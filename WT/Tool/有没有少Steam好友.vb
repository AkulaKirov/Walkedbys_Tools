Public Class 有没有少Steam好友

    Dim 自动检查 As Boolean, w As 工作

    Private Sub 有没有少Steam好友_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SteamCookie.呼起按钮(ButGetSteamCookie)
        w = New 工作(Pn, True)
        自动检查 = 设置.布林("AutoCheckSteamFriendsList")
        CheckAuto.Checked = 自动检查
        If 自动检查 Then
            ButGetFriends.PerformClick()
        End If
    End Sub

    Private Sub 有没有少Steam好友_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If Not 自动检查 Then Tag = ""
    End Sub

    Private Sub 有没有少Steam好友_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.布林("AutoCheckSteamFriendsList") = CheckAuto.Checked
    End Sub

    Private Sub ButGetFriends_Click(sender As Object, e As EventArgs) Handles ButGetFriends.Click
        w.开始(Sub()
                 Dim n1 As New List(Of String), i As String, i2 As String, ok As Boolean, n As String, less As Integer = 0
                 i = 设置.字符串("SteamFriends_" + SteamCookie.ID64)
                 If i.Length < 15 Then
                     w.日志("这是你的第一次检查好友列表，请日后重新来检查才能发现有没有人变少。")
                 Else
                     文字转列表(n1, i)
                 End If
                 Dim n2 As List(Of String) = SteamCookie.获得好友列表()
                 If n2.Count = 0 Then
                     w.日志("你没有好友！（或者请设置你的好友列表权限为公开）")
                 Else
                     If n2.First.ToLower = "failed" Then
                         w.日志("获得好友列表失败！请检查网络。")
                     Else
                         w.日志("你现在有： " & n2.Count & " 名好友。")
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
                                 w.日志("已经不再是好友：" + n)
                             End If
                         Next
                         If less < 1 Then
                             w.日志("恭喜：你的好友列表里没有少人噢。")
                         Else
                             If 自动检查 Then Tag = "你的Steam好友列表里少人了！"
                         End If
                         自动检查 = False
                     End If
                 End If
                 Thread.Sleep(3000)
                 w.结束()
             End Sub)
    End Sub

    Private Sub TxtLog_MouseUp(sender As Object, e As MouseEventArgs) Handles TxtLog.MouseUp
        With ButCheckSteam
            .Visible = False
            Dim s As String = 右(只要数字(TxtLog.SelectedText), 17)
            If 是Steam64ID(s) Then
                .Text = "查看：" & s
                .Visible = True
            End If
        End With
    End Sub

    Private Sub ButCheckSteam_Click(sender As Object, e As EventArgs)
        打开Steam用户主页(只要数字(ButCheckSteam.Text))
    End Sub

End Class