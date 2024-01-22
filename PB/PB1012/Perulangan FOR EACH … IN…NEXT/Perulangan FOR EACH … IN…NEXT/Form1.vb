Public Class Form1

    

    

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cntr.Click
        For Each ctrl In Controls
            ctrl.Text = "Tombol"
        Next
    End Sub
End Class
