<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblKode = New Label()
        lblNoHP = New Label()
        lblProduk = New Label()
        lblHarga = New Label()
        lblJumlah = New Label()
        lblTotal = New Label()
        TxtKode = New TextBox()
        TxtNoHP = New TextBox()
        CmbProduk = New ComboBox()
        TxtHarga = New TextBox()
        TxtJumlah = New TextBox()
        TxtTotal = New TextBox()
        BtnHitung = New Button()
        BtnSimpan = New Button()
        BtnBatal = New Button()
        dgvTransaksi = New DataGridView()
        PanelHeader = New Panel()
        lblTitle = New Label()
        lblSubtitle = New Label()
        StatusStrip1 = New StatusStrip()
        lblStatusBar = New ToolStripStatusLabel()
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).BeginInit()
        PanelHeader.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblKode
        ' 
        lblKode.Location = New Point(30, 90)
        lblKode.Name = "lblKode"
        lblKode.Size = New Size(100, 23)
        lblKode.TabIndex = 1
        lblKode.Text = "Kode Transaksi"
        ' 
        ' lblNoHP
        ' 
        lblNoHP.Location = New Point(30, 140)
        lblNoHP.Name = "lblNoHP"
        lblNoHP.Size = New Size(100, 23)
        lblNoHP.TabIndex = 3
        lblNoHP.Text = "Nomor HP"
        ' 
        ' lblProduk
        ' 
        lblProduk.Location = New Point(30, 190)
        lblProduk.Name = "lblProduk"
        lblProduk.Size = New Size(100, 23)
        lblProduk.TabIndex = 5
        lblProduk.Text = "Produk"
        ' 
        ' lblHarga
        ' 
        lblHarga.Location = New Point(400, 90)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(100, 23)
        lblHarga.TabIndex = 7
        lblHarga.Text = "Harga"
        ' 
        ' lblJumlah
        ' 
        lblJumlah.Location = New Point(400, 140)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(100, 23)
        lblJumlah.TabIndex = 9
        lblJumlah.Text = "Jumlah"
        ' 
        ' lblTotal
        ' 
        lblTotal.Location = New Point(400, 190)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(100, 23)
        lblTotal.TabIndex = 11
        lblTotal.Text = "Total"
        ' 
        ' TxtKode
        ' 
        TxtKode.Location = New Point(150, 90)
        TxtKode.Name = "TxtKode"
        TxtKode.Size = New Size(200, 31)
        TxtKode.TabIndex = 2
        ' 
        ' TxtNoHP
        ' 
        TxtNoHP.Location = New Point(150, 140)
        TxtNoHP.Name = "TxtNoHP"
        TxtNoHP.Size = New Size(200, 31)
        TxtNoHP.TabIndex = 4
        ' 
        ' CmbProduk
        ' 
        CmbProduk.Location = New Point(150, 190)
        CmbProduk.Name = "CmbProduk"
        CmbProduk.Size = New Size(200, 33)
        CmbProduk.TabIndex = 6
        ' 
        ' TxtHarga
        ' 
        TxtHarga.Location = New Point(520, 90)
        TxtHarga.Name = "TxtHarga"
        TxtHarga.ReadOnly = True
        TxtHarga.Size = New Size(202, 31)
        TxtHarga.TabIndex = 8
        ' 
        ' TxtJumlah
        ' 
        TxtJumlah.Location = New Point(520, 140)
        TxtJumlah.Name = "TxtJumlah"
        TxtJumlah.Size = New Size(202, 31)
        TxtJumlah.TabIndex = 10
        ' 
        ' TxtTotal
        ' 
        TxtTotal.Location = New Point(520, 190)
        TxtTotal.Name = "TxtTotal"
        TxtTotal.ReadOnly = True
        TxtTotal.Size = New Size(202, 31)
        TxtTotal.TabIndex = 12
        ' 
        ' BtnHitung
        ' 
        BtnHitung.Location = New Point(150, 240)
        BtnHitung.Name = "BtnHitung"
        BtnHitung.Size = New Size(75, 38)
        BtnHitung.TabIndex = 13
        BtnHitung.Text = "Hitung"
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.BackColor = Color.FromArgb(CByte(2), CByte(89), CByte(163))
        BtnSimpan.ForeColor = Color.White
        BtnSimpan.Location = New Point(260, 240)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(104, 38)
        BtnSimpan.TabIndex = 14
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = False
        ' 
        ' BtnBatal
        ' 
        BtnBatal.BackColor = Color.Gray
        BtnBatal.ForeColor = Color.White
        BtnBatal.Location = New Point(400, 240)
        BtnBatal.Name = "BtnBatal"
        BtnBatal.Size = New Size(75, 38)
        BtnBatal.TabIndex = 15
        BtnBatal.Text = "Batal"
        BtnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvTransaksi
        ' 
        dgvTransaksi.BackgroundColor = Color.Brown
        dgvTransaksi.ColumnHeadersHeight = 34
        dgvTransaksi.Location = New Point(0, 337)
        dgvTransaksi.Name = "dgvTransaksi"
        dgvTransaksi.RowHeadersWidth = 62
        dgvTransaksi.Size = New Size(840, 268)
        dgvTransaksi.TabIndex = 16
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.Firebrick
        PanelHeader.Controls.Add(lblTitle)
        PanelHeader.Controls.Add(lblSubtitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(840, 70)
        PanelHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(575, 40)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Transaksi Pulsa & Paket Data"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.ForeColor = Color.LightBlue
        lblSubtitle.Location = New Point(20, 40)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(100, 23)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Input transaksi pelanggan"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatusBar})
        StatusStrip1.Location = New Point(0, 608)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(840, 32)
        StatusStrip1.TabIndex = 17
        ' 
        ' lblStatusBar
        ' 
        lblStatusBar.Name = "lblStatusBar"
        lblStatusBar.Size = New Size(159, 25)
        lblStatusBar.Text = "FORM TRANSAKSI"
        ' 
        ' Form2
        ' 
        ClientSize = New Size(840, 640)
        Controls.Add(PanelHeader)
        Controls.Add(lblKode)
        Controls.Add(TxtKode)
        Controls.Add(lblNoHP)
        Controls.Add(TxtNoHP)
        Controls.Add(lblProduk)
        Controls.Add(CmbProduk)
        Controls.Add(lblHarga)
        Controls.Add(TxtHarga)
        Controls.Add(lblJumlah)
        Controls.Add(TxtJumlah)
        Controls.Add(lblTotal)
        Controls.Add(TxtTotal)
        Controls.Add(BtnHitung)
        Controls.Add(BtnSimpan)
        Controls.Add(BtnBatal)
        Controls.Add(dgvTransaksi)
        Controls.Add(StatusStrip1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Transaksi"
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).EndInit()
        PanelHeader.ResumeLayout(False)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' ================= DECLARE =================
    Friend WithEvents lblKode As Label
    Friend WithEvents lblNoHP As Label
    Friend WithEvents lblProduk As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblTotal As Label

    Friend WithEvents TxtKode As TextBox
    Friend WithEvents TxtNoHP As TextBox
    Friend WithEvents CmbProduk As ComboBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents TxtTotal As TextBox

    Friend WithEvents BtnHitung As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnBatal As Button

    Friend WithEvents dgvTransaksi As DataGridView

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatusBar As ToolStripStatusLabel

End Class