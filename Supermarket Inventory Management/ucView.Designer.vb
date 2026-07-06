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
        TextBox3 = New TextBox()
        Label10 = New Label()
        ComboBox1 = New ComboBox()
        Label8 = New Label()
        Button2 = New Button()
        lblQuantity = New Label()
        Button1 = New Button()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        Label6 = New Label()
        lblPrice = New Label()
        GroupBox4 = New GroupBox()
        Button4 = New Button()
        Button3 = New Button()
        txtNewPrice = New TextBox()
        Label7 = New Label()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox4.SuspendLayout()
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
        dgvProducts.Size = New Size(819, 419)
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
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(lblQuantity)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(957, 76)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(495, 364)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Update Quantity"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(220, 214)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(233, 31)
        TextBox3.TabIndex = 12
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(27, 214)
        Label10.Name = "Label10"
        Label10.Size = New Size(187, 25)
        Label10.TabIndex = 11
        Label10.Text = "Quantity change (+/-):"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Sold", "Arrived", "Removed", "Damaged", "Expired", "Shrinkage", "Internal Usage", "Customer Return", "Audit Correction"})
        ComboBox1.Location = New Point(220, 135)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(229, 33)
        ComboBox1.TabIndex = 9
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
        ' Button2
        ' 
        Button2.Location = New Point(253, 298)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 7
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lblQuantity
        ' 
        lblQuantity.BorderStyle = BorderStyle.Fixed3D
        lblQuantity.Location = New Point(220, 57)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(229, 38)
        lblQuantity.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(102, 298)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 6
        Button1.Text = "Confirm"
        Button1.UseVisualStyleBackColor = True
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
        GroupBox2.Location = New Point(62, 530)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(819, 337)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Supplier Data"
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
        GroupBox4.Controls.Add(Button4)
        GroupBox4.Controls.Add(Button3)
        GroupBox4.Controls.Add(txtNewPrice)
        GroupBox4.Controls.Add(lblPrice)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Controls.Add(Label7)
        GroupBox4.Location = New Point(957, 480)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(495, 287)
        GroupBox4.TabIndex = 8
        GroupBox4.TabStop = False
        GroupBox4.Text = "Update Price"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(253, 204)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 6
        Button4.Text = "Reset"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(102, 204)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 5
        Button3.Text = "Confirm"
        Button3.UseVisualStyleBackColor = True
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
        ' ucView
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
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
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtNewPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label10 As Label

End Class
