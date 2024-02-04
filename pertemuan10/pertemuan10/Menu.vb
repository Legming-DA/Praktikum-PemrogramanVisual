Public Class Menuu

    Private Sub Menuu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.IsLoggedIn Then
            TUGAS10_2118118.ShowDialog()
            Me.Close()
            Exit Sub
        Else
            TUGAS10_2118118.Close()
            Exit Sub
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        My.Settings.IsLoggedIn = False
        My.Settings.Save()
        TUGAS10_2118118.Show()
        Me.Hide()
        Exit Sub
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Me.Show()
    End Sub

    Private Sub DataStokPakaianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataStokPakaianToolStripMenuItem.Click
        My.Settings.IsLoggedIn = False
        My.Settings.Save()
        TUGAS8_2118118.Show()
        Me.Hide()
        Exit Sub
    End Sub
End Class