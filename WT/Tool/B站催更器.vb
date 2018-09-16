
Public Class B站催更器

    Dim Th As Thread

    Private Sub B站催更器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtID.Text = 设置.元素("bilibiliUID")
        LabOut.Text = ""
        If 设置.读取真假("CheckBilibiliAtStart") Then
            CheckAuto.Checked = True
            If ButTell.Enabled Then
                ButTell_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub TxtID_TextChanged(sender As Object, e As EventArgs) Handles TxtID.TextChanged
        TxtID.Text = 只要数字(TxtID.Text)
        ButTell.Enabled = (TxtID.TextLength > 0 AndAlso CoolDown.Enabled = False)
    End Sub

    Private Sub B站催更器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.元素("bilibiliUID") = TxtID.Text
        中断线程(Th)
    End Sub

    Private Sub ButTell_Click(sender As Object, e As EventArgs) Handles ButTell.Click
        ButTell.Enabled = False
        ButTell.Text = "冷却中"
        LabOut.Text = ""
        CoolDown.Enabled = True
        Th = New Thread(Sub()
                            Dim id As String = TxtID.Text
                            Dim h As New 简易HTTP("https://space.bilibili.com/ajax/member/getSubmitVideos?mid=" + id + "&page=1&pagesize=25&order=pubdate")
                            h.Referer = "https://space.bilibili.com" + 括(id, "//")
                            h.超时 = 5
                            Dim s As String = h.获得回应, out As String = ""
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
                                        Tag = "你今天已经更新过B站啦~"
                                    End If
                                End If
                            Else
                                out = "获得网站信息失败，错误信息：" + vbCrLf + s
                            End If
                            LabOut.Text = out
                        End Sub)
        Th.Start()
    End Sub

    Private Sub CoolDown_Tick(sender As Object, e As EventArgs) Handles CoolDown.Tick
        ButTell.Enabled = True
        ButTell.Text = "告诉我残酷的现实"
        CoolDown.Enabled = False
    End Sub

    Private Sub CheckAuto_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAuto.CheckedChanged
        设置.元素("CheckBilibiliAtStart") = CheckAuto.Checked.ToString
    End Sub

End Class