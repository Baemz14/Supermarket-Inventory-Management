Public Class frmRegister
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If Not (String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtPassword.Text) Or String.IsNullOrEmpty(txtConfPassword.Text)) Then
            If Not String.Compare(txtPassword.Text, txtConfPassword.Text) = 0 Then
                MessageBox.Show("passwords do not match")
            ElseIf ProductController.IsEmpNameExist(txtName.Text) Then
                MessageBox.Show("username already exist")
                txtName.Text = ""
            ElseIf ProductController.RegisterEmployee(txtName.Text, txtPassword.Text) Then
                If SessionManager.Login(txtName.Text, txtPassword.Text) Then
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class