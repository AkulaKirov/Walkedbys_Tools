
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
        CheckAuto.Checked = 设置.布林("bilibiliautocopy")
        列表控件选中项(ListBed, 设置.数字("imagebed"))
    End Sub

    Private Sub B站图床_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LabDoit.Text = LabDoit.Tag
        PicBox.Image = Nothing
        ButCopy.Enabled = False
        设置.数字("imagebed") = ListBed.SelectedIndex
        设置.字符串("bilibiliautocopy") = CheckAuto.Checked.ToString
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
        PicBox.Image = Nothing
        If 文件可用(m) AndAlso 是当中一个(文件后缀(m), "jpg", "png", "gif") AndAlso 文件大小(m) < 20 Then
            LabDoit.Text = "上传中：" + vbCrLf + m
            If 文件后缀(m) = "gif" Then
                图片 = 缓存目录 + "bi.gif"
                File.Copy(m, 缓存目录 + "bi.gif", True)
                预览图 = Image.FromFile(m)
            Else
                图片 = m
                预览图 = 读文件为图片(m)
            End If
            Refresh()
            ButPaste.Enabled = False
            Dim s As String = "", succ As Boolean = False
            Select Case ListBed.SelectedIndex
                Case 0
                    Dim h As New 简易HTTP("https://api.vc.bilibili.com/api/v1/image/upload", "POST")
                    Dim r As New 简易MultiPartFormData(h)
                    r.新文件("file_up", 图片, "image/jpeg")
                    r.新参数("biz", "draw")
                    r.新参数("category", "daily")
                    r.结束()
                    s = h.获取回应
                    If 包含(s, "{""code"":0,""message"":""success"",""") Then
                        s = 提取(s, "image_url"":""", """,""image_width")
                        succ = True
                    End If
                Case 1
                    Dim h As New 简易HTTP("http://img.tv.sohu.com/ndfs/uploadPhoto.do?appid=100114&allowGif=1&needCompress=false&isSupportHttps=true", "POST")
                    Dim r As New 简易MultiPartFormData(h)
                    r.新文件("file", 图片, "image/jpeg")
                    r.结束()
                    s = 去除(h.获取回应, 引号)
                    If 全部包含(s, "{height:", ",urlKey:", "url://") Then
                        s = "https://" + 提取(s, ",url://", ",size:")
                        succ = True
                    End If
                Case 2
                    Dim h As New 简易HTTP("https://sm.ms/api/upload", "POST")
                    Dim r As New 简易MultiPartFormData(h)
                    r.新文件("smfile", 图片, "image/jpeg")
                    r.结束()
                    s = 去除(h.获取回应, 引号)
                    If 全部包含(s, "{code:success,data:", "filename:", ",url:http") Then
                        s = "https://" + 提取(s, "url:https://", ",")
                        succ = True
                    End If
            End Select
            If succ Then
                LabDoit.Text = s
                ButCopy.Enabled = True
                If CheckAuto.Checked Then
                    剪贴板.文本 = LabDoit.Text
                End If
            Else
                ButRetry.Enabled = True
                LabDoit.Text = "失败！" + vbCrLf + s
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

    Private Sub ButCopy_Click(sender As Object, e As EventArgs) Handles ButCopy.Click
        剪贴板.文本 = LabDoit.Text
    End Sub

    Private Sub ButPaste_Click(sender As Object, e As EventArgs) Handles ButPaste.Click
        Dim m As Image = 剪贴板.图片
        If IsNothing(m) Then
            LabDoit.Text = "剪贴板里没有图片！"
            ButCopy.Enabled = False
        Else
            Dim i As String = 缓存目录 + "bilibilitemp.png"
            m.Save(i)
            m.Dispose()
            检查图片(i)
        End If
    End Sub

    Private Sub ButRetry_Click(sender As Object, e As EventArgs) Handles ButRetry.Click
        Dim n As Image = PicBox.Image
        Dim i As String = 缓存目录 + "bilibilitemp.png"
        n.Save(i)
        检查图片(i)
    End Sub

    Private Sub LinkSource_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSource.LinkClicked
        Dim i As String
        Select Case ListBed.SelectedIndex
            Case 0
                i = "https://t.bilibili.com/"
            Case 1
                i = "https://fans.tv.sohu.com/i/topic/add"
            Case 2
                i = "https://sm.ms/"
        End Select
        Process.Start(i)
    End Sub

End Class