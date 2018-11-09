
Public Class 信息修改器

    Dim Ts As WBC文件

    Private Sub 信息修改器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ts = 设置
        刷新列表()
    End Sub

    Private Sub ListT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListT.SelectedIndexChanged
        TxtInfo.Text = ""
        Dim i As Integer = ListT.SelectedIndex
        If i < 0 Then Exit Sub
        TxtInfo.Text = Ts.字符串(ListT.Items(i))
    End Sub

    Private Sub ButSave_Click(sender As Object, e As EventArgs) Handles ButSave.Click
        Dim i As Integer = ListT.SelectedIndex
        If i < 0 Then Exit Sub
        Ts.字符串(ListT.Items(i)) = TxtInfo.Text
    End Sub

    Sub 刷新列表()
        ListT.Items.Clear()
        For Each i As WBC元素 In Ts.元素列表
            ListT.Items.Add(i.名字)
        Next
    End Sub

    Private Sub ButRefresh_Click(sender As Object, e As EventArgs) Handles ButRefresh.Click
        TxtInfo.Text = ""
        刷新列表()
    End Sub

    Private Sub 信息修改器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ButRefresh.PerformClick()
    End Sub

End Class