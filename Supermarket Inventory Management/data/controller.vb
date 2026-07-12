Imports System.Data.SQLite
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text

Module ProductController

    Public Function IsEmpNameExist(name As String) As Boolean
        Using conn As SQLiteConnection = GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM employee WHERE employee_name = @Name"

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", name.Trim())

                Try
                    conn.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0

                Catch ex As Exception
                    Throw New Exception("System Error checking username: " & ex.Message)
                End Try
            End Using
        End Using
    End Function

    Public Function RegisterEmployee(name As String, password As String) As Boolean
        If IsEmpNameExist(name) Then
            Return False
        End If

        Using conn As SQLiteConnection = GetConnection()
            Dim query As String = "INSERT INTO employee (employee_name, employee_pass_hash) VALUES (@Name, @Password)"

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", name.Trim())
                cmd.Parameters.AddWithValue("@Password", HashPassword(password))

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0

                Catch ex As Exception
                    Throw New Exception("Database Error during registration: " & ex.Message)
                End Try
            End Using
        End Using
    End Function

    Public Function LoginEmployee(name As String, password As String) As Integer
        If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(password) Then
            Return -1
        End If

        Using conn As SQLiteConnection = GetConnection()
            Dim query As String = "SELECT employee_id, employee_pass_hash FROM employee WHERE employee_name = @Name"

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", name.Trim())

                Try
                    conn.Open()

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim storedHash As String = reader("employee_pass_hash").ToString()
                            If CompareHash(password, storedHash) Then
                                Return Convert.ToInt32(reader("employee_id"))
                            End If
                        End If
                    End Using
                    Return -1

                Catch ex As Exception
                    Throw New Exception("System Error during login validation: " & ex.Message)
                End Try
            End Using
        End Using
    End Function

    Public Function GetAllEmployees() As DataTable
        Dim dt As New DataTable()
        Using conn As SQLiteConnection = GetConnection()
            Dim query As String = "SELECT e.employee_id, e.employee_name, (" &
                        "SELECT COUNT(*) FROM product_change pc INNER JOIN employee e ON pc.employee_id = e.employee_id" &
                        ") as 'Changes made'" &
                        "FROM employee e"
            Using cmd As New SQLiteCommand(query, conn)
                Try
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                Catch ex As Exception
                    Throw New Exception("Controller Error (GetAllEmployees): " & ex.Message)
                End Try
            End Using
        End Using
        Return dt
    End Function

    Public Function GetEmployeeChanges(employeeId As Integer) As DataTable
        Dim dt As New DataTable()
        'TODO make the column names nicer
        Using conn As SQLiteConnection = GetConnection()
            Dim query As String = "SELECT pc.*, p.product_name, p.quantity as 'current quantity' " &
                        "FROM product_change pc " &
                        "INNER JOIN employee e ON e.employee_id = pc.employee_id " &
                        "INNER JOIN product p ON pc.product_id = p.product_id "
            Using cmd As New SQLiteCommand(query, conn)
                Try
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                Catch ex As Exception
                    Throw New Exception("Controller Error (GetAllEmployees): " & ex.Message)
                End Try
            End Using
        End Using
        Return dt
    End Function

    Public Function GetAllProducts() As DataTable
        Dim dt As New DataTable()
        Using conn As SQLiteConnection = GetConnection()
            Dim query As String = "SELECT p.product_id, p.product_name, " &
                             "c.category_name as category, c.tax_rate, s.supplier_name as supplier, " &
                             "p.unit_price, p.quantity, p.unit, p.reorder_treshold, " &
                             "p.bulk_quantity, p.bulk_discount_rate " &
                             "FROM product p " &
                             "INNER JOIN category c ON p.category_id = c.category_id " &
                             "INNER JOIN supplier s ON p.supplier_id = s.supplier_id"
            Using cmd As New SQLiteCommand(query, conn)
                Try
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                Catch ex As Exception
                    Throw New Exception("Controller Error (GetAllProducts): " & ex.Message)
                End Try
            End Using
        End Using
        Return dt
    End Function

    Public Function GetAllCategories() As DataTable
        Dim dt As New DataTable()

        Using conn As SQLiteConnection = GetConnection()
            Dim query As String = "SELECT category_id, category_name, tax_rate FROM category"

            Using cmd As New SQLiteCommand(query, conn)
                Try
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                Catch ex As Exception
                    Throw New Exception("Controller Error (GetAllCategories): " & ex.Message)
                End Try
            End Using
        End Using

        Return dt
    End Function

    Public Function GetAllSuppliers() As DataTable
        Dim dt As New DataTable()

        Using conn As SQLiteConnection = GetConnection()
            Dim query As String = "SELECT supplier_id, supplier_name, supplier_phone, supplier_email FROM supplier"

            Using cmd As New SQLiteCommand(query, conn)
                Try
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                Catch ex As Exception
                    Throw New Exception("Controller Error (GetAllSuppliers): " & ex.Message)
                End Try
            End Using
        End Using

        Return dt
    End Function

    Public Function AddProduct(productName As String, supplierId As Integer, categoryId As Integer,
                               unitPrice As Decimal, quantity As Integer, unit As String,
                               reorderThreshold As Integer, bulkQuantity As Integer, bulkDiscount As Decimal) As Boolean

        Using conn As SQLiteConnection = GetConnection()
            Dim query As String = "INSERT INTO product (product_name, supplier_id, category_id, unit_price, " &
                                 "quantity, unit, reorder_treshold, bulk_quantity, bulk_discount_rate) " &
                                 "VALUES (@Name, @SupID, @CatID, @Price, @Qty, @Unit, @Threshold, @BulkQty, @BulkDiscount)"

            Using cmd As New SQLiteCommand(query, conn)
                ' Bind all your user inputs securely to parameters
                cmd.Parameters.AddWithValue("@Name", productName)
                cmd.Parameters.AddWithValue("@SupID", supplierId)
                cmd.Parameters.AddWithValue("@CatID", categoryId)
                cmd.Parameters.AddWithValue("@Price", unitPrice)
                cmd.Parameters.AddWithValue("@Qty", quantity)
                cmd.Parameters.AddWithValue("@Unit", unit)
                cmd.Parameters.AddWithValue("@Threshold", reorderThreshold)
                cmd.Parameters.AddWithValue("@BulkQty", bulkQuantity)
                cmd.Parameters.AddWithValue("@BulkDiscount", bulkDiscount)

                Try
                    conn.Open()
                    ' ExecuteNonQuery returns the number of rows affected
                    Return cmd.ExecuteNonQuery() > 0

                Catch ex As SQLiteException When ex.ResultCode = SQLiteErrorCode.Constraint
                    ' This intercepts foreign key or unique constraint violations specifically
                    Throw New Exception("Database Error: Selected Category or Supplier does not exist.")
                Catch ex As Exception
                    ' Catches any other unexpected bugs (e.g. locked database file)
                    Throw New Exception("System Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Function

    Public Function AddCategory(categoryName As String, taxRate As Decimal) As Boolean
        Using conn As SQLiteConnection = GetConnection()
            Dim query As String = "INSERT INTO category (category_name, tax_rate) VALUES (@Name, @Tax)"

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", categoryName)
                cmd.Parameters.AddWithValue("@Tax", taxRate)

                Try
                    conn.Open()
                    Return cmd.ExecuteNonQuery() > 0
                Catch ex As SQLiteException When ex.ResultCode = SQLiteErrorCode.Constraint
                    Throw New Exception("Database Error: This category name already exists.")
                Catch ex As Exception
                    Throw New Exception("System Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Function

    Public Function AddSupplier(supplierName As String, phone As String, email As String) As Boolean
        Using conn As SQLiteConnection = GetConnection()
            Dim query As String = "INSERT INTO supplier (supplier_name, supplier_phone, supplier_email) " &
                             "VALUES (@Name, @Phone, @Email)"

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", supplierName)
                cmd.Parameters.AddWithValue("@Phone", phone)
                cmd.Parameters.AddWithValue("@Email", email)

                Try
                    conn.Open()
                    Return cmd.ExecuteNonQuery() > 0
                Catch ex As SQLiteException When ex.ResultCode = SQLiteErrorCode.Constraint
                    Throw New Exception("Database Error: Supplier details violate database rules.")
                Catch ex As Exception
                    Throw New Exception("System Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Function

    Public Function IsEmpIdExist(id As Integer) As Boolean
        Using conn As SQLiteConnection = GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM employee WHERE employee_id = @Id"

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Id", id)

                Try
                    conn.Open()

                    ' 1. Use ExecuteScalar because we are retrieving a count number
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' 2. If the count is greater than 0, the ID exists!
                    Return count > 0

                Catch ex As Exception
                    Throw New Exception("System Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Function

    Public Function ChangeProductQuantity(productId As Integer, quantityChange As Decimal, employeeId As Integer, changeDesc As String) As Boolean
        Dim isSuccess As Boolean = False

        Using conn As SQLiteConnection = GetConnection()
            Try
                conn.Open()

                Using transaction As SQLiteTransaction = conn.BeginTransaction()

                    Dim updateQuery As String = "UPDATE product SET quantity = quantity + @Change WHERE product_id = @ProdID"

                    Using updateCmd As New SQLiteCommand(updateQuery, conn, transaction)
                        updateCmd.Parameters.AddWithValue("@Change", quantityChange)
                        updateCmd.Parameters.AddWithValue("@ProdID", productId)

                        Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()

                        If rowsAffected = 0 Then
                            transaction.Rollback()
                            Return False
                        End If
                    End Using

                    Dim logQuery As String = "INSERT INTO product_change " &
                                         "(product_id, change_desc, quantity_changed, employee_id, change_datetime, price_changed) " &
                                         "VALUES (@ProdID, @Desc, @QtyChanged, @EmpID, datetime('now', 'localtime'), 0)"

                    Using logCmd As New SQLiteCommand(logQuery, conn, transaction)
                        logCmd.Parameters.AddWithValue("@ProdID", productId)
                        logCmd.Parameters.AddWithValue("@Desc", changeDesc)
                        logCmd.Parameters.AddWithValue("@QtyChanged", quantityChange)
                        logCmd.Parameters.AddWithValue("@EmpID", employeeId)

                        logCmd.ExecuteNonQuery()
                    End Using

                    transaction.Commit()
                    isSuccess = True

                End Using

            Catch ex As Exception
                Throw New Exception("Database Ledger Error: Failed to execute stock adjustment. Details: " & ex.Message)
            End Try
        End Using

        Return isSuccess
    End Function

    Public Function ChangeProductPrice(productId As Integer, newPrice As Decimal, employeeId As Integer) As Boolean
        Dim isSuccess As Boolean = False
        Using conn As SQLiteConnection = GetConnection()
            Try
                conn.Open()
                Using transaction As SQLiteTransaction = conn.BeginTransaction()
                    Dim updateQuery As String = "UPDATE product SET unit_price = @NewPrice WHERE product_id = @ProdID"
                    Using updateCmd As New SQLiteCommand(updateQuery, conn, transaction)
                        updateCmd.Parameters.AddWithValue("@NewPrice", newPrice)
                        updateCmd.Parameters.AddWithValue("@ProdID", productId)
                        Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                        If rowsAffected = 0 Then
                            transaction.Rollback()
                            Return False
                        End If
                    End Using
                    Dim logQuery As String = "INSERT INTO product_change " &
                                         "(product_id, change_desc, quantity_changed, employee_id, change_datetime, price_changed) " &
                                         "VALUES (@ProdID, 'Price Change', 0, @EmpID, datetime('now', 'localtime'), @NewPrice)"
                    Using logCmd As New SQLiteCommand(logQuery, conn, transaction)
                        logCmd.Parameters.AddWithValue("@ProdID", productId)
                        logCmd.Parameters.AddWithValue("@EmpID", employeeId)
                        logCmd.Parameters.AddWithValue("@NewPrice", newPrice)
                        logCmd.ExecuteNonQuery()
                    End Using
                    transaction.Commit()
                    isSuccess = True
                End Using
            Catch ex As Exception
                Throw New Exception("Database Ledger Error: Failed to execute price adjustment. Details: " & ex.Message)
            End Try
        End Using
        Return isSuccess
    End Function

    Public Sub DebugPrintDataTable(dt As DataTable)
        Console.WriteLine("=== START OF DATATABLE CONSOLE DUMP ===")

        Dim headers As New List(Of String)()
        For Each col As DataColumn In dt.Columns
            headers.Add(col.ColumnName)
        Next
        Console.WriteLine(String.Join(" | ", headers))
        Console.WriteLine(New String("-"c, 60))

        For Each row As DataRow In dt.Rows
            Dim rowItems As String = String.Join(" | ", row.ItemArray)
            Console.WriteLine(rowItems)
        Next

        Console.WriteLine("=== END OF DATATABLE CONSOLE DUMP ===")
    End Sub

    ' Password hashing uses PBKDF2 (SHA-256) with a random per-user salt.
    ' Stored format: "pbkdf2$<iterations>$<saltBase64>$<hashBase64>".
    Private Const Pbkdf2Prefix As String = "pbkdf2"
    Private Const Pbkdf2Iterations As Integer = 100000
    Private Const SaltSize As Integer = 16   ' 128-bit salt
    Private Const KeySize As Integer = 32    ' 256-bit derived key

    Public Function HashPassword(password As String) As String
        Dim salt(SaltSize - 1) As Byte
        RandomNumberGenerator.Fill(salt)

        Dim key As Byte() = Rfc2898DeriveBytes.Pbkdf2(
            password, salt, Pbkdf2Iterations, HashAlgorithmName.SHA256, KeySize)

        Return String.Join("$", Pbkdf2Prefix, Pbkdf2Iterations.ToString(),
                           Convert.ToBase64String(salt), Convert.ToBase64String(key))
    End Function

    Public Function CompareHash(password As String, storedHash As String) As Boolean
        If String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(storedHash) Then
            Return False
        End If

        If storedHash.StartsWith(Pbkdf2Prefix & "$", StringComparison.Ordinal) Then
            Dim parts As String() = storedHash.Split("$"c)
            If parts.Length <> 4 Then Return False

            Dim iterations As Integer
            If Not Integer.TryParse(parts(1), iterations) Then Return False

            Dim salt As Byte()
            Dim expected As Byte()
            Try
                salt = Convert.FromBase64String(parts(2))
                expected = Convert.FromBase64String(parts(3))
            Catch
                Return False
            End Try

            Dim actual As Byte() = Rfc2898DeriveBytes.Pbkdf2(
                password, salt, iterations, HashAlgorithmName.SHA256, expected.Length)

            ' Constant-time comparison to avoid timing attacks.
            Return CryptographicOperations.FixedTimeEquals(actual, expected)
        End If

        ' Legacy accounts stored a plain SHA-256 hex digest (no salt). Verify those for
        ' backward compatibility so existing users can still log in.
        Return String.Equals(LegacySha256Hex(password), storedHash, StringComparison.OrdinalIgnoreCase)
    End Function

    Private Function LegacySha256Hex(password As String) As String
        Dim hashedBytes As Byte() = SHA256.HashData(Encoding.UTF8.GetBytes(password))
        Dim sb As New StringBuilder()
        For Each b As Byte In hashedBytes
            sb.Append(b.ToString("x2"))
        Next
        Return sb.ToString()
    End Function

End Module