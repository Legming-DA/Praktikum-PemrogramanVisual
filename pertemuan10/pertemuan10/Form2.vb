Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.IsLoggedIn Then
            Form1.ShowDialog()
            Me.Close()
            Exit Sub
        Else
            Form1.Close()
            Exit Sub
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        My.Settings.IsLoggedIn = False
        My.Settings.Save()
        Form1.Show()
        Me.Hide()
        Exit Sub
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Me.Show()
    End Sub
End Class