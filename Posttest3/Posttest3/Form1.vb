Public Class Form1

    Dim hobby As String = ""

    Private Sub btnGambar_Click(sender As Object, e As EventArgs) Handles btnGambar.Click

        Dim open As New OpenFileDialog
        open.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If open.ShowDialog = DialogResult.OK Then
            picProfil.Image = Image.FromFile(open.FileName)
        End If

    End Sub


    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> " "c Then
            e.Handled = True
        End If

    End Sub


    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub


    Private Sub txtTelpon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelpon.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTelpon.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If picProfil.Image Is Nothing Then
            MessageBox.Show("Foto belum dipilih")
            Exit Sub
        End If

        If rbCowo.Checked = False And
            rbCewe.Checked = False Then
            MessageBox.Show("Pilih jenis kelamin")
            Exit Sub
        End If

        If cblari.Checked = False And
           cbMemasak.Checked = False And
           cbTraveling.Checked = False And
           cbMelukis.Checked = False And
           cbMembacaBK.Checked = False And
           cbCuciMtr.Checked = False And
           cbProgramer.Checked = False And
           cbGaming.Checked = False And
           cbMenyanyi.Checked = False And
           cbBalet.Checked = False Then

            MessageBox.Show("Pilih minimal satu hobby")
            Exit Sub

        End If


        hobby = ""

        For Each c As Control In gbHobi.Controls

            If TypeOf c Is CheckBox Then

                Dim cb As CheckBox = CType(c, CheckBox)

                If cb.Checked Then
                    hobby &= cb.Text & ", "
                End If

            End If

        Next


        Dim jk As String

        If rbCowo.Checked Then
            jk = rbCowo.Text
        Else
            jk = rbCewe.Text
        End If


        Dim fh As New Form2

        fh.Nama = txtNama.Text
        fh.umur = txtUmur.Text
        fh.Telepon = txtTelpon.Text
        fh.Alamat = txtAlamat.Text
        fh.Tanggal = dtpTglLahir.Value.ToString("dd/MM/yyyy")
        fh.Hobby = hobby
        fh.Jk = jk
        fh.Foto = picProfil.Image

        fh.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class