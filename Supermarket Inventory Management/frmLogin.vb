Public Class frmLogin

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()

        Using registerWindow As New frmRegister()
            Dim regResult As DialogResult = registerWindow.ShowDialog()
            If regResult = DialogResult.OK Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                Me.Show()
            End If
        End Using
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not (String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtPassword.Text)) Then
            If SessionManager.Login(txtName.Text, txtPassword.Text) Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("login credential wrong")
            End If
        Else
            MessageBox.Show("pls fill login creds")
        End If
    End Sub
End Class