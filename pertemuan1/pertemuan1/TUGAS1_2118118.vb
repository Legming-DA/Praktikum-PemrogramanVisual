Public Class TUGAS1_2118118
    Dim A
    Private Sub TUGAS1_2118118_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnKonversi1_Click(sender As Object, e As EventArgs) Handles btnKonversi1.Click
        A = CInt(txtNilai1.Text) + CInt(txtNilai2.Text)
        txtHasil1.Text = A
    End Sub

    Private Sub btnKonversi2_Click(sender As Object, e As EventArgs) Handles btnKonversi2.Click
        txtHasil2.Text = txtNilai1.Text + txtNilai2.Text
    End Sub

    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        txtHasil3.Text = StrReverse(txtHasil2.Text)
    End Sub
End Class