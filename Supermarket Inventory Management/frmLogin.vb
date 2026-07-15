Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Login"
        Me.AcceptButton = btnLogin
    End Sub

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

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not (String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtPassword.Text)) Then
            If SessionManager.Login(txtName.Text, txtPassword.Text) Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Login Credential Incorrect")
            End If
        Else
            MessageBox.Show("Please Fill Up Login Credentials")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class