Module Module1
    Public daftarBuku(100, 1) As String
    Public jumlahBuku As Integer = 0

    Public Sub tambahBuku(judul As String, genre As String)
        daftarBuku(jumlahBuku, 0) = judul
        daftarBuku(jumlahBuku, 1) = genre
        jumlahBuku += 1
    End Sub

    Public Sub hapusBuku(idx As Integer)
        For i As Integer = idx To jumlahBuku - 2
            daftarBuku(i, 0) = daftarBuku(i + 1, 0)
            daftarBuku(i, 1) = daftarBuku(i + 1, 1)
        Next
        jumlahBuku -= 1
    End Sub
End Module