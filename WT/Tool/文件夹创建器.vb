
Public Class 文件夹创建器

    Private Sub ButCreate_Click(sender As Object, e As EventArgs) Handles ButCreate.Click
        Dim i As String = TxtPath.Text, out As String = ""
        ButOpen.Visible = False
        If i.Length < 4 OrElse i(1) <> ":" Then
            out = "输入错误"
        ElseIf 文件夹存在(i) Then
            out = "文件夹已经存在"
            ButOpen.Tag = i
            ButOpen.Visible = True
        Else
            Try
                Directory.CreateDirectory(i)
                If 文件夹存在(i) Then out = "成功创建"
                ButOpen.Tag = i
                ButOpen.Visible = True
            Catch ex As Exception
                out = "创建失败：" + ex.Message
            End Try
        End If
        LabOut.Text = out
    End Sub

    Private Sub 文件夹创建器_Load(sender As Object, e As EventArgs) Handles Me.Load
        LabOut.Text = ""
        TxtPath.Text = 设置.元素("MKDIRpath")
    End Sub

    Private Sub ButOpen_Click(sender As Object, e As EventArgs) Handles ButOpen.Click
        Dim i As String = 追加斜杠(ButOpen.Tag)
        If 文件夹存在(i) Then
            Process.Start(i)
        Else
            ButOpen.Tag = ""
            ButOpen.Visible = False
            LabOut.Text = "文件夹已经被删除"
        End If
    End Sub

    Private Sub TxtPath_TextChanged(sender As Object, e As EventArgs) Handles TxtPath.TextChanged
        设置.保存元素("MKDIRpath", TxtPath.Text)
    End Sub

    Private Sub TxtPath_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtPath.KeyUp
        If e.KeyCode = Keys.Enter Then
            ButCreate.PerformClick()
        End If
    End Sub

End Class
