
Public Class 启动器

    Friend 工具收藏 As New List(Of 工具)
    Friend 收藏按纽 As New List(Of Button)
    Dim Th更新 As New Thread(Sub()
                               Dim h As New 简易HTTP("https://raw.githubusercontent.com/gordonwalkedby/Walkedbys_Tools/master/WT/updater.xml")
                               h.超时 = 5
                               Dim t As String = h.获得回应
                               Dim out As String = ""
                               If 全部包含(t, "这是一个检查更新版本用的", "<root>") Then
                                   Dim v As Single = Val(提取XML(t, "root", "ver"))
                                   If 版本 < v Then
                                       GBabout.Text += "（检测到新版本：v" + v.ToString + "）"
                                   Else
                                       GBabout.Text += "（已是最新版本：v" + v.ToString + "）"
                                   End If
                               Else
                                   GBabout.Text += "（检查更新失败）"
                               End If
                           End Sub)
    Dim 关于链接 As New List(Of LinkLabel)
    Dim 版本 As Single = My.Application.Info.Version.Major + (My.Application.Info.Version.Minor / 10)

    Private Sub 启动器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        随机.刷新()
        Icon = 图标
        Text = "走過去的工具箱 测试版 v" + 版本.ToString
        Nico.Icon = 图标
        线程越界()
        Th更新.Start()
        Directory.CreateDirectory(TempF)
        工具列表.Add(New 工具("文件夹创建器", 文件夹创建器, "MKDIR", "输入一个路径，就能新建好你要的文件夹。"))
        工具列表.Add(New 工具("B站图床", B站图床, "BilibiliPic", "把20MB以下的图片无损放到B站服务器还行。"))
        工具列表.Add(New 工具("日子提醒器", 日子提醒, "DayReminder", "可以拿来提醒生日或者重要的啥日子。"))
        工具列表.Add(New 工具("监视式VMT生成器", VMT生成器, "VMTG", "给一个贴图文件夹监视式地批量生成 VMT 文件。"))
        工具列表.Add(New 工具("系统代理设置", 系统代理设置, "ProxyManager", "快速设置系统代理。"))
        工具列表.Add(New 工具("GMod模组发布器", GM模组发布器, "GMAddonPu", "打包GMA文件，发布或更新 Addon 到 Garry's Mod Workshop。"))
        工具列表.Add(New 工具("未响应图片制作器", 未响应图片制作器, "NoResPic", "制作假装程序未响应的假图片。"))
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
                .Width = 150
                .Height = 32
                .Left = IIf(i > 4, IIf(i - 4 > 1, (i - 5) * 160 + 10, 10), IIf(i > 1, (i - 1) * 160 + 10, 10))
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
        After1s.Enabled = True
    End Sub

    Private Sub 启动器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Nico.Visible = False
        中断线程(Th更新)
        设置.保存到本地()
        删除(TempF)
    End Sub

    Sub 检查推送()
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
                .Enabled = (工具收藏.Count < 8)
                .Text = "收藏"
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

    Private Sub 启动器_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        检查推送()
    End Sub

    Private Sub After1s_Tick(sender As Object, e As EventArgs) Handles After1s.Tick
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
        After1s.Enabled = False
    End Sub

    Private Sub Nico_MouseUp(sender As Object, e As MouseEventArgs) Handles Nico.MouseUp
        If e.Button = MouseButtons.Left Then
            With 最后窗体
                .TopMost = True
                .WindowState = FormWindowState.Normal
                .Show()
                .TopMost = False
            End With
        End If
    End Sub

    Private Sub 显示窗口ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示窗口ToolStripMenuItem.Click
        Nico_MouseUp(sender, New MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0))
    End Sub

    Private Sub NicoMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NicoMenu.Opening
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
                                    Close()
                                End Sub
        End With
        NicoMenu.Items.Add(i)
    End Sub

    Private Sub 返回启动器ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 返回启动器ToolStripMenuItem.Click
        If Not 最后窗体.Equals(Me) Then 最后窗体.Close() Else 显示窗口ToolStripMenuItem_Click(sender, e)
    End Sub

End Class

