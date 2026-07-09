Public Class ucEmployees
    Dim employeeTable As New DataTable()
    Dim selectedEmployeeId As Integer = -1
    Dim selectedEmployeeChanges As New DataTable()

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
        If dgvEmployees.CurrentRow Is Nothing Then
            Exit Sub
        End If

        selectedEmployeeId = dgvEmployees.CurrentRow.Cells("employee_id").Value
        If selectedEmployeeId = -1 Then
            Exit Sub
        End If

        Try
            selectedEmployeeChanges = GetEmployeeChanges(selectedEmployeeId)
        Catch ex As Exception
            MessageBox.Show("Error fetching employee changes: " & ex.Message)
            Exit Sub
        End Try

        If selectedEmployeeChanges IsNot Nothing Then
            dgvEmployeeChanges.DataSource = selectedEmployeeChanges
        End If
    End Sub
End Class
