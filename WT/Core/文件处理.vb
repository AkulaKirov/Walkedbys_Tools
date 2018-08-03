
Module 文件处理

    ''' <summary>
    ''' 把一个 Stream ReadToEnd
    ''' </summary>
    Public Function 读取流(流 As Stream) As String
        Dim r As New StreamReader(流)
        Dim i As String = r.ReadToEnd
        r.Dispose()
        If IsNothing(i) Then i = ""
        Return i
    End Function

    ''' <summary>
    ''' 把文字写入流
    ''' </summary>
    Public Sub 写入流(流 As Stream, 内容 As String)
        Dim b() As Byte = 文字转字节(内容)
        流.Write(b, 0, b.Length)
    End Sub

    ''' <summary>
    ''' 把内容写入流
    ''' </summary>
    Public Sub 写入流(流 As Stream, 内容 As Byte())
        流.Write(内容, 0, 内容.Length)
    End Sub

    ''' <summary>
    ''' 寻找比特里面的对应字节的index并生成list
    ''' </summary>
    Public Function 寻找字节位置(比特() As Byte, 寻找() As Byte) As List(Of Integer)
        Dim Find As New List(Of Integer)
        Dim i As Integer = 比特.Count - 1, j As Integer = 寻找.Count - 1
        If i < 1 OrElse j < 1 OrElse i < j Then Return Find
        Dim x As Integer, y As Integer = 0
        For x = 0 To i
            If 比特(x) = 寻找(y) Then
                y += 1
                If y = j Then
                    Find.Add(x - j + 1)
                    y = 0
                End If
            Else
                y = 0
            End If
        Next
        Return Find
    End Function

    ''' <summary>
    ''' 把比特里面寻找到的字节用替换的字节进行替换
    ''' </summary>
    Public Function 替换字节(比特() As Byte, 寻找() As Byte, 替换() As Byte) As Byte()
        Dim find As List(Of Integer) = 寻找字节位置(比特, 寻找)
        If find.Count < 1 Then Return 比特
        Dim Out As New List(Of Byte)
        Dim i As Integer, b As Byte
        For i = 0 To 比特.Count - 1
            If 在列表(find, i) Then
                For Each b In 替换
                    Out.Add(b)
                Next
                i += 替换.Count - 1
            Else
                Out.Add(比特(i))
            End If
        Next
        Dim f(Out.Count - 1) As Byte
        For i = 0 To Out.Count - 1
            f(i) = Out.Item(i)
        Next
        Return f
    End Function

    ''' <summary>
    ''' 长度为1，内容为0的字节
    ''' </summary>
    Public Function 空字节() As Byte()
        Dim i(0) As Byte
        Return i
    End Function

    ''' <summary>
    ''' 如果路径字符串的结尾没有\的话就加一个\
    ''' </summary>
    Public Function 追加斜杠(路径 As String) As String
        路径 = 路径.Replace("/", "\")
        Return IIf(路径.EndsWith("\"), 路径, 路径 + "\")
    End Function

    ''' <summary>
    ''' 获得本程序的文件的目录
    ''' </summary>
    Public Function 程序文件目录() As String
        Return 追加斜杠(My.Application.Info.DirectoryPath)
    End Function

    ''' <summary>
    ''' 获得本程序的工作目录
    ''' </summary>
    Public Function 程序工作目录() As String
        Return 追加斜杠(Directory.GetCurrentDirectory)
    End Function

    ''' <summary>
    ''' 判断这个文件夹是否存在于电脑上
    ''' </summary>
    Public Function 文件夹存在(路径 As String) As Boolean
        Return Directory.Exists(路径)
    End Function

    ''' <summary>
    ''' 删除一个文件夹
    ''' </summary>
    Public Sub 删除文件夹(文件夹 As String)
        Try
            Directory.Delete(文件夹, True)
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' 字节单位转换
    ''' </summary>
    Public Function 字节单位转换(数字 As Double, Optional 初始单位 As String = "b", Optional 输出单位 As String = "m") As Long
        初始单位 = LCase(左(初始单位, 1))
        输出单位 = LCase(左(输出单位, 1))
        Select Case 初始单位
            Case "k"
                数字 = 数字 * 1024
            Case "m"
                数字 = 数字 * 1024 * 1024
            Case "g"
                数字 = 数字 * 1024 * 1024 * 1024
            Case "t"
                数字 = 数字 * 1024 * 1024 * 1024 * 1024
            Case Else
                数字 = 数字
        End Select
        Select Case 输出单位
            Case "k"
                数字 = 数字 / 1024
            Case "m"
                数字 = 数字 / 1024 / 1024
            Case "g"
                数字 = 数字 / 1024 / 1024 / 1024
            Case "t"
                数字 = 数字 / 1024 / 1024 / 1024 / 1024
            Case Else
                数字 = 数字
        End Select
        Return 数字
    End Function

    ''' <summary>
    ''' 快速生成一个文件类
    ''' </summary>
    Public Function 文件x(目标 As String) As 文件
        Return New 文件(目标)
    End Function

    ''' <summary>
    ''' 一个简单负责处理文件信息读写的类
    ''' </summary>
    Public Class 文件

        Dim Fl As String

        Public Sub New(目标 As String)
            If 目标.Length < 1 Then Exit Sub
            Fl = LCase(目标.Replace("/", "\"))
            If Not (Fl(1) = ":" AndAlso Fl(2) = "\") Then
                Fl = 程序文件目录() + Fl
            End If
            If Not 文件夹存在(路径) Then Directory.CreateDirectory(路径)
        End Sub

        ''' <summary>
        ''' 获得文件路径+文件名的完整信息
        ''' </summary>
        Public ReadOnly Property 地址 As String
            Get
                Return Fl.ToLower
            End Get
        End Property

        ''' <summary>
        ''' 获得文件的路径
        ''' </summary>
        Public ReadOnly Property 路径 As String
            Get
                Return 追加斜杠(Regex.Match(Fl, ".*\\").ToString)
            End Get
        End Property

        ''' <summary>
        ''' 获得文件所在的分区的盘符，采用小写字母
        ''' </summary>
        Public ReadOnly Property 分区 As String
            Get
                Return Fl(0).ToString
            End Get
        End Property

        ''' <summary>
        ''' 文件是否存在
        ''' </summary>
        Public ReadOnly Property 存在 As Boolean
            Get
                Return File.Exists(Fl)
            End Get
        End Property

        ''' <summary>
        ''' 返回文件的小写后缀名，不带第一个点
        ''' </summary>
        Public ReadOnly Property 后缀 As String
            Get
                Return 去左(Regex.Match(Fl, "\..*").ToString.ToLower, 1)
            End Get
        End Property

        ''' <summary>
        ''' 获得文件名，不含后缀
        ''' </summary>
        Public ReadOnly Property 文件名 As String
            Get
                Return 去除(Fl, 路径, Regex.Match(Fl, "\..*").ToString)
            End Get
        End Property

        ''' <summary>
        ''' 获得文件名，含后缀
        ''' </summary>
        Public ReadOnly Property 完整文件名 As String
            Get
                Return 去除(Fl, 路径)
            End Get
        End Property

        ''' <summary>
        ''' 判断文件是否可以读写
        ''' </summary>
        Public ReadOnly Property 可用 As Boolean
            Get
                If Not 存在 Then Return True
                Try
                    File.OpenRead(Fl).Close()
                    File.OpenWrite(Fl).Close()
                    Return True
                Catch ex As Exception
                    Return False
                End Try
            End Get
        End Property

        ''' <summary>
        ''' 获得文件的大小
        ''' </summary>
        Public ReadOnly Property 大小(Optional 单位 As String = "m") As Integer
            Get
                If Not 存在 Then Return 0
                Return 字节单位转换(FileLen(Fl), "b", 单位)
            End Get
        End Property

        ''' <summary>
        ''' 向文件内写入内容字符串
        ''' </summary>
        Public Sub 写(内容 As String)
            If Not 可用 Then Exit Sub
            内容 = 回车规范(内容)
            File.WriteAllText(Fl, 内容)
        End Sub

        ''' <summary>
        ''' 向文件内写入内容字节
        ''' </summary>
        Public Sub 写字节(内容 As Byte())
            If Not 可用 Then Exit Sub
            删除()
            Dim r As New BinaryWriter(File.OpenWrite(Fl))
            r.Write(内容)
            r.Close()
        End Sub

        ''' <summary>
        ''' 试着把文件删除
        ''' </summary>
        Public Sub 删除()
            If 存在 AndAlso 可用 Then File.Delete(Fl)
        End Sub

        ''' <summary>
        ''' 把文件复制到别的地方，并且改名
        ''' </summary>
        Public Sub 复制(路径 As String, 新文件名 As String)
            路径 = 追加斜杠(路径)
            If Not 文件夹存在(路径) Then Directory.CreateDirectory(路径)
            If 存在 AndAlso 可用 Then File.Copy(Fl, 路径 + 新文件名, True)
        End Sub

        ''' <summary>
        ''' 把文件复制到这个文件夹，并且不改名
        ''' </summary>
        Public Sub 复制(路径 As String)
            路径 = 追加斜杠(路径)
            If Not 文件夹存在(路径) Then Directory.CreateDirectory(路径)
            If 存在 AndAlso 可用 Then File.Copy(Fl, 路径 + 完整文件名, True)
        End Sub

        ''' <summary>
        ''' 把文件里的内容读取为文字
        ''' </summary>
        Public Function 读() As String
            If Not 存在 OrElse Not 可用 Then Return ""
            Return 回车规范(File.ReadAllText(Fl))
        End Function

        ''' <summary>
        ''' 把文件的内容读取为字节数组
        ''' </summary>
        Public Function 读字节() As Byte()
            If Not 存在 OrElse Not 可用 Then Return 空字节()
            Dim b As Byte()
            Dim r As New BinaryReader(File.OpenRead(Fl))
            b = r.ReadBytes(大小("b"))
            r.Close()
            Return b
        End Function

        ''' <summary>
        ''' 把文件读取为 Image 并且不占用图片
        ''' </summary>
        ''' <returns></returns>
        Public Function 转图片() As Image
            Dim t As Image = Nothing
            If 存在 AndAlso 可用 Then
                Dim r As New MemoryStream
                Dim b As Byte() = 读字节()
                r.Write(b, 0, b.Length)
                t = Image.FromStream(r)
                r.Close()
            End If
            Return t
        End Function

    End Class

    ''' <summary>
    ''' 一个保存简易信息到本地的类
    ''' </summary>
    Public Class 简易CFG

        Public Property 全文本 As String
        Public Property 文件 As String

        Public Sub New(Optional 本地文件 As String = "")
            全文本 = ""
            文件 = 本地文件
        End Sub

        Public Property 节点(name As String) As String
            Set(value As String)
                If name.Length < 1 Then Exit Property
                全文本 = 正则去除(全文本, "\[" + name + "=([\s\S]*?)\]")
                If value.Length > 0 Then
                    value = Replace(value, "[", "a/,s")
                    value = Replace(value, "]", "c/;g")
                    全文本 += 括(name + "=" + value, "[]") + vbCrLf
                End If
                全文本 = 去多余回车(全文本)
            End Set
            Get
                If 全文本.Length < 4 OrElse name.Length < 1 Then Return ""
                Dim i As String = Regex.Match(全文本, "\[" + name + "=([\s\S]*?)\]").ToString
                i = 去右(去左(i, name.Length + 2), 1)
                i = i.Replace("a/,s", "[")
                i = i.Replace("c/;g", "]")
                Return i
            End Get
        End Property

        Public Sub 保存本地文件()
            Dim i As New 文件(文件)
            i.写(全文本)
        End Sub

        Public Sub 读取本地文件()
            Dim f As New 文件(文件)
            Dim i As String = f.读
            If i.Length > 3 Then
                全文本 = Regex.Match(i, "\[([\s\S]*)\]").ToString
            Else
                全文本 = ""
            End If
        End Sub

    End Class


End Module
