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
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim ex As Exception = e.Exception
            Dim s As String = ex.StackTrace + vbCrLf + ex.Message
            报错退出(s)
        End Sub

        Sub 报错退出(s As String)
            MsgBox(s, MsgBoxStyle.Exclamation, "有东西出错！")
            Try
                启动器.Nico.Visible = False
                删除(TempF)
            Catch ex As Exception
            End Try
            End
        End Sub

    End Class

End Namespace
