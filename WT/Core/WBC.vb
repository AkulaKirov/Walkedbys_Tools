Module WBC

    ''' <summary>
    ''' Walkedby's Config 配置文件
    ''' </summary>
    Public Class WBC文件

        Public Property 元素列表 As List(Of WBC元素)

        Public Property 本地文件 As String

        Public Sub New(本地文件 As String)
            Me.本地文件 = 本地文件
            元素列表 = New List(Of WBC元素)
            If 文件可用(本地文件) Then
                Dim f As String = 文件后缀(本地文件)
                If f = "wbc" Then
                    Dim r As New BinaryReader(File.OpenRead(本地文件)), s1 As String, s2 As String
                    读取字符串到零(r)
                    Do While True
                        s1 = 读取字符串到零(r)
                        s2 = 读取字符串到零(r)
                        字符串(s1) = s2
                        If r.BaseStream.Position >= r.BaseStream.Length - 1 Then Exit Do
                    Loop
                    r.Close()
                Else
                    兼容读取老版本()
                    删除(本地文件)
                    Me.本地文件 = 程序文件目录 + "wt.wbc"
                    保存到本地()
                End If
            End If
        End Sub

        Public Sub 保存到本地()
            If 文件后缀(本地文件) <> "wbc" Then Exit Sub
            Dim r As New BinaryWriter(File.OpenWrite(本地文件))
            With r
                .Write(文字转字节("这是戈登走過去的程序配置文件，请不要篡改内容以免相关程序出错。谢谢合作。"))
                Dim b0 As Byte = 0, i As WBC元素
                .Write(b0)
                For Each i In 元素列表
                    .Write(文字转字节(i.名字))
                    .Write(b0)
                    .Write(文字转字节(i.值))
                    .Write(b0)
                Next
                .Close()
            End With
        End Sub

        Private Function 获得元素(名字 As String) As WBC元素
            名字 = 名字.ToLower
            For Each i As WBC元素 In 元素列表
                If i.名字 = 名字 Then
                    Return i
                End If
            Next
            Return Nothing
        End Function

        Public Property 布林(名字 As String, Optional 默认 As Boolean = False) As Boolean
            Get
                Return 字符串(名字, 默认.ToString).ToLower = "true"
            End Get
            Set(值 As Boolean)
                字符串(名字) = 值.ToString.ToLower
            End Set
        End Property

        Public Property 日期(名字 As String, Optional 默认 As Date = #2000-01-01 00:00:00#) As Date
            Get
                Return 字符串(名字, 默认.ToString)
            End Get
            Set(值 As Date)
                字符串(名字) = 值.ToString
            End Set
        End Property

        Public Property 数字(名字 As String, Optional 默认 As Double = 0) As Double
            Get
                Return Val(字符串(名字, 默认.ToString))
            End Get
            Set(值 As Double)
                字符串(名字) = 值.ToString
            End Set
        End Property

        Public Property 字符串(名字 As String, Optional 默认 As String = "") As String
            Get
                Dim n As WBC元素 = 获得元素(名字)
                If IsNothing(n) Then Return 默认
                Return n.值
            End Get
            Set(值 As String)
                If 名字.Length < 1 Then Exit Property
                值 = 非空字符串(值)
                Dim n As WBC元素 = 获得元素(名字), 为空 = (值.Length = 0)
                If IsNothing(n) Then
                    If Not 为空 Then
                        元素列表.Add(New WBC元素(名字, 值))
                    End If
                Else
                    If 为空 Then
                        元素列表.Remove(n)
                    Else
                        n.值 = 值
                    End If
                End If
            End Set
        End Property

        Private Sub 兼容读取老版本()
            Dim f As String = 文件后缀(本地文件)
            Select Case f
                Case "xml"
                    读取老版本XML(读文件(本地文件))
                Case "wbxml"
                    Dim Read_r As New BinaryReader(File.OpenRead(本地文件))
                    Dim Read_hash As Integer = Read_r.ReadInt32()
                    Dim Read_n As Integer = Read_r.ReadByte, Read_n2 As Integer = Read_r.ReadByte
                    Dim Read_s As New List(Of Byte)
                    For Read_i = 6 To Read_r.BaseStream.Length - 1
                        Dim Read_b As Byte = Read_r.ReadByte
                        If Read_b > Read_n2 Then Read_s.Add(Read_b - Read_n2)
                    Next
                    Read_r.Close()
                    f = HttpUtility.UrlDecode(字节转文字(Read_s.ToArray))
                    读取老版本XML(f)
            End Select
        End Sub

        Private Sub 读取老版本XML(xml As String)
            Dim s As String, t As String, n As String
            s = 提取(xml, "<WT>", "</WT>")
            For Each m As Match In Regex.Matches(s, "\<.*?\>")
                t = m.ToString
                If Not t.StartsWith("</") Then
                    n = 提取(t, "<", ">")
                    字符串(n) = HttpUtility.UrlDecode(提取(s, 括(n, "<>"), 括(n, "</>")))
                End If
            Next
        End Sub

    End Class

    Public Class WBC元素

        Public Property 名字 As String

        Public Property 值 As String

        Public Sub New(名字 As String, 内容 As String)
            Me.名字 = 名字.ToLower
            值 = 非空字符串(内容)
        End Sub

        Public Overrides Function ToString() As String
            Return 名字 + "=" + 值
        End Function

    End Class

End Module
