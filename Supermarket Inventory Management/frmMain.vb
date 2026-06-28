Public Class frmMain
    Private Sub SwitchScreen(ByVal selectedUC As UserControl)
        pnlContent.Controls.Clear()
        selectedUC.Dock = DockStyle.Fill
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

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchScreen(New ucDashboard)
    End Sub
End Class
