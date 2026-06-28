Imports System.Data.SQLite

Module ProductController

    Public Function GetAllProducts() As DataTable
        Dim dt As New DataTable()
        Using conn As SQLiteConnection = GetConnection()
            Dim query As String = "SELECT p.product_id, p.product_name, " &
                             "c.category_name, s.supplier_name, " &
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

End Module