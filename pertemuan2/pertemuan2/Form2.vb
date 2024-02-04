Public Class Form2
    Dim a, b
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        a = CInt(txtN1.Text) + CInt(txtN2.Text) + CInt(txtN3.Text)
        txtTotal.Text = a
        txtTotal.Visible = True

        b = (CInt(txtN1.Text) + CInt(txtN2.Text) + CInt(txtN3.Text)) / 3
        txtRata.Text = b

        If txtRata.Text >= 90 Then
            Label7.Text = "A"
            MessageBox.Show("Grade Nilai Anda A")
        ElseIf txtRata.Text >= 80 Then
            Label7.Text = "B"
            MessageBox.Show("Grade Nilai Anda B")
        ElseIf txtRata.Text >= 70 Then
            Label7.Text = "C"
            MessageBox.Show("Grade Nilai Anda C")
        Else
            Label7.Text = ""
            MessageBox.Show("Anda Tidak Lulus")
        End If
    End Sub
End Class