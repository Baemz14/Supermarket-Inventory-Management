Public Class ucDashboard

    Private Sub ucDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTheme.StyleScreen(Me)
        UiTheme.StyleGrid(dgvMyChanges)
        lblTitle.ForeColor = UiTheme.Primary

        lblUsernameValue.Text = SessionManager.CurrentUsername
        lblEmployeeIdValue.Text = SessionManager.CurrentId.ToString()

        Try
            ' Same query the Employees screen uses, but scoped to whoever is logged in.
            Dim myChanges As DataTable = GetEmployeeChanges(SessionManager.CurrentId)
            dgvMyChanges.DataSource = myChanges
            dgvMyChanges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            lblChangesValue.Text = myChanges.Rows.Count.ToString()
            If myChanges.Rows.Count > 0 Then
                ' Rows come back newest first, so row 0 is the latest activity.
                lblLastActiveValue.Text = myChanges.Rows(0)("Date").ToString() & " " & myChanges.Rows(0)("Time").ToString()
            Else
                lblLastActiveValue.Text = "No changes yet"
            End If
        Catch ex As Exception
            MessageBox.Show("Error fetching your changes: " & ex.Message)
        End Try
    End Sub

End Class
