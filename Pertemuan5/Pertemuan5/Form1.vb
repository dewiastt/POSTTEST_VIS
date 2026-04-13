Imports MySqlConnector
Imports System.Data

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Private Sub TampilData()
        dgvJenis.DataSource = GetAll()
        dgvJenis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Private Sub Kosong()
        TxtKodeJenis.Clear()
        TxtNamaProduk.Clear()
        TxtHarga.Clear()
        TxtMasaAktif.Clear()

        CmbKategori.SelectedIndex = -1
        CmbOperator.SelectedIndex = -1
        CmbStatus.SelectedIndex = -1
    End Sub


    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtKodeJenis.Text = "" Or TxtNamaProduk.Text = "" Then
            MessageBox.Show("Data wajib diisi!")
            Exit Sub
        End If

        Dim harga As Decimal
        If Not Decimal.TryParse(TxtHarga.Text, harga) Then
            MessageBox.Show("Harga harus angka")
            Exit Sub
        End If

        If Simpan(
            TxtKodeJenis.Text,
            TxtNamaProduk.Text,
            CmbKategori.Text,
            CmbOperator.Text,
            harga,
            TxtMasaAktif.Text,
            CmbStatus.Text) Then

            MessageBox.Show("Data berhasil disimpan")
            TampilData()
            Kosong()
        End If
    End Sub


    Private Sub dgvJenis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJenis.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row = dgvJenis.Rows(e.RowIndex)

        TxtKodeJenis.Text = row.Cells("kode_produk").Value.ToString()
        TxtNamaProduk.Text = row.Cells("nama_produk").Value.ToString()
        TxtHarga.Text = row.Cells("harga").Value.ToString()
        TxtMasaAktif.Text = row.Cells("masa_aktif").Value.ToString()

        CmbKategori.Text = row.Cells("kategori").Value.ToString()
        CmbOperator.Text = row.Cells("operator").Value.ToString()
        CmbStatus.Text = row.Cells("status").Value.ToString()
    End Sub


    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If TxtKodeJenis.Text = "" Then
            MessageBox.Show("Pilih data dulu!")
            Exit Sub
        End If

        If MessageBox.Show("Yakin hapus?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If Hapus(TxtKodeJenis.Text) Then
                MessageBox.Show("Data berhasil dihapus")
                TampilData()
                Kosong()
            End If
        End If
    End Sub


    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If TxtKodeJenis.Text = "" Then
            MessageBox.Show("Pilih data dulu!")
            Exit Sub
        End If

        Dim harga As Decimal
        If Not Decimal.TryParse(TxtHarga.Text, harga) Then
            MessageBox.Show("Harga harus angka")
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim query As String = "UPDATE produk SET " &
                    "nama_produk=@nama, kategori=@kategori, operator=@operator, " &
                    "harga=@harga, masa_aktif=@masa, status=@status " &
                    "WHERE kode_produk=@kode"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", TxtKodeJenis.Text)
                    cmd.Parameters.AddWithValue("@nama", TxtNamaProduk.Text)
                    cmd.Parameters.AddWithValue("@kategori", CmbKategori.Text)
                    cmd.Parameters.AddWithValue("@operator", CmbOperator.Text)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@masa", TxtMasaAktif.Text)
                    cmd.Parameters.AddWithValue("@status", CmbStatus.Text)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Data berhasil diubah")
            TampilData()
            Kosong()

        Catch ex As Exception
            MessageBox.Show("Gagal update: " & ex.Message)
        End Try
    End Sub


    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Kosong()
        TxtKodeJenis.Focus()
    End Sub


    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        If e.KeyChar = Chr(13) Then ' ENTER ditekan

            If TxtSearch.Text = "" Then
                TampilData()
            Else
                dgvJenis.DataSource = SearchData(TxtSearch.Text)
            End If

        End If
    End Sub

End Class