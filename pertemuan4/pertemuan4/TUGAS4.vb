Public Class TUGAS4
    Dim nil1, nil2, hasil As Double

    Function aritmatika_operation()
        If (rbJumlah.Checked = True) Then
            hasil = nil1 + nil2
        ElseIf (rbKurang.Checked = True) Then
            hasil = nil1 - nil2
        ElseIf (rbKali.Checked = True) Then
            hasil = nil1 * nil2
        ElseIf (rbBagi.Checked = True) Then
            hasil = nil1 / nil2
        ElseIf (rbSisa.Checked = True) Then
            hasil = nil1 Mod nil2
        ElseIf (rbPangkat.Checked = True) Then
            hasil = nil1 ^ nil2
        End If
        txtHasil.Text = hasil
        Return hasil
    End Function

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Try
            nil1 = (txtN1.Text)
            nil2 = (txtN2.Text)
        Catch ex As Exception
            MsgBox("Nice Try, Cek Ulang Inputan-mu Bestie:v", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Caution!")
        End Try
        Call aritmatika_operation()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub
End Class