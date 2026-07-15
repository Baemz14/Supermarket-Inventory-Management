Imports System.Drawing.Printing

Public Class ucSales
    Dim productTable As New DataTable()
    Dim ProductList As DataTable
    Dim selectedRow As DataRow

    ' One line in the current sale. We hold the tax rate here so the receipt can be
    ' built without going back to the database.
    Private Class CartLine
        Public ProductId As Integer
        Public Name As String
        Public UnitPrice As Decimal
        Public Qty As Integer
        Public TaxRate As Decimal

        Public ReadOnly Property Subtotal As Decimal
            Get
                Return UnitPrice * Qty
            End Get
        End Property

        Public ReadOnly Property Tax As Decimal
            Get
                Return Subtotal * TaxRate
            End Get
        End Property
    End Class

    Private ReadOnly cart As New List(Of CartLine)

    ' The most recently confirmed receipt, kept so the print handler can draw it.
    Private receiptLines As New List(Of String)

    Private Sub ucSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Give the cart columns readable headers and sensible widths.
        Product.Text = "Product"
        Qty.Text = "Qty"
        Price.Text = "Total"
        Product.Width = 180
        Qty.Width = 60
        Price.Width = 110

        loadProductList()
    End Sub

    Private Sub loadProductList()
        Try
            productTable = GetAllProducts()
        Catch ex As Exception
            MessageBox.Show("Error fetching data from database: " & ex.Message)
            Exit Sub
        End Try
        If productTable IsNot Nothing Then
            Dim columnsToKeep As String() = {"product_id", "product_name", "category", "unit_price", "quantity", "unit"}
            ProductList = productTable.DefaultView.ToTable("FilteredProducts", False, columnsToKeep)
            dgvProducts.DataSource = ProductList
            ApplyKeywordFilter()
        End If
    End Sub

    Private Sub ApplyKeywordFilter()
        If ProductList Is Nothing Then Return

        Dim keyword As String = txtKeyword.Text.Trim()
        Dim filterExpression As String = ""

        If keyword.Length > 0 Then
            Dim safe As String = EscapeLikeValue(keyword)
            filterExpression = "(product_name LIKE '%" & safe & "%' OR category LIKE '%" & safe & "%')"
        End If

        ProductList.DefaultView.RowFilter = filterExpression
    End Sub

    Private Sub txtKeyword_TextChanged(sender As Object, e As EventArgs) Handles txtKeyword.TextChanged
        ApplyKeywordFilter()
    End Sub

    Private Function GetSelectedProductRow() As DataRow
        If productTable Is Nothing OrElse dgvProducts.CurrentRow Is Nothing Then
            Return Nothing
        End If

        Dim idCell As Object = dgvProducts.CurrentRow.Cells("product_id").Value
        If idCell Is Nothing OrElse idCell Is DBNull.Value Then
            Return Nothing
        End If

        Dim matches() As DataRow = productTable.Select("product_id = " & Convert.ToInt32(idCell))
        If matches.Length = 0 Then
            Return Nothing
        End If
        Return matches(0)
    End Function

    Private Sub dgvProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProducts.SelectionChanged
        selectedRow = GetSelectedProductRow()
        If selectedRow Is Nothing Then
            Return
        End If

        lblProduct.Text = selectedRow("product_name").ToString()
        lblPrice.Text = Convert.ToDecimal(selectedRow("unit_price")).ToString("c")
        lblStockQuantity.Text = selectedRow("quantity").ToString()
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If selectedRow Is Nothing Then
            MessageBox.Show("Please select a product first.")
            Return
        End If

        Dim quantityToBuy As Integer
        If Not Integer.TryParse(txtQuantityToBuy.Text, quantityToBuy) OrElse quantityToBuy <= 0 Then
            MessageBox.Show("Please enter a valid quantity to buy.")
            Return
        End If

        Dim productId As Integer = Convert.ToInt32(selectedRow("product_id"))
        Dim stockQuantity As Integer = Convert.ToInt32(selectedRow("quantity"))

        ' If this product is already in the cart, the new amount stacks on top of
        ' what's there, so validate the combined quantity against stock.
        Dim existing As CartLine = cart.FirstOrDefault(Function(c) c.ProductId = productId)
        Dim alreadyInCart As Integer = If(existing IsNot Nothing, existing.Qty, 0)

        If quantityToBuy + alreadyInCart > stockQuantity Then
            MessageBox.Show($"Not enough stock available. In stock: {stockQuantity}, already in cart: {alreadyInCart}.")
            Return
        End If

        If existing IsNot Nothing Then
            existing.Qty += quantityToBuy
        Else
            cart.Add(New CartLine With {
                .ProductId = productId,
                .Name = selectedRow("product_name").ToString(),
                .UnitPrice = Convert.ToDecimal(selectedRow("unit_price")),
                .Qty = quantityToBuy,
                .TaxRate = Convert.ToDecimal(selectedRow("tax_rate"))
            })
        End If

        RefreshCartView()
        txtQuantityToBuy.Text = ""
    End Sub

    ' Double-click a cart row to remove it (handy when the cashier miskeys).
    Private Sub lvCart_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvCart.MouseDoubleClick
        If lvCart.SelectedItems.Count = 0 Then Return
        Dim index As Integer = lvCart.SelectedItems(0).Index
        If index >= 0 AndAlso index < cart.Count Then
            cart.RemoveAt(index)
            RefreshCartView()
        End If
    End Sub

    ' Rebuild the ListView from the cart list so display and data never drift apart.
    Private Sub RefreshCartView()
        lvCart.Items.Clear()
        For Each line In cart
            Dim item As New ListViewItem(line.Name)
            item.SubItems.Add(line.Qty.ToString())
            item.SubItems.Add(line.Subtotal.ToString("c"))
            lvCart.Items.Add(item)
        Next
    End Sub

    Private Sub btnConfirmTransaction_Click(sender As Object, e As EventArgs) Handles btnConfirmTransaction.Click
        If cart.Count = 0 Then
            MessageBox.Show("The cart is empty.")
            Return
        End If

        If Not SessionManager.IsLoggedIn Then
            MessageBox.Show("You must be logged in to complete a sale.")
            Return
        End If

        ' Re-check stock against the live database right before committing, in case
        ' quantities changed since the products were loaded. This makes it far less
        ' likely we'll get halfway through a sale and hit an out-of-stock item.
        Dim freshProducts As DataTable
        Try
            freshProducts = GetAllProducts()
        Catch ex As Exception
            MessageBox.Show("Could not verify stock: " & ex.Message)
            Return
        End Try

        For Each line In cart
            Dim matches() As DataRow = freshProducts.Select("product_id = " & line.ProductId)
            If matches.Length = 0 Then
                MessageBox.Show($"'{line.Name}' no longer exists. Please remove it from the cart.")
                Return
            End If
            Dim liveStock As Integer = Convert.ToInt32(matches(0)("quantity"))
            If line.Qty > liveStock Then
                MessageBox.Show($"Not enough stock for '{line.Name}'. In stock: {liveStock}, in cart: {line.Qty}.")
                Return
            End If
        Next

        ' Deduct each product as a "Sold" stock change, logged against the cashier.
        Try
            For Each line In cart
                ChangeProductQuantity(line.ProductId, -line.Qty, SessionManager.CurrentId, "Sold")
            Next
        Catch ex As Exception
            MessageBox.Show("The sale could not be completed: " & ex.Message &
                            vbCrLf & "Some items may already have been deducted; please check the stock.")
            loadProductList()
            Return
        End Try

        BuildReceipt()
        ShowReceipt()

        cart.Clear()
        RefreshCartView()
        loadProductList()
    End Sub

    ' Compose the receipt as a list of plain-text lines, reused for both the
    ' preview and the printout.
    Private Sub BuildReceipt()
        receiptLines = New List(Of String)()

        Dim subtotal As Decimal = cart.Sum(Function(c) c.Subtotal)
        Dim taxTotal As Decimal = cart.Sum(Function(c) c.Tax)
        Dim grandTotal As Decimal = subtotal + taxTotal

        receiptLines.Add("      SUPERMARKET RECEIPT")
        receiptLines.Add(New String("-"c, 34))
        receiptLines.Add("Date: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm"))
        receiptLines.Add("Cashier: " & SessionManager.CurrentUsername)
        receiptLines.Add(New String("-"c, 34))

        For Each line In cart
            receiptLines.Add(line.Name)
            Dim detail As String = $"  {line.Qty} x {line.UnitPrice:c}"
            receiptLines.Add(PadLine(detail, line.Subtotal.ToString("c")))
        Next

        receiptLines.Add(New String("-"c, 34))
        receiptLines.Add(PadLine("Subtotal", subtotal.ToString("c")))
        receiptLines.Add(PadLine("Tax", taxTotal.ToString("c")))
        receiptLines.Add(PadLine("TOTAL", grandTotal.ToString("c")))
        receiptLines.Add(New String("-"c, 34))
        receiptLines.Add("      Thank you for shopping!")
    End Sub

    ' Left-justify a label and right-justify a value within a fixed 34-char width.
    Private Function PadLine(leftText As String, rightText As String) As String
        Const width As Integer = 34
        Dim spaces As Integer = Math.Max(1, width - leftText.Length - rightText.Length)
        Return leftText & New String(" "c, spaces) & rightText
    End Function

    ' Show a print preview; the dialog's toolbar has the Print button, which
    ' satisfies both "print the receipt" and "let the user print it".
    Private Sub ShowReceipt()
        Dim doc As New PrintDocument()
        doc.DocumentName = "Sales Receipt"
        AddHandler doc.PrintPage, AddressOf ReceiptPrintPage

        Using preview As New PrintPreviewDialog()
            preview.Document = doc
            preview.Width = 600
            preview.Height = 800
            preview.ShowDialog()
        End Using
    End Sub

    Private Sub ReceiptPrintPage(sender As Object, e As PrintPageEventArgs)
        Using font As New Font("Consolas", 10)
            Dim y As Single = e.MarginBounds.Top
            Dim lineHeight As Single = font.GetHeight(e.Graphics)
            For Each lineText In receiptLines
                e.Graphics.DrawString(lineText, font, Brushes.Black, e.MarginBounds.Left, y)
                y += lineHeight
            Next
        End Using
    End Sub
End Class
