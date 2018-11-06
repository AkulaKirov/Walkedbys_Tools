Public Class Steam批量好友留言

    Dim 开始时间 As Date, th As Thread, 回收列表 As New List(Of String), 失败列表 As New List(Of String), 冷却时间 As Integer = 5, 失败文本 As String
    Delegate Sub 委托结束工作()
    Dim QT As String = "[]"

    Private Sub Steam批量好友留言_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        填写steamCookie(GBsteamCookie, Pn)
        文字转列表(ListFriends.Items, 设置.字符串("SteamFriendsList"))
        TxtSay.Text = 设置.字符串("SteamFriendSayWhat")
        TxtSay_TextChanged(Nothing, Nothing)
        TxtWork.Text = 设置.字符串("SteamFriendSayWho")
    End Sub

    Private Sub Steam批量好友留言_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.字符串("SteamFriendSayWhat") = TxtSay.Text
        设置.字符串("SteamFriendSayWho") = TxtWork.Text
        结束工作()
    End Sub

    Private Sub ButGetFriends_Click(sender As Object, e As EventArgs) Handles ButGetFriends.Click
        ListFriends.Items.Clear()
        TxtLOG.Text = ""
        Dim h As New 简易HTTP("https://steamcommunity.com/my/friends/")
        h.Cookie = 获取steamCookie()
        h.超时 = 5
        Dim s As String = 去除(h.获取回应, 引号, vbCr, vbLf)
        If s.Length < 3000 Then
            LOG("获得好友列表失败！" + vbCrLf + s)
        ElseIf 包含(s, "g_steamID = false;") Then
            LOG("获得好友列表失败！" + vbCrLf + "cookie 看起来已经过期了，登录失败。")
        Else
            Dim m As Match, n As String
            For Each m In Regex.Matches(s, "data-search=.*?data-steamid=765611[0-9]{11}")
                s = m.ToString
                n = Trim(提取(s, "data-search=", ";")) + " " + 括("765611" + 提取(s, "data-steamid=765611"), QT)
                If n.Length > 15 Then
                    ListFriends.Items.Add(n)
                End If
            Next
        End If
        设置.字符串("SteamFriendsList") = 列表转文字(ListFriends.Items)
    End Sub

    Private Sub ListFriends_DoubleClick(sender As Object, e As EventArgs) Handles ListFriends.DoubleClick
        With ListFriends
            Dim n As Integer = .SelectedIndex
            If n > -1 Then
                TxtWork.Text += .Items.Item(n) + vbCrLf
            End If
        End With
    End Sub

    Private Sub TxtSay_TextChanged(sender As Object, e As EventArgs) Handles TxtSay.TextChanged
        With TxtSay
            LabSay.Text = "留言内容：" & 括(.TextLength & "/" & .MaxLength)
        End With
    End Sub

    Private Sub ButStart_Click(sender As Object, e As EventArgs) Handles ButStart.Click
        开始工作()
        回收列表.Clear()
        失败列表.Clear()
        th = New Thread(Sub()
                            Dim fs As New List(Of String), m As Match, s As String
                            For Each m In Regex.Matches(TxtWork.Text, "\[765611[0-9]{11}\]")
                                s = m.ToString
                                If Not 在列表(fs, s) Then fs.Add(只要数字(s))
                            Next
                            LOG("你要给 " & fs.Count & " 个人留言。")
                            If fs.Count < 1 Then
                                结束工作()
                            End If
                            Dim say As String = TxtSay.Text
                            If say.Length < 1 Then
                                LOG("你不能发送空白留言！")
                                结束工作()
                            End If
                            失败文本 = say
                            For Each i As String In fs
                                Thread.Sleep(冷却时间 * 1000)
                                给好友留言(i, say)
                            Next
                            LOG("成功个数（可撤回）：" & 回收列表.Count)
                            If 失败列表.Count > 0 Then
                                LOG("失败个数：" & 失败列表.Count)
                                LOG("失败列表：")
                                LOG(列表转文字(失败列表))
                                LOG("失败的可试着重新发送。")
                            End If
                            结束工作()
                        End Sub)
        th.Start()
    End Sub

    Private Sub ButUndo_Click(sender As Object, e As EventArgs) Handles ButUndo.Click
        开始工作()
        LOG("有 " & 回收列表.Count & " 条留言要撤回。")
        If 回收列表.Count < 1 Then
            结束工作()
        End If
        th = New Thread(Sub()
                            Dim n As New List(Of String), i As String, fail As Integer = 0
                            For Each i In 回收列表
                                Thread.Sleep(冷却时间 * 1000)
                                If 删除留言(i) Then
                                    LOG("已撤回： " & 括(左(i, 17), QT))
                                    n.Add(i)
                                Else
                                    LOG("撤回失败： " & 括(左(i, 17), QT))
                                    fail += 1
                                End If
                            Next
                            For Each i In n
                                回收列表.Remove(i)
                            Next
                            LOG("成功：" & n.Count)
                            If fail > 0 Then
                                LOG("失败：" & fail)
                                LOG("你可以重试撤回。")
                            End If
                            结束工作()
                        End Sub)
        th.Start()
    End Sub

    Private Sub ButReSend_Click(sender As Object, e As EventArgs) Handles ButReSend.Click
        开始工作()
        LOG("有 " & 失败列表.Count & " 条留言要重新发送。")
        If 失败列表.Count < 1 Then
            结束工作()
        End If
        th = New Thread(Sub()
                            Dim i As String, n As New List(Of String)
                            For Each i In 失败列表
                                n.Add(i)
                            Next
                            回收列表.Clear()
                            失败列表.Clear()
                            For Each i In n
                                Thread.Sleep(冷却时间 * 1000)
                                给好友留言(i, 失败文本)
                            Next
                            LOG("成功：" & 回收列表.Count)
                            If 失败列表.Count > 0 Then
                                LOG("失败个数：" & 失败列表.Count)
                                LOG("失败列表：")
                                LOG(列表转文字(失败列表))
                                LOG("失败的可试着重新发送。")
                            End If
                            结束工作()
                        End Sub)
        th.Start()
    End Sub

    Private Sub ButSTOP_Click(sender As Object, e As EventArgs) Handles ButSTOP.Click
        If ButSTOP.Enabled = False Then Exit Sub
        中断线程(th)
        LOG("用时：" & 时间差(Now, 开始时间, True))
        LOG("工作结束：" & Now.ToLongTimeString)
        Pn.Enabled = True
        ButSTOP.Enabled = False
        GBsteamCookie.Enabled = True
    End Sub

    Sub 开始工作()
        中断线程(th)
        ButSTOP.Enabled = True
        Pn.Enabled = False
        GBsteamCookie.Enabled = False
        开始时间 = Now
        TxtLOG.Text = ""
        LOG("工作开始：" & Now.ToLongTimeString)
    End Sub

    Sub 结束工作()
        Dim n As New 委托结束工作(Sub()
                                ButSTOP.PerformClick()
                            End Sub)
        Invoke(n)
    End Sub

    Sub LOG(s As String)
        With TxtLOG
            If .TextLength > 0 Then .Text += vbCrLf
            .Text += s
            .SelectionStart = .TextLength
            .ScrollToCaret()
        End With
    End Sub

    Function 给好友留言(id64 As String, say As String) As String
        id64 = 左(只要数字(id64), 17)
        Dim h As New 简易HTTP("https://steamcommunity.com/comment/Profile/post/" + id64 + "/-1/", "POST")
        h.Cookie = 获取steamCookie()
        h.超时 = 5
        h.Referer = "https://steamcommunity.com/profiles/" + id64 + "/"
        Dim m As New 简易FormData()
        m.批量添加("comment", say, "count", "1", "feature2", "-1", "sessionid", 设置.字符串("SteamSession"))
        h.写入(m.ToString)
        Dim s As String = 去除(h.获取回应, 引号)
        If s.StartsWith("{success:true,name:Profile_" + id64) Then
            s = id64 + 只要数字(提取(s, "id=comment_content_", ">"))
            LOG("成功：" & 括(id64, QT))
            回收列表.Add(s)
        Else
            s = 左(去除(s, "{success:false,error:"), 100)
            If 包含(s, "The settings on this account do not allow you to add ") Then s += "（也可能是 cookie 失效）"
            LOG("发送失败：" & 括(id64, QT) & " 原因：" & s)
            失败列表.Add(括(id64, QT))
        End If
        Return s
    End Function

    Function 删除留言(id As String) As Boolean
        Dim id64 As String = 左(id, 17)
        id = 去左(id, 17)
        Dim h As New 简易HTTP("https://steamcommunity.com/comment/Profile/delete/" + id64 + "/-1/", "POST")
        h.Cookie = 获取steamCookie()
        h.超时 = 5
        h.Referer = "https://steamcommunity.com/profiles/" + id64 + "/"
        Dim m As New 简易FormData()
        m.批量添加("gidcomment", id, "count", "1", "feature2", "-1", "sessionid", 设置.字符串("SteamSession"), "start", "0")
        h.写入(m.ToString)
        Dim s As String = 去除(h.获取回应, 引号)
        Return s.StartsWith("{success:true,name:Profile_" + id64)
    End Function

End Class