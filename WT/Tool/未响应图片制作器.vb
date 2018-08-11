
Public Class 未响应图片制作器

    Dim 名字 As String = ""
    Dim 图片 As Image = Nothing
    Dim 图标 As Icon = Nothing
    Dim 输出 As Image = Nothing

    Private Sub 未响应图片制作器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        文本框拖入文件(TxtICO)
        TxtName.Text = 读取("NoRESname")
        TxtICO.Text = 读取("NoRESico")
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
        If Not IsNothing(图标) Then g.DrawIcon(图标, 20, 50)
    End Sub

    Private Sub LabS_Paint(sender As Object, e As PaintEventArgs) Handles LabS.Paint
        绘制()
        If Not IsNothing(输出) Then e.Graphics.DrawImage(输出, 0, 0, LabS.Width, LabS.Height)
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged
        名字 = TxtName.Text
        保存("NoRESname", TxtName.Text)
        Refresh()
    End Sub

    Private Sub TxtICO_TextChanged(sender As Object, e As EventArgs) Handles TxtICO.TextChanged
        Dim s As String = TxtICO.Text
        保存("NoRESico", s)
        If s.Length < 5 Then Exit Sub
        Dim f As New 文件(s)
        If Not (f.存在 AndAlso f.可用) Then Exit Sub
        Dim i As String = f.后缀
        If 是当中一个(i, "jpg", "png", "bmp") Then
            图片 = f.转图片
            图标 = Nothing
        ElseIf i = "ico" Then
            图标 = New Icon(s, 30, 30)
            图片 = Nothing
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