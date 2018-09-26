Public Class 字符画图片制作

    Private Sub 字符画图片制作_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListStyle.SelectedIndex = 0
    End Sub

    Private Sub ButGetPic_Click(sender As Object, e As EventArgs) Handles ButGetPic.Click
        Dim bc As Image = 剪贴板.图片
        If IsNothing(bc) Then
            TxtOut.Text = "no image!"
            Exit Sub
        End If
        If ListStyle.SelectedIndex < 0 Then ListStyle.SelectedIndex = 0
        Dim n As Integer = TxtHeight.Value
        Dim b As New Bitmap(bc, bc.Width * (n / bc.Height) * 1.8, n)
        Dim l As String = ListStyle.Text
        Dim out As String = ""
        Dim x As Integer, y As Integer
        For y = 0 To b.Height - 1
            For x = 0 To b.Width - 1
                n = 灰度(b.GetPixel(x, y)) / 256 * l.Length - 1
                If n < 1 Then n = 0
                out += l(n)
            Next
            out += vbCrLf
        Next
        TxtOut.Text = out
    End Sub

    Function 灰度(i As Color) As Integer
        Return Int(i.R * 0.2126 + i.G * 0.7152 + i.B * 0.0722)
    End Function

End Class