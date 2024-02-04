Public Class TUGAS6

  
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "File gambar (*.jpg,*.png,*.bmp) | *.jpg;*.png;*.bmp"

        If openFile.ShowDialog() = DialogResult.OK Then
            pictBox.Image = Image.FromFile(openFile.FileName)
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        pictBox.Image = Nothing
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim P As New IO.StreamReader("D:\KULIAH\2118118\Semester 4 (2223)\Pemrograman Visual\Praktikum\Project Praktikum\pertemuan6\" & txtFile.Text & ".txt")
        txtRead.Text = P.ReadToEnd
        P.Close()
    End Sub
End Class