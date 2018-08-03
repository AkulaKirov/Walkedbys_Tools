
Module 控件优化

    ''' <summary>
    ''' 把这个窗体里的文本框都设置 ctrl+a 全选
    ''' </summary>
    ''' <param name="窗体"></param>
    Public Sub 文本框全选(窗体 As Form)
        For Each i As Control In 窗体.Controls
            If i.GetType.Equals((New TextBox).GetType) Then
                AddHandler i.KeyUp, Sub(sender As TextBox, e As KeyEventArgs)
                                        If e.Control AndAlso e.KeyCode = Keys.A Then sender.SelectAll()
                                    End Sub
            End If
        Next
    End Sub

    ''' <summary>
    ''' 使文本框支持拖入一个文件或文件夹
    ''' </summary>
    Public Sub 文本框拖入文件(ParamArray 文本框() As TextBox)
        For Each i As TextBox In 文本框
            i.AllowDrop = True
            AddHandler i.DragEnter, Sub(sender As TextBox, e As DragEventArgs)
                                        e.Effect = DragDropEffects.Link
                                    End Sub
            AddHandler i.DragDrop, Sub(sender As TextBox, e As DragEventArgs)
                                       For Each m As String In e.Data.GetData(DataFormats.FileDrop)
                                           sender.Text = m
                                           Exit For
                                       Next
                                       sender.SelectionStart = sender.TextLength
                                   End Sub
        Next
    End Sub

    ''' <summary>
    ''' 把这个 ListBox 的指定index的一项移除，并且向前选中一个
    ''' </summary>
    Public Sub 移除选中项(组 As ListBox)
        移除选中项s(组)
    End Sub

    ''' <summary>
    ''' 把这个 ComboBox 的指定index的一项移除，并且向前选中一个
    ''' </summary>
    Public Sub 移除选中项(组 As ComboBox)
        移除选中项s(组)
    End Sub

    Private Sub 移除选中项s(组 As Object)
        Dim index As Integer = 组.SelectedIndex
        If 组.items.count < 1 Then Exit Sub
        组.Items.RemoveAt(Index)
        Index -= 1
        If Index < 0 Then Index = 0
        Dim c As Integer = 组.Items.Count
        If c > 0 Then
            If c > Index Then
                组.SelectedIndex = Index
            Else
                组.SelectedIndex = c - 1
            End If
        End If
    End Sub

End Module