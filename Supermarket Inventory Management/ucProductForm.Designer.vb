<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProductForm
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
        GroupBox1 = New GroupBox()
        tlpProduct = New TableLayoutPanel()
        lblName = New Label()
        txtProductName = New TextBox()
        lblCategory = New Label()
        cboCategory = New ComboBox()
        lblSupplier = New Label()
        cboSupplier = New ComboBox()
        lblUnitPrice = New Label()
        numUnitPrice = New NumericUpDown()
        lblQuantity = New Label()
        numQuantity = New NumericUpDown()
        lblUnit = New Label()
        txtUnit = New TextBox()
        lblReorder = New Label()
        numReorderThreshold = New NumericUpDown()
        lblBulkQty = New Label()
        numBulkQuantity = New NumericUpDown()
        lblBulkDiscount = New Label()
        numBulkDiscount = New NumericUpDown()
        btnAddProduct = New Button()
        GroupBox2 = New GroupBox()
        tlpSupplierForm = New TableLayoutPanel()
        Label1 = New Label()
        txtSupplierName = New TextBox()
        Label2 = New Label()
        txtSupplierPhone = New TextBox()
        Label3 = New Label()
        txtSupplierEmail = New TextBox()
        btnAddSupplier = New Button()
        GroupBox3 = New GroupBox()
        tlpCategoryForm = New TableLayoutPanel()
        lblCategoryName = New Label()
        txtCategoryName = New TextBox()
        lblTaxRate = New Label()
        numTaxRate = New NumericUpDown()
        btnAddCategory = New Button()
        tlpRoot.SuspendLayout()
        GroupBox1.SuspendLayout()
        tlpProduct.SuspendLayout()
        CType(numUnitPrice, ComponentModel.ISupportInitialize).BeginInit()
        CType(numQuantity, ComponentModel.ISupportInitialize).BeginInit()
        CType(numReorderThreshold, ComponentModel.ISupportInitialize).BeginInit()
        CType(numBulkQuantity, ComponentModel.ISupportInitialize).BeginInit()
        CType(numBulkDiscount, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        tlpSupplierForm.SuspendLayout()
        GroupBox3.SuspendLayout()
        tlpCategoryForm.SuspendLayout()
        CType(numTaxRate, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' tlpRoot
        '
        tlpRoot.ColumnCount = 2
        tlpRoot.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpRoot.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpRoot.Controls.Add(GroupBox1, 0, 0)
        tlpRoot.Controls.Add(GroupBox2, 1, 0)
        tlpRoot.Controls.Add(GroupBox3, 1, 1)
        tlpRoot.Dock = DockStyle.Fill
        tlpRoot.Location = New Point(0, 0)
        tlpRoot.Name = "tlpRoot"
        tlpRoot.Padding = New Padding(15)
        tlpRoot.RowCount = 2
        tlpRoot.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpRoot.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpRoot.Size = New Size(1525, 924)
        tlpRoot.TabIndex = 0
        '
        ' GroupBox1
        '
        GroupBox1.Controls.Add(tlpProduct)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Location = New Point(18, 18)
        GroupBox1.Margin = New Padding(3, 3, 12, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(12)
        tlpRoot.SetRowSpan(GroupBox1, 2)
        GroupBox1.Size = New Size(732, 888)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add New Product"
        '
        ' tlpProduct
        '
        tlpProduct.ColumnCount = 2
        tlpProduct.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
        tlpProduct.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpProduct.Controls.Add(lblName, 0, 0)
        tlpProduct.Controls.Add(txtProductName, 1, 0)
        tlpProduct.Controls.Add(lblCategory, 0, 1)
        tlpProduct.Controls.Add(cboCategory, 1, 1)
        tlpProduct.Controls.Add(lblSupplier, 0, 2)
        tlpProduct.Controls.Add(cboSupplier, 1, 2)
        tlpProduct.Controls.Add(lblUnitPrice, 0, 3)
        tlpProduct.Controls.Add(numUnitPrice, 1, 3)
        tlpProduct.Controls.Add(lblQuantity, 0, 4)
        tlpProduct.Controls.Add(numQuantity, 1, 4)
        tlpProduct.Controls.Add(lblUnit, 0, 5)
        tlpProduct.Controls.Add(txtUnit, 1, 5)
        tlpProduct.Controls.Add(lblReorder, 0, 6)
        tlpProduct.Controls.Add(numReorderThreshold, 1, 6)
        tlpProduct.Controls.Add(lblBulkQty, 0, 7)
        tlpProduct.Controls.Add(numBulkQuantity, 1, 7)
        tlpProduct.Controls.Add(lblBulkDiscount, 0, 8)
        tlpProduct.Controls.Add(numBulkDiscount, 1, 8)
        tlpProduct.Controls.Add(btnAddProduct, 1, 9)
        tlpProduct.Dock = DockStyle.Fill
        tlpProduct.Location = New Point(12, 37)
        tlpProduct.Name = "tlpProduct"
        tlpProduct.RowCount = 11
        tlpProduct.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpProduct.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpProduct.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpProduct.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpProduct.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpProduct.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpProduct.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpProduct.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpProduct.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpProduct.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpProduct.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpProduct.Size = New Size(708, 839)
        tlpProduct.TabIndex = 0
        '
        ' lblName
        '
        lblName.Anchor = AnchorStyles.Left
        lblName.AutoSize = True
        lblName.Location = New Point(3, 10)
        lblName.Name = "lblName"
        lblName.Size = New Size(130, 25)
        lblName.TabIndex = 0
        lblName.Text = "Product Name:"
        '
        ' txtProductName
        '
        txtProductName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtProductName.Location = New Point(178, 3)
        txtProductName.Margin = New Padding(3, 3, 3, 10)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(527, 31)
        txtProductName.TabIndex = 1
        '
        ' lblCategory
        '
        lblCategory.Anchor = AnchorStyles.Left
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(3, 54)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(88, 25)
        lblCategory.TabIndex = 2
        lblCategory.Text = "Category:"
        '
        ' cboCategory
        '
        cboCategory.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategory.Location = New Point(178, 47)
        cboCategory.Margin = New Padding(3, 3, 3, 10)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(527, 33)
        cboCategory.TabIndex = 3
        '
        ' lblSupplier
        '
        lblSupplier.Anchor = AnchorStyles.Left
        lblSupplier.AutoSize = True
        lblSupplier.Location = New Point(3, 100)
        lblSupplier.Name = "lblSupplier"
        lblSupplier.Size = New Size(81, 25)
        lblSupplier.TabIndex = 4
        lblSupplier.Text = "Supplier:"
        '
        ' cboSupplier
        '
        cboSupplier.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList
        cboSupplier.Location = New Point(178, 93)
        cboSupplier.Margin = New Padding(3, 3, 3, 10)
        cboSupplier.Name = "cboSupplier"
        cboSupplier.Size = New Size(527, 33)
        cboSupplier.TabIndex = 5
        '
        ' lblUnitPrice
        '
        lblUnitPrice.Anchor = AnchorStyles.Left
        lblUnitPrice.AutoSize = True
        lblUnitPrice.Location = New Point(3, 146)
        lblUnitPrice.Name = "lblUnitPrice"
        lblUnitPrice.Size = New Size(90, 25)
        lblUnitPrice.TabIndex = 6
        lblUnitPrice.Text = "Unit Price:"
        '
        ' numUnitPrice
        '
        numUnitPrice.Anchor = AnchorStyles.Left
        numUnitPrice.DecimalPlaces = 2
        numUnitPrice.Increment = New Decimal(New Integer() {10, 0, 0, 131072})
        numUnitPrice.Location = New Point(178, 139)
        numUnitPrice.Margin = New Padding(3, 3, 3, 10)
        numUnitPrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numUnitPrice.Name = "numUnitPrice"
        numUnitPrice.Size = New Size(200, 31)
        numUnitPrice.TabIndex = 7
        '
        ' lblQuantity
        '
        lblQuantity.Anchor = AnchorStyles.Left
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(3, 190)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(84, 25)
        lblQuantity.TabIndex = 8
        lblQuantity.Text = "Quantity:"
        '
        ' numQuantity
        '
        numQuantity.Anchor = AnchorStyles.Left
        numQuantity.Location = New Point(178, 183)
        numQuantity.Margin = New Padding(3, 3, 3, 10)
        numQuantity.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numQuantity.Name = "numQuantity"
        numQuantity.Size = New Size(200, 31)
        numQuantity.TabIndex = 9
        '
        ' lblUnit
        '
        lblUnit.Anchor = AnchorStyles.Left
        lblUnit.AutoSize = True
        lblUnit.Location = New Point(3, 234)
        lblUnit.Name = "lblUnit"
        lblUnit.Size = New Size(48, 25)
        lblUnit.TabIndex = 10
        lblUnit.Text = "Unit:"
        '
        ' txtUnit
        '
        txtUnit.Anchor = AnchorStyles.Left
        txtUnit.Location = New Point(178, 227)
        txtUnit.Margin = New Padding(3, 3, 3, 10)
        txtUnit.Name = "txtUnit"
        txtUnit.PlaceholderText = "e.g. kg, unit, bottle"
        txtUnit.Size = New Size(200, 31)
        txtUnit.TabIndex = 11
        '
        ' lblReorder
        '
        lblReorder.Anchor = AnchorStyles.Left
        lblReorder.AutoSize = True
        lblReorder.Location = New Point(3, 278)
        lblReorder.Name = "lblReorder"
        lblReorder.Size = New Size(161, 25)
        lblReorder.TabIndex = 12
        lblReorder.Text = "Reorder Threshold:"
        '
        ' numReorderThreshold
        '
        numReorderThreshold.Anchor = AnchorStyles.Left
        numReorderThreshold.Location = New Point(178, 271)
        numReorderThreshold.Margin = New Padding(3, 3, 3, 10)
        numReorderThreshold.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numReorderThreshold.Name = "numReorderThreshold"
        numReorderThreshold.Size = New Size(200, 31)
        numReorderThreshold.TabIndex = 13
        '
        ' lblBulkQty
        '
        lblBulkQty.Anchor = AnchorStyles.Left
        lblBulkQty.AutoSize = True
        lblBulkQty.Location = New Point(3, 322)
        lblBulkQty.Name = "lblBulkQty"
        lblBulkQty.Size = New Size(122, 25)
        lblBulkQty.TabIndex = 14
        lblBulkQty.Text = "Bulk Quantity:"
        '
        ' numBulkQuantity
        '
        numBulkQuantity.Anchor = AnchorStyles.Left
        numBulkQuantity.Location = New Point(178, 315)
        numBulkQuantity.Margin = New Padding(3, 3, 3, 10)
        numBulkQuantity.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numBulkQuantity.Name = "numBulkQuantity"
        numBulkQuantity.Size = New Size(200, 31)
        numBulkQuantity.TabIndex = 15
        '
        ' lblBulkDiscount
        '
        lblBulkDiscount.Anchor = AnchorStyles.Left
        lblBulkDiscount.AutoSize = True
        lblBulkDiscount.Location = New Point(3, 366)
        lblBulkDiscount.Name = "lblBulkDiscount"
        lblBulkDiscount.Size = New Size(154, 25)
        lblBulkDiscount.TabIndex = 16
        lblBulkDiscount.Text = "Bulk Discount (%):"
        '
        ' numBulkDiscount
        '
        numBulkDiscount.Anchor = AnchorStyles.Left
        numBulkDiscount.DecimalPlaces = 2
        numBulkDiscount.Location = New Point(178, 359)
        numBulkDiscount.Margin = New Padding(3, 3, 3, 10)
        numBulkDiscount.Name = "numBulkDiscount"
        numBulkDiscount.Size = New Size(200, 31)
        numBulkDiscount.TabIndex = 17
        '
        ' btnAddProduct
        '
        btnAddProduct.Anchor = AnchorStyles.Left
        btnAddProduct.Location = New Point(178, 415)
        btnAddProduct.Margin = New Padding(3, 15, 3, 3)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(200, 45)
        btnAddProduct.TabIndex = 18
        btnAddProduct.Text = "Add Product"
        btnAddProduct.UseVisualStyleBackColor = True
        '
        ' GroupBox2
        '
        GroupBox2.Controls.Add(tlpSupplierForm)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(765, 18)
        GroupBox2.Margin = New Padding(3, 3, 3, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(12)
        GroupBox2.Size = New Size(742, 429)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Add New Supplier"
        '
        ' tlpSupplierForm
        '
        tlpSupplierForm.ColumnCount = 2
        tlpSupplierForm.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
        tlpSupplierForm.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpSupplierForm.Controls.Add(Label1, 0, 0)
        tlpSupplierForm.Controls.Add(txtSupplierName, 1, 0)
        tlpSupplierForm.Controls.Add(Label2, 0, 1)
        tlpSupplierForm.Controls.Add(txtSupplierPhone, 1, 1)
        tlpSupplierForm.Controls.Add(Label3, 0, 2)
        tlpSupplierForm.Controls.Add(txtSupplierEmail, 1, 2)
        tlpSupplierForm.Controls.Add(btnAddSupplier, 1, 3)
        tlpSupplierForm.Dock = DockStyle.Fill
        tlpSupplierForm.Location = New Point(12, 37)
        tlpSupplierForm.Name = "tlpSupplierForm"
        tlpSupplierForm.RowCount = 5
        tlpSupplierForm.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpSupplierForm.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpSupplierForm.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpSupplierForm.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpSupplierForm.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpSupplierForm.Size = New Size(718, 380)
        tlpSupplierForm.TabIndex = 0
        '
        ' Label1
        '
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(3, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 25)
        Label1.TabIndex = 0
        Label1.Text = "Supplier Name:"
        '
        ' txtSupplierName
        '
        txtSupplierName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtSupplierName.Location = New Point(160, 3)
        txtSupplierName.Margin = New Padding(3, 3, 3, 10)
        txtSupplierName.Name = "txtSupplierName"
        txtSupplierName.Size = New Size(555, 31)
        txtSupplierName.TabIndex = 1
        '
        ' Label2
        '
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(3, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 25)
        Label2.TabIndex = 2
        Label2.Text = "Phone Number:"
        '
        ' txtSupplierPhone
        '
        txtSupplierPhone.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtSupplierPhone.Location = New Point(160, 47)
        txtSupplierPhone.Margin = New Padding(3, 3, 3, 10)
        txtSupplierPhone.Name = "txtSupplierPhone"
        txtSupplierPhone.Size = New Size(555, 31)
        txtSupplierPhone.TabIndex = 3
        '
        ' Label3
        '
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(3, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 25)
        Label3.TabIndex = 4
        Label3.Text = "Email:"
        '
        ' txtSupplierEmail
        '
        txtSupplierEmail.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtSupplierEmail.Location = New Point(160, 91)
        txtSupplierEmail.Margin = New Padding(3, 3, 3, 10)
        txtSupplierEmail.Name = "txtSupplierEmail"
        txtSupplierEmail.Size = New Size(555, 31)
        txtSupplierEmail.TabIndex = 5
        '
        ' btnAddSupplier
        '
        btnAddSupplier.Anchor = AnchorStyles.Right
        btnAddSupplier.Location = New Point(532, 147)
        btnAddSupplier.Margin = New Padding(3, 15, 3, 3)
        btnAddSupplier.Name = "btnAddSupplier"
        btnAddSupplier.Size = New Size(183, 45)
        btnAddSupplier.TabIndex = 6
        btnAddSupplier.Text = "Add Supplier"
        btnAddSupplier.UseVisualStyleBackColor = True
        '
        ' GroupBox3
        '
        GroupBox3.Controls.Add(tlpCategoryForm)
        GroupBox3.Dock = DockStyle.Fill
        GroupBox3.Location = New Point(765, 465)
        GroupBox3.Margin = New Padding(3, 6, 3, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(12)
        GroupBox3.Size = New Size(742, 441)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Add New Category"
        '
        ' tlpCategoryForm
        '
        tlpCategoryForm.ColumnCount = 2
        tlpCategoryForm.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
        tlpCategoryForm.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpCategoryForm.Controls.Add(lblCategoryName, 0, 0)
        tlpCategoryForm.Controls.Add(txtCategoryName, 1, 0)
        tlpCategoryForm.Controls.Add(lblTaxRate, 0, 1)
        tlpCategoryForm.Controls.Add(numTaxRate, 1, 1)
        tlpCategoryForm.Controls.Add(btnAddCategory, 1, 2)
        tlpCategoryForm.Dock = DockStyle.Fill
        tlpCategoryForm.Location = New Point(12, 37)
        tlpCategoryForm.Name = "tlpCategoryForm"
        tlpCategoryForm.RowCount = 4
        tlpCategoryForm.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpCategoryForm.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpCategoryForm.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        tlpCategoryForm.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpCategoryForm.Size = New Size(718, 392)
        tlpCategoryForm.TabIndex = 0
        '
        ' lblCategoryName
        '
        lblCategoryName.Anchor = AnchorStyles.Left
        lblCategoryName.AutoSize = True
        lblCategoryName.Location = New Point(3, 10)
        lblCategoryName.Name = "lblCategoryName"
        lblCategoryName.Size = New Size(139, 25)
        lblCategoryName.TabIndex = 0
        lblCategoryName.Text = "Category Name:"
        '
        ' txtCategoryName
        '
        txtCategoryName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtCategoryName.Location = New Point(166, 3)
        txtCategoryName.Margin = New Padding(3, 3, 3, 10)
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.Size = New Size(549, 31)
        txtCategoryName.TabIndex = 1
        '
        ' lblTaxRate
        '
        lblTaxRate.Anchor = AnchorStyles.Left
        lblTaxRate.AutoSize = True
        lblTaxRate.Location = New Point(3, 54)
        lblTaxRate.Name = "lblTaxRate"
        lblTaxRate.Size = New Size(119, 25)
        lblTaxRate.TabIndex = 2
        lblTaxRate.Text = "Tax Rate (%):"
        '
        ' numTaxRate
        '
        numTaxRate.Anchor = AnchorStyles.Left
        numTaxRate.DecimalPlaces = 2
        numTaxRate.Location = New Point(166, 47)
        numTaxRate.Margin = New Padding(3, 3, 3, 10)
        numTaxRate.Name = "numTaxRate"
        numTaxRate.Size = New Size(200, 31)
        numTaxRate.TabIndex = 3
        '
        ' btnAddCategory
        '
        btnAddCategory.Anchor = AnchorStyles.Right
        btnAddCategory.Location = New Point(532, 103)
        btnAddCategory.Margin = New Padding(3, 15, 3, 3)
        btnAddCategory.Name = "btnAddCategory"
        btnAddCategory.Size = New Size(183, 45)
        btnAddCategory.TabIndex = 4
        btnAddCategory.Text = "Add Category"
        btnAddCategory.UseVisualStyleBackColor = True
        '
        ' ucProductForm
        '
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(tlpRoot)
        MinimumSize = New Size(1000, 700)
        Name = "ucProductForm"
        Size = New Size(1525, 924)
        tlpRoot.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        tlpProduct.ResumeLayout(False)
        tlpProduct.PerformLayout()
        CType(numUnitPrice, ComponentModel.ISupportInitialize).EndInit()
        CType(numQuantity, ComponentModel.ISupportInitialize).EndInit()
        CType(numReorderThreshold, ComponentModel.ISupportInitialize).EndInit()
        CType(numBulkQuantity, ComponentModel.ISupportInitialize).EndInit()
        CType(numBulkDiscount, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        tlpSupplierForm.ResumeLayout(False)
        tlpSupplierForm.PerformLayout()
        GroupBox3.ResumeLayout(False)
        tlpCategoryForm.ResumeLayout(False)
        tlpCategoryForm.PerformLayout()
        CType(numTaxRate, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlpRoot As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tlpProduct As TableLayoutPanel
    Friend WithEvents lblName As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents lblSupplier As Label
    Friend WithEvents cboSupplier As ComboBox
    Friend WithEvents lblUnitPrice As Label
    Friend WithEvents numUnitPrice As NumericUpDown
    Friend WithEvents lblQuantity As Label
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents lblUnit As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents lblReorder As Label
    Friend WithEvents numReorderThreshold As NumericUpDown
    Friend WithEvents lblBulkQty As Label
    Friend WithEvents numBulkQuantity As NumericUpDown
    Friend WithEvents lblBulkDiscount As Label
    Friend WithEvents numBulkDiscount As NumericUpDown
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tlpSupplierForm As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSupplierPhone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSupplierEmail As TextBox
    Friend WithEvents btnAddSupplier As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tlpCategoryForm As TableLayoutPanel
    Friend WithEvents lblCategoryName As Label
    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents lblTaxRate As Label
    Friend WithEvents numTaxRate As NumericUpDown
    Friend WithEvents btnAddCategory As Button

End Class

