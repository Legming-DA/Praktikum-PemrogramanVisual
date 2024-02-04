Public Class Form1

    Sub tampilPesan()
        MsgBox("Inputkan Nama Anda", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "pesan")
    End Sub

    Sub tampilkan(ByVal nama As String)
        MessageBox.Show("Panggil " & nama)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String
        input = TextBox1.Text()
        Call tampilkan(input)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tampilPesan()
    End Sub
End Class
