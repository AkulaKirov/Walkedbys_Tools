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
        Me.ButAddToFavor = New System.Windows.Forms.Button()
        Me.ButOpenTool = New System.Windows.Forms.Button()
        Me.TxtToolDes = New System.Windows.Forms.TextBox()
        Me.ListTools = New System.Windows.Forms.ListBox()
        Me.GBupdate = New System.Windows.Forms.GroupBox()
        Me.TxtUpdate = New System.Windows.Forms.TextBox()
        Me.LabAbout = New System.Windows.Forms.Label()
        Me.GBabout = New System.Windows.Forms.GroupBox()
        Me.TimerX = New System.Windows.Forms.Timer(Me.components)
        Me.Nico = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NicoMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.显示窗口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.返回启动器ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GBallTools.SuspendLayout()
        Me.GBupdate.SuspendLayout()
        Me.GBabout.SuspendLayout()
        Me.NicoMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBfavorites
        '
        Me.GBfavorites.Location = New System.Drawing.Point(12, 3)
        Me.GBfavorites.Name = "GBfavorites"
        Me.GBfavorites.Size = New System.Drawing.Size(730, 117)
        Me.GBfavorites.TabIndex = 0
        Me.GBfavorites.TabStop = False
        Me.GBfavorites.Text = "工具收藏夹"
        '
        'GBallTools
        '
        Me.GBallTools.Controls.Add(Me.ButAddToFavor)
        Me.GBallTools.Controls.Add(Me.ButOpenTool)
        Me.GBallTools.Controls.Add(Me.TxtToolDes)
        Me.GBallTools.Controls.Add(Me.ListTools)
        Me.GBallTools.Location = New System.Drawing.Point(12, 126)
        Me.GBallTools.Name = "GBallTools"
        Me.GBallTools.Size = New System.Drawing.Size(382, 235)
        Me.GBallTools.TabIndex = 1
        Me.GBallTools.TabStop = False
        Me.GBallTools.Text = "全部工具"
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
        'TxtToolDes
        '
        Me.TxtToolDes.Location = New System.Drawing.Point(207, 20)
        Me.TxtToolDes.Multiline = True
        Me.TxtToolDes.Name = "TxtToolDes"
        Me.TxtToolDes.ReadOnly = True
        Me.TxtToolDes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtToolDes.Size = New System.Drawing.Size(168, 166)
        Me.TxtToolDes.TabIndex = 1
        Me.TxtToolDes.TabStop = False
        Me.TxtToolDes.Text = "请从左边的列表里选择一个工具"
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
        Me.GBupdate.Location = New System.Drawing.Point(400, 126)
        Me.GBupdate.Name = "GBupdate"
        Me.GBupdate.Size = New System.Drawing.Size(342, 121)
        Me.GBupdate.TabIndex = 2
        Me.GBupdate.TabStop = False
        Me.GBupdate.Text = "新消息："
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
        Me.GBabout.Controls.Add(Me.LabAbout)
        Me.GBabout.Location = New System.Drawing.Point(400, 254)
        Me.GBabout.Name = "GBabout"
        Me.GBabout.Size = New System.Drawing.Size(339, 107)
        Me.GBabout.TabIndex = 4
        Me.GBabout.TabStop = False
        Me.GBabout.Text = "关于 "
        '
        'TimerX
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
        '启动器
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(754, 381)
        Me.Controls.Add(Me.GBabout)
        Me.Controls.Add(Me.GBupdate)
        Me.Controls.Add(Me.GBallTools)
        Me.Controls.Add(Me.GBfavorites)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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

    End Sub

    Friend WithEvents GBfavorites As GroupBox
    Friend WithEvents GBallTools As GroupBox
    Friend WithEvents ListTools As ListBox
    Friend WithEvents TxtToolDes As TextBox
    Friend WithEvents ButOpenTool As Button
    Friend WithEvents ButAddToFavor As Button
    Friend WithEvents GBupdate As GroupBox
    Friend WithEvents TxtUpdate As TextBox
    Friend WithEvents LabAbout As Label
    Friend WithEvents GBabout As GroupBox
    Friend WithEvents TimerX As System.Windows.Forms.Timer
    Friend WithEvents Nico As NotifyIcon
    Friend WithEvents NicoMenu As ContextMenuStrip
    Friend WithEvents 显示窗口ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 返回启动器ToolStripMenuItem As ToolStripMenuItem
End Class
