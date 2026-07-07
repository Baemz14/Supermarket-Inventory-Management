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
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvEmployeeChanges, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvEmployees
        ' 
        dgvEmployees.AllowUserToAddRows = False
        dgvEmployees.AllowUserToDeleteRows = False
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployees.Location = New Point(100, 47)
        dgvEmployees.MultiSelect = False
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.ReadOnly = True
        dgvEmployees.RowHeadersVisible = False
        dgvEmployees.RowHeadersWidth = 62
        dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployees.Size = New Size(663, 308)
        dgvEmployees.TabIndex = 0
        ' 
        ' dgvEmployeeChanges
        ' 
        dgvEmployeeChanges.AllowUserToAddRows = False
        dgvEmployeeChanges.AllowUserToDeleteRows = False
        dgvEmployeeChanges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployeeChanges.Location = New Point(100, 433)
        dgvEmployeeChanges.MultiSelect = False
        dgvEmployeeChanges.Name = "dgvEmployeeChanges"
        dgvEmployeeChanges.ReadOnly = True
        dgvEmployeeChanges.RowHeadersVisible = False
        dgvEmployeeChanges.RowHeadersWidth = 62
        dgvEmployeeChanges.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployeeChanges.Size = New Size(1098, 356)
        dgvEmployeeChanges.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(921, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 25)
        Label1.TabIndex = 2
        Label1.Text = "Employee"
        ' 
        ' ucEmployees
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label1)
        Controls.Add(dgvEmployeeChanges)
        Controls.Add(dgvEmployees)
        MinimumSize = New Size(1525, 924)
        Name = "ucEmployees"
        Size = New Size(1525, 924)
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvEmployeeChanges, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents dgvEmployeeChanges As DataGridView
    Friend WithEvents Label1 As Label

End Class
