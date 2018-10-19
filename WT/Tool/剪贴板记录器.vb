
Public Class 剪贴板记录器

    Dim LastTxt As String = ""
    Dim LastPic As Image = Nothing

    Public Sub 剪贴板记录器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        文本框拖入文件夹(TxtPic)
        文本框拖入文件(TxtText)
        TxtPic.Text = 设置.字符串("CBpic")
        TxtText.Text = 设置.字符串("CBtext")
        ListOption.SelectedIndex = Val(设置.字符串("CBwhen"))
    End Sub

    Private Sub 剪贴板记录器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.字符串("CBpic") = TxtPic.Text
        设置.字符串("CBtext") = TxtText.Text
        设置.字符串("CBwhen") = ListOption.SelectedIndex.ToString
    End Sub

    Private Sub Watching_Tick(sender As Object, e As EventArgs) Handles Watching.Tick
        If 后台定时器启用(ListOption) Then
            Dim s As String = TxtText.Text, m As String
            If s.Length > 0 AndAlso 文件可用(s) Then
                m = 剪贴板.文本
                If Not IsNothing(m) Then
                    If m <> LastTxt Then
                        File.AppendAllText(s, vbCrLf + m)
                        LastTxt = m
                    End If
                End If
            End If
            s = TxtPic.Text
            If s.Length > 0 AndAlso 文件夹存在(s) Then
                Dim i As Image = 剪贴板.图片
                If Not IsNothing(i) Then
                    If 图片一样(LastPic, i, True) = False Then
                        m = s + UNIX时间(Now).ToString + ".png"
                        If 文件存在(m) = False Then i.Save(m)
                        LastPic = i
                    End If
                End If
            End If
        End If
    End Sub

    Public Function 图片一样(i As Bitmap, j As Bitmap, Optional 快速 As Boolean = False) As Boolean
        If (IsNothing(i) AndAlso IsNothing(j)) Then Return True
        If IsNothing(i) OrElse IsNothing(j) OrElse i.Size <> j.Size Then Return False
        If i.Equals(j) Then Return True
        Dim a As Integer = i.Width - 1, b As Integer = i.Height - 1
        If 快速 Then
            For x As Integer = 0 To 8
                a = 随机.整数(0, a)
                b = 随机.整数(0, b)
                If i.GetPixel(a, b) <> j.GetPixel(a, b) Then
                    Return False
                End If
            Next
        Else
            For x As Integer = 0 To a
                For y As Integer = 0 To b
                    If i.GetPixel(x, y) <> j.GetPixel(x, y) Then
                        Return False
                    End If
                Next
            Next
        End If
        Return True
    End Function

End Class