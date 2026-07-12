Public Class ucView
    Dim productTable As New DataTable()
    Dim ProductList As DataTable
    Dim selectedRow As DataRow

    Private Sub ucView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim columnsToKeep As String() = {"product_id", "product_name", "unit_price", "quantity", "unit", "reorder_treshold", "category", "tax_rate"}
            ProductList = productTable.DefaultView.ToTable("FilteredProducts", False, columnsToKeep)
            dgvProducts.DataSource = ProductList
            ApplyKeywordFilter()   ' keep any active search applied after a reload
        End If
    End Sub

    Private Sub txtKeyword_TextChanged(sender As Object, e As EventArgs) Handles txtKeyword.TextChanged
        ApplyKeywordFilter()
    End Sub

    ' Filters the product grid by the search keyword, matching product name or category.
    Private Sub ApplyKeywordFilter()
        If ProductList Is Nothing Then Return

        Dim keyword As String = txtKeyword.Text.Trim()
        If keyword.Length = 0 Then
            ProductList.DefaultView.RowFilter = ""
        Else
            Dim safe As String = EscapeLikeValue(keyword)
            ProductList.DefaultView.RowFilter =
                "product_name LIKE '%" & safe & "%' OR category LIKE '%" & safe & "%'"
        End If
    End Sub

    ' Escapes characters that are special inside a DataView RowFilter LIKE expression.
    Private Shared Function EscapeLikeValue(value As String) As String
        Dim sb As New System.Text.StringBuilder()
        For Each c As Char In value
            Select Case c
                Case "'"c
                    sb.Append("''")
                Case "["c, "]"c, "%"c, "*"c
                    sb.Append("["c).Append(c).Append("]"c)
                Case Else
                    sb.Append(c)
            End Select
        Next
        Return sb.ToString()
    End Function

    Private Sub dgvProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProducts.SelectionChanged
        resetQuantityChange()
        resetPriceChange()
        resetBulkBuy()

        ' Match by product_id (not grid row index) so selection stays correct while filtering/sorting.
        selectedRow = GetSelectedProductRow()
        If selectedRow Is Nothing Then
            Return
        End If

        lblSupplier.Text = selectedRow("supplier")
        lblDiscount.Text = (selectedRow("bulk_discount_rate") * 100).ToString()
        lblMinBulk.Text = selectedRow("bulk_quantity").ToString()

        Dim unit As String = selectedRow("unit")
        lblUnitInQuantity.Text = unit
        lblUnitInSupplier.Text = unit

        lblQuantity.Text = selectedRow("quantity").ToString()
        lblPrice.Text = selectedRow("unit_price").ToString()
    End Sub

    ' Returns the full data row for the currently selected grid row, matched by product_id.
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

    Private Sub btnResetQuantity_Click(sender As Object, e As EventArgs) Handles btnResetQuantity.Click
        resetQuantityChange()
    End Sub

    Private Sub resetQuantityChange()
        txtQuantityChange.Text = ""
        cboReason.SelectedIndex = -1
    End Sub

    Private Sub btnPriceReset_Click(sender As Object, e As EventArgs) Handles btnPriceReset.Click
        resetPriceChange()
    End Sub

    Private Sub resetPriceChange()
        txtNewPrice.Text = ""
    End Sub

    Private Sub btnBulkBuyReset_Click(sender As Object, e As EventArgs) Handles btnBulkBuyReset.Click
        resetBulkBuy()
    End Sub

    Private Sub resetBulkBuy()
        lblBulkPrice.Text = ""
        lblBulkDiscountPrice.Text = ""
        lblPriceAfterBulk.Text = ""
        txtQuantityBuy.Text = ""
    End Sub

    Private Sub txtQuantityBuy_TextChanged(sender As Object, e As EventArgs) Handles txtQuantityBuy.TextChanged
        If selectedRow Is Nothing Then
            Return
        End If

        Dim quantity As Decimal = 0
        Dim quantString As String = txtQuantityBuy.Text
        Decimal.TryParse(quantString, quantity)

        Dim price As Decimal = quantity * selectedRow("unit_price")
        Dim bulkDiscount As Decimal = 0
        If quantity >= selectedRow("bulk_quantity") Then
            bulkDiscount = price * (selectedRow("bulk_discount_rate"))
        End If
        lblBulkPrice.Text = price.ToString("c")
        lblBulkDiscountPrice.Text = bulkDiscount.ToString("c")
        lblPriceAfterBulk.Text = (price - bulkDiscount).ToString("c")
    End Sub

    Private Function isPositiveChange(reason As String) As Boolean
        Dim positiveReason() As String = {
            "Arrived", "Customer Return", "Audit Correction"
        }
        Dim negativeReason() As String = {
            "Sold", "Removed", "Damaged", "Expired",
            "Shrinkage", "Internal Usage"
        }

        If positiveReason.Contains(reason) Then
            Return True
        ElseIf negativeReason.Contains(reason) Then
            Return False
        End If

        Throw New Exception("reason passed not correct")

    End Function

    Private Sub cboReason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReason.SelectedIndexChanged
        If cboReason.SelectedIndex = -1 Then
            lblQuantChangeIsPos.Text = "(+/-)"
        ElseIf (isPositiveChange(cboReason.SelectedItem.ToString())) Then
            lblQuantChangeIsPos.Text = "(+)"
        Else
            lblQuantChangeIsPos.Text = "(-)"
        End If
    End Sub

    Private Sub btnQuantityConfirm_Click(sender As Object, e As EventArgs) Handles btnQuantityConfirm.Click
        If selectedRow Is Nothing Then
            MessageBox.Show("No product selected.")
            Return
        End If

        If cboReason.SelectedIndex = -1 Then
            MessageBox.Show("Please select a reason for the quantity change.")
            Return
        ElseIf txtQuantityChange.Text = "" Then
            MessageBox.Show("Please enter a quantity change.")
            Return
        End If

        Dim quantityChange As Decimal
        If Not Decimal.TryParse(txtQuantityChange.Text, quantityChange) Then
            MessageBox.Show("Please enter a valid numeric value for the quantity change.")
            Return
        End If

        Dim reason As String = cboReason.SelectedItem.ToString()
        quantityChange = If(isPositiveChange(reason), quantityChange, -quantityChange)

        Dim isSuccess As Boolean = ChangeProductQuantity(selectedRow("product_id"), quantityChange, SessionManager.CurrentId, reason)
        If isSuccess Then
            MessageBox.Show("Quantity change applied successfully.")
            resetQuantityChange()
            loadProductList()
        Else
            MessageBox.Show("Failed to apply quantity change.")
        End If
    End Sub

    Private Sub btnPriceConfirm_Click(sender As Object, e As EventArgs) Handles btnPriceConfirm.Click
        If selectedRow Is Nothing Then
            MessageBox.Show("No product selected.")
            Return
        End If

        If txtNewPrice.Text = "" Then
            MessageBox.Show("Please enter a new price.")
            Return
        End If

        Dim newPrice As Decimal
        If Not Decimal.TryParse(txtNewPrice.Text, newPrice) Then
            MessageBox.Show("Please enter a valid numeric value for the new price.")
            Return
        End If

        Dim isSuccess As Boolean = ChangeProductPrice(selectedRow("product_id"), newPrice, SessionManager.CurrentId)
        If isSuccess Then
            MessageBox.Show("Price change applied successfully.")
            resetPriceChange()
            loadProductList()
        Else
            MessageBox.Show("Failed to apply price change.")
        End If
    End Sub

    Private Sub btnBulkBuyConfirm_Click(sender As Object, e As EventArgs) Handles btnBulkBuyConfirm.Click
        If selectedRow Is Nothing Then
            MessageBox.Show("No product selected.")
            Return
        End If

        If txtQuantityBuy.Text = "" Then
            MessageBox.Show("Please enter a quantity to buy.")
            Return
        End If

        Dim quantityToBuy As Decimal
        If Not Decimal.TryParse(txtQuantityBuy.Text, quantityToBuy) Then
            MessageBox.Show("Please enter a valid numeric value for the quantity to buy.")
            Return
        End If

        Dim isSuccess As Boolean = ChangeProductQuantity(selectedRow("product_id"), quantityToBuy, SessionManager.CurrentId, "Bulk Buy")
        If isSuccess Then
            Dim basePrice As Decimal = quantityToBuy * Convert.ToDecimal(selectedRow("unit_price"))
            Dim bulkDiscount As Decimal = 0
            Dim isDiscountApplied As Boolean = False

            If quantityToBuy >= Convert.ToDecimal(selectedRow("bulk_quantity")) Then
                bulkDiscount = basePrice * Convert.ToDecimal(selectedRow("bulk_discount_rate"))
                isDiscountApplied = True
            End If

            Dim finalPrice As Decimal = basePrice - bulkDiscount

            Dim receipt As New System.Text.StringBuilder()
            receipt.AppendLine("Purchase Successful!")
            receipt.AppendLine("----------------------------------------")
            receipt.AppendLine(String.Format("Item: {0}", selectedRow("product_name")))
            receipt.AppendLine(String.Format("Quantity: {0} {1}", quantityToBuy, selectedRow("unit")))
            receipt.AppendLine(String.Format("Original Total: {0:c}", basePrice))

            If isDiscountApplied Then
                Dim discountPercent As Decimal = Convert.ToDecimal(selectedRow("bulk_discount_rate")) * 100
                receipt.AppendLine(String.Format("Bulk Discount ({0}%): -{1:c}", discountPercent, bulkDiscount))
            Else
                receipt.AppendLine("Bulk Discount: None (Threshold not met)")
            End If

            receipt.AppendLine("----------------------------------------")
            receipt.AppendLine(String.Format("Total Paid: {0:c}", finalPrice))

            MessageBox.Show(receipt.ToString(), "Purchase Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)

            resetBulkBuy()
            loadProductList()
        Else
            MessageBox.Show("Failed to apply bulk purchase.")
        End If
    End Sub

    ' Applies friendly column headers and highlights low-stock rows. Runs whenever the grid
    ' (re)binds, which includes after a search filter changes.
    Private Sub dgvProducts_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvProducts.DataBindingComplete
        SetProductHeader("product_id", "ID")
        SetProductHeader("product_name", "Product")
        SetProductHeader("category", "Category")
        SetProductHeader("unit_price", "Unit Price")
        SetProductHeader("quantity", "Qty")
        SetProductHeader("unit", "Unit")
        SetProductHeader("reorder_treshold", "Reorder At")
        SetProductHeader("tax_rate", "Tax Rate")

        ' Flag rows where stock has dropped to or below the reorder threshold.
        For Each row As DataGridViewRow In dgvProducts.Rows
            Dim qty As Object = row.Cells("quantity").Value
            Dim reorder As Object = row.Cells("reorder_treshold").Value
            If IsNumeric(qty) AndAlso IsNumeric(reorder) AndAlso Convert.ToDecimal(qty) <= Convert.ToDecimal(reorder) Then
                row.DefaultCellStyle.BackColor = Color.MistyRose
                row.DefaultCellStyle.ForeColor = Color.Firebrick
            Else
                row.DefaultCellStyle.BackColor = Color.Empty
                row.DefaultCellStyle.ForeColor = Color.Empty
            End If
        Next
    End Sub

    Private Sub SetProductHeader(columnName As String, headerText As String)
        If dgvProducts.Columns.Contains(columnName) Then
            dgvProducts.Columns(columnName).HeaderText = headerText
        End If
    End Sub
End Class
