Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            随机.刷新()
            线程越界()
            Dim i As String
            i = 程序文件目录.ToLower
            If 全部包含(i, "c:\users", "\appdata\", "\temp\") Then 报错退出("对不起，请不要把本程序在压缩包内直接打开。")
            If 版本转小数(Environment.OSVersion.Version) < 6.09 Then 报错退出("对不起，本程序不支持低于 Windows 7 的系统。")
            i = Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full", "Release", "")
            If Val(i) < 460000 Then 报错退出("对不起，请安装 .NET Framework 4.7 或以上版本。")
            i = 程序文件名
            If i <> "wt" Then 报错退出("对不起，你不能乱修改文件。
请尝试重新安装本程序。")
            If Process.GetProcessesByName("wt").Count > 1 Then 报错退出("对不起，本程序不能多开。
或者请把其他名为 wt 的进程退出。")
            For Each i In e.CommandLine
                启动参数.Add(i.ToLower)
            Next
            i = 程序文件目录() + "wt_save."
            Dim b As Boolean = 文件存在(i + "xml")
            设置.本地文件 = i + IIf(b, "xml", "wbxml")
            设置.从本地读取()
            If Not 文件存在(设置.本地文件) Then 启动参数.Add("-firsttime")
            设置.本地文件 = i + "wbxml"
            删除(i + "xml")
            If 在列表(启动参数, "-firsttime") Then
                Dim n As MsgBoxResult
                n = MsgBox("你想在桌面上建立本程序的快捷方式吗？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "欢迎使用走過去的工具箱~")
                If n = MsgBoxResult.Yes Then 程序设置.ButCreateSC_Click()
            End If
            开始时间 = Now
            If 在列表(启动参数, "-tryfix") Then
                新工具("信息修改器", 信息修改器, "TryFix", "设置保存信息的修改器。")
            End If
            新工具(" 工具箱设置", 程序设置, "AllSettings", "关于本工具箱的一些设置。")
            新工具("文件夹创建器", 文件夹创建器, "MKDIR", "输入一个路径，就能新建好你要的文件夹。")
            新工具("B站图床", B站图床, "BilibiliPic", "把20MB以下的图片无损放到B站服务器还行。")
            新工具("日子提醒器", 日子提醒, "DayReminder", "提醒生日或者重要的啥日子。", True)
            新工具("监视式VMT生成器", VMT生成器, "VMTG", "给一个贴图文件夹监视式地批量生成 VMT 文件。")
            新工具("系统代理设置", 系统代理设置, "ProxyManager", "快速设置系统代理。")
            新工具("GMod模组发布器", GM模组发布器, "GMAddonPu", "打包GMA文件，发布或更新 Addon 到 Garry's Mod Workshop。")
            新工具("未响应图片制作器", 未响应图片制作器, "NoResPic", "制作假装程序未响应的假图片。")
            新工具("文件筛选", 文件筛选, "FileChoose", "把A文件夹B文件夹的文件选择性的复制到C文件夹。")
            新工具("Workshop物品篡改器", 创意工坊篡改器, "WorkshopCut", "可以直接修改 Steam Workshop 指定物品的信息，但是你必须是这个物品的上传者或贡献者。")
            '新工具("临时工具", 临时工具, "Whatever", "临时用的工具，你不应该在公开发布版里面看见我。")
            新工具("剪贴板记录器", 剪贴板记录器, "clipboardrecord", "在后台记录剪贴板的内容到硬盘里。", True)
            新工具("模型贴图打包器", 起源模型贴图打包器, "sourcemodelpacker", "给 Source 的模型文件批量打包贴图文件。")
            新工具("RunSringLUA制作器", RunStringLUA制作器, "runstringlua", "算是给 GMod LUA 加密？")
            新工具("B站催更器", B站催更器, "BilibiliPushYou", "会提醒你B站多久没更视频的一个工具。")
            新工具("B站实时最大AV", B站AV变化, "BilibiliAV", "直观地显示一下B站各分区的最大AV号的实时情况。")
            新工具("随机生成器", 随机生成器, "RandomG", "随机生成中英文句子或者数字等。")
            新工具("网络检测", 网络检测, "NetTest", "如果你觉得你的网络不正常可以一直看着这个。")
            新工具("字符画图片制作", 字符画图片制作, "CharPic", "用字符画表示图片。")
            新工具("有没有少Steam好友", Steam好友列表检查, "steamfriends", "检查你的Steam好友列表是不是少人了。")
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim ex As Exception = e.Exception
            Dim s As String = ex.StackTrace + vbCrLf + ex.Message
            报错退出(s)
        End Sub

    End Class

End Namespace
