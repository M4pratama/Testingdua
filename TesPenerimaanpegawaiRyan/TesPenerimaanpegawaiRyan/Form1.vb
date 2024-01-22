Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtNilai.TextChanged

    End Sub

    Private Sub TxtHasil_TextChanged(sender As Object, e As EventArgs) Handles TxtHasil.TextChanged

    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        If (Val(TxtNilai.Text >= 75)) Or (Val(txtHar.text >= 75)) Then
            TxtHasil.Text = "Lulus"
        Else
            TxtHasil.Text = "Tidak Lulus"




        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles TxtHar.Click
        End

    End Sub
End Class
