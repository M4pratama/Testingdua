Public Class Form1
    Sub BERSIH()
        If textKB.SelectedItem = "01" Then
            textNB.Text = "Buku"
            textHS.Text = 4000
            textS.Text = "Buah"
        End If
        If textKB.SelectedItem = "02" Then
            textNB.Text = "Pulpen"
            textHS.Text = 2000
            textS.Text = "Buah"
        End If
        If textKB.SelectedItem = "03" Then
            textNB.Text = "Stipo"
            textHS.Text = 3000
            textS.Text = "Buah"
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BERSIH()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Call BERSIH()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Tutup.Click
        Dim Tutup As String
        Tutup = MessageBox.Show("Yakin tutup form ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class
