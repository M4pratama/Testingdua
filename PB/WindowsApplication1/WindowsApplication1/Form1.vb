Public Class Form1

    Private Sub BtnProses_Click(ByVal sender As System.Object, ...
        Select Case Val(TxtJPR.Text)
            Case 500 To 1000
                TxtHadiah.Text = "Mug Cantik"
            Case 1001 To 1500
                TxtHadiah.Text = "Boneka Cantik"
            Case 1501 To 2000
                TxtHadiah.Text = "Kipas Angin"
            Case 2001 To 2500
                TxtHadiah.Text = "Dispenser"
            Case Else
                TxtHadiah.Text = "Tidak Ada"
        End Select
    End Sub



    Private Sub TxtJPR_TextChanged(sender As Object, e As EventArgs) Handles TxtJPR.TextChanged

    End Sub
  

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

    End Sub
End Class
