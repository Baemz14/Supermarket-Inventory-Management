Public Class ucDashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("henlo")
    End Sub

    Private Sub ucDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = SessionManager.CurrentUsername
    End Sub
End Class
