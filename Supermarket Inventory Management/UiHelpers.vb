' Small helpers shared by the UI screens.
Friend Module UiHelpers

    ' Escapes characters that are special inside a DataView RowFilter LIKE expression.
    Friend Function EscapeLikeValue(value As String) As String
        Dim sb As New System.Text.StringBuilder()
        For Each c As Char In value
            Select Case c
                Case "'"c
                    sb.Append("''")
                Case "["c, "]"c, "%"c, "*"c
                    sb.Append("["c).Append(c).Append("]"c)
                Case Else
                    sb.Append(c)
            End Select
        Next
        Return sb.ToString()
    End Function

End Module
