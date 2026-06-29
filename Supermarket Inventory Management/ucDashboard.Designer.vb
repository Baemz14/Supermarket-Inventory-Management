<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Button1 = New Button()
        lblUsername = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(52, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 25)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(434, 414)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 1
        Button1.Text = "Henlo"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(450, 145)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(56, 25)
        lblUsername.TabIndex = 2
        lblUsername.Text = "name"
        ' 
        ' ucDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblUsername)
        Controls.Add(Button1)
        Controls.Add(Label1)
        MinimumSize = New Size(1024, 728)
        Name = "ucDashboard"
        Size = New Size(1024, 728)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblUsername As Label

End Class
