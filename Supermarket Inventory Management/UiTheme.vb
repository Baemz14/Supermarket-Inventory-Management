' Central look-and-feel for the app. Screens call these helpers from their Load
' handlers so every grid, button and field is styled in exactly one place.
Friend Module UiTheme

    ' Palette
    Friend ReadOnly Primary As Color = Color.FromArgb(46, 125, 87)        ' deep green - headers, primary buttons
    Friend ReadOnly PrimaryDark As Color = Color.FromArgb(35, 99, 68)     ' hover state of primary
    Friend ReadOnly PrimaryPale As Color = Color.FromArgb(214, 236, 225)  ' selection highlight
    Friend ReadOnly Surface As Color = Color.White                        ' screen background
    Friend ReadOnly FieldBack As Color = Color.FromArgb(241, 244, 242)    ' read-only value fields
    Friend ReadOnly RowAlt As Color = Color.FromArgb(247, 250, 248)       ' alternating grid rows
    Friend ReadOnly GridLine As Color = Color.FromArgb(225, 231, 228)
    Friend ReadOnly BorderGray As Color = Color.FromArgb(190, 200, 195)
    Friend ReadOnly TextDark As Color = Color.FromArgb(33, 41, 36)

    Friend Sub StyleScreen(root As Control)
        root.BackColor = Surface
    End Sub

    ' Flat grid: green header band, soft horizontal lines, pale-green selection.
    ' Call before assigning DataSource so the row height applies to new rows.
    Friend Sub StyleGrid(dgv As DataGridView)
        dgv.EnableHeadersVisualStyles = False
        dgv.BorderStyle = BorderStyle.None
        dgv.BackgroundColor = Surface
        dgv.GridColor = GridLine
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgv.ColumnHeadersHeight = 42
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Primary
        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Primary
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        dgv.ColumnHeadersDefaultCellStyle.Padding = New Padding(6, 0, 0, 0)
        dgv.DefaultCellStyle.BackColor = Surface
        dgv.DefaultCellStyle.ForeColor = TextDark
        dgv.DefaultCellStyle.SelectionBackColor = PrimaryPale
        dgv.DefaultCellStyle.SelectionForeColor = TextDark
        dgv.DefaultCellStyle.Padding = New Padding(6, 0, 0, 0)
        dgv.AlternatingRowsDefaultCellStyle.BackColor = RowAlt
        dgv.RowTemplate.Height = 36
    End Sub

    ' Solid green button for the main action of a form (Confirm / Add / Login).
    Friend Sub StylePrimaryButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Primary
        btn.ForeColor = Color.White
        btn.FlatAppearance.MouseOverBackColor = PrimaryDark
        btn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btn.Cursor = Cursors.Hand
    End Sub

    ' Quiet outlined button for secondary actions (Reset / Cancel).
    Friend Sub StyleSecondaryButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 1
        btn.FlatAppearance.BorderColor = BorderGray
        btn.BackColor = Surface
        btn.ForeColor = TextDark
        btn.FlatAppearance.MouseOverBackColor = FieldBack
        btn.Cursor = Cursors.Hand
    End Sub

    ' Read-only value display: flat soft-gray box instead of the sunken 3D border.
    Friend Sub StyleValueLabel(lbl As Label)
        lbl.BorderStyle = BorderStyle.None
        lbl.BackColor = FieldBack
        lbl.ForeColor = TextDark
    End Sub

    Friend Sub StyleMenu(menu As MenuStrip)
        menu.BackColor = Surface
        menu.Padding = New Padding(10, 6, 0, 6)
        menu.Renderer = New ToolStripProfessionalRenderer(New ThemeMenuColors())
    End Sub

    ' Colors the menu hover/press states green instead of the default blue.
    Private Class ThemeMenuColors
        Inherits ProfessionalColorTable

        Public Overrides ReadOnly Property MenuItemSelected As Color
            Get
                Return PrimaryPale
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
            Get
                Return PrimaryPale
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
            Get
                Return PrimaryPale
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
            Get
                Return PrimaryPale
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
            Get
                Return PrimaryPale
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemBorder As Color
            Get
                Return Primary
            End Get
        End Property

        Public Overrides ReadOnly Property MenuBorder As Color
            Get
                Return GridLine
            End Get
        End Property

        Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
            Get
                Return Surface
            End Get
        End Property
    End Class

End Module
