Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim sayi, ters As String
        Dim i As Integer = 0
        sayi = "12345"
        ters = StrReverse(sayi)
        ters = ters.Substring(0, 4)
        Do While (i < sayi.Length)
            ListBox1.Items.Add(ters.Substring(i, ters.Length - i).ToString() + sayi.Substring(0, sayi.Length - i).ToString())
            i = i + 1
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Dim rnd As New Random
        Dim ad() As String = {"Doğukan", "Anıl", "Kubilay", "Emre", "Deniz", "Mert", "Samet"}
        Dim il() As String = {"Ankara", "İzmir", "Antalya", "Ordu", "Artvin", "Rize", "Eskişehir"}
        Dim dizi(6, 6) As String
        For i = 0 To 6
            dizi(0, i) = ad(i)
            dizi(1, i) = il(rnd.Next(0, 7))
        Next
        For i = 0 To 6
            ListBox1.Items.Add(dizi(0, i).ToString() + Space(4) + dizi(1, i).ToString())
        Next
    End Sub
End Class
