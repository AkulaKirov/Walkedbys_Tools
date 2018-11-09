
Public Class 创意工坊篡改器

    Private Sub 创意工坊篡改器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SteamCookie.呼起按钮(ButGetSteamCookie)
        Dim i As Integer = 设置.数字("WorkshopLanguage")
        If i >= ListLanguage.Items.Count Then i = 0
        ListLanguage.SelectedIndex = i
        TxtTitle.Text = 设置.字符串("WorkshopTitle")
        TxtDes.Text = 设置.字符串("WorkshopDes")
        TxtID.Text = 设置.字符串("WorkshopID")
    End Sub

    Private Sub 创意工坊篡改器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.字符串("WorkshopTitle") = TxtTitle.Text
        设置.字符串("WorkshopDes") = TxtDes.Text
        设置.字符串("WorkshopLanguage") = ListLanguage.SelectedIndex.ToString
        设置.字符串("WorkshopID") = TxtID.Text
    End Sub

    Private Sub TxtID_TextChanged(sender As Object, e As EventArgs) Handles TxtID.TextChanged
        TxtID.Text = 只要数字(TxtID.Text)
        ButGo.Enabled = TxtID.TextLength > 3
        ButGoBrowser.Enabled = ButGo.Enabled
    End Sub

    Private Sub ButGo_Click(sender As Object, e As EventArgs) Handles ButGo.Click
        TxtLog.Text = ""
        If SteamCookie.填写正确 = False Then
            日志("你的 Steam Cookie 填写不正确，请去检查。")
        Else
            Dim h As New 简易HTTP("https://steamcommunity.com/sharedfiles/itemedittext/", "POST")
            Dim id As String = TxtID.Text
            h.内容Type = "application/x-www-form-urlencoded"
            h.Cookie = SteamCookie.完整Cookie
            h.Origin = "https://steamcommunity.com"
            h.Referer = "https://steamcommunity.com/sharedfiles/itemedittext/?id=" + id
            h.超时 = 5
            Dim n As New 简易FormData
            n.添加("id", id)
            n.添加("sessionid", SteamCookie.SessionID)
            n.添加("language", 只要数字(ListLanguage.SelectedItem.ToString))
            n.添加("title", TxtTitle.Text)
            n.添加("description", TxtDes.Text)
            h.写入(n.ToString)
            Dim s As String = h.获取回应, i As String = ""
            If s.Length < 1000 Then
                i = "网络出错：" + vbCrLf + s
            Else
                If 包含(s, "g_steamID = false;") Then
                    i = "Cookie 已经失效，登录失败。"
                Else
                    If 全部包含(s, "<div id=""BG_bottom"">", "<div id=""message"">", "<p class=""returnLink"">") Then
                        i = "Steam 返回称：此物品不存在。"
                    ElseIf 包含(s, "<div id=""error_display"" class=""workshop_paymentinfo_validation_error"">") Then
                        i = "Steam 返回称：修改已经成功。"
                    Else
                        i = "情况不明，你填写的物品ID的主人可能不是你，建议去浏览器里直接检查一下情况。"
                    End If
                End If
            End If
            日志(i)
        End If
    End Sub

    Private Sub ButGoBrowser_Click(sender As Object, e As EventArgs) Handles ButGoBrowser.Click
        Process.Start("https://steamcommunity.com/sharedfiles/filedetails/?id=" + TxtID.Text)
    End Sub

End Class
