Imports System

Public Class Volume
    Private Sub ButtonHitungVolume_Click(sender As Object, e As EventArgs) Handles ButtonHitungVolume.Click
        ' Validasi input
        If String.IsNullOrEmpty(TextBoxJariJari.Text) Or String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("Harap isi semua field.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Mengambil nilai dari TextBox dan mengonversi ke tipe data Double
        Dim jariJari As Double = Double.Parse(TextBoxJariJari.Text)
        Dim tinggi As Double = Double.Parse(TextBox2.Text)

        ' Hitung volume kerucut
        Dim volumeKerucut As Double = (1.0 / 3.0) * Math.PI * Math.Pow(jariJari, 2) * tinggi

        ' Mengonversi hasil perhitungan ke bilangan bulat
        Dim hasilBulat As Integer = CInt(volumeKerucut)

        ' Menampilkan hasil perhitungan
        MessageBox.Show("Volume Kerucut adalah: " & hasilBulat.ToString(), "Hasil Perhitungan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class