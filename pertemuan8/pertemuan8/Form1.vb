Imports System.Data.SqlClient
Public Class Form1
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Ds As DataSet
    Dim Rd As SqlDataReader
    Dim MyDB As String

    Sub Koneksi()
        MyDB = "Data Source = DESKTOP-1LHOCU8\PRASSSSS; initial catalog = db_mahasiswa; integrated security = true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

    Sub clear()
        txtNIM.Clear()
        txtNama.Clear()
        txtJur.Clear()
        txtAng.Clear()
    End Sub

    Private Sub kondisiAwal()
        Call Koneksi()
        Call clear()
        Da = New SqlDataAdapter("Select * from tb_mahasiswa", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tb_mahasiswa")
        DataGridView1.DataSource = (Ds.Tables("tb_mahasiswa"))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New SqlDataAdapter("Select * from tb_mahasiswa", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tb_mahasiswa")
        DataGridView1.DataSource = (Ds.Tables("tb_mahasiswa"))
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If txtNIM.Text = "" Or txtNama.Text = "" Or txtJur.Text = "" Or txtAng.Text = "" Then
            MsgBox("Lengkapi Data Dahulu", MsgBoxStyle.Critical, "Failed")
        Else
            Call Koneksi()
            Dim input As String = "Insert into tb_mahasiswa values ('" & txtNIM.Text & "', '" & txtNama.Text & "', '" & txtJur.Text & "', '" & txtAng.Text & "')"
            Cmd = New SqlCommand(input, Conn)
            Try
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Diinput", MsgBoxStyle.Information, "Information")
                Call kondisiAwal()
            Catch ex As Exception
                MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical, "Failed")
            End Try
            Call clear()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call Koneksi()
        Dim baru As String = "update tb_mahasiswa set NIM = '" & txtNIM.Text & "', Nama = '" & txtNama.Text & "', Jurusan = '" & txtJur.Text & "', Angkatan = '" & txtAng.Text & "' where NIM = '" & txtNIM.Text & "'"
        Cmd = New SqlCommand(baru, Conn)
        Try
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diupdate", MsgBoxStyle.Information, "Information")
            Call kondisiAwal()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical, "Failed")
        End Try
        Call clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call Koneksi()
        Dim hapus As String = "delete from tb_mahasiswa where NIM = '" & txtNIM.Text & "'"
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
        Cmd = New SqlCommand("select * from tb_mahasiswa where NIM = '" & txtCari.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            txtNIM.Text = Rd.Item("NIM")
            txtNama.Text = Rd.Item("Nama")
            txtJur.Text = Rd.Item("Jurusan")
            txtAng.Text = Rd.Item("Angkatan")
        Else
            MsgBox("Data Tidak Ditemukan!", MsgBoxStyle.Critical, "Failed")
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        FormCRMahasiswa.Show()
    End Sub
End Class
