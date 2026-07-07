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
        selectedUC.Dock = DockStyle.None
        selectedUC.Size = pnlContent.ClientSize
        selectedUC.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
        pnlContent.Controls.Add(selectedUC)
        selectedUC.BringToFront()
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
        SessionManager.Logout()
        Me.Hide()
        Dim freshForm As New frmMain()
        freshForm.Show()
        Me.Close()
    End Sub

    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        SwitchScreen(New ucEmployees)
    End Sub
End Class
