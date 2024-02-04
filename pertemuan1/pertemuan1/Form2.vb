Public Class Form2
    Dim A

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        A = CInt(textA.Text) + CInt(textB.Text)
        textHasil.Text = A
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        A = CInt(textA.Text) * CInt(textB.Text)
        textHasil.Text = A
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        A = CInt(textA.Text) - CInt(textB.Text)
        textHasil.Text = A
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        A = CInt(textA.Text) / CInt(textB.Text)
        textHasil.Text = A
    End Sub

    Private Sub btnString_Click(sender As Object, e As EventArgs) Handles btnString.Click
        textHasil.Text = textA.Text + textB.Text
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click

    End Sub
End Class