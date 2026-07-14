<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtName = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        Label4 = New Label()
        btnRegister = New Button()
        chkShowPassword = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(196, 28)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 0
        Label1.Text = "login form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(110, 97)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 20)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(114, 140)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(196, 97)
        txtName.Margin = New Padding(2, 2, 2, 2)
        txtName.Name = "txtName"
        txtName.Size = New Size(121, 27)
        txtName.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(196, 140)
        txtPassword.Margin = New Padding(2, 2, 2, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(121, 27)
        txtPassword.TabIndex = 4
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(196, 203)
        btnLogin.Margin = New Padding(2, 2, 2, 2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(90, 27)
        btnLogin.TabIndex = 6
        btnLogin.Text = "login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(222, 251)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(25, 20)
        Label4.TabIndex = 7
        Label4.Text = "Or"
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(153, 288)
        btnRegister.Margin = New Padding(2, 2, 2, 2)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(163, 27)
        btnRegister.TabIndex = 8
        btnRegister.Text = "Register new account"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(196, 170)
        chkShowPassword.Margin = New Padding(2, 2, 2, 2)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(134, 24)
        chkShowPassword.TabIndex = 5
        chkShowPassword.Text = "Show password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(844, 439)
        Controls.Add(btnRegister)
        Controls.Add(Label4)
        Controls.Add(chkShowPassword)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents chkShowPassword As CheckBox
End Class
