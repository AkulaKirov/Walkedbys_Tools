
Module 控件优化

    ''' <summary>
    ''' 使文本框支持拖入一个文件或文件夹
    ''' </summary>
    Public Sub 文本框拖入文件(ParamArray 文本框() As TextBox)
        For Each i As TextBox In 文本框
            i.AllowDrop = True
            AddHandler i.DragEnter, Sub(sender As TextBox, e As Forms.DragEventArgs)
                                        e.Effect = Forms.DragDropEffects.Link
                                    End Sub
            AddHandler i.DragDrop, Sub(sender As TextBox, e As Forms.DragEventArgs)
                                       sender.Text = ""
                                       For Each m As String In e.Data.GetData(Forms.DataFormats.FileDrop)
                                           sender.Text = m
                                           Exit For
                                       Next
                                       sender.SelectionStart = sender.TextLength
                                   End Sub
            AddHandler i.TextChanged, Sub()
                                          Dim s As String = Trim(i.Text)
                                          If s.Length < 1 Then Exit Sub
                                          If Not 文件存在(s) Then s = ""
                                          i.Text = s
                                      End Sub
            AddHandler i.FindForm.Activated, Sub()
                                                 Dim s As String = Trim(i.Text)
                                                 If s.Length < 1 Then Exit Sub
                                                 If Not 文件存在(s) Then s = ""
                                                 i.Text = s
                                             End Sub
        Next
    End Sub

    ''' <summary>
    ''' 使文本框支持拖入一个文件或文件夹
    ''' </summary>
    Public Sub 文本框拖入文件夹(ParamArray 文本框() As TextBox)
        For Each i As TextBox In 文本框
            i.AllowDrop = True
            AddHandler i.DragEnter, Sub(sender As TextBox, e As Forms.DragEventArgs)
                                        e.Effect = Forms.DragDropEffects.Link
                                    End Sub
            AddHandler i.DragDrop, Sub(sender As TextBox, e As Forms.DragEventArgs)
                                       sender.Text = ""
                                       For Each m As String In e.Data.GetData(Forms.DataFormats.FileDrop)
                                           sender.Text = m
                                           Exit For
                                       Next
                                       sender.SelectionStart = sender.TextLength
                                   End Sub
            AddHandler i.TextChanged, Sub()
                                          Dim s As String = Trim(i.Text)
                                          If s.Length < 1 Then Exit Sub
                                          If Not 文件夹存在(s) Then s = ""
                                          i.Text = s
                                      End Sub
            AddHandler i.FindForm.Activated, Sub()
                                                 Dim s As String = Trim(i.Text)
                                                 If s.Length < 1 Then Exit Sub
                                                 If Not 文件夹存在(s) Then s = ""
                                                 i.Text = s
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
        组.Items.RemoveAt(index)
        index -= 1
        If index < 0 Then index = 0
        Dim c As Integer = 组.Items.Count
        If c > 0 Then
            If c > index Then
                组.SelectedIndex = index
            Else
                组.SelectedIndex = c - 1
            End If
        End If
    End Sub

End Module