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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        PictureBox1 = New PictureBox()
        PictureBox5 = New PictureBox()
        Panel6 = New Panel()
        Panel1 = New Panel()
        Label3 = New Label()
        Label5 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        btnRegister = New Button()
        chkShowPassword = New CheckBox()
        btnLogin = New Button()
        txtName = New TextBox()
        Label4 = New Label()
        txtPassword = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(859, 511)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImageLayout = ImageLayout.None
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.InitialImage = Nothing
        PictureBox5.Location = New Point(10, 10)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(60, 60)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 0
        PictureBox5.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(31), CByte(50), CByte(79))
        Panel6.Controls.Add(PictureBox5)
        Panel6.Location = New Point(39, 30)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(80, 80)
        Panel6.TabIndex = 12
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnRegister)
        Panel1.Controls.Add(chkShowPassword)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtPassword)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(513, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(346, 511)
        Panel1.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(44, 237)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(55, 137)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(236, 38)
        Label5.TabIndex = 9
        Label5.Text = "Access your dashboard and manage " & vbCrLf & "system data"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(72, 100)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 37)
        Label1.TabIndex = 0
        Label1.Text = "Welcome Back"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(44, 199)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 20)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(70), CByte(141), CByte(223))
        btnRegister.FlatStyle = FlatStyle.Popup
        btnRegister.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(76, 374)
        btnRegister.Margin = New Padding(2)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(195, 37)
        btnRegister.TabIndex = 8
        btnRegister.Text = "Register new account"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.FlatStyle = FlatStyle.Flat
        chkShowPassword.ForeColor = Color.White
        chkShowPassword.Location = New Point(142, 274)
        chkShowPassword.Margin = New Padding(2)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(130, 24)
        chkShowPassword.TabIndex = 5
        chkShowPassword.Text = "Show password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(70), CByte(141), CByte(223))
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(76, 312)
        btnLogin.Margin = New Padding(2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(195, 37)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(142, 196)
        txtName.Margin = New Padding(2)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Enter your username "
        txtName.Size = New Size(161, 27)
        txtName.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(161, 351)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(26, 20)
        Label4.TabIndex = 7
        Label4.Text = "Or"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(142, 234)
        txtPassword.Margin = New Padding(2)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Enter your password"
        txtPassword.Size = New Size(161, 27)
        txtPassword.TabIndex = 4
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(859, 511)
        Controls.Add(Panel1)
        Controls.Add(Panel6)
        Controls.Add(PictureBox1)
        Margin = New Padding(2)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Supermarket Inventory Management"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
End Class
