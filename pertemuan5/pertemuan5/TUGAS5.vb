Public Class TUGAS5

    Private Sub TUGAS5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNama.Focus()
        Dim array(11, 0) As String
        array(0, 0) = "NIM"
        array(1, 0) = "Nama"
        array(2, 0) = "Nilai Tugas 1"
        array(3, 0) = "Nilai Tugas 2"
        array(4, 0) = "Nilai Tugas 3"
        array(5, 0) = "Nilai UTS"
        array(6, 0) = "Nilai UAS"
        array(7, 0) = "Jumlah"
        array(8, 0) = "Rata-rata"
        array(9, 0) = "Grade"
        array(10, 0) = "Keterangan"
        ListView1.GridLines = True
        ListView1.View = View.Details
        For baris = 0 To 11
            For kolom = 0 To 0
                ListView1.Columns.Add(array(baris, kolom), 0)
            Next
        Next

        'ListView1.GridLines = True
        'ListView1.View = View.Details

        txtNIM.ReadOnly = True
        txtNIM.Text = "2118001"
    End Sub

    Private Sub txtN1_TextChanged(sender As Object, e As EventArgs) Handles txtN1.TextChanged
        txtJumlah.Text = Val(txtN1.Text) + Val(txtN2.Text) + Val(txtN3.Text) + Val(txtUTS.Text) + Val(txtUAS.Text)
        txtRata.Text = FormatNumber((txtJumlah.Text) / 5)
    End Sub

    Private Sub txtN2_TextChanged(sender As Object, e As EventArgs) Handles txtN2.TextChanged
        txtJumlah.Text = Val(txtN1.Text) + Val(txtN2.Text) + Val(txtN3.Text) + Val(txtUTS.Text) + Val(txtUAS.Text)
        txtRata.Text = FormatNumber((txtJumlah.Text) / 5)
    End Sub

    Private Sub txtN3_TextChanged(sender As Object, e As EventArgs) Handles txtN3.TextChanged
        txtJumlah.Text = Val(txtN1.Text) + Val(txtN2.Text) + Val(txtN3.Text) + Val(txtUTS.Text) + Val(txtUAS.Text)
        txtRata.Text = FormatNumber((txtJumlah.Text) / 5)
    End Sub

    Private Sub txtUTS_TextChanged(sender As Object, e As EventArgs) Handles txtUTS.TextChanged
        txtJumlah.Text = Val(txtN1.Text) + Val(txtN2.Text) + Val(txtN3.Text) + Val(txtUTS.Text) + Val(txtUAS.Text)
        txtRata.Text = FormatNumber((txtJumlah.Text) / 5)
    End Sub

    Private Sub txtUAS_TextChanged(sender As Object, e As EventArgs) Handles txtUAS.TextChanged
        txtJumlah.Text = Val(txtN1.Text) + Val(txtN2.Text) + Val(txtN3.Text) + Val(txtUTS.Text) + Val(txtUAS.Text)
        txtRata.Text = FormatNumber((txtJumlah.Text) / 5)
    End Sub

    Private Sub txtRata_TextChanged(sender As Object, e As EventArgs) Handles txtRata.TextChanged
        If txtRata.Text >= 90 Then
            txtGrade.Text = "A"
        ElseIf txtRata.Text >= 80 Then
            txtGrade.Text = "B"
        ElseIf txtRata.Text >= 70 Then
            txtGrade.Text = "C"
        ElseIf txtRata.Text < 70 Then
            txtGrade.Text = "D"
        End If
    End Sub

    Private Sub txtGrade_TextChanged(sender As Object, e As EventArgs) Handles txtGrade.TextChanged
        If txtGrade.Text = "A" Then
            txtKet.Text = "Lulus"
        ElseIf txtGrade.Text = "B" Then
            txtKet.Text = "Lulus"
        ElseIf txtGrade.Text = "C" Then
            txtKet.Text = "Lulus"
        Else
            txtKet.Text = "Tidak Lulus"
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim array(10) As String
        array(0) = txtNIM.Text
        array(1) = txtNama.Text
        array(2) = txtN1.Text
        array(3) = txtN2.Text
        array(4) = txtN3.Text
        array(5) = txtUTS.Text
        array(6) = txtUAS.Text
        array(7) = txtJumlah.Text
        array(8) = txtRata.Text
        array(9) = txtGrade.Text
        array(10) = txtKet.Text

        Dim list As ListViewItem
        list = New ListViewItem
        list = ListView1.Items.Add(array(0))
        list.SubItems.Add(array(1))
        list.SubItems.Add(array(2))
        list.SubItems.Add(array(3))
        list.SubItems.Add(array(4))
        list.SubItems.Add(array(5))
        list.SubItems.Add(array(6))
        list.SubItems.Add(array(7))
        list.SubItems.Add(array(8))
        list.SubItems.Add(array(9))
        list.SubItems.Add(array(10))

        txtNIM.Text = Val(txtNIM.Text) + 1
        txtNama.Text = " "
        txtNama.Clear()
        txtN1.Clear()
        txtN2.Clear()
        txtN3.Clear()
        txtUTS.Clear()
        txtUAS.Clear()
        txtJumlah.Clear()
        txtGrade.Clear()
        txtKet.Clear()

        txtNama.Focus()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

End Class