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
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        txtSupplierEmail = New TextBox()
        txtSupplierPhone = New TextBox()
        txtSupplierName = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox3 = New GroupBox()
        btnAddSupplier = New Button()
        CType(numUnitPrice, ComponentModel.ISupportInitialize).BeginInit()
        CType(numQuantity, ComponentModel.ISupportInitialize).BeginInit()
        CType(numReorderThreshold, ComponentModel.ISupportInitialize).BeginInit()
        CType(numBulkQuantity, ComponentModel.ISupportInitialize).BeginInit()
        CType(numBulkDiscount, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(62, 64)
        lblName.Name = "lblName"
        lblName.Size = New Size(130, 25)
        lblName.TabIndex = 19
        lblName.Text = "Product Name:"
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(318, 61)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(320, 31)
        txtProductName.TabIndex = 1
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(62, 119)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(88, 25)
        lblCategory.TabIndex = 18
        lblCategory.Text = "Category:"
        ' 
        ' cboCategory
        ' 
        cboCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategory.Location = New Point(318, 116)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(320, 33)
        cboCategory.TabIndex = 2
        ' 
        ' lblSupplier
        ' 
        lblSupplier.AutoSize = True
        lblSupplier.Location = New Point(62, 174)
        lblSupplier.Name = "lblSupplier"
        lblSupplier.Size = New Size(81, 25)
        lblSupplier.TabIndex = 17
        lblSupplier.Text = "Supplier:"
        ' 
        ' cboSupplier
        ' 
        cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList
        cboSupplier.Location = New Point(318, 171)
        cboSupplier.Name = "cboSupplier"
        cboSupplier.Size = New Size(320, 33)
        cboSupplier.TabIndex = 3
        ' 
        ' lblUnitPrice
        ' 
        lblUnitPrice.AutoSize = True
        lblUnitPrice.Location = New Point(62, 229)
        lblUnitPrice.Name = "lblUnitPrice"
        lblUnitPrice.Size = New Size(90, 25)
        lblUnitPrice.TabIndex = 16
        lblUnitPrice.Text = "Unit Price:"
        ' 
        ' numUnitPrice
        ' 
        numUnitPrice.DecimalPlaces = 2
        numUnitPrice.Increment = New Decimal(New Integer() {10, 0, 0, 131072})
        numUnitPrice.Location = New Point(318, 226)
        numUnitPrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numUnitPrice.Name = "numUnitPrice"
        numUnitPrice.Size = New Size(200, 31)
        numUnitPrice.TabIndex = 4
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(62, 284)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(84, 25)
        lblQuantity.TabIndex = 15
        lblQuantity.Text = "Quantity:"
        ' 
        ' numQuantity
        ' 
        numQuantity.Location = New Point(318, 281)
        numQuantity.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numQuantity.Name = "numQuantity"
        numQuantity.Size = New Size(200, 31)
        numQuantity.TabIndex = 5
        ' 
        ' lblUnit
        ' 
        lblUnit.AutoSize = True
        lblUnit.Location = New Point(62, 339)
        lblUnit.Name = "lblUnit"
        lblUnit.Size = New Size(48, 25)
        lblUnit.TabIndex = 14
        lblUnit.Text = "Unit:"
        ' 
        ' txtUnit
        ' 
        txtUnit.Location = New Point(318, 336)
        txtUnit.Name = "txtUnit"
        txtUnit.PlaceholderText = "e.g. kg, unit, bottle"
        txtUnit.Size = New Size(200, 31)
        txtUnit.TabIndex = 6
        ' 
        ' lblReorder
        ' 
        lblReorder.AutoSize = True
        lblReorder.Location = New Point(62, 394)
        lblReorder.Name = "lblReorder"
        lblReorder.Size = New Size(161, 25)
        lblReorder.TabIndex = 13
        lblReorder.Text = "Reorder Threshold:"
        ' 
        ' numReorderThreshold
        ' 
        numReorderThreshold.Location = New Point(318, 391)
        numReorderThreshold.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numReorderThreshold.Name = "numReorderThreshold"
        numReorderThreshold.Size = New Size(200, 31)
        numReorderThreshold.TabIndex = 7
        ' 
        ' lblBulkQty
        ' 
        lblBulkQty.AutoSize = True
        lblBulkQty.Location = New Point(62, 449)
        lblBulkQty.Name = "lblBulkQty"
        lblBulkQty.Size = New Size(122, 25)
        lblBulkQty.TabIndex = 12
        lblBulkQty.Text = "Bulk Quantity:"
        ' 
        ' numBulkQuantity
        ' 
        numBulkQuantity.Location = New Point(318, 446)
        numBulkQuantity.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numBulkQuantity.Name = "numBulkQuantity"
        numBulkQuantity.Size = New Size(200, 31)
        numBulkQuantity.TabIndex = 8
        ' 
        ' lblBulkDiscount
        ' 
        lblBulkDiscount.AutoSize = True
        lblBulkDiscount.Location = New Point(62, 504)
        lblBulkDiscount.Name = "lblBulkDiscount"
        lblBulkDiscount.Size = New Size(154, 25)
        lblBulkDiscount.TabIndex = 11
        lblBulkDiscount.Text = "Bulk Discount (%):"
        ' 
        ' numBulkDiscount
        ' 
        numBulkDiscount.DecimalPlaces = 2
        numBulkDiscount.Location = New Point(318, 501)
        numBulkDiscount.Name = "numBulkDiscount"
        numBulkDiscount.Size = New Size(200, 31)
        numBulkDiscount.TabIndex = 9
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.Location = New Point(318, 574)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(200, 45)
        btnAddProduct.TabIndex = 10
        btnAddProduct.Text = "Add Product"
        btnAddProduct.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtUnit)
        GroupBox1.Controls.Add(btnAddProduct)
        GroupBox1.Controls.Add(lblName)
        GroupBox1.Controls.Add(numBulkDiscount)
        GroupBox1.Controls.Add(txtProductName)
        GroupBox1.Controls.Add(lblBulkDiscount)
        GroupBox1.Controls.Add(lblCategory)
        GroupBox1.Controls.Add(numBulkQuantity)
        GroupBox1.Controls.Add(cboCategory)
        GroupBox1.Controls.Add(lblBulkQty)
        GroupBox1.Controls.Add(lblSupplier)
        GroupBox1.Controls.Add(numReorderThreshold)
        GroupBox1.Controls.Add(cboSupplier)
        GroupBox1.Controls.Add(lblReorder)
        GroupBox1.Controls.Add(lblUnitPrice)
        GroupBox1.Controls.Add(numUnitPrice)
        GroupBox1.Controls.Add(lblUnit)
        GroupBox1.Controls.Add(lblQuantity)
        GroupBox1.Controls.Add(numQuantity)
        GroupBox1.Location = New Point(40, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(668, 691)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add New Product"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnAddSupplier)
        GroupBox2.Controls.Add(txtSupplierEmail)
        GroupBox2.Controls.Add(txtSupplierPhone)
        GroupBox2.Controls.Add(txtSupplierName)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(806, 41)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(653, 337)
        GroupBox2.TabIndex = 21
        GroupBox2.TabStop = False
        GroupBox2.Text = "Add New Supplier"
        ' 
        ' txtSupplierEmail
        ' 
        txtSupplierEmail.Location = New Point(279, 171)
        txtSupplierEmail.Name = "txtSupplierEmail"
        txtSupplierEmail.Size = New Size(277, 31)
        txtSupplierEmail.TabIndex = 5
        ' 
        ' txtSupplierPhone
        ' 
        txtSupplierPhone.Location = New Point(279, 116)
        txtSupplierPhone.Name = "txtSupplierPhone"
        txtSupplierPhone.Size = New Size(277, 31)
        txtSupplierPhone.TabIndex = 4
        ' 
        ' txtSupplierName
        ' 
        txtSupplierName.Location = New Point(279, 61)
        txtSupplierName.Name = "txtSupplierName"
        txtSupplierName.Size = New Size(277, 31)
        txtSupplierName.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(155, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 25)
        Label3.TabIndex = 2
        Label3.Text = "Email:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(77, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 25)
        Label2.TabIndex = 1
        Label2.Text = "Phone Number:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(80, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 25)
        Label1.TabIndex = 0
        Label1.Text = "Supplier Name:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Location = New Point(806, 452)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(653, 319)
        GroupBox3.TabIndex = 22
        GroupBox3.TabStop = False
        GroupBox3.Text = "Add New Category"
        ' 
        ' btnAddSupplier
        ' 
        btnAddSupplier.Location = New Point(339, 255)
        btnAddSupplier.Name = "btnAddSupplier"
        btnAddSupplier.Size = New Size(183, 45)
        btnAddSupplier.TabIndex = 6
        btnAddSupplier.Text = "Add Supplier"
        btnAddSupplier.UseVisualStyleBackColor = True
        ' 
        ' ucProductForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        MinimumSize = New Size(1525, 924)
        Name = "ucProductForm"
        Size = New Size(1525, 924)
        CType(numUnitPrice, ComponentModel.ISupportInitialize).EndInit()
        CType(numQuantity, ComponentModel.ISupportInitialize).EndInit()
        CType(numReorderThreshold, ComponentModel.ISupportInitialize).EndInit()
        CType(numBulkQuantity, ComponentModel.ISupportInitialize).EndInit()
        CType(numBulkDiscount, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtSupplierPhone As TextBox
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSupplierEmail As TextBox
    Friend WithEvents btnAddSupplier As Button

End Class
