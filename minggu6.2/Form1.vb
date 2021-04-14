Public Class Form1
    Private Sub btnHari_Click(sender As Object, e As EventArgs) Handles btnHari.Click
        Dim strNamaHari(6) As String
        Dim x As Integer
        strNamaHari(0) = "Ahad"
        strNamaHari(1) = "Isnin"
        strNamaHari(2) = "Selasa"
        strNamaHari(3) = "Rabu"
        strNamaHari(4) = "Khamis"
        strNamaHari(5) = "Jumaat"
        strNamaHari(6) = "Sabtu"
        x = 0
        Array.Sort(strNamaHari)

        For x = 0 To 6
            lstHari.Items.Add(strNamaHari(x))
        Next
    End Sub
End Class
