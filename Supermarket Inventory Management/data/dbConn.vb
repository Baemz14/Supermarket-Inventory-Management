Imports System.Data.SQLite

Module dbConnection
    Private dbDir As String = System.IO.Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory & "..\..\..\data\inventory_db.db")
    Public connString As String = "Data Source=" & dbDir & ";Version=3;Foreign Keys=True;"

    Public Function GetConnection() As SQLiteConnection
        Return New SQLiteConnection(connString)
    End Function

    ' Runs once at startup to bring an existing database file up to the schema the
    ' app expects. Every statement here is idempotent ("IF NOT EXISTS") so it is
    ' safe to run on every launch. SQLite can't add a UNIQUE constraint to an
    ' existing table via ALTER, but a UNIQUE INDEX enforces the same rule. NOCASE
    ' makes the match case-insensitive so "Beverage" and "beverage" collide.
    Public Sub EnsureSchema()
        Using conn As SQLiteConnection = GetConnection()
            conn.Open()
            For Each ddl In {
                "CREATE UNIQUE INDEX IF NOT EXISTS ux_category_name ON category(category_name COLLATE NOCASE)",
                "CREATE UNIQUE INDEX IF NOT EXISTS ux_supplier_name ON supplier(supplier_name COLLATE NOCASE)"
            }
                Using cmd As New SQLiteCommand(ddl, conn)
                    cmd.ExecuteNonQuery()
                End Using
            Next
        End Using
    End Sub
End Module
