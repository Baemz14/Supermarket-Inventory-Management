<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucView
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
        flpSearch = New FlowLayoutPanel()
        Label1 = New Label()
        txtKeyword = New TextBox()
        dgvProducts = New DataGridView()
        GroupBox1 = New GroupBox()
        tlpQuantity = New TableLayoutPanel()
        Label2 = New Label()
        lblQuantity = New Label()
        lblUnitInQuantity = New Label()
        Label8 = New Label()
        cboReason = New ComboBox()
        Label10 = New Label()
        txtQuantityChange = New TextBox()
        lblQuantChangeIsPos = New Label()
        flpQuantityButtons = New FlowLayoutPanel()
        btnQuantityConfirm = New Button()
        btnResetQuantity = New Button()
        tlpBottomLeft = New TableLayoutPanel()
        GroupBox2 = New GroupBox()
        tlpSupplier = New TableLayoutPanel()
        Label3 = New Label()
        lblSupplier = New Label()
        Label9 = New Label()
        lblDiscount = New Label()
        Label12 = New Label()
        Label11 = New Label()
        lblMinBulk = New Label()
        lblUnitInSupplier = New Label()
        GroupBox3 = New GroupBox()
        tlpBulk = New TableLayoutPanel()
        Label4 = New Label()
        lblBulkPrice = New Label()
        Label5 = New Label()
        lblBulkDiscountPrice = New Label()
        Label13 = New Label()
        lblPriceAfterBulk = New Label()
        Label14 = New Label()
        txtQuantityBuy = New TextBox()
        flpBulkButtons = New FlowLayoutPanel()
        btnBulkBuyConfirm = New Button()
        btnBulkBuyReset = New Button()
        GroupBox4 = New GroupBox()
        tlpPrice = New TableLayoutPanel()
        Label6 = New Label()
        lblPrice = New Label()
        Label7 = New Label()
        txtNewPrice = New TextBox()
        flpPriceButtons = New FlowLayoutPanel()
        btnPriceConfirm = New Button()
        btnPriceReset = New Button()
        tlpRoot.SuspendLayout()
        flpSearch.SuspendLayout()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        tlpQuantity.SuspendLayout()
        flpQuantityButtons.SuspendLayout()
        tlpBottomLeft.SuspendLayout()
        GroupBox2.SuspendLayout()
        tlpSupplier.SuspendLayout()
        GroupBox3.SuspendLayout()
        tlpBulk.SuspendLayout()
        flpBulkButtons.SuspendLayout()
        GroupBox4.SuspendLayout()
        tlpPrice.SuspendLayout()
        flpPriceButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' tlpRoot
        ' 
        tlpRoot.ColumnCount = 2
        tlpRoot.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 62.3411369F))
        tlpRoot.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 37.6588631F))
        tlpRoot.Controls.Add(flpSearch, 0, 0)
        tlpRoot.Controls.Add(dgvProducts, 0, 1)
        tlpRoot.Controls.Add(GroupBox1, 1, 1)
        tlpRoot.Controls.Add(tlpBottomLeft, 0, 2)
        tlpRoot.Controls.Add(GroupBox4, 1, 2)
        tlpRoot.Dock = DockStyle.Fill
        tlpRoot.Location = New Point(0, 0)
        tlpRoot.Name = "tlpRoot"
        tlpRoot.Padding = New Padding(15)
        tlpRoot.RowCount = 3
        tlpRoot.RowStyles.Add(New RowStyle())
        tlpRoot.RowStyles.Add(New RowStyle(SizeType.Percent, 52F))
        tlpRoot.RowStyles.Add(New RowStyle(SizeType.Percent, 48F))
        tlpRoot.Size = New Size(1525, 924)
        tlpRoot.TabIndex = 0
        ' 
        ' flpSearch
        ' 
        flpSearch.AutoSize = True
        flpSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpSearch.Controls.Add(Label1)
        flpSearch.Controls.Add(txtKeyword)
        flpSearch.Location = New Point(18, 18)
        flpSearch.Name = "flpSearch"
        flpSearch.Size = New Size(465, 37)
        flpSearch.TabIndex = 0
        flpSearch.WrapContents = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(3, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 25)
        Label1.TabIndex = 0
        Label1.Text = "Keywords:"
        ' 
        ' txtKeyword
        ' 
        txtKeyword.Anchor = AnchorStyles.Left
        txtKeyword.Location = New Point(102, 3)
        txtKeyword.Name = "txtKeyword"
        txtKeyword.Size = New Size(360, 31)
        txtKeyword.TabIndex = 1
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AllowUserToAddRows = False
        dgvProducts.AllowUserToDeleteRows = False
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Dock = DockStyle.Fill
        dgvProducts.Location = New Point(18, 61)
        dgvProducts.Margin = New Padding(3, 3, 12, 12)
        dgvProducts.MultiSelect = False
        dgvProducts.Name = "dgvProducts"
        dgvProducts.ReadOnly = True
        dgvProducts.RowHeadersVisible = False
        dgvProducts.RowHeadersWidth = 62
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProducts.Size = New Size(917, 427)
        dgvProducts.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(tlpQuantity)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Location = New Point(950, 61)
        GroupBox1.Margin = New Padding(3, 3, 3, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(12)
        GroupBox1.Size = New Size(557, 427)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Update Quantity"
        ' 
        ' tlpQuantity
        ' 
        tlpQuantity.ColumnCount = 3
        tlpQuantity.ColumnStyles.Add(New ColumnStyle())
        tlpQuantity.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpQuantity.ColumnStyles.Add(New ColumnStyle())
        tlpQuantity.Controls.Add(Label2, 0, 0)
        tlpQuantity.Controls.Add(lblQuantity, 1, 0)
        tlpQuantity.Controls.Add(lblUnitInQuantity, 2, 0)
        tlpQuantity.Controls.Add(Label8, 0, 1)
        tlpQuantity.Controls.Add(cboReason, 1, 1)
        tlpQuantity.Controls.Add(flpQuantityButtons, 0, 3)
        tlpQuantity.Controls.Add(txtQuantityChange, 1, 2)
        tlpQuantity.Controls.Add(Label10, 0, 2)
        tlpQuantity.Controls.Add(lblQuantChangeIsPos, 2, 2)
        tlpQuantity.Dock = DockStyle.Fill
        tlpQuantity.Location = New Point(12, 36)
        tlpQuantity.Name = "tlpQuantity"
        tlpQuantity.RowCount = 5
        tlpQuantity.RowStyles.Add(New RowStyle())
        tlpQuantity.RowStyles.Add(New RowStyle())
        tlpQuantity.RowStyles.Add(New RowStyle())
        tlpQuantity.RowStyles.Add(New RowStyle())
        tlpQuantity.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpQuantity.Size = New Size(533, 379)
        tlpQuantity.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(3, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 25)
        Label2.TabIndex = 0
        Label2.Text = "Current quantity:"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblQuantity.BorderStyle = BorderStyle.Fixed3D
        lblQuantity.Location = New Point(158, 3)
        lblQuantity.Margin = New Padding(3, 3, 3, 8)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(297, 38)
        lblQuantity.TabIndex = 1
        lblQuantity.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblUnitInQuantity
        ' 
        lblUnitInQuantity.Anchor = AnchorStyles.Left
        lblUnitInQuantity.BorderStyle = BorderStyle.Fixed3D
        lblUnitInQuantity.Location = New Point(461, 3)
        lblUnitInQuantity.Margin = New Padding(3, 3, 3, 8)
        lblUnitInQuantity.Name = "lblUnitInQuantity"
        lblUnitInQuantity.Size = New Size(69, 38)
        lblUnitInQuantity.TabIndex = 2
        lblUnitInQuantity.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Location = New Point(3, 58)
        Label8.Name = "Label8"
        Label8.Size = New Size(138, 25)
        Label8.TabIndex = 3
        Label8.Text = "Change Reason:"
        ' 
        ' cboReason
        ' 
        cboReason.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cboReason.DropDownStyle = ComboBoxStyle.DropDownList
        cboReason.FormattingEnabled = True
        cboReason.Items.AddRange(New Object() {"Sold", "Arrived", "Removed", "Damaged", "Expired", "Shrinkage", "Internal Usage", "Customer Return", "Audit Correction"})
        cboReason.Location = New Point(158, 52)
        cboReason.Margin = New Padding(3, 3, 3, 8)
        cboReason.Name = "cboReason"
        cboReason.Size = New Size(297, 33)
        cboReason.TabIndex = 4
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Left
        Label10.AutoSize = True
        Label10.Location = New Point(3, 101)
        Label10.Name = "Label10"
        Label10.Size = New Size(149, 25)
        Label10.TabIndex = 5
        Label10.Text = "Quantity Change:"
        ' 
        ' txtQuantityChange
        ' 
        txtQuantityChange.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtQuantityChange.Location = New Point(158, 96)
        txtQuantityChange.Margin = New Padding(3, 3, 3, 8)
        txtQuantityChange.Name = "txtQuantityChange"
        txtQuantityChange.Size = New Size(297, 31)
        txtQuantityChange.TabIndex = 6
        ' 
        ' lblQuantChangeIsPos
        ' 
        lblQuantChangeIsPos.Anchor = AnchorStyles.Left
        lblQuantChangeIsPos.AutoSize = True
        lblQuantChangeIsPos.Location = New Point(461, 101)
        lblQuantChangeIsPos.Name = "lblQuantChangeIsPos"
        lblQuantChangeIsPos.Size = New Size(48, 25)
        lblQuantChangeIsPos.TabIndex = 7
        lblQuantChangeIsPos.Text = "(+/-)"
        ' 
        ' flpQuantityButtons
        ' 
        flpQuantityButtons.Anchor = AnchorStyles.Right
        flpQuantityButtons.AutoSize = True
        flpQuantityButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpQuantity.SetColumnSpan(flpQuantityButtons, 3)
        flpQuantityButtons.Controls.Add(btnQuantityConfirm)
        flpQuantityButtons.Controls.Add(btnResetQuantity)
        flpQuantityButtons.Location = New Point(294, 147)
        flpQuantityButtons.Margin = New Padding(3, 12, 3, 3)
        flpQuantityButtons.Name = "flpQuantityButtons"
        flpQuantityButtons.Size = New Size(236, 40)
        flpQuantityButtons.TabIndex = 8
        flpQuantityButtons.WrapContents = False
        ' 
        ' btnQuantityConfirm
        ' 
        btnQuantityConfirm.Location = New Point(3, 3)
        btnQuantityConfirm.Name = "btnQuantityConfirm"
        btnQuantityConfirm.Size = New Size(112, 34)
        btnQuantityConfirm.TabIndex = 0
        btnQuantityConfirm.Text = "Confirm"
        btnQuantityConfirm.UseVisualStyleBackColor = True
        ' 
        ' btnResetQuantity
        ' 
        btnResetQuantity.Location = New Point(121, 3)
        btnResetQuantity.Name = "btnResetQuantity"
        btnResetQuantity.Size = New Size(112, 34)
        btnResetQuantity.TabIndex = 1
        btnResetQuantity.Text = "Reset"
        btnResetQuantity.UseVisualStyleBackColor = True
        ' 
        ' tlpBottomLeft
        ' 
        tlpBottomLeft.ColumnCount = 2
        tlpBottomLeft.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpBottomLeft.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpBottomLeft.Controls.Add(GroupBox2, 0, 0)
        tlpBottomLeft.Controls.Add(GroupBox3, 1, 0)
        tlpBottomLeft.Dock = DockStyle.Fill
        tlpBottomLeft.Location = New Point(15, 500)
        tlpBottomLeft.Margin = New Padding(0)
        tlpBottomLeft.Name = "tlpBottomLeft"
        tlpBottomLeft.RowCount = 1
        tlpBottomLeft.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpBottomLeft.Size = New Size(932, 409)
        tlpBottomLeft.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(tlpSupplier)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(3, 3)
        GroupBox2.Margin = New Padding(3, 3, 6, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(12)
        GroupBox2.Size = New Size(457, 403)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "Supplier Data"
        ' 
        ' tlpSupplier
        ' 
        tlpSupplier.ColumnCount = 3
        tlpSupplier.ColumnStyles.Add(New ColumnStyle())
        tlpSupplier.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpSupplier.ColumnStyles.Add(New ColumnStyle())
        tlpSupplier.Controls.Add(Label3, 0, 0)
        tlpSupplier.Controls.Add(lblSupplier, 1, 0)
        tlpSupplier.Controls.Add(Label9, 0, 1)
        tlpSupplier.Controls.Add(lblDiscount, 1, 1)
        tlpSupplier.Controls.Add(Label12, 2, 1)
        tlpSupplier.Controls.Add(Label11, 0, 2)
        tlpSupplier.Controls.Add(lblMinBulk, 1, 2)
        tlpSupplier.Controls.Add(lblUnitInSupplier, 2, 2)
        tlpSupplier.Dock = DockStyle.Fill
        tlpSupplier.Location = New Point(12, 36)
        tlpSupplier.Name = "tlpSupplier"
        tlpSupplier.RowCount = 4
        tlpSupplier.RowStyles.Add(New RowStyle())
        tlpSupplier.RowStyles.Add(New RowStyle())
        tlpSupplier.RowStyles.Add(New RowStyle())
        tlpSupplier.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpSupplier.Size = New Size(433, 355)
        tlpSupplier.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(3, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 25)
        Label3.TabIndex = 0
        Label3.Text = "Supplier:"
        ' 
        ' lblSupplier
        ' 
        lblSupplier.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblSupplier.BorderStyle = BorderStyle.Fixed3D
        tlpSupplier.SetColumnSpan(lblSupplier, 2)
        lblSupplier.Location = New Point(164, 3)
        lblSupplier.Margin = New Padding(3, 3, 3, 8)
        lblSupplier.Name = "lblSupplier"
        lblSupplier.Size = New Size(266, 38)
        lblSupplier.TabIndex = 1
        lblSupplier.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Left
        Label9.AutoSize = True
        Label9.Location = New Point(3, 61)
        Label9.Name = "Label9"
        Label9.Size = New Size(122, 25)
        Label9.TabIndex = 2
        Label9.Text = "Bulk discount:"
        ' 
        ' lblDiscount
        ' 
        lblDiscount.Anchor = AnchorStyles.Left
        lblDiscount.BorderStyle = BorderStyle.Fixed3D
        lblDiscount.Location = New Point(164, 52)
        lblDiscount.Margin = New Padding(3, 3, 3, 8)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(90, 38)
        lblDiscount.TabIndex = 3
        lblDiscount.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Left
        Label12.AutoSize = True
        Label12.Location = New Point(363, 61)
        Label12.Name = "Label12"
        Label12.Size = New Size(27, 25)
        Label12.TabIndex = 4
        Label12.Text = "%"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Left
        Label11.AutoSize = True
        Label11.Location = New Point(3, 110)
        Label11.Name = "Label11"
        Label11.Size = New Size(155, 25)
        Label11.TabIndex = 5
        Label11.Text = "Min bulk quantity:"
        ' 
        ' lblMinBulk
        ' 
        lblMinBulk.Anchor = AnchorStyles.Left
        lblMinBulk.BorderStyle = BorderStyle.Fixed3D
        lblMinBulk.Location = New Point(164, 101)
        lblMinBulk.Margin = New Padding(3, 3, 3, 8)
        lblMinBulk.Name = "lblMinBulk"
        lblMinBulk.Size = New Size(136, 38)
        lblMinBulk.TabIndex = 6
        lblMinBulk.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblUnitInSupplier
        ' 
        lblUnitInSupplier.Anchor = AnchorStyles.Left
        lblUnitInSupplier.BorderStyle = BorderStyle.Fixed3D
        lblUnitInSupplier.Location = New Point(363, 101)
        lblUnitInSupplier.Margin = New Padding(3, 3, 3, 8)
        lblUnitInSupplier.Name = "lblUnitInSupplier"
        lblUnitInSupplier.Size = New Size(67, 38)
        lblUnitInSupplier.TabIndex = 7
        lblUnitInSupplier.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(tlpBulk)
        GroupBox3.Dock = DockStyle.Fill
        GroupBox3.Location = New Point(472, 3)
        GroupBox3.Margin = New Padding(6, 3, 3, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(12)
        GroupBox3.Size = New Size(457, 403)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "Buy in Bulk"
        ' 
        ' tlpBulk
        ' 
        tlpBulk.ColumnCount = 2
        tlpBulk.ColumnStyles.Add(New ColumnStyle())
        tlpBulk.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpBulk.Controls.Add(Label4, 0, 0)
        tlpBulk.Controls.Add(lblBulkPrice, 1, 0)
        tlpBulk.Controls.Add(Label5, 0, 1)
        tlpBulk.Controls.Add(lblBulkDiscountPrice, 1, 1)
        tlpBulk.Controls.Add(Label13, 0, 2)
        tlpBulk.Controls.Add(lblPriceAfterBulk, 1, 2)
        tlpBulk.Controls.Add(Label14, 0, 3)
        tlpBulk.Controls.Add(txtQuantityBuy, 1, 3)
        tlpBulk.Controls.Add(flpBulkButtons, 0, 4)
        tlpBulk.Dock = DockStyle.Fill
        tlpBulk.Location = New Point(12, 36)
        tlpBulk.Name = "tlpBulk"
        tlpBulk.RowCount = 6
        tlpBulk.RowStyles.Add(New RowStyle())
        tlpBulk.RowStyles.Add(New RowStyle())
        tlpBulk.RowStyles.Add(New RowStyle())
        tlpBulk.RowStyles.Add(New RowStyle())
        tlpBulk.RowStyles.Add(New RowStyle())
        tlpBulk.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpBulk.Size = New Size(433, 355)
        tlpBulk.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New Point(3, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 25)
        Label4.TabIndex = 0
        Label4.Text = "Price:"
        ' 
        ' lblBulkPrice
        ' 
        lblBulkPrice.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblBulkPrice.BorderStyle = BorderStyle.Fixed3D
        lblBulkPrice.Location = New Point(176, 3)
        lblBulkPrice.Margin = New Padding(3, 3, 3, 8)
        lblBulkPrice.Name = "lblBulkPrice"
        lblBulkPrice.Size = New Size(254, 38)
        lblBulkPrice.TabIndex = 1
        lblBulkPrice.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Location = New Point(3, 61)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 25)
        Label5.TabIndex = 2
        Label5.Text = "Bulk discount:"
        ' 
        ' lblBulkDiscountPrice
        ' 
        lblBulkDiscountPrice.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblBulkDiscountPrice.BorderStyle = BorderStyle.Fixed3D
        lblBulkDiscountPrice.Location = New Point(176, 52)
        lblBulkDiscountPrice.Margin = New Padding(3, 3, 3, 8)
        lblBulkDiscountPrice.Name = "lblBulkDiscountPrice"
        lblBulkDiscountPrice.Size = New Size(254, 38)
        lblBulkDiscountPrice.TabIndex = 3
        lblBulkDiscountPrice.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Left
        Label13.AutoSize = True
        Label13.Location = New Point(3, 110)
        Label13.Name = "Label13"
        Label13.Size = New Size(167, 25)
        Label13.TabIndex = 4
        Label13.Text = "Price after discount:"
        ' 
        ' lblPriceAfterBulk
        ' 
        lblPriceAfterBulk.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblPriceAfterBulk.BorderStyle = BorderStyle.Fixed3D
        lblPriceAfterBulk.Location = New Point(176, 101)
        lblPriceAfterBulk.Margin = New Padding(3, 3, 3, 8)
        lblPriceAfterBulk.Name = "lblPriceAfterBulk"
        lblPriceAfterBulk.Size = New Size(254, 38)
        lblPriceAfterBulk.TabIndex = 5
        lblPriceAfterBulk.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Left
        Label14.AutoSize = True
        Label14.Location = New Point(3, 155)
        Label14.Name = "Label14"
        Label14.Size = New Size(140, 25)
        Label14.TabIndex = 6
        Label14.Text = "Quantity to Buy:"
        ' 
        ' txtQuantityBuy
        ' 
        txtQuantityBuy.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtQuantityBuy.Location = New Point(176, 150)
        txtQuantityBuy.Margin = New Padding(3, 3, 3, 8)
        txtQuantityBuy.Name = "txtQuantityBuy"
        txtQuantityBuy.Size = New Size(254, 31)
        txtQuantityBuy.TabIndex = 7
        ' 
        ' flpBulkButtons
        ' 
        flpBulkButtons.Anchor = AnchorStyles.Right
        flpBulkButtons.AutoSize = True
        flpBulkButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpBulk.SetColumnSpan(flpBulkButtons, 2)
        flpBulkButtons.Controls.Add(btnBulkBuyConfirm)
        flpBulkButtons.Controls.Add(btnBulkBuyReset)
        flpBulkButtons.Location = New Point(194, 201)
        flpBulkButtons.Margin = New Padding(3, 12, 3, 3)
        flpBulkButtons.Name = "flpBulkButtons"
        flpBulkButtons.Size = New Size(236, 40)
        flpBulkButtons.TabIndex = 8
        flpBulkButtons.WrapContents = False
        ' 
        ' btnBulkBuyConfirm
        ' 
        btnBulkBuyConfirm.Location = New Point(3, 3)
        btnBulkBuyConfirm.Name = "btnBulkBuyConfirm"
        btnBulkBuyConfirm.Size = New Size(112, 34)
        btnBulkBuyConfirm.TabIndex = 0
        btnBulkBuyConfirm.Text = "Confirm"
        btnBulkBuyConfirm.UseVisualStyleBackColor = True
        ' 
        ' btnBulkBuyReset
        ' 
        btnBulkBuyReset.Location = New Point(121, 3)
        btnBulkBuyReset.Name = "btnBulkBuyReset"
        btnBulkBuyReset.Size = New Size(112, 34)
        btnBulkBuyReset.TabIndex = 1
        btnBulkBuyReset.Text = "Reset"
        btnBulkBuyReset.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(tlpPrice)
        GroupBox4.Dock = DockStyle.Fill
        GroupBox4.Location = New Point(950, 503)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(12)
        GroupBox4.Size = New Size(557, 403)
        GroupBox4.TabIndex = 4
        GroupBox4.TabStop = False
        GroupBox4.Text = "Update Price"
        ' 
        ' tlpPrice
        ' 
        tlpPrice.ColumnCount = 2
        tlpPrice.ColumnStyles.Add(New ColumnStyle())
        tlpPrice.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpPrice.Controls.Add(Label6, 0, 0)
        tlpPrice.Controls.Add(lblPrice, 1, 0)
        tlpPrice.Controls.Add(Label7, 0, 1)
        tlpPrice.Controls.Add(txtNewPrice, 1, 1)
        tlpPrice.Controls.Add(flpPriceButtons, 0, 2)
        tlpPrice.Dock = DockStyle.Fill
        tlpPrice.Location = New Point(12, 36)
        tlpPrice.Name = "tlpPrice"
        tlpPrice.RowCount = 4
        tlpPrice.RowStyles.Add(New RowStyle())
        tlpPrice.RowStyles.Add(New RowStyle())
        tlpPrice.RowStyles.Add(New RowStyle())
        tlpPrice.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpPrice.Size = New Size(533, 355)
        tlpPrice.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Location = New Point(3, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 25)
        Label6.TabIndex = 0
        Label6.Text = "Current price:"
        ' 
        ' lblPrice
        ' 
        lblPrice.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        lblPrice.BorderStyle = BorderStyle.Fixed3D
        lblPrice.Location = New Point(126, 3)
        lblPrice.Margin = New Padding(3, 3, 3, 8)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(404, 38)
        lblPrice.TabIndex = 1
        lblPrice.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Location = New Point(3, 57)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 25)
        Label7.TabIndex = 2
        Label7.Text = "New Price:"
        ' 
        ' txtNewPrice
        ' 
        txtNewPrice.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtNewPrice.Location = New Point(126, 52)
        txtNewPrice.Margin = New Padding(3, 3, 3, 8)
        txtNewPrice.Name = "txtNewPrice"
        txtNewPrice.Size = New Size(404, 31)
        txtNewPrice.TabIndex = 3
        ' 
        ' flpPriceButtons
        ' 
        flpPriceButtons.Anchor = AnchorStyles.Right
        flpPriceButtons.AutoSize = True
        flpPriceButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlpPrice.SetColumnSpan(flpPriceButtons, 2)
        flpPriceButtons.Controls.Add(btnPriceConfirm)
        flpPriceButtons.Controls.Add(btnPriceReset)
        flpPriceButtons.Location = New Point(294, 103)
        flpPriceButtons.Margin = New Padding(3, 12, 3, 3)
        flpPriceButtons.Name = "flpPriceButtons"
        flpPriceButtons.Size = New Size(236, 40)
        flpPriceButtons.TabIndex = 4
        flpPriceButtons.WrapContents = False
        ' 
        ' btnPriceConfirm
        ' 
        btnPriceConfirm.Location = New Point(3, 3)
        btnPriceConfirm.Name = "btnPriceConfirm"
        btnPriceConfirm.Size = New Size(112, 34)
        btnPriceConfirm.TabIndex = 0
        btnPriceConfirm.Text = "Confirm"
        btnPriceConfirm.UseVisualStyleBackColor = True
        ' 
        ' btnPriceReset
        ' 
        btnPriceReset.Location = New Point(121, 3)
        btnPriceReset.Name = "btnPriceReset"
        btnPriceReset.Size = New Size(112, 34)
        btnPriceReset.TabIndex = 1
        btnPriceReset.Text = "Reset"
        btnPriceReset.UseVisualStyleBackColor = True
        ' 
        ' ucView
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(tlpRoot)
        MinimumSize = New Size(1000, 700)
        Name = "ucView"
        Size = New Size(1525, 924)
        tlpRoot.ResumeLayout(False)
        tlpRoot.PerformLayout()
        flpSearch.ResumeLayout(False)
        flpSearch.PerformLayout()
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        tlpQuantity.ResumeLayout(False)
        tlpQuantity.PerformLayout()
        flpQuantityButtons.ResumeLayout(False)
        tlpBottomLeft.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        tlpSupplier.ResumeLayout(False)
        tlpSupplier.PerformLayout()
        GroupBox3.ResumeLayout(False)
        tlpBulk.ResumeLayout(False)
        tlpBulk.PerformLayout()
        flpBulkButtons.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        tlpPrice.ResumeLayout(False)
        tlpPrice.PerformLayout()
        flpPriceButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlpRoot As TableLayoutPanel
    Friend WithEvents flpSearch As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKeyword As TextBox
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tlpQuantity As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblUnitInQuantity As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboReason As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtQuantityChange As TextBox
    Friend WithEvents lblQuantChangeIsPos As Label
    Friend WithEvents flpQuantityButtons As FlowLayoutPanel
    Friend WithEvents btnQuantityConfirm As Button
    Friend WithEvents btnResetQuantity As Button
    Friend WithEvents tlpBottomLeft As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tlpSupplier As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSupplier As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblMinBulk As Label
    Friend WithEvents lblUnitInSupplier As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tlpBulk As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblBulkPrice As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblBulkDiscountPrice As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblPriceAfterBulk As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtQuantityBuy As TextBox
    Friend WithEvents flpBulkButtons As FlowLayoutPanel
    Friend WithEvents btnBulkBuyConfirm As Button
    Friend WithEvents btnBulkBuyReset As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tlpPrice As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNewPrice As TextBox
    Friend WithEvents flpPriceButtons As FlowLayoutPanel
    Friend WithEvents btnPriceConfirm As Button
    Friend WithEvents btnPriceReset As Button

End Class

