Imports System.Data.SqlClient
Public Class Login
    Dim Con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUsername.Text = "") Then
            MsgBox("Masukkan Username dan Password")
            txtUsername.Focus()
            Exit Sub
        End If
        If (txtPassword.Text = "") Then
            MsgBox("Masukkan Password")
            txtPassword.Focus()
        End If

        Try
            Con = New SqlConnection("Data Source=DESKTOP-1LHOCU8\PRASSSSS; Initial Catalog=db_tiketBus; Integrated Security=True")
            Con.Open()
            cmd = New SqlCommand("select * from Pengguna where Username= '" & txtUsername.Text & "' and Password = '" & txtPassword.Text & "'")
            cmd.Connection = Con
            rdr = cmd.ExecuteReader()

            If (rdr.Read()) Then
                My.Settings.IsLoggedIn = True
                My.Settings.Save()
                Menuuu.Show()
                Me.Hide()
            Else
                MsgBox("Masukkan Username dan Passowrd")
                txtUsername.Text = ""
                txtPassword.Text = ""
            End If
        Catch ex As Exception
        End Try

    End Sub
End Class