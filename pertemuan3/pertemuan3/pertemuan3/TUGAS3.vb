Public Class TUGAS3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        'deklarasi variabel
        Dim a As Integer
        'kondisi perulangan
        For a = Val(txtAwal.Text) To Val(txtAkhir.Text)
            'jika a dibagi 2 bersisa 1, maka
            If a Mod 2 = 1 Then
                'menampilkan bilangan ganjil pada listbox1
                ListBox1.Items.Add(a)
            Else
                'menampilkan bilangan ganjil pada listbox2
                ListBox2.Items.Add(a)
            End If
        Next
    End Sub
End Class