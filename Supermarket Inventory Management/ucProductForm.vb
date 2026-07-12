Public Class ucProductForm

    Private Sub ucProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDropdowns()
    End Sub

    ' Fills the Category and Supplier dropdowns from the database.
    Private Sub LoadDropdowns()
        Try
            Dim categories As DataTable = GetAllCategories()
            cboCategory.DisplayMember = "category_name"
            cboCategory.ValueMember = "category_id"
            cboCategory.DataSource = categories

            Dim suppliers As DataTable = GetAllSuppliers()
            cboSupplier.DisplayMember = "supplier_name"
            cboSupplier.ValueMember = "supplier_id"
            cboSupplier.DataSource = suppliers
        Catch ex As Exception
            MessageBox.Show("Could not load categories/suppliers: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim name As String = txtProductName.Text.Trim()
        If name.Length = 0 Then
            MessageBox.Show("Please enter a product name.")
            Return
        End If

        If cboCategory.SelectedValue Is Nothing OrElse cboSupplier.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a category and a supplier. (Add one first if the list is empty.)")
            Return
        End If

        Dim unit As String = txtUnit.Text.Trim()
        If unit.Length = 0 Then
            MessageBox.Show("Please enter a unit (e.g. kg, unit, bottle).")
            Return
        End If

        Try
            Dim categoryId As Integer = Convert.ToInt32(cboCategory.SelectedValue)
            Dim supplierId As Integer = Convert.ToInt32(cboSupplier.SelectedValue)
            Dim unitPrice As Decimal = numUnitPrice.Value
            Dim quantity As Integer = CInt(numQuantity.Value)
            Dim reorderThreshold As Integer = CInt(numReorderThreshold.Value)
            Dim bulkQuantity As Integer = CInt(numBulkQuantity.Value)
            Dim bulkDiscount As Decimal = numBulkDiscount.Value / 100D   ' entered as %, stored as a 0-1 rate

            If AddProduct(name, supplierId, categoryId, unitPrice, quantity, unit,
                          reorderThreshold, bulkQuantity, bulkDiscount) Then
                MessageBox.Show("Product added successfully.")
                ResetForm()
            Else
                MessageBox.Show("Failed to add product.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message)
        End Try
    End Sub

    Private Sub ResetForm()
        txtProductName.Clear()
        txtUnit.Clear()
        numUnitPrice.Value = 0
        numQuantity.Value = 0
        numReorderThreshold.Value = 0
        numBulkQuantity.Value = 0
        numBulkDiscount.Value = 0
        If cboCategory.Items.Count > 0 Then cboCategory.SelectedIndex = 0
        If cboSupplier.Items.Count > 0 Then cboSupplier.SelectedIndex = 0
    End Sub

End Class
