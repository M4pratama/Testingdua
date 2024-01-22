Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HitungVolumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HitungVolumeToolStripMenuItem.Click
        Volume.Show()


    End Sub

    Private Sub HitungTinggiKerucutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HitungTinggiKerucutToolStripMenuItem.Click
        Tinggi.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Keluar dari aplikasi
            Application.Exit()
        Else
            ' Tetap dalam aplikasi
        End If

    End Sub
End Class
