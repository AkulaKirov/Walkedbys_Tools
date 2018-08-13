
Public Class 未响应图片制作器

    Dim 名字 As String = ""
    Dim 图片 As Image = Nothing
    Dim 输出 As Image = Nothing

    Private Sub 未响应图片制作器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        文本框拖入文件(TxtICO)
        TxtName.Text = 设置.元素("NoRESname")
        TxtICO.Text = 设置.元素("NoRESico")
    End Sub

    Sub 绘制()
        输出 = New Bitmap(LabS.Width, LabS.Height)
        Dim g As Graphics = Graphics.FromImage(输出)
        g.Clear(Color.White)
        g.DrawImage(My.Resources.无响应, 0, 0, LabS.Width, LabS.Height)
        Dim black As New SolidBrush(Color.Black)
        Dim blue As New SolidBrush(Color.FromArgb(0, 51, 153))
        g.DrawString(名字, New Font("Segoe UI", 9), black, 31, 9)
        g.DrawString(名字 + " has stopped working", New Font("Segoe UI", 12), blue, 58, 43)
        If Not IsNothing(图片) Then g.DrawImage(图片, 20, 50, 32, 32)
    End Sub

    Private Sub LabS_Paint(sender As Object, e As PaintEventArgs) Handles LabS.Paint
        绘制()
        If Not IsNothing(输出) Then e.Graphics.DrawImage(输出, 0, 0, LabS.Width, LabS.Height)
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged
        名字 = TxtName.Text
        设置.保存元素("NoRESname", TxtName.Text)
        Refresh()
    End Sub

    Private Sub TxtICO_TextChanged(sender As Object, e As EventArgs) Handles TxtICO.TextChanged
        Dim s As String = TxtICO.Text
        设置.保存元素("NoRESico", s)
        If s.Length < 5 Then Exit Sub
        If Not 文件可用(s) Then Exit Sub
        Dim i As String = 文件后缀(s)
        If 是当中一个(i, "jpg", "png") Then
            图片 = 读文件为图片(s)
        Else
            图片 = Nothing
            TxtICO.Text = ""
        End If
        Refresh()
    End Sub

    Private Sub ButClipBoard_Click(sender As Object, e As EventArgs) Handles ButClipBoard.Click
        If IsNothing(Clipboard.GetImage) Then Exit Sub
        图片 = Clipboard.GetImage
        图标 = Nothing
        Refresh()
    End Sub

    Private Sub ButOut_Click(sender As Object, e As EventArgs) Handles ButOut.Click
        If Not IsNothing(输出) Then Clipboard.SetImage(输出)
    End Sub

End Class