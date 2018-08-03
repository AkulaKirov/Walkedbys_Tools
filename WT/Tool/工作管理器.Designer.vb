<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 工作管理器
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
        Me.ButRefresh = New System.Windows.Forms.Button()
        Me.LabInfo = New System.Windows.Forms.Label()
        Me.ListProcesses = New System.Windows.Forms.ListBox()
        Me.Watching = New System.Windows.Forms.Timer(Me.components)
        Me.ButKill = New System.Windows.Forms.Button()
        Me.GBmemory = New System.Windows.Forms.GroupBox()
        Me.BarMemory = New System.Windows.Forms.ProgressBar()
        Me.GBmemory.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButRefresh
        '
        Me.ButRefresh.Enabled = False
        Me.ButRefresh.Location = New System.Drawing.Point(604, 7)
        Me.ButRefresh.Name = "ButRefresh"
        Me.ButRefresh.Size = New System.Drawing.Size(102, 29)
        Me.ButRefresh.TabIndex = 2
        Me.ButRefresh.TabStop = False
        Me.ButRefresh.Text = "刷新"
        Me.ButRefresh.UseVisualStyleBackColor = True
        '
        'LabInfo
        '
        Me.LabInfo.AutoSize = True
        Me.LabInfo.Location = New System.Drawing.Point(215, 12)
        Me.LabInfo.Name = "LabInfo"
        Me.LabInfo.Size = New System.Drawing.Size(191, 19)
        Me.LabInfo.TabIndex = 1
        Me.LabInfo.Text = "请选一个进程以查看相关信息。"
        '
        'ListProcesses
        '
        Me.ListProcesses.FormattingEnabled = True
        Me.ListProcesses.ItemHeight = 19
        Me.ListProcesses.Location = New System.Drawing.Point(12, 3)
        Me.ListProcesses.Name = "ListProcesses"
        Me.ListProcesses.Size = New System.Drawing.Size(197, 232)
        Me.ListProcesses.Sorted = True
        Me.ListProcesses.TabIndex = 0
        Me.ListProcesses.TabStop = False
        '
        'Watching
        '
        Me.Watching.Enabled = True
        Me.Watching.Interval = 1000
        '
        'ButKill
        '
        Me.ButKill.Enabled = False
        Me.ButKill.Location = New System.Drawing.Point(604, 42)
        Me.ButKill.Name = "ButKill"
        Me.ButKill.Size = New System.Drawing.Size(102, 29)
        Me.ButKill.TabIndex = 3
        Me.ButKill.TabStop = False
        Me.ButKill.Text = "关闭"
        Me.ButKill.UseVisualStyleBackColor = True
        '
        'GBmemory
        '
        Me.GBmemory.Controls.Add(Me.BarMemory)
        Me.GBmemory.Location = New System.Drawing.Point(215, 186)
        Me.GBmemory.Name = "GBmemory"
        Me.GBmemory.Size = New System.Drawing.Size(491, 58)
        Me.GBmemory.TabIndex = 4
        Me.GBmemory.TabStop = False
        Me.GBmemory.Text = "已用物理内存："
        '
        'BarMemory
        '
        Me.BarMemory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BarMemory.Location = New System.Drawing.Point(3, 21)
        Me.BarMemory.Name = "BarMemory"
        Me.BarMemory.Size = New System.Drawing.Size(485, 34)
        Me.BarMemory.TabIndex = 0
        '
        '工作管理器
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(711, 247)
        Me.Controls.Add(Me.GBmemory)
        Me.Controls.Add(Me.ButKill)
        Me.Controls.Add(Me.ListProcesses)
        Me.Controls.Add(Me.ButRefresh)
        Me.Controls.Add(Me.LabInfo)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "工作管理器"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "工作管理器"
        Me.GBmemory.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListProcesses As ListBox
    Friend WithEvents Watching As Windows.Forms.Timer
    Friend WithEvents LabInfo As Label
    Friend WithEvents ButRefresh As Button
    Friend WithEvents ButKill As Button
    Friend WithEvents GBmemory As GroupBox
    Friend WithEvents BarMemory As ProgressBar
End Class
