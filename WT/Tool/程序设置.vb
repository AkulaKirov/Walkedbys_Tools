
Public Class 程序设置

    Dim 选项数量 As Integer = 0

    Private Sub 程序设置_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        新选项("HideWindowAtMin", "最小化的时候直接隐藏到后台，而不是停留在任务栏里")
        新选项("NoUpdateAtMain", "启动程序的时候不检查更新（关闭后请自行去我博客查询更新）")
        新选项("ExitAtMain", "关闭主页的时候隐藏到后台，而不是直接退出程序")
        新选项("SaveBACKUP", "软件开启时保存一个备份的软件配置文件到我的文档下的wt_save_backup文件夹")
        If 设置.布林("SaveBACKUP") Then ButCheckBackup.Enabled = True
    End Sub

    Sub 新选项(名字 As String, 文字 As String)
        Dim c As New CheckBox, d As Single = 系统DPI()
        With c
            .Name = 名字
            .Left = 8
            .Top = 选项数量 * 30 * d + 5 * d
            .AutoSize = True
            .Text = 文字
            .TabStop = False
            .Checked = 设置.布林(名字)
            Tab1.Controls.Add(c)
            AddHandler .CheckedChanged, Sub()
                                            设置.布林(名字) = c.Checked
                                        End Sub
            AddHandler Activated, Sub()
                                      c.Checked = 设置.布林(名字)
                                  End Sub
        End With
        选项数量 += 1
    End Sub

    Public Sub 创建桌面快捷方式() Handles ButCreateSC.Click
        Try
            创建快捷方式(追加斜杠(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) + 中英文快捷方式名(), 程序文件目录 + "wt.exe")
        Catch ex As Exception
            Dp("创建桌面快捷方式出错：", ex.Message)
        End Try
    End Sub

    Public Function 中英文快捷方式名() As String
        If 包含(My.Computer.Info.InstalledUICulture.Name.ToLower, "cn") Then
            Return "走過去的工具箱.lnk"
        Else
            Return "Walkedby's Tools.lnk"
        End If
    End Function

    Private Sub ButClearCookie_Click(sender As Object, e As EventArgs) Handles ButClearCookie.Click
        SteamCookie.清空Cookie()
        设置.字符串("WeiboCookie") = ""
    End Sub

    Private Sub ButCheckBackup_Click(sender As Object, e As EventArgs) Handles ButCheckBackup.Click
        Process.Start(备份目录)
    End Sub

End Class