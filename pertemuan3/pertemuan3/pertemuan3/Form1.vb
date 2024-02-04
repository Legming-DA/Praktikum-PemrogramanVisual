Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim awal, akhir As Integer
        awal = Val(TextBox1.Text)
        akhir = Val(TextBox2.Text)

        Do While awal <= akhir
            ListBox1.Items.Add(awal)
            awal = awal + 1
        Loop
    End Sub
End Class
