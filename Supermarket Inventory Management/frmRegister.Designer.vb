<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Label4 = New Label()
        txtName = New TextBox()
        txtPassword = New TextBox()
        txtConfPassword = New TextBox()
        btnRegister = New Button()
        btnCancel = New Button()
        chkShowPassword = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(245, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 25)
        Label1.TabIndex = 0
        Label1.Text = "Register"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(127, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(131, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 25)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(62, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(160, 25)
        Label4.TabIndex = 3
        Label4.Text = "Confirm Password:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(245, 97)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(245, 154)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(150, 31)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtConfPassword
        ' 
        txtConfPassword.Location = New Point(245, 219)
        txtConfPassword.Name = "txtConfPassword"
        txtConfPassword.Size = New Size(150, 31)
        txtConfPassword.TabIndex = 6
        txtConfPassword.UseSystemPasswordChar = True
        '
        ' chkShowPassword
        '
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(245, 262)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(163, 29)
        chkShowPassword.TabIndex = 7
        chkShowPassword.Text = "Show password"
        chkShowPassword.UseVisualStyleBackColor = True
        '
        ' btnRegister
        '
        btnRegister.Location = New Point(162, 320)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(112, 34)
        btnRegister.TabIndex = 8
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(340, 320)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(603, 434)
        Controls.Add(btnCancel)
        Controls.Add(btnRegister)
        Controls.Add(chkShowPassword)
        Controls.Add(txtConfPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmRegister"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtConfPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkShowPassword As CheckBox
End Class
