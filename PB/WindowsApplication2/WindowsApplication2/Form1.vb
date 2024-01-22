Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnProsses.Click

        If TxtNPA.Text >= 85 And TxtNPS.Text >= 75 Then
            TxtHasil.Text = "LULUS"
        Else
            TxtHasil.Text = "GAGAL"
        End If
    End Sub


    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        TxtNPA.Text = " "
        TxtNPS.Text = " "
        TxtHasil.Text = " "
    End Sub

   

 

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        end

    End Sub
End Class
