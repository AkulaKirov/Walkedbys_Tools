
Public Class 创意工坊订阅列表导出

    Dim TH As Thread

    Private Sub 创意工坊订阅列表导出_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        填写steamCookie(GBsteamCookie, Sub()
                                         Pn.Visible = GBsteamCookie.Tag
                                     End Sub)
        TxtLink.Text = 设置.元素("SteamWorkshopURL")
    End Sub

    Private Sub 创意工坊订阅列表导出_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.元素("SteamWorkshopURL") = TxtLink.Text
        中断线程(TH)
        GBsteamCookie.Enabled = True
        Pn.Enabled = True
        ButStart.Text = "开始生成列表"
    End Sub

    Private Sub TxtLink_TextChanged(sender As Object, e As EventArgs) Handles TxtLink.TextChanged
        ButStart.Enabled = False
        Dim s As String = Trim(TxtLink.Text)
        If s.Length < 45 Then Exit Sub
        ButStart.Enabled = s.StartsWith("https://steamcommunity.com/") AndAlso 包含(s, "sharedfiles/filedetails/?id=", "/myworkshopfiles")
    End Sub

    Private Sub ButStart_Click(sender As Object, e As EventArgs) Handles ButStart.Click
        GBsteamCookie.Enabled = False
        Pn.Enabled = False
        ButStart.Text = "工作中"
        TH = New Thread(Sub()
                            Dim url As String = Trim(TxtLink.Text)
                            TxtOut.Text = ""
                            Dim once As Boolean = 包含(url, "sharedfiles/filedetails/?id=")
                            url = 正则去除(url, "&p=[0-9]*", "&numperpage=[0-9]*")
                            If Not 包含(url, "/?") Then
                                url += IIf(url.EndsWith("/"), "?", "/?")
                            End If
                            If once = False Then url += "&numperpage=30"
                            Dim p As Integer = 1, out As String = "", s As String, m As Match, mc As MatchCollection, n As String, c As Integer = 0, name As String
                            Do While True
                                Dim h As New 简易HTTP(url + IIf(once, "", "&p=" + p.ToString))
                                h.Cookie = 输出steamCookie()
                                s = h.获得回应(False)
                                If s.Length < 1000 Then
                                    out += "出错：" + vbCrLf + s
                                    Exit Do
                                ElseIf 包含(s, "g_steamID = false;") Then
                                    写文件("e:\f.html", s)
                                    out += "登录失败，cookie可能已经失效。"
                                    Exit Do
                                End If
                                s = s.Replace("&amp;", "&")
                                mc = Regex.Matches(s, "SharedFileBindMouseHover\( ([\s\S]*?)\);")
                                If mc.Count > 0 Then
                                    For Each m In mc
                                        n = Regex.Unescape(去除(m.ToString, 引号, vbCr, vbLf))
                                        name = 提取(n, "title:", ",description:")
                                        If name.Length > 0 Then
                                            out += name + " " + 括(提取(n, "id:", ",")) + vbCrLf
                                            c += 1
                                        End If
                                    Next
                                End If
                                If mc.Count < 30 OrElse once Then
                                    Exit Do
                                End If
                                p += 1
                            Loop
                            TxtOut.Text = "工作结束，共计：" + c.ToString + vbCrLf + out
                            ButStart.Text = "开始生成列表"
                            GBsteamCookie.Enabled = True
                            Pn.Enabled = True
                        End Sub)
        TH.Start()
    End Sub

End Class