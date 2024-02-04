Imports System.Data.SqlClient

Public Class _2118118_TUGAS7
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim MyDB As String
    Sub Koneksi()
        MyDB = "Data Source = DESKTOP-1LHOCU8\PRASSSSS; initial catalog = db_gudangPakaian; integrated security = true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
    Private Sub _2118118_TUGAS7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New SqlDataAdapter("Select * from StokPakaian", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "StokPakaian")
        DataGridView1.DataSource = (Ds.Tables("StokPakaian"))
    End Sub
End Class