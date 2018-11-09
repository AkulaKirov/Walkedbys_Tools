Public Class 微博批量删除

    Dim uid As String, NickName As String
    Dim w As 工作

    Private Sub 微博批量删除_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        w = New 工作(Pn, False)
        TxtCookie.Text = 设置.字符串("WeiboCookie")
        列表控件选中项(ListWhite, 设置.数字("WeiboWhitelistMode"))
        TxtWhiteList.Text = 设置.字符串("WeiboWhitelist")
        TxtLink1.Text = 设置.字符串("WeiboLink1")
        TxtLink2.Text = 设置.字符串("WeiboLink2")
    End Sub

    Private Sub 微博批量删除_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.数字("WeiboWhitelistMode") = ListWhite.SelectedIndex
        设置.字符串("WeiboCookie") = TxtCookie.Text
        设置.字符串("WeiboWhitelist") = TxtWhiteList.Text
        设置.字符串("WeiboLink2") = TxtLink1.Text
        设置.字符串("WeiboLink1") = TxtLink2.Text
    End Sub

    Private Sub TxtCookie_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCookie.KeyDown
        If e.KeyCode = Keys.Back Then TxtCookie.Text = ""
    End Sub

    Private Sub TxtCookie_TextChanged(sender As Object, e As EventArgs) Handles TxtCookie.TextChanged
        ButGo.Enabled = TxtCookie.TextLength > 20
    End Sub

    Private Sub ButGo_Click() Handles ButGo.Click
        ListIDs.Items.Clear()
        w.开始(Sub()
                 Dim ck As String = TxtCookie.Text
                 Dim h As 简易HTTP, s As String, cool As Integer = 2000
                 h = New 简易HTTP("https://weibo.com/me")
                 h.Origin = "https://weibo.com/"
                 h.Cookie = ck
                 h.超时 = 4
                 s = h.获取回应
                 If s.Length < 100 Then
                     w.日志("失败：" & s)
                 Else
                     If s.Length > 1000 AndAlso 全部包含(s, "$CONFIG['uid']='", "$CONFIG['nick']='") Then
                         w.日志("登录成功！")
                         NickName = 提取(s, "$CONFIG['nick']='", "';")
                         uid = 提取(s, "$CONFIG['uid']='", "';")
                         w.日志("UID：" & uid)
                         w.日志("昵称：" & NickName)
                     Else
                         w.日志("登录失败！Cookie可能已经失效！请去浏览器获取新 Cookie 。返回数据的长度：" & s.Length)
                         w.结束()
                     End If
                 End If
                 Dim 开始 As ULong = 0, 结束 As ULong = 0, 范围 As Boolean = False
                 If TxtLink1.TextLength > 15 AndAlso TxtLink2.TextLength > 15 Then
                     w.日志("开始采集要删除的微博列表。")
                     Thread.Sleep(cool)
                     开始 = 获取微博范围(TxtLink1.Text)
                     Thread.Sleep(cool)
                     结束 = 获取微博范围(TxtLink2.Text)
                     If 开始 = 123456 OrElse 结束 = 123456 Then
                         w.日志("范围有误，该范围内应该没有微博了，请去检查。")
                         w.结束()
                     End If
                     If 开始 >= 3333333333333333 AndAlso 结束 >= 3333333333333333 Then
                         If 开始 = 结束 Then
                             w.日志("微博范围一样，无法继续：" & 开始 & " - " & 结束)
                             w.结束()
                         Else
                             范围 = True
                             If 开始 > 结束 Then 互换(开始, 结束)
                             w.日志("已经查得微博范围：" & 开始 & " - " & 结束)
                             TxtLink1.Text = "https://m.weibo.cn/detail/" & 结束
                             TxtLink2.Text = "https://m.weibo.cn/detail/" & 开始
                         End If
                     End If
                 Else
                     w.日志("链接为空，视作删除全部微博。")
                 End If
                 Dim m As Match, mc As MatchCollection, lastweibo As ULong = 0, t As ULong, s2 As String
                 Dim whitelist As New List(Of String)
                 If TxtWhiteList.TextLength > 0 Then whitelist = 分割(TxtWhiteList.Text, vbCrLf)
                 If 范围 Then lastweibo = 结束
                 Do While True
                     Thread.Sleep(cool)
                     t = 0
                     s = "https://m.weibo.cn/api/container/getIndex?uid=用户&luicode=10000011&lfid=111111用户_-_WEIBO_SECOND_PROFILE_WEIBO&containerid=107603用户"
                     If lastweibo > 3333 Then
                         s += "&since_id=" + lastweibo.ToString
                         w.日志("扫描：" + lastweibo.ToString)
                     End If
                     h = New 简易HTTP(替换(s, "用户", uid))
                     h.Cookie = ck
                     h.超时 = 4
                     h.UA = 浏览器UA.iPhone7
                     s = h.获取回应
                     s = 去除(s, vbCr, vbLf, 引号)
                     If s.StartsWith("{ok:1,data:{") = False OrElse s.Length < 1000 Then
                         w.日志("出错：")
                         w.日志(s)
                         w.结束()
                     End If
                     mc = Regex.Matches(s, uid + "_\-_.*?user:\{id:" + uid)
                     If mc.Count = 0 Then Exit Do
                     For Each m In mc
                         s = m.ToString
                         t = Val(只要数字(提取(s, "_-_", ",scheme:")))
                         s2 = 正则去除(Trim(提取(s, ",text:", ",source:")), "<a .*?>", "</a>", "<span.*?>", "</span>", "<br />", ",textLength:[0-9]*", "<img .*?>")
                         If t > 999 Then
                             s = t.ToString & " " & 左(s2, 10)
                             If 在列表(ListIDs.Items, s) = False AndAlso 关键词筛选(s2, whitelist) Then
                                 If 范围 = False OrElse (t <= 结束 AndAlso t >= 开始) Then
                                     ListIDs.Items.Add(s)
                                 End If
                             End If
                             If 范围 AndAlso (t < 开始 OrElse t > 结束) Then
                                 Exit Do
                             End If
                         End If
                     Next
                     If t < lastweibo OrElse lastweibo < 3333 Then
                         lastweibo = t
                     Else
                         w.日志("应该已经到头了：" & t)
                         Exit Do
                     End If
                 Loop
                 w.日志("采集完成，一共： " & ListIDs.Items.Count & " 条微博。")
                 w.日志("开始一条一条地删除。")
                 Dim mf As 简易FormData, 失败 As Integer = 0
                 t = ListIDs.Items.Count
                 For Each s2 In ListIDs.Items
                     Thread.Sleep(cool)
                     s2 = 左(s2, 16)
                     h = New 简易HTTP("https://weibo.com/aj/mblog/del?ajwvr=6", "POST")
                     h.Cookie = ck
                     h.Referer = "https://weibo.com/u/" + uid
                     h.超时 = 4
                     mf = New 简易FormData
                     mf.添加("mid", s2)
                     h.写入(mf.ToString)
                     s = 去除(h.获取回应, 引号)
                     If s.StartsWith("{code:100000,msg:") Then
                         t -= 1
                         w.日志("成功删除：" & s2 & " ，还剩：" & t)
                     Else
                         w.日志(s2 & " 失败：" & s & " ，还剩：" & t)
                         失败 += 1
                     End If
                 Next
                 If 失败 > 0 Then
                     w.日志("失败的微博：" & 失败 & " 条。")
                     w.日志("删除失败的微博，建议重新进行操作来尝试删除他们。")
                 End If
                 w.结束()
             End Sub)
    End Sub

    Private Sub ButOld_Click(sender As Object, e As EventArgs) Handles ButOld.Click
        TxtLink2.Text = "https://m.weibo.cn/detail/3333333333333333"
    End Sub

    Function 获取微博范围(m As String) As ULong
        Dim n As ULong = 123456
        If m.StartsWith("https://weibo.com/") Then
            Dim h As New 简易HTTP(m), s As String
            h.Cookie = TxtCookie.Text
            s = 去除(h.获取回应, 引号, vbCr, vbLf)
            n = Val(提取(s, "c?do=mblog&act=", " class="))
            If n < 3333333333333333 Then n = 123456
        ElseIf m.StartsWith("https://m.weibo.cn/detail/") Then
            n = Val(左(只要数字(m), 16))
            If n < 3333333333333333 Then n = 123456
        End If
        Return n
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabIDcount.Text = "个数：" & ListIDs.Items.Count
    End Sub

    Private Sub ButHowToCookie_Click(sender As Object, e As EventArgs) Handles ButHowToCookie.Click
        Process.Start("https://github.com/gordonwalkedby/Walkedbys_Tools/wiki/%E5%A6%82%E4%BD%95%E8%8E%B7%E5%8F%96%E5%BE%AE%E5%8D%9A-Cookie")
    End Sub

    Function 关键词筛选(s As String, f As List(Of String)) As Boolean
        Dim n As Integer = ListWhite.SelectedIndex
        If f.Count < 1 OrElse n = 2 Then Return True
        Dim b As Boolean = False
        s = s.ToLower
        For Each i As String In f
            If 包含(s, i.ToLower) Then
                b = True
                Exit For
            End If
        Next
        Return IIf(n = 0, b, Not b)
    End Function

End Class