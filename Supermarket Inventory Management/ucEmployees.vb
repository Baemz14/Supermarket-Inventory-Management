Public Class ucEmployees
    Dim employeeTable As New DataTable()
    Dim selectedEmployeeId As Integer = -1

    Private Sub ucEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            employeeTable = GetAllEmployees()
        Catch ex As Exception
            MessageBox.Show("Error fetching data from database: " & ex.Message)
            Exit Sub
        End Try

        If employeeTable IsNot Nothing Then
            dgvEmployees.DataSource = employeeTable
        End If
    End Sub

    Private Sub dgvEmployees_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEmployees.SelectionChanged
        ' TODO
    End Sub
End Class
