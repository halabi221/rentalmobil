Public Class Login
    Sub bersih()
        txtpassword.Clear()
    End Sub
    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Username atau Password Tidak Boleh Kosong!")
        Else
            Call Koneksi()
            CMD = New Odbc.OdbcCommand("Select * From user where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "'", Conn)
            Rd = CMD.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                'If txtusername.Text = "AA" And txtpassword.Text = "BB" Then
                Me.Hide()
                menuutama.Show()
            Else
                MsgBox("Username atau Password Salah!")
            End If
            Call bersih()
        End If

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub
End Class