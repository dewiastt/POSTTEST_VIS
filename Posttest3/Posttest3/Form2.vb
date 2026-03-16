Public Class Form2

    Public Nama As String
    Public umur As String
    Public Telepon As String
    Public Alamat As String
    Public Tanggal As String
    Public Hobby As String
    Public Jk As String
    Public Foto As Image

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = nama
        lblUmur.Text = umur
        lblTelpon.Text = telepon
        lblAlamat.Text = alamat
        lblTLahir.Text = tanggal
        lblHobi.Text = hobby
        lblJK.Text = jk

        PictureBox1.Image = foto

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint

    End Sub

    Private Sub lblKeyJK_Click(sender As Object, e As EventArgs) Handles lblKeyJK.Click

    End Sub
End Class