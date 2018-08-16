<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 后台键盘指令
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
        Me.ListTemps = New System.Windows.Forms.ComboBox()
        Me.LabList = New System.Windows.Forms.Label()
        Me.CheckEnabled = New System.Windows.Forms.CheckBox()
        Me.LabKeys = New System.Windows.Forms.Label()
        Me.TxtBind1 = New System.Windows.Forms.TextBox()
        Me.ButAdd = New System.Windows.Forms.Button()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.ButDEl = New System.Windows.Forms.Button()
        Me.ButUSE = New System.Windows.Forms.Button()
        Me.LabEN = New System.Windows.Forms.Label()
        Me.ListEN = New System.Windows.Forms.ListBox()
        Me.LabWhen = New System.Windows.Forms.Label()
        Me.ListWhen = New System.Windows.Forms.ComboBox()
        Me.Watching = New System.Windows.Forms.Timer(Me.components)
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.TabOpen = New System.Windows.Forms.TabPage()
        Me.TxtOpen = New System.Windows.Forms.TextBox()
        Me.TabShut = New System.Windows.Forms.TabPage()
        Me.TxtShut = New System.Windows.Forms.TextBox()
        Me.TxtBind2 = New System.Windows.Forms.TextBox()
        Me.TxtBind3 = New System.Windows.Forms.TextBox()
        Me.TxtBind4 = New System.Windows.Forms.TextBox()
        Me.TxtBind0 = New System.Windows.Forms.TextBox()
        Me.Tabs.SuspendLayout()
        Me.TabOpen.SuspendLayout()
        Me.TabShut.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListTemps
        '
        Me.ListTemps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListTemps.FormattingEnabled = True
        Me.ListTemps.Location = New System.Drawing.Point(140, 6)
        Me.ListTemps.Name = "ListTemps"
        Me.ListTemps.Size = New System.Drawing.Size(217, 27)
        Me.ListTemps.TabIndex = 0
        Me.ListTemps.TabStop = False
        '
        'LabList
        '
        Me.LabList.AutoSize = True
        Me.LabList.Location = New System.Drawing.Point(8, 9)
        Me.LabList.Name = "LabList"
        Me.LabList.Size = New System.Drawing.Size(126, 19)
        Me.LabList.TabIndex = 1
        Me.LabList.Text = "选择已保存的方案："
        '
        'CheckEnabled
        '
        Me.CheckEnabled.AutoSize = True
        Me.CheckEnabled.Location = New System.Drawing.Point(12, 43)
        Me.CheckEnabled.Name = "CheckEnabled"
        Me.CheckEnabled.Size = New System.Drawing.Size(54, 23)
        Me.CheckEnabled.TabIndex = 2
        Me.CheckEnabled.TabStop = False
        Me.CheckEnabled.Text = "启用"
        Me.CheckEnabled.UseVisualStyleBackColor = True
        '
        'LabKeys
        '
        Me.LabKeys.AutoSize = True
        Me.LabKeys.Location = New System.Drawing.Point(8, 69)
        Me.LabKeys.Name = "LabKeys"
        Me.LabKeys.Size = New System.Drawing.Size(230, 19)
        Me.LabKeys.TabIndex = 3
        Me.LabKeys.Text = "选择要绑定的按键（鼠标单击清空）："
        '
        'TxtBind1
        '
        Me.TxtBind1.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtBind1.Location = New System.Drawing.Point(79, 91)
        Me.TxtBind1.MaxLength = 10
        Me.TxtBind1.Name = "TxtBind1"
        Me.TxtBind1.ShortcutsEnabled = False
        Me.TxtBind1.Size = New System.Drawing.Size(65, 22)
        Me.TxtBind1.TabIndex = 4
        Me.TxtBind1.TabStop = False
        Me.TxtBind1.Tag = "1"
        '
        'ButAdd
        '
        Me.ButAdd.Enabled = False
        Me.ButAdd.Location = New System.Drawing.Point(140, 256)
        Me.ButAdd.Name = "ButAdd"
        Me.ButAdd.Size = New System.Drawing.Size(102, 32)
        Me.ButAdd.TabIndex = 5
        Me.ButAdd.TabStop = False
        Me.ButAdd.Text = "新建方案"
        Me.ButAdd.UseVisualStyleBackColor = True
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(11, 260)
        Me.TxtName.MaxLength = 10
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(123, 25)
        Me.TxtName.TabIndex = 6
        Me.TxtName.TabStop = False
        '
        'ButDEl
        '
        Me.ButDEl.Enabled = False
        Me.ButDEl.Location = New System.Drawing.Point(248, 256)
        Me.ButDEl.Name = "ButDEl"
        Me.ButDEl.Size = New System.Drawing.Size(110, 32)
        Me.ButDEl.TabIndex = 7
        Me.ButDEl.TabStop = False
        Me.ButDEl.Text = "删除此方案"
        Me.ButDEl.UseVisualStyleBackColor = True
        '
        'ButUSE
        '
        Me.ButUSE.BackColor = System.Drawing.Color.Transparent
        Me.ButUSE.Location = New System.Drawing.Point(243, 36)
        Me.ButUSE.Name = "ButUSE"
        Me.ButUSE.Size = New System.Drawing.Size(114, 35)
        Me.ButUSE.TabIndex = 8
        Me.ButUSE.TabStop = False
        Me.ButUSE.Text = "读取此方案"
        Me.ButUSE.UseVisualStyleBackColor = False
        '
        'LabEN
        '
        Me.LabEN.AutoSize = True
        Me.LabEN.Location = New System.Drawing.Point(360, 6)
        Me.LabEN.Name = "LabEN"
        Me.LabEN.Size = New System.Drawing.Size(100, 19)
        Me.LabEN.TabIndex = 11
        Me.LabEN.Text = "已启用的模板："
        '
        'ListEN
        '
        Me.ListEN.FormattingEnabled = True
        Me.ListEN.ItemHeight = 19
        Me.ListEN.Location = New System.Drawing.Point(364, 31)
        Me.ListEN.Name = "ListEN"
        Me.ListEN.Size = New System.Drawing.Size(232, 232)
        Me.ListEN.TabIndex = 12
        Me.ListEN.TabStop = False
        '
        'LabWhen
        '
        Me.LabWhen.AutoSize = True
        Me.LabWhen.Location = New System.Drawing.Point(364, 270)
        Me.LabWhen.Name = "LabWhen"
        Me.LabWhen.Size = New System.Drawing.Size(74, 19)
        Me.LabWhen.TabIndex = 13
        Me.LabWhen.Text = "何时工作："
        '
        'ListWhen
        '
        Me.ListWhen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListWhen.FormattingEnabled = True
        Me.ListWhen.Items.AddRange(New Object() {"只在本工具运行时工作", "工具箱运行时工作", "现在不工作"})
        Me.ListWhen.Location = New System.Drawing.Point(444, 267)
        Me.ListWhen.Name = "ListWhen"
        Me.ListWhen.Size = New System.Drawing.Size(152, 27)
        Me.ListWhen.TabIndex = 14
        Me.ListWhen.TabStop = False
        '
        'Watching
        '
        Me.Watching.Enabled = True
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.TabOpen)
        Me.Tabs.Controls.Add(Me.TabShut)
        Me.Tabs.Location = New System.Drawing.Point(11, 119)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(347, 135)
        Me.Tabs.TabIndex = 15
        '
        'TabOpen
        '
        Me.TabOpen.Controls.Add(Me.TxtOpen)
        Me.TabOpen.Location = New System.Drawing.Point(4, 28)
        Me.TabOpen.Name = "TabOpen"
        Me.TabOpen.Padding = New System.Windows.Forms.Padding(3)
        Me.TabOpen.Size = New System.Drawing.Size(339, 103)
        Me.TabOpen.TabIndex = 0
        Me.TabOpen.Text = "要打开的"
        Me.TabOpen.UseVisualStyleBackColor = True
        '
        'TxtOpen
        '
        Me.TxtOpen.AllowDrop = True
        Me.TxtOpen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtOpen.Location = New System.Drawing.Point(3, 3)
        Me.TxtOpen.MaxLength = 1000
        Me.TxtOpen.Multiline = True
        Me.TxtOpen.Name = "TxtOpen"
        Me.TxtOpen.Size = New System.Drawing.Size(333, 97)
        Me.TxtOpen.TabIndex = 0
        Me.TxtOpen.TabStop = False
        '
        'TabShut
        '
        Me.TabShut.Controls.Add(Me.TxtShut)
        Me.TabShut.Location = New System.Drawing.Point(4, 28)
        Me.TabShut.Name = "TabShut"
        Me.TabShut.Padding = New System.Windows.Forms.Padding(3)
        Me.TabShut.Size = New System.Drawing.Size(339, 103)
        Me.TabShut.TabIndex = 1
        Me.TabShut.Text = "要关闭的"
        Me.TabShut.UseVisualStyleBackColor = True
        '
        'TxtShut
        '
        Me.TxtShut.AllowDrop = True
        Me.TxtShut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtShut.Location = New System.Drawing.Point(3, 3)
        Me.TxtShut.MaxLength = 1000
        Me.TxtShut.Multiline = True
        Me.TxtShut.Name = "TxtShut"
        Me.TxtShut.Size = New System.Drawing.Size(333, 97)
        Me.TxtShut.TabIndex = 1
        Me.TxtShut.TabStop = False
        '
        'TxtBind2
        '
        Me.TxtBind2.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtBind2.Location = New System.Drawing.Point(150, 91)
        Me.TxtBind2.MaxLength = 10
        Me.TxtBind2.Name = "TxtBind2"
        Me.TxtBind2.ShortcutsEnabled = False
        Me.TxtBind2.Size = New System.Drawing.Size(65, 22)
        Me.TxtBind2.TabIndex = 16
        Me.TxtBind2.TabStop = False
        Me.TxtBind2.Tag = "1"
        '
        'TxtBind3
        '
        Me.TxtBind3.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtBind3.Location = New System.Drawing.Point(221, 91)
        Me.TxtBind3.MaxLength = 10
        Me.TxtBind3.Name = "TxtBind3"
        Me.TxtBind3.ShortcutsEnabled = False
        Me.TxtBind3.Size = New System.Drawing.Size(65, 22)
        Me.TxtBind3.TabIndex = 17
        Me.TxtBind3.TabStop = False
        Me.TxtBind3.Tag = "1"
        '
        'TxtBind4
        '
        Me.TxtBind4.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtBind4.Location = New System.Drawing.Point(292, 91)
        Me.TxtBind4.MaxLength = 10
        Me.TxtBind4.Name = "TxtBind4"
        Me.TxtBind4.ShortcutsEnabled = False
        Me.TxtBind4.Size = New System.Drawing.Size(65, 22)
        Me.TxtBind4.TabIndex = 18
        Me.TxtBind4.TabStop = False
        Me.TxtBind4.Tag = "1"
        '
        'TxtBind0
        '
        Me.TxtBind0.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtBind0.Location = New System.Drawing.Point(11, 91)
        Me.TxtBind0.MaxLength = 10
        Me.TxtBind0.Name = "TxtBind0"
        Me.TxtBind0.ShortcutsEnabled = False
        Me.TxtBind0.Size = New System.Drawing.Size(65, 22)
        Me.TxtBind0.TabIndex = 19
        Me.TxtBind0.TabStop = False
        Me.TxtBind0.Tag = "1"
        '
        '后台键盘指令
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 297)
        Me.Controls.Add(Me.TxtBind0)
        Me.Controls.Add(Me.TxtBind4)
        Me.Controls.Add(Me.TxtBind3)
        Me.Controls.Add(Me.TxtBind2)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.ListWhen)
        Me.Controls.Add(Me.LabWhen)
        Me.Controls.Add(Me.ListEN)
        Me.Controls.Add(Me.LabEN)
        Me.Controls.Add(Me.ButUSE)
        Me.Controls.Add(Me.ButDEl)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.ButAdd)
        Me.Controls.Add(Me.TxtBind1)
        Me.Controls.Add(Me.LabKeys)
        Me.Controls.Add(Me.CheckEnabled)
        Me.Controls.Add(Me.LabList)
        Me.Controls.Add(Me.ListTemps)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "后台键盘指令"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "自定义后台键盘指令"
        Me.Tabs.ResumeLayout(False)
        Me.TabOpen.ResumeLayout(False)
        Me.TabOpen.PerformLayout()
        Me.TabShut.ResumeLayout(False)
        Me.TabShut.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListTemps As ComboBox
    Friend WithEvents LabList As Label
    Friend WithEvents CheckEnabled As CheckBox
    Friend WithEvents LabKeys As Label
    Friend WithEvents TxtBind1 As TextBox
    Friend WithEvents ButAdd As Button
    Friend WithEvents TxtName As TextBox
    Friend WithEvents ButDEl As Button
    Friend WithEvents ButUSE As Button
    Friend WithEvents LabEN As Label
    Friend WithEvents ListEN As ListBox
    Friend WithEvents LabWhen As Label
    Friend WithEvents ListWhen As ComboBox
    Friend WithEvents Watching As Forms.Timer
    Friend WithEvents Tabs As TabControl
    Friend WithEvents TabOpen As TabPage
    Friend WithEvents TabShut As TabPage
    Friend WithEvents TxtOpen As TextBox
    Friend WithEvents TxtShut As TextBox
    Friend WithEvents TxtBind2 As TextBox
    Friend WithEvents TxtBind3 As TextBox
    Friend WithEvents TxtBind4 As TextBox
    Friend WithEvents TxtBind0 As TextBox
End Class
