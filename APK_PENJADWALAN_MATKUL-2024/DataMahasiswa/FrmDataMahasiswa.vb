Imports MySql.Data.MySqlClient

Public Class FrmDataMahasiswa
    Sub AktifDataGridMahasiswa()
        With DataGridMahasiswa
            .EnableHeadersVisualStyles = False

            'mengatur propertis pada data grid header
            .Font = New Font(DataGridMahasiswa.Font, FontStyle.Bold)
            DataGridMahasiswa.DefaultCellStyle.Font = New Font("Arial", 11)
            DataGridMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            DataGridMahasiswa.ColumnHeadersHeight = 40

            ' memberikan nama pada header NIK
            DataGridMahasiswa.Columns(0).Width = 150
            DataGridMahasiswa.Columns(0).HeaderText = "NIK"
            DataGridMahasiswa.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            'memberikan nama pada header nama 
            DataGridMahasiswa.Columns(1).Width = 250
            DataGridMahasiswa.Columns(1).HeaderText = "NAMA"
            DataGridMahasiswa.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            'memberikan nama pada headerJenis kelamin
            DataGridMahasiswa.Columns(2).Width = 150
            DataGridMahasiswa.Columns(2).HeaderText = "JENIS KELAMIN"
            DataGridMahasiswa.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            'memberikan nama pada headerJenis tempat lahir 
            DataGridMahasiswa.Columns(3).Width = 150
            DataGridMahasiswa.Columns(3).HeaderText = "TEMPAT LAHIR"
            DataGridMahasiswa.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            'memberikan nama pada header tanggal lahir 
            DataGridMahasiswa.Columns(4).Width = 150
            DataGridMahasiswa.Columns(4).HeaderText = "TGL LAHIR "
            DataGridMahasiswa.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            'memberikan nama pada header alamat
            DataGridMahasiswa.Columns(5).Width = 200
            DataGridMahasiswa.Columns(5).HeaderText = "ALAMAT"
            DataGridMahasiswa.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            'memberikan nama pada header nama pprodi 
            DataGridMahasiswa.Columns(6).Width = 230
            DataGridMahasiswa.Columns(6).HeaderText = "NAMA PRODI"
            DataGridMahasiswa.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            'memberikan nama pada header status mahasiswa
            DataGridMahasiswa.Columns(7).Width = 200
            DataGridMahasiswa.Columns(7).HeaderText = "STATUS MAHASISWA"
            DataGridMahasiswa.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With
    End Sub

    Sub TampilkanDataMahasiswa()
        Call KoneksiDB()
        DA = New MySqlDataAdapter("SELECT DISTINCT
                                  tbl_mahasiswa.NIK_Mhs,
                                  tbl_mahasiswa.Nm_Mhs,
                                  tbl_mahasiswa.JK_Mhs,
                                  tbl_mahasiswa.tmptlahir_Mhs,
                                  tbl_mahasiswa.TglLahir_Mhs,
                                  tbl_mahasiswa.Alamat_Mhs,
                                  tbl_prodi.Nm_prodi,
                                  tbl_mahasiswa.Status_Mhs
                                  FROM tbl_mahasiswa INNER JOIN tbl_prodi ON tbl_mahasiswa.Kd_Prodi = tbl_prodi.Kd_prodi", DbKoneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DataGridMahasiswa.DataSource = DS.Tables(0)
        Call AktifDataGridMahasiswa()
    End Sub

    Sub TampilkanNamaProdi()
        Call KoneksiDB()
        Kode_Jurusan = ""
        CMD = New MySqlCommand("SELECT tbl_prodi.Nm_prodi FROM tbl_prodi ORDER BY tbl_prodi.Kd_prodi", DbKoneksi)
        DR = CMD.ExecuteReader
        CbNamaprodi.Items.Clear()
        Do While DR.Read
            CbNamaprodi.Items.Add(DR.Item("Nm_prodi"))
        Loop
        DR.Close()
    End Sub

    Sub FilterNamaJurusanMahasiswa()
        Call KoneksiDB()
        'menampilkan filter data berdasarkan nama prodi
        DA = New MySqlDataAdapter("SELECT DISTINCT
                                  tbl_mahasiswa.NIK_Mhs,
                                  tbl_mahasiswa.Nm_Mhs,
                                  tbl_mahasiswa.JK_Mhs,
                                  tbl_mahasiswa.tmptlahir_Mhs,
                                  tbl_mahasiswa.TglLahir_Mhs,
                                  tbl_mahasiswa.Alamat_Mhs,
                                  tbl_prodi.Nm_prodi,
                                  tbl_mahasiswa.Status_Mhs 
                                  FROM tbl_mahasiswa INNER JOIN tbl_prodi ON tbl_mahasiswa.Kd_Prodi = tbl_prodi.Kd_prodi", DbKoneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DataGridMahasiswa.DataSource = DS.Tables(0)
        DataGridMahasiswa.ReadOnly = True

        'menvalidasi data jurusan yang belum ada pada datagrid atau database
        CMD = New MySqlCommand("SELECT DISTINCT tbl_prodi.Nm_prodi 
                        FROM tbl_mahasiswa 
                        INNER JOIN tbl_prodi 
                        ON tbl_mahasiswa.Kd_Prodi = tbl_prodi.Kd_prodi 
                        WHERE tbl_prodi.Nm_prodi = '" + CbNamaprodi.Text + "'", DbKoneksi)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            CbNamaprodi.Text = DR.Item("Nm_prodi")
        Else
            MsgBox("Data Mahasiswa Jurusan " & CbNamaprodi.Text & " Belum ada!", vbCritical + vbOK)
            Call TampilkanDataMahasiswa()
            CbNamaprodi.Focus()
            Exit Sub
        End If
        DR.Close()
    End Sub

    Private Sub FrmDataMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB()
        Call TampilkanDataMahasiswa()
        Call TampilkanNamaProdi()
        DataGridMahasiswa.Enabled = False
    End Sub

    Private Sub CbNamaJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNamaprodi.SelectedIndexChanged
        Call KoneksiDB()
        CMD = New MySqlCommand("SELECT * FROM tbl_prodi WHERE Nm_prodi ='" & CbNamaprodi.Text & "'", DbKoneksi)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Kode_Jurusan = DR.Item("Kd_Prodi")
            Lbkdprodi.Text = Microsoft.VisualBasic.Right(Kode_Jurusan, 2)
        End If
        DR.Close()
        Call FilterNamaJurusanMahasiswa()
    End Sub

    Sub carimana()
        Call KoneksiDB()
        DA = New MySqlDataAdapter("SELECT DISTINCT
                                  tbl_mahasiswa.NIK_Mhs,
                                  tbl_mahasiswa.Nm_Mhs,
                                  tbl_mahasiswa.JK_Mhs,
                                  tbl_mahasiswa.tmptlahir_Mhs,
                                  tbl_mahasiswa.TglLahir_Mhs,
                                  tbl_mahasiswa.Alamat_Mhs,
                                  tbl_prodi.Nm_prodi,
                                  tbl_mahasiswa.Status_Mhs 
                                  FROM tbl_mahasiswa INNER JOIN tbl_prodi ON tbl_mahasiswa.Kd_Prodi = tbl_prodi.Kd_prodi WHERE tbl_prodi.Nm_prodi
                                  = '" & CbNamaprodi.Text & "' AND tbl_mahasiswa.Nm_Mhs LIKE '%" & TxCariNama.Text & "%'", DbKoneksi)

        DS = New DataSet
        DA.Fill(DS)
        DataGridMahasiswa.DataSource = DS.Tables(0)

    End Sub

    Private Sub Btcari_Click(sender As Object, e As EventArgs) Handles Btcari.Click
        Call carimana()
        DataGridMahasiswa.Enabled = True
    End Sub

    Private Sub BtTambahData_Click(sender As Object, e As EventArgs) Handles BtTambahData.Click
        Call KoneksiDB()

        If CbNamaprodi.SelectedIndex = -1 Then
            MsgBox("Silahkan pilih nama prodi terlebih dahulu", vbVerticalTab + vbYes, "peringatan")
            CbNamaprodi.Focus()
        Else
            Call FrmDataMhs.Show()
            Call BuatNimMahasiswa(Lbkdprodi.Text)
            Me.Enabled = False
            FrmDataMhs.CbNmJurusan.Text = CbNamaprodi.Text
        End If
    End Sub

    Private Sub BtKeluar_Click(sender As Object, e As EventArgs) Handles BtKeluar.Click
        If BtKeluar.Text = "KELUAR" Then
            Pesan = MsgBox("Anda yakin ingin keluar dari from data mahasiswa?", vbQuestion + vbYesNo, "Informasi")
            If Pesan = vbYes Then
                Me.Close()
            End If
            'Else
            '   BtTambahData.Text = "&AKTIF FORM"
            '  BtTambahData.Text = True
            ' BtTambahData.BackColor = Color.LightGray
        End If
    End Sub
    Sub BuatNimMahasiswa(kodeprodi As String)
        Try
            ' Ambil tahun sekarang, misal 2025
            Dim TahunSekarang As String = Format(Date.Now, "yyyy")

            ' Query: ambil NIM terakhir berdasarkan tahun dan kode prodi
            Dim SQL As String =
            "SELECT NIK_Mhs FROM tbl_mahasiswa " &
            "WHERE LEFT(NIK_Mhs, 6) = '" & TahunSekarang & kodeprodi & "' " &
            "ORDER BY NIK_Mhs DESC LIMIT 1;"

            Dim CMD As New MySqlCommand(SQL, DbKoneksi)
            Dim DR As MySqlDataReader = CMD.ExecuteReader()

            Dim Hasil As String
            Dim Hitung As Long

            If DR.Read() Then
                ' Ambil 3 digit terakhir dari NIM terakhir, lalu tambah 1
                Hitung = CLng(Microsoft.VisualBasic.Right(DR.GetString(0), 3)) + 1
            Else
                Hitung = 1
            End If
            DR.Close()

            ' Format: YYYY + KODE PRODI + 3 digit urut
            Hasil = TahunSekarang & kodeprodi & Microsoft.VisualBasic.Right("000" & Hitung, 3)

            ' Tampilkan hasil ke label atau textbox
            FrmDataMhs.LbNim.Text = Hasil

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat membuat NIM: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridMahasiswa_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridMahasiswa.CellMouseDoubleClick
        On Error Resume Next

        FrmDataMhs.Show()
        Me.Enabled = False

        FrmDataMhs.BtHapus.Enabled = True
        FrmDataMhs.BtSimpan.Enabled = True
        FrmDataMhs.BtSimpan.Text = "&UBAH"
        FrmDataMhs.BtSimpan.BackColor = Color.CornflowerBlue

        FrmDataMhs.BtKeluar.Text = "&BATAL"
        FrmDataMhs.BtHapus.Enabled = True
        FrmDataMhs.BtHapus.BackColor = Color.CornflowerBlue

        Call KoneksiDB()
        Dim Baris As Integer
        CMD = New MySqlCommand("SELECT DISTINCT
                              tbl_mahasiswa.NIK_Mhs,
                              tbl_mahasiswa.Nm_Mhs,
                              tbl_mahasiswa.Jk_Mhs,
                              tbl_mahasiswa.Tmptlahir_Mhs,
                              tbl_mahasiswa.TglLahir_Mhs,
                              tbl_mahasiswa.Alamat_Mhs,
                              tbl_prodi.Nm_Prodi,
                              tbl_mahasiswa.Status_Mhs 
                            FROM tbl_mahasiswa
                              INNER JOIN tbl_prodi ON tbl_mahasiswa.Kd_prodi = tbl_prodi.Kd_Prodi 
                            WHERE tbl_mahasiswa.NIK_Mhs ='" + DataGridMahasiswa.Item(0, Baris).Value + "'", DbKoneksi)

        DR = CMD.ExecuteReader
        DR.Read()
        Baris = Me.DataGridMahasiswa.CurrentRow.Index
        With DataGridMahasiswa.Rows.Item(Baris)
            FrmDataMhs.LbNim.Text = .Cells(0).Value
            FrmDataMhs.TxtNama.Text = .Cells(1).Value
            FrmDataMhs.CbJenisKelamin.Text = .Cells(2).Value
            FrmDataMhs.TxtempatLahir.Text = .Cells(3).Value
            FrmDataMhs.DttglLahir.Text = .Cells(4).Value
            FrmDataMhs.TxtAlamat.Text = .Cells(5).Value
            FrmDataMhs.CbNmJurusan.Text = CbNamaprodi.Text
            FrmDataMhs.CbStatusMhs.Text = .Cells(6).Value
        End With
    End Sub

End Class
