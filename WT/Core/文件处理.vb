
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
        路径 = Trim(路径)
        If 路径.Length < 2 Then Return 路径
        路径 = 路径.Replace("/", "\")
        Return IIf(路径.EndsWith("\"), 路径, 路径 + "\")
    End Function

    ''' <summary>
    ''' 获得本程序的文件的目录
    ''' </summary>
    Public ReadOnly Property 程序文件目录() As String
        Get
            Return 追加斜杠(My.Application.Info.DirectoryPath)
        End Get
    End Property

    ''' <summary>
    ''' 获得本程序的工作目录
    ''' </summary>
    Public ReadOnly Property 程序工作目录() As String
        Get
            Return 追加斜杠(Directory.GetCurrentDirectory)
        End Get
    End Property

    ''' <summary>
    ''' 获得本程序的小写文件名，不带exe
    ''' </summary>
    Public ReadOnly Property 程序文件名() As String
        Get
            Return Process.GetCurrentProcess.ProcessName.ToLower
        End Get
    End Property

    ''' <summary>
    ''' 判断这个文件夹是否存在于电脑上
    ''' </summary>
    Public Function 文件夹存在(路径 As String) As Boolean
        Return Directory.Exists(路径)
    End Function

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
    ''' 返回文件的路径，最后带斜杠\
    ''' </summary>
    Public Function 文件路径(文件 As String) As String
        If 文件.Length < 5 Then Return ""
        Return 追加斜杠(Regex.Match(文件, ".*\\").ToString)
    End Function

    ''' <summary>
    ''' 返回文件是否存在
    ''' </summary>
    Public Function 文件存在(文件 As String) As Boolean
        If 文件.Length < 3 Then Return False
        Return File.Exists(文件)
    End Function

    ''' <summary>
    ''' 返回一个路径下是否存在指定的多个文件
    ''' </summary>
    Public Function 批量文件存在(路径 As String, ParamArray 文件() As String) As Boolean
        路径 = 追加斜杠(路径)
        If Not 文件夹存在(路径) Then Return False
        For Each i As String In 文件
            If Not 文件存在(路径 + i) Then Return False
        Next
        Return True
    End Function

    ''' <summary>
    ''' 返回文件的小写后缀名，不带第一个点
    ''' </summary>
    Public Function 文件后缀(文件 As String) As String
        If 文件.Length < 5 Then Return ""
        Return 去左(Regex.Match(文件名(文件, True), "\..*").ToString.ToLower, 1)
    End Function

    ''' <summary>
    ''' 把文件重命名为新的文件名，也支持文件夹
    ''' </summary>
    Public Sub 文件重命名(文件 As String, 新文件名 As String)
        If Not (文件可用(文件) OrElse 文件夹存在(文件)) Then Exit Sub
        If 文件.EndsWith("/") Then 文件 = 去右(文件, 1)
        If 新文件名.EndsWith("/") Then 新文件名 = 去右(新文件名, 1)
        Dim i As String = 文件路径(文件)
        Dim s As String = 新文件名
        If 文件路径(新文件名).Length < 1 Then s = i + s
        Try
            Rename(文件, s)
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' 返回文件名，默认不带后缀名
    ''' </summary>
    Public Function 文件名(文件 As String, Optional 带后缀 As Boolean = False) As String
        If 文件.Length < 5 OrElse (Not 包含(文件, ":", "\")) Then Return 文件
        Dim s As String = 去除(文件, 文件路径(文件))
        If Not 带后缀 Then s = 正则去除(s, "\..*")
        Return s
    End Function

    ''' <summary>
    ''' 返回文件夹的名字
    ''' </summary>
    Public Function 文件夹名(文件夹 As String) As String
        Return 文件名(去右(追加斜杠(文件夹), 1), False)
    End Function

    ''' <summary>
    ''' 返回文件是否可读写，如果文件不存在也表示可读写
    ''' </summary>
    Public Function 文件可读写(文件 As String) As Boolean
        If 文件.Length < 5 Then Return False
        If Not 文件存在(文件) Then Return True
        Try
            File.OpenRead(文件).Close()
            File.OpenWrite(文件).Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' 文件是否存在并且可读写
    ''' </summary>
    Public Function 文件可用(文件 As String) As Boolean
        Return (文件存在(文件) AndAlso 文件可读写(文件))
    End Function

    ''' <summary>
    ''' 返回文件的大小，不带小数
    ''' </summary>
    Public Function 文件大小(文件 As String, Optional 单位 As String = "m") As Integer
        If 文件.Length < 5 OrElse Not 文件存在(文件) Then Return 0
        Return 字节单位转换(FileLen(文件), "b", 单位)
    End Function

    ''' <summary>
    ''' 把 UTF8 文本写入到文件当中
    ''' </summary>
    Public Sub 写文件(文件 As String, 内容 As String)
        If Not 文件可读写(文件) Then Exit Sub
        内容 = 回车规范(内容)
        Try
            File.WriteAllText(文件, 内容)
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' 把字节写入到文件当中
    ''' </summary>
    Public Sub 写文件(文件 As String, 字节 As Byte())
        If Not 文件可读写(文件) Then Exit Sub
        删除(文件)
        Try
            Dim r As New BinaryWriter(File.OpenWrite(文件))
            r.Write(字节)
            r.Close()
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' 把文件或者文件夹删除
    ''' </summary>
    Public Sub 删除(ParamArray 文件() As String)
        For Each i As String In 文件
            If i.Length > 5 Then
                Try
                    If 文件存在(i) Then File.Delete(i)
                    If 文件夹存在(i) Then Directory.Delete(i, True)
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub

    ''' <summary>
    ''' 把文件里面的内容读取为文字或字节
    ''' </summary>
    Public Function 读文件(文件 As String, Optional 读取为字节 As Boolean = False)
        If 读取为字节 Then
            If Not 文件可用(文件) Then Return 空字节()
            Dim b As Byte()
            Dim r As New BinaryReader(File.OpenRead(文件))
            b = r.ReadBytes(文件大小(文件, "b"))
            r.Close()
            Return b
        Else
            If Not 文件可用(文件) Then Return ""
            Return 回车规范(File.ReadAllText(文件))
        End If
    End Function

    ''' <summary>
    ''' 把文件读取为 Image 并且不占用图片
    ''' </summary>
    Public Function 读文件为图片(文件 As String, Optional 宽 As Integer = 0, Optional 高 As Integer = 0) As Image
        Dim t As Image = Nothing
        If Not 文件可用(文件) Then Return t
        Dim b As Byte() = 读文件(文件, True)
        If b.Length > 0 Then
            Dim r As New MemoryStream
            r.Write(b, 0, b.Length)
            Dim n As String = 文件后缀(文件)
            If 是当中一个(n, "jpg", "png", "bmp") Then
                If 宽 > 0 AndAlso 高 > 0 Then
                    t = New Bitmap(Image.FromStream(r), 宽, 高)
                Else
                    t = Image.FromStream(r)
                End If
            End If
            r.Close()
        End If
        Return t
    End Function

    ''' <summary>
    ''' 读取我自己的加密文本，如果检测到hash不对就会返回空字符串
    ''' </summary>
    Public Function 读加密文件(文件 As String, Optional 不检测 As Boolean = False) As String
        If Not 文件可用(文件) Then Return ""
        Dim r As New BinaryReader(File.OpenRead(文件))
        Dim hash As Integer = r.ReadInt32()
        Dim n As Integer = r.ReadByte, n2 As Integer = r.ReadByte
        Dim s As New List(Of Byte)
        For i = 6 To r.BaseStream.Length - 1
            Dim b As Byte = r.ReadByte
            If b > n2 Then s.Add(b - n2)
        Next
        Dim f As String = 字节转文字(s.ToArray)
        Return HttpUtility.UrlDecode(f)
        If 不检测 OrElse f.GetHashCode = hash Then
            Return HttpUtility.UrlDecode(f)
        Else
            Return ""
        End If
    End Function

    ''' <summary>
    ''' 保存我自己加密过的文本
    ''' </summary>
    Public Sub 写加密文件(文件 As String, 内容 As String)
        If Not 文件可读写(文件) Then Exit Sub
        删除(文件)
        Dim r As New BinaryWriter(File.OpenWrite(文件))
        内容 = HttpUtility.UrlEncode(内容)
        Dim n As Byte = 随机.整数(1, 99), n2 As Byte = 随机.整数(10, 99), i As Integer
        r.Write(内容.GetHashCode)
        r.Write(n)
        r.Write(n2)
        Dim b As Byte() = 文字转字节(内容)
        For i = 0 To b.Count - 1
            b(i) += n2
            r.Write(b(i))
            If 随机.真假(20) Then
                r.Write(CType(随机.整数(0, n2 - 1), Byte))
            End If
        Next
        r.Close()
    End Sub

    Public Class 简易XML

        Public Property 全文本 As String
        Public Property 本地文件 As String
        Public Property 根元素 As String

        Public Sub New(根 As String, Optional 原始文本 As String = "", Optional 文件 As String = "")
            根元素 = 根
            全文本 = Trim(原始文本)
            提纯()
            本地文件 = 文件.ToLower
        End Sub

        Private Sub 提出根元素()
            非空字符串(全文本)
            If 全文本.StartsWith(括(根元素, "<>")) AndAlso 全文本.EndsWith(括(根元素, "</>")) Then
                全文本 = 提取(全文本, 括(根元素, "<>"), 括(根元素, "</>"))
            End If
        End Sub

        Private Sub 加上根元素()
            非空字符串(全文本)
            If Not (全文本.StartsWith(括(根元素, "<>")) AndAlso 全文本.EndsWith(括(根元素, "</>"))) Then
                全文本 = 括(根元素, "<>") + 全文本 + 括(根元素, "</>")
            End If
        End Sub

        Private Sub 提纯()
            提出根元素()
            加上根元素()
        End Sub

        Public Sub 保存到本地()
            本地文件 = 本地文件.ToLower
            If 本地文件.Length < 5 Then Exit Sub
            If 文件后缀(本地文件) = "wbxml" Then
                写加密文件(本地文件, ToString)
            Else
                写文件(本地文件, ToString)
            End If
        End Sub

        Public Sub 从本地读取()
            本地文件 = 本地文件.ToLower
            If 本地文件.Length < 5 Then Exit Sub
            If 文件后缀(本地文件) = "wbxml" Then
                全文本 = 读加密文件(本地文件)
            Else
                全文本 = 读文件(本地文件)
            End If
            提纯()
        End Sub

        Public Overrides Function ToString() As String
            提纯()
            Return 全文本
        End Function

        Public Sub 保存元素(名字 As String, 内容 As Object)
            Dim s As String = 内容.ToString
            If s.Length > 0 Then 字符串(名字) = s
        End Sub

        Public Property 字符串(名字 As String) As String
            Get
                Return HttpUtility.UrlDecode(提取XML(全文本, 名字))
            End Get
            Set(内容 As String)
                Dim a As String = 括(名字, "<>")
                Dim b As String = 括(名字, "</>")
                全文本 = Regex.Replace(全文本, a + "([\s\S]*?)" + b, "")
                If 内容.Length > 0 Then
                    提出根元素()
                    全文本 += a + HttpUtility.UrlEncode(内容) + b
                    加上根元素()
                End If
            End Set
        End Property

        Public Function 元素列表() As List(Of String)
            Dim n As New List(Of String)
            提出根元素()
            Dim s As String = 全文本
            加上根元素()
            If s.Length > 5 Then
                For Each m As Match In Regex.Matches(s, "<[^/]+?>")
                    Dim t As String = 去除(m.ToString, "<", ">")
                    If 字符串(t).Length > 0 Then n.Add(t)
                Next
            End If
            Return n
        End Function

        Public Property 数字(名字 As String, Optional 默认 As Double = 0) As Double
            Get
                Dim s As String = 字符串(名字)
                If s.Length < 1 Then Return 默认
                Return Val(s)
            End Get
            Set(value As Double)
                字符串(名字) = value.ToString
            End Set
        End Property

        Public Property 布林(名字 As String, Optional 默认 As Boolean = False) As Boolean
            Get
                Dim s As String = 字符串(名字)
                If s.Length < 1 Then Return 默认
                Return s = "true"
            End Get
            Set(value As Boolean)
                字符串(名字) = value.ToString
            End Set
        End Property

        Public Property 日期(名字 As String, Optional 默认 As Date = #2000/01/01 00:00:00#) As Date
            Get
                Dim s As String = 字符串(名字)
                If s.Length < 3 Then Return 默认
                Return Date.Parse(s)
            End Get
            Set(value As Date)
                字符串(名字) = value.ToString
            End Set
        End Property

    End Class

    ''' <summary>
    ''' 简单地创建一个快捷方式
    ''' </summary>
    Public Sub 创建快捷方式(lnk文件 As String, 目标文件 As String, Optional 起始文件夹 As String = "")
        Directory.CreateDirectory(文件路径(lnk文件))
        If 起始文件夹.Length < 3 Then 起始文件夹 = 文件路径(目标文件)
        Dim sc As IWshRuntimeLibrary.IWshShortcut = (New IWshRuntimeLibrary.WshShell).CreateShortcut(lnk文件)
        sc.TargetPath = 目标文件
        sc.WindowStyle = 1
        sc.WorkingDirectory = 起始文件夹
        sc.IconLocation = 目标文件
        sc.Save()
    End Sub

    ''' <summary>
    ''' 针对 BinaryReader 进行操作，一直读取字符串直到特定的byte
    ''' </summary>
    Public Function 读取字符串到零(r As BinaryReader, Optional b As Byte = 0)
        Dim s As String = ""
        Do While True
            Dim ba As Byte = r.ReadByte
            If ba = b Then Exit Do
            s += Chr(b)
        Loop
        Return s
    End Function

End Module
