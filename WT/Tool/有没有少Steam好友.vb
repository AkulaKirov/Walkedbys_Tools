Public Class 有没有少Steam好友

    Private Sub 有没有少Steam好友_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SteamCookie.呼起按钮(ButGetSteamCookie)
        CheckAuto.Checked = 设置.布林("AutoCheckSteamFriendsList")
    End Sub

    Private Sub ButGetFriends_Click(sender As Object, e As EventArgs) Handles ButGetFriends.Click
        开始工作(Pn, True, Sub()
                           Thread.Sleep(3000)
                           Dim n1 As New List(Of String), i As String, i2 As String, ok As Boolean, n As String, less As Integer = 0
                           文字转列表(n1, 设置.字符串("SteamFriends_" + SteamCookie.ID64))
                           If n1.Count < 0 Then
                               日志("这是你的第一次检查好友列表，请日后重新来检查才能发现有没有人变少。")
                           End If
                           Dim n2 As List(Of String) = SteamCookie.获得好友列表()
                           If n2.Count = 0 Then
                               日志("你没有好友！")
                           Else
                               If n2.First.ToLower = "failed" Then
                                   日志("获得好友列表失败！请检查网络。")
                               Else
                                   日志("你现在有： " & n2.Count & " 名好友。")
                                   For Each i In n1
                                       n = i
                                       i = 右(i, 19)
                                       ok = False
                                       For Each i2 In n2
                                           If 右(i2, 19) = i Then
                                               ok = True
                                               Exit For
                                           End If
                                       Next
                                       If Not ok Then
                                           less += 1
                                           日志("已经不再是好友：" + n)
                                       End If
                                   Next
                                   If less < 1 Then 日志("恭喜：你的好友列表里没有少人噢。")
                               End If
                           End If
                           结束工作()
                       End Sub)
    End Sub

End Class