Public Class 批量复制文件

    Private Sub 批量复制文件_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        文字转列表(ListFrom.Items, 设置.字符串("CopyMuchFrom"))
        文字转列表(ListTo.Items, 设置.字符串("CopyMuchTo"))
        批量复制文件_Activated(sender, e)
    End Sub

    Private Sub 批量复制文件_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim i As String, f As New List(Of String)
        For Each i In ListTo.Items
            If 文件夹存在(i) = False Then f.Add(i)
        Next
        For Each i In f
            ListTo.Items.Remove(i)
        Next
        f.Clear()
        For Each i In ListFrom.Items
            If (文件夹存在(i) OrElse 文件存在(i)) = False Then f.Add(i)
        Next
        For Each i In f
            ListFrom.Items.Remove(i)
        Next
    End Sub

    Private Sub ListFrom_DragEnter(sender As Object, e As Forms.DragEventArgs) Handles ListFrom.DragEnter, ListTo.DragEnter
        e.Effect = Forms.DragDropEffects.Link
    End Sub

    Private Sub 批量复制文件_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.字符串("CopyMuchTo") = 列表转文字(ListTo.Items)
        设置.字符串("CopyMuchFrom") = 列表转文字(ListFrom.Items)
    End Sub

    Private Sub ButStart_Click(sender As Object, e As EventArgs) Handles ButStart.Click
        LabDone.Visible = False
        列表去重(ListFrom.Items)
        列表去重(ListTo.Items)
        Dim i As String, i2 As String
        For Each i In ListFrom.Items
            If 文件存在(i) Then
                For Each i2 In ListTo.Items
                    Try
                        My.Computer.FileSystem.CopyFile(i, i2 + 文件名(i, True), True)
                    Catch ex As Exception
                        Dp("复制文件出错：", ex.Message)
                    End Try
                Next
            End If
            If 文件夹存在(i) Then
                For Each i2 In ListTo.Items
                    Try
                        My.Computer.FileSystem.CopyDirectory(i, i2 + 文件名(i, True), True)
                    Catch ex As Exception
                        Dp("复制文件夹出错：", ex.Message)
                    End Try
                Next
            End If
        Next
        LabDone.Visible = True
    End Sub

    Private Sub ButClear_Click(sender As Object, e As EventArgs) Handles ButClear.Click
        ListFrom.Items.Clear()
        ListTo.Items.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ButStart.Enabled = (ListFrom.Items.Count > 0 AndAlso ListTo.Items.Count > 0)
    End Sub

    Private Sub ListTo_DragDrop(sender As Object, e As Forms.DragEventArgs) Handles ListTo.DragDrop
        For Each m As String In e.Data.GetData(Forms.DataFormats.FileDrop)
            If 文件夹存在(m) Then
                ListTo.Items.Add(追加斜杠(m))
            End If
        Next
    End Sub

    Private Sub ListFrom_DragDrop(sender As Object, e As Forms.DragEventArgs) Handles ListFrom.DragDrop
        For Each m As String In e.Data.GetData(Forms.DataFormats.FileDrop)
            If 文件夹存在(m) Then
                ListFrom.Items.Add(追加斜杠(m))
            End If
            If 文件存在(m) Then
                ListFrom.Items.Add(m)
            End If
        Next
    End Sub

End Class