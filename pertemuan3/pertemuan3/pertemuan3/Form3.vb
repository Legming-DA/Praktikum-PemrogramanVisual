Public Class Form3

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Integer
        For a = 2002 To 2023
            ComboBox1.Items.Add(a)
        Next
    End Sub
End Class