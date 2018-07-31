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
        TxtPath.Text = 读取("MKDIRpath")
    End Sub

    Private Sub ButOpen_Click(sender As Object, e As EventArgs) Handles ButOpen.Click
        Process.Start(追加斜杠(ButOpen.Tag))
    End Sub

    Private Sub TxtPath_TextChanged(sender As Object, e As EventArgs) Handles TxtPath.TextChanged
        保存("MKDIRpath", TxtPath.Text)
    End Sub

End Class
