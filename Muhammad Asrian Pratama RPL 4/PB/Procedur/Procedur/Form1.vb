Public Class Form1
    Sub BERSIH()
        TextboxKB.Text = ""
        TextboxNB.Text = ""
        TextboxS.Text = ""
        TextboxJ.Text = ""
        TextboxH.Text = ""
        TextboxTH.Text = ""
        TextboxKB.Focus()
        TextboxTH.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BERSIH()
    End Sub

    Private Sub ButtonCLEAR_Click(sender As Object, e As EventArgs) Handles ButtonCLEAR.Click
        Call BERSIH()
    End Sub

    Private Sub ButtonEXIT_Click(sender As Object, e As EventArgs) Handles ButtonEXIT.Click
        Dim Tutup As String
        Tutup = MessageBox.Show("Yakin tutup form ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ButtonHITUNG_Click(sender As Object, e As EventArgs) Handles ButtonHITUNG.Click
        ' Memproses data dan menghitung total harga
        If Not IsNumeric(TextboxJ.Text) Or Not IsNumeric(TextboxH.Text) Then
            MessageBox.Show("Jumlah dan harga satuan harus angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim jumlah As Integer = Convert.ToInt32(TextboxJ.Text)
        Dim hargaSatuan As Double = Convert.ToDouble(TextboxH.Text)
        Dim totalHarga As Double = jumlah * hargaSatuan

        ' Menetapkan nilai pada textbox total harga
        TextboxTH.Text = totalHarga.ToString("N2")
        TextboxTH.Enabled = True
    End Sub
End Class