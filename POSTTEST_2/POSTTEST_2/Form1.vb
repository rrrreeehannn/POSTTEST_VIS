Public Class Form1

    Sub TampilData(ByVal lst As ListBox)

        lst.Items.Clear()

        For i As Integer = 0 To jumlah - 1
            lst.Items.Add(judulBuku(i) & " (" & genreBuku(i) & ")")
        Next

    End Sub

    Function CariBuku(ByVal judul As String) As Integer

        For i As Integer = 0 To jumlah - 1
            If judulBuku(i).ToLower = judul.ToLower Then
                Return i
            End If
        Next

        Return -1

    End Function


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        judulBuku(jumlah) = txtJudul.Text
        genreBuku(jumlah) = txtGenre.Text
        jumlah += 1

        TampilData(lstBuku)

        txtJudul.Clear()
        txtGenre.Clear()

    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim index As Integer
        index = CariBuku(txtHapus.Text)

        If index <> -1 Then

            For i As Integer = index To jumlah - 2
                judulBuku(i) = judulBuku(i + 1)
                genreBuku(i) = genreBuku(i + 1)
            Next

            jumlah -= 1
            TampilData(lstBuku)

        Else
            MessageBox.Show("Buku tidak ditemukan")
        End If

        txtHapus.Clear()

    End Sub

End Class