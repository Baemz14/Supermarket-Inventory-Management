Public Class ucView
    Private Sub ucView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim productTable As DataTable = GetAllProducts()
            dgvProducts.DataSource = productTable

        Catch ex As Exception
            MessageBox.Show("Error loading grid: " & ex.Message)
        End Try
    End Sub
End Class
