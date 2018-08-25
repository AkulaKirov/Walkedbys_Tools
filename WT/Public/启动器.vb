
Public Class 启动器

    Friend 工具收藏 As New List(Of 工具)
    Friend 收藏按纽 As New List(Of Button)
    Dim 关于链接 As New List(Of LinkLabel)
    Dim 版本 As Single = 版本转小数(My.Application.Info.Version)
    Dim 计时 As Integer = 0
    Dim 已退出 As Boolean = False

    Private Sub 启动器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = 图标
        Text = "走過去的工具箱 测试版 v" + 版本.ToString
        Nico.Icon = 图标
        Directory.CreateDirectory(TempF)
        新工具("文件夹创建器", 文件夹创建器, "MKDIR", "输入一个路径，就能新建好你要的文件夹。")
        新工具("B站图床", B站图床, "BilibiliPic", "把20MB以下的图片无损放到B站服务器还行。")
        新工具("日子提醒器", 日子提醒, "DayReminder", "提醒生日或者重要的啥日子。")
        新工具("监视式VMT生成器", VMT生成器, "VMTG", "给一个贴图文件夹监视式地批量生成 VMT 文件。")
        新工具("系统代理设置", 系统代理设置, "ProxyManager", "快速设置系统代理。")
        新工具("GMod模组发布器", GM模组发布器, "GMAddonPu", "打包GMA文件，发布或更新 Addon 到 Garry's Mod Workshop。")
        新工具("未响应图片制作器", 未响应图片制作器, "NoResPic", "制作假装程序未响应的假图片。")
        新工具(" 工具箱设置", 程序设置, "AllSettings", "关于本工具箱的一些设置。")
        新工具("文件筛选", 文件筛选, "FileChoose", "把A文件夹B文件夹的文件选择性的复制到C文件夹。")
        新工具("Workshop物品篡改器", 创意工坊篡改器, "WorkshopCut", "可以直接修改 Steam Workshop 指定物品的信息，但是你必须是这个物品的上传者或贡献者。")
        新工具("SMD骨骼修整器", SMD骨骼修整器, "SMDmover", "（不推荐使用）修整一个SMD的骨骼的名字或者贴图的名字。")
        '新工具("临时工具", 临时工具, "Whatever", "临时用的工具，你不应该在公开发布版里面看见我。")
        新工具("剪贴板记录器", 剪贴板记录器, "clipboardrecord", "在后台记录剪贴板的内容到硬盘里。")
        新工具("网站监视器", 网站监视器, "HTTPWatch", "通过 HTTP GET 自动在后台定时检查返回数据的变化并提醒。")
        AddHandler SizeChanged, AddressOf 最小化隐藏
        Dim t As 工具, b As Button, i As Integer, g As String
        For Each t In 工具列表
            ListTools.Items.Add(t.名字)
        Next
        For i = 1 To 8
            b = New Button
            GBfavorites.Controls.Add(b)
            收藏按纽.Add(b)
            With b
                .Visible = False
                Dim wd As Integer = 170
                .Width = wd
                wd += 10
                .Height = 32
                .Left = IIf(i > 4, IIf(i - 4 > 1, (i - 5) * wd + 10, 10), IIf(i > 1, (i - 1) * wd + 10, 10))
                .Top = IIf(i > 4, 70, 20)
                AddHandler .Click, Sub()
                                       ID工具(.Tag).启动()
                                   End Sub
            End With
        Next
        Dim mc As New List(Of String)
        文字转列表(mc, 设置.元素("FAVOR"))
        For Each g In mc
            t = ID工具(g)
            If Not IsNothing(t) Then
                工具收藏.Add(t)
            End If
            If 工具收藏.Count >= 8 Then Exit For
        Next
        For i = 0 To 工具收藏.Count - 1
            If 工具收藏.Count < 1 Then Exit For
            b = 收藏按纽.Item(i)
            t = 工具收藏.Item(i)
            b.Text = t.名字
            b.Tag = t.ID
            b.Visible = True
        Next
        GBfavorites.Text = "工具收藏夹" + 括(工具收藏.Count.ToString + "/8")
        新增关于链接("博客", "https://walkedby.com/wt")
        新增关于链接("源码", "https://github.com/gordonwalkedby/Walkedbys_Tools")
        新增关于链接("下载最新版", "https://github.com/gordonwalkedby/Walkedbys_Tools/releases")
        新增关于链接("请我喝可乐", "https://walkedby.com/donateme/")
        Refresh()
        TimerX.Enabled = True
        GBallTools.Text += 括((ListTools.Items.Count - 1).ToString)
        If Not 设置.读取真假("NoUpdateAtMain") Then
            新线程(Sub()
                    Dim h As New 简易HTTP("https://raw.githubusercontent.com/gordonwalkedby/Walkedbys_Tools/master/WT/updater.xml")
                    h.超时 = 5
                    Dim ta As String = h.获得回应
                    Dim out As String = ""
                    If 全部包含(ta, "这是一个检查更新版本用的", "<root>") Then
                        Dim v As Single = Val(提取XML(ta, "root", "ver"))
                        ta = v.ToString + "）"
                        If 版本 < v Then
                            GBabout.Text += "（检测到新版本：v" + ta
                        Else
                            GBabout.Text += "（已是最新版本：v" + ta
                        End If
                    Else
                        GBabout.Text += "（检查更新失败）"
                    End If
                End Sub)
        End If
    End Sub

    Private Sub 启动器_FormClosing(sender As Form, e As FormClosingEventArgs) Handles Me.FormClosing
        If 设置.读取真假("ExitAtMain") Then
            退出()
        Else
            e.Cancel = True
            隐藏到后台(sender)
        End If
    End Sub

    Public Sub 退出()
        Nico.Visible = False
        For Each t As Thread In 多线程
            中断线程(t)
        Next
        设置.保存到本地()
        删除(TempF)
        已退出 = True
        End
    End Sub

    Sub 检查推送() Handles Me.Activated
        TxtUpdate.Text = ""
        日子提醒.日子提醒_Load()
        日子提醒.提醒好日子()
        Dim s As String = TxtUpdate.Text
        If s.Length > 50 Then s = 左(s, 50) + "..."
        Nico.Text = "走過去的工具箱" + vbCrLf + s
    End Sub

    Private Sub ListTools_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTools.SelectedIndexChanged
        Dim i As Integer = ListTools.SelectedIndex
        If i < 0 Then Exit Sub
        Dim t As 工具 = 名字工具(ListTools.SelectedItem.ToString)
        TxtToolDes.Text = t.名字 + vbCrLf + IIf(在列表(工具收藏, t), "【已收藏】" + vbCrLf, "") + "简介：" + vbCrLf + t.简介
        ButOpenTool.Enabled = True
        With ButAddToFavor
            If 在列表(工具收藏, t) Then
                .Enabled = True
                .Text = "取消收藏"
            Else
                If 工具收藏.Count < 8 Then
                    .Enabled = True
                    .Text = "收藏"
                Else
                    .Enabled = False
                    .Text = "收藏夹已满"
                End If
            End If
        End With
    End Sub

    Private Sub ListTools_DoubleClick(sender As Object, e As EventArgs) Handles ListTools.DoubleClick
        Dim i As Integer = ListTools.SelectedIndex
        If i < 0 Then Exit Sub
        Dim t As 工具 = 名字工具(ListTools.Items.Item(i))
        t.启动()
    End Sub

    Private Sub ButOpenTool_Click(sender As Object, e As EventArgs) Handles ButOpenTool.Click
        Dim t As 工具 = 名字工具(ListTools.SelectedItem.ToString)
        t.启动()
    End Sub

    Private Sub ButAddToFavor_Click(sender As Object, e As EventArgs) Handles ButAddToFavor.Click
        Dim t As 工具 = 名字工具(ListTools.SelectedItem.ToString)
        If Not 在列表(工具收藏, t) Then
            If 工具收藏.Count < 8 Then 工具收藏.Add(t)
        Else
            工具收藏.Remove(t)
        End If
        Dim i As Integer = 0
        For i = 0 To 7
            收藏按纽.Item(i).Visible = False
        Next
        If 工具收藏.Count > 0 Then
            For i = 0 To 工具收藏.Count - 1
                Dim b As Button = 收藏按纽.Item(i)
                t = 工具收藏.Item(i)
                b.Text = t.名字
                b.Tag = t.ID
                b.Visible = True
            Next
        End If
        设置.元素("FAVOR") = 列表转文字(工具收藏)
        ListTools_SelectedIndexChanged(sender, e)
        GBfavorites.Text = "工具收藏夹" + 括(工具收藏.Count.ToString + "/8")
    End Sub

    Sub 新增关于链接(文字 As String, 链接 As String)
        Dim m As New LinkLabel
        GBabout.Controls.Add(m)
        With m
            .Top = LabAbout.Bottom + 5
            If 关于链接.Count = 0 Then
                .Left = 6
            Else
                .Left = 关于链接.Last.Right + 6
            End If
            .Width = 100
            .Height = 100
            .Text = 文字
            .Visible = True
            .AutoSize = True
            AddHandler .LinkClicked, Sub(sender As Object, e As LinkLabelLinkClickedEventArgs)
                                         Process.Start(链接)
                                     End Sub
        End With
        关于链接.Add(m)
    End Sub

    Private Sub GBabout_Paint(sender As Object, e As PaintEventArgs) Handles GBabout.Paint
        Dim i As Image = My.Resources.LogoPng
        Dim b As Single = 0.4
        With GBabout
            e.Graphics.DrawImage(i, .Width - i.Width * b, .Height - i.Height * b, i.Width * b, i.Height * b)
        End With
    End Sub

    Private Sub TimerX_Tick(sender As Object, e As EventArgs) Handles TimerX.Tick
        计时 += 1
        Select Case 计时
            Case 1
                Dim t As 工具, g As String
                If 启动参数.Count > 0 Then
                    For Each g In 启动参数
                        If g.StartsWith("-") Then
                            t = ID工具(去左(g, 1))
                            If Not IsNothing(t) Then
                                t.启动()
                                Exit For
                            End If
                        End If
                    Next
                End If
            Case 2
        End Select
        If 计时 Mod 60 * (1000 / TimerX.Interval) = 0 Then
            设置.保存到本地()
        End If
        If 已退出 Then
            Do While True
                PRT("die")
                End
            Loop
        Else
            Nico.Visible = True
        End If
    End Sub

    Private Sub Nico_MouseUp(sender As Object, e As MouseEventArgs) Handles Nico.MouseUp
        If e.Button = MouseButtons.Left Then
            显示到前台(最后窗体)
        End If
    End Sub

    Private Sub 显示窗口ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示窗口ToolStripMenuItem.Click
        Nico_MouseUp(sender, New MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0))
    End Sub

    Private Sub NicoMenu_Opening(sender As Object, e As CancelEventArgs) Handles NicoMenu.Opening
        Dim f As New List(Of ToolStripMenuItem)
        Dim i As ToolStripMenuItem
        For Each i In NicoMenu.Items
            If i.Tag <> "" Then
                f.Add(i)
            End If
        Next
        For Each i In f
            NicoMenu.Items.Remove(i)
        Next
        For Each n As 工具 In 工具收藏
            i = New ToolStripMenuItem
            With i
                .Text = n.名字
                .Tag = "工具"
                AddHandler i.Click, Sub()
                                        显示到前台(最后窗体)
                                        n.启动()
                                    End Sub
            End With
            NicoMenu.Items.Add(i)
        Next
        i = New ToolStripMenuItem
        With i
            .Text = "退出"
            .Tag = "退出"
            AddHandler i.Click, Sub()
                                    退出()
                                End Sub
        End With
        NicoMenu.Items.Add(i)
    End Sub

    Private Sub 返回启动器ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 返回启动器ToolStripMenuItem.Click
        显示到前台(最后窗体)
        If Not 最后窗体.Equals(Me) Then 最后窗体.Close()
    End Sub

End Class

