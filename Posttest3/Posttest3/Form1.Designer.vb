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
        picProfil = New PictureBox()
        btnGambar = New Button()
        lblNama = New Label()
        lblUmur = New Label()
        lblTglLahir = New Label()
        lblTelpon = New Label()
        lblAlamat = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelpon = New TextBox()
        txtAlamat = New TextBox()
        dtpTglLahir = New DateTimePicker()
        gbJKelamin = New GroupBox()
        rbCewe = New RadioButton()
        rbCowo = New RadioButton()
        gbHobi = New GroupBox()
        cbMenyanyi = New CheckBox()
        cbBalet = New CheckBox()
        cbGaming = New CheckBox()
        cbCuciMtr = New CheckBox()
        cbProgramer = New CheckBox()
        cbMembacaBK = New CheckBox()
        cbMelukis = New CheckBox()
        cbTraveling = New CheckBox()
        cbMemasak = New CheckBox()
        cblari = New CheckBox()
        btnCetak = New Button()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        gbJKelamin.SuspendLayout()
        gbHobi.SuspendLayout()
        SuspendLayout()
        ' 
        ' picProfil
        ' 
        picProfil.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        picProfil.BorderStyle = BorderStyle.FixedSingle
        picProfil.Location = New Point(20, 24)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(121, 136)
        picProfil.SizeMode = PictureBoxSizeMode.StretchImage
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' btnGambar
        ' 
        btnGambar.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnGambar.Cursor = Cursors.Hand
        btnGambar.FlatAppearance.BorderColor = Color.FromArgb(CByte(184), CByte(204), CByte(244))
        btnGambar.FlatStyle = FlatStyle.Flat
        btnGambar.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGambar.ForeColor = Color.Black
        btnGambar.Location = New Point(20, 181)
        btnGambar.Name = "btnGambar"
        btnGambar.Size = New Size(110, 32)
        btnGambar.TabIndex = 1
        btnGambar.Text = "Send Foto"
        btnGambar.UseVisualStyleBackColor = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
        lblNama.ForeColor = Color.Black
        lblNama.Location = New Point(160, 0)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 21)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Transparent
        lblUmur.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
        lblUmur.ForeColor = Color.Black
        lblUmur.Location = New Point(160, 55)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(56, 21)
        lblUmur.TabIndex = 3
        lblUmur.Text = "Umur"
        ' 
        ' lblTglLahir
        ' 
        lblTglLahir.AutoSize = True
        lblTglLahir.BackColor = Color.Transparent
        lblTglLahir.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
        lblTglLahir.ForeColor = Color.Black
        lblTglLahir.Location = New Point(160, 108)
        lblTglLahir.Name = "lblTglLahir"
        lblTglLahir.Size = New Size(125, 21)
        lblTglLahir.TabIndex = 4
        lblTglLahir.Text = "Tanggal Lahir"
        ' 
        ' lblTelpon
        ' 
        lblTelpon.AutoSize = True
        lblTelpon.BackColor = Color.Transparent
        lblTelpon.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
        lblTelpon.ForeColor = Color.Black
        lblTelpon.Location = New Point(160, 163)
        lblTelpon.Name = "lblTelpon"
        lblTelpon.Size = New Size(106, 21)
        lblTelpon.TabIndex = 5
        lblTelpon.Text = "No Telepon"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
        lblAlamat.ForeColor = Color.Black
        lblAlamat.Location = New Point(160, 216)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(70, 21)
        lblAlamat.TabIndex = 6
        lblAlamat.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.ForeColor = Color.Black
        txtNama.Location = New Point(160, 24)
        txtNama.MaxLength = 50
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(280, 28)
        txtNama.TabIndex = 7
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        txtUmur.BorderStyle = BorderStyle.FixedSingle
        txtUmur.ForeColor = Color.Black
        txtUmur.Location = New Point(160, 77)
        txtUmur.MaxLength = 3
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(280, 28)
        txtUmur.TabIndex = 8
        ' 
        ' txtTelpon
        ' 
        txtTelpon.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        txtTelpon.BorderStyle = BorderStyle.FixedSingle
        txtTelpon.ForeColor = Color.Black
        txtTelpon.Location = New Point(160, 185)
        txtTelpon.MaxLength = 15
        txtTelpon.Name = "txtTelpon"
        txtTelpon.Size = New Size(280, 28)
        txtTelpon.TabIndex = 9
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.ForeColor = Color.Black
        txtAlamat.Location = New Point(160, 240)
        txtAlamat.MaxLength = 100
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(280, 28)
        txtAlamat.TabIndex = 10
        ' 
        ' dtpTglLahir
        ' 
        dtpTglLahir.CalendarMonthBackground = Color.Black
        dtpTglLahir.CalendarTitleBackColor = SystemColors.ActiveCaptionText
        dtpTglLahir.CalendarTitleForeColor = Color.Black
        dtpTglLahir.CalendarTrailingForeColor = SystemColors.ControlText
        dtpTglLahir.Format = DateTimePickerFormat.Short
        dtpTglLahir.Location = New Point(160, 132)
        dtpTglLahir.Name = "dtpTglLahir"
        dtpTglLahir.Size = New Size(280, 28)
        dtpTglLahir.TabIndex = 11
        ' 
        ' gbJKelamin
        ' 
        gbJKelamin.BackColor = Color.Transparent
        gbJKelamin.Controls.Add(rbCewe)
        gbJKelamin.Controls.Add(rbCowo)
        gbJKelamin.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbJKelamin.ForeColor = Color.Black
        gbJKelamin.Location = New Point(460, 292)
        gbJKelamin.Name = "gbJKelamin"
        gbJKelamin.Size = New Size(160, 75)
        gbJKelamin.TabIndex = 12
        gbJKelamin.TabStop = False
        gbJKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbCewe
        ' 
        rbCewe.AutoSize = True
        rbCewe.BackColor = Color.Transparent
        rbCewe.Font = New Font("Calisto MT", 9F)
        rbCewe.ForeColor = Color.White
        rbCewe.Location = New Point(12, 48)
        rbCewe.Name = "rbCewe"
        rbCewe.Size = New Size(122, 25)
        rbCewe.TabIndex = 14
        rbCewe.TabStop = True
        rbCewe.Text = "Perempuan"
        rbCewe.UseVisualStyleBackColor = False
        ' 
        ' rbCowo
        ' 
        rbCowo.AutoSize = True
        rbCowo.BackColor = Color.Transparent
        rbCowo.Font = New Font("Calisto MT", 9F)
        rbCowo.ForeColor = Color.White
        rbCowo.Location = New Point(12, 25)
        rbCowo.Name = "rbCowo"
        rbCowo.Size = New Size(110, 25)
        rbCowo.TabIndex = 13
        rbCowo.TabStop = True
        rbCowo.Text = "Laki-Laki"
        rbCowo.UseVisualStyleBackColor = False
        ' 
        ' gbHobi
        ' 
        gbHobi.BackColor = Color.Transparent
        gbHobi.Controls.Add(cbMenyanyi)
        gbHobi.Controls.Add(cbBalet)
        gbHobi.Controls.Add(cbGaming)
        gbHobi.Controls.Add(cbCuciMtr)
        gbHobi.Controls.Add(cbProgramer)
        gbHobi.Controls.Add(cbMembacaBK)
        gbHobi.Controls.Add(cbMelukis)
        gbHobi.Controls.Add(cbTraveling)
        gbHobi.Controls.Add(cbMemasak)
        gbHobi.Controls.Add(cblari)
        gbHobi.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbHobi.ForeColor = Color.Black
        gbHobi.Location = New Point(20, 292)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(430, 145)
        gbHobi.TabIndex = 13
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' cbMenyanyi
        ' 
        cbMenyanyi.AutoSize = True
        cbMenyanyi.BackColor = Color.Transparent
        cbMenyanyi.Font = New Font("Calisto MT", 9F)
        cbMenyanyi.ForeColor = Color.White
        cbMenyanyi.Location = New Point(215, 110)
        cbMenyanyi.Name = "cbMenyanyi"
        cbMenyanyi.Size = New Size(113, 25)
        cbMenyanyi.TabIndex = 9
        cbMenyanyi.Text = "Menyanyi"
        cbMenyanyi.UseVisualStyleBackColor = False
        ' 
        ' cbBalet
        ' 
        cbBalet.AutoSize = True
        cbBalet.BackColor = Color.Transparent
        cbBalet.Font = New Font("Calisto MT", 9F)
        cbBalet.ForeColor = Color.White
        cbBalet.Location = New Point(215, 88)
        cbBalet.Name = "cbBalet"
        cbBalet.Size = New Size(75, 25)
        cbBalet.TabIndex = 8
        cbBalet.Text = "Balet"
        cbBalet.UseVisualStyleBackColor = False
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.BackColor = Color.Transparent
        cbGaming.Font = New Font("Calisto MT", 9F)
        cbGaming.ForeColor = Color.White
        cbGaming.Location = New Point(215, 66)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(99, 25)
        cbGaming.TabIndex = 7
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = False
        ' 
        ' cbCuciMtr
        ' 
        cbCuciMtr.AutoSize = True
        cbCuciMtr.BackColor = Color.Transparent
        cbCuciMtr.Font = New Font("Calisto MT", 9F)
        cbCuciMtr.ForeColor = Color.White
        cbCuciMtr.Location = New Point(215, 44)
        cbCuciMtr.Name = "cbCuciMtr"
        cbCuciMtr.Size = New Size(123, 25)
        cbCuciMtr.TabIndex = 6
        cbCuciMtr.Text = "Cuci motor"
        cbCuciMtr.UseVisualStyleBackColor = False
        ' 
        ' cbProgramer
        ' 
        cbProgramer.AutoSize = True
        cbProgramer.BackColor = Color.Transparent
        cbProgramer.Font = New Font("Calisto MT", 9F)
        cbProgramer.ForeColor = Color.White
        cbProgramer.Location = New Point(215, 22)
        cbProgramer.Name = "cbProgramer"
        cbProgramer.Size = New Size(116, 25)
        cbProgramer.TabIndex = 5
        cbProgramer.Text = "Programer"
        cbProgramer.UseVisualStyleBackColor = False
        ' 
        ' cbMembacaBK
        ' 
        cbMembacaBK.AutoSize = True
        cbMembacaBK.BackColor = Color.Transparent
        cbMembacaBK.Font = New Font("Calisto MT", 9F)
        cbMembacaBK.ForeColor = Color.White
        cbMembacaBK.Location = New Point(12, 110)
        cbMembacaBK.Name = "cbMembacaBK"
        cbMembacaBK.Size = New Size(157, 25)
        cbMembacaBK.TabIndex = 4
        cbMembacaBK.Text = "Membaca Buku"
        cbMembacaBK.UseVisualStyleBackColor = False
        ' 
        ' cbMelukis
        ' 
        cbMelukis.AutoSize = True
        cbMelukis.BackColor = Color.Transparent
        cbMelukis.Font = New Font("Calisto MT", 9F)
        cbMelukis.ForeColor = Color.White
        cbMelukis.Location = New Point(12, 88)
        cbMelukis.Name = "cbMelukis"
        cbMelukis.Size = New Size(97, 25)
        cbMelukis.TabIndex = 3
        cbMelukis.Text = "Melukis"
        cbMelukis.UseVisualStyleBackColor = False
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.BackColor = Color.Transparent
        cbTraveling.Font = New Font("Calisto MT", 9F)
        cbTraveling.ForeColor = Color.White
        cbTraveling.Location = New Point(12, 66)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(109, 25)
        cbTraveling.TabIndex = 2
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = False
        ' 
        ' cbMemasak
        ' 
        cbMemasak.AutoSize = True
        cbMemasak.BackColor = Color.Transparent
        cbMemasak.Font = New Font("Calisto MT", 9F)
        cbMemasak.ForeColor = Color.White
        cbMemasak.Location = New Point(12, 44)
        cbMemasak.Name = "cbMemasak"
        cbMemasak.Size = New Size(110, 25)
        cbMemasak.TabIndex = 1
        cbMemasak.Text = "Memasak"
        cbMemasak.UseVisualStyleBackColor = False
        ' 
        ' cblari
        ' 
        cblari.AutoSize = True
        cblari.BackColor = Color.Transparent
        cblari.Font = New Font("Calisto MT", 9F)
        cblari.ForeColor = Color.White
        cblari.Location = New Point(12, 22)
        cblari.Name = "cblari"
        cblari.Size = New Size(68, 25)
        cblari.TabIndex = 0
        cblari.Text = "Lari"
        cblari.UseVisualStyleBackColor = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnCetak.Cursor = Cursors.Hand
        btnCetak.FlatAppearance.BorderSize = 0
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetak.ForeColor = Color.Black
        btnCetak.Location = New Point(460, 399)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(143, 38)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCoral
        ClientSize = New Size(632, 473)
        Controls.Add(btnCetak)
        Controls.Add(gbHobi)
        Controls.Add(gbJKelamin)
        Controls.Add(dtpTglLahir)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelpon)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(lblAlamat)
        Controls.Add(lblTelpon)
        Controls.Add(lblTglLahir)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(btnGambar)
        Controls.Add(picProfil)
        Font = New Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Cetak Kartu"
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        gbJKelamin.ResumeLayout(False)
        gbJKelamin.PerformLayout()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProfil As PictureBox
    Friend WithEvents btnGambar As Button
    Friend WithEvents lblNama As Label
    Private lblUmur As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTglLahir As Label
    Friend WithEvents lblTelpon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelpon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpTglLahir As DateTimePicker
    Friend WithEvents gbJKelamin As GroupBox
    Private rbCewe As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rbCowo As RadioButton
    Friend WithEvents gbHobi As GroupBox
    Private cbMenyanyi As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents cbBalet As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents cbCuciMtr As CheckBox
    Private cbGaming As CheckBox
    Friend WithEvents cbProgramer As CheckBox
    Friend WithEvents cbMembacaBK As CheckBox
    Friend WithEvents cbMelukis As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents cblari As CheckBox
    Friend WithEvents btnCetak As Button

End Class