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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Label4 = New Label()
        txtName = New TextBox()
        txtPassword = New TextBox()
        txtConfPassword = New TextBox()
        btnRegister = New Button()
        btnCancel = New Button()
        chkShowPassword = New CheckBox()
        PictureBox1 = New PictureBox()
        PictureBox5 = New PictureBox()
        Panel1 = New Panel()
        Label6 = New Label()
        Label3 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        Label9 = New Label()
        Panel6 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(20, 263)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 20)
        Label4.TabIndex = 3
        Label4.Text = "Confirm Password:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(166, 177)
        txtName.Margin = New Padding(2)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Enter your username "
        txtName.Size = New Size(161, 27)
        txtName.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(166, 218)
        txtPassword.Margin = New Padding(2)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Enter your password"
        txtPassword.Size = New Size(161, 27)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtConfPassword
        ' 
        txtConfPassword.Location = New Point(166, 259)
        txtConfPassword.Margin = New Padding(2)
        txtConfPassword.Name = "txtConfPassword"
        txtConfPassword.PlaceholderText = "Confirm your password"
        txtConfPassword.Size = New Size(161, 27)
        txtConfPassword.TabIndex = 6
        txtConfPassword.UseSystemPasswordChar = True
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(70), CByte(141), CByte(223))
        btnRegister.FlatStyle = FlatStyle.Popup
        btnRegister.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(76, 340)
        btnRegister.Margin = New Padding(2)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(195, 37)
        btnRegister.TabIndex = 8
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(70), CByte(141), CByte(223))
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(76, 401)
        btnCancel.Margin = New Padding(2)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(195, 37)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        chkShowPassword.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkShowPassword.ForeColor = Color.White
        chkShowPassword.Location = New Point(166, 299)
        chkShowPassword.Margin = New Padding(2)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(136, 24)
        chkShowPassword.TabIndex = 7
        chkShowPassword.Text = "Show password"
        chkShowPassword.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(859, 511)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(chkShowPassword)
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtConfPassword)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(btnRegister)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(Label9)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(513, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(346, 511)
        Panel1.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(100, 137)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(147, 19)
        Label6.TabIndex = 9
        Label6.Text = "Please fill up the form"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(68, 218)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.FlatStyle = FlatStyle.Flat
        Label7.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(112, 100)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(123, 37)
        Label7.TabIndex = 0
        Label7.Text = "Register"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(63, 177)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 20)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(160, 379)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(26, 20)
        Label9.TabIndex = 7
        Label9.Text = "Or"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(31), CByte(50), CByte(79))
        Panel6.Controls.Add(PictureBox5)
        Panel6.Location = New Point(39, 30)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(80, 80)
        Panel6.TabIndex = 15
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(859, 511)
        Controls.Add(Panel6)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Margin = New Padding(2)
        Name = "frmRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtConfPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
