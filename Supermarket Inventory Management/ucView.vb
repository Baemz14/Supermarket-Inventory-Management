Public Class ucView
    Dim productTable As New DataTable()
    Dim ProductList As DataTable

    Private Sub ucView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            productTable = GetAllProducts()
        Catch ex As Exception
            MessageBox.Show("Error fetching data from database: " & ex.Message)
            Exit Sub ' Stop early if the database fails to prevent null assignment crashes
        End Try

        If productTable IsNot Nothing Then
            Dim columnsToKeep As String() = {"product_id", "product_name", "unit_price", "quantity", "unit", "reorder_treshold"}
            ProductList = productTable.DefaultView.ToTable("FilteredProducts", False, columnsToKeep)
            dgvProducts.DataSource = ProductList
        End If
    End Sub

    Private Sub txtKeyword_TextChanged(sender As Object, e As EventArgs) Handles txtKeyword.TextChanged
        'TODO: Implement search functionality based on the keyword entered in txtKeyword
    End Sub

    Private Sub dgvProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProducts.SelectionChanged
        If dgvProducts.SelectedRows.Count <= 0 Then
            Return
        End If

        'TODO: Implement functionality to display supplier data n form stuffs
    End Sub

End Class
