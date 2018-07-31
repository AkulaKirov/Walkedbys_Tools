Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim ex As Exception = e.Exception
            MsgBox(ex.StackTrace + vbCrLf + ex.Message, MsgBoxStyle.Exclamation, "有东西出错！截图给我看一下？")
        End Sub

    End Class

End Namespace
