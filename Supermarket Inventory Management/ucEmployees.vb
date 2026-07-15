Public Class ucEmployees
    Dim employeeTable As New DataTable()
    Dim selectedEmployeeId As Integer = -1
    Dim selectedEmployeeChanges As New DataTable()

    Dim selectedChange As DataRow

    Private Sub ucEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTheme.StyleScreen(Me)
        UiTheme.StyleGrid(dgvEmployees)
        UiTheme.StyleGrid(dgvEmployeeChanges)

        For Each valueLabel In {lblProduct, lblReason, lblChangedAnswer, lblBeforeAnswer, lblAfterAnswer}
            UiTheme.StyleValueLabel(valueLabel)
        Next

        Try
            employeeTable = GetAllEmployees()
        Catch ex As Exception
            MessageBox.Show("Error fetching data from database: " & ex.Message)
            Exit Sub
        End Try

        If employeeTable IsNot Nothing Then
            dgvEmployees.DataSource = employeeTable
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If

        cboReasonFilter.SelectedIndex = 0   ' "(All)"
    End Sub

    Private Sub dgvEmployees_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEmployees.SelectionChanged
        If dgvEmployees.CurrentRow Is Nothing Then
            ' Nothing selected (e.g. the keyword filter matched no employees) - clear the changes list.
            selectedEmployeeId = -1
            selectedEmployeeChanges = New DataTable()
            dgvEmployeeChanges.DataSource = Nothing
            selectedChange = Nothing
            refreshChangesInfo()
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
            dgvEmployeeChanges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            ApplyChangesFilter()   ' keep the active keyword/reason filter when switching employees
        End If
    End Sub

    Private Sub txtEmployeeKeyword_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeKeyword.TextChanged
        If employeeTable Is Nothing Then Return

        Dim keyword As String = txtEmployeeKeyword.Text.Trim()
        If keyword.Length = 0 Then
            employeeTable.DefaultView.RowFilter = ""
        Else
            employeeTable.DefaultView.RowFilter =
                "employee_name LIKE '%" & EscapeLikeValue(keyword) & "%'"
        End If
    End Sub

    Private Sub txtChangesKeyword_TextChanged(sender As Object, e As EventArgs) Handles txtChangesKeyword.TextChanged
        ApplyChangesFilter()
    End Sub

    Private Sub cboReasonFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReasonFilter.SelectedIndexChanged
        ApplyChangesFilter()
    End Sub

    ' Filters the changes grid by product-name keyword and/or the selected change reason.
    Private Sub ApplyChangesFilter()
        If selectedEmployeeChanges Is Nothing OrElse selectedEmployeeChanges.Columns.Count = 0 Then Return

        Dim filters As New List(Of String)()

        Dim keyword As String = txtChangesKeyword.Text.Trim()
        If keyword.Length > 0 Then
            filters.Add("[Product] LIKE '%" & EscapeLikeValue(keyword) & "%'")
        End If

        ' Index 0 is "(All)", which means no reason filter.
        If cboReasonFilter.SelectedIndex > 0 Then
            filters.Add("[Reason] = '" & cboReasonFilter.SelectedItem.ToString().Replace("'", "''") & "'")
        End If

        selectedEmployeeChanges.DefaultView.RowFilter = String.Join(" AND ", filters)
    End Sub

    Private Sub dgvEmployees_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvEmployees.DataBindingComplete
        If dgvEmployees.Columns.Contains("employee_id") Then
            dgvEmployees.Columns("employee_id").Visible = False
        End If
        If dgvEmployees.Columns.Contains("employee_name") Then
            dgvEmployees.Columns("employee_name").HeaderText = "Employee"
        End If
    End Sub

    Private Sub dgvEmployeeChanges_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEmployeeChanges.SelectionChanged
        If dgvEmployeeChanges.CurrentRow IsNot Nothing AndAlso dgvEmployeeChanges.CurrentRow.DataBoundItem IsNot Nothing Then
            Dim rowView As DataRowView = CType(dgvEmployeeChanges.CurrentRow.DataBoundItem, DataRowView)
            selectedChange = rowView.Row
        Else
            selectedChange = Nothing
        End If

        refreshChangesInfo()
    End Sub

    Private Sub refreshChangesInfo()
        If selectedChange Is Nothing Then
            lblAfterAnswer.Text = ""
            lblBeforeAnswer.Text = ""
            lblChangedAnswer.Text = ""
            lblProduct.Text = ""
            lblReason.Text = ""
            Exit Sub
        End If

        Dim reason As String = selectedChange("Reason")
        If reason = "Price Change" Then
            lblAfter.Text = "Price After:"
            lblBefore.Text = "Price Before:"
            lblChanged.Text = "Price Changed:"

            Dim priceAfter As Decimal = Convert.ToDecimal(selectedChange("Price After"))
            Dim priceChanged As Decimal = Convert.ToDecimal(selectedChange("Price Changed"))

            lblChangedAnswer.Text = priceChanged.ToString("c")
            lblBeforeAnswer.Text = (priceAfter - priceChanged).ToString("c")
            lblAfterAnswer.Text = priceAfter.ToString("c")
        Else
            lblAfter.Text = "Quantity After:"
            lblBefore.Text = "Quantity Before:"
            lblChanged.Text = "Quantity Changed:"

            Dim qtyAfter As Decimal = Convert.ToDecimal(selectedChange("Qty After"))
            Dim qtyChanged As Decimal = Convert.ToDecimal(selectedChange("Qty Changed"))

            lblChangedAnswer.Text = qtyChanged.ToString("n0")
            lblBeforeAnswer.Text = (qtyAfter - qtyChanged).ToString("n0")
            lblAfterAnswer.Text = qtyAfter.ToString("n0")
        End If

        lblProduct.Text = selectedChange("Product")
        lblReason.Text = reason
    End Sub
End Class
