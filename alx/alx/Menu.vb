Public Class Menuuu

    Private Sub Menuuu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.IsLoggedIn Then
            Login.ShowDialog()
            Me.Close()
            Exit Sub
        Else
            Login.Close()
            Exit Sub
        End If
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        My.Settings.IsLoggedIn = False
        My.Settings.Save()
        Login.Show()
        Me.Hide()
        Exit Sub
    End Sub

    Private Sub DataBusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBusToolStripMenuItem.Click
        My.Settings.IsLoggedIn = False
        My.Settings.Save()
        surur.Show()
        Me.Hide()
        Exit Sub
    End Sub
End Class