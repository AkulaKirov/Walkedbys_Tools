
Public Class 启动器

    Friend 收藏按纽 As New List(Of Button)
    Dim 关于链接 As New List(Of LinkLabel)
    Dim 彩蛋码 As String
    Dim 已退出 As Boolean = False
    Dim 原时长 As Long

    Private Sub 启动器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        随机.刷新()
        Icon = 图标
        Text = "走過去的工具箱 测试版 v" + 版本.ToString
        Nico.Icon = 图标
        Directory.CreateDirectory(缓存目录)
        Dim t As 工具, b As Button, i As Integer, g As String
        If 在列表(启动参数, "-tryfix") Then
            新工具("信息修改器", 信息修改器, "TryFix", "设置保存信息的修改器")
        End If
        '新工具("临时工具", 临时工具, "Whatever", "临时用的工具，你不应该在公开发布版里面看见我")
        新工具(" 工具箱设置", 程序设置, "AllSettings", "关于本工具箱的一些设置")
        新工具("文件夹创建器", 文件夹创建器, "MKDIR", "输入一个路径，就能新建好你要的文件夹")
        新工具("B站图床", B站图床, "BilibiliPic", "把20MB以下的图片无损放到B站服务器还行")
        新工具("日子提醒器", 日子提醒, "DayReminder", "提醒生日或者重要的啥日子", True)
        新工具("监视式VMT生成器", VMT生成器, "VMTG", "给一个贴图文件夹监视式地批量生成 VMT 文件")
        新工具("系统代理设置", 系统代理设置, "ProxyManager", "快速设置系统代理")
        新工具("GMod模组发布器", GM模组发布器, "GMAddonPu", "打包GMA文件，发布或更新 Addon 到 Garry's Mod Workshop")
        新工具("未响应图片制作器", 未响应图片制作器, "NoResPic", "制作假装程序未响应的假图片")
        新工具("文件筛选", 文件筛选, "FileChoose", "把A文件夹B文件夹的文件选择性的复制到C文件夹")
        新工具("创意工坊物品篡改器", 创意工坊篡改器, "WorkshopCut", "可以直接修改 Steam Workshop 指定物品的信息，但是你必须是这个物品的上传者或贡献者")
        新工具("剪贴板记录器", 剪贴板记录器, "ClipBoardRecord", "在后台记录剪贴板的内容到硬盘里", True)
        新工具("模型贴图打包器", 起源模型贴图打包器, "SourceModelPacker", "给 Source 的模型文件批量打包贴图文件")
        新工具("RunSringLUA制作器", RunStringLUA制作器, "RunStringLua", "算是给 GMod LUA 加密？")
        新工具("B站催更器", B站催更器, "BilibiliPushYou", "会提醒你B站多久没更视频的一个工具", 设置.读取真假("CheckBilibiliAtStart"))
        新工具("B站实时最大AV", B站AV变化, "BilibiliAV", "直观地显示一下B站各分区的最大AV号的实时情况")
        新工具("随机生成器", 随机生成器, "RandomG", "随机生成中英文句子或者数字等")
        新工具("网络检测", 网络检测, "NetTest", "如果你觉得你的网络不正常可以一直看着这个")
        新工具("字符画图片制作", 字符画图片制作, "CharPic", "用字符画表示图片")
        新工具("有没有少Steam好友", Steam好友列表检查, "SteamFriends", "检查你的Steam好友里是不是有人把你删了", 设置.读取真假("CheckSteamFriendsAtStart"))
        新工具("创意工坊物品列表导出", 创意工坊订阅列表导出, "WorkshopListOut", "把你的workshop订阅的或者是收藏夹里的或者是你发布的或者合集里的物品都导出成一个列表")
        新工具("创意工坊合集物品批量添加", 创意工坊合集物品批量添加, "WorkshopCollectionAdd", "可以先用Workshop物品列表导出工具导出物品列表，然后在这里导入到指定的合集。")
        AddHandler SizeChanged, AddressOf 最小化隐藏
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
                                       名字工具(.Tag).启动()
                                   End Sub
            End With
        Next
        Dim mc As New List(Of String)
        文字转列表(mc, 设置.元素("FAVOR"))
        For Each g In mc
            t = 名字工具(g)
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
        新增关于链接("下载最新版", "https://github.com/gordonwalkedby/Walkedbys_Tools/releases")
        新增关于链接("请我喝好的", "https://walkedby.com/donateme/")
        新增关于链接("反馈", "https://steamcn.com/t422593-1-1")
        GBallTools.Text += 括((ListTools.Items.Count - 1).ToString)
        原时长 = 设置.读取数("OpenTime")
        TimerC_Tick()
        If Not 设置.读取真假("NoUpdateAtMain") Then
            新线程(Sub()
                    Dim h As New 简易HTTP("https://raw.githubusercontent.com/gordonwalkedby/Walkedbys_Tools/master/WT/updater.xml")
                    h.超时 = 5
                    Dim ta As String = h.获得回应
                    Dim out As String = ""
                    If 全部包含(ta, "这是一个检查更新版本用的", "<root>") Then
                        Dim v As New Version(提取XML(ta, "root", "ver"))
                        ta = v.ToString + "）"
                        If My.Application.Info.Version < v Then
                            GBabout.Text += "（检测到新版本：v" + ta
                        Else
                            GBabout.Text += "（已是最新版本：v" + ta
                        End If
                    Else
                        GBabout.Text += "（检查更新失败）"
                    End If
                End Sub)
        End If
        彩蛋码 = ""
        LabFun.Text = 随机.多选一("",
"8848 钛金显卡~",
"真高兴我的计算机几乎都不是学校教的。",
"风水轮流转。",
"要试试直接对着我输入 " + 随机.多选一("steam", "stcn", "2233") + " 吗？",
"那太不幸了。",
"正义之子面对有悖常理的世界，会让世界天翻地覆。",
"我不喜欢吵架或者辱骂，我也不支持断绝交流的大门。",
"我有一个男友，可惜他关键时刻派不上用场。",
"迅雷其实是功能最齐全的下载软件，可惜他越做越差。",
"一个朋友曾对我说：steam没被墙，只是被DNS污染了。",
"You forget a thousand things every day, make sure this is one of them.",
"做地图做到想吐，赚钱好难啊。",
"做傻瓜式软件救不了中国人。",
"别和差的比，越差越有理。",
"有钱能使鬼推磨。",
"我喜欢喝可乐，我更喜欢喝热茶，就是那种便宜的绿茶，茶叶买回来泡开水喝。",
"你猜猜这里一共可以出现几句话？",
"我也曾是个小学生，我先玩的CF，然后玩的CS1.6，然后学了怎么做CS1.6地图。",
"我用的麦克风大概30元不到就能买到同款。",
"我播放量最高的那个马化腾的视频其实是个垃圾视频，只花了我两个小时做好的。",
"我已经等不急玩GTA6或者半条命2EP3了。",
"曾经有一个朋友让我电脑登录他的steam账号帮他做点事情，我很高兴，因为他信任我，被信任真好。",
"人啊，不要有点成功就开始来点名言警句教人家做人，结果到头来反而被自己说的大道理压死。——敖厂长",
"男友一直对他QQ群里的人：自己百度去。但是在我面前，有问题都是第一时间问我，他自己都不肯百度。",
"幸福很难，自由也很难，尤其在中国，两者几乎不能兼得。",
"Turn down for what!",
"男友可有钱了，就是希望他智商和修养也能和他的余额一样高。",
"美国圣地亚戈国际农业集团总裁——威廉伯爵，享有与美国总统同等的荣誉。",
"一个比一个干净，反过来看，一个比一个肮脏。",
"你喜欢聊天吗w",
"我也想做合法的事情，如果合法手段有用的话。",
"我很不敢相信，有的人碰过智能手机，没有碰过电脑的鼠标键盘。"
).ToString
        Refresh()
        AutoSave.Enabled = True
        Opener.Enabled = True
        配色(Me)
        If 设置.读取真假("SaveBACKUP") Then
            g = 程序文件目录 + "wt_save_backup\"
            Directory.CreateDirectory(g)
            g += 下划线日期(Today) + ".wbxml"
            If Not 文件存在(g) Then
                If 文件可读写(g) Then File.Copy(设置.本地文件, g, True)
            End If
        End If
    End Sub

    Private Sub 启动器_FormClosing(sender As Form, e As FormClosingEventArgs) Handles Me.FormClosing
        If 设置.读取真假("ExitAtMain") Then
            e.Cancel = True
            隐藏到后台(sender)
        Else
            退出()
        End If
    End Sub

    Public Sub 退出()
        设置.元素("OpenTime") = 原时长 + Abs(DateDiff(DateInterval.Second, Now, 开始时间))
        Nico.Visible = False
        For Each t As Thread In 多线程
            中断线程(t)
        Next
        For Each n As 工具 In 工具列表
            If n.启动过了 Then n.窗体.Dispose()
        Next
        设置.保存到本地()
        删除(缓存目录)
        已退出 = True
        End
    End Sub

    Private Sub ListTools_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTools.SelectedIndexChanged
        Dim i As Integer = ListTools.SelectedIndex
        If i < 0 Then Exit Sub
        Dim t As 工具 = 名字工具(ListTools.SelectedItem.ToString)
        TxtToolInfo.Text = t.简介
        TxtToolID.Text = t.ID
        TxtToolName.Text = t.名字
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

    Private Sub Opener_Tick(sender As Object, e As EventArgs) Handles Opener.Tick
        Dim t As 工具, g As String
        If 启动参数.Count > 0 Then
            For Each g In 启动参数
                If g.StartsWith("-") Then
                    t = 名字工具(去左(g, 1))
                    If Not IsNothing(t) Then
                        t.启动()
                        Opener.Enabled = False
                        Exit Sub
                    End If
                End If
            Next
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

    Private Sub 启动器_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        彩蛋码 += 右(e.KeyCode.ToString, 1).ToLower
        彩蛋码 = 右(彩蛋码, 30)
        Dim i As Integer, lc As List(Of Label), l As Label, c As Integer
        If 彩蛋码.EndsWith("steam") AndAlso 只做一次(3156) Then
            c = 100
            lc = New List(Of Label)
            For i = 0 To c
                l = New Label
                l.Text = "-" & 随机.整数(5, 99) & "%"
                l.Font = New Font("Arial", 随机.整数(15, 50))
                l.BackColor = Color.FromArgb(76, 107, 34)
                l.ForeColor = Color.FromArgb(164, 208, 7)
                l.AutoSize = True
                l.Location = New Drawing.Point(随机.整数(-20, Width - 100), 随机.整数(0, -5000))
                Controls.Add(l)
                lc.Add(l)
                l.BringToFront()
            Next
            Dim nt As New Forms.Timer
            nt.Interval = 15
            AddHandler nt.Tick, Sub()
                                    Dim done As Boolean = True
                                    For Each l In lc
                                        l.Top += 8
                                        If l.Top < Height + 100 Then done = False
                                    Next
                                    If done Then
                                        For i = 0 To c
                                            lc.First.Dispose()
                                        Next
                                        nt.Dispose()
                                    End If
                                End Sub
            nt.Enabled = True
        ElseIf 彩蛋码.EndsWith("stcn") AndAlso 只做一次(2157) Then
            Process.Start("https://steamcn.com/suid-581001")
        ElseIf 彩蛋码.EndsWith("2233") AndAlso 只做一次(2354) Then
            Process.Start("https://wx4.sinaimg.cn/large/aa1dc371gy1fvaj53qa1kj22rb1uo4qs.jpg")
        End If
    End Sub

    Private Sub AutoSave_Tick(sender As Object, e As EventArgs) Handles AutoSave.Tick
        设置.保存到本地()
    End Sub

    Private Sub TimerC_Tick() Handles TimerC.Tick
        If 已退出 Then Exit Sub
        TimerC.Enabled = True
        Dim u As Long = 原时长 + Abs(DateDiff(DateInterval.Second, Now, 开始时间))
        Dim s As String = "你已用本软件：" + 时间文字(u) + " " + 括(u.ToString + "s")
        LabTime.Text = s
        s = ""
        For Each t As 工具 In 工具列表
            If t.推送.Length > 0 Then s += t.推送 + vbCrLf
        Next
        s = 去右(s, 2)
        If s <> TxtUpdate.Text Then TxtUpdate.Text = s
        If s.Length > 50 Then s = 左(s, 50) + "..."
        Nico.Text = "走過去的工具箱" + vbCrLf + s
    End Sub

    Private Sub ButShortCut_Click(sender As Object, e As EventArgs) Handles ButShortCut.Click
        Process.Start("https://s1.ax1x.com/2018/09/09/iiRZBq.png")
    End Sub

End Class

