Public Class Form1

    Private Sub BtnProsses_Click(sender As Object, e As EventArgs) Handles BtnProsses.Click
        If TxtPas.Text = "rahasia" Then
            MsgBox("Password yang Anda Masukkan Benar",
            MsgBoxStyle.Information, "Info Login")
        Else
            MsgBox("Password yang Anda Masukkan Salah", 16, "Info")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pesan As String
        pesan = MsgBox("Apakah Anda ingin menutup Program ini?",
        MsgBoxStyle.YesNo + 32, "Tutup Program")
        If pesan = vbYes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class
