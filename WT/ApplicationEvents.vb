Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim i As String = Process.GetCurrentProcess.ProcessName.ToLower
            If i <> "wt" Then 报错退出("对不起，你不能乱修改文件。
请尝试重新安装本程序~")
            If Process.GetProcessesByName("wt").Count > 1 Then
                报错退出("对不起，本程序不能多开。
或者请把其他名为 wt 的进程退出。")
            End If
            For Each i In e.CommandLine
                启动参数.Add(i)
            Next
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim ex As Exception = e.Exception
            Dim s As String = ex.StackTrace + vbCrLf + ex.Message
            报错退出(s)
        End Sub

        Sub 报错退出(s As String)
            MsgBox(s, MsgBoxStyle.Exclamation, "有东西出错！")
            End
        End Sub

    End Class

End Namespace
