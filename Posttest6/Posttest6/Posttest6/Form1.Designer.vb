<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblKodeJenis = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TxtKodeJenis = New TextBox()
        TxtNamaProduk = New TextBox()
        TxtSearch = New TextBox()
        lblKategori = New Label()
        lblOperator = New Label()
        lblHarga = New Label()
        lblMasaAktif = New Label()
        lblStatusProd = New Label()
        CmbKategori = New ComboBox()
        CmbOperator = New ComboBox()
        CmbStatus = New ComboBox()
        TxtHarga = New TextBox()
        TxtMasaAktif = New TextBox()
        BtnSimpan = New Button()
        BtnUbah = New Button()
        BtnHapus = New Button()
        BtnBatal = New Button()
        BtnTransaksi = New Button()
        dgvJenis = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        PanelHeader = New Panel()
        lblTitle = New Label()
        lblSubtitle = New Label()
        StatusStrip1 = New StatusStrip()
        lblStatusBar = New ToolStripStatusLabel()
        lblCountBar = New ToolStripStatusLabel()
        CType(dgvJenis, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        PanelHeader.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblKodeJenis
        ' 
        lblKodeJenis.Location = New Point(30, 90)
        lblKodeJenis.Name = "lblKodeJenis"
        lblKodeJenis.Size = New Size(100, 23)
        lblKodeJenis.TabIndex = 1
        lblKodeJenis.Text = "Kode"
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(400, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 3
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(400, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 15
        Label3.Text = "Search"
        ' 
        ' TxtKodeJenis
        ' 
        TxtKodeJenis.Location = New Point(150, 90)
        TxtKodeJenis.Name = "TxtKodeJenis"
        TxtKodeJenis.Size = New Size(195, 31)
        TxtKodeJenis.TabIndex = 2
        ' 
        ' TxtNamaProduk
        ' 
        TxtNamaProduk.Location = New Point(520, 90)
        TxtNamaProduk.Name = "TxtNamaProduk"
        TxtNamaProduk.Size = New Size(183, 31)
        TxtNamaProduk.TabIndex = 4
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Location = New Point(520, 240)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.Size = New Size(183, 31)
        TxtSearch.TabIndex = 16
        ' 
        ' lblKategori
        ' 
        lblKategori.Location = New Point(30, 140)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(100, 23)
        lblKategori.TabIndex = 5
        lblKategori.Text = "Kategori"
        ' 
        ' lblOperator
        ' 
        lblOperator.Location = New Point(400, 140)
        lblOperator.Name = "lblOperator"
        lblOperator.Size = New Size(100, 23)
        lblOperator.TabIndex = 7
        lblOperator.Text = "Operator"
        ' 
        ' lblHarga
        ' 
        lblHarga.Location = New Point(30, 190)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(100, 23)
        lblHarga.TabIndex = 9
        lblHarga.Text = "Harga"
        ' 
        ' lblMasaAktif
        ' 
        lblMasaAktif.Location = New Point(400, 190)
        lblMasaAktif.Name = "lblMasaAktif"
        lblMasaAktif.Size = New Size(100, 23)
        lblMasaAktif.TabIndex = 11
        lblMasaAktif.Text = "Masa Aktif"
        ' 
        ' lblStatusProd
        ' 
        lblStatusProd.Location = New Point(30, 240)
        lblStatusProd.Name = "lblStatusProd"
        lblStatusProd.Size = New Size(100, 23)
        lblStatusProd.TabIndex = 13
        lblStatusProd.Text = "Status"
        ' 
        ' CmbKategori
        ' 
        CmbKategori.Items.AddRange(New Object() {"Pulsa", "Paket Data", "Nelpon"})
        CmbKategori.Location = New Point(150, 140)
        CmbKategori.Name = "CmbKategori"
        CmbKategori.Size = New Size(195, 33)
        CmbKategori.TabIndex = 6
        ' 
        ' CmbOperator
        ' 
        CmbOperator.Items.AddRange(New Object() {"Telkomsel", "Indosat", "By.u"})
        CmbOperator.Location = New Point(520, 140)
        CmbOperator.Name = "CmbOperator"
        CmbOperator.Size = New Size(183, 33)
        CmbOperator.TabIndex = 8
        ' 
        ' CmbStatus
        ' 
        CmbStatus.Items.AddRange(New Object() {"Aktif", "Belum Aktif"})
        CmbStatus.Location = New Point(150, 240)
        CmbStatus.Name = "CmbStatus"
        CmbStatus.Size = New Size(195, 33)
        CmbStatus.TabIndex = 14
        ' 
        ' TxtHarga
        ' 
        TxtHarga.Location = New Point(150, 190)
        TxtHarga.Name = "TxtHarga"
        TxtHarga.Size = New Size(195, 31)
        TxtHarga.TabIndex = 10
        ' 
        ' TxtMasaAktif
        ' 
        TxtMasaAktif.Location = New Point(520, 190)
        TxtMasaAktif.Name = "TxtMasaAktif"
        TxtMasaAktif.Size = New Size(183, 31)
        TxtMasaAktif.TabIndex = 12
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.BackColor = Color.FromArgb(CByte(2), CByte(89), CByte(163))
        BtnSimpan.ForeColor = Color.White
        BtnSimpan.Location = New Point(150, 290)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(94, 44)
        BtnSimpan.TabIndex = 17
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = False
        ' 
        ' BtnUbah
        ' 
        BtnUbah.BackColor = Color.Orange
        BtnUbah.ForeColor = Color.White
        BtnUbah.Location = New Point(270, 290)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(75, 40)
        BtnUbah.TabIndex = 18
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = False
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = Color.Red
        BtnHapus.ForeColor = Color.White
        BtnHapus.Location = New Point(374, 290)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(75, 40)
        BtnHapus.TabIndex = 19
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' BtnBatal
        ' 
        BtnBatal.BackColor = Color.Gray
        BtnBatal.ForeColor = Color.White
        BtnBatal.Location = New Point(488, 290)
        BtnBatal.Name = "BtnBatal"
        BtnBatal.Size = New Size(75, 40)
        BtnBatal.TabIndex = 20
        BtnBatal.Text = "Batal"
        BtnBatal.UseVisualStyleBackColor = False
        ' 
        ' BtnTransaksi
        ' 
        BtnTransaksi.BackColor = Color.Green
        BtnTransaksi.ForeColor = Color.White
        BtnTransaksi.Location = New Point(595, 290)
        BtnTransaksi.Name = "BtnTransaksi"
        BtnTransaksi.Size = New Size(108, 40)
        BtnTransaksi.TabIndex = 21
        BtnTransaksi.Text = "Transaksi"
        BtnTransaksi.UseVisualStyleBackColor = False
        ' 
        ' dgvJenis
        ' 
        dgvJenis.BackgroundColor = Color.Firebrick
        dgvJenis.ColumnHeadersHeight = 34
        dgvJenis.Location = New Point(20, 340)
        dgvJenis.Name = "dgvJenis"
        dgvJenis.RowHeadersWidth = 62
        dgvJenis.Size = New Size(780, 250)
        dgvJenis.TabIndex = 22
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
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
        lblTitle.Location = New Point(20, 5)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(562, 35)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Sistem Pulsa dan Paket Data Online"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.ForeColor = Color.LightBlue
        lblSubtitle.Location = New Point(20, 40)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(100, 23)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Kelola data dengan mudah"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatusBar, lblCountBar})
        StatusStrip1.Location = New Point(0, 608)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(840, 32)
        StatusStrip1.TabIndex = 23
        ' 
        ' lblStatusBar
        ' 
        lblStatusBar.Name = "lblStatusBar"
        lblStatusBar.Size = New Size(118, 25)
        lblStatusBar.Text = "DEWI ASTUTI"
        ' 
        ' lblCountBar
        ' 
        lblCountBar.Name = "lblCountBar"
        lblCountBar.Size = New Size(707, 25)
        lblCountBar.Spring = True
        ' 
        ' Form1
        ' 
        ClientSize = New Size(840, 640)
        Controls.Add(PanelHeader)
        Controls.Add(lblKodeJenis)
        Controls.Add(TxtKodeJenis)
        Controls.Add(Label2)
        Controls.Add(TxtNamaProduk)
        Controls.Add(lblKategori)
        Controls.Add(CmbKategori)
        Controls.Add(lblOperator)
        Controls.Add(CmbOperator)
        Controls.Add(lblHarga)
        Controls.Add(TxtHarga)
        Controls.Add(lblMasaAktif)
        Controls.Add(TxtMasaAktif)
        Controls.Add(lblStatusProd)
        Controls.Add(CmbStatus)
        Controls.Add(Label3)
        Controls.Add(TxtSearch)
        Controls.Add(BtnSimpan)
        Controls.Add(BtnUbah)
        Controls.Add(BtnHapus)
        Controls.Add(BtnBatal)
        Controls.Add(BtnTransaksi)
        Controls.Add(dgvJenis)
        Controls.Add(StatusStrip1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Pulsa"
        CType(dgvJenis, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        PanelHeader.ResumeLayout(False)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' ================= DECLARE =================
    Friend WithEvents lblKodeJenis As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

    Friend WithEvents TxtKodeJenis As TextBox
    Friend WithEvents TxtNamaProduk As TextBox
    Friend WithEvents TxtSearch As TextBox

    Friend WithEvents lblKategori As Label
    Friend WithEvents lblOperator As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblMasaAktif As Label
    Friend WithEvents lblStatusProd As Label

    Friend WithEvents CmbKategori As ComboBox
    Friend WithEvents CmbOperator As ComboBox
    Friend WithEvents CmbStatus As ComboBox

    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtMasaAktif As TextBox

    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnTransaksi As Button

    Friend WithEvents dgvJenis As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatusBar As ToolStripStatusLabel
    Friend WithEvents lblCountBar As ToolStripStatusLabel

End Class