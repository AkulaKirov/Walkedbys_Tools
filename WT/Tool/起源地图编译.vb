
Public Class 起源地图编译

    Dim 编译器列表 As New List(Of String)

    Private Sub 起源地图编译_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        文本框拖入文件(TxtMap)
        文本框拖入文件夹(TxtBin)
        TxtMap.Text = 设置.元素("Compilemap")
        TxtBin.Text = 设置.元素("CompileBin")
        TxtThread.Value = 设置.读取数("CompileThread", 4)
        TxtGame.Text = 设置.元素("CompileGamePs")
        列表控件选中项(ListMod, 设置.读取数("CompileMod"))
        列表控件选中项(ListGame, 设置.读取数("CompileGame"))
        新编译器("vbsp", "漏洞测试", "-leaktest", "nodetail", "-nodetail", "清空", "")
        新编译器("vvis", "快速", "-fast", "nosort", "-nosort", "清空", "")
        新编译器("vrad", "快速", "-fast", "最终", "-final", "清空", "")
        CheckCopyMap.Checked = 设置.读取真假("CompileCopyMap")
        CheckOpenGame.Checked = 设置.读取真假("CompileOpenGame")
    End Sub

    Private Sub 起源地图编译_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.元素("Compilemap") = TxtMap.Text
        设置.元素("CompileThread") = TxtThread.Value.ToString
        设置.元素("CompileBin") = TxtBin.Text
        设置.元素("CompileMod") = ListMod.SelectedIndex.ToString
        设置.元素("CompileGame") = ListGame.SelectedIndex.ToString
        设置.元素("CompileGamePs") = TxtGame.Text
        设置.元素("CompileOpenGame") = CheckOpenGame.Checked.ToString
        设置.元素("CompileCopyMap") = CheckCopyMap.Checked.ToString
    End Sub

    Private Sub 起源地图编译_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim s As String = TxtBin.Text
        If s.Length < 5 Then Exit Sub
        If Not (文件存在(s + ListGame.SelectedItem.ToString) AndAlso 文件夹存在(s + ListMod.SelectedItem.ToString)) Then
            TxtBin.Text = 去右(s, 1)
        End If
    End Sub

    Private Sub TxtMap_TextChanged(sender As Object, e As EventArgs) Handles TxtMap.TextChanged, TxtBin.TextChanged
        If 文件后缀(TxtMap.Text) <> "vmf" Then
            TxtMap.Text = ""
        End If
        ButStart.Enabled = 文本框都有字(TxtMap, TxtBin)
    End Sub

    Private Sub TxtBin_TextChanged(sender As Object, e As EventArgs) Handles TxtBin.TextChanged
        Dim s As String = 追加斜杠(TxtBin.Text)
        ListMod.Items.Clear()
        ListGame.Items.Clear()
        If 批量文件存在(s + "bin\", "vbsp.exe", "vrad.exe", "vvis.exe") Then
            Dim i As String
            For Each i In Directory.GetDirectories(s, "*", SearchOption.TopDirectoryOnly)
                If 文件存在(追加斜杠(i) + "gameinfo.txt") Then
                    i = 文件名(i)
                    If i.ToLower <> "bin" Then ListMod.Items.Add(i)
                End If
            Next
            For Each i In Directory.GetFiles(s, "*.exe", SearchOption.TopDirectoryOnly)
                ListGame.Items.Add(文件名(i, True))
            Next
            If ListMod.Items.Count > 0 AndAlso ListGame.Items.Count > 0 Then
                ListMod.SelectedIndex = 0
                ListGame.SelectedIndex = 0
                Exit Sub
            End If
        End If
        TxtBin.Text = ""
    End Sub

    Function 编译器启用(名字 As String) As Boolean
        Dim c As CheckBox = Controls("Check" + 名字)
        Return c.Checked
    End Function

    Function 编译器参数(名字 As String) As String
        Return 名字 + ".exe -game " + 引(TxtBin.Text + ListMod.Text) + " -threads " + TxtThread.Value.ToString + " " + Trim(Controls("Txt" + 名字).Text) + " " + 引(TxtMap.Text)
    End Function

    Sub 新编译器(名字 As String, 预设1 As String, 预设1内容 As String, 预设2 As String, 预设2内容 As String, 预设3 As String, 预设3内容 As String)
        Dim t As New CheckBox
        Controls.Add(t)
        With t
            .Name = "Check" + 名字
            .Text = 名字 + ".exe"
            .Size = New Drawing.Size(1, 1)
            .AutoSize = True
            .Left = LabBin.Left
            .Top = LabThread.Bottom + 15 * 系统DPI() + (.Height + 15) * 系统DPI() * 编译器列表.Count
            .TabStop = False
            .Checked = 设置.读取真假("Compilerx" + 名字, True)
            AddHandler FormClosing, Sub()
                                        设置.元素("Compilerx" + 名字) = .Checked.ToString
                                    End Sub
        End With
        Dim t1 As New TextBox
        Controls.Add(t1)
        With t1
            .Name = "Txt" + 名字
            .Text = 设置.元素("Compiler" + 名字)
            .MaxLength = 200
            .Left = 100 * 系统DPI()
            .Top = t.Top
            .Width = 380 * 系统DPI()
            .TabStop = False
            AddHandler FormClosing, Sub()
                                        设置.元素("Compiler" + 名字) = .Text
                                    End Sub
        End With
        新预设(t1, 预设1, 预设1内容, 1)
        新预设(t1, 预设2, 预设2内容, 2)
        新预设(t1, 预设3, 预设3内容, 3)
        编译器列表.Add(名字)
    End Sub

    Sub 新预设(t1 As TextBox, 名字 As String, 内容 As String, 位置 As Integer)
        Dim t2 As New Button
        Controls.Add(t2)
        With t2
            .Text = 名字
            .Width = 100
            .Left = t1.Right + ((位置 - 1) * .Width + 12) * 系统DPI()
            .Height = t1.Height + 5
            .Top = t1.Top - 3
            .TabStop = False
            AddHandler .Click, Sub()
                                   t1.Text = 内容
                                   t1.Select(t1.TextLength, 0)
                               End Sub
        End With
    End Sub

    Private Sub ButStart_Click(sender As Object, e As EventArgs) Handles ButStart.Click
        Enabled = False
        Dim p As String = TxtBin.Text, i As String
        Dim m As String = 左(p, 2) + vbCrLf
        m += "cd " + 引(p + "bin\") + vbCrLf
        For Each i In 编译器列表
            If 编译器启用(i) Then
                m += 编译器参数(i) + vbCrLf
            End If
        Next
        If CheckCopyMap.Checked Then
            m += "copy /y " + 引(TxtMap.Text.ToLower.Replace(".vmf", ".bsp")) + " " + 引(p + ListMod.Text + "\maps\") + vbCrLf
        End If
        If CheckOpenGame.Checked Then
            m += "cd " + 引(p) + vbCrLf
            m += ListGame.Text + " " + Trim(TxtGame.Text) + " +map " + 引(文件名(TxtMap.Text)) + vbCrLf
        End If
        m += "pause"
        i = 缓存目录 + "compile.bat"
        写文件(i, m)
        Shell(i, AppWinStyle.NormalFocus, True)
        删除(i)
        Cooldown.Enabled = True
    End Sub

    Private Sub Cooldown_Tick(sender As Object, e As EventArgs) Handles Cooldown.Tick
        Enabled = True
        Cooldown.Enabled = False
    End Sub

End Class