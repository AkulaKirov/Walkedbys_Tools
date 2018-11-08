﻿
Public Class Steam好友列表检查

    Dim TH As Thread, 自动检查 As Boolean = False, 肯定少人 As Boolean = False

    Private Sub Steam好友列表检查_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With LabAutoCheck
            .Tag = .Text
            .Text = ""
        End With
        TxtID64.Text = 设置.字符串("steam64id")
        TxtLog.Text = 设置.字符串("steamFriendLOG")
        If 设置.布林("CheckSteamFriendsAtStart") Then
            CheckAuto.Checked = True
            If 只做一次(7458) Then
                自动检查 = True
                If ButCheck.Enabled Then ButCheck_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub Steam好友列表检查_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.字符串("steam64id") = TxtID64.Text
        设置.字符串("steamFriendLOG") = TxtLog.Text
        中断线程(TH)
    End Sub

    Private Sub TxtID64_TextChanged(sender As Object, e As EventArgs) Handles TxtID64.TextChanged
        Dim s As String = 左(只要数字(TxtID64.Text), 17)
        TxtID64.Text = s
        ButCheck.Enabled = (是steam64ID(s) AndAlso TimerC.Enabled = False)
    End Sub

    Private Sub ButCheck_Click(sender As Object, e As EventArgs) Handles ButCheck.Click
        TimerC.Enabled = True
        ButCheck.Enabled = False
        ButCheck.Text = "冷却中"
        TH = New Thread(Sub()
                            Dim uid As String = TxtID64.Text
                            Dim h As New 简易HTTP("https://api.steampowered.com/ISteamUser/GetFriendList/v1/?key=C4A54581C4CD472BFFA98CC49885EEEF&steamid=" + uid)
                            h.超时 = 5
                            Dim out As String = Now.ToString + vbCrLf + "用户：" + uid + vbCrLf
                            Dim s As String = 去除(h.获取回应, 引号), 少人 As Boolean = False
                            If 包含(s, "friendslist") Then
                                Dim u As String = 设置.字符串("steamfriendslist" + uid), id As String, n As Integer = 0
                                Dim mc As MatchCollection
                                If 包含(u, "friendslist") Then
                                    If 肯定少人 Then u += "steamid:" + 随机.数字(17) + ","
                                    mc = Regex.Matches(u, "steamid:[0-9]{17},")
                                    For Each i As Match In mc
                                        id = i.ToString
                                        If Not 包含(s, id) Then
                                            n += 1
                                            out += "不再是好友：" + 只要数字(id) + vbCrLf
                                            少人 = True
                                            If 设置.布林("CheckSteamFriendsAtStart") AndAlso 自动检查 Then
                                                Tag = "你的steam好友列表少人了！"
                                            End If
                                        End If
                                    Next
                                    If n = 0 AndAlso 自动检查 Then
                                        LabAutoCheck.Text = LabAutoCheck.Tag
                                    End If
                                    mc = Regex.Matches(s, "steamid:[0-9]{17},")
                                    out += "好友数：" + mc.Count.ToString + vbCrLf
                                    out += "检查完毕" + IIf(n = 0, "，没有少人。", "。")
                                Else
                                    mc = Regex.Matches(s, "steamid:[0-9]{17},")
                                    out += "好友数：" + mc.Count.ToString + vbCrLf
                                    out += "第一次检查完成，日后检查才能发现少人。"
                                End If
                                设置.字符串("steamfriendslist" + uid) = s
                            Else
                                out += "获取失败，原因：" + vbCrLf + s
                            End If
                            If (自动检查 AndAlso 少人) OrElse 自动检查 = False Then
                                TxtLog.Text = out + vbCrLf + "===============================" + vbCrLf + TxtLog.Text
                            End If
                            自动检查 = False
                        End Sub)
        TH.Start()
    End Sub

    Private Sub ButClear_Click(sender As Object, e As EventArgs) Handles ButClear.Click
        TxtLog.Text = ""
    End Sub

    Private Sub TimerC_Tick(sender As Object, e As EventArgs) Handles TimerC.Tick
        TimerC.Enabled = False
        ButCheck.Enabled = (TxtID64.TextLength = 17)
        ButCheck.Text = "点我检查"
    End Sub

    Private Sub LabID_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LabID.LinkClicked
        Process.Start("https://steamrepcn.com/")
    End Sub

    Private Sub CheckAuto_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAuto.CheckedChanged
        设置.字符串("CheckSteamFriendsAtStart") = CheckAuto.Checked.ToString
    End Sub

    Private Sub Steam好友列表检查_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Tag = ""
    End Sub

    Private Sub TxtLog_MouseUp(sender As Object, e As MouseEventArgs) Handles TxtLog.MouseUp
        Dim s As String = 只要数字(TxtLog.SelectedText), b As Boolean = 是steam64ID(s)
        With ButSearch
            .Visible = b
            If b Then
                .Text = "查询：" + s + IIf(s = TxtID64.Text, "（你自己）", "")
            End If
        End With
    End Sub

    Private Sub ButSearch_Click(sender As Object, e As EventArgs) Handles ButSearch.Click
        Process.Start("https://steamrepcn.com/profiles/" + 只要数字(ButSearch.Text))
    End Sub

End Class