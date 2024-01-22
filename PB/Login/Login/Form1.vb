Private Sub BtnProses_Click(ByVal sender As System.Object, ...
    If TxtPas.Text = "rahasia" Then
        MsgBox("Password yang Anda Masukkan Benar",
        MsgBoxStyle.Information, "Info Login")
    Else
        MsgBox("Password yang Anda Masukkan Salah", 16, "Info")
    End If
End Sub