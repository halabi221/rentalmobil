Public Class menuutama


    Private Sub btnuser_Click(sender As Object, e As EventArgs) Handles btnuser.Click
        Formuser.Show()
    End Sub

    Private Sub btnrental_Click(sender As Object, e As EventArgs) Handles btnrental.Click
        Formrental.ShowDialog()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim keluar As String

        '' Tampil peringatan
        keluar = MsgBox("Yakin Anda Ingin Keluar...?", vbQuestion + vbYesNo, "Konfirmasi")
        If keluar = vbYes Then
            Me.Close()
        ElseIf keluar = vbNo Then
            Exit Sub
        End If
        Login.Show()

    End Sub

    Private Sub btnlaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        Formlaporansewa.Show()
    End Sub

    Private Sub menuutama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class