Public Class Form1
    Public judul As String
    Public genre As String
    Public index As Integer

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        judul = txtJudul.Text
        genre = txtGenre.Text

        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan Genre harus diisi")
        Else
            tambahBuku(judul, genre)
            tampilkanData()
            txtJudul.Clear()
            txtGenre.Clear()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judulCari As String = txtHapus.Text

        If judulCari = "" Then
            MessageBox.Show("Masukkan judul buku")
        Else
            For i As Integer = 0 To jumlahBuku - 1
                If daftarBuku(i, 0) = judulCari Then
                    index = i
                    hapusBuku(index)
                    tampilkanData()
                    txtHapus.Clear()
                    Exit Sub
                End If
            Next
            MessageBox.Show("Judul buku tidak ditemukan")
        End If
    End Sub

    Private Sub tampilkanData()
        listBuku.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            listBuku.Items.Add(daftarBuku(i, 0) & " - " & daftarBuku(i, 1))
        Next
    End Sub
End Class