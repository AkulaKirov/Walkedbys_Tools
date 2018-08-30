<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RunStringLUA制作器
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
        Me.ButDo = New System.Windows.Forms.Button()
        Me.TxtLUA = New System.Windows.Forms.TextBox()
        Me.ButCopy = New System.Windows.Forms.Button()
        Me.LabLen = New System.Windows.Forms.Label()
        Me.LabProblem = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButDo
        '
        Me.ButDo.Enabled = False
        Me.ButDo.Location = New System.Drawing.Point(12, 220)
        Me.ButDo.Name = "ButDo"
        Me.ButDo.Size = New System.Drawing.Size(122, 35)
        Me.ButDo.TabIndex = 0
        Me.ButDo.TabStop = False
        Me.ButDo.Text = "RunString化"
        Me.ButDo.UseVisualStyleBackColor = True
        '
        'TxtLUA
        '
        Me.TxtLUA.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLUA.Location = New System.Drawing.Point(12, 12)
        Me.TxtLUA.MaxLength = 20000
        Me.TxtLUA.Multiline = True
        Me.TxtLUA.Name = "TxtLUA"
        Me.TxtLUA.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLUA.Size = New System.Drawing.Size(680, 202)
        Me.TxtLUA.TabIndex = 1
        Me.TxtLUA.TabStop = False
        '
        'ButCopy
        '
        Me.ButCopy.Enabled = False
        Me.ButCopy.Location = New System.Drawing.Point(140, 220)
        Me.ButCopy.Name = "ButCopy"
        Me.ButCopy.Size = New System.Drawing.Size(126, 35)
        Me.ButCopy.TabIndex = 2
        Me.ButCopy.TabStop = False
        Me.ButCopy.Text = "全选复制"
        Me.ButCopy.UseVisualStyleBackColor = True
        '
        'LabLen
        '
        Me.LabLen.AutoSize = True
        Me.LabLen.Location = New System.Drawing.Point(272, 228)
        Me.LabLen.Name = "LabLen"
        Me.LabLen.Size = New System.Drawing.Size(56, 19)
        Me.LabLen.TabIndex = 3
        Me.LabLen.Text = "长度：0"
        '
        'LabProblem
        '
        Me.LabProblem.AutoSize = True
        Me.LabProblem.Location = New System.Drawing.Point(12, 258)
        Me.LabProblem.Name = "LabProblem"
        Me.LabProblem.Size = New System.Drawing.Size(516, 95)
        Me.LabProblem.TabIndex = 4
        Me.LabProblem.Text = "不保证一定完全正常工作，自己注意测试。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "已知问题：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "同一个文件的 local 参数必须在一起，不然分段会出问题。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "在代码内的字符串可能会被破坏，有些空格或者" &
    "什么特别符号的会少掉。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "实在太长的代码就无法运行了。（建议把需要加密的代码复制进来就好了，整段有危险）"
        '
        'RunStringLUA制作器
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(704, 373)
        Me.Controls.Add(Me.LabProblem)
        Me.Controls.Add(Me.LabLen)
        Me.Controls.Add(Me.ButCopy)
        Me.Controls.Add(Me.TxtLUA)
        Me.Controls.Add(Me.ButDo)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "RunStringLUA制作器"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RunStringLUA制作器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButDo As Button
    Friend WithEvents TxtLUA As TextBox
    Friend WithEvents ButCopy As Button
    Friend WithEvents LabLen As Label
    Friend WithEvents LabProblem As Label
End Class
