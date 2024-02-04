Imports System.Data.SqlClient
Public Class Form1
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Ds As DataSet
    Dim MyDB As String
    Sub Koneksi()
        MyDB = "Data Source = DESKTOP-1LHOCU8\PRASSSSS; initial catalog = db_mahasiswa; integrated security = true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New SqlDataAdapter("Select * from tb_mahasiswa", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tb_mahasiswa")
        DataGridView1.DataSource = (Ds.Tables("tb_mahasiswa"))
    End Sub
End Class
