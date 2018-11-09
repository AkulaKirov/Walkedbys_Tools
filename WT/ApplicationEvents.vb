Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim i As String
            i = 程序文件名
            If i <> "wt" Then 报错退出("对不起，你不能乱修改文件。
请尝试重新安装本程序。")
            If Process.GetProcessesByName("wt").Count > 1 Then 报错退出("对不起，本程序不能多开。
或者请把其他名为 wt 的进程退出。")
            i = 程序文件目录.ToLower
            If 全部包含(i, "c:\users", "\appdata\", "\temp\") Then
                报错退出("对不起，请不要把本程序在压缩包内直接打开。")
            ElseIf i.EndsWith("\desktop\") Then
                报错退出("对不起，为了桌面的美观，请不要在桌面直接运行本程序。")
            End If
            If 版本转小数(Environment.OSVersion.Version) < 6.09 Then
                报错退出("对不起，本程序不支持低于 Windows 7 Service Pack 1 的系统。")
            End If
            i = Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full", "Release", "")
            If Val(i) < 460000 Then
                MsgBox("你的 .NET Framework 虽然已经达到了运行程序的要求，
但是要完美运行本程序，
请安装 .NET Framework 4.7 或以上版本。
如果你不安装，每次开启本程序时都会弹出本提示。", MsgBoxStyle.Information, "出错！走過去的工具箱 v" + 版本.ToString)
            End If
            For Each i In e.CommandLine
                启动参数.Add(i.ToLower)
            Next
            i = 程序文件目录() + "wt.wbc"
            If Not 文件存在(i) Then
                i = 程序文件目录() + "wt_save.wbxml"
                If Not 文件存在(i) Then
                    i = 程序文件目录() + "wt_save.xml"
                    If Not 文件存在(i) Then
                        启动参数.Add("-firsttime")
                        i = 程序文件目录() + "wt.wbc"
                    End If
                End If
            End If
            设置 = New WBC文件(i)
            If i.EndsWith("wbc") = False Then
                删除(i)
                设置.本地文件 = 程序文件目录() + "wt.wbc"
                设置.保存到本地()
            End If
            If 在列表(启动参数, "-firsttime") Then
                Dim n As MsgBoxResult
                n = MsgBox("你想在桌面上建立本程序的快捷方式吗？", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "欢迎使用走過去的工具箱~")
                If n = MsgBoxResult.Yes Then 程序设置.创建桌面快捷方式()
            End If
            线程越界()
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim ex As Exception = e.Exception
            Dim s As String = ex.StackTrace + vbCrLf + ex.Message
            报错退出(s)
        End Sub

    End Class

End Namespace
