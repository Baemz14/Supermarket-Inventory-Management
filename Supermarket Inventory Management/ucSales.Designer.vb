<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSales
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
        Label1 = New Label()
        txtKeyword = New TextBox()
        GroupBox1 = New GroupBox()
        lvCart = New ListView()
        Product = New ColumnHeader()
        Qty = New ColumnHeader()
        Price = New ColumnHeader()
        GroupBox2 = New GroupBox()
        btnAddToCart = New Button()
        txtQuantityToBuy = New TextBox()
        lblStockQuantity = New Label()
        lblPrice = New Label()
        lblProduct = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnConfirmTransaction = New Button()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AllowUserToAddRows = False
        dgvProducts.AllowUserToDeleteRows = False
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(18, 65)
        dgvProducts.MultiSelect = False
        dgvProducts.Name = "dgvProducts"
        dgvProducts.ReadOnly = True
        dgvProducts.RowHeadersVisible = False
        dgvProducts.RowHeadersWidth = 62
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProducts.Size = New Size(773, 415)
        dgvProducts.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 25)
        Label1.TabIndex = 1
        Label1.Text = "Keyword:"
        ' 
        ' txtKeyword
        ' 
        txtKeyword.Location = New Point(143, 13)
        txtKeyword.Name = "txtKeyword"
        txtKeyword.Size = New Size(150, 31)
        txtKeyword.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnConfirmTransaction)
        GroupBox1.Controls.Add(lvCart)
        GroupBox1.Location = New Point(844, 76)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(630, 797)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cart"
        ' 
        ' lvCart
        ' 
        lvCart.Columns.AddRange(New ColumnHeader() {Product, Qty, Price})
        lvCart.FullRowSelect = True
        lvCart.Location = New Point(58, 91)
        lvCart.Name = "lvCart"
        lvCart.Size = New Size(365, 146)
        lvCart.TabIndex = 0
        lvCart.UseCompatibleStateImageBehavior = False
        lvCart.View = View.Details
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnAddToCart)
        GroupBox2.Controls.Add(txtQuantityToBuy)
        GroupBox2.Controls.Add(lblStockQuantity)
        GroupBox2.Controls.Add(lblPrice)
        GroupBox2.Controls.Add(lblProduct)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(43, 523)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(736, 330)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Selected Product"
        ' 
        ' btnAddToCart
        ' 
        btnAddToCart.Location = New Point(171, 275)
        btnAddToCart.Name = "btnAddToCart"
        btnAddToCart.Size = New Size(112, 34)
        btnAddToCart.TabIndex = 8
        btnAddToCart.Text = "Add to Cart"
        btnAddToCart.UseVisualStyleBackColor = True
        ' 
        ' txtQuantityToBuy
        ' 
        txtQuantityToBuy.Location = New Point(185, 194)
        txtQuantityToBuy.Name = "txtQuantityToBuy"
        txtQuantityToBuy.Size = New Size(150, 31)
        txtQuantityToBuy.TabIndex = 7
        ' 
        ' lblStockQuantity
        ' 
        lblStockQuantity.BorderStyle = BorderStyle.Fixed3D
        lblStockQuantity.Location = New Point(203, 147)
        lblStockQuantity.Name = "lblStockQuantity"
        lblStockQuantity.Size = New Size(94, 38)
        lblStockQuantity.TabIndex = 6
        ' 
        ' lblPrice
        ' 
        lblPrice.BorderStyle = BorderStyle.Fixed3D
        lblPrice.Location = New Point(168, 99)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(94, 38)
        lblPrice.TabIndex = 5
        ' 
        ' lblProduct
        ' 
        lblProduct.BorderStyle = BorderStyle.Fixed3D
        lblProduct.Location = New Point(168, 53)
        lblProduct.Name = "lblProduct"
        lblProduct.Size = New Size(176, 38)
        lblProduct.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(86, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 25)
        Label5.TabIndex = 3
        Label5.Text = "Quantity:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 25)
        Label4.TabIndex = 2
        Label4.Text = "Stock Quantity:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(62, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 25)
        Label3.TabIndex = 1
        Label3.Text = "Price:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 0
        Label2.Text = "Product:"
        ' 
        ' btnConfirmTransaction
        ' 
        btnConfirmTransaction.Location = New Point(104, 626)
        btnConfirmTransaction.Name = "btnConfirmTransaction"
        btnConfirmTransaction.Size = New Size(187, 34)
        btnConfirmTransaction.TabIndex = 1
        btnConfirmTransaction.Text = "Confirm Transaction"
        btnConfirmTransaction.UseVisualStyleBackColor = True
        ' 
        ' ucSales
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(txtKeyword)
        Controls.Add(Label1)
        Controls.Add(dgvProducts)
        Name = "ucSales"
        Size = New Size(1525, 924)
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKeyword As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lvCart As ListView
    Friend WithEvents Product As ColumnHeader
    Friend WithEvents Qty As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQuantityToBuy As TextBox
    Friend WithEvents lblStockQuantity As Label
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents btnConfirmTransaction As Button

End Class
