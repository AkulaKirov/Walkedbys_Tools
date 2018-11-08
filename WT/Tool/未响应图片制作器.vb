
Public Class 未响应图片制作器

    Dim 图片 As Image = Nothing
    Dim 输出 As Image = Nothing

    Private Sub 未响应图片制作器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtName.Text = 设置.字符串("NoRESname")
        ListStyle.SelectedIndex = 设置.数字("NoRESstyle")
    End Sub

    Private Sub 未响应图片制作器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.字符串("NoRESname") = TxtName.Text
        设置.字符串("NoRESstyle") = ListStyle.SelectedIndex
    End Sub

    Private Sub 未响应图片制作器_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim b As Image = My.Resources.win7无响应, 名字 As String = Trim(TxtName.Text)
        Select Case ListStyle.SelectedIndex
            Case 1
                b = My.Resources.win10未响应
            Case 2
                b = My.Resources.xp未响应
        End Select
        输出 = New Bitmap(b.Width, b.Height)
        Dim g As Graphics = Graphics.FromImage(输出)
        g.Clear(Color.White)
        g.DrawImage(b, 0, 0, b.Width, b.Height)
        Dim d As Single = 系统DPI()
        Select Case ListStyle.SelectedIndex
            Case 0
                g.DrawString(名字, New Font("Segoe UI", 9 / d), New SolidBrush(Color.Black), 31, 9)
                g.DrawString(名字 + " has stopped working", New Font("Segoe UI", 12 / d), New SolidBrush(Color.FromArgb(0, 51, 153)), 58, 43)
                If Not IsNothing(图片) Then g.DrawImage(图片, 20, 50, 32, 32)
            Case 1
                g.DrawString(名字, New Font("Segoe UI", 9 / d), New SolidBrush(Color.Black), 30, 9)
                g.DrawString(名字 + " 未响应", New Font("Segoe UI", 12 / d), New SolidBrush(Color.FromArgb(0, 51, 153)), 12, 43)
            Case 2
                g.DrawString(名字, New Font("System", 9 / d, Drawing.FontStyle.Bold), New SolidBrush(Color.White), 80, 8)
                If Not IsNothing(图片) Then
                    g.DrawImage(图片, 16, 43, 28, 28)
                    b = My.Resources.xp未响应2
                    g.DrawImage(b, 13, 60)
                End If
        End Select
        If Not IsNothing(输出) Then e.Graphics.DrawImage(输出, 12 * d, 81 * d, 输出.Width, 输出.Height)
    End Sub

    Private Sub ButClipBoard_Click(sender As Object, e As EventArgs) Handles ButClipBoard.Click
        If IsNothing(剪贴板.图片) Then
            图片 = Nothing
        Else
            图片 = 剪贴板.图片
        End If
        Refresh()
    End Sub

    Private Sub ButOut_Click(sender As Object, e As EventArgs) Handles ButOut.Click
        If Not IsNothing(输出) Then 剪贴板.图片 = 输出
    End Sub

    Private Sub ListStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListStyle.SelectedIndexChanged, TxtName.TextChanged
        Refresh()
    End Sub

End Class