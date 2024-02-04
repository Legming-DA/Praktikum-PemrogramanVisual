Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim L As New IO.StreamWriter("D:\KULIAH\2118118\Semester 4 (2223)\Pemrograman Visual\Praktikum\Project Praktikum\pertemuan6\" & txtFileName.Text & ".txt")
        L.Write(txtText.Text)
        L.Close()
    End Sub
End Class