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
        tlpRoot = New TableLayoutPanel()
        lblTitle = New Label()
        grpProfile = New GroupBox()
        tlpProfile = New TableLayoutPanel()
        lblUsername = New Label()
        lblUsernameValue = New Label()
        lblEmployeeId = New Label()
        lblEmployeeIdValue = New Label()
        lblChanges = New Label()
        lblChangesValue = New Label()
        lblLastActive = New Label()
        lblLastActiveValue = New Label()
        lblMyChanges = New Label()
        dgvMyChanges = New DataGridView()
        tlpRoot.SuspendLayout()
        grpProfile.SuspendLayout()
        tlpProfile.SuspendLayout()
        CType(dgvMyChanges, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' tlpRoot
        '
        tlpRoot.ColumnCount = 1
        tlpRoot.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpRoot.Controls.Add(lblTitle, 0, 0)
        tlpRoot.Controls.Add(grpProfile, 0, 1)
        tlpRoot.Controls.Add(lblMyChanges, 0, 2)
        tlpRoot.Controls.Add(dgvMyChanges, 0, 3)
        tlpRoot.Dock = DockStyle.Fill
        tlpRoot.Location = New Point(0, 0)
        tlpRoot.Name = "tlpRoot"
        tlpRoot.Padding = New Padding(15)
        tlpRoot.RowCount = 4
        tlpRoot.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpRoot.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpRoot.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpRoot.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpRoot.Size = New Size(1525, 924)
        tlpRoot.TabIndex = 0
        '
        ' lblTitle
        '
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.Location = New Point(18, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(120, 45)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Account"
        '
        ' grpProfile
        '
        grpProfile.Anchor = AnchorStyles.Left
        grpProfile.Controls.Add(tlpProfile)
        grpProfile.Location = New Point(18, 75)
        grpProfile.Margin = New Padding(3, 15, 3, 3)
        grpProfile.Name = "grpProfile"
        grpProfile.Padding = New Padding(12)
        grpProfile.Size = New Size(560, 230)
        grpProfile.TabIndex = 1
        grpProfile.TabStop = False
        grpProfile.Text = "Profile"
        '
        ' tlpProfile
        '
        tlpProfile.ColumnCount = 2
        tlpProfile.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
        tlpProfile.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpProfile.Controls.Add(lblUsername, 0, 0)
        tlpProfile.Controls.Add(lblUsernameValue, 1, 0)
        tlpProfile.Controls.Add(lblEmployeeId, 0, 1)
        tlpProfile.Controls.Add(lblEmployeeIdValue, 1, 1)
        tlpProfile.Controls.Add(lblChanges, 0, 2)
        tlpProfile.Controls.Add(lblChangesValue, 1, 2)
        tlpProfile.Controls.Add(lblLastActive, 0, 3)
        tlpProfile.Controls.Add(lblLastActiveValue, 1, 3)
        tlpProfile.Dock = DockStyle.Fill
        tlpProfile.Location = New Point(12, 37)
        tlpProfile.Name = "tlpProfile"
        tlpProfile.RowCount = 4
        tlpProfile.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpProfile.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpProfile.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpProfile.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpProfile.Size = New Size(536, 181)
        tlpProfile.TabIndex = 0
        '
        ' lblUsername
        '
        lblUsername.Anchor = AnchorStyles.Left
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(3, 6)
        lblUsername.Margin = New Padding(3, 6, 30, 6)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(95, 25)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        '
        ' lblUsernameValue
        '
        lblUsernameValue.Anchor = AnchorStyles.Left
        lblUsernameValue.AutoSize = True
        lblUsernameValue.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUsernameValue.Location = New Point(176, 6)
        lblUsernameValue.Margin = New Padding(3, 6, 3, 6)
        lblUsernameValue.Name = "lblUsernameValue"
        lblUsernameValue.Size = New Size(22, 25)
        lblUsernameValue.TabIndex = 1
        lblUsernameValue.Text = "-"
        '
        ' lblEmployeeId
        '
        lblEmployeeId.Anchor = AnchorStyles.Left
        lblEmployeeId.AutoSize = True
        lblEmployeeId.Location = New Point(3, 43)
        lblEmployeeId.Margin = New Padding(3, 6, 30, 6)
        lblEmployeeId.Name = "lblEmployeeId"
        lblEmployeeId.Size = New Size(118, 25)
        lblEmployeeId.TabIndex = 2
        lblEmployeeId.Text = "Employee ID:"
        '
        ' lblEmployeeIdValue
        '
        lblEmployeeIdValue.Anchor = AnchorStyles.Left
        lblEmployeeIdValue.AutoSize = True
        lblEmployeeIdValue.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblEmployeeIdValue.Location = New Point(176, 43)
        lblEmployeeIdValue.Margin = New Padding(3, 6, 3, 6)
        lblEmployeeIdValue.Name = "lblEmployeeIdValue"
        lblEmployeeIdValue.Size = New Size(22, 25)
        lblEmployeeIdValue.TabIndex = 3
        lblEmployeeIdValue.Text = "-"
        '
        ' lblChanges
        '
        lblChanges.Anchor = AnchorStyles.Left
        lblChanges.AutoSize = True
        lblChanges.Location = New Point(3, 80)
        lblChanges.Margin = New Padding(3, 6, 30, 6)
        lblChanges.Name = "lblChanges"
        lblChanges.Size = New Size(135, 25)
        lblChanges.TabIndex = 4
        lblChanges.Text = "Changes made:"
        '
        ' lblChangesValue
        '
        lblChangesValue.Anchor = AnchorStyles.Left
        lblChangesValue.AutoSize = True
        lblChangesValue.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblChangesValue.Location = New Point(176, 80)
        lblChangesValue.Margin = New Padding(3, 6, 3, 6)
        lblChangesValue.Name = "lblChangesValue"
        lblChangesValue.Size = New Size(22, 25)
        lblChangesValue.TabIndex = 5
        lblChangesValue.Text = "-"
        '
        ' lblLastActive
        '
        lblLastActive.Anchor = AnchorStyles.Left
        lblLastActive.AutoSize = True
        lblLastActive.Location = New Point(3, 117)
        lblLastActive.Margin = New Padding(3, 6, 30, 6)
        lblLastActive.Name = "lblLastActive"
        lblLastActive.Size = New Size(112, 25)
        lblLastActive.TabIndex = 6
        lblLastActive.Text = "Last activity:"
        '
        ' lblLastActiveValue
        '
        lblLastActiveValue.Anchor = AnchorStyles.Left
        lblLastActiveValue.AutoSize = True
        lblLastActiveValue.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblLastActiveValue.Location = New Point(176, 117)
        lblLastActiveValue.Margin = New Padding(3, 6, 3, 6)
        lblLastActiveValue.Name = "lblLastActiveValue"
        lblLastActiveValue.Size = New Size(22, 25)
        lblLastActiveValue.TabIndex = 7
        lblLastActiveValue.Text = "-"
        '
        ' lblMyChanges
        '
        lblMyChanges.AutoSize = True
        lblMyChanges.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblMyChanges.Location = New Point(18, 323)
        lblMyChanges.Margin = New Padding(3, 15, 3, 6)
        lblMyChanges.Name = "lblMyChanges"
        lblMyChanges.Size = New Size(135, 30)
        lblMyChanges.TabIndex = 2
        lblMyChanges.Text = "My Changes"
        '
        ' dgvMyChanges
        '
        dgvMyChanges.AllowUserToAddRows = False
        dgvMyChanges.AllowUserToDeleteRows = False
        dgvMyChanges.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        dgvMyChanges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMyChanges.Dock = DockStyle.Fill
        dgvMyChanges.Location = New Point(18, 362)
        dgvMyChanges.MultiSelect = False
        dgvMyChanges.Name = "dgvMyChanges"
        dgvMyChanges.ReadOnly = True
        dgvMyChanges.RowHeadersVisible = False
        dgvMyChanges.RowHeadersWidth = 62
        dgvMyChanges.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMyChanges.Size = New Size(1489, 547)
        dgvMyChanges.TabIndex = 3
        '
        ' ucDashboard
        '
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(tlpRoot)
        MinimumSize = New Size(800, 600)
        Name = "ucDashboard"
        Size = New Size(1525, 924)
        tlpRoot.ResumeLayout(False)
        tlpRoot.PerformLayout()
        grpProfile.ResumeLayout(False)
        tlpProfile.ResumeLayout(False)
        tlpProfile.PerformLayout()
        CType(dgvMyChanges, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlpRoot As TableLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpProfile As GroupBox
    Friend WithEvents tlpProfile As TableLayoutPanel
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblUsernameValue As Label
    Friend WithEvents lblEmployeeId As Label
    Friend WithEvents lblEmployeeIdValue As Label
    Friend WithEvents lblChanges As Label
    Friend WithEvents lblChangesValue As Label
    Friend WithEvents lblLastActive As Label
    Friend WithEvents lblLastActiveValue As Label
    Friend WithEvents lblMyChanges As Label
    Friend WithEvents dgvMyChanges As DataGridView

End Class
