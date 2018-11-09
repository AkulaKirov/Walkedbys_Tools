
Public Class SteamCookie窗体

    Private Sub SteamCookie_Load(sender As Object, e As EventArgs) Handles Me.Load
        If 只做一次(74565) Then 控件DPI修正(Me)
        CtrlW关闭(Me)
        TxtSession.Text = SteamCookie.SessionID
        TxtLoginSecure.Text = SteamCookie.LoginSecure
        Icon = 图标
        SteamCookie.更新按钮文字()
    End Sub

    Private Sub SteamCookie_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SteamCookie.更新按钮文字()
    End Sub

    Private Sub TxtSession_KeyDown(sender As TextBox, e As KeyEventArgs) Handles TxtSession.KeyDown, TxtLoginSecure.KeyDown
        If e.KeyCode = Keys.Back Then sender.Text = ""
    End Sub

    Private Sub TxtSession_TextChanged(sender As TextBox, e As EventArgs) Handles TxtSession.TextChanged
        SteamCookie.SessionID = ""
        Dim s As String = Trim(TxtSession.Text)
        If s.Length = 24 Then
            SteamCookie.SessionID = s
        Else
            TxtSession.Text = ""
        End If
    End Sub

    Private Sub TxtLoginSecure_TextChanged(sender As Object, e As EventArgs) Handles TxtLoginSecure.TextChanged
        SteamCookie.LoginSecure = ""
        Dim s As String = Trim(TxtLoginSecure.Text)
        If s.Length = 63 AndAlso Regex.IsMatch(s, "765611[0-9]{11}") Then
            SteamCookie.LoginSecure = s
            ButCheckMy.Text = "查看我的 Steam 个人主页 " + 括(SteamCookie.ID64)
        Else
            TxtLoginSecure.Text = ""
            ButCheckMy.Text = "查看我的 Steam 个人主页"
        End If
    End Sub

    Private Sub ButHowToGetCookie_Click(sender As Object, e As EventArgs) Handles ButHowToGetCookie.Click
        Try
            Process.Start("https://github.com/gordonwalkedby/Walkedbys_Tools/wiki/%E5%A6%82%E4%BD%95%E8%8E%B7%E5%BE%97-Steam-Cookie")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SteamCookie窗体_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub ButCheckMy_Click(sender As Object, e As EventArgs) Handles ButCheckMy.Click
        Dim n As String = SteamCookie.ID64
        If n.Length = 17 Then
            n = "https://steamcommunity.com/profiles/" + n + "/"
        Else
            n = "https://steamcommunity.com/my/"
        End If
        Process.Start(n)
    End Sub

End Class

''' <summary>
''' 对 Steam Cookie 进行操作
''' </summary>
Public Class SteamCookie

    Private Shared 按钮列表 As New List(Of Button)

    Public Shared Sub 更新按钮文字()
        Dim ok As Boolean = 填写正确
        For Each b As Button In 按钮列表
            b.Text = "点我填写 Steam Cookie " + 括(IIf(ok, ID64, "还没有填写"), "（）")
        Next
    End Sub

    Public Shared Sub 设置按钮启用(Enabled As Boolean)
        For Each b As Button In 按钮列表
            b.Enabled = Enabled
        Next
    End Sub

    Public Shared Sub 呼起按钮(b As Button)
        按钮列表.Add(b)
        更新按钮文字()
        AddHandler b.Click, Sub()
                                With SteamCookie窗体
                                    .Left = 鼠标X - 80
                                    .Top = 鼠标Y - 80
                                    .ShowDialog()
                                End With
                            End Sub
    End Sub

    Public Shared ReadOnly Property ID64 As String
        Get
            Return 左(LoginSecure, 17)
        End Get
    End Property

    Public Shared Property SessionID As String
        Get
            Return 设置.字符串("SteamSession")
        End Get
        Set(value As String)
            设置.字符串("SteamSession") = value
        End Set
    End Property

    Public Shared Property LoginSecure As String
        Get
            Return 设置.字符串("SteamLoginSecure")
        End Get
        Set(value As String)
            设置.字符串("SteamLoginSecure") = value
        End Set
    End Property

    Public Shared ReadOnly Property 填写正确 As Boolean
        Get
            Return SessionID.Length + LoginSecure.Length = 87
        End Get
    End Property

    Public Shared ReadOnly Property 完整Cookie As String
        Get
            If 填写正确 Then
                Return "steamLoginSecure=" + LoginSecure + "; sessionid=" + SessionID
            Else
                Return ""
            End If
        End Get
    End Property

    Public Shared Function 获得好友列表() As List(Of String)
        Dim f As New List(Of String)
        If 填写正确 = False Then Return f
        Dim h As New 简易HTTP("https://steamcommunity.com/profiles/" + ID64 + "/friends/")
        h.超时 = 5
        Dim s As String = 去除(h.获取回应, 引号, vbCr, vbLf)
        If s.Length < 2000 Then
            f.Add("failed")
        Else
            Dim m As Match, n As String
            For Each m In Regex.Matches(s, "data-search=.*?data-steamid=765611[0-9]{11}")
                s = m.ToString
                n = Trim(提取(s, "data-search=", ";")) + " " + 括("765611" + 提取(s, "data-steamid=765611"), "[]")
                If n.Length > 17 Then f.Add(n)
            Next
            设置.字符串("SteamFriends_" + ID64) = 列表转文字(f)
        End If
        Return f
    End Function

End Class
