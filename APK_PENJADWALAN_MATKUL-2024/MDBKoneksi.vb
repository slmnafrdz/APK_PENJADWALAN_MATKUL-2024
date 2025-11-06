Imports MySql.Data.MySqlClient
Module MDBKoneksi
    'memebuat variable
    Public DbKoneksi As MySqlConnection         'menampung data mysql
    Public DA As MySqlDataAdapter               '(DataAdapter) sebagai jembatan untuk mengambil dan mengirimkan data antara aplikasi dan database
    Public DS As DataSet                        '(DaraSet) berfungsi sebagai penampung data sementara yang diambil dari database.
    Public CMD As MySqlCommand                  'Menampung perintah SQL. Mengirimkan perintah tersebut ke server database
    Public DR As MySqlDataReader                'digunakan untuk membaca data dari database secara langsung dan berurutan
    Public Hitung As Integer = 1
    Public Kode_Jurusan As String
    Public Kode_Semester As String
    Public Nomor As Integer

    Public LokasiDatabase As String
    Public SQLinsert As String
    Public SQLUpdate As String
    Public SQLHapus As String
    Public Pesan As String
    Public PesanMk1 As String
    Public PesanSmtr As String

    'membuat prosedure Public untuk koneksi database
    Public Sub KoneksiDB()
        Try
            'lokasi Database
            LokasiDatabase = "Server=localhost;Uid=root;Pwd=salman;Database=dbakademik_2024"
            DbKoneksi = New MySqlConnection(LokasiDatabase)

            If DbKoneksi.State = ConnectionState.Closed Then
                DbKoneksi.Open()

            End If
        Catch ex As Exception
            MsgBox("KONEKSI GAGAL", vbExclamation, "KONEKSI GAGAL")
        End Try
    End Sub

    Function Diskonek()
        DbKoneksi.Close()
        Return DbKoneksi
    End Function
End Module
