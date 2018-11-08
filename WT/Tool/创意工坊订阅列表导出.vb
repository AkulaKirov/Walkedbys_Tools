
Public Class 创意工坊订阅列表导出

    Private Sub 创意工坊订阅列表导出_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SteamCookie.呼起按钮(ButGetSteamCookie)
        TxtLink.Text = 设置.字符串("SteamWorkshopURL")
        TxtStart.Value = 设置.数字("SteamWorkshopGetStart", 1)
        TxtMax.Value = 设置.数字("SteamWorkshopGetMax", 99)
    End Sub

    Private Sub 创意工坊订阅列表导出_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.字符串("SteamWorkshopURL") = TxtLink.Text
        设置.字符串("SteamWorkshopGetStart") = TxtStart.Value.ToString
        设置.字符串("SteamWorkshopGetMax") = TxtMax.Value.ToString
    End Sub

    Private Sub TxtLink_TextChanged(sender As Object, e As EventArgs) Handles TxtLink.TextChanged
        ButStart.Enabled = False
        Dim s As String = Trim(TxtLink.Text)
        If s.Length < 45 Then Exit Sub
        s = s.Replace("http://", "https://")
        ButStart.Enabled = s.StartsWith("https://steamcommunity.com/") AndAlso 包含(s, "sharedfiles/filedetails/?id=", "/myworkshopfiles")
    End Sub

    Private Sub ButStart_Click(sender As Object, e As EventArgs) Handles ButStart.Click
        开始工作(Pn, True, Sub()
                           Dim url As String = Trim(TxtLink.Text)
                           Dim once As Boolean = 包含(url, "sharedfiles/filedetails/?id=")
                           url = 正则去除(url, "&p=[0-9]*", "&numperpage=[0-9]*")
                           If Not 包含(url, "/?") Then
                               url += IIf(url.EndsWith("/"), "?", "/?")
                           End If
                           If once = False Then url += "&numperpage=30"
                           Dim p As Integer, s As String, m As Match, mc As MatchCollection, n As String, c As Integer = 0, name As String
                           For p = TxtStart.Value To TxtStart.Value + TxtMax.Value
                               Dim h As New 简易HTTP(url + IIf(once, "", "&p=" + p.ToString))
                               h.Cookie = SteamCookie.完整Cookie
                               s = h.获取回应()
                               If s.Length < 1000 Then
                                   日志("出错：" + vbCrLf + s)
                                   结束工作()
                               ElseIf 包含(s, "g_steamID = false;") Then
                                   日志("登录失败，cookie可能已经失效。")
                                   结束工作()
                               End If
                               mc = Regex.Matches(s, "SharedFileBindMouseHover\( ([\s\S]*?)\);")
                               If mc.Count > 0 Then
                                   For Each m In mc
                                       n = Regex.Unescape(去除(m.ToString, 引号, vbCr, vbLf))
                                       name = 提取(n, "title:", ",description:")
                                       If name.Length > 0 Then
                                           日志(name + " " + 括(提取(n, "id:", ",")))
                                           c += 1
                                       End If
                                   Next
                               End If
                               If mc.Count < 10 OrElse once Then
                                   Exit For
                               End If
                           Next
                           日志("共计：" + c.ToString)
                           结束工作()
                       End Sub)
    End Sub

End Class