<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 启动器
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
        Me.GBallTools = New System.Windows.Forms.GroupBox()
        Me.TxtToolInfo = New System.Windows.Forms.TextBox()
        Me.TxtToolName = New System.Windows.Forms.TextBox()
        Me.ButOpenTool = New System.Windows.Forms.Button()
        Me.ListTools = New System.Windows.Forms.ListBox()
        Me.GBpush = New System.Windows.Forms.GroupBox()
        Me.TxtPush = New System.Windows.Forms.TextBox()
        Me.LabAbout = New System.Windows.Forms.Label()
        Me.GBabout = New System.Windows.Forms.GroupBox()
        Me.LabTime = New System.Windows.Forms.Label()
        Me.Nico = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NicoMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.显示窗口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.返回主页ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabFun = New System.Windows.Forms.Label()
        Me.TimerC = New System.Windows.Forms.Timer(Me.components)
        Me.AutoSave = New System.Windows.Forms.Timer(Me.components)
        Me.GBupdate = New System.Windows.Forms.GroupBox()
        Me.TxtUpdate = New System.Windows.Forms.TextBox()
        Me.走過去的工具箱ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GBallTools.SuspendLayout()
        Me.GBpush.SuspendLayout()
        Me.GBabout.SuspendLayout()
        Me.NicoMenu.SuspendLayout()
        Me.GBupdate.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBallTools
        '
        Me.GBallTools.Controls.Add(Me.TxtToolInfo)
        Me.GBallTools.Controls.Add(Me.TxtToolName)
        Me.GBallTools.Controls.Add(Me.ButOpenTool)
        Me.GBallTools.Controls.Add(Me.ListTools)
        Me.GBallTools.Location = New System.Drawing.Point(9, 12)
        Me.GBallTools.Name = "GBallTools"
        Me.GBallTools.Size = New System.Drawing.Size(382, 358)
        Me.GBallTools.TabIndex = 1
        Me.GBallTools.TabStop = False
        Me.GBallTools.Text = "全部工具"
        '
        'TxtToolInfo
        '
        Me.TxtToolInfo.BackColor = System.Drawing.Color.White
        Me.TxtToolInfo.Location = New System.Drawing.Point(207, 51)
        Me.TxtToolInfo.Multiline = True
        Me.TxtToolInfo.Name = "TxtToolInfo"
        Me.TxtToolInfo.ReadOnly = True
        Me.TxtToolInfo.Size = New System.Drawing.Size(168, 254)
        Me.TxtToolInfo.TabIndex = 5
        Me.TxtToolInfo.TabStop = False
        '
        'TxtToolName
        '
        Me.TxtToolName.BackColor = System.Drawing.Color.White
        Me.TxtToolName.Location = New System.Drawing.Point(207, 20)
        Me.TxtToolName.Name = "TxtToolName"
        Me.TxtToolName.ReadOnly = True
        Me.TxtToolName.Size = New System.Drawing.Size(168, 25)
        Me.TxtToolName.TabIndex = 4
        Me.TxtToolName.TabStop = False
        '
        'ButOpenTool
        '
        Me.ButOpenTool.Enabled = False
        Me.ButOpenTool.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButOpenTool.Location = New System.Drawing.Point(207, 311)
        Me.ButOpenTool.Name = "ButOpenTool"
        Me.ButOpenTool.Size = New System.Drawing.Size(168, 39)
        Me.ButOpenTool.TabIndex = 2
        Me.ButOpenTool.TabStop = False
        Me.ButOpenTool.Text = "运行"
        Me.ButOpenTool.UseVisualStyleBackColor = True
        '
        'ListTools
        '
        Me.ListTools.FormattingEnabled = True
        Me.ListTools.ItemHeight = 19
        Me.ListTools.Location = New System.Drawing.Point(11, 23)
        Me.ListTools.Name = "ListTools"
        Me.ListTools.ScrollAlwaysVisible = True
        Me.ListTools.Size = New System.Drawing.Size(190, 327)
        Me.ListTools.Sorted = True
        Me.ListTools.TabIndex = 0
        Me.ListTools.TabStop = False
        '
        'GBpush
        '
        Me.GBpush.Controls.Add(Me.TxtPush)
        Me.GBpush.Location = New System.Drawing.Point(400, 12)
        Me.GBpush.Name = "GBpush"
        Me.GBpush.Size = New System.Drawing.Size(342, 120)
        Me.GBpush.TabIndex = 2
        Me.GBpush.TabStop = False
        Me.GBpush.Text = "推送："
        '
        'TxtPush
        '
        Me.TxtPush.BackColor = System.Drawing.Color.White
        Me.TxtPush.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtPush.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtPush.Location = New System.Drawing.Point(3, 21)
        Me.TxtPush.Multiline = True
        Me.TxtPush.Name = "TxtPush"
        Me.TxtPush.ReadOnly = True
        Me.TxtPush.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtPush.Size = New System.Drawing.Size(336, 96)
        Me.TxtPush.TabIndex = 0
        Me.TxtPush.TabStop = False
        '
        'LabAbout
        '
        Me.LabAbout.AutoSize = True
        Me.LabAbout.BackColor = System.Drawing.Color.Transparent
        Me.LabAbout.Location = New System.Drawing.Point(6, 20)
        Me.LabAbout.Name = "LabAbout"
        Me.LabAbout.Size = New System.Drawing.Size(209, 38)
        Me.LabAbout.TabIndex = 3
        Me.LabAbout.Text = "走過去的工具箱 Walkedby's Tools" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "编写：戈登走過去"
        '
        'GBabout
        '
        Me.GBabout.Controls.Add(Me.LabTime)
        Me.GBabout.Controls.Add(Me.LabAbout)
        Me.GBabout.Location = New System.Drawing.Point(397, 263)
        Me.GBabout.Name = "GBabout"
        Me.GBabout.Size = New System.Drawing.Size(339, 107)
        Me.GBabout.TabIndex = 4
        Me.GBabout.TabStop = False
        Me.GBabout.Text = "关于 "
        '
        'LabTime
        '
        Me.LabTime.AutoSize = True
        Me.LabTime.BackColor = System.Drawing.Color.Transparent
        Me.LabTime.Location = New System.Drawing.Point(6, 84)
        Me.LabTime.Name = "LabTime"
        Me.LabTime.Size = New System.Drawing.Size(74, 19)
        Me.LabTime.TabIndex = 4
        Me.LabTime.Text = "已经用了："
        '
        'Nico
        '
        Me.Nico.BalloonTipText = "走過去的工具箱"
        Me.Nico.ContextMenuStrip = Me.NicoMenu
        Me.Nico.Text = "走過去的工具箱"
        Me.Nico.Visible = True
        '
        'NicoMenu
        '
        Me.NicoMenu.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NicoMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.NicoMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.走過去的工具箱ToolStripMenuItem, Me.ToolStripSeparator1, Me.显示窗口ToolStripMenuItem, Me.返回主页ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.NicoMenu.Name = "NicoMenu"
        Me.NicoMenu.ShowItemToolTips = False
        Me.NicoMenu.Size = New System.Drawing.Size(181, 128)
        '
        '显示窗口ToolStripMenuItem
        '
        Me.显示窗口ToolStripMenuItem.Name = "显示窗口ToolStripMenuItem"
        Me.显示窗口ToolStripMenuItem.Size = New System.Drawing.Size(169, 24)
        Me.显示窗口ToolStripMenuItem.Text = "显示窗口"
        '
        '返回主页ToolStripMenuItem
        '
        Me.返回主页ToolStripMenuItem.Name = "返回主页ToolStripMenuItem"
        Me.返回主页ToolStripMenuItem.Size = New System.Drawing.Size(169, 24)
        Me.返回主页ToolStripMenuItem.Text = "返回主页"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(169, 24)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'LabFun
        '
        Me.LabFun.AutoSize = True
        Me.LabFun.Location = New System.Drawing.Point(17, 373)
        Me.LabFun.Name = "LabFun"
        Me.LabFun.Size = New System.Drawing.Size(40, 19)
        Me.LabFun.TabIndex = 5
        Me.LabFun.Text = "fun~"
        '
        'TimerC
        '
        Me.TimerC.Interval = 1000
        '
        'AutoSave
        '
        Me.AutoSave.Interval = 30000
        '
        'GBupdate
        '
        Me.GBupdate.Controls.Add(Me.TxtUpdate)
        Me.GBupdate.Location = New System.Drawing.Point(400, 138)
        Me.GBupdate.Name = "GBupdate"
        Me.GBupdate.Size = New System.Drawing.Size(342, 119)
        Me.GBupdate.TabIndex = 6
        Me.GBupdate.TabStop = False
        Me.GBupdate.Text = "新版本："
        '
        'TxtUpdate
        '
        Me.TxtUpdate.BackColor = System.Drawing.Color.White
        Me.TxtUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtUpdate.Location = New System.Drawing.Point(3, 21)
        Me.TxtUpdate.Multiline = True
        Me.TxtUpdate.Name = "TxtUpdate"
        Me.TxtUpdate.ReadOnly = True
        Me.TxtUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtUpdate.Size = New System.Drawing.Size(336, 95)
        Me.TxtUpdate.TabIndex = 0
        Me.TxtUpdate.TabStop = False
        Me.TxtUpdate.WordWrap = False
        '
        '走過去的工具箱ToolStripMenuItem
        '
        Me.走過去的工具箱ToolStripMenuItem.Name = "走過去的工具箱ToolStripMenuItem"
        Me.走過去的工具箱ToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.走過去的工具箱ToolStripMenuItem.Text = "走過去的工具箱"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        '启动器
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(754, 396)
        Me.Controls.Add(Me.GBupdate)
        Me.Controls.Add(Me.LabFun)
        Me.Controls.Add(Me.GBabout)
        Me.Controls.Add(Me.GBpush)
        Me.Controls.Add(Me.GBallTools)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "启动器"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "走過去的工具箱"
        Me.GBallTools.ResumeLayout(False)
        Me.GBallTools.PerformLayout()
        Me.GBpush.ResumeLayout(False)
        Me.GBpush.PerformLayout()
        Me.GBabout.ResumeLayout(False)
        Me.GBabout.PerformLayout()
        Me.NicoMenu.ResumeLayout(False)
        Me.GBupdate.ResumeLayout(False)
        Me.GBupdate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBallTools As GroupBox
    Friend WithEvents ListTools As ListBox
    Friend WithEvents ButOpenTool As Button
    Friend WithEvents GBpush As GroupBox
    Friend WithEvents TxtPush As TextBox
    Friend WithEvents LabAbout As Label
    Friend WithEvents GBabout As GroupBox
    Friend WithEvents Nico As NotifyIcon
    Friend WithEvents NicoMenu As ContextMenuStrip
    Friend WithEvents LabFun As Label
    Friend WithEvents TxtToolName As TextBox
    Friend WithEvents TxtToolInfo As TextBox
    Friend WithEvents LabTime As Label
    Friend WithEvents TimerC As Forms.Timer
    Friend WithEvents AutoSave As Forms.Timer
    Friend WithEvents GBupdate As GroupBox
    Friend WithEvents TxtUpdate As TextBox
    Friend WithEvents 显示窗口ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 返回主页ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 走過去的工具箱ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
