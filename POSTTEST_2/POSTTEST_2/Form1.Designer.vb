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
        grpHapus = New GroupBox()
        btnHapus = New Button()
        txtHapus = New TextBox()
        lblJudulHapus = New Label()
        grpTambah = New GroupBox()
        btnTambah = New Button()
        txtGenre = New TextBox()
        lblJudulBuku = New Label()
        txtJudul = New TextBox()
        lblGenre = New Label()
        lstBuku = New ListBox()
        grpHapus.SuspendLayout()
        grpTambah.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpHapus
        ' 
        grpHapus.Controls.Add(btnHapus)
        grpHapus.Controls.Add(txtHapus)
        grpHapus.Controls.Add(lblJudulHapus)
        grpHapus.Location = New Point(454, 33)
        grpHapus.Name = "grpHapus"
        grpHapus.Size = New Size(287, 177)
        grpHapus.TabIndex = 0
        grpHapus.TabStop = False
        grpHapus.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(160, 142)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 3
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(129, 31)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(125, 27)
        txtHapus.TabIndex = 2
        ' 
        ' lblJudulHapus
        ' 
        lblJudulHapus.AutoSize = True
        lblJudulHapus.Location = New Point(16, 34)
        lblJudulHapus.Name = "lblJudulHapus"
        lblJudulHapus.Size = New Size(79, 20)
        lblJudulHapus.TabIndex = 4
        lblJudulHapus.Text = "Judul Buku"
        ' 
        ' grpTambah
        ' 
        grpTambah.Controls.Add(btnTambah)
        grpTambah.Controls.Add(txtGenre)
        grpTambah.Controls.Add(lblJudulBuku)
        grpTambah.Controls.Add(txtJudul)
        grpTambah.Controls.Add(lblGenre)
        grpTambah.Location = New Point(38, 33)
        grpTambah.Name = "grpTambah"
        grpTambah.Size = New Size(299, 177)
        grpTambah.TabIndex = 1
        grpTambah.TabStop = False
        grpTambah.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(164, 148)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(133, 90)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(125, 27)
        txtGenre.TabIndex = 4
        ' 
        ' lblJudulBuku
        ' 
        lblJudulBuku.AutoSize = True
        lblJudulBuku.Location = New Point(6, 34)
        lblJudulBuku.Name = "lblJudulBuku"
        lblJudulBuku.Size = New Size(79, 20)
        lblJudulBuku.TabIndex = 2
        lblJudulBuku.Text = "Judul Buku"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(133, 34)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(125, 27)
        txtJudul.TabIndex = 3
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(6, 76)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(48, 20)
        lblGenre.TabIndex = 3
        lblGenre.Text = "Genre"
        ' 
        ' lstBuku
        ' 
        lstBuku.FormattingEnabled = True
        lstBuku.Location = New Point(257, 234)
        lstBuku.Name = "lstBuku"
        lstBuku.Size = New Size(292, 204)
        lstBuku.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstBuku)
        Controls.Add(grpTambah)
        Controls.Add(grpHapus)
        Name = "Form1"
        Text = "Form1"
        grpHapus.ResumeLayout(False)
        grpHapus.PerformLayout()
        grpTambah.ResumeLayout(False)
        grpTambah.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpHapus As GroupBox
    Friend WithEvents grpTambah As GroupBox
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents lblJudulHapus As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents lblJudulBuku As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents lstBuku As ListBox

End Class
