Imports System

Public Class Tinggi
    Private Sub ButtonHitungTinggi_Click(sender As Object, e As EventArgs) Handles ButtonHitungTinggi.Click
        ' Validasi input
        If String.IsNullOrEmpty(TextBoxVolume.Text) Or String.IsNullOrEmpty(TextBoxJariJari.Text) Then
            MessageBox.Show("Harap isi semua field.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Mengambil nilai dari TextBox dan mengonversi ke tipe data Double
        Dim volume As Double = Double.Parse(TextBoxVolume.Text)
        Dim jariJari As Double = Double.Parse(TextBoxJariJari.Text)

        ' Hitung tinggi kerucut
        Dim tinggiKerucut As Double = (3.0 * volume) / (Math.PI * Math.Pow(jariJari, 2))

        ' Menampilkan hasil perhitungan
        MessageBox.Show("Tinggi Kerucut adalah: " & tinggiKerucut.ToString(), "Hasil Perhitungan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class