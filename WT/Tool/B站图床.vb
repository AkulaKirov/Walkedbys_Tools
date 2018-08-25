
Public Class B站图床

    Dim 图片 As String = ""
    Dim 预览图 As Image
    Dim 重试 As Boolean = False

    Private Sub B站图床_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabDoit.Tag = LabDoit.Text
        ButPaste.Enabled = True
        ButRetry.Enabled = False
        ButCopy.Enabled = False
        PicBox.Image = Nothing
    End Sub

    Private Sub B站图床_DragDrop(sender As Object, e As Forms.DragEventArgs) Handles Me.DragDrop
        For Each m As String In e.Data.GetData(Forms.DataFormats.FileDrop)
            检查图片(m)
            Exit For
        Next
    End Sub

    Sub 检查图片(m As String)
        ButRetry.Enabled = False
        ButCopy.Enabled = False
        预览图 = Nothing
        If 文件存在(m) AndAlso 文件可读写(m) AndAlso 是当中一个(文件后缀(m), "jpg", "png", "gif") AndAlso 文件大小(m) < 20 Then
            LabDoit.Text = "上传中：" + vbCrLf + m
            图片 = m
            预览图 = 读文件为图片(m)
            Refresh()
            ButPaste.Enabled = False
            Dim h As New 简易HTTP("https://api.vc.bilibili.com/api/v1/image/upload", "POST")
            Dim r As New 简易MultiPartFormData(h)
            r.新文件("file_up", 图片, "image/jpeg")
            r.新参数("biz", "draw")
            r.新参数("category", "daily")
            r.结束()
            Dim s As String = h.获得回应
            If 包含(s, "{""code"":0,""message"":""success"",""") Then
                LabDoit.Text = 提取(s, "image_url"":""", """,""image_width")
                ButCopy.Enabled = True
            Else
                LabDoit.Text = "失败！" + vbCrLf + s
                ButRetry.Enabled = True
            End If
            ButPaste.Enabled = True
            LabDoit.BringToFront()
        Else
            LabDoit.Text = "对不起，文件不合适。" + vbCrLf + m
        End If
        PicBox.Image = 预览图
    End Sub

    Private Sub B站图床_DragEnter(sender As Object, e As Forms.DragEventArgs) Handles Me.DragEnter
        e.Effect = Forms.DragDropEffects.Link
    End Sub

    Private Sub B站图床_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LabDoit.Text = LabDoit.Tag
        PicBox.Image = Nothing
        ButCopy.Enabled = False
    End Sub

    Private Sub ButCopy_Click(sender As Object, e As EventArgs) Handles ButCopy.Click
        Forms.Clipboard.SetText(LabDoit.Text)
    End Sub

    Private Sub ButPaste_Click(sender As Object, e As EventArgs) Handles ButPaste.Click
        Dim m As Image = Forms.Clipboard.GetImage
        If IsNothing(m) Then
            LabDoit.Text = "剪贴板里没有图片！"
        Else
            Try
                Dim i As String = TempF + "bilibilitemp.png"
                m.Save(i)
                m.Dispose()
                检查图片(i)
            Catch ex As Exception
                LabDoit.Text = "剪贴板图片有误：" + vbCrLf + ex.Message
            End Try
        End If
    End Sub

    Private Sub ButRetry_Click(sender As Object, e As EventArgs) Handles ButRetry.Click
        Dim n As Image = PicBox.Image
        Dim i As String = TempF + "bilibilitemp.png"
        n.Save(i)
        检查图片(i)
    End Sub

End Class