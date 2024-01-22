Public Class Form1

    Private Sub Btnbuka_Click(sender As Object, e As EventArgs) Handles Btnbuka.Click
        If ofdbuka.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Pcbgambar.Image = Image.FromFile(ofdbuka.FileName)
                Me.Text = "Membuka File" + ofdbuka.FileName
            Catch ex As Exception
                MessageBox.Show("File gagal di buka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Dim tutup As String
        tutup = MessageBox.Show("Yakin tutup form ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class
