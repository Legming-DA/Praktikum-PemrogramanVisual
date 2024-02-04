Imports System.Data.SqlClient
Public Class Form1
    Dim Con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUser.Text = "") Then
            MsgBox("Masukkan Username dan Paswword")
            txtUser.Focus()
            Exit Sub
        End If
        If (txtPW.Text = "") Then
            MsgBox("Masukkan Password")
            txtPW.Focus()
        End If

        Try
            Con = New SqlConnection("Data Source=DESKTOP-1LHOCU8\PRASSSSS; Initial Catalog=db_user; Integrated Security=True")
            Con.Open()
            cmd = New SqlCommand("select * from tb_user where Username= '" & txtUser.Text & "' and Password = '" & txtPW.Text & "'")
            cmd.Connection = Con
            rdr = cmd.ExecuteReader()

            If (rdr.Read()) Then
                My.Settings.IsLoggedIn = True
                My.Settings.Save()
                Form2.Show()
                Me.Hide()
            Else
                MsgBox("Masukkan Username dan Passowrd")
                txtUser.Text = ""
                txtPW.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.IsLoggedIn Then
            Me.Close()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
