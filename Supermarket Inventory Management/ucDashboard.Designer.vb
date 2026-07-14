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
        lblTitle = New Label()
        grpProfile = New GroupBox()
        lblLastActiveValue = New Label()
        lblChangesValue = New Label()
        lblEmployeeIdValue = New Label()
        lblUsernameValue = New Label()
        lblLastActive = New Label()
        lblChanges = New Label()
        lblEmployeeId = New Label()
        lblUsername = New Label()
        lblMyChanges = New Label()
        dgvMyChanges = New DataGridView()
        grpProfile.SuspendLayout()
        CType(dgvMyChanges, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' lblTitle
        '
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.Location = New Point(52, 32)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(120, 45)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Account"
        '
        ' grpProfile
        '
        grpProfile.Controls.Add(lblLastActiveValue)
        grpProfile.Controls.Add(lblChangesValue)
        grpProfile.Controls.Add(lblEmployeeIdValue)
        grpProfile.Controls.Add(lblUsernameValue)
        grpProfile.Controls.Add(lblLastActive)
        grpProfile.Controls.Add(lblChanges)
        grpProfile.Controls.Add(lblEmployeeId)
        grpProfile.Controls.Add(lblUsername)
        grpProfile.Location = New Point(62, 100)
        grpProfile.Name = "grpProfile"
        grpProfile.Size = New Size(560, 230)
        grpProfile.TabIndex = 1
        grpProfile.TabStop = False
        grpProfile.Text = "Profile"
        '
        ' lblUsername
        '
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(40, 50)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(95, 25)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        '
        ' lblEmployeeId
        '
        lblEmployeeId.AutoSize = True
        lblEmployeeId.Location = New Point(40, 95)
        lblEmployeeId.Name = "lblEmployeeId"
        lblEmployeeId.Size = New Size(118, 25)
        lblEmployeeId.TabIndex = 1
        lblEmployeeId.Text = "Employee ID:"
        '
        ' lblChanges
        '
        lblChanges.AutoSize = True
        lblChanges.Location = New Point(40, 140)
        lblChanges.Name = "lblChanges"
        lblChanges.Size = New Size(135, 25)
        lblChanges.TabIndex = 2
        lblChanges.Text = "Changes made:"
        '
        ' lblLastActive
        '
        lblLastActive.AutoSize = True
        lblLastActive.Location = New Point(40, 185)
        lblLastActive.Name = "lblLastActive"
        lblLastActive.Size = New Size(112, 25)
        lblLastActive.TabIndex = 3
        lblLastActive.Text = "Last activity:"
        '
        ' lblUsernameValue
        '
        lblUsernameValue.AutoSize = True
        lblUsernameValue.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUsernameValue.Location = New Point(230, 50)
        lblUsernameValue.Name = "lblUsernameValue"
        lblUsernameValue.Size = New Size(22, 25)
        lblUsernameValue.TabIndex = 4
        lblUsernameValue.Text = "-"
        '
        ' lblEmployeeIdValue
        '
        lblEmployeeIdValue.AutoSize = True
        lblEmployeeIdValue.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblEmployeeIdValue.Location = New Point(230, 95)
        lblEmployeeIdValue.Name = "lblEmployeeIdValue"
        lblEmployeeIdValue.Size = New Size(22, 25)
        lblEmployeeIdValue.TabIndex = 5
        lblEmployeeIdValue.Text = "-"
        '
        ' lblChangesValue
        '
        lblChangesValue.AutoSize = True
        lblChangesValue.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblChangesValue.Location = New Point(230, 140)
        lblChangesValue.Name = "lblChangesValue"
        lblChangesValue.Size = New Size(22, 25)
        lblChangesValue.TabIndex = 6
        lblChangesValue.Text = "-"
        '
        ' lblLastActiveValue
        '
        lblLastActiveValue.AutoSize = True
        lblLastActiveValue.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblLastActiveValue.Location = New Point(230, 185)
        lblLastActiveValue.Name = "lblLastActiveValue"
        lblLastActiveValue.Size = New Size(22, 25)
        lblLastActiveValue.TabIndex = 7
        lblLastActiveValue.Text = "-"
        '
        ' lblMyChanges
        '
        lblMyChanges.AutoSize = True
        lblMyChanges.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblMyChanges.Location = New Point(62, 370)
        lblMyChanges.Name = "lblMyChanges"
        lblMyChanges.Size = New Size(160, 30)
        lblMyChanges.TabIndex = 2
        lblMyChanges.Text = "My Changes"
        '
        ' dgvMyChanges
        '
        dgvMyChanges.AllowUserToAddRows = False
        dgvMyChanges.AllowUserToDeleteRows = False
        dgvMyChanges.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        dgvMyChanges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMyChanges.Location = New Point(62, 415)
        dgvMyChanges.MultiSelect = False
        dgvMyChanges.Name = "dgvMyChanges"
        dgvMyChanges.ReadOnly = True
        dgvMyChanges.RowHeadersVisible = False
        dgvMyChanges.RowHeadersWidth = 62
        dgvMyChanges.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMyChanges.Size = New Size(1390, 450)
        dgvMyChanges.TabIndex = 3
        '
        ' ucDashboard
        '
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(dgvMyChanges)
        Controls.Add(lblMyChanges)
        Controls.Add(grpProfile)
        Controls.Add(lblTitle)
        MinimumSize = New Size(1525, 924)
        Name = "ucDashboard"
        Size = New Size(1525, 924)
        grpProfile.ResumeLayout(False)
        grpProfile.PerformLayout()
        CType(dgvMyChanges, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents grpProfile As GroupBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblEmployeeId As Label
    Friend WithEvents lblChanges As Label
    Friend WithEvents lblLastActive As Label
    Friend WithEvents lblUsernameValue As Label
    Friend WithEvents lblEmployeeIdValue As Label
    Friend WithEvents lblChangesValue As Label
    Friend WithEvents lblLastActiveValue As Label
    Friend WithEvents lblMyChanges As Label
    Friend WithEvents dgvMyChanges As DataGridView

End Class
