
Module 控件优化

    Private dpi As Single = 0

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
                                           sender.Text = 追加斜杠(m)
                                           Exit For
                                       Next
                                       sender.SelectionStart = sender.TextLength
                                   End Sub
            AddHandler i.TextChanged, Sub()
                                          Dim s As String = 追加斜杠(i.Text)
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

    ''' <summary>
    ''' 确定这些文本框都有文字而不是空的
    ''' </summary>
    Public Function 文本框都有字(ParamArray t() As TextBox) As Boolean
        For Each i As TextBox In t
            If i.TextLength < 1 Then Return False
        Next
        Return True
    End Function

    ''' <summary>
    ''' 把textbox的文字有改变的时候，自动拖动文本框的滚动条到末尾
    ''' </summary>
    Public Sub 文本框自动拖到最后(ParamArray t() As TextBox)
        For Each i As TextBox In t
            AddHandler i.TextChanged, Sub()
                                          i.SelectionStart = i.TextLength
                                          i.ScrollToCaret()
                                      End Sub
        Next
    End Sub

    ''' <summary>
    ''' 获得控件的小写名字
    ''' </summary>
    Public Function 控件类型(i As Control) As String
        Return 去除(i.GetType.ToString, "System.Windows.Forms.").ToLower
    End Function

    ''' <summary>
    ''' 获得系统屏幕显示的DPI
    ''' </summary>
    Public Function 系统DPI() As Single
        If dpi > 0 Then Return dpi
        Dim n As Integer = Registry.GetValue("HKEY_CURRENT_USER\Control Panel\Desktop\WindowMetrics", "AppliedDPI", 100)
        For i As Integer = 50 To 600 Step 25
            If Abs(i - n) < 12.5 Then
                n = i
                Exit For
            End If
        Next
        dpi = n / 100
        Return dpi
    End Function

    ''' <summary>
    ''' 根据系统的DPI对控件进行缩放
    ''' </summary>
    Public Sub 控件DPI修正(f As Control)
        Dim d As Single = 系统DPI()
        If d = 1 Then Exit Sub
        Dim b As Boolean = True, s As String = 控件类型(f)
        If s = "label" Then
            Dim l As Label = f
            If l.AutoSize Then
                b = False
            End If
        End If
        If b Then
            f.Height *= d
            f.Width *= d
        End If
        If Not s.StartsWith(My.Application.Info.AssemblyName.ToLower + ".") Then
            f.Left *= d
            f.Top *= d
        End If
        If f.HasChildren Then
            For Each n As Control In f.Controls
                控件DPI修正(n)
            Next
        End If
    End Sub

End Module