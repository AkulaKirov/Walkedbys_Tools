<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 剪贴板记录器
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
        Me.components = New System.ComponentModel.Container()
        Me.LabText = New System.Windows.Forms.Label()
        Me.TxtText = New System.Windows.Forms.TextBox()
        Me.LabPic = New System.Windows.Forms.Label()
        Me.TxtPic = New System.Windows.Forms.TextBox()
        Me.ListOption = New System.Windows.Forms.ComboBox()
        Me.LabWhen = New System.Windows.Forms.Label()
        Me.LabBlank = New System.Windows.Forms.Label()
        Me.Watching = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LabText
        '
        Me.LabText.AutoSize = True
        Me.LabText.Location = New System.Drawing.Point(12, 9)
        Me.LabText.Name = "LabText"
        Me.LabText.Size = New System.Drawing.Size(360, 19)
        Me.LabText.TabIndex = 0
        Me.LabText.Text = "剪贴板文字保存到什么文件里（会回车附加在文件的最后）："
        '
        'TxtText
        '
        Me.TxtText.Location = New System.Drawing.Point(16, 31)
        Me.TxtText.Name = "TxtText"
        Me.TxtText.Size = New System.Drawing.Size(598, 25)
        Me.TxtText.TabIndex = 1
        Me.TxtText.TabStop = False
        '
        'LabPic
        '
        Me.LabPic.AutoSize = True
        Me.LabPic.Location = New System.Drawing.Point(12, 59)
        Me.LabPic.Name = "LabPic"
        Me.LabPic.Size = New System.Drawing.Size(391, 19)
        Me.LabPic.TabIndex = 2
        Me.LabPic.Text = "剪贴板图片保存到什么文件夹里（文件名为 当前unix时间.png）："
        '
        'TxtPic
        '
        Me.TxtPic.Location = New System.Drawing.Point(16, 81)
        Me.TxtPic.Name = "TxtPic"
        Me.TxtPic.Size = New System.Drawing.Size(598, 25)
        Me.TxtPic.TabIndex = 3
        Me.TxtPic.TabStop = False
        '
        'ListOption
        '
        Me.ListOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListOption.FormattingEnabled = True
        Me.ListOption.Items.AddRange(New Object() {"只在本工具运行的时候", "本软件运行的时候", "现在不记录"})
        Me.ListOption.Location = New System.Drawing.Point(118, 112)
        Me.ListOption.Name = "ListOption"
        Me.ListOption.Size = New System.Drawing.Size(186, 27)
        Me.ListOption.TabIndex = 4
        Me.ListOption.TabStop = False
        '
        'LabWhen
        '
        Me.LabWhen.AutoSize = True
        Me.LabWhen.Location = New System.Drawing.Point(12, 115)
        Me.LabWhen.Name = "LabWhen"
        Me.LabWhen.Size = New System.Drawing.Size(100, 19)
        Me.LabWhen.TabIndex = 5
        Me.LabWhen.Text = "什么时候记录："
        '
        'LabBlank
        '
        Me.LabBlank.AutoSize = True
        Me.LabBlank.Location = New System.Drawing.Point(12, 153)
        Me.LabBlank.Name = "LabBlank"
        Me.LabBlank.Size = New System.Drawing.Size(139, 19)
        Me.LabBlank.TabIndex = 6
        Me.LabBlank.Text = "留空表示不记录该项目"
        '
        'Watching
        '
        Me.Watching.Interval = 300
        '
        '剪贴板记录器
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(626, 192)
        Me.Controls.Add(Me.LabBlank)
        Me.Controls.Add(Me.LabWhen)
        Me.Controls.Add(Me.ListOption)
        Me.Controls.Add(Me.TxtPic)
        Me.Controls.Add(Me.LabPic)
        Me.Controls.Add(Me.TxtText)
        Me.Controls.Add(Me.LabText)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "剪贴板记录器"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "剪贴板记录器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabText As Label
    Friend WithEvents TxtText As TextBox
    Friend WithEvents LabPic As Label
    Friend WithEvents TxtPic As TextBox
    Friend WithEvents ListOption As ComboBox
    Friend WithEvents LabWhen As Label
    Friend WithEvents LabBlank As Label
    Friend WithEvents Watching As Forms.Timer
End Class
