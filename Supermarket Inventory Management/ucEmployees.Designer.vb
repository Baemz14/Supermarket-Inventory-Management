<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucEmployees
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
        flpEmployeeFilter = New FlowLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        txtEmployeeKeyword = New TextBox()
        dgvEmployees = New DataGridView()
        GroupBox1 = New GroupBox()
        tlpChangesInfo = New TableLayoutPanel()
        Label6 = New Label()
        lblProduct = New Label()
        Label7 = New Label()
        lblReason = New Label()
        lblChanged = New Label()
        lblChangedAnswer = New Label()
        lblBefore = New Label()
        lblBeforeAnswer = New Label()
        lblAfter = New Label()
        lblAfterAnswer = New Label()
        flpChangesFilter = New FlowLayoutPanel()
        Label3 = New Label()
        Label4 = New Label()
        txtChangesKeyword = New TextBox()
        Label5 = New Label()
        cboReasonFilter = New ComboBox()
        dgvEmployeeChanges = New DataGridView()
        tlpRoot.SuspendLayout()
        flpEmployeeFilter.SuspendLayout()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        tlpChangesInfo.SuspendLayout()
        flpChangesFilter.SuspendLayout()
        CType(dgvEmployeeChanges, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' tlpRoot
        '
        tlpRoot.ColumnCount = 2
        tlpRoot.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpRoot.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpRoot.Controls.Add(flpEmployeeFilter, 0, 0)
        tlpRoot.Controls.Add(dgvEmployees, 0, 1)
        tlpRoot.Controls.Add(GroupBox1, 1, 1)
        tlpRoot.Controls.Add(flpChangesFilter, 0, 2)
        tlpRoot.Controls.Add(dgvEmployeeChanges, 0, 3)
        tlpRoot.Dock = DockStyle.Fill
        tlpRoot.Location = New Point(0, 0)
        tlpRoot.Name = "tlpRoot"
        tlpRoot.Padding = New Padding(15)
        tlpRoot.RowCount = 4
        tlpRoot.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpRoot.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        tlpRoot.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpRoot.RowStyles.Add(New RowStyle(SizeType.Percent, 55F))
        tlpRoot.Size = New Size(1525, 924)
        tlpRoot.TabIndex = 0
        '
        ' flpEmployeeFilter
        '
        flpEmployeeFilter.AutoSize = True
        flpEmployeeFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpRoot.SetColumnSpan(flpEmployeeFilter, 2)
        flpEmployeeFilter.Controls.Add(Label1)
        flpEmployeeFilter.Controls.Add(Label2)
        flpEmployeeFilter.Controls.Add(txtEmployeeKeyword)
        flpEmployeeFilter.Location = New Point(18, 18)
        flpEmployeeFilter.Name = "flpEmployeeFilter"
        flpEmployeeFilter.Size = New Size(500, 40)
        flpEmployeeFilter.TabIndex = 0
        flpEmployeeFilter.WrapContents = False
        '
        ' Label1
        '
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label1.Location = New Point(3, 5)
        Label1.Margin = New Padding(3, 0, 24, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 30)
        Label1.TabIndex = 0
        Label1.Text = "Employees"
        '
        ' Label2
        '
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(150, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 25)
        Label2.TabIndex = 1
        Label2.Text = "Keyword:"
        '
        ' txtEmployeeKeyword
        '
        txtEmployeeKeyword.Anchor = AnchorStyles.Left
        txtEmployeeKeyword.Location = New Point(241, 3)
        txtEmployeeKeyword.Name = "txtEmployeeKeyword"
        txtEmployeeKeyword.Size = New Size(247, 31)
        txtEmployeeKeyword.TabIndex = 2
        '
        ' dgvEmployees
        '
        dgvEmployees.AllowUserToAddRows = False
        dgvEmployees.AllowUserToDeleteRows = False
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployees.Dock = DockStyle.Fill
        dgvEmployees.Location = New Point(18, 64)
        dgvEmployees.Margin = New Padding(3, 3, 12, 12)
        dgvEmployees.MultiSelect = False
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.ReadOnly = True
        dgvEmployees.RowHeadersVisible = False
        dgvEmployees.RowHeadersWidth = 62
        dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployees.Size = New Size(717, 350)
        dgvEmployees.TabIndex = 1
        '
        ' GroupBox1
        '
        GroupBox1.Controls.Add(tlpChangesInfo)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Location = New Point(750, 64)
        GroupBox1.Margin = New Padding(3, 3, 3, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(12)
        GroupBox1.Size = New Size(754, 350)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Changes Info"
        '
        ' tlpChangesInfo
        '
        tlpChangesInfo.ColumnCount = 2
        tlpChangesInfo.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
        tlpChangesInfo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpChangesInfo.Controls.Add(Label6, 0, 0)
        tlpChangesInfo.Controls.Add(lblProduct, 1, 0)
        tlpChangesInfo.Controls.Add(Label7, 0, 1)
        tlpChangesInfo.Controls.Add(lblReason, 1, 1)
        tlpChangesInfo.Controls.Add(lblChanged, 0, 2)
        tlpChangesInfo.Controls.Add(lblChangedAnswer, 1, 2)
        tlpChangesInfo.Controls.Add(lblBefore, 0, 3)
        tlpChangesInfo.Controls.Add(lblBeforeAnswer, 1, 3)
        tlpChangesInfo.Controls.Add(lblAfter, 0, 4)
        tlpChangesInfo.Controls.Add(lblAfterAnswer, 1, 4)
        tlpChangesInfo.Dock = DockStyle.Fill
        tlpChangesInfo.Location = New Point(12, 37)
        tlpChangesInfo.Name = "tlpChangesInfo"
        tlpChangesInfo.RowCount = 6
        tlpChangesInfo.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpChangesInfo.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpChangesInfo.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpChangesInfo.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpChangesInfo.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpChangesInfo.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpChangesInfo.Size = New Size(730, 301)
        tlpChangesInfo.TabIndex = 0
        '
        ' Label6
        '
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Location = New Point(3, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 25)
        Label6.TabIndex = 0
        Label6.Text = "Product:"
        '
        ' lblProduct
        '
        lblProduct.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblProduct.BorderStyle = BorderStyle.Fixed3D
        lblProduct.Location = New Point(184, 3)
        lblProduct.Margin = New Padding(3, 3, 3, 8)
        lblProduct.Name = "lblProduct"
        lblProduct.Size = New Size(543, 38)
        lblProduct.TabIndex = 1
        lblProduct.TextAlign = ContentAlignment.MiddleLeft
        '
        ' Label7
        '
        Label7.Anchor = AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Location = New Point(3, 59)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 25)
        Label7.TabIndex = 2
        Label7.Text = "Reason:"
        '
        ' lblReason
        '
        lblReason.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblReason.BorderStyle = BorderStyle.Fixed3D
        lblReason.Location = New Point(184, 52)
        lblReason.Margin = New Padding(3, 3, 3, 8)
        lblReason.Name = "lblReason"
        lblReason.Size = New Size(543, 38)
        lblReason.TabIndex = 3
        lblReason.TextAlign = ContentAlignment.MiddleLeft
        '
        ' lblChanged
        '
        lblChanged.Anchor = AnchorStyles.Left
        lblChanged.AutoSize = True
        lblChanged.Location = New Point(3, 108)
        lblChanged.Name = "lblChanged"
        lblChanged.Size = New Size(160, 25)
        lblChanged.TabIndex = 4
        lblChanged.Text = "Quantity Changed:"
        '
        ' lblChangedAnswer
        '
        lblChangedAnswer.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblChangedAnswer.BorderStyle = BorderStyle.Fixed3D
        lblChangedAnswer.Location = New Point(184, 101)
        lblChangedAnswer.Margin = New Padding(3, 3, 3, 8)
        lblChangedAnswer.Name = "lblChangedAnswer"
        lblChangedAnswer.Size = New Size(543, 38)
        lblChangedAnswer.TabIndex = 5
        lblChangedAnswer.TextAlign = ContentAlignment.MiddleLeft
        '
        ' lblBefore
        '
        lblBefore.Anchor = AnchorStyles.Left
        lblBefore.AutoSize = True
        lblBefore.Location = New Point(3, 157)
        lblBefore.Name = "lblBefore"
        lblBefore.Size = New Size(140, 25)
        lblBefore.TabIndex = 6
        lblBefore.Text = "Quantity Before:"
        '
        ' lblBeforeAnswer
        '
        lblBeforeAnswer.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblBeforeAnswer.BorderStyle = BorderStyle.Fixed3D
        lblBeforeAnswer.Location = New Point(184, 150)
        lblBeforeAnswer.Margin = New Padding(3, 3, 3, 8)
        lblBeforeAnswer.Name = "lblBeforeAnswer"
        lblBeforeAnswer.Size = New Size(543, 38)
        lblBeforeAnswer.TabIndex = 7
        lblBeforeAnswer.TextAlign = ContentAlignment.MiddleLeft
        '
        ' lblAfter
        '
        lblAfter.Anchor = AnchorStyles.Left
        lblAfter.AutoSize = True
        lblAfter.Location = New Point(3, 206)
        lblAfter.Name = "lblAfter"
        lblAfter.Size = New Size(128, 25)
        lblAfter.TabIndex = 8
        lblAfter.Text = "Quantity After:"
        '
        ' lblAfterAnswer
        '
        lblAfterAnswer.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblAfterAnswer.BorderStyle = BorderStyle.Fixed3D
        lblAfterAnswer.Location = New Point(184, 199)
        lblAfterAnswer.Margin = New Padding(3, 3, 3, 8)
        lblAfterAnswer.Name = "lblAfterAnswer"
        lblAfterAnswer.Size = New Size(543, 38)
        lblAfterAnswer.TabIndex = 9
        lblAfterAnswer.TextAlign = ContentAlignment.MiddleLeft
        '
        ' flpChangesFilter
        '
        flpChangesFilter.AutoSize = True
        flpChangesFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpRoot.SetColumnSpan(flpChangesFilter, 2)
        flpChangesFilter.Controls.Add(Label3)
        flpChangesFilter.Controls.Add(Label4)
        flpChangesFilter.Controls.Add(txtChangesKeyword)
        flpChangesFilter.Controls.Add(Label5)
        flpChangesFilter.Controls.Add(cboReasonFilter)
        flpChangesFilter.Location = New Point(18, 426)
        flpChangesFilter.Margin = New Padding(3, 9, 3, 3)
        flpChangesFilter.Name = "flpChangesFilter"
        flpChangesFilter.Size = New Size(1000, 40)
        flpChangesFilter.TabIndex = 3
        flpChangesFilter.WrapContents = False
        '
        ' Label3
        '
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label3.Location = New Point(3, 5)
        Label3.Margin = New Padding(3, 0, 24, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(260, 30)
        Label3.TabIndex = 0
        Label3.Text = "Changes made by [name]"
        '
        ' Label4
        '
        Label4.Anchor = AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New Point(290, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 25)
        Label4.TabIndex = 1
        Label4.Text = "Keyword:"
        '
        ' txtChangesKeyword
        '
        txtChangesKeyword.Anchor = AnchorStyles.Left
        txtChangesKeyword.Location = New Point(381, 3)
        txtChangesKeyword.Name = "txtChangesKeyword"
        txtChangesKeyword.Size = New Size(247, 31)
        txtChangesKeyword.TabIndex = 2
        '
        ' Label5
        '
        Label5.Anchor = AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Location = New Point(655, 7)
        Label5.Margin = New Padding(24, 0, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 25)
        Label5.TabIndex = 3
        Label5.Text = "Change Reason:"
        '
        ' cboReasonFilter
        '
        cboReasonFilter.Anchor = AnchorStyles.Left
        cboReasonFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboReasonFilter.FormattingEnabled = True
        cboReasonFilter.Items.AddRange(New Object() {"(All)", "Sold", "Arrived", "Removed", "Damaged", "Expired", "Shrinkage", "Internal Usage", "Customer Return", "Audit Correction", "Bulk Buy", "Price Change"})
        cboReasonFilter.Location = New Point(799, 3)
        cboReasonFilter.Name = "cboReasonFilter"
        cboReasonFilter.Size = New Size(205, 33)
        cboReasonFilter.TabIndex = 4
        '
        ' dgvEmployeeChanges
        '
        dgvEmployeeChanges.AllowUserToAddRows = False
        dgvEmployeeChanges.AllowUserToDeleteRows = False
        dgvEmployeeChanges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tlpRoot.SetColumnSpan(dgvEmployeeChanges, 2)
        dgvEmployeeChanges.Dock = DockStyle.Fill
        dgvEmployeeChanges.Location = New Point(18, 472)
        dgvEmployeeChanges.MultiSelect = False
        dgvEmployeeChanges.Name = "dgvEmployeeChanges"
        dgvEmployeeChanges.ReadOnly = True
        dgvEmployeeChanges.RowHeadersVisible = False
        dgvEmployeeChanges.RowHeadersWidth = 62
        dgvEmployeeChanges.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployeeChanges.Size = New Size(1486, 434)
        dgvEmployeeChanges.TabIndex = 4
        '
        ' ucEmployees
        '
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(tlpRoot)
        MinimumSize = New Size(1000, 700)
        Name = "ucEmployees"
        Size = New Size(1525, 924)
        tlpRoot.ResumeLayout(False)
        tlpRoot.PerformLayout()
        flpEmployeeFilter.ResumeLayout(False)
        flpEmployeeFilter.PerformLayout()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        tlpChangesInfo.ResumeLayout(False)
        tlpChangesInfo.PerformLayout()
        flpChangesFilter.ResumeLayout(False)
        flpChangesFilter.PerformLayout()
        CType(dgvEmployeeChanges, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tlpRoot As TableLayoutPanel
    Friend WithEvents flpEmployeeFilter As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmployeeKeyword As TextBox
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tlpChangesInfo As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblReason As Label
    Friend WithEvents lblChanged As Label
    Friend WithEvents lblChangedAnswer As Label
    Friend WithEvents lblBefore As Label
    Friend WithEvents lblBeforeAnswer As Label
    Friend WithEvents lblAfter As Label
    Friend WithEvents lblAfterAnswer As Label
    Friend WithEvents flpChangesFilter As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtChangesKeyword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboReasonFilter As ComboBox
    Friend WithEvents dgvEmployeeChanges As DataGridView

End Class

