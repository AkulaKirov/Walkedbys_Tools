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
        Me.GBfavorites = New System.Windows.Forms.GroupBox()
        Me.GBallTools = New System.Windows.Forms.GroupBox()
        Me.ButShortCut = New System.Windows.Forms.Button()
        Me.TxtToolID = New System.Windows.Forms.TextBox()
        Me.TxtToolInfo = New System.Windows.Forms.TextBox()
        Me.TxtToolName = New System.Windows.Forms.TextBox()
        Me.ButAddToFavor = New System.Windows.Forms.Button()
        Me.ButOpenTool = New System.Windows.Forms.Button()
        Me.ListTools = New System.Windows.Forms.ListBox()
        Me.GBupdate = New System.Windows.Forms.GroupBox()
        Me.TxtUpdate = New System.Windows.Forms.TextBox()
        Me.LabAbout = New System.Windows.Forms.Label()
        Me.GBabout = New System.Windows.Forms.GroupBox()
        Me.LabTime = New System.Windows.Forms.Label()
        Me.Opener = New System.Windows.Forms.Timer(Me.components)
        Me.Nico = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NicoMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.显示窗口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.返回启动器ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabFun = New System.Windows.Forms.Label()
        Me.TimerC = New System.Windows.Forms.Timer(Me.components)
        Me.AutoSave = New System.Windows.Forms.Timer(Me.components)
        Me.GBallTools.SuspendLayout()
        Me.GBupdate.SuspendLayout()
        Me.GBabout.SuspendLayout()
        Me.NicoMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBfavorites
        '
        Me.GBfavorites.Location = New System.Drawing.Point(9, 12)
        Me.GBfavorites.Name = "GBfavorites"
        Me.GBfavorites.Size = New System.Drawing.Size(730, 117)
        Me.GBfavorites.TabIndex = 0
        Me.GBfavorites.TabStop = False
        Me.GBfavorites.Text = "工具收藏夹"
        '
        'GBallTools
        '
        Me.GBallTools.Controls.Add(Me.ButShortCut)
        Me.GBallTools.Controls.Add(Me.TxtToolID)
        Me.GBallTools.Controls.Add(Me.TxtToolInfo)
        Me.GBallTools.Controls.Add(Me.TxtToolName)
        Me.GBallTools.Controls.Add(Me.ButAddToFavor)
        Me.GBallTools.Controls.Add(Me.ButOpenTool)
        Me.GBallTools.Controls.Add(Me.ListTools)
        Me.GBallTools.Location = New System.Drawing.Point(9, 135)
        Me.GBallTools.Name = "GBallTools"
        Me.GBallTools.Size = New System.Drawing.Size(382, 235)
        Me.GBallTools.TabIndex = 1
        Me.GBallTools.TabStop = False
        Me.GBallTools.Text = "全部工具"
        '
        'ButShortCut
        '
        Me.ButShortCut.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButShortCut.Location = New System.Drawing.Point(341, 50)
        Me.ButShortCut.Name = "ButShortCut"
        Me.ButShortCut.Size = New System.Drawing.Size(34, 24)
        Me.ButShortCut.TabIndex = 7
        Me.ButShortCut.TabStop = False
        Me.ButShortCut.Text = "？"
        Me.ButShortCut.UseVisualStyleBackColor = True
        '
        'TxtToolID
        '
        Me.TxtToolID.Location = New System.Drawing.Point(207, 50)
        Me.TxtToolID.Name = "TxtToolID"
        Me.TxtToolID.ReadOnly = True
        Me.TxtToolID.Size = New System.Drawing.Size(128, 24)
        Me.TxtToolID.TabIndex = 6
        Me.TxtToolID.TabStop = False
        '
        'TxtToolInfo
        '
        Me.TxtToolInfo.Location = New System.Drawing.Point(207, 80)
        Me.TxtToolInfo.Multiline = True
        Me.TxtToolInfo.Name = "TxtToolInfo"
        Me.TxtToolInfo.ReadOnly = True
        Me.TxtToolInfo.Size = New System.Drawing.Size(168, 104)
        Me.TxtToolInfo.TabIndex = 5
        Me.TxtToolInfo.TabStop = False
        '
        'TxtToolName
        '
        Me.TxtToolName.Location = New System.Drawing.Point(207, 20)
        Me.TxtToolName.Name = "TxtToolName"
        Me.TxtToolName.ReadOnly = True
        Me.TxtToolName.Size = New System.Drawing.Size(168, 24)
        Me.TxtToolName.TabIndex = 4
        Me.TxtToolName.TabStop = False
        '
        'ButAddToFavor
        '
        Me.ButAddToFavor.Enabled = False
        Me.ButAddToFavor.Location = New System.Drawing.Point(284, 190)
        Me.ButAddToFavor.Name = "ButAddToFavor"
        Me.ButAddToFavor.Size = New System.Drawing.Size(91, 39)
        Me.ButAddToFavor.TabIndex = 3
        Me.ButAddToFavor.TabStop = False
        Me.ButAddToFavor.Text = "收藏"
        Me.ButAddToFavor.UseVisualStyleBackColor = True
        '
        'ButOpenTool
        '
        Me.ButOpenTool.Enabled = False
        Me.ButOpenTool.Location = New System.Drawing.Point(207, 190)
        Me.ButOpenTool.Name = "ButOpenTool"
        Me.ButOpenTool.Size = New System.Drawing.Size(71, 39)
        Me.ButOpenTool.TabIndex = 2
        Me.ButOpenTool.TabStop = False
        Me.ButOpenTool.Text = "运行"
        Me.ButOpenTool.UseVisualStyleBackColor = True
        '
        'ListTools
        '
        Me.ListTools.FormattingEnabled = True
        Me.ListTools.ItemHeight = 17
        Me.ListTools.Location = New System.Drawing.Point(11, 23)
        Me.ListTools.Name = "ListTools"
        Me.ListTools.ScrollAlwaysVisible = True
        Me.ListTools.Size = New System.Drawing.Size(190, 208)
        Me.ListTools.Sorted = True
        Me.ListTools.TabIndex = 0
        Me.ListTools.TabStop = False
        '
        'GBupdate
        '
        Me.GBupdate.Controls.Add(Me.TxtUpdate)
        Me.GBupdate.Location = New System.Drawing.Point(400, 135)
        Me.GBupdate.Name = "GBupdate"
        Me.GBupdate.Size = New System.Drawing.Size(342, 121)
        Me.GBupdate.TabIndex = 2
        Me.GBupdate.TabStop = False
        Me.GBupdate.Text = "推送："
        '
        'TxtUpdate
        '
        Me.TxtUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtUpdate.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.TxtUpdate.Location = New System.Drawing.Point(3, 20)
        Me.TxtUpdate.Multiline = True
        Me.TxtUpdate.Name = "TxtUpdate"
        Me.TxtUpdate.ReadOnly = True
        Me.TxtUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtUpdate.Size = New System.Drawing.Size(336, 98)
        Me.TxtUpdate.TabIndex = 0
        Me.TxtUpdate.TabStop = False
        '
        'LabAbout
        '
        Me.LabAbout.AutoSize = True
        Me.LabAbout.BackColor = System.Drawing.Color.Transparent
        Me.LabAbout.Location = New System.Drawing.Point(6, 20)
        Me.LabAbout.Name = "LabAbout"
        Me.LabAbout.Size = New System.Drawing.Size(208, 34)
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
        Me.LabTime.Size = New System.Drawing.Size(73, 17)
        Me.LabTime.TabIndex = 4
        Me.LabTime.Text = "已经用了："
        '
        'Opener
        '
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
        Me.NicoMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.显示窗口ToolStripMenuItem, Me.返回启动器ToolStripMenuItem})
        Me.NicoMenu.Name = "NicoMenu"
        Me.NicoMenu.ShowItemToolTips = False
        Me.NicoMenu.Size = New System.Drawing.Size(131, 52)
        '
        '显示窗口ToolStripMenuItem
        '
        Me.显示窗口ToolStripMenuItem.Name = "显示窗口ToolStripMenuItem"
        Me.显示窗口ToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.显示窗口ToolStripMenuItem.Text = "显示窗口"
        '
        '返回启动器ToolStripMenuItem
        '
        Me.返回启动器ToolStripMenuItem.Name = "返回启动器ToolStripMenuItem"
        Me.返回启动器ToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.返回启动器ToolStripMenuItem.Text = "返回主页"
        '
        'LabFun
        '
        Me.LabFun.AutoSize = True
        Me.LabFun.Location = New System.Drawing.Point(17, 373)
        Me.LabFun.Name = "LabFun"
        Me.LabFun.Size = New System.Drawing.Size(39, 17)
        Me.LabFun.TabIndex = 5
        Me.LabFun.Text = "fun~"
        '
        'TimerC
        '
        Me.TimerC.Interval = 1000
        '
        'AutoSave
        '
        Me.AutoSave.Interval = 20000
        '
        '启动器
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(754, 396)
        Me.Controls.Add(Me.LabFun)
        Me.Controls.Add(Me.GBabout)
        Me.Controls.Add(Me.GBupdate)
        Me.Controls.Add(Me.GBallTools)
        Me.Controls.Add(Me.GBfavorites)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "启动器"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "走過去的工具箱"
        Me.GBallTools.ResumeLayout(False)
        Me.GBallTools.PerformLayout()
        Me.GBupdate.ResumeLayout(False)
        Me.GBupdate.PerformLayout()
        Me.GBabout.ResumeLayout(False)
        Me.GBabout.PerformLayout()
        Me.NicoMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBfavorites As GroupBox
    Friend WithEvents GBallTools As GroupBox
    Friend WithEvents ListTools As ListBox
    Friend WithEvents ButOpenTool As Button
    Friend WithEvents ButAddToFavor As Button
    Friend WithEvents GBupdate As GroupBox
    Friend WithEvents TxtUpdate As TextBox
    Friend WithEvents LabAbout As Label
    Friend WithEvents GBabout As GroupBox
    Friend WithEvents Opener As System.Windows.Forms.Timer
    Friend WithEvents Nico As NotifyIcon
    Friend WithEvents NicoMenu As ContextMenuStrip
    Friend WithEvents 显示窗口ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 返回启动器ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabFun As Label
    Friend WithEvents TxtToolName As TextBox
    Friend WithEvents TxtToolInfo As TextBox
    Friend WithEvents LabTime As Label
    Friend WithEvents TimerC As Forms.Timer
    Friend WithEvents AutoSave As Forms.Timer
    Friend WithEvents TxtToolID As TextBox
    Friend WithEvents ButShortCut As Button
End Class
