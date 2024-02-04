Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("Kode Barang", 90)
        ListView1.Columns.Add("Nama Barang", 115)
        ListView1.Columns.Add("Jenis Barang", 115)
        txtKode.Text = 1
        'txtKode.Text = Val(txtKode.Text) + 1
        txtNama.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim Arr(2) As String
        Arr(0) = txtKode.Text
        Arr(1) = txtNama.Text
        Arr(2) = txtJenis.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        txtKode.Text = Val(txtKode.Text) + 1
        txtKode.Text = txtKode.Text
        txtNama.Text = " "
        txtJenis.Text = " "
        txtNama.Focus()
    End Sub
End Class
