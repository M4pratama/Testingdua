Public Class Form1

    Private Sub Proses_Click(sender As Object, e As EventArgs) Handles Proses.Click
        Dim angka As Integer
        ListBox1.Items.Clear()
        angka = 1
        While angka <= Val(TxtBatas.Text)
            ListBox1.Items.Add(angka)
            angka = angka + 1
        End While

    End Sub
End Class
