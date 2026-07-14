Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not SessionManager.IsLoggedIn Then
            Using loginWindow As New frmLogin()
                Dim authResult As DialogResult = loginWindow.ShowDialog()
                If authResult = DialogResult.OK Then
                    SwitchScreen(New ucView)
                Else
                    Application.Exit()
                End If

            End Using
            Return
        End If

        SwitchScreen(New ucDashboard)
    End Sub

    Private Sub SwitchScreen(ByVal selectedUC As UserControl)
        pnlContent.Controls.Clear()
        pnlContent.AutoScroll = True
        ' Each screen lays itself out with TableLayoutPanels, so it can simply fill
        ' the window. Below the screen's MinimumSize the panel shows scrollbars.
        selectedUC.Dock = DockStyle.Fill
        pnlContent.Controls.Add(selectedUC)
    End Sub

    Private Sub mnuDashboard_Click(sender As Object, e As EventArgs) Handles mnuDashboard.Click
        SwitchScreen(New ucDashboard)
    End Sub

    Private Sub mnuView_Click(sender As Object, e As EventArgs) Handles mnuView.Click
        SwitchScreen(New ucView)
    End Sub

    Private Sub mnuAddProduct_Click(sender As Object, e As EventArgs) Handles mnuAddProduct.Click
        SwitchScreen(New ucProductForm)
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        ' Re-authenticate on this same window instead of opening a new frmMain and
        ' closing this one. Closing this form would shut the whole app down (the
        ' shutdown mode is "exit after the main form closes"), which was the logout bug.
        SessionManager.Logout()
        pnlContent.Controls.Clear()
        Me.Hide()

        Using loginWindow As New frmLogin()
            If loginWindow.ShowDialog() = DialogResult.OK Then
                SwitchScreen(New ucView)
                Me.Show()
            Else
                Application.Exit()
            End If
        End Using
    End Sub

    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        SwitchScreen(New ucEmployees)
    End Sub
End Class
