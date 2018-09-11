
Public Class 程序设置

    Dim 选项数量 As Integer = 0

    Private Sub 程序设置_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        新选项("HideWindowAtMin", "最小化的时候直接隐藏到后台，而不是停留在任务栏里")
        新选项("NoUpdateAtMain", "启动程序的时候不检查更新（关闭后请自行去我博客查询更新）")
        新选项("ExitAtMain", "关闭主页的时候隐藏到后台，而不是直接退出程序")
        新选项("SaveBACKUP", "软件开启时保存一个备份的配置信息文件到本地")
    End Sub

    Sub 新选项(名字 As String, 文字 As String)
        Dim c As New CheckBox
        With c
            .Name = 名字
            .Left = 8
            .Top = 选项数量 * 30 + 5
            .AutoSize = True
            .Text = 文字
            .TabStop = False
            .Checked = 设置.读取真假(名字)
            Tab1.Controls.Add(c)
            AddHandler .CheckedChanged, Sub()
                                            设置.元素(名字) = c.Checked.ToString
                                        End Sub
            AddHandler Activated, Sub()
                                      c.Checked = 设置.读取真假(名字)
                                  End Sub
        End With
        选项数量 += 1
    End Sub

    Public Sub ButCreateSC_Click() Handles ButCreateSC.Click
        Try
            创建快捷方式(追加斜杠(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) + 中英文快捷方式名(), 程序文件目录 + "wt.exe")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "创建桌面快捷方式出错啦")
        End Try
    End Sub

    Public Function 中英文快捷方式名() As String
        If 包含(My.Computer.Info.InstalledUICulture.Name.ToLower, "cn") Then
            Return "走過去的工具箱.lnk"
        Else
            Return "Walkedby's Tools.lnk"
        End If
    End Function

    Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click
        Dim n As MsgBoxResult
        n = MsgBox("你确定要卸载本软件吗？
很高兴你打开了我（然后又选择把我卸掉）。
卸载会删掉程序本体，留存的信息，
还有快捷方式（如果你没重命名的话）。
程序本体有几率自删失败，还请同志你亲自动手 。", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "你确定吗？")
        If n <> MsgBoxResult.Ok Then Exit Sub
        启动器.Nico.Visible = False
        Dim s As String = 追加斜杠(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
        删除(s + "走過去的工具箱.lnk", s + "Walkedby's Tools.lnk", 缓存目录, 程序文件目录() + "wt_save.xml", 程序文件目录() + "wt_save.wbxml", 程序文件目录() + "wt_save_backup")
        s = "C:\Users\" + 当前用户名 + "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\"
        删除(s + "走過去的工具箱.lnk", s + "Walkedby's Tools.lnk")
        Shell("cmd.exe /c c: & taskkill /im wt.exe /f & timeout 1 & del /f /q " + 引(程序文件目录 + "wt.exe") + "  & echo Finished uninstall. & pause", AppWinStyle.NormalFocus)
    End Sub

End Class