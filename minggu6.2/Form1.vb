Public Class Form1
    Private Sub btnHari_Click(sender As Object, e As EventArgs) Handles btnHari.Click
        Dim strNamaHari(6) As String
        Dim x As Integer
        strNamaHari(0) = "Sunday"
        strNamaHari(1) = "Monday"
        strNamaHari(2) = "Tuesday"
        strNamaHari(3) = "Wednesday"
        strNamaHari(4) = "Thursday"
        strNamaHari(5) = "Friday"
        strNamaHari(6) = "Saturday"
        x = 0
        Array.Sort(strNamaHari)

        For x = 0 To 6
            lstHari.Items.Add(strNamaHari(x))
        Next
    End Sub
End Class
