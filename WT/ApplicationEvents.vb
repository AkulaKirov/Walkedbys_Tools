Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            随机.刷新()
            Dim i As String
            For Each i In e.CommandLine
                启动参数.Add(i.ToLower)
            Next
            i = 程序文件名
            If i <> "wt" Then 报错退出("对不起，你不能乱修改文件。
请尝试重新安装本程序~")
            If Process.GetProcessesByName("wt").Count > 1 Then
                报错退出("对不起，本程序不能多开。
或者请把其他名为 wt 的进程退出。")
            End If
            If (Not 文件存在(设置.本地文件)) OrElse 在列表(启动参数, "-firsttime") Then
                Dim n As MsgBoxResult = MsgBox("你好，程序没有找到你的配置文件。
所以你应该是第一次使用本程序吧。
我们正在使用百度统计来回收各位用户的使用情况，
主要收集的是使用地点、系统、时间等，
你是否同意或希望向我们回传你的使用信息？
你也可以日后在工具箱设置里自行关闭这一项。", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "欢迎使用走過去的工具箱~")
                If n <> MsgBoxResult.Yes Then
                    设置.元素("NoReportBack") = "True"
                End If
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
