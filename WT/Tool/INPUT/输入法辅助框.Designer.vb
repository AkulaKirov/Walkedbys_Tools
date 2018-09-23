<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 输入法辅助框
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabWhen = New System.Windows.Forms.Label()
        Me.ListWhen = New System.Windows.Forms.ComboBox()
        Me.LabNote = New System.Windows.Forms.Label()
        Me.Worker = New System.Windows.Forms.Timer(Me.components)
        Me.LabProblem = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabWhen
        '
        Me.LabWhen.AutoSize = True
        Me.LabWhen.Location = New System.Drawing.Point(12, 9)
        Me.LabWhen.Name = "LabWhen"
        Me.LabWhen.Size = New System.Drawing.Size(74, 19)
        Me.LabWhen.TabIndex = 0
        Me.LabWhen.Text = "何时工作："
        '
        'ListWhen
        '
        Me.ListWhen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListWhen.FormattingEnabled = True
        Me.ListWhen.Items.AddRange(New Object() {"只在本工具运行的时候", "本软件运行的时候", "不工作"})
        Me.ListWhen.Location = New System.Drawing.Point(92, 6)
        Me.ListWhen.Name = "ListWhen"
        Me.ListWhen.Size = New System.Drawing.Size(186, 27)
        Me.ListWhen.TabIndex = 5
        Me.ListWhen.TabStop = False
        '
        'LabNote
        '
        Me.LabNote.AutoSize = True
        Me.LabNote.Location = New System.Drawing.Point(12, 49)
        Me.LabNote.Name = "LabNote"
        Me.LabNote.Size = New System.Drawing.Size(219, 95)
        Me.LabNote.TabIndex = 6
        Me.LabNote.Text = "在本工具工作的时候" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "你可以按下键盘上的快捷键 ctrl + |  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "这样就会弹出一个临时小窗口" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "你可以在临时窗口上打字" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "然后输出回你原来的地方"
        '
        'Worker
        '
        Me.Worker.Enabled = True
        Me.Worker.Interval = 30
        '
        'LabProblem
        '
        Me.LabProblem.AutoSize = True
        Me.LabProblem.Location = New System.Drawing.Point(12, 159)
        Me.LabProblem.Name = "LabProblem"
        Me.LabProblem.Size = New System.Drawing.Size(347, 57)
        Me.LabProblem.TabIndex = 7
        Me.LabProblem.Text = "已知问题：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "全屏游戏或程序的时候最好不要用这个，因为会切回桌面。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "弹出的窗口可能输入焦点不在窗口上，需要手动点一下。"
        '
        '输入法辅助框
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(385, 252)
        Me.Controls.Add(Me.LabProblem)
        Me.Controls.Add(Me.LabNote)
        Me.Controls.Add(Me.ListWhen)
        Me.Controls.Add(Me.LabWhen)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MaximizeBox = False
        Me.Name = "输入法辅助框"
        Me.Text = "输入法辅助框"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabWhen As Label
    Friend WithEvents ListWhen As ComboBox
    Friend WithEvents LabNote As Label
    Friend WithEvents Worker As Forms.Timer
    Friend WithEvents LabProblem As Label
End Class
