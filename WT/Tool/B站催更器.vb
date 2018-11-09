
Public Class B站催更器

    Dim w As 工作

    Private Sub B站催更器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        w = New 工作(Pn, False)
        TxtID.Text = 设置.字符串("bilibiliUID")
        CheckAuto.Checked = 设置.布林("CheckBilibiliAtStart")
        If CheckAuto.Checked Then
            ButTell.PerformClick()
        End If
        LabOut.Text = ""
    End Sub

    Private Sub B站催更器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.布林("CheckBilibiliAtStart") = CheckAuto.Checked
        设置.字符串("bilibiliUID") = TxtID.Text
    End Sub

    Private Sub TxtID_TextChanged(sender As Object, e As EventArgs) Handles TxtID.TextChanged
        TxtID.Text = 只要数字(TxtID.Text)
        ButTell.Enabled = TxtID.TextLength > 0
    End Sub

    Private Sub ButTell_Click(sender As Object, e As EventArgs) Handles ButTell.Click
        LabOut.Text = ""
        w.开始(Sub()
                 Dim id As String = 设置.字符串("bilibiliUID")
                 Dim h As New 简易HTTP("https://space.bilibili.com/ajax/member/getSubmitVideos?mid=" + id + "&page=1&pagesize=25&order=pubdate")
                 h.Referer = "https://space.bilibili.com" + 括(id, "//")
                 h.超时 = 3
                 Dim s As String = h.获取回应, out As String = ""
                 If s.StartsWith("{""status"":true,""data"":") Then
                     If 包含(s, "tlist"":[],""vlist"":[],""count"":0") Then
                         out = "同志，你没视频。"
                     Else
                         s = 去除(s, vbCr, vbLf, 引号)
                         s = 提取(s, "author", "length")
                         id = 时间差(UNIX时间恢复(Val(提取(s, "created:", ","))), Now, False)
                         out = "你是：" + 提取(s, ":", ",") + vbCrLf + "距离你上一次发视频已经过去了：" + id
                         If id <> "不到一天" Then
                             Tag = "你已经" + id + "没更B站了！"
                         Else
                             Tag = "你最近已经更新过B站啦~"
                         End If
                     End If
                 Else
                     out = "获取网站信息失败，错误信息：" + vbCrLf + s
                 End If
                 LabOut.Text = out
                 w.结束()
             End Sub)
    End Sub

End Class