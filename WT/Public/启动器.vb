
Public Class 启动器

    Dim 关于链接 As New List(Of LinkLabel)
    Dim 彩蛋码 As String
    Dim 时长 As Long

    Private Sub 启动器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        随机.刷新()
        Icon = 图标
        Text = "走過去的工具箱 测试版 v" + 版本.ToString
        Nico.Icon = 图标
        控件DPI修正(Me)
        Directory.CreateDirectory(缓存目录)
        Dim t As 工具, g As String, i As Integer
        If 在列表(启动参数, "-tryfix") Then
            新工具(" 内部信息修改器", 信息修改器, "TryFix", "程序设置实际保存信息的修改器")
        End If
        CtrlW关闭(Me)
        i = 10 * 系统DPI()
        GBpush.Height = GBabout.Top - i - GBpush.Top
        GBupdate.Top = -1000
        If 程序运行中("VBCSCompiler") AndAlso 程序运行中("devenv") Then 新工具("临时工具", 临时工具, "Whatever", "临时用的工具，一般是拿来测试的，如果你运行了 Visual Studio 的话，我就会显示在这里。")
        新工具(" 工具箱设置", 程序设置, "AllSettings", "关于本工具箱的一些设置")
        新工具("B站图床", B站图床, "BilibiliPic", "把20MB以下的图片无损放到B站服务器还行")
        新工具("日子提醒器", 日子提醒, "DayReminder", "提醒生日或者重要的啥日子", True)
        新工具("监视式VMT生成器", VMT生成器, "VMTG", "给一个贴图文件夹监视式地批量生成 VMT 文件")
        新工具("系统代理设置", 系统代理设置, "ProxyManager", "快速设置系统代理")
        新工具("GMod模组发布器", GM模组发布器, "GMAddonPu", "打包GMA文件，发布或更新 Addon 到 Garry's Mod Workshop")
        新工具("未响应图片制作器", 未响应图片制作器, "NoResPic", "制作假装程序未响应的假图片")
        新工具("文件筛选", 文件筛选, "FileChoose", "把A文件夹B文件夹的文件选择性的复制到C文件夹")
        新工具("创意工坊物品篡改器", 创意工坊篡改器, "WorkshopCut", "可以直接修改 Steam Workshop 指定物品的信息，但是你必须是这个物品的上传者或贡献者")
        新工具("剪贴板记录器", 剪贴板记录器, "ClipBoardRecord", "在后台记录剪贴板的内容到硬盘里", Val(设置.元素("CBwhen")) <> 2)
        新工具("模型贴图打包器", 起源模型贴图打包器, "SourceModelPacker", "给 Source 的模型文件批量打包贴图文件")
        新工具("RunSringLUA制作器", RunStringLUA制作器, "RunStringLua", "算是给 GMod LUA 加密？")
        新工具("B站催更器", B站催更器, "BilibiliPushYou", "会提醒你B站多久没更视频的一个工具", 设置.读取真假("CheckBilibiliAtStart"))
        新工具("随机生成器", 随机生成器, "RandomG", "随机生成中英文句子或者数字等")
        新工具("网络检测", 网络检测, "NetTest", "如果你觉得你的网络不正常可以一直看着这个")
        新工具("字符画图片制作", 字符画图片制作, "CharPic", "用字符画表示图片")
        新工具("有没有少Steam好友", Steam好友列表检查, "SteamFriends", "检查你的Steam好友里是不是有人把你删了", 设置.读取真假("CheckSteamFriendsAtStart"))
        新工具("创意工坊物品列表导出", 创意工坊订阅列表导出, "WorkshopListOut", "把你的workshop订阅的或者是收藏夹里的或者是你发布的或者合集里的物品都导出成一个列表")
        新工具("创意工坊合集物品批量添加", 创意工坊合集物品批量添加, "WorkshopCollectionAdd", "可以先用Workshop物品列表导出工具导出物品列表，然后在这里导入到指定的合集。")
        新工具("输入法辅助框", 输入法辅助框, "InputHelper", "在临时窗口上打字来避免一些垃圾软件对输入法的不支持。", Val(设置.元素("IMEwhen")) <> 2)
        AddHandler SizeChanged, AddressOf 最小化隐藏
        For Each t In 工具列表
            ListTools.Items.Add(t.名字)
        Next
        新增关于链接("博客", "https://walkedby.com/wt")
        新增关于链接("下载最新版", "https://github.com/gordonwalkedby/Walkedbys_Tools/releases")
        新增关于链接("请我喝好的", "https://walkedby.com/donateme/")
        新增关于链接("反馈", "https://github.com/gordonwalkedby/Walkedbys_Tools/issues")
        For Each g In 分割(设置.元素("HistoryTool"), vbCrLf)
            t = 名字工具(g)
            If Not IsNothing(t) Then 最后使用的工具.Add(t)
        Next
        GBallTools.Text += 括((ListTools.Items.Count - 1).ToString)
        时长 = 设置.读取数("OpenTime")
        TimerC_Tick()
        TimerC.Enabled = True
        If Not 设置.读取真假("NoUpdateAtMain") Then
            新线程(Sub()
                    Dim h As New 简易HTTP("https://raw.githubusercontent.com/gordonwalkedby/Walkedbys_Tools/master/WT/updater.xml")
                    Dim o As String = h.获得回应
                    If o.Length > 50 AndAlso 全部包含(o, "<version>", "<note>这是一个检查更新版本用的 XML 文件。</note>", "</info>", "<v012>") Then
                        Dim nv As New Version(提取(o, "<version>", "</version>"))
                        If nv > My.Application.Info.Version Then
                            GBupdate.Top = GBabout.Top - 10 - GBupdate.Height
                            GBpush.Height = GBupdate.Top - 10 - GBpush.Top
                            GBupdate.Text = "检测到新版本：v" + nv.ToString
                            o = o.Replace("- ", vbCrLf + "●")
                            TxtUpdate.Text = "更新内容：" + 提取(o, "<info>", "</info>")
                        Else
                            o = "已是最新版本：v" + nv.ToString
                            GBabout.Text += 括(o, "（）")
                        End If
                    Else
                        GBabout.Text += "（检查更新失败）"
                    End If
                End Sub)
        End If
        彩蛋码 = ""
        LabFun.Text = 随机.多选一("w",
"8848 钛金显卡~",
"真高兴我的计算机几乎都不是学校教的。",
"风水轮流转。",
"要试试直接对着我输入 " + 随机.多选一("steam", "stcn", "2233", "cat") + " 吗？",
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
"Turn down for what!",
"男友可有钱了，就是希望他智商和修养也能和他的余额一样高。",
"美国圣地亚戈国际农业集团总裁——威廉伯爵，享有与美国总统同等的荣誉。",
"一个比一个干净，反过来看，一个比一个肮脏。",
"你喜欢聊天吗w",
"我也想做合法的事情，如果合法手段有用的话。",
"我很不敢相信，有的人碰过智能手机，没有碰过电脑的鼠标键盘。",
"sv_cheats 1",
"v0.9以下的版本碰见v0.10就会识别成v0.1，然后一直：已是最新版本。",
"戈登~戈登~戈登登~",
"我的steam 50级了，不知道什么时候才100级。",
"刷Q币吗？100元10个！刷不到三倍包赔！",
"上千的手机有什么好买的？给我400元我给你买个iPhone5用用。",
"av87519",
"好的评价都是主观的，但不代表我的观点你就必须要认同，你完全可以保留自己的观点。——黑镖客梦回",
"凡是要考试的，我基本上都做的很糟糕，然后很伤心。因为，有人和我竞争，有人比我好。"
).ToString
        Refresh()
        AutoSave.Enabled = True
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
        AutoSave_Tick(Nothing, Nothing)
        Nico.Visible = False
        For Each t As Thread In 多线程
            中断线程(t)
        Next
        For Each n As 工具 In 工具列表
            If n.启动过了 Then n.窗体.Dispose()
        Next
        设置.保存到本地()
        删除(缓存目录)
        End
    End Sub

    Private Sub ListTools_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTools.SelectedIndexChanged
        Dim i As Integer = ListTools.SelectedIndex
        If i < 0 Then Exit Sub
        Dim t As 工具 = 名字工具(ListTools.SelectedItem.ToString)
        TxtToolInfo.Text = t.简介
        TxtToolName.Text = t.名字
        ButOpenTool.Enabled = True
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

    Sub 新增关于链接(文字 As String, 链接 As String)
        Dim m As New LinkLabel
        GBabout.Controls.Add(m)
        With m
            .Top = LabAbout.Bottom + 5
            If 关于链接.Count = 0 Then
                .Left = 6 * 系统DPI()
            Else
                .Left = 关于链接.Last.Right + 6 * 系统DPI()
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
        Dim i As Image = My.Resources.head
        Dim b As Single = 0.4 * 系统DPI()
        With GBabout
            e.Graphics.DrawImage(i, .Width - i.Width * b, .Height - i.Height * b, i.Width * b, i.Height * b)
        End With
    End Sub

    Private Sub Nico_MouseUp(sender As Object, e As MouseEventArgs) Handles Nico.MouseUp
        If e.Button = MouseButtons.Left Then
            显示到前台(最后窗体)
        End If
    End Sub

    Private Sub NicoMenu_Opening() Handles NicoMenu.Opening
        Dim i As ToolStripMenuItem
        NicoMenu.Items.Clear()
        Dim f As Integer = 0, n As Integer, t As 工具
        For n = 最后使用的工具.Count - 1 To 0 Step -1
            f += 1
            t = 最后使用的工具.Item(n)
            i = New ToolStripMenuItem
            With i
                .Text = t.名字
                AddHandler i.Click, Sub(sender As Object, e As EventArgs)
                                        显示到前台(最后窗体)
                                        名字工具(sender.text).启动()
                                    End Sub
            End With
            NicoMenu.Items.Add(i)
            If f >= 5 Then Exit For
        Next
        If NicoMenu.Items.Count > 0 Then NicoMenu.Items.Add(New ToolStripSeparator)
        i = New ToolStripMenuItem
        With i
            .Text = "显示窗口"
            AddHandler i.Click, Sub()
                                    显示到前台(最后窗体)
                                End Sub
        End With
        NicoMenu.Items.Add(i)
        i = New ToolStripMenuItem
        With i
            .Text = "返回主页"
            AddHandler i.Click, Sub()
                                    If Not 最后窗体.Equals(Me) Then 最后窗体.Close()
                                    显示到前台(最后窗体)
                                End Sub
        End With
        NicoMenu.Items.Add(i)
        NicoMenu.Items.Add(New ToolStripSeparator)
        i = New ToolStripMenuItem
        With i
            .Text = "退出"
            AddHandler i.Click, Sub()
                                    退出()
                                End Sub
        End With
        NicoMenu.Items.Add(i)
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
        ElseIf 彩蛋码.EndsWith("cat") AndAlso 只做一次(2358) Then
            Process.Start("https://bongo.cat/")
        End If
    End Sub

    Private Sub AutoSave_Tick(sender As Object, e As EventArgs) Handles AutoSave.Tick
        设置.元素("OpenTime") = 时长
        设置.元素("HistoryTool") = 列表转文字(最后使用的工具)
        设置.保存到本地()
    End Sub

    Private Sub TimerC_Tick() Handles TimerC.Tick
        时长 += 1
        Dim s As String = "你已用本软件：" + 时间文字(时长) + " " + 括(时长.ToString + "s")
        LabTime.Text = s
        s = ""
        For Each t As 工具 In 工具列表
            If t.推送.Length > 0 Then s += t.推送 + vbCrLf
        Next
        s = 去右(s, 2)
        If s <> TxtPush.Text Then TxtPush.Text = s
        If s.Length > 50 Then s = 左(s, 50) + "..."
        Nico.Text = "走過去的工具箱" + vbCrLf + s
    End Sub

End Class
