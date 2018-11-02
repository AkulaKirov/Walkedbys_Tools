Public Class 微博批量删除

    Dim Th As Thread
    Dim StopIt As String = "停止", DoIt As String = "开始"
    Dim uid As String, NickName As String
    Delegate Sub 委托停止()

    Private Sub 微博批量删除_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        结束工作()
    End Sub

    Private Sub TxtCookie_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCookie.KeyDown
        If e.KeyCode = Keys.Back Then TxtCookie.Text = ""
    End Sub

    Private Sub TxtCookie_TextChanged(sender As Object, e As EventArgs) Handles TxtCookie.TextChanged
        ButGo.Enabled = TxtCookie.TextLength > 20
    End Sub

    Private Sub TxtLink2_TextChanged(sender As Object, e As EventArgs) Handles TxtLink2.TextChanged

    End Sub

    Sub Log(s As String)
        With TxtLog
            If .TextLength > 0 Then .Text += vbCrLf
            .Text += s
            .SelectionStart = .TextLength
            .ScrollToCaret()
        End With
    End Sub

    Private Sub ButGo_Click() Handles ButGo.Click
        If ButGo.Text = StopIt Then
            ButGo.Text = DoIt
            中断线程(Th)
            Pn.Enabled = True
            Log("工作结束：" + Now.ToLongTimeString)
        Else
            Pn.Enabled = False
            TxtLog.Text = ""
            ButGo.Text = StopIt
            Th = New Thread(Sub()
                                Log("工作开始：" + Now.ToShortTimeString)
                                Dim ck As String = TxtCookie.Text
                                Dim h As 简易HTTP, s As String
                                h = New 简易HTTP("https://weibo.com/me")
                                h.Origin = "https://weibo.com/"
                                h.Cookie = ck
                                s = h.获得回应
                                If s.Length < 100 Then
                                    Log("失败：" & s)
                                Else
                                    If s.Length > 1000 AndAlso 全部包含(s, "$CONFIG['uid']='", "$CONFIG['nick']='") Then
                                        Log("登录成功！")
                                        NickName = 提取(s, "$CONFIG['nick']='", "';")
                                        uid = 提取(s, "$CONFIG['uid']='", "';")
                                        Log("UID：" & uid)
                                        Log("昵称：" & NickName)
                                    Else
                                        Log("登录失败！Cookie可能已经失效！返回数据的长度：" & s.Length)
                                        结束工作()
                                    End If
                                End If
                                Dim 开始 As ULong = 0, 结束 As ULong = 0, 范围 As Boolean = False
                                If TxtLink1.TextLength > 15 AndAlso TxtLink2.TextLength > 15 Then
                                    开始 = 获得微博范围(TxtLink1.Text)
                                    结束 = 获得微博范围(TxtLink2.Text)
                                    If 开始 > 3333333333333333 AndAlso 结束 > 3333333333333333 Then
                                        If 开始 = 结束 Then
                                            Log("微博范围一样：" & 开始 & " - " & 结束)
                                            结束工作()
                                        Else
                                            范围 = True
                                            If 开始 > 结束 Then 互换(开始, 结束)
                                            Log("已经查得微博范围：" & 开始 & " - " & 结束)
                                        End If
                                    End If
                                Else
                                    Log("链接为空，删除全部微博。")
                                End If
                                Dim f As New List(Of String), m As Match, mc As MatchCollection, lastweibo As String = "", t As ULong, added As Integer = 0
                                If 范围 Then lastweibo = 结束.ToString
                                Log("开始采集要删除的微博列表：")
                                Do While True
                                    Thread.Sleep(2 * 1000)
                                    t = 0
                                    s = "https://m.weibo.cn/api/container/getIndex?uid=用户&luicode=10000011&lfid=111111用户_-_WEIBO_SECOND_PROFILE_WEIBO&containerid=107603用户"
                                    If lastweibo.Length > 0 Then s += "&since_id=" + lastweibo
                                    h = New 简易HTTP(替换(s, "用户", uid))
                                    h.Cookie = ck
                                    h.UA = 浏览器UA.iPhone7
                                    s = 去除(h.获得回应, vbCr, vbLf, 引号)
                                    If s.StartsWith("{ok:1,data:{") = False OrElse s.Length < 1000 Then
                                        Log("出错：")
                                        Log(s)
                                        结束工作()
                                    End If
                                    mc = Regex.Matches(s, ",itemid:[0-9]{10,}_-_[0-9]{16},")
                                    added = 0
                                    For Each m In mc
                                        t = Val(只要数字(右(m.ToString, 17)))
                                        If 在列表(f, s) = False AndAlso t <= 结束 AndAlso t >= 开始 Then
                                            f.Add(t.ToString)
                                            added += 1
                                        End If
                                        If t < 开始 Then
                                            Exit Do
                                        End If
                                    Next
                                    Log("新收集到：" & added & "条，目前一共：" & f.Count)
                                    If added = 0 Then Exit Do
                                    If t > 0 Then
                                        lastweibo = t
                                    End If
                                Loop
                                Log("采集完成，一共： " & f.Count & " 条微博。")
                                结束工作()
                            End Sub)
            Th.Start()
        End If
    End Sub

    Function 获得微博范围(m As String) As ULong
        If m.StartsWith("https://weibo.com/") Then
            Dim h As New 简易HTTP(m), s As String
            h.Cookie = TxtCookie.Text
            s = 去除(h.获得回应, 引号, vbCr, vbLf)
            Return Val(提取(s, "c?do=mblog&act=", " class="))
        ElseIf m.StartsWith("https://m.weibo.cn/detail/") Then
            Return Val(左(只要数字(m), 16))
        End If
        Return 0
    End Function

    Sub 结束工作()
        If ButGo.Text = StopIt Then
            Dim f As New 委托停止(Sub()
                                  ButGo.PerformClick()
                              End Sub)
            Invoke(f)
        End If
    End Sub

End Class