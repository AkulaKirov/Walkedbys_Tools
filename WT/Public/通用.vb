
Module 通用

    Friend 工具列表 As New List(Of 工具)
    Friend 设置 As New 简易XML("WT", "", 程序文件目录() + "wt_save.xml")
    Friend TempF As String = 程序文件目录() + "WalkedbysTemps\"
    Friend 图标 As Icon = My.Resources.ico
    Friend 最后窗体 As Form = 启动器
    Friend 启动参数 As New List(Of String)

    Public Function ID工具(id As String) As 工具
        For Each t As 工具 In 工具列表
            If t.ID.ToLower = id.ToLower Then Return t
        Next
        Return Nothing
    End Function

    Public Function 名字工具(名字 As String) As 工具
        For Each t As 工具 In 工具列表
            If 包含(t.名字, 名字) Then Return t
        Next
        Return Nothing
    End Function

    Public Sub 推送(m As String)
        With 启动器.TxtUpdate
            If .TextLength > 1 Then .Text += vbCrLf
            .Text += m
        End With
    End Sub

    Public Sub 最小化隐藏(sender As Object, e As EventArgs)
        If sender.WindowState = FormWindowState.Minimized Then
            sender.WindowState = FormWindowState.Normal
            sender.Hide()
        End If
    End Sub

    Public Class 工具

        Public Property 名字 As String
        Public Property 简介 As String
        Public Property 窗体 As Form
        Public Property ID As String

        Public Sub New(name As String, win As Form, 内部id As String, description As String)
            名字 = name
            窗体 = win
            简介 = description
            ID = 内部id.ToLower
            窗体.Icon = 图标
            窗体.ImeMode = ImeMode.Off
            窗体.ShowInTaskbar = False
            窗体.AutoScaleMode = AutoScaleMode.Dpi
            AddHandler 窗体.FormClosing, Sub(sender As Object, e As FormClosingEventArgs)
                                           e.Cancel = True
                                           窗体.Hide()
                                           启动器.Location = 窗体.Location
                                           启动器.WindowState = FormWindowState.Normal
                                           启动器.Show()
                                           启动器.Location = 窗体.Location
                                           最后窗体 = 启动器
                                       End Sub
            AddHandler 窗体.SizeChanged, AddressOf 最小化隐藏
        End Sub

        Public Sub 启动()
            最后窗体.Hide()
            窗体.Location = 最后窗体.Location
            窗体.Show()
            窗体.Location = 最后窗体.Location
            窗体.WindowState = FormWindowState.Normal
            最后窗体 = 窗体
        End Sub

        Public Overrides Function ToString() As String
            Return ID
        End Function

    End Class

    Public Class 模板组

        Dim g As New List(Of 模板)
        Dim n As String
        Dim 列表 As ComboBox
        Dim 文本框 As TextBox
        Dim 新增按纽 As Button, 移除按纽 As Button, 读取按纽 As Button

        Public Sub New(名字 As String, 列表控件 As ComboBox, 文本控件 As TextBox, 新增 As Button, 移除 As Button, 读取 As Button)
            n = "模板组___" + 名字
            Dim x As New 简易XML(n, 设置.元素(n))
            列表 = 列表控件
            文本框 = 文本控件
            新增按纽 = 新增
            移除按纽 = 移除
            读取按纽 = 读取
            新增按纽.Enabled = False
            移除按纽.Enabled = False
            读取按纽.Enabled = False
            AddHandler 列表.SelectedIndexChanged, AddressOf 刷新
            AddHandler 文本框.TextChanged, Sub()
                                            Dim name As String = Trim(文本框.Text)
                                            新增按纽.Enabled = (name.Length > 0 AndAlso name.Length < 11 AndAlso Not 在列表(列表.Items, name))
                                            刷新()
                                        End Sub
            AddHandler 移除按纽.Click, Sub()
                                       移除列表选中项()
                                       刷新()
                                   End Sub
            AddHandler 移除按纽.FindForm.FormClosing, Sub()
                                                      保存()
                                                  End Sub
            Dim f As List(Of String) = 分割(设置.元素(n + "列表"), vbCrLf)
            列表.Items.Clear()
            Dim t As 模板
            If f.Count > 0 Then
                For Each i As String In f
                    If i.Length > 0 Then
                        t = New 模板(i)
                        t.读取(x.元素(i))
                        g.Add(t)
                    End If

                Next
            End If
            If g.Count > 0 Then
                For Each t In g
                    列表.Items.Add(t.名字)
                Next
            End If
        End Sub

        Private Sub 刷新()
            Dim i As Integer = 列表.SelectedIndex
            Dim b As Boolean = (i > -1)
            移除按纽.Enabled = b
            读取按纽.Enabled = b
        End Sub

        Public Sub 新增(ParamArray s() As 模板)
            Dim i As 模板
            For Each i In s
                g.Add(i)
                列表.Items.Add(i.名字)
                列表.SelectedItem = i.名字
            Next
            文本框.Text = ""
            保存()
        End Sub

        Public Function 读取当前项() As 模板
            If 列表.SelectedIndex < 0 Then Return Nothing
            Dim i As String = 列表.SelectedItem.ToString
            If i.Length < 1 OrElse g.Count < 1 Then Return Nothing
            Dim s As New List(Of 模板), t As 模板
            For Each t In g
                If t.名字 = i Then Return t
            Next
            Return Nothing
        End Function

        Public Sub 移除列表选中项()
            If 列表.SelectedIndex < 0 Then Exit Sub
            Dim i As String = 列表.SelectedItem.ToString
            If i.Length < 1 OrElse g.Count < 1 Then Exit Sub
            Dim s As New List(Of 模板), t As 模板
            For Each t In g
                If t.名字 = i Then s.Add(t)
            Next
            移除选中项(列表)
            For Each t In s
                g.Remove(t)
            Next
            保存()
        End Sub

        Public Overrides Function ToString() As String
            Dim s As String = ""
            If g.Count > 0 Then
                For Each t As 模板 In g
                    s += t.ToString
                Next
            End If
            Return s
        End Function

        Public Sub 保存()
            设置.元素(n + "列表") = 列表转文字(列表.Items)
            设置.元素(n) = ToString()
        End Sub

    End Class

    Public Class 模板

        Dim n As 简易XML
        Public Property 名字 As String

        Public Sub New(name As String)
            名字 = name
            n = New 简易XML(名字)
        End Sub

        Public Sub 读取(s As String)
            n.全文本 = s
        End Sub

        Public Property 元素(name As String) As String
            Get
                Return n.元素(name)
            End Get
            Set(value As String)
                n.元素(name) = value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return n.ToString
        End Function

    End Class

End Module
