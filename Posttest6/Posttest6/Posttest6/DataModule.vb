Imports MySqlConnector
Imports System.Data
Imports System.Windows.Forms

Module DataModule


    Public Function GetAll() As DataTable
        Dim dt As New DataTable()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim query As String = "SELECT * FROM produk ORDER BY kode_produk ASC"

                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        End Try

        Return dt
    End Function


    Public Function Simpan(kode As String, nama As String,
                          kategori As String, op As String,
                          harga As Decimal, masa As String,
                          status As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim query As String = "INSERT INTO produk " &
                    "(kode_produk,nama_produk,kategori,operator,harga,masa_aktif,status) " &
                    "VALUES (@kode,@nama,@kategori,@operator,@harga,@masa,@status)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kategori", kategori)
                    cmd.Parameters.AddWithValue("@operator", op)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@masa", masa)
                    cmd.Parameters.AddWithValue("@status", status)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message)
            Return False
        End Try
    End Function


    Public Function Hapus(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim query As String = "DELETE FROM produk WHERE kode_produk=@kode"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal hapus: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function SearchData(keyword As String) As DataTable
        Dim dt As New DataTable()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim query As String = "SELECT * FROM produk WHERE " &
                "kode_produk LIKE @key OR " &
                "nama_produk LIKE @key OR " &
                "kategori LIKE @key OR " &
                "operator LIKE @key OR " &
                "status LIKE @key"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")

                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal search: " & ex.Message)
        End Try

        Return dt
    End Function

End Module