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
        Label1 = New Label()
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
        CType(numUnitPrice, ComponentModel.ISupportInitialize).BeginInit()
        CType(numQuantity, ComponentModel.ISupportInitialize).BeginInit()
        CType(numReorderThreshold, ComponentModel.ISupportInitialize).BeginInit()
        CType(numBulkQuantity, ComponentModel.ISupportInitialize).BeginInit()
        CType(numBulkDiscount, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' Label1
        '
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Label1.Location = New Point(44, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 38)
        Label1.TabIndex = 0
        Label1.Text = "Add New Product"
        '
        ' lblName
        '
        lblName.AutoSize = True
        lblName.Location = New Point(44, 110)
        lblName.Name = "lblName"
        lblName.Size = New Size(133, 25)
        lblName.Text = "Product Name:"
        '
        ' txtProductName
        '
        txtProductName.Location = New Point(300, 107)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(320, 31)
        txtProductName.TabIndex = 1
        '
        ' lblCategory
        '
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(44, 165)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(90, 25)
        lblCategory.Text = "Category:"
        '
        ' cboCategory
        '
        cboCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategory.Location = New Point(300, 162)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(320, 33)
        cboCategory.TabIndex = 2
        '
        ' lblSupplier
        '
        lblSupplier.AutoSize = True
        lblSupplier.Location = New Point(44, 220)
        lblSupplier.Name = "lblSupplier"
        lblSupplier.Size = New Size(84, 25)
        lblSupplier.Text = "Supplier:"
        '
        ' cboSupplier
        '
        cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList
        cboSupplier.Location = New Point(300, 217)
        cboSupplier.Name = "cboSupplier"
        cboSupplier.Size = New Size(320, 33)
        cboSupplier.TabIndex = 3
        '
        ' lblUnitPrice
        '
        lblUnitPrice.AutoSize = True
        lblUnitPrice.Location = New Point(44, 275)
        lblUnitPrice.Name = "lblUnitPrice"
        lblUnitPrice.Size = New Size(96, 25)
        lblUnitPrice.Text = "Unit Price:"
        '
        ' numUnitPrice
        '
        numUnitPrice.DecimalPlaces = 2
        numUnitPrice.Increment = New Decimal(New Integer() {10, 0, 0, 131072})
        numUnitPrice.Location = New Point(300, 272)
        numUnitPrice.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numUnitPrice.Name = "numUnitPrice"
        numUnitPrice.Size = New Size(200, 31)
        numUnitPrice.TabIndex = 4
        '
        ' lblQuantity
        '
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(44, 330)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(89, 25)
        lblQuantity.Text = "Quantity:"
        '
        ' numQuantity
        '
        numQuantity.Location = New Point(300, 327)
        numQuantity.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numQuantity.Name = "numQuantity"
        numQuantity.Size = New Size(200, 31)
        numQuantity.TabIndex = 5
        '
        ' lblUnit
        '
        lblUnit.AutoSize = True
        lblUnit.Location = New Point(44, 385)
        lblUnit.Name = "lblUnit"
        lblUnit.Size = New Size(53, 25)
        lblUnit.Text = "Unit:"
        '
        ' txtUnit
        '
        txtUnit.Location = New Point(300, 382)
        txtUnit.Name = "txtUnit"
        txtUnit.PlaceholderText = "e.g. kg, unit, bottle"
        txtUnit.Size = New Size(200, 31)
        txtUnit.TabIndex = 6
        '
        ' lblReorder
        '
        lblReorder.AutoSize = True
        lblReorder.Location = New Point(44, 440)
        lblReorder.Name = "lblReorder"
        lblReorder.Size = New Size(179, 25)
        lblReorder.Text = "Reorder Threshold:"
        '
        ' numReorderThreshold
        '
        numReorderThreshold.Location = New Point(300, 437)
        numReorderThreshold.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numReorderThreshold.Name = "numReorderThreshold"
        numReorderThreshold.Size = New Size(200, 31)
        numReorderThreshold.TabIndex = 7
        '
        ' lblBulkQty
        '
        lblBulkQty.AutoSize = True
        lblBulkQty.Location = New Point(44, 495)
        lblBulkQty.Name = "lblBulkQty"
        lblBulkQty.Size = New Size(151, 25)
        lblBulkQty.Text = "Bulk Quantity:"
        '
        ' numBulkQuantity
        '
        numBulkQuantity.Location = New Point(300, 492)
        numBulkQuantity.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        numBulkQuantity.Name = "numBulkQuantity"
        numBulkQuantity.Size = New Size(200, 31)
        numBulkQuantity.TabIndex = 8
        '
        ' lblBulkDiscount
        '
        lblBulkDiscount.AutoSize = True
        lblBulkDiscount.Location = New Point(44, 550)
        lblBulkDiscount.Name = "lblBulkDiscount"
        lblBulkDiscount.Size = New Size(172, 25)
        lblBulkDiscount.Text = "Bulk Discount (%):"
        '
        ' numBulkDiscount
        '
        numBulkDiscount.DecimalPlaces = 2
        numBulkDiscount.Location = New Point(300, 547)
        numBulkDiscount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        numBulkDiscount.Name = "numBulkDiscount"
        numBulkDiscount.Size = New Size(200, 31)
        numBulkDiscount.TabIndex = 9
        '
        ' btnAddProduct
        '
        btnAddProduct.Location = New Point(300, 620)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(200, 45)
        btnAddProduct.TabIndex = 10
        btnAddProduct.Text = "Add Product"
        btnAddProduct.UseVisualStyleBackColor = True
        '
        ' ucProductForm
        '
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnAddProduct)
        Controls.Add(numBulkDiscount)
        Controls.Add(lblBulkDiscount)
        Controls.Add(numBulkQuantity)
        Controls.Add(lblBulkQty)
        Controls.Add(numReorderThreshold)
        Controls.Add(lblReorder)
        Controls.Add(txtUnit)
        Controls.Add(lblUnit)
        Controls.Add(numQuantity)
        Controls.Add(lblQuantity)
        Controls.Add(numUnitPrice)
        Controls.Add(lblUnitPrice)
        Controls.Add(cboSupplier)
        Controls.Add(lblSupplier)
        Controls.Add(cboCategory)
        Controls.Add(lblCategory)
        Controls.Add(txtProductName)
        Controls.Add(lblName)
        Controls.Add(Label1)
        MinimumSize = New Size(1525, 924)
        Name = "ucProductForm"
        Size = New Size(1525, 924)
        CType(numUnitPrice, ComponentModel.ISupportInitialize).EndInit()
        CType(numQuantity, ComponentModel.ISupportInitialize).EndInit()
        CType(numReorderThreshold, ComponentModel.ISupportInitialize).EndInit()
        CType(numBulkQuantity, ComponentModel.ISupportInitialize).EndInit()
        CType(numBulkDiscount, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
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

End Class
