<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 批量复制文件
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabFrom = New System.Windows.Forms.Label()
        Me.ListFrom = New System.Windows.Forms.ListBox()
        Me.ListTo = New System.Windows.Forms.ListBox()
        Me.LabTo = New System.Windows.Forms.Label()
        Me.ButStart = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButClear = New System.Windows.Forms.Button()
        Me.LabWarn = New System.Windows.Forms.Label()
        Me.LabDone = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabFrom
        '
        Me.LabFrom.AutoSize = True
        Me.LabFrom.Location = New System.Drawing.Point(12, 9)
        Me.LabFrom.Name = "LabFrom"
        Me.LabFrom.Size = New System.Drawing.Size(152, 19)
        Me.LabFrom.TabIndex = 0
        Me.LabFrom.Text = "要复制的文件、文件夹："
        '
        'ListFrom
        '
        Me.ListFrom.AllowDrop = True
        Me.ListFrom.FormattingEnabled = True
        Me.ListFrom.ItemHeight = 19
        Me.ListFrom.Location = New System.Drawing.Point(12, 31)
        Me.ListFrom.Name = "ListFrom"
        Me.ListFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListFrom.Size = New System.Drawing.Size(435, 327)
        Me.ListFrom.TabIndex = 1
        '
        'ListTo
        '
        Me.ListTo.AllowDrop = True
        Me.ListTo.FormattingEnabled = True
        Me.ListTo.ItemHeight = 19
        Me.ListTo.Location = New System.Drawing.Point(453, 31)
        Me.ListTo.Name = "ListTo"
        Me.ListTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListTo.Size = New System.Drawing.Size(402, 327)
        Me.ListTo.TabIndex = 2
        '
        'LabTo
        '
        Me.LabTo.AutoSize = True
        Me.LabTo.Location = New System.Drawing.Point(449, 9)
        Me.LabTo.Name = "LabTo"
        Me.LabTo.Size = New System.Drawing.Size(165, 19)
        Me.LabTo.TabIndex = 3
        Me.LabTo.Text = "把他们复制到这些文件夹："
        '
        'ButStart
        '
        Me.ButStart.Enabled = False
        Me.ButStart.Location = New System.Drawing.Point(475, 364)
        Me.ButStart.Name = "ButStart"
        Me.ButStart.Size = New System.Drawing.Size(245, 33)
        Me.ButStart.TabIndex = 4
        Me.ButStart.Text = "复制（文件很多很大就会卡一会）"
        Me.ButStart.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'ButClear
        '
        Me.ButClear.Location = New System.Drawing.Point(726, 364)
        Me.ButClear.Name = "ButClear"
        Me.ButClear.Size = New System.Drawing.Size(127, 33)
        Me.ButClear.TabIndex = 6
        Me.ButClear.Text = "清空"
        Me.ButClear.UseVisualStyleBackColor = True
        '
        'LabWarn
        '
        Me.LabWarn.AutoSize = True
        Me.LabWarn.Location = New System.Drawing.Point(8, 371)
        Me.LabWarn.Name = "LabWarn"
        Me.LabWarn.Size = New System.Drawing.Size(230, 19)
        Me.LabWarn.TabIndex = 7
        Me.LabWarn.Text = "复制时如果有重复的文件将会被覆盖。"
        '
        'LabDone
        '
        Me.LabDone.AutoSize = True
        Me.LabDone.Location = New System.Drawing.Point(381, 371)
        Me.LabDone.Name = "LabDone"
        Me.LabDone.Size = New System.Drawing.Size(48, 19)
        Me.LabDone.TabIndex = 8
        Me.LabDone.Text = "完成！"
        Me.LabDone.Visible = False
        '
        '批量复制文件
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(867, 417)
        Me.Controls.Add(Me.LabDone)
        Me.Controls.Add(Me.LabWarn)
        Me.Controls.Add(Me.ButClear)
        Me.Controls.Add(Me.ButStart)
        Me.Controls.Add(Me.LabTo)
        Me.Controls.Add(Me.ListTo)
        Me.Controls.Add(Me.ListFrom)
        Me.Controls.Add(Me.LabFrom)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "批量复制文件"
        Me.Text = "批量复制文件"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabFrom As Label
    Friend WithEvents ListFrom As ListBox
    Friend WithEvents ListTo As ListBox
    Friend WithEvents LabTo As Label
    Friend WithEvents ButStart As Button
    Friend WithEvents Timer1 As Forms.Timer
    Friend WithEvents ButClear As Button
    Friend WithEvents LabWarn As Label
    Friend WithEvents LabDone As Label
End Class
