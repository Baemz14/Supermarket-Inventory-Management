Module SessionManager
    Public Property CurrentUsername As String = Nothing
    Public Property CurrentId As Integer = -1

    Public ReadOnly Property IsLoggedIn As Boolean
        Get
            Return Not Integer.IsNegative(CurrentId)
        End Get
    End Property

    Public Function Login(name As String, password As String) As Boolean
        Dim id As Integer = LoginEmployee(name, password)
        If id = -1 Then
            Return False
        End If
        CurrentUsername = name
        CurrentId = id
        Return True
    End Function

    Public Sub Logout()
        CurrentUsername = Nothing
        CurrentId = -1
    End Sub
End Module
