Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String = TextBox1.Text
        If s.Length < 17 Then Exit Sub
        Dim n As Integer = 0
        Dim mc As MatchCollection = Regex.Matches(s, "[0-9]{17}")
        If mc.Count < 1 Then Exit Sub
        For Each m As Match In mc
            s = s.Insert(m.Index + n, "[")
            s = s.Insert(m.Index + n + 17 + 1, "]")
            n += 2
        Next
        TextBox1.Text = s
    End Sub

End Class