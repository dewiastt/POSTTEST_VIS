<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        grpTambah = New GroupBox()
        btnTambah = New Button()
        txtGenre = New TextBox()
        lblGenre = New Label()
        txtJudul = New TextBox()
        lblJudul = New Label()
        grpHapus = New GroupBox()
        btnHapus = New Button()
        txtHapus = New TextBox()
        lblHapus = New Label()
        listBuku = New ListBox()
        grpTambah.SuspendLayout()
        grpHapus.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpTambah
        ' 
        grpTambah.BackColor = SystemColors.ActiveCaption
        grpTambah.Controls.Add(btnTambah)
        grpTambah.Controls.Add(txtGenre)
        grpTambah.Controls.Add(lblGenre)
        grpTambah.Controls.Add(txtJudul)
        grpTambah.Controls.Add(lblJudul)
        grpTambah.Location = New Point(12, 12)
        grpTambah.Name = "grpTambah"
        grpTambah.Size = New Size(392, 240)
        grpTambah.TabIndex = 0
        grpTambah.TabStop = False
        grpTambah.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(144, 200)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(144, 108)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(150, 31)
        txtGenre.TabIndex = 1
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(15, 108)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(57, 25)
        lblGenre.TabIndex = 2
        lblGenre.Text = "genre"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(144, 51)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(150, 31)
        txtJudul.TabIndex = 1
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(6, 51)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(102, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = " Judul Buku"
        ' 
        ' grpHapus
        ' 
        grpHapus.BackColor = SystemColors.ActiveCaption
        grpHapus.Controls.Add(btnHapus)
        grpHapus.Controls.Add(txtHapus)
        grpHapus.Controls.Add(lblHapus)
        grpHapus.Cursor = Cursors.Hand
        grpHapus.Location = New Point(421, 12)
        grpHapus.Name = "grpHapus"
        grpHapus.Size = New Size(367, 240)
        grpHapus.TabIndex = 1
        grpHapus.TabStop = False
        grpHapus.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(164, 184)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(146, 47)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(150, 31)
        txtHapus.TabIndex = 1
        ' 
        ' lblHapus
        ' 
        lblHapus.AutoSize = True
        lblHapus.Location = New Point(6, 47)
        lblHapus.Name = "lblHapus"
        lblHapus.Size = New Size(97, 25)
        lblHapus.TabIndex = 0
        lblHapus.Text = "Judul Buku"
        ' 
        ' listBuku
        ' 
        listBuku.BackColor = SystemColors.ActiveCaption
        listBuku.FormattingEnabled = True
        listBuku.Location = New Point(218, 258)
        listBuku.Name = "listBuku"
        listBuku.Size = New Size(377, 179)
        listBuku.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(listBuku)
        Controls.Add(grpHapus)
        Controls.Add(grpTambah)
        Name = "Form1"
        Text = "Form1"
        grpTambah.ResumeLayout(False)
        grpTambah.PerformLayout()
        grpHapus.ResumeLayout(False)
        grpHapus.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpTambah As GroupBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents grpHapus As GroupBox
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents lblHapus As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents listBuku As ListBox

End Class