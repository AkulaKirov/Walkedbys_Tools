Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            For Each i As String In e.CommandLine
                启动参数.Add(i)
            Next
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim ex As Exception = e.Exception
            Dim s As String = ex.StackTrace + vbCrLf + ex.Message
            PRT(s)
            MsgBox(s, MsgBoxStyle.Exclamation, "有东西出错！截图给我看一下？")
        End Sub

    End Class

End Namespace
