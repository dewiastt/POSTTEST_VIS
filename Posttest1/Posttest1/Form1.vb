Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles BTNTambah.Click
        Dim input As String = ipsTxt.Text.Replace(",", ".")
        Dim ip As Double


        If Double.TryParse(input, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, ip) Then


            If ip >= 0 And ip <= 4.0 Then


                totalIP += ip
                jumlahSemester += 1

                Dim ipk As Double = totalIP / jumlahSemester
                IpkText.Text = ipk.ToString("0.00")


                If ipk >= 2.0 And ipk <= 2.75 Then
                    LblPredikat.Text = "Cukup"
                ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                    LblPredikat.Text = "Memuaskan"
                ElseIf ipk > 3.0 Then
                    LblPredikat.Text = "Sangat Memuaskan"
                Else
                    LblPredikat.Text = "Di bawah standar"
                End If


                ipsTxt.Clear()
                ipsTxt.Focus()

            Else

                MessageBox.Show("Nilai IP Semester harus di antara 0 sampai 4.00!", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ipsTxt.Clear()
                ipsTxt.Focus()
            End If

        Else

            MessageBox.Show("Masukkan nilai IP Semester yang valid (angka)!", "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ipsTxt.Clear()
            ipsTxt.Focus()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        ipsTxt.Clear()
        IpkText.Clear()
        ipsTxt.Text = "-"
        ipsTxt.Focus()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblkum.Click

    End Sub
End Class