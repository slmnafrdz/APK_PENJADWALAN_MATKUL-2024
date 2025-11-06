<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDataMhs
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbStatusMhs = New System.Windows.Forms.ComboBox()
        Me.CbNmJurusan = New System.Windows.Forms.ComboBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.CbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtSimpan = New System.Windows.Forms.Button()
        Me.BtKeluar = New System.Windows.Forms.Button()
        Me.BtHapus = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lbkdprodi = New System.Windows.Forms.Label()
        Me.DttglLahir = New System.Windows.Forms.DateTimePicker()
        Me.TxtempatLahir = New System.Windows.Forms.TextBox()
        Me.LbNim = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(665, 88)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = ":: BIODATA MAHASISWA ::"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CbStatusMhs
        '
        Me.CbStatusMhs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbStatusMhs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbStatusMhs.FormattingEnabled = True
        Me.CbStatusMhs.Location = New System.Drawing.Point(268, 455)
        Me.CbStatusMhs.Name = "CbStatusMhs"
        Me.CbStatusMhs.Size = New System.Drawing.Size(165, 29)
        Me.CbStatusMhs.TabIndex = 14
        '
        'CbNmJurusan
        '
        Me.CbNmJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNmJurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbNmJurusan.FormattingEnabled = True
        Me.CbNmJurusan.Location = New System.Drawing.Point(360, 407)
        Me.CbNmJurusan.Name = "CbNmJurusan"
        Me.CbNmJurusan.Size = New System.Drawing.Size(279, 29)
        Me.CbNmJurusan.TabIndex = 13
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(268, 288)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAlamat.Size = New System.Drawing.Size(371, 99)
        Me.TxtAlamat.TabIndex = 12
        '
        'CbJenisKelamin
        '
        Me.CbJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbJenisKelamin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbJenisKelamin.FormattingEnabled = True
        Me.CbJenisKelamin.Location = New System.Drawing.Point(268, 193)
        Me.CbJenisKelamin.Name = "CbJenisKelamin"
        Me.CbJenisKelamin.Size = New System.Drawing.Size(165, 29)
        Me.CbJenisKelamin.TabIndex = 10
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(268, 150)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(282, 28)
        Me.TxtNama.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 463)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 21)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Status Mahasiswa"
        '
        'BtSimpan
        '
        Me.BtSimpan.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtSimpan.Location = New System.Drawing.Point(30, 31)
        Me.BtSimpan.Name = "BtSimpan"
        Me.BtSimpan.Size = New System.Drawing.Size(127, 57)
        Me.BtSimpan.TabIndex = 3
        Me.BtSimpan.Text = "&SIMPAN"
        Me.BtSimpan.UseVisualStyleBackColor = True
        '
        'BtKeluar
        '
        Me.BtKeluar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtKeluar.ForeColor = System.Drawing.Color.Red
        Me.BtKeluar.Location = New System.Drawing.Point(513, 31)
        Me.BtKeluar.Name = "BtKeluar"
        Me.BtKeluar.Size = New System.Drawing.Size(125, 57)
        Me.BtKeluar.TabIndex = 2
        Me.BtKeluar.Text = "&KELUAR"
        Me.BtKeluar.UseVisualStyleBackColor = True
        '
        'BtHapus
        '
        Me.BtHapus.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtHapus.Location = New System.Drawing.Point(272, 31)
        Me.BtHapus.Name = "BtHapus"
        Me.BtHapus.Size = New System.Drawing.Size(126, 57)
        Me.BtHapus.TabIndex = 1
        Me.BtHapus.Text = "&HAPUS"
        Me.BtHapus.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.BtSimpan)
        Me.GroupBox2.Controls.Add(Me.BtKeluar)
        Me.GroupBox2.Controls.Add(Me.BtHapus)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 498)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(665, 113)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 415)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 21)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Jurusan "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tempat /Tgl Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NIM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama "
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Lbkdprodi)
        Me.GroupBox1.Controls.Add(Me.DttglLahir)
        Me.GroupBox1.Controls.Add(Me.TxtempatLahir)
        Me.GroupBox1.Controls.Add(Me.LbNim)
        Me.GroupBox1.Controls.Add(Me.CbStatusMhs)
        Me.GroupBox1.Controls.Add(Me.CbNmJurusan)
        Me.GroupBox1.Controls.Add(Me.TxtAlamat)
        Me.GroupBox1.Controls.Add(Me.CbJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Garamond", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 611)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = ":: Input Data :"
        '
        'Lbkdprodi
        '
        Me.Lbkdprodi.BackColor = System.Drawing.Color.Lime
        Me.Lbkdprodi.ForeColor = System.Drawing.Color.Transparent
        Me.Lbkdprodi.Location = New System.Drawing.Point(268, 407)
        Me.Lbkdprodi.Name = "Lbkdprodi"
        Me.Lbkdprodi.Size = New System.Drawing.Size(86, 28)
        Me.Lbkdprodi.TabIndex = 18
        '
        'DttglLahir
        '
        Me.DttglLahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DttglLahir.Location = New System.Drawing.Point(458, 245)
        Me.DttglLahir.Name = "DttglLahir"
        Me.DttglLahir.Size = New System.Drawing.Size(127, 28)
        Me.DttglLahir.TabIndex = 17
        '
        'TxtempatLahir
        '
        Me.TxtempatLahir.Location = New System.Drawing.Point(268, 245)
        Me.TxtempatLahir.Name = "TxtempatLahir"
        Me.TxtempatLahir.Size = New System.Drawing.Size(184, 28)
        Me.TxtempatLahir.TabIndex = 16
        '
        'LbNim
        '
        Me.LbNim.BackColor = System.Drawing.Color.Lime
        Me.LbNim.ForeColor = System.Drawing.Color.White
        Me.LbNim.Location = New System.Drawing.Point(268, 107)
        Me.LbNim.Name = "LbNim"
        Me.LbNim.Size = New System.Drawing.Size(184, 28)
        Me.LbNim.TabIndex = 15
        '
        'FrmDataMhs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmDataMhs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmDataMhs"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CbStatusMhs As ComboBox
    Friend WithEvents CbNmJurusan As ComboBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents CbJenisKelamin As ComboBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtSimpan As Button
    Friend WithEvents BtKeluar As Button
    Friend WithEvents BtHapus As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DttglLahir As DateTimePicker
    Friend WithEvents TxtempatLahir As TextBox
    Friend WithEvents LbNim As Label
    Friend WithEvents Lbkdprodi As Label
End Class
