Public Class 后台键盘指令

    Dim 按键文本框 As List(Of TextBox)
    Dim MZ As 模板组
    Dim Ks(4) As Integer

    Public Sub 后台键盘指令_Load() Handles MyBase.Load
        MZ = New 模板组("KeyBinder", ListTemps, TxtName, ButAdd, ButDEl, ButUSE)
        按键文本框 = New List(Of TextBox) From {TxtBind0, TxtBind1, TxtBind2, TxtBind3, TxtBind4}
        Dim i As Integer
        For i = 0 To 4
            Dim t As TextBox = 按键文本框.Item(i)
            t.Tag = i.ToString
            AddHandler t.KeyUp, Sub(sender As TextBox, e As KeyEventArgs)
                                    sender.Text = e.KeyData.ToString
                                    Ks(Val(sender.Tag)) = e.KeyCode
                                    TxtCMD_TextChanged(sender, e)
                                End Sub
            AddHandler t.MouseUp, Sub(sender As TextBox, e As MouseEventArgs)
                                      sender.Text = ""
                                      TxtCMD_TextChanged(sender, e)
                                      Ks(Val(sender.Tag)) = 0
                                  End Sub
            AddHandler t.TextChanged, AddressOf TxtCMD_TextChanged
        Next
        刷新启用列表()
        i = 设置.读取数("KeyBWhen")
        If i < 0 OrElse i >= ListWhen.Items.Count Then i = 0
        ListWhen.SelectedIndex = i
    End Sub

    Private Sub 后台键盘指令_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.元素("KeyBWhen") = ListWhen.SelectedIndex.ToString
    End Sub

    Private Sub TxtCMD_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged, TxtOpen.TextChanged, TxtShut.TextChanged
        Dim b As Boolean = False
        For Each t As TextBox In 按键文本框
            If Not IsNothing(t) AndAlso t.TextLength > 0 Then
                b = True
                Exit For
            End If
        Next
        MZ.刷新()
        刷新启用列表()
    End Sub

    Private Sub ButAdd_Click(sender As Object, e As EventArgs) Handles ButAdd.Click
        Dim f As String = TxtName.Text
        Dim t As New 模板(f)
        t.元素("EN") = CheckEnabled.Checked.ToString
        t.元素("CMDopen") = TxtOpen.Text
        t.元素("CMDshut") = TxtShut.Text
        For i As Integer = 0 To 4
            Dim s As String = 按键文本框.Item(i).Text
            If s.Length > 0 Then
                t.元素("bKEY" & i) = Ks(i)
            End If
        Next
        MZ.新增(t)
        ' TxtName.Text = f
        刷新启用列表()
    End Sub

    Private Sub ListTemps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTemps.SelectedIndexChanged
        '  TxtName.Text = t.名字
        刷新启用列表()
    End Sub

    Sub 刷新启用列表()
        ListEN.Items.Clear()
        If IsNothing(MZ) Then Exit Sub
        Dim t As 模板
        For Each t In MZ.模板列表
            If t.读取真假("EN") Then
                ListEN.Items.Add(t.名字)
            End If
        Next
    End Sub

    Private Sub Watching_Tick(sender As Object, e As EventArgs) Handles Watching.Tick
        Exit Sub
        If IsNothing(MZ) OrElse ListEN.Items.Count < 1 Then Exit Sub
        Dim i As Integer = 设置.读取数("KeyBWhen"), b As Boolean = False
        Select Case i
            Case 0
                b = (最后窗体.Text = Text)
            Case 1
                b = True
            Case 2
                b = False
            Case Else
                i = 0
        End Select
        If Not b Then Exit Sub
        Dim t As 模板, n As String
        For Each n In ListEN.Items
            t = MZ.获得模板(n)
            If Not IsNothing(t) Then
                b = True
                For i = 0 To 4
                    Dim tk As Integer = Input.KeyInterop.KeyFromVirtualKey(t.读取数("bKEY" & i))
                    If tk > 0 Then
                        If Not Input.Keyboard.IsKeyDown(tk) Then
                            b = False
                        End If
                    End If
                Next
                If b Then
                    Dim p As String, o As String = t.元素("CMDopen")
                    If o.Length > 0 Then
                        For Each p In 分割(o, vbCrLf)
                            If Not 程序运行中(文件名(p)) Then
                                Try
                                    Shell(p)
                                Catch ex As Exception
                                End Try
                            End If
                        Next
                    End If
                    o = t.元素("CMDshut")
                    If o.Length > 0 Then
                        For Each p In 分割(o, vbCrLf)
                            关闭程序(p)
                        Next
                    End If
                End If
            End If
        Next
        刷新启用列表()
    End Sub

    Private Sub ListWhen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListWhen.SelectedIndexChanged
        设置.元素("KeyBWhen") = ListWhen.SelectedIndex.ToString
    End Sub

    Private Sub TxtOpen_DragEnter(sender As Object, e As Forms.DragEventArgs) Handles TxtOpen.DragEnter, TxtShut.DragEnter
        e.Effect = Forms.DragDropEffects.Link
    End Sub

    Private Sub TxtOpen_DragDrop(sender As TextBox, e As Forms.DragEventArgs) Handles TxtOpen.DragDrop
        For Each m As String In e.Data.GetData(Forms.DataFormats.FileDrop)
            sender.Text += IIf(sender.TextLength > 0, vbCrLf, "") + m
        Next
    End Sub

    Private Sub TxtShut_DragDrop(sender As TextBox, e As Forms.DragEventArgs) Handles TxtShut.DragDrop
        For Each m As String In e.Data.GetData(Forms.DataFormats.FileDrop)
            sender.Text += IIf(sender.TextLength > 0, vbCrLf, "") + 文件名(m)
        Next
    End Sub

    Private Sub ButUSE_Click(sender As Object, e As EventArgs) Handles ButUSE.Click
        Dim t As 模板 = MZ.读取当前项
        If IsNothing(t) Then Exit Sub
        CheckEnabled.Checked = t.读取真假("EN")
        TxtOpen.Text = t.元素("CMDopen")
        TxtShut.Text = t.元素("CMDshut")
        For i As Integer = 0 To 4
            Ks(i) = Val(t.元素("bKEY" & i))
            按键文本框(i).Text = IIf(Ks(i) > 0, CType(Ks(i), Keys).ToString, "")
        Next
        刷新启用列表()
    End Sub

    Private Sub CheckEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEnabled.CheckedChanged
        Dim t As 模板 = MZ.读取当前项
        If IsNothing(t) Then Exit Sub
        t.元素("EN") = CheckEnabled.Checked
        刷新启用列表()
    End Sub

End Class