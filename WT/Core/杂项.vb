
Module 杂项

    Public ReadOnly Property 当前用户名 As String
        Get
            Return 去左(Regex.Match(My.User.Name, "\\.*").ToString(), 1)
        End Get
    End Property

    ''' <summary>
    ''' 把输入的东西进行 DEBUG 输出
    ''' </summary>
    Public Sub PRT(ParamArray 输入() As Object)
        Dim s As String = ""
        For Each i As Object In 输入
            If IsNothing(i) Then
                s += "<Nothing>"
            Else
                Dim t As String = i.ToString
                If t.Length < 1 Then t = "<空字符串>"
                s += t
            End If
            s += Space(4)
        Next
        s = Trim(s)
        If s.Length < 1 Then s = "<没有输出>" & Space(4) & Now.ToString
        Debug.Print(s)
    End Sub

    ''' <summary>
    ''' 互换两个对象
    ''' </summary>
    Public Sub 互换(ByRef A As Object, ByRef B As Object)
        Dim C As Object = A
        A = B
        B = C
    End Sub

    ''' <summary>
    ''' 判断物品是否等于其他物品当中的一个
    ''' </summary>
    Public Function 是当中一个(物品 As Object, ParamArray 其他() As Object) As Boolean
        For Each i As Object In 其他
            If i = 物品 Then Return True
        Next
        Return False
    End Function

    ''' <summary>
    ''' 随机来点东西
    ''' </summary>
    Public Class 随机

        ''' <summary>
        ''' 运行 Randomize
        ''' </summary>
        Public Shared Sub 刷新()
            Randomize()
        End Sub

        ''' <summary>
        ''' 获得A、B之间的一个随机整数，可以等于A,B
        ''' </summary>
        Public Shared Function 整数(Optional A As Integer = 100, Optional B As Integer = 0) As Integer
            If B > A Then 互换(A, B)
            Return Int(Rnd() * (A - B + 1) + B)
        End Function

        ''' <summary>
        ''' 随机获得 True 或 False
        ''' </summary>
        Public Shared Function 真假(Optional 百分比概率 As Integer = 50) As Boolean
            Return (Rnd() > (百分比概率 / 100))
        End Function

        ''' <summary>
        ''' 随机获得指定个数的小写字母
        ''' </summary>
        Public Shared Function 小写字母(Optional 个数 As Integer = 10) As String
            Dim s As String = ""
            For i As Integer = 1 To 个数
                s += Chr(整数(122, 97))
            Next
            Return s
        End Function

        ''' <summary>
        ''' 返回指定长度的用数字组成的字符串
        ''' </summary>
        Public Shared Function 数字(Optional 长度 As Integer = 10) As String
            Dim s As String = ""
            For i As Integer = 1 To 长度
                s += 整数(9, 0).ToString
            Next
            Return s
        End Function

        ''' <summary>
        ''' 返回指定长度的用汉字组成的字符串
        ''' </summary>
        Public Shared Function 汉字(Optional 长度 As Integer = 10) As String
            Dim s As String = ""
            For i As Integer = 1 To 长度
                s += 常用简体字(整数(0, 常用简体字.Length - 1))
            Next
            Return s
        End Function

        ''' <summary>
        ''' 从所给的物品里随机挑一个物品返回
        ''' </summary>
        Public Shared Function 多选一(ParamArray 物品() As Object) As Object
            Return 物品(整数(0, 物品.Length - 1))
        End Function

        Public Shared Function 比特() As Byte
            Dim b As Byte = 整数(0, 255)
            Return b
        End Function

        ''' <summary>
        ''' 组成随机大小写字母和数字的指定长度的字符串
        ''' </summary>
        Public Shared Function 文字(Optional 长度 As Integer = 10) As String
            Dim s As String = ""
            For i As Integer = 1 To 长度
                s += 多选一(小写字母(1), LCase(小写字母(1)), 整数(0, 9)).ToString
            Next
            Return s
        End Function

    End Class

    ''' <summary>
    ''' 鼠标所在位置的 X 坐标
    ''' </summary>
    Public ReadOnly Property 鼠标X As Integer
        Get
            Return Cursor.Position.X
        End Get
    End Property

    ''' <summary>
    ''' 鼠标所在位置的 Y 坐标
    ''' </summary>
    Public ReadOnly Property 鼠标Y As Integer
        Get
            Return Cursor.Position.Y
        End Get
    End Property

    ''' <summary>
    ''' 给线程权限可以直接篡改控件
    ''' </summary>
    Public Sub 线程越界(Optional 允许 As Boolean = True)
        Control.CheckForIllegalCrossThreadCalls = Not 允许
    End Sub

    ''' <summary>
    ''' 把线程强制中断
    ''' </summary>
    Public Sub 中断线程(ParamArray s() As Thread)
        For Each 线程 As Thread In s
            If (Not IsNothing(线程)) AndAlso 线程.IsAlive Then 线程.Abort()
        Next
    End Sub

    ''' <summary>
    ''' 检测物品是否为列表的某一项
    ''' </summary>
    Public Function 在列表(列表 As Object, 物品 As Object) As Boolean
        If 列表.Count < 1 Then Return False
        For Each i As Object In 列表
            If 物品.GetHashCode = i.GetHashCode Then Return True
        Next
        Return False
    End Function

    ''' <summary>
    ''' 为列表去重
    ''' </summary>
    Public Sub 列表去重(列表 As Object)
        If 列表.count < 1 Then Exit Sub
        Dim x As New Collection
        For Each i As String In 列表
            If Not 在列表(x, i) AndAlso Trim(i).Length > 0 Then x.Add(i)
        Next
        列表.clear
        For Each i As Object In x
            If Trim(i).ToString.Length > 0 Then 列表.Add(i.ToString)
        Next
    End Sub

    ''' <summary>
    ''' 转换时间为UNIX时间
    ''' </summary>
    Public Function UNIX时间(时间 As Date) As Long
        Return DateDiff("s", #1970-1-1 0:0:0#, ConvertTimeToUtc(时间))
    End Function

    ''' <summary>
    ''' 把UNIX时间转换回普通时间
    ''' </summary>
    Public Function UNIX时间恢复(时间 As Long) As Date
        Dim T1970 As Date = #1970-1-1 0:0:0#
        Return ConvertTime(T1970.Add(New TimeSpan(0, 0, 0, 时间)), Utc, Local)
    End Function

    ''' <summary>
    ''' 把计算机时间变成北京时区的时间
    ''' </summary>
    Public Function 北京时间(时间 As Date) As Date
        Return ConvertTimeBySystemTimeZoneId(时间, Local.Id, "China Standard Time")
    End Function

    ''' <summary>
    ''' 把输入的公历转换成农历
    ''' </summary>
    Public Function 公历转农历(公历 As Date) As Date
        Dim c As New ChineseLunisolarCalendar
        Return (New Date(c.GetYear(公历), c.GetMonth(公历), c.GetDayOfMonth(公历), 公历.Hour, 公历.Minute, 公历.Second))
    End Function

    ''' <summary>
    ''' 返回两个日期之间的长度
    ''' </summary>
    Public Function 时间差(s1 As Date, s2 As Date, Optional 一天以内详细 As Boolean = False) As String
        Dim i As Long = Abs(DateDiff(DateInterval.Second, s1, s2))
        Dim d As Long = 24 * 60 * 60
        If i < d Then
            If 一天以内详细 Then
                Return 时间文字(i)
            Else
                Return "不到一天"
            End If
        Else
            Return 时间文字(i)
        End If
    End Function

    ''' <summary>
    ''' 给秒的时间，返回中文文字
    ''' </summary>
    Public Function 时间文字(i As Long) As String
        Dim d As Long = 24 * 60 * 60
        If i < d Then
            If i < 90 Then
                Return i & "秒"
            ElseIf i < 60 * 120 Then
                Return Fix(i / 60) & "分钟"
            Else
                Return Fix(i / 60 / 60) & "个小时"
            End If
        Else
            i = Int(i / d + 0.5)
            If i < 60 Then
                Return i & "天"
            ElseIf i < 30 * 18 Then
                Return Fix(i / 30) & "个月"
            Else
                Return Fix(i / 365) & "年"
            End If
        End If
    End Function

    ''' <summary>
    ''' 是否有这个名字的程序运行，名字不需要后缀
    ''' </summary>
    Public Function 程序运行中(程序名 As String) As Boolean
        Dim ps() As Process = Process.GetProcessesByName(程序名)
        Return (ps.Count > 0)
    End Function

    ''' <summary>
    ''' 关闭每一个这个名字的程序进程，名字不需要后缀
    ''' </summary>
    Public Sub 关闭程序(程序名 As String)
        Dim ps() As Process = Process.GetProcessesByName(程序名)
        For Each p As Process In ps
            Try
                p.Kill()
            Catch ex As Exception
            End Try
        Next
    End Sub

    ''' <summary>
    ''' 确定这个字符串是不是标准的steam64位ID
    ''' </summary>
    Public Function 是steam64ID(s As String) As Boolean
        s = 只要数字(s)
        Return s.Length = 17 AndAlso s.StartsWith("765611")
    End Function

End Module
