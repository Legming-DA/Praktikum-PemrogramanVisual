Imports System.Data.SqlClient

Public Class TUGAS8_2118118
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Ds As DataSet
    Dim Rd As SqlDataReader
    Dim MyDB As String

    Sub Koneksi()
        MyDB = "Data Source = DESKTOP-1LHOCU8\PRASSSSS; initial catalog = db_gudangPakaian; integrated security = true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

    Sub clear()
        txtID.Clear()
        txtJenis.Clear()
        txtUkuran.Clear()
        txtWarna.Clear()
        txtStok.Clear()
    End Sub

    Private Sub kondisiAwal()
        Call Koneksi()
        Call clear()
        Da = New SqlDataAdapter("Select * from StokPakaian", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "StokPakaian")
        DataGridView1.DataSource = (Ds.Tables("StokPakaian"))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New SqlDataAdapter("Select * from StokPakaian", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "StokPakaian")
        DataGridView1.DataSource = (Ds.Tables("StokPakaian"))
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If txtID.Text = "" Or txtJenis.Text = "" Or txtUkuran.Text = "" Or txtWarna.Text = "" Or txtStok.Text = "" Then
            MsgBox("Lengkapi Data Dahulu", MsgBoxStyle.Critical, "Failed")
        Else
            Call Koneksi()
            Dim input As String = "Insert into StokPakaian values ('" & txtID.Text & "', '" & txtJenis.Text & "', '" & txtUkuran.Text & "', '" & txtWarna.Text & "', '" & txtStok.Text & "')"
            Cmd = New SqlCommand(input, Conn)
            Try
                Cmd.ExecuteNonQuery()
                MsgBox("Data Pakaian Berhasil Diinput", MsgBoxStyle.Information, "Information")
                Call kondisiAwal()
            Catch ex As Exception
                MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical, "Failed")
            End Try
            Call clear()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call Koneksi()
        Dim baru As String = "update StokPakaian set id_pakaian = '" & txtID.Text & "', jenis_pakaian = '" & txtJenis.Text & "', ukuran = '" & txtUkuran.Text & "', warna = '" & txtWarna.Text & "', jumlah_stok = '" & txtStok.Text & "' where id_pakaian = '" & txtID.Text & "'"
        Cmd = New SqlCommand(baru, Conn)
        Try
            Cmd.ExecuteNonQuery()
            MsgBox("Data Pakaian Berhasil Diupdate", MsgBoxStyle.Information, "Information")
            Call kondisiAwal()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical, "Failed")
        End Try
        Call clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call Koneksi()
        Dim hapus As String = "delete from StokPakaian where id_pakaian = '" & txtID.Text & "'"
        Cmd = New SqlCommand(hapus, Conn)
        Try
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Information")
            Call kondisiAwal()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical, "Failed")
        End Try
        Call clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call clear()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call Koneksi()
        Cmd = New SqlCommand("select * from StokPakaian where id_pakaian = '" & txtCari.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            txtID.Text = Rd.Item("id_pakaian")
            txtJenis.Text = Rd.Item("jenis_pakaian")
            txtUkuran.Text = Rd.Item("ukuran")
            txtWarna.Text = Rd.Item("warna")
            txtStok.Text = Rd.Item("jumlah_stok")
        Else
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Critical, "Failed")
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ReportPakaian.Show()
    End Sub
End Class