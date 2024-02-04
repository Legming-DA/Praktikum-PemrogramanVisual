Public Class TUGAS2
    Dim inputan As String, pilih, n1, n2 As Integer, total As Double
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        inputan = InputBox("Pilih Daftar Bangun Datar!", "PROGRAM BANGUN DATAR ")

        pilih = Val(inputan)
        MessageBox.Show("Anda Memilih No." & pilih & "", "Program Bangun Datar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        n1 = CDbl(txtN1.Text)
        n2 = CDbl(txtN2.Text)
        Select Case pilih
            Case 1
                total = 3.14 * n1 * n2
                MessageBox.Show("Jari-jari 1 : " & n1 & ", Jari-jari 2 : " & n2 & ", Luas Lingkaran = " & total & " cm", "Perhitungan Luas Lingkaran", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                total = n1 * n2
                MessageBox.Show("Panjang : " & n1 & ", Lebar : " & n2 & ", Luas Persegi Panjang = " & total & " cm", "Perhitungan Luas Persegi Panjang", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 3
                total = n1 * n2
                MessageBox.Show("Sisi 1 : " & n1 & ", Sisi 2 : " & n2 & ", Luas Persegi = " & total & " cm", "Perhitungan Luas Persegi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 4
                total = n1 * n2
                MessageBox.Show("Alas : " & n1 & ", Tinggi : " & n2 & ", Luas Jajar Genjang = " & total & " cm", "Perhitungan Luas Jajar Genjang", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 5
                total = (n1 * n2) / 2
                MessageBox.Show("Diagonal 1 : " & n1 & ", Diagonal 2 : " & n2 & ", Luas Belah Ketupat = " & total & " cm", "Perhitungan Luas Belah Ketupat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case Else
                MessageBox.Show("Anda salah memasukkan pilihan!", "CAUTION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
End Class