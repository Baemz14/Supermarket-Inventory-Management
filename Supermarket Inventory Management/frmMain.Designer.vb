<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        mnuView = New ToolStripMenuItem()
        mnuAddProduct = New ToolStripMenuItem()
        EmployeesToolStripMenuItem = New ToolStripMenuItem()
        mnuDashboard = New ToolStripMenuItem()
        mnuLogout = New ToolStripMenuItem()
        pnlContent = New Panel()
        SalesCounterToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuView, SalesCounterToolStripMenuItem, mnuAddProduct, EmployeesToolStripMenuItem, mnuDashboard, mnuLogout})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1525, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuView
        ' 
        mnuView.Name = "mnuView"
        mnuView.Size = New Size(145, 29)
        mnuView.Text = "View Inventory"
        ' 
        ' mnuAddProduct
        ' 
        mnuAddProduct.Name = "mnuAddProduct"
        mnuAddProduct.Size = New Size(113, 29)
        mnuAddProduct.Text = "Add To DB"
        ' 
        ' EmployeesToolStripMenuItem
        ' 
        EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        EmployeesToolStripMenuItem.Size = New Size(114, 29)
        EmployeesToolStripMenuItem.Text = "Employees"
        ' 
        ' mnuDashboard
        ' 
        mnuDashboard.Name = "mnuDashboard"
        mnuDashboard.Size = New Size(93, 29)
        mnuDashboard.Text = "Account"
        ' 
        ' mnuLogout
        ' 
        mnuLogout.Name = "mnuLogout"
        mnuLogout.Size = New Size(85, 29)
        mnuLogout.Text = "Logout"
        ' 
        ' pnlContent
        ' 
        pnlContent.AutoScroll = True
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 33)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1525, 924)
        pnlContent.TabIndex = 1
        ' 
        ' SalesCounterToolStripMenuItem
        ' 
        SalesCounterToolStripMenuItem.Name = "SalesCounterToolStripMenuItem"
        SalesCounterToolStripMenuItem.Size = New Size(136, 29)
        SalesCounterToolStripMenuItem.Text = "Sales Counter"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1525, 957)
        Controls.Add(pnlContent)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        MinimumSize = New Size(1547, 1013)
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Supermarket Inventory Management"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuAddProduct As ToolStripMenuItem
    Friend WithEvents mnuDashboard As ToolStripMenuItem
    Friend WithEvents mnuView As ToolStripMenuItem
    Friend WithEvents pnlContent As Panel
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents EmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesCounterToolStripMenuItem As ToolStripMenuItem

End Class
