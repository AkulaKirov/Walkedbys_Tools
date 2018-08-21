
Module 通用

    Friend 工具列表 As New List(Of 工具)
    Friend 设置 As New 简易XML("WT", "", 程序文件目录() + "wt_save.xml")
    Public TempF As String = 程序文件目录() + "WalkedbysTemps\"
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

    Public Sub 最小化隐藏(sender As Form, e As EventArgs)
        Select Case sender.WindowState
            Case FormWindowState.Minimized
                If Not 设置.读取真假("HideWindowAtMin") Then 隐藏到后台(sender)
            Case FormWindowState.Normal
                显示到前台(sender)
        End Select
    End Sub

    Public Sub 隐藏到后台(sender As Form)
        With sender
            .ShowInTaskbar = False
            .Hide()
        End With
    End Sub

    Public Sub 显示到前台(sender As Form)
        With sender
            .ShowInTaskbar = True
            .TopMost = True
            .Show()
            .WindowState = FormWindowState.Normal
            .TopMost = False
        End With
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
            窗体.ImeMode = 启动器.ImeMode
            窗体.ShowInTaskbar = True
            窗体.MaximizeBox = False
            窗体.AutoScaleMode = AutoScaleMode.Dpi
            AddHandler 窗体.FormClosing, Sub(sender As Object, e As FormClosingEventArgs)
                                           e.Cancel = True
                                           窗体.Hide()
                                           窗体.ShowInTaskbar = False
                                           启动器.Location = 窗体.Location
                                           启动器.WindowState = FormWindowState.Normal
                                           启动器.Show()
                                           启动器.Location = 窗体.Location
                                           最后窗体 = 启动器
                                           最后窗体.ShowInTaskbar = True
                                       End Sub
            AddHandler 窗体.SizeChanged, AddressOf 最小化隐藏
        End Sub

        Public Sub 启动()
            最后窗体.Hide()
            显示到前台(窗体)
            窗体.Location = 最后窗体.Location
            最后窗体 = 窗体
        End Sub

        Public Overrides Function ToString() As String
            Return ID
        End Function

    End Class

    Public Class 模板组

        Dim n As String, g As New List(Of 模板)
        Dim 列表 As ComboBox, 文本框 As TextBox, 新增按纽 As Button, 移除按纽 As Button, 读取按纽 As Button

        Public Sub New(名字 As String, 列表控件 As ComboBox, 文本控件 As TextBox, 新增 As Button, 移除 As Button, 读取 As Button)
            n = "模板组___" + 名字
            Dim x As New 简易XML(n, 设置.元素(n))
            列表 = 列表控件
            文本框 = 文本控件
            文本框.MaxLength = 10
            新增按纽 = 新增
            移除按纽 = 移除
            读取按纽 = 读取
            新增按纽.Enabled = False
            移除按纽.Enabled = False
            读取按纽.Enabled = False
            AddHandler 列表.SelectedIndexChanged, AddressOf 刷新
            AddHandler 文本框.TextChanged, AddressOf 刷新
            AddHandler 移除按纽.Click, Sub()
                                       移除列表选中项()
                                       刷新()
                                   End Sub
            AddHandler 移除按纽.FindForm.FormClosing, AddressOf 保存
            Dim f As List(Of String) = 分割(设置.元素(n + "列表"), vbCrLf)
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
            列表.Items.Clear()
            If g.Count > 0 Then
                For Each t In g
                    列表.Items.Add(t.名字)
                Next
            End If
        End Sub

        Public Sub 刷新()
            Dim name As String = Trim(文本框.Text)
            新增按纽.Enabled = (name.Length > 0 AndAlso name.Length < 11 AndAlso Not 在列表(列表.Items, name))
            Dim i As Integer = 列表.SelectedIndex
            Dim b As Boolean = (i > -1)
            移除按纽.Enabled = b
            读取按纽.Enabled = b
        End Sub

        Public Sub 新增(s As 模板)
            g.Add(s)
            列表.Items.Add(s.名字)
            列表.SelectedItem = s.名字
            文本框.Text = ""
            刷新()
            保存()
        End Sub

        Public Function 读取当前项() As 模板
            If 列表.SelectedIndex < 0 Then Return Nothing
            Dim i As String = 列表.SelectedItem.ToString
            If i.Length < 1 OrElse g.Count < 1 Then Return Nothing
            Return 获得模板(i)
        End Function

        Public Sub 移除列表选中项()
            If 列表.SelectedIndex < 0 Then Exit Sub
            If g.Count < 1 Then Exit Sub
            Dim t As 模板 = 读取当前项()
            移除选中项(列表)
            g.Remove(t)
            刷新()
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

        Public ReadOnly Property 模板列表 As List(Of 模板)
            Get
                Return g
            End Get
        End Property

        Public Function 获得模板(name As String) As 模板
            Dim t As 模板
            For Each t In g
                If t.名字 = name Then
                    Return t
                End If
            Next
            Return Nothing
        End Function

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

        Public Function 读取真假(name As String) As Boolean
            Return n.读取真假(name)
        End Function

        Public Function 读取数(name As String) As Double
            Return n.读取数(name)
        End Function

    End Class

End Module
