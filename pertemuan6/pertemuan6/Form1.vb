Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim R As New IO.StreamReader("D:\KULIAH\2118118\Semester 4 (2223)\Pemrograman Visual\Praktikum\Project Praktikum\pertemuan6\" & txtFileName.Text & ".txt")
        'txtText.Text = R.ReadToEnd
        'R.Close()

        If txtFileName.Text = "legming2118118" Then
            Dim R As New IO.StreamReader("D:\KULIAH\2118118\Semester 4 (2223)\Pemrograman Visual\Praktikum\Project Praktikum\pertemuan6\" & txtFileName.Text & ".txt")
            txtText.Text = R.ReadToEnd
            R.Close()
        Else
            Try
                txtFileName.Text = "legming2118118"
            Catch ex As Exception
                MsgBox("Error: Could not find file", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Caution!")
            End Try
        End If 'Try
        '    txtFileName.Text = "legming2118118"
        'Catch ex As Exception
        '    MsgBox("Error: Could not find file", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Caution!")
        'End Try

    End Sub
End Class
