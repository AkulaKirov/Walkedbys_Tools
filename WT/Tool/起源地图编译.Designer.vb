<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 起源地图编译
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
        Me.LabMap = New System.Windows.Forms.Label()
        Me.TxtMap = New System.Windows.Forms.TextBox()
        Me.LabBin = New System.Windows.Forms.Label()
        Me.TxtBin = New System.Windows.Forms.TextBox()
        Me.LabThread = New System.Windows.Forms.Label()
        Me.TxtThread = New System.Windows.Forms.NumericUpDown()
        Me.ListMod = New System.Windows.Forms.ComboBox()
        Me.LabGame = New System.Windows.Forms.Label()
        Me.ListGame = New System.Windows.Forms.ComboBox()
        Me.CheckCopyMap = New System.Windows.Forms.CheckBox()
        Me.CheckOpenGame = New System.Windows.Forms.CheckBox()
        Me.TxtGame = New System.Windows.Forms.TextBox()
        Me.ButStart = New System.Windows.Forms.Button()
        Me.Cooldown = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TxtThread, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabMap
        '
        Me.LabMap.AutoSize = True
        Me.LabMap.Location = New System.Drawing.Point(12, 9)
        Me.LabMap.Name = "LabMap"
        Me.LabMap.Size = New System.Drawing.Size(79, 20)
        Me.LabMap.TabIndex = 0
        Me.LabMap.Text = "地图文件："
        '
        'TxtMap
        '
        Me.TxtMap.Location = New System.Drawing.Point(97, 9)
        Me.TxtMap.MaxLength = 200
        Me.TxtMap.Name = "TxtMap"
        Me.TxtMap.Size = New System.Drawing.Size(690, 25)
        Me.TxtMap.TabIndex = 1
        '
        'LabBin
        '
        Me.LabBin.AutoSize = True
        Me.LabBin.Location = New System.Drawing.Point(12, 44)
        Me.LabBin.Name = "LabBin"
        Me.LabBin.Size = New System.Drawing.Size(93, 20)
        Me.LabBin.TabIndex = 2
        Me.LabBin.Text = "游戏文件夹："
        '
        'TxtBin
        '
        Me.TxtBin.Location = New System.Drawing.Point(111, 41)
        Me.TxtBin.MaxLength = 200
        Me.TxtBin.Name = "TxtBin"
        Me.TxtBin.Size = New System.Drawing.Size(521, 25)
        Me.TxtBin.TabIndex = 3
        '
        'LabThread
        '
        Me.LabThread.AutoSize = True
        Me.LabThread.Location = New System.Drawing.Point(12, 81)
        Me.LabThread.Name = "LabThread"
        Me.LabThread.Size = New System.Drawing.Size(247, 20)
        Me.LabThread.TabIndex = 4
        Me.LabThread.Text = "线程数量（推荐设置为CPU核心数）："
        '
        'TxtThread
        '
        Me.TxtThread.Location = New System.Drawing.Point(265, 81)
        Me.TxtThread.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.TxtThread.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TxtThread.Name = "TxtThread"
        Me.TxtThread.Size = New System.Drawing.Size(82, 25)
        Me.TxtThread.TabIndex = 5
        Me.TxtThread.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ListMod
        '
        Me.ListMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListMod.FormattingEnabled = True
        Me.ListMod.Location = New System.Drawing.Point(638, 40)
        Me.ListMod.Name = "ListMod"
        Me.ListMod.Size = New System.Drawing.Size(149, 27)
        Me.ListMod.TabIndex = 6
        '
        'LabGame
        '
        Me.LabGame.AutoSize = True
        Me.LabGame.Location = New System.Drawing.Point(12, 227)
        Me.LabGame.Name = "LabGame"
        Me.LabGame.Size = New System.Drawing.Size(149, 20)
        Me.LabGame.TabIndex = 7
        Me.LabGame.Text = "游戏程序及附加参数："
        '
        'ListGame
        '
        Me.ListGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListGame.FormattingEnabled = True
        Me.ListGame.Location = New System.Drawing.Point(167, 224)
        Me.ListGame.Name = "ListGame"
        Me.ListGame.Size = New System.Drawing.Size(149, 27)
        Me.ListGame.TabIndex = 8
        '
        'CheckCopyMap
        '
        Me.CheckCopyMap.AutoSize = True
        Me.CheckCopyMap.Location = New System.Drawing.Point(12, 257)
        Me.CheckCopyMap.Name = "CheckCopyMap"
        Me.CheckCopyMap.Size = New System.Drawing.Size(250, 24)
        Me.CheckCopyMap.TabIndex = 9
        Me.CheckCopyMap.TabStop = False
        Me.CheckCopyMap.Text = "完成后复制bsp文件去 maps 文件夹"
        Me.CheckCopyMap.UseVisualStyleBackColor = True
        '
        'CheckOpenGame
        '
        Me.CheckOpenGame.AutoSize = True
        Me.CheckOpenGame.Location = New System.Drawing.Point(322, 257)
        Me.CheckOpenGame.Name = "CheckOpenGame"
        Me.CheckOpenGame.Size = New System.Drawing.Size(182, 24)
        Me.CheckOpenGame.TabIndex = 10
        Me.CheckOpenGame.TabStop = False
        Me.CheckOpenGame.Text = "完成后打开游戏载入地图"
        Me.CheckOpenGame.UseVisualStyleBackColor = True
        '
        'TxtGame
        '
        Me.TxtGame.Location = New System.Drawing.Point(322, 224)
        Me.TxtGame.MaxLength = 200
        Me.TxtGame.Name = "TxtGame"
        Me.TxtGame.Size = New System.Drawing.Size(465, 25)
        Me.TxtGame.TabIndex = 11
        '
        'ButStart
        '
        Me.ButStart.Enabled = False
        Me.ButStart.Location = New System.Drawing.Point(12, 287)
        Me.ButStart.Name = "ButStart"
        Me.ButStart.Size = New System.Drawing.Size(193, 45)
        Me.ButStart.TabIndex = 12
        Me.ButStart.Text = "开始编译"
        Me.ButStart.UseVisualStyleBackColor = True
        '
        'Cooldown
        '
        Me.Cooldown.Interval = 800
        '
        '起源地图编译
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(799, 349)
        Me.Controls.Add(Me.ButStart)
        Me.Controls.Add(Me.TxtGame)
        Me.Controls.Add(Me.CheckOpenGame)
        Me.Controls.Add(Me.CheckCopyMap)
        Me.Controls.Add(Me.ListGame)
        Me.Controls.Add(Me.LabGame)
        Me.Controls.Add(Me.ListMod)
        Me.Controls.Add(Me.TxtThread)
        Me.Controls.Add(Me.LabThread)
        Me.Controls.Add(Me.TxtBin)
        Me.Controls.Add(Me.LabBin)
        Me.Controls.Add(Me.TxtMap)
        Me.Controls.Add(Me.LabMap)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "起源地图编译"
        Me.Text = "起源地图编译器"
        CType(Me.TxtThread, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabMap As Label
    Friend WithEvents TxtMap As TextBox
    Friend WithEvents LabBin As Label
    Friend WithEvents TxtBin As TextBox
    Friend WithEvents LabThread As Label
    Friend WithEvents TxtThread As NumericUpDown
    Friend WithEvents ListMod As ComboBox
    Friend WithEvents LabGame As Label
    Friend WithEvents ListGame As ComboBox
    Friend WithEvents CheckCopyMap As CheckBox
    Friend WithEvents CheckOpenGame As CheckBox
    Friend WithEvents TxtGame As TextBox
    Friend WithEvents ButStart As Button
    Friend WithEvents Cooldown As Forms.Timer
End Class
