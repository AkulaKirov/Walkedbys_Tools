
Module SMD文件处理

    Private Function 小数文字(i As Double) As String
        Return FormatNumber(i, 6)
    End Function

    Private Function 空格组合句子(ParamArray s() As Object) As String
        Dim m As String = "", t As String = " "
        For Each i As Object In s
            m += i.ToString + t
        Next
        Return 去右(m, t.Length)
    End Function

    Private Function 回车组成句子(ParamArray s() As Object) As String
        Dim m As String = "", t As String = vbCrLf
        For Each i As Object In s
            m += i.ToString + t
        Next
        Return 去右(m, t.Length)
    End Function

    Public Class SMD文件

        Public Property 骨骼组 As List(Of SMD骨骼)
        Public Property 面组 As List(Of SMD面)
        Public Property 文本 As String
        Public Property 贴图列表 As List(Of String)

        Public Sub New(s As String, Optional 只读取骨骼 As Boolean = False)
            s = 提取(回车规范(s), "version 1" + vbCrLf).Replace(vbTab, " ")
            Do While 包含(s, "  ")
                s = s.Replace("  ", " ")
            Loop
            文本 = s
            骨骼组 = New List(Of SMD骨骼)
            Dim bs As String = 提取(s, "nodes" + vbCrLf, vbCrLf + "end"), i As String
            For Each i In 分割(bs, vbCrLf)
                If i.Length > 3 Then Dim hb As New SMD骨骼(i, Me)
            Next
            面组 = New List(Of SMD面)
            贴图列表 = New List(Of String)
            If Not 只读取骨骼 Then
                bs = 提取(s, "triangles" + vbCrLf, vbCrLf + "end")
                Dim f As List(Of String) = 分割(bs, vbCrLf), j As Integer
                For j = 0 To f.Count - 1 Step 4
                    If j + 3 < f.Count Then
                        Dim fm As New SMD面(回车组成句子(f(j), f(j + 1), f(j + 2), f(j + 3)), Me)
                        面组.Add(fm)
                        If Not 在列表(贴图列表, fm.贴图名) Then 贴图列表.Add(fm.贴图名)
                    End If
                Next
            End If
        End Sub

        Public Overrides Function ToString() As String
            Dim s As String = ""
            For Each n As SMD骨骼 In 骨骼组
                s += 空格组合句子(n.ID, n.位置, n.方向) + vbCrLf
            Next
            Return 回车组成句子("version 1", "nodes", 列表转文字(骨骼组), "end", "skeleton", "time 0", 去右(s, vbCrLf.Length), "end", "triangles", 列表转文字(面组), "end")
        End Function

        Public Function 名字骨骼(name As String) As SMD骨骼
            For Each n As SMD骨骼 In 骨骼组
                If n.名字 = name Then
                    Return n
                End If
            Next
            Return Nothing
        End Function

        Public Function ID骨骼(id As Integer) As SMD骨骼
            If id < 骨骼组.Count Then
                Return 骨骼组(id)
            Else
                Return Nothing
            End If
        End Function

    End Class

    Public Class SMD骨骼

        Public Property 文件 As SMD文件
        Public Property 名字 As String
        Public Property 父骨骼 As SMD骨骼
        Public Property 位置 As 坐标
        Public Property 方向 As 坐标

        Public Sub New(s As String, smd As SMD文件)
            文件 = smd
            s = Trim(s)
            名字 = 提取(s, vbQuote, vbQuote)
            s = 去除(s, 名字, vbQuote)
            Dim n As Integer = Val(Regex.Match(s, " [0-9]+").ToString)
            If n > -1 Then 父骨骼 = smd.ID骨骼(n) Else 父骨骼 = Nothing
            smd.骨骼组.Add(Me)
            s = 提取(smd.文本, "time 0" + vbCrLf, "end")
            Dim m As String = "", j As New List(Of Double)
            For Each m In 分割(s, vbCrLf)
                m = Trim(m)
                If m.StartsWith(ID) Then Exit For
            Next
            For Each s In 分割(m, " ")
                j.Add(Val(s))
            Next
            位置 = New 坐标(j(1), j(2), j(3))
            方向 = New 坐标(j(4), j(5), j(6))
        End Sub

        Public ReadOnly Property ID As Integer
            Get
                Dim i As Integer
                For i = 0 To 文件.骨骼组.Count - 1
                    If 文件.骨骼组(i).名字 = 名字 Then Return i
                Next
                Return 0
            End Get
        End Property

        Public Overrides Function ToString() As String
            Dim n As Integer = -1
            If Not IsNothing(父骨骼) Then n = 父骨骼.ID
            Return 空格组合句子(ID, 引(名字), n)
        End Function

        Public Shared Operator <>(left As SMD骨骼, right As SMD骨骼) As Boolean
            Return Not (left = right)
        End Operator

        Public Shared Operator =(left As SMD骨骼, right As SMD骨骼) As Boolean
            Return (left.名字 = right.名字)
        End Operator

        Public Function 获得子骨骼() As List(Of SMD骨骼)
            Dim n As New List(Of SMD骨骼)
            For Each i As SMD骨骼 In 文件.骨骼组
                If (Not IsNothing(i.父骨骼)) AndAlso i.父骨骼 = Me Then
                    n.Add(i)
                End If
            Next
            Return n
            PRT(n.Count)
        End Function

    End Class

    Public Class SMD面

        Public Property 文件 As SMD文件
        Public Property 贴图名 As String
        Public Property 点 As SMD点()

        Public Sub New(s As String, smd As SMD文件)
            文件 = smd
            Dim f As List(Of String) = 分割(s, vbCrLf)
            贴图名 = f(0)
            Dim c As Integer = 2, i As Integer
            ReDim 点(c)
            For i = 0 To c
                点(i) = New SMD点(f(i + 1), 文件)
            Next
        End Sub

        Public Overrides Function ToString() As String
            Dim s As String = 贴图名 + vbCrLf
            For Each n As SMD点 In 点
                s += n.ToString + vbCrLf
            Next
            Return 去右(s, vbCrLf.Length)
        End Function

    End Class

    Public Class SMD点

        Public Property 文件 As SMD文件
        Public Property 主骨骼 As SMD骨骼
        Public Property 坐标 As 坐标
        Public Property Norm坐标 As 坐标
        Public Property U As Double
        Public Property V As Double
        Public Property 附加骨骼数量 As Integer
        Public Property 权重 As List(Of SMD点权重)

        Public Sub New(s As String, smd As SMD文件)
            s = Trim(s)
            文件 = smd
            Dim fn As New List(Of Double)
            For Each i As String In 分割(s, " ")
                fn.Add(Val(i))
            Next
            主骨骼 = smd.骨骼组(fn(0))
            坐标 = New 坐标(fn(1), fn(2), fn(3))
            Norm坐标 = New 坐标(fn(4), fn(5), fn(6))
            U = fn(7)
            V = fn(8)
            If fn.Count > 9 Then
                附加骨骼数量 = fn(9)
                权重 = New List(Of SMD点权重)
                Dim j As Integer
                For j = 10 To (fn.Count - 1) Step 2
                    权重.Add(New SMD点权重(fn(j), fn(j + 1), smd))
                Next
            End If
        End Sub

        Public Overrides Function ToString() As String
            Dim s As String = 空格组合句子(主骨骼.ID, 坐标, Norm坐标, U, V)
            If Not IsNothing(权重) AndAlso 权重.Count > 0 Then
                s += " " + 附加骨骼数量.ToString
                For Each n As SMD点权重 In 权重
                    s += " " + n.ToString
                Next
            End If
            Return s
        End Function

    End Class

    Public Class SMD点权重

        Public Property 文件 As SMD文件
        Public Property 骨骼 As SMD骨骼
        Public Property 大小 As Double

        Public Sub New(s As String, smd As SMD文件)
            文件 = smd
            s = Trim(s)
            Dim f As List(Of String) = 分割(s, " ")
            骨骼 = smd.ID骨骼(Val(f(0)))
            大小 = Val(f(1))
        End Sub

        Public Sub New(骨骼 As Integer, 大小 As Double, smd As SMD文件)
            文件 = smd
            Me.骨骼 = smd.ID骨骼(骨骼)
            Me.大小 = 大小
        End Sub

        Public Overrides Function ToString() As String
            Return 骨骼.ID.ToString + " " + 小数文字(大小)
        End Function

    End Class

    Public Class 坐标

        Public Property X As Double
        Public Property Y As Double
        Public Property Z As Double

        Public Sub New(X As Double, Y As Double, Z As Double)
            Me.X = X
            Me.Y = Y
            Me.Z = Z
        End Sub

        Public Sub New(s As String)
            s = Trim(s)
            Dim f As List(Of String) = 分割(s, " ")
            X = Val(f(0))
            Y = Val(f(1))
            Z = Val(f(2))
        End Sub

        Public Overrides Function ToString() As String
            Return 小数文字(X) & " " & 小数文字(Y) & " " & 小数文字(Z)
        End Function

        Public Shared Operator +(left As 坐标, right As 坐标) As 坐标
            Return (New 坐标(left.X + right.X, left.Y + right.Y, left.Z + right.Z))
        End Operator

        Public Shared Operator -(left As 坐标, right As 坐标) As 坐标
            Return (New 坐标(left.X - right.X, left.Y - right.Y, left.Z - right.Z))
        End Operator

    End Class

End Module
