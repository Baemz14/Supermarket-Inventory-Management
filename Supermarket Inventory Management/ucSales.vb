Imports System.Windows.Forms.DataVisualization

Public Class ucSales
    Dim productTable As New DataTable()
    Dim ProductList As DataTable
    Dim selectedRow As DataRow

    Private Sub ucSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        lblProduct.Text = selectedRow("product_name")
        lblPrice.Text = selectedRow("unit_price").ToString()
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
        Dim stockQuantity As Integer = Convert.ToInt32(selectedRow("quantity"))
        If quantityToBuy > stockQuantity Then
            MessageBox.Show("Not enough stock available.")
            Return
        End If

        Dim item As New ListViewItem(selectedRow("product_name").ToString())

        ' 2. Add sub-items for the remaining columns across the row layout
        item.SubItems.Add(selectedRow("unit_price").ToString("c"))
        item.SubItems.Add(quantityToBuy.ToString())
        item.SubItems.Add((quantityToBuy * Convert.ToDecimal(selectedRow("unit_price"))).ToString("c"))

        ' 3. Drop the completed row directly into the scrollable list container matrix
        lvCart.Items.Add(item)

        txtQuantityToBuy.Text = ""
    End Sub
End Class
