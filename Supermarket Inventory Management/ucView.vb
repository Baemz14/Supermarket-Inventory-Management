Public Class ucView
    Dim productTable As New DataTable()
    Dim ProductList As DataTable
    Dim selectedRow As DataRow

    Private Sub ucView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            productTable = GetAllProducts()
        Catch ex As Exception
            MessageBox.Show("Error fetching data from database: " & ex.Message)
            Exit Sub ' Stop early if the database fails to prevent null assignment crashes
        End Try

        If productTable IsNot Nothing Then
            Dim columnsToKeep As String() = {"product_id", "product_name", "unit_price", "quantity", "unit", "reorder_treshold", "category", "tax_rate"}
            ProductList = productTable.DefaultView.ToTable("FilteredProducts", False, columnsToKeep)
            dgvProducts.DataSource = ProductList
        End If
    End Sub

    Private Sub txtKeyword_TextChanged(sender As Object, e As EventArgs) Handles txtKeyword.TextChanged
        'TODO: Implement search functionality based on the keyword entered in txtKeyword
    End Sub

    Private Sub dgvProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProducts.SelectionChanged
        resetQuantityChange()
        resetPriceChange()
        resetBulkBuy()

        If dgvProducts.SelectedRows.Count <= 0 Then
            Return
        End If

        selectedRow = productTable.Rows(dgvProducts.CurrentRow.Index)
        lblSupplier.Text = selectedRow("supplier")
        lblDiscount.Text = (selectedRow("bulk_discount_rate") * 100).ToString()
        lblMinBulk.Text = selectedRow("bulk_quantity").ToString()

        Dim unit As String = selectedRow("unit")
        lblUnitInQuantity.Text = unit
        lblUnitInSupplier.Text = unit

        lblQuantity.Text = selectedRow("quantity").ToString()
        lblPrice.Text = selectedRow("unit_price").ToString()
    End Sub

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

    Private Sub btnQuantityConfirm_Click(sender As Object, e As EventArgs) Handles btnQuantityConfirm.Click
        'TODO
    End Sub

    Private Sub btnPriceConfirm_Click(sender As Object, e As EventArgs) Handles btnPriceConfirm.Click
        'TODO
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

    Private Sub btnBulkBuyConfirm_Click(sender As Object, e As EventArgs) Handles btnBulkBuyConfirm.Click
        'TODO
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
End Class
