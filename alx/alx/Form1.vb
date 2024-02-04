Imports System.Data.SqlClient
Public Class surur
    Dim _koneksi As SqlConnection
    Dim _adapter As SqlDataAdapter
    Dim _command As SqlCommand
    Dim _set As DataSet
    Dim _reader As SqlDataReader
    Dim _database As String

    Sub koneksi()
        _database = "Data Source = DESKTOP-1LHOCU8\PRASSSSS; initial catalog = db_tiketBus; integrated security = true"
        _koneksi = New SqlConnection(_database)
        If _koneksi.State = ConnectionState.Closed Then _koneksi.Open()
    End Sub

    Sub clearInput()
        txt_noBus.Clear()
        txt_sopir.Clear()
        txt_rute.Clear()
        txt_class.Clear()
        txt_harga.Clear()
        txt_jml_seats.Clear()
    End Sub

    Sub awal()
        clearInput()
        Dim query As String
        query = "SELECT * FROM tb_bus"
        _adapter = New SqlDataAdapter(query, _koneksi)
        _set = New DataSet
        _set.Clear()
        _adapter.Fill(_set, "tb_bus")
        DataGridView1.DataSource = (_set.Tables("tb_bus"))
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim query As String
        query = "INSERT INTO tb_bus VALUES ('" + txt_noBus.Text + "','" + txt_sopir.Text + "','" + txt_rute.Text + "','" + txt_class.Text + "','" + txt_harga.Text + "','" + txt_jml_seats.Text + "')"
        _command = New SqlCommand(query, _koneksi)

        Try
            _command.ExecuteNonQuery()
            MsgBox("Data Berhasil ditambahkan")
            awal()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub surur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        awal()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim query As String
        query = "UPDATE tb_bus SET no_bus = '" + txt_noBus.Text + "', nama_sopir = '" + txt_sopir.Text + "', rute = '" + txt_rute.Text + "', class_bus = '" + txt_class.Text + "', harga_tiket = '" + txt_harga.Text + "', jml_seats = '" + txt_jml_seats.Text + "' WHERE no_bus = '" + txt_noBus.Text + "'"
        _command = New SqlCommand(query, _koneksi)
        Try
            _command.ExecuteNonQuery()
            MsgBox("Data Berhasil diubah")
            awal()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim baris As Integer
        baris = DataGridView1.CurrentRow.Index
        txt_noBus.Text = DataGridView1.Item(0, baris).Value
        txt_sopir.Text = DataGridView1.Item(1, baris).Value
        txt_rute.Text = DataGridView1.Item(2, baris).Value
        txt_class.Text = DataGridView1.Item(3, baris).Value
        txt_harga.Text = DataGridView1.Item(4, baris).Value
        txt_jml_seats.Text = DataGridView1.Item(5, baris).Value
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim query As String
        query = "DELETE FROM tb_bus WHERE no_bus = '" + txt_noBus.Text + "'"
        _command = New SqlCommand(query, _koneksi)
        Try
            _command.ExecuteNonQuery()
            MsgBox("Data Berhasil dihapus")
            awal()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim query As String
        query = "SELECT * FROM tb_bus WHERE no_bus = '" + txt_cari.Text + "'"
        _command = New SqlCommand(query, _koneksi)
        _reader = _command.ExecuteReader
        _reader.Read()
        If _reader.HasRows Then
            txt_noBus.Text = _reader.Item("no-bus")
            txt_sopir.Text = _reader.Item("nama_sopir")
            txt_rute.Text = _reader.Item("rute")
            txt_class.Text = _reader.Item("class_bus")
            txt_harga.Text = _reader.Item("harga_tiket")
            txt_jml_seats.Text = _reader.Item("jml_seats")
        Else
            MsgBox("data tidak ada")
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Call clearInput()
    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        ReportBus.Show()
    End Sub
End Class

