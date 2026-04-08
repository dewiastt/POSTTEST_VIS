<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        lbltglahir = New Label()
        cmbDevisi = New ComboBox()
        rbPerempuan = New RadioButton()
        rbPria = New RadioButton()
        dtpTanggalLahir = New DateTimePicker()
        txtUmur = New TextBox()
        txtId = New TextBox()
        txtNama = New TextBox()
        TabPage2 = New TabPage()
        mtbTelepon = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        TabPage3 = New TabPage()
        btnSimpanCetak = New Button()
        chk8 = New CheckBox()
        chk7 = New CheckBox()
        chk6 = New CheckBox()
        chk5 = New CheckBox()
        chk4 = New CheckBox()
        chk3 = New CheckBox()
        chk2 = New CheckBox()
        chk1 = New CheckBox()
        GroupBox1 = New GroupBox()
        rbAnggota = New RadioButton()
        rbAdmin = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        pbProfil = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        OpenFileDialogFoto = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        lblaiunmul = New Label()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(pbProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 2, 0, 2)
        MenuStrip1.Size = New Size(1000, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(112, 29)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(111, 29)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(130, 29)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(108, 29)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(76, 29)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(196, 80)
        TabControl1.Margin = New Padding(4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(699, 402)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(lbltglahir)
        TabPage1.Controls.Add(cmbDevisi)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbPria)
        TabPage1.Controls.Add(dtpTanggalLahir)
        TabPage1.Controls.Add(txtUmur)
        TabPage1.Controls.Add(txtId)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Margin = New Padding(4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4)
        TabPage1.Size = New Size(691, 364)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' lbltglahir
        ' 
        lbltglahir.AutoSize = True
        lbltglahir.Location = New Point(30, 196)
        lbltglahir.Name = "lbltglahir"
        lbltglahir.Size = New Size(111, 25)
        lbltglahir.TabIndex = 7
        lbltglahir.Text = "Tanggal lahir"
        ' 
        ' cmbDevisi
        ' 
        cmbDevisi.FormattingEnabled = True
        cmbDevisi.Items.AddRange(New Object() {"DEPARTEMEN MEDIFO", "DEPARTEMEN KPSDM", "DEPARTEMEN HUBLU", "BENDAHARA", "SEKERTARIS", "KETUA"})
        cmbDevisi.Location = New Point(30, 312)
        cmbDevisi.Margin = New Padding(4)
        cmbDevisi.Name = "cmbDevisi"
        cmbDevisi.Size = New Size(188, 33)
        cmbDevisi.TabIndex = 6
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(112, 275)
        rbPerempuan.Margin = New Padding(4)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(126, 29)
        rbPerempuan.TabIndex = 5
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbPria
        ' 
        rbPria.AutoSize = True
        rbPria.Location = New Point(30, 275)
        rbPria.Margin = New Padding(4)
        rbPria.Name = "rbPria"
        rbPria.Size = New Size(66, 29)
        rbPria.TabIndex = 4
        rbPria.TabStop = True
        rbPria.Text = "Pria"
        rbPria.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(30, 236)
        dtpTanggalLahir.Margin = New Padding(4)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(323, 31)
        dtpTanggalLahir.TabIndex = 3
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(30, 146)
        txtUmur.Margin = New Padding(4)
        txtUmur.Name = "txtUmur"
        txtUmur.PlaceholderText = "Umur"
        txtUmur.Size = New Size(155, 31)
        txtUmur.TabIndex = 2
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(31, 91)
        txtId.Margin = New Padding(4)
        txtId.Name = "txtId"
        txtId.PlaceholderText = "Id"
        txtId.Size = New Size(155, 31)
        txtId.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(30, 34)
        txtNama.Margin = New Padding(4)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(155, 31)
        txtNama.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(mtbTelepon)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Margin = New Padding(4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4)
        TabPage2.Size = New Size(691, 364)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(42, 161)
        mtbTelepon.Margin = New Padding(4)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(155, 31)
        mtbTelepon.TabIndex = 2
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(39, 100)
        txtAlamat.Margin = New Padding(4)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(155, 31)
        txtAlamat.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(36, 42)
        txtEmail.Margin = New Padding(4)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(155, 31)
        txtEmail.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btnSimpanCetak)
        TabPage3.Controls.Add(chk8)
        TabPage3.Controls.Add(chk7)
        TabPage3.Controls.Add(chk6)
        TabPage3.Controls.Add(chk5)
        TabPage3.Controls.Add(chk4)
        TabPage3.Controls.Add(chk3)
        TabPage3.Controls.Add(chk2)
        TabPage3.Controls.Add(chk1)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(pbProfil)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Margin = New Padding(4)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(4)
        TabPage3.Size = New Size(691, 364)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.Location = New Point(211, 297)
        btnSimpanCetak.Margin = New Padding(4)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(229, 36)
        btnSimpanCetak.TabIndex = 11
        btnSimpanCetak.Text = "Simpan Dan Cetak Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = True
        ' 
        ' chk8
        ' 
        chk8.AutoSize = True
        chk8.Location = New Point(375, 260)
        chk8.Margin = New Padding(4)
        chk8.Name = "chk8"
        chk8.Size = New Size(114, 29)
        chk8.TabIndex = 10
        chk8.Text = "Menyanyi"
        chk8.UseVisualStyleBackColor = True
        ' 
        ' chk7
        ' 
        chk7.AutoSize = True
        chk7.Location = New Point(375, 228)
        chk7.Margin = New Padding(4)
        chk7.Name = "chk7"
        chk7.Size = New Size(78, 29)
        chk7.TabIndex = 9
        chk7.Text = "Tidur"
        chk7.UseVisualStyleBackColor = True
        ' 
        ' chk6
        ' 
        chk6.AutoSize = True
        chk6.Location = New Point(375, 196)
        chk6.Margin = New Padding(4)
        chk6.Name = "chk6"
        chk6.Size = New Size(111, 29)
        chk6.TabIndex = 8
        chk6.Text = "Fotografi"
        chk6.UseVisualStyleBackColor = True
        ' 
        ' chk5
        ' 
        chk5.AutoSize = True
        chk5.Location = New Point(375, 164)
        chk5.Margin = New Padding(4)
        chk5.Name = "chk5"
        chk5.Size = New Size(99, 29)
        chk5.TabIndex = 7
        chk5.Text = "Menulis"
        chk5.UseVisualStyleBackColor = True
        ' 
        ' chk4
        ' 
        chk4.AutoSize = True
        chk4.Location = New Point(211, 260)
        chk4.Margin = New Padding(4)
        chk4.Name = "chk4"
        chk4.Size = New Size(100, 29)
        chk4.TabIndex = 6
        chk4.Text = "Blogger"
        chk4.UseVisualStyleBackColor = True
        ' 
        ' chk3
        ' 
        chk3.AutoSize = True
        chk3.Location = New Point(211, 228)
        chk3.Margin = New Padding(4)
        chk3.Name = "chk3"
        chk3.Size = New Size(146, 29)
        chk3.TabIndex = 5
        chk3.Text = "Menggambar"
        chk3.UseVisualStyleBackColor = True
        ' 
        ' chk2
        ' 
        chk2.AutoSize = True
        chk2.Location = New Point(211, 196)
        chk2.Margin = New Padding(4)
        chk2.Name = "chk2"
        chk2.Size = New Size(91, 29)
        chk2.TabIndex = 4
        chk2.Text = "Makan"
        chk2.UseVisualStyleBackColor = True
        ' 
        ' chk1
        ' 
        chk1.AutoSize = True
        chk1.Location = New Point(211, 164)
        chk1.Margin = New Padding(4)
        chk1.Name = "chk1"
        chk1.Size = New Size(99, 29)
        chk1.TabIndex = 3
        chk1.Text = "Menulis"
        chk1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(rbAnggota)
        GroupBox1.Controls.Add(rbAdmin)
        GroupBox1.Controls.Add(rbKetua)
        GroupBox1.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.Desktop
        GroupBox1.Location = New Point(228, 19)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(228, 130)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jabatan"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(15, 89)
        rbAnggota.Margin = New Padding(4)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(104, 29)
        rbAnggota.TabIndex = 2
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(14, 59)
        rbAdmin.Margin = New Padding(4)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(113, 29)
        rbAdmin.TabIndex = 1
        rbAdmin.TabStop = True
        rbAdmin.Text = "Sekretaris"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(14, 28)
        rbKetua.Margin = New Padding(4)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(83, 29)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(54, 236)
        btnBrowse.Margin = New Padding(4)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(118, 36)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' pbProfil
        ' 
        pbProfil.BackgroundImageLayout = ImageLayout.Stretch
        pbProfil.Location = New Point(25, 19)
        pbProfil.Margin = New Padding(4)
        pbProfil.Name = "pbProfil"
        pbProfil.Size = New Size(170, 196)
        pbProfil.TabIndex = 0
        pbProfil.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' OpenFileDialogFoto
        ' 
        OpenFileDialogFoto.FileName = "OpenFileDialog2"
        ' 
        ' lblaiunmul
        ' 
        lblaiunmul.AutoSize = True
        lblaiunmul.Font = New Font("Showcard Gothic", 16.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblaiunmul.Location = New Point(199, 36)
        lblaiunmul.Name = "lblaiunmul"
        lblaiunmul.Size = New Size(553, 40)
        lblaiunmul.TabIndex = 2
        lblaiunmul.Text = "KOMUNITAS PENDAKI KALIMANTAN"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.AccessibleRole = AccessibleRole.MenuBar
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Location = New Point(35, 36)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(145, 154)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1000, 562)
        Controls.Add(PictureBox1)
        Controls.Add(lblaiunmul)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(pbProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cmbDevisi As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbPria As RadioButton
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents pbProfil As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents chk8 As CheckBox
    Friend WithEvents chk7 As CheckBox
    Friend WithEvents chk6 As CheckBox
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialogFoto As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblaiunmul As Label
    Friend WithEvents lbltglahir As Label
End Class