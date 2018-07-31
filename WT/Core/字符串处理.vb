
Module 字符串处理

    ''' <summary>
    ''' 一个英文引号
    ''' </summary>
    Public Const vbQuote As String = """"

    ''' <summary>
    ''' 把全部回车统一到指定的 vbCrLf
    ''' </summary>
    Public Function 回车规范(文字 As String) As String
        If 文字.Length < 1 Then Return 文字
        文字 = 文字.Replace(vbCrLf, vbLf)
        文字 = 文字.Replace(vbCr, vbLf)
        Return 非空字符串(文字.Replace(vbLf, vbCrLf))
    End Function

    ''' <summary>
    ''' 把空的字符串变成 ""
    ''' </summary>
    Public Function 非空字符串(ByRef 文字 As String) As String
        If IsNothing(文字) Then 文字 = String.Empty
        Return 文字
    End Function

    ''' <summary>
    ''' 把文字从左数的几个字给提取出来
    ''' </summary>
    Public Function 左(文字 As String, 个数 As Integer) As String
        If 个数 < 0 Then 个数 = 0
        Return Left(文字, 个数)
    End Function

    ''' <summary>
    ''' 把文字从左数的几个字给提取出来
    ''' </summary>
    Public Function 右(文字 As String, 个数 As Integer) As String
        If 个数 < 0 Then 个数 = 0
        Return Right(文字, 个数)
    End Function

    ''' <summary>
    ''' 把文字从左数的几个字给提取出来
    ''' </summary>
    Public Function 去左(文字 As String, 个数 As Integer) As String
        个数 = 文字.Length - 个数
        If 个数 < 0 Then 个数 = 0
        Return Right(文字, 个数)
    End Function

    ''' <summary>
    ''' 把文字从左数的几个字给提取出来
    ''' </summary>
    Public Function 去右(文字 As String, 个数 As Integer) As String
        个数 = 文字.Length - 个数
        If 个数 < 0 Then 个数 = 0
        Return Left(文字, 个数)
    End Function

    ''' <summary>
    ''' 把文字里的回车替换为别的文字，默认为空
    ''' </summary>
    Public Function 去回车(文字 As String, Optional 替换 As String = "") As String
        If 文字.Length < 1 Then Return ""
        Return 回车规范(文字).Replace(vbCrLf, 替换)
    End Function

    ''' <summary>
    ''' 把列表转成一行行文字
    ''' </summary>
    Public Function 列表转文字(列表 As Object) As String
        If 列表.count < 1 Then Return ""
        Dim s As String = "", i As Integer = 0
        For i = 0 To 列表.count - 1
            s += 去回车(列表.item(i).ToString) + vbCrLf
        Next
        Return 去右(s, 2)
    End Function

    ''' <summary>
    ''' 把一行行文字变成列表
    ''' </summary>
    Public Sub 文字转列表(列表 As Object, 文字 As String)
        If 文字.Length < 1 Then Exit Sub
        For Each m As Match In Regex.Matches(文字, ".*")
            Dim t As String = 去除(m.ToString, vbCr, vbLf)
            If t.Length > 0 Then 列表.add(t)
        Next
    End Sub

    ''' <summary>
    ''' 把文字用括号括起来
    ''' </summary>
    Public Function 括(文字 As String, Optional 括号 As String = "()") As String
        Return 左(括号, 1) + 文字 + 右(括号, 1)
    End Function

    ''' <summary>
    ''' 把 文字 变成 "文字"
    ''' </summary>
    Public Function 引(文字 As String) As String
        Return vbQuote + 文字 + vbQuote
    End Function

    ''' <summary>
    ''' 把文字用间隔符进行分割，生成一个字符串列表。
    ''' 如果字符串内没有间隔符，就直接生成只有文字本体的列表。
    ''' </summary>
    Public Function 分割(文字 As String, 间隔符 As String) As List(Of String)
        Dim s As New List(Of String)
        If 包含(文字, 间隔符) Then s.Add(间隔符) Else s.Add(文字)
        If 文字.Length < 2 Then Return s
        If Not 文字.EndsWith(间隔符) Then 文字 += 间隔符
        For Each m As Match In Regex.Matches(文字, "([\s\S]*?)" + Regex.Escape(间隔符))
            Dim t As String = m.ToString.Replace(间隔符, "")
            If t.Length > 0 Then s.Add(t)
        Next
        Return s
    End Function

    ''' <summary>
    ''' 把用分割函数生成的列表进行合并
    ''' </summary>
    Public Function 合并分割(分割 As List(Of String)) As String
        Dim s As String = "", i As Integer, c As Integer = 分割.Count
        If c = 1 Then Return 分割.First
        c -= 1
        For i = 1 To c
            s += 分割.Item(i)
            If i <> c Then s += 分割.First
        Next
        Return s
    End Function

    ''' <summary>
    ''' 检查文字当中是否包含要寻找的字符串之一
    ''' </summary>
    Public Function 包含(文字 As String, ParamArray 寻找() As String) As Boolean
        For Each i As String In 寻找
            If InStr(文字, i) > 0 Then Return True
        Next
        Return False
    End Function

    ''' <summary>
    ''' 检查文字当中是否包含全部要寻找的字符串
    ''' </summary>
    Public Function 全部包含(文字 As String, ParamArray 寻找() As String) As Boolean
        For Each i As String In 寻找
            If InStr(文字, i) <= 0 Then Return False
        Next
        Return True
    End Function

    ''' <summary>
    ''' 把寻找到的文字从文字中移除
    ''' </summary>
    Public Function 去除(文字 As String, ParamArray 寻找() As String) As String
        For Each i As String In 寻找
            文字 = Replace(文字, i, "")
        Next
        Return 非空字符串(文字)
    End Function

    ''' <summary>
    ''' 把匹配到的正则表达式字从文字中移除
    ''' </summary>
    Public Function 正则去除(文字 As String, ParamArray 寻找() As String) As String
        For Each i As String In 寻找
            If 文字.Length > 0 Then 文字 = Regex.Replace(文字, i, "")
        Next
        Return 非空字符串(文字)
    End Function

    ''' <summary>
    ''' 把两个及以上个数的回车变成一个回车
    ''' </summary>
    Public Function 去多余回车(文字 As String) As String
        文字 = 回车规范(文字)
        Do While 包含(文字, vbCrLf + vbCrLf)
            文字 = 文字.Replace(vbCrLf + vbCrLf, vbCrLf)
        Loop
        Return 文字
    End Function

    ''' <summary>
    ''' 把文字里不是数字的东西全部去掉
    ''' </summary>
    Public Function 只要数字(文字 As String) As String
        Dim s As String = ""
        If 文字.Length > 0 Then
            For Each m As Match In Regex.Matches(文字, "[0-9]")
                s += m.ToString
            Next
        End If
        Return s
    End Function

    ''' <summary>
    ''' 把字符串转成字节
    ''' </summary>
    Public Function 文字转字节(文字 As String, Optional 编码 As Encoding = Nothing) As Byte()
        If IsNothing(编码) Then 编码 = Encoding.UTF8
        Return 编码.GetBytes(非空字符串(文字))
    End Function

    ''' <summary>
    ''' 把字节转成字符串
    ''' </summary>
    Public Function 字节转文字(字节 As Byte(), Optional 编码 As Encoding = Nothing) As String
        If IsNothing(编码) Then 编码 = Encoding.UTF8
        Return 非空字符串(编码.GetString(字节))
    End Function

    ''' <summary>
    ''' 返回文字有多少行
    ''' </summary>
    Public Function 行数(文字 As String) As Integer
        If 文字.Length < 1 Then Return 0
        文字 = 回车规范(文字)
        Dim mc As MatchCollection = Regex.Matches(文字, ".*(\n|$)")
        Return mc.Count
    End Function

    ''' <summary>
    ''' 返回文字里指定那一行的文字
    ''' </summary>
    Public Function 行(文字 As String, 行号 As Integer) As String
        If 文字.Length < 1 Then Return ""
        文字 = 回车规范(文字)
        Dim mc As MatchCollection = Regex.Matches(文字, ".*(\n|$)")
        If mc.Count >= 行号 Then Return 去除(mc.Item(行号 - 1).ToString, vbCrLf)
        Return ""
    End Function

    ''' <summary>
    ''' 提取在文字中头开始的字符
    ''' </summary>
    Public Function 提取(文字 As String, 头 As String) As String
        If 包含(文字, 头) Then Return Mid(文字, InStr(文字, 头, CompareMethod.Text) + 头.Length, 文字.Length)
        Return ""
    End Function

    ''' <summary>
    ''' 提取在文字中头尾字符中间的字符
    ''' </summary>
    Public Function 提取(文字 As String, 头 As String, 尾 As String) As String
        Dim s As String = 提取(文字, 头)
        If s.Length > 0 AndAlso 包含(文字, 尾) Then
            Return 去右(s, 提取(s, 尾).Length + 尾.Length)
        End If
        Return ""
    End Function

End Module
