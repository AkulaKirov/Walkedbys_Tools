Public Class Steam批量好友留言

    Dim 回收列表 As New List(Of String), 失败列表 As New List(Of String), 失败文本 As String
    Dim QT As String = "[]"
    Dim w As 工作

    Private Sub Steam批量好友留言_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        w = New 工作(Pn, True)
        SteamCookie.呼起按钮(ButGetSteamCookie)
        文字转列表(ListFriends.Items, 设置.字符串("SteamFriends_" + SteamCookie.ID64))
        TxtSay.Text = 设置.字符串("SteamFriendSayWhat")
        TxtSay_TextChanged(Nothing, Nothing)
        TxtWork.Text = 设置.字符串("SteamFriendSayWho")
    End Sub

    Private Sub Steam批量好友留言_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.字符串("SteamFriendSayWhat") = TxtSay.Text
        设置.字符串("SteamFriendSayWho") = TxtWork.Text
    End Sub

    Private Sub ButGetFriends_Click(sender As Object, e As EventArgs) Handles ButGetFriends.Click
        TxtLog.Text = ""
        ListFriends.Items.Clear()
        If SteamCookie.填写正确 Then
            For Each i As String In SteamCookie.获得好友列表()
                ListFriends.Items.Add(i)
            Next
        Else
            w.日志("请先填写 Steam Cookie")
        End If
    End Sub

    Private Sub ListFriends_DoubleClick(sender As Object, e As EventArgs) Handles ListFriends.DoubleClick
        With ListFriends
            Dim n As Integer = .SelectedIndex
            If n > -1 Then
                If TxtWork.TextLength > 1 Then
                    TxtWork.Text += vbCrLf
                End If
                TxtWork.Text += .Items.Item(n)
                TxtWork.SelectionStart = TxtWork.TextLength
                TxtWork.ScrollToCaret()
            End If
        End With
    End Sub

    Private Sub TxtSay_TextChanged(sender As Object, e As EventArgs) Handles TxtSay.TextChanged
        With TxtSay
            LabSay.Text = "留言内容：" & 括(.TextLength & "/" & .MaxLength)
        End With
    End Sub

    Private Sub ButStart_Click(sender As Object, e As EventArgs) Handles ButStart.Click
        w.开始(Sub()
                 回收列表.Clear()
                 失败列表.Clear()
                 Dim fs As New List(Of String), m As Match, s As String
                 For Each m In Regex.Matches(TxtWork.Text, "\[765611[0-9]{11}\]")
                     s = 只要数字(m.ToString)
                     If Not 在列表(fs, s) Then fs.Add(s)
                 Next
                 w.日志("你要给 " & fs.Count & " 个人留言。")
                 If fs.Count < 1 Then
                     w.结束()
                 End If
                 Dim say As String = TxtSay.Text
                 If say.Length < 1 Then
                     w.日志("你不能发送空白留言！")
                     w.结束()
                 End If
                 失败文本 = say
                 For Each i As String In fs
                     s = 给好友留言(i, say)
                     If s.Length > 10 Then
                         回收列表.Add(s)
                     Else
                         失败列表.Add(括(i, QT))
                     End If
                 Next
                 w.日志("成功个数（可撤回）：" & 回收列表.Count)
                 If 失败列表.Count > 0 Then
                     w.日志("失败个数：" & 失败列表.Count)
                     w.日志("失败列表：")
                     w.日志(列表转文字(失败列表))
                     w.日志("失败的可点按钮【重试发生失败的留言】。")
                 End If
                 w.结束()
             End Sub)
    End Sub

    Private Sub ButUndo_Click(sender As Object, e As EventArgs) Handles ButUndo.Click
        w.开始(Sub()
                 w.日志("有 " & 回收列表.Count & " 条留言要撤回。")
                 If 回收列表.Count < 1 Then
                     w.结束()
                 End If
                 Dim n As New List(Of String), i As String, fail As Integer = 0
                 For Each i In 回收列表
                     If 删除留言(i) Then
                         w.日志("已撤回： " & 括(左(i, 17), QT))
                         n.Add(i)
                     Else
                         w.日志("撤回失败： " & 括(左(i, 17), QT))
                         fail += 1
                     End If
                 Next
                 For Each i In n
                     回收列表.Remove(i)
                 Next
                 w.日志("成功：" & n.Count)
                 If fail > 0 Then
                     w.日志("失败：" & fail)
                     w.日志("你可以再点一次撤回以重试。")
                 End If
                 w.结束()
             End Sub)
    End Sub

    Private Sub ButReSend_Click(sender As Object, e As EventArgs) Handles ButReSend.Click
        w.开始(Sub()
                 w.日志("有 " & 失败列表.Count & " 条留言要重新发送。")
                 If 失败列表.Count < 1 Then
                     w.结束()
                 End If
                 Dim i As String, n As New List(Of String), s As String
                 For Each i In 失败列表
                     s = 给好友留言(i, 失败文本)
                     If s.Length > 10 Then
                         回收列表.Add(s)
                     Else
                         n.Add(i)
                     End If
                 Next
                 失败列表.Clear()
                 For Each i In n
                     失败列表.Add(i)
                 Next
                 w.日志("成功：" & 回收列表.Count)
                 If 失败列表.Count > 0 Then
                     w.日志("失败个数：" & 失败列表.Count)
                     w.日志("失败列表：")
                     w.日志(列表转文字(失败列表))
                     w.日志("失败的可点按钮【重试发生失败的留言】。")
                 End If
                 w.结束()
             End Sub)
    End Sub

    Private Sub ShowCount_Tick(sender As Object, e As EventArgs) Handles ShowCount.Tick
        ButUndo.Text = "撤回本次发出的留言" & 括(回收列表.Count.ToString)
        ButReSend.Text = "重试发生失败的留言" & 括(失败列表.Count.ToString)
    End Sub

    Private Sub TxtLog_MouseUp(sender As Object, e As MouseEventArgs) Handles TxtLog.MouseUp
        With ButCheckComments
            .Visible = False
            Dim s As String = 右(只要数字(TxtLog.SelectedText), 17)
            If Regex.IsMatch(s, "765611[0-9]{11}") Then
                .Text = "去浏览器查看情况 " + 括(s)
                .Visible = True
            End If
        End With
    End Sub

    Private Sub ButCheckComments_Click(sender As Object, e As EventArgs) Handles ButCheckComments.Click
        Process.Start("https://steamcommunity.com/profiles/" + 只要数字(ButCheckComments.Text) + "/allcomments")
    End Sub

    Function 给好友留言(id64 As String, say As String) As String
        id64 = 左(只要数字(id64), 17)
        Thread.Sleep(5000)
        Dim h As New 简易HTTP("https://steamcommunity.com/comment/Profile/post/" + id64 + "/-1/", "POST")
        h.Cookie = SteamCookie.完整Cookie
        h.超时 = 5
        h.Referer = "https://steamcommunity.com/profiles/" + id64 + "/"
        Dim m As New 简易FormData()
        m.批量添加("comment", say, "count", "1", "feature2", "-1", "sessionid", 设置.字符串("SteamSession"))
        h.写入(m.ToString)
        Dim s As String = 去除(h.获取回应, 引号)
        If s.StartsWith("{success:true,name:Profile_" + id64) Then
            w.日志("成功：" & 括(id64, QT))
            Return id64 + 只要数字(提取(s, "id=comment_content_", ">"))
        Else
            s = 左(去除(s, "{success:false,error:"), 100)
            If 包含(s, "The settings on this account do not allow you to add ") Then s += "（也可能是 cookie 失效）"
            w.日志("发送失败：" & 括(id64, QT) & " 原因：" & s)
        End If
        Return ""
    End Function

    Function 删除留言(id As String) As Boolean
        Thread.Sleep(2500)
        Dim id64 As String = 左(id, 17)
        id = 去左(id, 17)
        Dim h As New 简易HTTP("https://steamcommunity.com/comment/Profile/delete/" + id64 + "/-1/", "POST")
        h.Cookie = SteamCookie.完整Cookie
        h.超时 = 5
        h.Referer = "https://steamcommunity.com/profiles/" + id64 + "/"
        Dim m As New 简易FormData()
        m.批量添加("gidcomment", id, "count", "1", "feature2", "-1", "sessionid", SteamCookie.SessionID, "start", "0")
        h.写入(m.ToString)
        Dim s As String = 去除(h.获取回应, 引号)
        Return s.StartsWith("{success:true,name:Profile_" + id64)
    End Function

End Class