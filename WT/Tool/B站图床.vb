Imports System.ComponentModel

Public Class B站图床

    Dim TH As Thread
    Dim 上传中 As Boolean = False
    Dim 图片 As String = ""
    Dim 预览图 As Image

    Private Sub B站图床_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabDoit.Tag = LabDoit.Text
    End Sub

    Private Sub B站图床_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        If 上传中 Then Exit Sub
        For Each m As String In e.Data.GetData(DataFormats.FileDrop)
            检查图片(m)
            Exit For
        Next
    End Sub

    Sub 检查图片(m As String)
        预览图 = Nothing
        Dim i As New 文件(m)
        If i.存在 AndAlso i.可用 AndAlso 是当中一个(i.后缀, "jpg", "png", "gif") AndAlso i.大小 < 20 Then
            LabDoit.Text = "上传中：" + vbCrLf + m
            图片 = m
            预览图 = i.转图片
            Refresh()
            TH = New Thread(AddressOf 上传图片)
            TH.Start()
            LabDoit.BringToFront()
        Else
            LabDoit.Text = "对不起，文件不合适。" + vbCrLf + m
        End If
        PicBox.Image = 预览图
    End Sub

    Sub 上传图片()
        上传中 = True
        ButCopy.Enabled = False
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
        Else
            LabDoit.Text = "失败！" + vbCrLf + s
        End If
        上传中 = False
        ButCopy.Enabled = True
        ButPaste.Enabled = True
    End Sub

    Private Sub B站图床_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        e.Effect = DragDropEffects.Link
    End Sub

    Private Sub B站图床_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        中断线程(TH)
        LabDoit.Text = LabDoit.Tag
    End Sub

    Private Sub ButCopy_Click(sender As Object, e As EventArgs) Handles ButCopy.Click
        Clipboard.SetText(LabDoit.Text)
    End Sub

    Private Sub ButPaste_Click(sender As Object, e As EventArgs) Handles ButPaste.Click
        Dim m As Image = Clipboard.GetImage
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

End Class