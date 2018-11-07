
Public Class 创意工坊合集物品批量添加

    Private Sub 创意工坊合集物品批量添加_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SteamCookie.呼起按钮(ButGetSteamCookie)
        TxtID.Text = 设置.字符串("WorkshopCollectionID")
        TxtInput.Text = 设置.字符串("WorkshopCollectionInput")
    End Sub

    Private Sub 创意工坊合集物品批量添加_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.字符串("WorkshopCollectionID") = TxtID.Text
        设置.字符串("WorkshopCollectionInput") = TxtInput.Text
    End Sub

    Private Sub TxtID_TextChanged(sender As Object, e As EventArgs) Handles TxtID.TextChanged, TxtInput.TextChanged
        TxtID.Text = 只要数字(TxtID.Text)
    End Sub

    Private Sub ButStart_Click(sender As Object, e As EventArgs) Handles ButStart.Click
        开始工作(Pn, True, Sub()
                           Dim h As 简易HTTP, id As String = TxtID.Text, n As String = "", g As Integer = 0, g2 As New List(Of String)
                           Dim mc As MatchCollection = Regex.Matches(TxtInput.Text, "\([0-9]{3,}\)")
                           If mc.Count > 0 Then
                               For Each m As Match In mc
                                   n = 只要数字(m.ToString)
                                   h = New 简易HTTP("https://steamcommunity.com/sharedfiles/addchild", "POST")
                                   h.Origin = "https://steamcommunity.com"
                                   h.Host = "steamcommunity.com"
                                   h.Referer = "https://steamcommunity.com/sharedfiles/managecollection/?id=" + id + "&activeSection=MyItems"
                                   h.Cookie = SteamCookie.完整Cookie
                                   Dim f As New 简易FormData
                                   f.添加("id", id)
                                   f.添加("sessionid", SteamCookie.SessionID)
                                   f.添加("childid", n)
                                   f.添加("activeSection", "MyItems")
                                   h.写入(f.ToString)
                                   Dim s As String = h.获取回应(False)
                                   If s.Length < 1000 Then
                                       日志("网络出错，详情：" + vbCrLf + s)
                                       结束工作()
                                   Else
                                       If 包含(s, "g_steamID = false;") Then
                                           日志("Cookie 已经失效，登录失败。")
                                           结束工作()
                                       End If
                                   End If
                                   s = 去除(s, 引号)
                                   If 包含(s, "SharedFileBindMouseHover( sharedfile_" + n + ", true, {id:") Then
                                       g += 1
                                       日志("导入成功：" + n)
                                   Else
                                       g2.Add(n)
                                       日志("导入失败：" + n)
                                   End If
                               Next
                               日志("一共导入成功：" + g.ToString + "个，失败：" + g2.Count.ToString + "个。")
                               If g2.Count > 0 Then
                                   日志("失败物品列表：")
                                   For Each n In g2
                                       日志(括(n))
                                   Next
                               End If
                           Else
                               日志("没有发现任何要批量加入的物品数据。")
                           End If
                           结束工作()
                       End Sub)
    End Sub

End Class