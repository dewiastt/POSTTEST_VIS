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
        lblsum = New Label()
        lblkum = New Label()
        ipsTxt = New TextBox()
        BTNTambah = New Button()
        btnReset = New Button()
        IpkText = New TextBox()
        LblPredikat = New Label()
        SuspendLayout()
        ' 
        ' lblsum
        ' 
        lblsum.AutoSize = True
        lblsum.Location = New Point(128, 143)
        lblsum.Name = "lblsum"
        lblsum.Size = New Size(105, 25)
        lblsum.TabIndex = 0
        lblsum.Text = "IP Semester"
        ' 
        ' lblkum
        ' 
        lblkum.AutoSize = True
        lblkum.Location = New Point(128, 252)
        lblkum.Name = "lblkum"
        lblkum.Size = New Size(107, 25)
        lblkum.TabIndex = 1
        lblkum.Text = "IP Kumulatif"
        ' 
        ' ipsTxt
        ' 
        ipsTxt.Location = New Point(270, 137)
        ipsTxt.Name = "ipsTxt"
        ipsTxt.Size = New Size(242, 31)
        ipsTxt.TabIndex = 2
        ' 
        ' BTNTambah
        ' 
        BTNTambah.Location = New Point(270, 188)
        BTNTambah.Name = "BTNTambah"
        BTNTambah.Size = New Size(112, 34)
        BTNTambah.TabIndex = 3
        BTNTambah.Text = "Tambah"
        BTNTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(400, 188)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 4
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' IpkText
        ' 
        IpkText.Location = New Point(270, 249)
        IpkText.Name = "IpkText"
        IpkText.Size = New Size(242, 31)
        IpkText.TabIndex = 5
        ' 
        ' LblPredikat
        ' 
        LblPredikat.AutoSize = True
        LblPredikat.Location = New Point(270, 308)
        LblPredikat.Name = "LblPredikat"
        LblPredikat.Size = New Size(168, 25)
        LblPredikat.TabIndex = 6
        LblPredikat.Text = "Sangat Memuaskan"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LblPredikat)
        Controls.Add(IpkText)
        Controls.Add(btnReset)
        Controls.Add(BTNTambah)
        Controls.Add(ipsTxt)
        Controls.Add(lblkum)
        Controls.Add(lblsum)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblsum As Label
    Friend WithEvents lblkum As Label
    Friend WithEvents ipsTxt As TextBox
    Friend WithEvents BTNTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents IpkText As TextBox
    Friend WithEvents LblPredikat As Label

End Class
