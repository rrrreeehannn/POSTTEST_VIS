Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If txtIPS.Text = "" Then
            MessageBox.Show("Masukkan IP Semester terlebih dahulu!")
            Exit Sub
        End If

        Dim ips As Double = Val(txtIPS.Text)

        totalIP += ips
        jumlahSemester += 1

        Dim ipk As Double = totalIP / jumlahSemester

        txtIPK.Text = Format(ipk, "0.00")
        lblPredikat.Text = HitungPredikat(ipk)

        txtIPS.Clear()
        txtIPS.Focus()

    End Sub

    Function HitungPredikat(ipk As Double) As String

        If ipk >= 2.0 And ipk <= 2.75 Then
            Return "Cukup"
        ElseIf ipk >= 2.76 And ipk <= 3.0 Then
            Return "Memuaskan"
        ElseIf ipk >= 3.01 Then
            Return "Sangat Memuaskan"
        Else
            Return "-"
        End If

    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        totalIP = 0
        jumlahSemester = 0

        txtIPK.Text = ""
        lblPredikat.Text = "-"
        txtIPS.Clear()
        txtIPS.Focus()

    End Sub

End Class