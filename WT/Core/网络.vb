Module 网络

    ''' <summary>
    ''' 常见的浏览器UA列表
    ''' </summary>
    Public Class 浏览器UA

        Public Const Chrome64 As String = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.167 Safari/537.36"
        Public Const Steam As String = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; Valve Steam Client/default/1522709999; ) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36"
        Public Const IE11 As String = "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; rv:11.0) like Gecko "
        Public Const iPhone7 As String = "Mozilla/5.0 (iPhone; CPU iPhone OS 10_3 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) CriOS/56.0.2924.75 Mobile/14E5239e Safari/602.1"

    End Class

    ''' <summary>
    ''' 简易的 HTTP 请求
    ''' </summary>
    Public Class 简易HTTP

        Private h As HttpWebRequest, url As String

        Public Sub New(链接 As String, Optional 请求方法 As String = "GET")
            url = 链接
            Dim u As New Uri(链接)
            h = WebRequest.Create(u)
            UA = 浏览器UA.Chrome64
            内容Type = "application/x-www-form-urlencoded; charset=UTF-8"
            方法 = 请求方法
            超时 = 8
        End Sub

        Public ReadOnly Property 链接() As String
            Get
                Return url
            End Get
        End Property

        ''' <summary>
        ''' HttpWebRequest 本体
        ''' </summary>
        Public Function 本体() As HttpWebRequest
            Return h
        End Function

        ''' <summary>
        ''' 添加或者覆盖掉指定名字的 HTTP Header 的内容
        ''' </summary>
        Public Sub 设置头(名字 As String, 内容 As String)
            移除头(名字)
            Dim s As String = ""
            For Each n As Char In 内容.ToCharArray
                If Asc(n) < 32 OrElse Asc(n) > 127 Then
                    s += HttpUtility.UrlEncode(n)
                Else
                    s += n
                End If
            Next
            h.Headers.Add(名字, s)
        End Sub

        ''' <summary>
        ''' 移除指定名字的 HTTP Header 内容
        ''' </summary>
        Public Sub 移除头(名字 As String)
            h.Headers.Remove(名字)
        End Sub

        ''' <summary>
        ''' 获得指定名字的 HTTP Header 内容
        ''' </summary>
        Public Function 获得头(名字 As String) As String
            Dim i As String = h.Headers.Get(名字)
            If Not IsNothing(i) Then Return i
            Return ""
        End Function

        Public Property Cookie As String
            Set(value As String)
                设置头("cookie", value)
            End Set
            Get
                Return 获得头("cookie")
            End Get
        End Property

        Public Property Origin As String
            Set(value As String)
                设置头("Origin", value)
            End Set
            Get
                Return 获得头("Origin")
            End Get
        End Property

        Public Property Host As String
            Set(value As String)
                h.Host = value
            End Set
            Get
                Return h.Host
            End Get
        End Property

        Public Property 方法 As String
            Set(value As String)
                h.Method = value
            End Set
            Get
                Return h.Method
            End Get
        End Property

        Public Property Referer As String
            Set(value As String)
                h.Referer = value
            End Set
            Get
                Return h.Referer
            End Get
        End Property

        Public Property UA As String
            Set(value As String)
                h.UserAgent = value
            End Set
            Get
                Return h.UserAgent
            End Get
        End Property

        Public Property 内容Type As String
            Set(value As String)
                h.ContentType = value
            End Set
            Get
                Return h.ContentType
            End Get
        End Property

        ''' <summary>
        ''' 以秒为单位的请求超时期限
        ''' </summary>
        ''' <returns></returns>
        Public Property 超时 As Integer
            Set(value As Integer)
                h.Timeout = value * 1000
            End Set
            Get
                Return Int(h.Timeout / 1000)
            End Get
        End Property

        ''' <summary>
        ''' 向 HTTP 请求头中写入内容
        ''' </summary>
        Public Sub 写入(内容 As Object)
            Try
                写入流(h.GetRequestStream, 内容)
            Catch ex As Exception
            End Try
        End Sub

        ''' <summary>
        ''' 获得 HTTP 请求的最终回应
        ''' </summary>
        Public Function 获得回应(Optional 解码 As Boolean = True) As String
            Try
                Dim r As WebResponse = h.GetResponse
                Dim i As String = 读取流(r.GetResponseStream)
                If 解码 Then i = Regex.Unescape(i)
                Return 非空字符串(i)
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function

    End Class

    ''' <summary>
    ''' 简易的 POST 请求用的 FormData 信息生成器
    ''' </summary>
    Public Class 简易FormData

        Dim all As String

        Public Sub New(Optional 原文 As String = "")
            all = 原文
        End Sub

        Public Sub 添加(名字 As String, 内容 As String)
            If all.Length > 3 Then all += "&"
            all += 名字 + "=" + HttpUtility.UrlEncode(内容)
        End Sub

        Public Sub 批量添加(ParamArray 值() As String)
            Dim i As Integer
            For i = 0 To (值.Length - 1) Step 2
                添加(值(i), 值(i + 1))
            Next
        End Sub

        Public Overrides Function ToString() As String
            Return all
        End Function

    End Class

    ''' <summary>
    ''' 用来建立 multipart/form-data 请求
    ''' </summary>
    Public Class 简易MultiPartFormData

        Private h As HttpWebRequest
        Private bd As String = ""
        Private s As Stream
        Private lose As Boolean = False
        Private heading As String = ""
        Private 数据 As String = ""

        Public Sub New(请求 As 简易HTTP)
            Try
                h = 请求.本体
                数据 = ""
                bd = "------WebKitFormBoundary" + 随机.小写字母(8)
                heading = "--" + bd + vbCrLf
                h.Method = "POST"
                h.ContentType = "multipart/form-data; boundary=" + bd
                s = h.GetRequestStream
            Catch ex As Exception
                lose = True
            End Try
        End Sub

        Private Sub 加头()
            If lose Then Exit Sub
            写入流(s, heading)
            If 数据.Length > 5 Then 数据 += vbCrLf
            数据 += heading
        End Sub

        ''' <summary>
        ''' 在 multipart/form-data 里新增一个参数
        ''' </summary>
        Public Sub 新参数(名字 As String, 值 As String, Optional 类型 As String = "")
            If lose Then Exit Sub
            加头()
            Dim i As String = "Content-Disposition: form-data; name=" + 引(名字) + vbCrLf
            If 类型.Length > 1 Then i += "Content-Type: " + 类型
            i += vbCrLf + 值
            写入流(s, i)
        End Sub

        ''' <summary>
        ''' 在 multipart/form-data 里加入比特
        ''' </summary>
        Public Sub 新文件(名字 As String, 文件 As String, Optional 文件类型 As String = "")
            If lose Then Exit Sub
            加头()
            Dim i As String = "Content-Disposition: form-data; name=" + 引(名字) + "; filename=" + 引(文件名(文件, True)) + vbCrLf
            If 文件类型.Length > 0 Then i += "Content-Type: " + 文件类型
            i += vbCrLf + vbCrLf
            写入流(s, i)
            数据 += i
            Dim b() As Byte = 读文件(文件, True)
            写入流(s, b)
            数据 += "[二进制 " & b.Length & "]"
        End Sub

        ''' <summary>
        ''' 在 multipart/form-data 里加入比特
        ''' </summary>
        Public Sub 新比特(名字 As String, 文件名 As String, 比特 As Byte(), Optional 文件类型 As String = "")
            If lose Then Exit Sub
            加头()
            Dim i As String = "Content-Disposition: form-data; name=" + 引(名字) + "; filename=" + 引(文件名) + vbCrLf + "Content-Type: " + 文件类型 + vbCrLf + vbCrLf
            写入流(s, i)
            数据 += i
            写入流(s, 比特)
            数据 += "[二进制 " & 比特.Length & "]"
        End Sub

        ''' <summary>
        ''' 完成 multipart/form-data 的数据
        ''' </summary>
        Public Sub 结束()
            If lose Then Exit Sub
            Dim i As String = vbCrLf + "--" + bd + "--"
            Dim b As Byte() = 文字转字节(i)
            s.Write(b, 0, b.Length)
            数据 += i
        End Sub

        ''' <summary>
        ''' 预览将要 POST 过去的数据
        ''' </summary>
        Public ReadOnly Property 数据预览 As String
            Get
                Return (数据 + vbCrLf + "--" + bd + "--").Replace(vbCrLf, vbCrLf + "-CRLF-")
            End Get
        End Property

    End Class

    ''' <summary>
    ''' 利用淘宝的API返回网络的准确时间
    ''' </summary>
    Public Function 网络时间() As Date
        Dim h As New 简易HTTP("https://api.m.taobao.com/rest/api3.do?api=mtop.common.getTimestamp")
        h.超时 = 1
        Dim i As String = 去除(h.获得回应(False), 引号)
        Dim t As Long = Val(去右(提取(i, "data:{t:", "}"), 3))
        If t > 1500000000 Then Return UNIX时间恢复(t)
        Return 北京时间(Now)
    End Function

End Module
