
Public Class 信息修改器

    Dim 备份 As String

    Private Sub 信息修改器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not 在列表(启动参数, "-tryfix") Then
            报错退出("非法的操作！必须退出！")
        End If
        备份 = 设置.全文本
        刷新列表()
    End Sub

    Private Sub ListT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListT.SelectedIndexChanged
        TxtInfo.Text = ""
        Dim i As Integer = ListT.SelectedIndex
        If i < 0 Then Exit Sub
        TxtInfo.Text = 设置.元素(ListT.Items.Item(i))
    End Sub

    Private Sub ButSave_Click(sender As Object, e As EventArgs) Handles ButSave.Click
        Dim i As Integer = ListT.SelectedIndex
        If i < 0 Then Exit Sub
        设置.元素(ListT.Items.Item(i)) = TxtInfo.Text
    End Sub

    Private Sub ButBack_Click(sender As Object, e As EventArgs) Handles ButBack.Click
        设置.全文本 = 备份
        TxtInfo.Text = ""
        刷新列表()
    End Sub

    Sub 刷新列表()
        ListT.Items.Clear()
        For Each i As String In 设置.元素列表
            ListT.Items.Add(i)
        Next
    End Sub

End Class