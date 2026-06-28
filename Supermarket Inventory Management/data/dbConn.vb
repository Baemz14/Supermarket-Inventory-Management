Imports System.Data.SQLite

Module dbConnection
    Private dbDir As String = System.IO.Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory & "..\..\..\data\inventory_db.db")
    Public connString As String = "Data Source=" & dbDir & ";Version=3;Foreign Keys=True;"

    Public Function GetConnection() As SQLiteConnection
        Return New SQLiteConnection(connString)
    End Function
End Module