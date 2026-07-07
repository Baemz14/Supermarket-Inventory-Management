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
        dgvProducts = New DataGridView()
        txtKeyword = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Label10 = New Label()
        lblUnitInQuantity = New Label()
        txtQuantityChange = New TextBox()
        lblQuantChangeIsPos = New Label()
        cboReason = New ComboBox()
        Label8 = New Label()
        btnResetQuantity = New Button()
        lblQuantity = New Label()
        btnQuantityConfirm = New Button()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        lblUnitInSupplier = New Label()
        lblMinBulk = New Label()
        Label12 = New Label()
        lblDiscount = New Label()
        lblSupplier = New Label()
        Label11 = New Label()
        Label9 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        lblPrice = New Label()
        GroupBox4 = New GroupBox()
        btnPriceReset = New Button()
        btnPriceConfirm = New Button()
        txtNewPrice = New TextBox()
        Label7 = New Label()
        GroupBox3 = New GroupBox()
        Label15 = New Label()
        btnBulkBuyReset = New Button()
        btnBulkBuyConfirm = New Button()
        txtQuantityBuy = New TextBox()
        Label14 = New Label()
        lblPriceAfterBulk = New Label()
        lblBulkDiscountPrice = New Label()
        lblBulkPrice = New Label()
        Label13 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AllowUserToAddRows = False
        dgvProducts.AllowUserToDeleteRows = False
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(62, 85)
        dgvProducts.MultiSelect = False
        dgvProducts.Name = "dgvProducts"
        dgvProducts.ReadOnly = True
        dgvProducts.RowHeadersVisible = False
        dgvProducts.RowHeadersWidth = 62
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProducts.Size = New Size(878, 394)
        dgvProducts.TabIndex = 1
        ' 
        ' txtKeyword
        ' 
        txtKeyword.Location = New Point(166, 17)
        txtKeyword.Name = "txtKeyword"
        txtKeyword.Size = New Size(360, 31)
        txtKeyword.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(67, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 25)
        Label1.TabIndex = 3
        Label1.Text = "Keywords:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(lblUnitInQuantity)
        GroupBox1.Controls.Add(txtQuantityChange)
        GroupBox1.Controls.Add(lblQuantChangeIsPos)
        GroupBox1.Controls.Add(cboReason)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(btnResetQuantity)
        GroupBox1.Controls.Add(lblQuantity)
        GroupBox1.Controls.Add(btnQuantityConfirm)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(986, 76)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(495, 364)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Update Quantity"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(23, 220)
        Label10.Name = "Label10"
        Label10.Size = New Size(149, 25)
        Label10.TabIndex = 14
        Label10.Text = "Quantity Change:"
        ' 
        ' lblUnitInQuantity
        ' 
        lblUnitInQuantity.BorderStyle = BorderStyle.Fixed3D
        lblUnitInQuantity.Location = New Point(384, 56)
        lblUnitInQuantity.Name = "lblUnitInQuantity"
        lblUnitInQuantity.Size = New Size(69, 38)
        lblUnitInQuantity.TabIndex = 13
        ' 
        ' txtQuantityChange
        ' 
        txtQuantityChange.Location = New Point(220, 214)
        txtQuantityChange.Name = "txtQuantityChange"
        txtQuantityChange.Size = New Size(233, 31)
        txtQuantityChange.TabIndex = 12
        ' 
        ' lblQuantChangeIsPos
        ' 
        lblQuantChangeIsPos.AutoSize = True
        lblQuantChangeIsPos.Location = New Point(166, 220)
        lblQuantChangeIsPos.Name = "lblQuantChangeIsPos"
        lblQuantChangeIsPos.Size = New Size(48, 25)
        lblQuantChangeIsPos.TabIndex = 11
        lblQuantChangeIsPos.Text = "(+/-)"
        ' 
        ' cboReason
        ' 
        cboReason.DropDownStyle = ComboBoxStyle.DropDownList
        cboReason.FormattingEnabled = True
        cboReason.Items.AddRange(New Object() {"Sold", "Arrived", "Removed", "Damaged", "Expired", "Shrinkage", "Internal Usage", "Customer Return", "Audit Correction"})
        cboReason.Location = New Point(220, 135)
        cboReason.Name = "cboReason"
        cboReason.Size = New Size(229, 33)
        cboReason.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(74, 135)
        Label8.Name = "Label8"
        Label8.Size = New Size(138, 25)
        Label8.TabIndex = 8
        Label8.Text = "Change Reason:"
        ' 
        ' btnResetQuantity
        ' 
        btnResetQuantity.Location = New Point(253, 298)
        btnResetQuantity.Name = "btnResetQuantity"
        btnResetQuantity.Size = New Size(112, 34)
        btnResetQuantity.TabIndex = 7
        btnResetQuantity.Text = "Reset"
        btnResetQuantity.UseVisualStyleBackColor = True
        ' 
        ' lblQuantity
        ' 
        lblQuantity.BorderStyle = BorderStyle.Fixed3D
        lblQuantity.Location = New Point(220, 57)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(158, 38)
        lblQuantity.TabIndex = 2
        ' 
        ' btnQuantityConfirm
        ' 
        btnQuantityConfirm.Location = New Point(102, 298)
        btnQuantityConfirm.Name = "btnQuantityConfirm"
        btnQuantityConfirm.Size = New Size(112, 34)
        btnQuantityConfirm.TabIndex = 6
        btnQuantityConfirm.Text = "Confirm"
        btnQuantityConfirm.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(68, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 25)
        Label2.TabIndex = 0
        Label2.Text = "Current quantity:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblUnitInSupplier)
        GroupBox2.Controls.Add(lblMinBulk)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(lblDiscount)
        GroupBox2.Controls.Add(lblSupplier)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(62, 502)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(417, 365)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Supplier Data"
        ' 
        ' lblUnitInSupplier
        ' 
        lblUnitInSupplier.BorderStyle = BorderStyle.Fixed3D
        lblUnitInSupplier.Location = New Point(316, 176)
        lblUnitInSupplier.Name = "lblUnitInSupplier"
        lblUnitInSupplier.Size = New Size(67, 38)
        lblUnitInSupplier.TabIndex = 7
        ' 
        ' lblMinBulk
        ' 
        lblMinBulk.BorderStyle = BorderStyle.Fixed3D
        lblMinBulk.Location = New Point(174, 177)
        lblMinBulk.Name = "lblMinBulk"
        lblMinBulk.Size = New Size(136, 38)
        lblMinBulk.TabIndex = 6
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(242, 131)
        Label12.Name = "Label12"
        Label12.Size = New Size(27, 25)
        Label12.TabIndex = 5
        Label12.Text = "%"
        ' 
        ' lblDiscount
        ' 
        lblDiscount.BorderStyle = BorderStyle.Fixed3D
        lblDiscount.Location = New Point(174, 118)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(62, 38)
        lblDiscount.TabIndex = 4
        ' 
        ' lblSupplier
        ' 
        lblSupplier.BorderStyle = BorderStyle.Fixed3D
        lblSupplier.Location = New Point(174, 58)
        lblSupplier.Name = "lblSupplier"
        lblSupplier.Size = New Size(209, 38)
        lblSupplier.TabIndex = 3
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(13, 177)
        Label11.Name = "Label11"
        Label11.Size = New Size(155, 25)
        Label11.TabIndex = 2
        Label11.Text = "Min bulk quantity:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(46, 118)
        Label9.Name = "Label9"
        Label9.Size = New Size(122, 25)
        Label9.TabIndex = 1
        Label9.Text = "Bulk discount:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(87, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 25)
        Label3.TabIndex = 0
        Label3.Text = "Supplier:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(93, 53)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 25)
        Label6.TabIndex = 1
        Label6.Text = "Current price:"
        ' 
        ' lblPrice
        ' 
        lblPrice.BorderStyle = BorderStyle.Fixed3D
        lblPrice.Location = New Point(220, 53)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(229, 38)
        lblPrice.TabIndex = 3
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(btnPriceReset)
        GroupBox4.Controls.Add(btnPriceConfirm)
        GroupBox4.Controls.Add(txtNewPrice)
        GroupBox4.Controls.Add(lblPrice)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Controls.Add(Label7)
        GroupBox4.Location = New Point(986, 479)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(495, 287)
        GroupBox4.TabIndex = 8
        GroupBox4.TabStop = False
        GroupBox4.Text = "Update Price"
        ' 
        ' btnPriceReset
        ' 
        btnPriceReset.Location = New Point(253, 204)
        btnPriceReset.Name = "btnPriceReset"
        btnPriceReset.Size = New Size(112, 34)
        btnPriceReset.TabIndex = 6
        btnPriceReset.Text = "Reset"
        btnPriceReset.UseVisualStyleBackColor = True
        ' 
        ' btnPriceConfirm
        ' 
        btnPriceConfirm.Location = New Point(102, 204)
        btnPriceConfirm.Name = "btnPriceConfirm"
        btnPriceConfirm.Size = New Size(112, 34)
        btnPriceConfirm.TabIndex = 5
        btnPriceConfirm.Text = "Confirm"
        btnPriceConfirm.UseVisualStyleBackColor = True
        ' 
        ' txtNewPrice
        ' 
        txtNewPrice.Location = New Point(220, 123)
        txtNewPrice.Name = "txtNewPrice"
        txtNewPrice.Size = New Size(229, 31)
        txtNewPrice.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(117, 123)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 25)
        Label7.TabIndex = 0
        Label7.Text = "New Price:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(btnBulkBuyReset)
        GroupBox3.Controls.Add(btnBulkBuyConfirm)
        GroupBox3.Controls.Add(txtQuantityBuy)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Controls.Add(lblPriceAfterBulk)
        GroupBox3.Controls.Add(lblBulkDiscountPrice)
        GroupBox3.Controls.Add(lblBulkPrice)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Location = New Point(505, 502)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(435, 365)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        GroupBox3.Text = "Buy in Bulk"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(164, 205)
        Label15.Name = "Label15"
        Label15.Size = New Size(0, 25)
        Label15.TabIndex = 10
        ' 
        ' btnBulkBuyReset
        ' 
        btnBulkBuyReset.Location = New Point(248, 287)
        btnBulkBuyReset.Name = "btnBulkBuyReset"
        btnBulkBuyReset.Size = New Size(112, 34)
        btnBulkBuyReset.TabIndex = 9
        btnBulkBuyReset.Text = "Reset"
        btnBulkBuyReset.UseVisualStyleBackColor = True
        ' 
        ' btnBulkBuyConfirm
        ' 
        btnBulkBuyConfirm.Location = New Point(79, 287)
        btnBulkBuyConfirm.Name = "btnBulkBuyConfirm"
        btnBulkBuyConfirm.Size = New Size(112, 34)
        btnBulkBuyConfirm.TabIndex = 8
        btnBulkBuyConfirm.Text = "Confirm"
        btnBulkBuyConfirm.UseVisualStyleBackColor = True
        ' 
        ' txtQuantityBuy
        ' 
        txtQuantityBuy.Location = New Point(207, 218)
        txtQuantityBuy.Name = "txtQuantityBuy"
        txtQuantityBuy.Size = New Size(181, 31)
        txtQuantityBuy.TabIndex = 7
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(61, 221)
        Label14.Name = "Label14"
        Label14.Size = New Size(140, 25)
        Label14.TabIndex = 6
        Label14.Text = "Quantity to Buy:"
        ' 
        ' lblPriceAfterBulk
        ' 
        lblPriceAfterBulk.BorderStyle = BorderStyle.Fixed3D
        lblPriceAfterBulk.Location = New Point(207, 150)
        lblPriceAfterBulk.Name = "lblPriceAfterBulk"
        lblPriceAfterBulk.Size = New Size(181, 38)
        lblPriceAfterBulk.TabIndex = 5
        ' 
        ' lblBulkDiscountPrice
        ' 
        lblBulkDiscountPrice.BorderStyle = BorderStyle.Fixed3D
        lblBulkDiscountPrice.Location = New Point(207, 94)
        lblBulkDiscountPrice.Name = "lblBulkDiscountPrice"
        lblBulkDiscountPrice.Size = New Size(181, 38)
        lblBulkDiscountPrice.TabIndex = 4
        ' 
        ' lblBulkPrice
        ' 
        lblBulkPrice.BorderStyle = BorderStyle.Fixed3D
        lblBulkPrice.Location = New Point(207, 41)
        lblBulkPrice.Name = "lblBulkPrice"
        lblBulkPrice.Size = New Size(181, 38)
        lblBulkPrice.TabIndex = 3
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(34, 154)
        Label13.Name = "Label13"
        Label13.Size = New Size(167, 25)
        Label13.TabIndex = 2
        Label13.Text = "Price after discount:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(79, 95)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 25)
        Label5.TabIndex = 1
        Label5.Text = "Bulk discount:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(148, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 25)
        Label4.TabIndex = 0
        Label4.Text = "Price:"
        ' 
        ' ucView
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(txtKeyword)
        Controls.Add(dgvProducts)
        MinimumSize = New Size(1525, 924)
        Name = "ucView"
        Size = New Size(1525, 924)
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents txtKeyword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtQuantityBuy As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnResetQuantity As Button
    Friend WithEvents btnQuantityConfirm As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtNewPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnPriceReset As Button
    Friend WithEvents btnPriceConfirm As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtQuantityChange As TextBox
    Friend WithEvents lblQuantChangeIsPos As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblUnitInSupplier As Label
    Friend WithEvents lblMinBulk As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblSupplier As Label
    Friend WithEvents lblUnitInQuantity As Label
    Friend WithEvents cboReason As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblPriceAfterBulk As Label
    Friend WithEvents lblBulkDiscountPrice As Label
    Friend WithEvents lblBulkPrice As Label
    Friend WithEvents btnBulkBuyReset As Button
    Friend WithEvents btnBulkBuyConfirm As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label

End Class
