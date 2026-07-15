Public Class frmRegister

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Register"
        Me.AcceptButton = btnRegister   ' Enter submits the registration
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If Not (String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtPassword.Text) Or String.IsNullOrEmpty(txtConfPassword.Text)) Then
            If Not String.Compare(txtPassword.Text, txtConfPassword.Text) = 0 Then
                MessageBox.Show("passwords do not match")
            ElseIf IsEmpNameExist(txtName.Text) Then
                MessageBox.Show("username already exist")
                txtName.Text = ""
            ElseIf RegisterEmployee(txtName.Text, txtPassword.Text) Then
                If Login(txtName.Text, txtPassword.Text) Then
                    DialogResult = DialogResult.OK
                    Close
                Else
                    MessageBox.Show("database error")
                End If
            Else
                MessageBox.Show("controller error")
            End If
        Else
            MessageBox.Show("pls fill login creds")
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        txtConfPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class