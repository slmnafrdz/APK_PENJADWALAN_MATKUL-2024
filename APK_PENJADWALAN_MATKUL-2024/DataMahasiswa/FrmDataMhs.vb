Public Class FrmDataMhs
    Sub statusMhs()
        'membuat sub status mahasiswa yang akan di tampilkan kedalam objek combobox status
        CbStatusMhs.Items.Add("AKTIF")
        CbStatusMhs.Items.Add("NON AKTIF")
        CbStatusMhs.Items.Add("CUTI AKADEMIK")
        CbStatusMhs.Items.Add("DROP OUT")
    End Sub

    Sub JenisKelamin()
        CbJenisKelamin.Items.Add("LAKI-LAKI")
        CbJenisKelamin.Items.Add("PEREMPUAN")
    End Sub

    Private Sub CmdProdiMhs_DropDown()
    End Sub
    Private Sub BtKeluar_Click(sender As Object, e As EventArgs) Handles BtKeluar.Click
        If BtKeluar.Text = "KELUAR" Then
            Pesan = MsgBox("Anda yakin ingin keluar dari from data mahasiswa?", vbQuestion + vbYesNo, "Informasi")
            If Pesan = vbYes Then
                Me.Close()
                FrmDataMahasiswa.Enabled = True
            End If
            'Else
            'BtTambahData.Text = "&AKTIF FORM"
            'BtTambahData.Text = True
            'BtTambahData.BackColor = Color.LightGray
        End If
    End Sub

    Sub TampilkanFilterNamaProdi()
        Call KoneksiDB()
        Kode_Jurusan = " "
        CMD = New MySqlCommand("SELECT tbl_prodi.Nm_prodi FROM tbl_prodi ORDER BY Kd_Prodi ", DbKoneksi)
        DR = CMD.ExecuteReader
        CbNmJurusan.Items.Clear()
        Do While DR.Read
            CbNmJurusan.Items.Add(DR.Item("Nm_prodi"))
        Loop
        DR.Close()
    End Sub

    Private Sub BtSimpan_Click(sender As Object, e As EventArgs) Handles BtSimpan.Click
        If TxtNama.Text = "" Then
            MsgBox("Silahkan Isi datanya", vbInformation, "Informasi")
            TxtNama.Focus()
        Else
            Call KoneksiDB()
            Try
                'Perintah Insert untuk menyimpan data ke dalam tabel 
                If BtSimpan.Text = "&SIMPAN" Then
                    SQLinsert = "INSERT INTO tbl_mahasiswa VALUE('" & LbNim.Text & "', '" _
                    & TxtNama.Text & "','" _
                    & CbJenisKelamin.Text & "','" _
                    & TxtempatLahir.Text & "','" _
                    & Format(DttglLahir.Value, "yyyy-MM-dd") & "','" _
                    & TxtAlamat.Text & "','" _
                    & Lbkdprodi.Text & "','" _
                    & CbStatusMhs.Text & "')"

                    CMD = New MySqlCommand(SQLinsert, DbKoneksi)
                    CMD.ExecuteNonQuery()

                    MsgBox("Data berhasil ditambhakan ", vbInformation, "sukses")
                    Me.Close()
                    FrmDataMahasiswa.Show()
                    FrmDataMahasiswa.Enabled = True
                    FrmDataMahasiswa.TampilkanDataMahasiswa()

                ElseIf BtSimpan.Text = "&UBAH" Then
                    SQLUpdate = "UPDATE tbl_mahasiswa SET Nm_Mhs='" & TxtNama.Text & "', " _
                   & "Jk_Mhs='" & CbJenisKelamin.Text & "'," _
                   & "Tmptlahir_Mhs='" & TxtempatLahir.Text & "'," _
                   & "TglLahir_Mhs='" & DttglLahir.Text & "'," _
                   & "Alamat_Mhs='" & TxtAlamat.Text & "'," _
                   & "jurusan_Mhs='" & CbNmJurusan.Text & "'," _
                   & "Status_Mhs='" & CbStatusMhs.Text & "'" _
                   & "WHERE NIK_Mhs='" & LbNim.Text & "'"
                    CMD = New MySqlCommand(SQLUpdate, DbKoneksi)
                    CMD.ExecuteNonQuery()

                    MsgBox("Data berhasil diubah ", vbInformation, "sukses")
                    Me.Close()
                    FrmDataMahasiswa.Show()
                    FrmDataMahasiswa.Enabled = True
                    FrmDataMahasiswa.TampilkanDataMahasiswa()
                End If
            Catch ex As Exception
                MsgBox("gagal menyimpan data", vbInformation, "error")
            End Try
        End If
    End Sub

    Private Sub CbJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNmJurusan.SelectedIndexChanged
        Call KoneksiDB()
        CMD = New MySqlCommand("SELECT * FROM tbl_prodi WHERE Nm_Prodi='" & CbNmJurusan.Text & "'", DbKoneksi)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Kode_Jurusan = DR.Item("Kd_prodi")
            Lbkdprodi.Text = Kode_Jurusan
        End If
        DR.Close()
    End Sub

    Private Sub CbJurusan_DropDown(sender As Object, e As EventArgs) Handles CbNmJurusan.DropDown
        CbNmJurusan.SelectedIndex = -1
    End Sub

    Private Sub FrmDataMhs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB()
        Call statusMhs()
        Call JenisKelamin()
        Call TampilkanFilterNamaProdi()
    End Sub
End Class