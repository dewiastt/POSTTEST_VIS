Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Form1

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable

    Sub Koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=dbpulsa")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub LoadData()
        Koneksi()
        da = New MySqlDataAdapter("SELECT * FROM produk", conn)
        dt = New DataTable
        da.Fill(dt)
        dgvJenis.DataSource = dt
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub


    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Koneksi()

        If TxtKodeJenis.Text = "" Or TxtNamaProduk.Text = "" Then
            MessageBox.Show("Data belum lengkap!")
            Exit Sub
        End If

        cmd = New MySqlCommand("INSERT INTO produk VALUES (@kode,@nama,@kategori,@operator,@harga,@masa,@status)", conn)

        cmd.Parameters.AddWithValue("@kode", TxtKodeJenis.Text)
        cmd.Parameters.AddWithValue("@nama", TxtNamaProduk.Text)
        cmd.Parameters.AddWithValue("@kategori", CmbKategori.Text)
        cmd.Parameters.AddWithValue("@operator", CmbOperator.Text)
        cmd.Parameters.AddWithValue("@harga", TxtHarga.Text)
        cmd.Parameters.AddWithValue("@masa", TxtMasaAktif.Text)
        cmd.Parameters.AddWithValue("@status", CmbStatus.Text)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil disimpan!")

        LoadData()
        Bersih()
    End Sub


    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        Koneksi()

        cmd = New MySqlCommand("UPDATE produk SET nama_produk=@nama,kategori=@kategori,operator=@operator,harga=@harga,masa_aktif=@masa,status=@status WHERE kode_produk=@kode", conn)

        cmd.Parameters.AddWithValue("@kode", TxtKodeJenis.Text)
        cmd.Parameters.AddWithValue("@nama", TxtNamaProduk.Text)
        cmd.Parameters.AddWithValue("@kategori", CmbKategori.Text)
        cmd.Parameters.AddWithValue("@operator", CmbOperator.Text)
        cmd.Parameters.AddWithValue("@harga", TxtHarga.Text)
        cmd.Parameters.AddWithValue("@masa", TxtMasaAktif.Text)
        cmd.Parameters.AddWithValue("@status", CmbStatus.Text)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil diubah!")

        LoadData()
        Bersih()
    End Sub

   
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Koneksi()

        cmd = New MySqlCommand("DELETE FROM produk WHERE kode_produk=@kode", conn)
        cmd.Parameters.AddWithValue("@kode", TxtKodeJenis.Text)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil dihapus!")

        LoadData()
        Bersih()
    End Sub

   
    Private Sub dgvJenis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJenis.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvJenis.Rows(e.RowIndex)

            TxtKodeJenis.Text = row.Cells("kode_produk").Value.ToString()
            TxtNamaProduk.Text = row.Cells("nama_produk").Value.ToString()
            CmbKategori.Text = row.Cells("kategori").Value.ToString()
            CmbOperator.Text = row.Cells("operator").Value.ToString()
            TxtHarga.Text = row.Cells("harga").Value.ToString()
            TxtMasaAktif.Text = row.Cells("masa_aktif").Value.ToString()
            CmbStatus.Text = row.Cells("status").Value.ToString()
        End If
    End Sub

   
    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Koneksi()

        da = New MySqlDataAdapter("SELECT * FROM produk WHERE nama_produk LIKE '%" & TxtSearch.Text & "%'", conn)
        dt = New DataTable
        da.Fill(dt)

        dgvJenis.DataSource = dt
    End Sub


    Sub Bersih()
        TxtKodeJenis.Clear()
        TxtNamaProduk.Clear()
        TxtHarga.Clear()
        TxtMasaAktif.Clear()
        TxtSearch.Clear()

        CmbKategori.Text = ""
        CmbOperator.Text = ""
        CmbStatus.Text = ""
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Bersih()
    End Sub

    ' ================= PINDAH KE TRANSAKSI =================
    Private Sub BtnTransaksi_Click(sender As Object, e As EventArgs) Handles BtnTransaksi.Click
        Form2.Show()
        Me.Hide()
    End Sub

End Class
