Imports System.IO

Public Class Form1


    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtId.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mtbTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialogFoto.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OpenFileDialogFoto.ShowDialog() = DialogResult.OK Then
            pbProfil.ImageLocation = OpenFileDialogFoto.FileName
            pbProfil.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        TampilkanKartu()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        SimpanDataKeFile()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click

        ' VALIDASI
        If txtNama.Text = "" Or txtId.Text = "" Or txtEmail.Text = "" Or txtAlamat.Text = "" Or cmbDevisi.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong!", "Error")
            Return
        End If

        If Not mtbTelepon.MaskCompleted Then
            MessageBox.Show("Format nomor telepon salah!", "Error")
            Return
        End If

        Dim hobi As String = GetHobi()

        If hobi = "" Then
            MessageBox.Show("Pilih minimal 1 hobi!", "Peringatan")
            Return
        End If

        If MessageBox.Show("Cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Dim f As New Form2()

            f.Nama = txtNama.Text.ToUpper()
            f.ID = txtId.Text
            f.Komunitas = cmbDevisi.Text
            f.Kontak = mtbTelepon.Text & " | " & txtEmail.Text
            f.Hobi = hobi

            If pbProfil.Image IsNot Nothing Then
                f.Foto = pbProfil.Image
            End If

            f.Show()
        End If

    End Sub


    Private Sub TampilkanKartu()
        Dim f As New Form2()

        f.Nama = txtNama.Text
        f.ID = txtId.Text
        f.Komunitas = cmbDevisi.Text
        f.Kontak = mtbTelepon.Text & " | " & txtEmail.Text
        f.Hobi = GetHobi()

        If pbProfil.Image IsNot Nothing Then
            f.Foto = pbProfil.Image
        End If

        f.Show()
    End Sub


    Private Function GetHobi() As String
        Dim hobi As String = ""
        Dim daftar = {chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8}

        For Each chk In daftar
            If chk.Checked Then
                hobi &= chk.Text & ", "
            End If
        Next

        Return hobi.TrimEnd(", ".ToCharArray())
    End Function


    Private Sub SimpanDataKeFile()
        SaveFileDialog1.Filter = "Text File|*.txt"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim isi As String =
                "Nama: " & txtNama.Text & vbCrLf &
                "ID: " & txtId.Text & vbCrLf &
                "Telepon: " & mtbTelepon.Text & vbCrLf &
                "Email: " & txtEmail.Text

            File.WriteAllText(SaveFileDialog1.FileName, isi)
            MessageBox.Show("Data berhasil disimpan!")
        End If
    End Sub

End Class
