<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 程序设置
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
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.ButCreateSC = New System.Windows.Forms.Button()
        Me.CheckStartUP = New System.Windows.Forms.CheckBox()
        Me.CheckHide = New System.Windows.Forms.CheckBox()
        Me.CheckUpdate = New System.Windows.Forms.CheckBox()
        Me.CheckExit = New System.Windows.Forms.CheckBox()
        Me.Tabs.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.Tab1)
        Me.Tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabs.Location = New System.Drawing.Point(0, 0)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(494, 276)
        Me.Tabs.TabIndex = 0
        Me.Tabs.TabStop = False
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.ButCreateSC)
        Me.Tab1.Controls.Add(Me.CheckStartUP)
        Me.Tab1.Controls.Add(Me.CheckHide)
        Me.Tab1.Controls.Add(Me.CheckUpdate)
        Me.Tab1.Controls.Add(Me.CheckExit)
        Me.Tab1.Location = New System.Drawing.Point(4, 28)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(486, 244)
        Me.Tab1.TabIndex = 0
        Me.Tab1.Text = "杂项"
        Me.Tab1.UseVisualStyleBackColor = True
        '
        'ButCreateSC
        '
        Me.ButCreateSC.Location = New System.Drawing.Point(346, 177)
        Me.ButCreateSC.Name = "ButCreateSC"
        Me.ButCreateSC.Size = New System.Drawing.Size(132, 53)
        Me.ButCreateSC.TabIndex = 6
        Me.ButCreateSC.TabStop = False
        Me.ButCreateSC.Text = "在桌面上建立" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "本程序的快捷方式"
        Me.ButCreateSC.UseVisualStyleBackColor = True
        '
        'CheckStartUP
        '
        Me.CheckStartUP.AutoSize = True
        Me.CheckStartUP.Location = New System.Drawing.Point(3, 89)
        Me.CheckStartUP.Name = "CheckStartUP"
        Me.CheckStartUP.Size = New System.Drawing.Size(275, 23)
        Me.CheckStartUP.TabIndex = 5
        Me.CheckStartUP.TabStop = False
        Me.CheckStartUP.Text = "开机启动本程序（可能会被安全软件拦截）"
        Me.CheckStartUP.UseVisualStyleBackColor = True
        '
        'CheckHide
        '
        Me.CheckHide.AutoSize = True
        Me.CheckHide.Location = New System.Drawing.Point(6, 6)
        Me.CheckHide.Name = "CheckHide"
        Me.CheckHide.Size = New System.Drawing.Size(340, 23)
        Me.CheckHide.TabIndex = 2
        Me.CheckHide.TabStop = False
        Me.CheckHide.Text = "最小化的时候停留在任务栏里，而不是直接隐藏到后台"
        Me.CheckHide.UseVisualStyleBackColor = True
        '
        'CheckUpdate
        '
        Me.CheckUpdate.AutoSize = True
        Me.CheckUpdate.Location = New System.Drawing.Point(6, 60)
        Me.CheckUpdate.Name = "CheckUpdate"
        Me.CheckUpdate.Size = New System.Drawing.Size(392, 23)
        Me.CheckUpdate.TabIndex = 1
        Me.CheckUpdate.TabStop = False
        Me.CheckUpdate.Text = "启动程序的时候不检查更新（关闭后请自行去我博客查询更新）"
        Me.CheckUpdate.UseVisualStyleBackColor = True
        '
        'CheckExit
        '
        Me.CheckExit.AutoSize = True
        Me.CheckExit.Location = New System.Drawing.Point(6, 33)
        Me.CheckExit.Name = "CheckExit"
        Me.CheckExit.Size = New System.Drawing.Size(314, 23)
        Me.CheckExit.TabIndex = 0
        Me.CheckExit.TabStop = False
        Me.CheckExit.Text = "关闭主页的时候直接退出程序，而不是隐藏到后台"
        Me.CheckExit.UseVisualStyleBackColor = True
        '
        '程序设置
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(494, 276)
        Me.Controls.Add(Me.Tabs)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "程序设置"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "程序设置"
        Me.Tabs.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tabs As TabControl
    Friend WithEvents Tab1 As TabPage
    Friend WithEvents CheckExit As CheckBox
    Friend WithEvents CheckUpdate As CheckBox
    Friend WithEvents CheckHide As CheckBox
    Friend WithEvents CheckStartUP As CheckBox
    Friend WithEvents ButCreateSC As Button
End Class
