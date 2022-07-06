Imports System.Data.Odbc
Public Class Formrental

    Sub tampil_user()
        CMD = New OdbcCommand("select * from rental", Conn)
        Rd = CMD.ExecuteReader
        dgvrental.Rows.Clear()
        Do While Rd.Read = True
            dgvrental.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3), Rd(4))
        Loop
    End Sub

    Sub bersih()
        txtkoderental.Clear()
        txtnamakendaraan.Clear()
        Txtnomorplat.Clear()
        txthargasewa.Clear()
        txtwarnakendaraan.Clear()
    End Sub

    Sub bersihtambahdata()
        txtnamakendaraan.Clear()
        Txtnomorplat.Clear()
        txthargasewa.Clear()
        txtwarnakendaraan.Clear()
    End Sub

    Private Sub kondisidisable()
        txtkoderental.Enabled = False
        txtnamakendaraan.Enabled = True
        Txtnomorplat.Enabled = True
        txthargasewa.Enabled = True
        txtwarnakendaraan.Enabled = True
        btntambahdata.Enabled = False
        btnsave.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub kondisienable()
        txtkoderental.Enabled = False
        txtnamakendaraan.Enabled = False
        Txtnomorplat.Enabled = False
        txthargasewa.Enabled = False
        txtwarnakendaraan.Enabled = True
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnclear.Enabled = False
        btnclose.Enabled = True
    End Sub

    Private Sub kondisisableupdate()
        txtkoderental.Enabled = False
        txtnamakendaraan.Enabled = True
        Txtnomorplat.Enabled = True
        txthargasewa.Enabled = True
        txtwarnakendaraan.Enabled = True
        btntambahdata.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
        btnclear.Enabled = True
        btnclose.Enabled = True
    End Sub

    Private Sub btntambahdata_Click(sender As Object, e As EventArgs) Handles btntambahdata.Click
        kondisidisable()
        Call Koneksi()
        CMD = New OdbcCommand("select koderental from rental order by koderental desc", Conn)
        Dim urutankode As String
        Dim hitung As Long
        Rd = CMD.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            urutankode = "RNTL" + "0001"
            txtnamakendaraan.Focus()
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 4) + 1
            urutankode = "RNTL" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        txtkoderental.Text = urutankode
        txtnamakendaraan.Focus()
        Call bersihtambahdata()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Formrental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call tampil_user()
        Call bersih()
        Call kondisidisable()
        Call kondisienable()
        Call bersihtambahdata()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        kondisienable()
        If txtkoderental.Text = "" Or txtnamakendaraan.Text = "" Or Txtnomorplat.Text = "" Or txthargasewa.Text = "" Or txtwarnakendaraan.Text = "" Then
            MsgBox("Semua Data Wajib di Isi.!!")
        Else
            'pesan username tidak boleh sama
            Call Koneksi()
            CMD = New OdbcCommand("select * from rental where koderental ='" & txtkoderental.Text & "'", Conn)
            Rd = CMD.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MsgBox("nomorplat tidak boleh sama")
                Call bersih()
            Else

                'pengecekan data user apakah ada atau tidak
                CMD = New OdbcCommand("select * rental rental where koderntal='" & txtkoderental.Text & "'", Conn)
                Rd = CMD.ExecuteReader
                Rd.Read()
                If Rd.HasRows = False Then
                    'penyimpanan data ke database
                    Call Koneksi()
                    CMD = New OdbcCommand("insert into rental values ('" & txtkoderental.Text &
                                              "','" & txtnamakendaraan.Text &
                                              "','" & Txtnomorplat.Text &
                                              "','" & txtwarnakendaraan.Text &
                                              "')", Conn)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Tambahkan.!!")
                    Call bersih()
                    Call tampil_user()
                Else
                End If
            End If
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Call Koneksi()
        CMD = New OdbcCommand("update rental set namakendaraan = '" & txtnamakendaraan.Text &
                                       "', username='" & Txtnomorplat.Text &
                                       "', password='" & txthargasewa.Text &
                                        "', password='" & txtwarnakendaraan.Text &
                                       "' where koderental = '" & txtkoderental.Text & "'", Conn)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil Di Update..!")
        Call bersih()
        Call tampil_user()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MsgBox("Apakah data akan di hapus..?") Then
            CMD = New OdbcCommand("delete from user where kodeuser = '" & txtkoderental.Text & "' ", Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di delete !!!")
            Call bersih()
            Call tampil_user()
        End If
    End Sub
End Class