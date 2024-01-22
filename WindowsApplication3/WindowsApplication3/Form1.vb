Public Class Form1

    Private Sub Cbokb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbokb.SelectedIndexChanged
        If Cbokb.Text = "PL01" Then
            TxtNb.Text = "PULPEN PILOT"
            TxtHb.Text = "1200"
        ElseIf Cbokb.Text = "PL02" Then
            TxtNb.Text = "PULPEN STANDART"
            TxtHb.Text = "1000"
        ElseIf Cbokb.Text = "BK01" Then
            TxtNb.Text = "BUKU AA 60 LBR"
            TxtHb.Text = "3800"
        Else
            TxtNb.Text = "BUKU SINAR DUNIA 50 LBR"
            TxtHb.Text = "3000"
        End If
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        End
    End Sub

    Private Sub Proses_Click(sender As Object, e As EventArgs) Handles Proses.Click
        If Val(Jumlah.Text) > 11 Then
            Dim Hitung
            Hitung = (Val(TxtHb.Text) * Val(Jumlah.Text)) * 0.15
            Diskon.Text = Hitung
            Dim AkHar
            AkHar = (Val(TxtHb.Text) * Val(Jumlah.Text)) - Hitung
            Total.Text = AkHar
        Else
            Dim Hitung
            Hitung = (Val(TxtHb.Text) * Val(Jumlah.Text))
            Diskon.Text = "Min beli 1 lusin"
            Total.Text = Hitung
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbokb.SelectedIndexChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtHb.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtNb.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles Total.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Cbokb.Text = ""
        TxtNb.Text = ""
        TxtHb.Text = ""
        Jumlah.Text = ""
        Diskon.Text = ""
        Total.Text = ""
    End Sub

    Private Sub Proses_Click_1(sender As Object, e As EventArgs) Handles Proses.Click

    End Sub

    Private Sub Jumlah_TextChanged(sender As Object, e As EventArgs) Handles Jumlah.TextChanged

    End Sub

    Private Sub Diskon_TextChanged(sender As Object, e As EventArgs) Handles Diskon.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub
End Class
