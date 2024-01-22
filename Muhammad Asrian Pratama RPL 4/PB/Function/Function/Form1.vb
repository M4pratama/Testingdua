Public Class Form1
    Function Akar(ByVal a As Decimal) As String
        Return Math.Sqrt(a)
    End Function

    Function pangkat(ByVal a As Decimal, ByVal b As Decimal) As String
        Return a ^ b
    End Function

    Function pembagian(ByVal a As Decimal, ByVal b As Decimal) As String
        Return a / b
    End Function
    Function perkalian(ByVal a As Decimal, ByVal b As Decimal) As String
        Return a * b
    End Function
    Function penjumlahan(ByVal a As Decimal, ByVal b As Decimal) As String
        Return a + b
    End Function
    Function pengurangan(ByVal a As Decimal, ByVal b As Decimal) As String
        Return a - b
    End Function
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If RdbAkar.Checked = True Then
            TxtHasil.Text = Akar(TxtVar1.Text)
        ElseIf RdbPangkat.Checked = True Then
            TxtHasil.Text = pangkat(TxtVar1.Text, TxtVar2.Text)
        ElseIf RdbPembagian.Checked = True Then
            TxtHasil.Text = pembagian(TxtVar1.Text, TxtVar2.Text)
        ElseIf RdbPerkalian.Checked = True Then
            TxtHasil.Text = perkalian(TxtVar1.Text, TxtVar2.Text)
        ElseIf RdbPenjumlahan.Checked = True Then
            TxtHasil.Text = penjumlahan(TxtVar1.Text, TxtVar2.Text)
        ElseIf RdbPengurangan.Checked = True Then
            TxtHasil.Text = pengurangan(TxtVar1.Text, TxtVar2.Text)
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim Tutup As String

        Tutup = MessageBox.Show("Yakin tutup form ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class
