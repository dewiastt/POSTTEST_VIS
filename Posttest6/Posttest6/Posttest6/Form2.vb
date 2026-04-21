Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Form2

    Dim conn As MySqlConnection

   
    Sub Koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=dbpulsa")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    
    Sub LoadProduk()
        CmbProduk.Items.Clear()
        CmbProduk.Items.Add("Pulsa")
        CmbProduk.Items.Add("Paket Data")
        CmbProduk.Items.Add("Nelpon")
    End Sub


    Sub LoadTransaksi()
        Koneksi()
        Dim da As New MySqlDataAdapter("SELECT * FROM transaksi", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvTransaksi.DataSource = dt
    End Sub

   
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProduk()
        LoadTransaksi()
    End Sub

 
    Private Sub CmbProduk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProduk.SelectedIndexChanged

        If CmbProduk.Text = "Pulsa" Then
            TxtHarga.Text = "10000"
        ElseIf CmbProduk.Text = "Paket Data" Then
            TxtHarga.Text = "20000"
        ElseIf CmbProduk.Text = "Nelpon" Then
            TxtHarga.Text = "15000"
        End If

    End Sub

   
    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        Dim harga As Double = Val(TxtHarga.Text)
        Dim jumlah As Integer = Val(TxtJumlah.Text)

        TxtTotal.Text = (harga * jumlah).ToString()
    End Sub

 
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Koneksi()

        If TxtNoHP.Text = "" Or CmbProduk.Text = "" Or TxtJumlah.Text = "" Then
            MessageBox.Show("Data belum lengkap!")
            Exit Sub
        End If

        Dim cmd As New MySqlCommand("INSERT INTO transaksi (tanggal, produk, nomor_hp, jumlah, total) VALUES (NOW(), @produk, @hp, @jumlah, @total)", conn)

        cmd.Parameters.AddWithValue("@produk", CmbProduk.Text)
        cmd.Parameters.AddWithValue("@hp", TxtNoHP.Text)
        cmd.Parameters.AddWithValue("@jumlah", TxtJumlah.Text)
        cmd.Parameters.AddWithValue("@total", TxtTotal.Text)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Transaksi berhasil disimpan!")

        LoadTransaksi()
        Bersih()
    End Sub

 
    Sub Bersih()
        TxtKode.Clear()
        TxtNoHP.Clear()
        CmbProduk.Text = ""
        TxtHarga.Clear()
        TxtJumlah.Clear()
        TxtTotal.Clear()
    End Sub


    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Form1.Show()
        Me.Close()
    End Sub

End Class
