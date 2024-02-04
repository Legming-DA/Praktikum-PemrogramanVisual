Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim array(4, 1) As String
        array(0, 0) = "NIM"
        array(0, 1) = "Nama"
        array(1, 0) = "Jenis Kelamin"
        array(1, 1) = "Status"
        array(2, 0) = "Laki-laki"
        array(2, 1) = "Perempuan"
        array(3, 0) = "Mahasiswa"
        array(3, 1) = "Lulus"
        ListView1.GridLines = True
        ListView1.View = View.Details
        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(array(baris, kolom), 100)
            Next
        Next
        For baris = 2 To 2
            For kolom = 0 To 1
                cmbJenis.Items.Add(array(baris, kolom))
            Next
        Next
        For baris = 3 To 3
            For kolom = 0 To 1
                cmbStatus.Items.Add(array(baris, kolom))
            Next
        Next
        txtNIM.ReadOnly = True
        txtNIM.Text = "2118118"
        txtNama.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim array(4) As String
        array(0) = txtNIM.Text
        array(1) = txtNama.Text
        array(2) = cmbJenis.Text
        array(3) = cmbStatus.Text

        Dim list As New ListViewItem
        list = ListView1.Items.Add(array(0))
        list.SubItems.Add(array(1))
        list.SubItems.Add(array(2))
        list.SubItems.Add(array(3))
        txtNIM.Text = txtNIM.Text + 1
        txtNama.Text = " "
        cmbJenis.Text = " "
        cmbStatus.Text = " "
        txtNama.Focus()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub
End Class