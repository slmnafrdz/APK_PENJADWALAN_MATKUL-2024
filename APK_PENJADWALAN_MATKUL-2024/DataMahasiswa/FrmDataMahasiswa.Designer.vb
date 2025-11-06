<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataMahasiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbkdprodi = New System.Windows.Forms.Label()
        Me.Btcari = New System.Windows.Forms.Button()
        Me.BtKeluar = New System.Windows.Forms.Button()
        Me.BtTambahData = New System.Windows.Forms.Button()
        Me.TxCariNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbNamaprodi = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridMahasiswa = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1240, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ":: DATA MAHASISWA ::"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Lbkdprodi)
        Me.Panel1.Controls.Add(Me.Btcari)
        Me.Panel1.Controls.Add(Me.BtKeluar)
        Me.Panel1.Controls.Add(Me.BtTambahData)
        Me.Panel1.Controls.Add(Me.TxCariNama)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CbNamaprodi)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 91)
        Me.Panel1.TabIndex = 1
        '
        'Lbkdprodi
        '
        Me.Lbkdprodi.AutoEllipsis = True
        Me.Lbkdprodi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbkdprodi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbkdprodi.ForeColor = System.Drawing.Color.Transparent
        Me.Lbkdprodi.Location = New System.Drawing.Point(129, 37)
        Me.Lbkdprodi.Name = "Lbkdprodi"
        Me.Lbkdprodi.Size = New System.Drawing.Size(36, 23)
        Me.Lbkdprodi.TabIndex = 8
        '
        'Btcari
        '
        Me.Btcari.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btcari.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btcari.Location = New System.Drawing.Point(832, 34)
        Me.Btcari.Name = "Btcari"
        Me.Btcari.Size = New System.Drawing.Size(75, 27)
        Me.Btcari.TabIndex = 6
        Me.Btcari.Text = "Cari"
        Me.Btcari.UseVisualStyleBackColor = True
        '
        'BtKeluar
        '
        Me.BtKeluar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtKeluar.AutoSize = True
        Me.BtKeluar.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtKeluar.ForeColor = System.Drawing.Color.Red
        Me.BtKeluar.Location = New System.Drawing.Point(1128, 29)
        Me.BtKeluar.Name = "BtKeluar"
        Me.BtKeluar.Size = New System.Drawing.Size(100, 35)
        Me.BtKeluar.TabIndex = 5
        Me.BtKeluar.Text = "KELUAR"
        Me.BtKeluar.UseVisualStyleBackColor = True
        '
        'BtTambahData
        '
        Me.BtTambahData.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtTambahData.AutoSize = True
        Me.BtTambahData.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtTambahData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtTambahData.Location = New System.Drawing.Point(952, 29)
        Me.BtTambahData.Name = "BtTambahData"
        Me.BtTambahData.Size = New System.Drawing.Size(159, 35)
        Me.BtTambahData.TabIndex = 4
        Me.BtTambahData.Text = "TAMBAH DATA"
        Me.BtTambahData.UseVisualStyleBackColor = True
        '
        'TxCariNama
        '
        Me.TxCariNama.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxCariNama.Location = New System.Drawing.Point(548, 35)
        Me.TxCariNama.Name = "TxCariNama"
        Me.TxCariNama.Size = New System.Drawing.Size(278, 25)
        Me.TxCariNama.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(439, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cari Nama"
        '
        'CbNamaprodi
        '
        Me.CbNamaprodi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNamaprodi.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNamaprodi.FormattingEnabled = True
        Me.CbNamaprodi.Items.AddRange(New Object() {"TEKNOLOGI MANUFAKTUR ", "TEKNOLOGI MEKATRONIKA ", "TEKNOLOGI REKAYASA PERANGKAT LUNAK", "TEKNOLOGI ELEKTRO"})
        Me.CbNamaprodi.Location = New System.Drawing.Point(171, 36)
        Me.CbNamaprodi.Name = "CbNamaprodi"
        Me.CbNamaprodi.Size = New System.Drawing.Size(262, 25)
        Me.CbNamaprodi.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Prodi"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(0, 560)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1240, 46)
        Me.Label4.TabIndex = 2
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.DataGridMahasiswa)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 154)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1240, 406)
        Me.Panel2.TabIndex = 3
        '
        'DataGridMahasiswa
        '
        Me.DataGridMahasiswa.AllowUserToDeleteRows = False
        Me.DataGridMahasiswa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMahasiswa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridMahasiswa.Location = New System.Drawing.Point(0, 0)
        Me.DataGridMahasiswa.Name = "DataGridMahasiswa"
        Me.DataGridMahasiswa.ReadOnly = True
        Me.DataGridMahasiswa.RowHeadersWidth = 51
        Me.DataGridMahasiswa.RowTemplate.Height = 24
        Me.DataGridMahasiswa.Size = New System.Drawing.Size(1240, 406)
        Me.DataGridMahasiswa.TabIndex = 0
        '
        'FrmDataMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 606)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmDataMahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmDataMahasiswa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtKeluar As Button
    Friend WithEvents BtTambahData As Button
    Friend WithEvents TxCariNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbNamaprodi As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridMahasiswa As DataGridView
    Friend WithEvents Btcari As Button
    Friend WithEvents Lbkdprodi As Label
End Class
