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
        Me.ButCheckBackup = New System.Windows.Forms.Button()
        Me.ButCreateSC = New System.Windows.Forms.Button()
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
        Me.Tabs.Size = New System.Drawing.Size(689, 277)
        Me.Tabs.TabIndex = 0
        Me.Tabs.TabStop = False
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.ButCheckBackup)
        Me.Tab1.Controls.Add(Me.ButCreateSC)
        Me.Tab1.Location = New System.Drawing.Point(4, 28)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(681, 245)
        Me.Tab1.TabIndex = 0
        Me.Tab1.Text = "杂项"
        Me.Tab1.UseVisualStyleBackColor = True
        '
        'ButCheckBackup
        '
        Me.ButCheckBackup.Enabled = False
        Me.ButCheckBackup.Location = New System.Drawing.Point(146, 180)
        Me.ButCheckBackup.Name = "ButCheckBackup"
        Me.ButCheckBackup.Size = New System.Drawing.Size(132, 53)
        Me.ButCheckBackup.TabIndex = 8
        Me.ButCheckBackup.TabStop = False
        Me.ButCheckBackup.Text = "查看备份文件夹"
        Me.ButCheckBackup.UseVisualStyleBackColor = True
        '
        'ButCreateSC
        '
        Me.ButCreateSC.Location = New System.Drawing.Point(8, 180)
        Me.ButCreateSC.Name = "ButCreateSC"
        Me.ButCreateSC.Size = New System.Drawing.Size(132, 53)
        Me.ButCreateSC.TabIndex = 6
        Me.ButCreateSC.TabStop = False
        Me.ButCreateSC.Text = "在桌面上建立" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "本程序的快捷方式"
        Me.ButCreateSC.UseVisualStyleBackColor = True
        '
        '程序设置
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(689, 277)
        Me.Controls.Add(Me.Tabs)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "程序设置"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "工具箱设置"
        Me.Tabs.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tabs As TabControl
    Friend WithEvents Tab1 As TabPage
    Friend WithEvents ButCreateSC As Button
    Friend WithEvents ButCheckBackup As Button
End Class
