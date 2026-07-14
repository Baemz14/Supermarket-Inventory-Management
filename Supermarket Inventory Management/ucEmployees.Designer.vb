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
        dgvEmployees = New DataGridView()
        dgvEmployeeChanges = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtEmployeeKeyword = New TextBox()
        txtChangesKeyword = New TextBox()
        Label5 = New Label()
        cboReasonFilter = New ComboBox()
        GroupBox1 = New GroupBox()
        lblAfter = New Label()
        lblBefore = New Label()
        lblChanged = New Label()
        Label7 = New Label()
        Label6 = New Label()
        lblProduct = New Label()
        lblReason = New Label()
        lblChangedAnswer = New Label()
        lblBeforeAnswer = New Label()
        lblAfterAnswer = New Label()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvEmployeeChanges, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvEmployees
        ' 
        dgvEmployees.AllowUserToAddRows = False
        dgvEmployees.AllowUserToDeleteRows = False
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployees.Location = New Point(62, 91)
        dgvEmployees.MultiSelect = False
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.ReadOnly = True
        dgvEmployees.RowHeadersVisible = False
        dgvEmployees.RowHeadersWidth = 62
        dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployees.Size = New Size(489, 308)
        dgvEmployees.TabIndex = 0
        ' 
        ' dgvEmployeeChanges
        ' 
        dgvEmployeeChanges.AllowUserToAddRows = False
        dgvEmployeeChanges.AllowUserToDeleteRows = False
        dgvEmployeeChanges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployeeChanges.Location = New Point(62, 505)
        dgvEmployeeChanges.MultiSelect = False
        dgvEmployeeChanges.Name = "dgvEmployeeChanges"
        dgvEmployeeChanges.ReadOnly = True
        dgvEmployeeChanges.RowHeadersVisible = False
        dgvEmployeeChanges.RowHeadersWidth = 62
        dgvEmployeeChanges.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployeeChanges.Size = New Size(1068, 356)
        dgvEmployeeChanges.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 25)
        Label1.TabIndex = 2
        Label1.Text = "Employee"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(213, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 25)
        Label2.TabIndex = 3
        Label2.Text = "Keyword:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(62, 438)
        Label3.Name = "Label3"
        Label3.Size = New Size(214, 25)
        Label3.TabIndex = 4
        Label3.Text = "Changes made by [name]"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(355, 438)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 25)
        Label4.TabIndex = 5
        Label4.Text = "Keyword:"
        ' 
        ' txtEmployeeKeyword
        ' 
        txtEmployeeKeyword.Location = New Point(304, 40)
        txtEmployeeKeyword.Name = "txtEmployeeKeyword"
        txtEmployeeKeyword.Size = New Size(247, 31)
        txtEmployeeKeyword.TabIndex = 6
        ' 
        ' txtChangesKeyword
        ' 
        txtChangesKeyword.Location = New Point(446, 438)
        txtChangesKeyword.Name = "txtChangesKeyword"
        txtChangesKeyword.Size = New Size(247, 31)
        txtChangesKeyword.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(781, 438)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 25)
        Label5.TabIndex = 8
        Label5.Text = "Change Reason:"
        ' 
        ' cboReasonFilter
        ' 
        cboReasonFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboReasonFilter.FormattingEnabled = True
        cboReasonFilter.Items.AddRange(New Object() {"(All)", "Sold", "Arrived", "Removed", "Damaged", "Expired", "Shrinkage", "Internal Usage", "Customer Return", "Audit Correction", "Bulk Buy", "Price Change"})
        cboReasonFilter.Location = New Point(925, 436)
        cboReasonFilter.Name = "cboReasonFilter"
        cboReasonFilter.Size = New Size(205, 33)
        cboReasonFilter.TabIndex = 9
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblAfterAnswer)
        GroupBox1.Controls.Add(lblBeforeAnswer)
        GroupBox1.Controls.Add(lblChangedAnswer)
        GroupBox1.Controls.Add(lblReason)
        GroupBox1.Controls.Add(lblProduct)
        GroupBox1.Controls.Add(lblAfter)
        GroupBox1.Controls.Add(lblBefore)
        GroupBox1.Controls.Add(lblChanged)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Location = New Point(711, 52)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(601, 347)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Changes Info"
        ' 
        ' lblAfter
        ' 
        lblAfter.AutoSize = True
        lblAfter.Location = New Point(82, 276)
        lblAfter.Name = "lblAfter"
        lblAfter.Size = New Size(128, 25)
        lblAfter.TabIndex = 4
        lblAfter.Text = "Quantity After:"
        ' 
        ' lblBefore
        ' 
        lblBefore.AutoSize = True
        lblBefore.Location = New Point(70, 220)
        lblBefore.Name = "lblBefore"
        lblBefore.Size = New Size(140, 25)
        lblBefore.TabIndex = 3
        lblBefore.Text = "Quantity Before:"
        ' 
        ' lblChanged
        ' 
        lblChanged.AutoSize = True
        lblChanged.Location = New Point(50, 163)
        lblChanged.Name = "lblChanged"
        lblChanged.Size = New Size(160, 25)
        lblChanged.TabIndex = 2
        lblChanged.Text = "Quantity Changed:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(137, 107)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 25)
        Label7.TabIndex = 1
        Label7.Text = "Reason:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(132, 51)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 25)
        Label6.TabIndex = 0
        Label6.Text = "Product:"
        ' 
        ' lblProduct
        ' 
        lblProduct.BorderStyle = BorderStyle.Fixed3D
        lblProduct.Location = New Point(225, 50)
        lblProduct.Name = "lblProduct"
        lblProduct.Size = New Size(249, 38)
        lblProduct.TabIndex = 5
        ' 
        ' lblReason
        ' 
        lblReason.BorderStyle = BorderStyle.Fixed3D
        lblReason.Location = New Point(225, 106)
        lblReason.Name = "lblReason"
        lblReason.Size = New Size(249, 38)
        lblReason.TabIndex = 6
        ' 
        ' lblChangedAnswer
        ' 
        lblChangedAnswer.BorderStyle = BorderStyle.Fixed3D
        lblChangedAnswer.Location = New Point(227, 162)
        lblChangedAnswer.Name = "lblChangedAnswer"
        lblChangedAnswer.Size = New Size(247, 38)
        lblChangedAnswer.TabIndex = 7
        ' 
        ' lblBeforeAnswer
        ' 
        lblBeforeAnswer.BorderStyle = BorderStyle.Fixed3D
        lblBeforeAnswer.Location = New Point(227, 220)
        lblBeforeAnswer.Name = "lblBeforeAnswer"
        lblBeforeAnswer.Size = New Size(247, 38)
        lblBeforeAnswer.TabIndex = 8
        ' 
        ' lblAfterAnswer
        ' 
        lblAfterAnswer.BorderStyle = BorderStyle.Fixed3D
        lblAfterAnswer.Location = New Point(227, 276)
        lblAfterAnswer.Name = "lblAfterAnswer"
        lblAfterAnswer.Size = New Size(247, 38)
        lblAfterAnswer.TabIndex = 9
        ' 
        ' ucEmployees
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox1)
        Controls.Add(cboReasonFilter)
        Controls.Add(Label5)
        Controls.Add(txtChangesKeyword)
        Controls.Add(txtEmployeeKeyword)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvEmployeeChanges)
        Controls.Add(dgvEmployees)
        MinimumSize = New Size(1525, 924)
        Name = "ucEmployees"
        Size = New Size(1525, 924)
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvEmployeeChanges, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents dgvEmployeeChanges As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmployeeKeyword As TextBox
    Friend WithEvents txtChangesKeyword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboReasonFilter As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblBefore As Label
    Friend WithEvents lblChanged As Label
    Friend WithEvents lblAfter As Label
    Friend WithEvents lblChangedAnswer As Label
    Friend WithEvents lblReason As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents lblBeforeAnswer As Label
    Friend WithEvents lblAfterAnswer As Label

End Class
