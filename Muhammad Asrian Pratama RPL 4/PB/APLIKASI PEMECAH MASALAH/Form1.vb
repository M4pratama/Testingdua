Public Class Form1

    Private Sub Btnproses_Click(sender As Object, e As EventArgs) Handles Btnproses.Click
        Try
            Dim X As Integer
            X = Txtangka.Text
            Do
                X = X Mod 2
                If X = 0 Then
                    MessageBox.Show("Bilangan Genap", " Informasi")
                    Exit Do
                ElseIf X = 1 Then
                    MessageBox.Show("BILANGAN GANJIL", "iNFORMASI")
                    Exit Do
                End If
            Loop While Not (X)



        Catch ex As Exception
            MsgBox("Salah mengimput data/ imput angka")

        Finally

            Txtangka.Text = ""
            Txtangka.Focus()
        End Try

    End Sub
End Class
