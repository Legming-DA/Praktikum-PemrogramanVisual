Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tb.Text = "harga = " & CInt(txtharga.Text) * CInt(txttotal.Text) & "/n kode barang = " & txtkd.Text & "/n nama barang=" & txtnama.Text

    End Sub
End Class
