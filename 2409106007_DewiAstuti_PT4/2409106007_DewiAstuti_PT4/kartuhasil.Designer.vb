<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        pbFotoKartu = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblKontak = New Label()
        lblHobi = New Label()
        lblaiunmul = New Label()
        btnTutup = New Button()
        CType(pbFotoKartu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFotoKartu
        ' 
        pbFotoKartu.BackgroundImageLayout = ImageLayout.None
        pbFotoKartu.Location = New Point(41, 71)
        pbFotoKartu.Margin = New Padding(4)
        pbFotoKartu.Name = "pbFotoKartu"
        pbFotoKartu.Size = New Size(169, 192)
        pbFotoKartu.SizeMode = PictureBoxSizeMode.Zoom
        pbFotoKartu.TabIndex = 1
        pbFotoKartu.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(244, 71)
        lblNama.Margin = New Padding(4, 0, 4, 0)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(244, 115)
        lblID.Margin = New Padding(4, 0, 4, 0)
        lblID.Name = "lblID"
        lblID.Size = New Size(30, 25)
        lblID.TabIndex = 3
        lblID.Text = "ID"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Location = New Point(244, 160)
        lblKomunitas.Margin = New Padding(4, 0, 4, 0)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(96, 25)
        lblKomunitas.TabIndex = 4
        lblKomunitas.Text = "Komunitas"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.Location = New Point(244, 199)
        lblKontak.Margin = New Padding(4, 0, 4, 0)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(67, 25)
        lblKontak.TabIndex = 5
        lblKontak.Text = "Kontak"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Location = New Point(244, 238)
        lblHobi.Margin = New Padding(4, 0, 4, 0)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(138, 25)
        lblHobi.TabIndex = 6
        lblHobi.Text = "Hobby/Aktifitas"
        ' 
        ' lblaiunmul
        ' 
        lblaiunmul.AutoSize = True
        lblaiunmul.Font = New Font("Showcard Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblaiunmul.Location = New Point(41, 22)
        lblaiunmul.Name = "lblaiunmul"
        lblaiunmul.Size = New Size(415, 30)
        lblaiunmul.TabIndex = 8
        lblaiunmul.Text = "KOMUNITAS PENDAKI KALIMANTAN"
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(244, 294)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(112, 34)
        btnTutup.TabIndex = 9
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(648, 389)
        Controls.Add(btnTutup)
        Controls.Add(lblaiunmul)
        Controls.Add(lblHobi)
        Controls.Add(lblKontak)
        Controls.Add(lblKomunitas)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(pbFotoKartu)
        ForeColor = Color.Black
        Margin = New Padding(4)
        Name = "Form2"
        Text = "Form2"
        CType(pbFotoKartu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFotoKartu As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblaiunmul As Label
    Friend WithEvents btnTutup As Button
End Class