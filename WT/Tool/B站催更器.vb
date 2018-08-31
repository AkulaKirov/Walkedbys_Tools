Public Class B站催更器

    Private Sub TxtID_TextChanged(sender As Object, e As EventArgs) Handles TxtID.TextChanged
        TxtID.Text = 只要数字(TxtID.Text)
        ButTell.Enabled = (TxtID.TextLength > 0 AndAlso CoolDown.Enabled = False)
    End Sub

    Private Sub B站催更器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtID.Text = 设置.元素("bilibiliUID")
        LabOut.Text = ""
    End Sub

    Private Sub B站催更器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.元素("bilibiliUID") = TxtID.Text
    End Sub

    Private Sub ButTell_Click(sender As Object, e As EventArgs) Handles ButTell.Click
        ButTell.Enabled = False
        ButTell.Text = "冷却中"
        Dim id As String = TxtID.Text
        Dim h As New 简易HTTP("https://space.bilibili.com/ajax/member/getSubmitVideos?mid=" + id + "&page=1&pagesize=25&order=pubdate")
        h.Referer = "https://space.bilibili.com" + 括(id, "//")
        h.超时 = 4
        Dim s As String = h.获得回应, out As String = ""
        If s.StartsWith("{""status"":true,""data"":") Then
            If 包含(s, "tlist"":[],""vlist"":[],""count"":0") Then
                out = "同志，你没视频。"
            Else
                s = 去除(s, vbCr, vbLf, vbQuote)
                s = 提取(s, "author", "length")
                out = "你是：" + 提取(s, ":", ",") + vbCrLf + "距离你的最后一个视频已经过去了：" + 时间差(UNIX时间恢复(Val(提取(s, "created:", ","))), Now, True)
            End If
        Else
            out = "获得网站信息失败，错误信息：" + vbCrLf + s
        End If
        LabOut.Text = out
        CoolDown.Enabled = True
    End Sub

    Private Sub CoolDown_Tick(sender As Object, e As EventArgs) Handles CoolDown.Tick
        ButTell.Enabled = True
        ButTell.Text = "告诉我残酷的现实"
        CoolDown.Enabled = False
    End Sub

End Class