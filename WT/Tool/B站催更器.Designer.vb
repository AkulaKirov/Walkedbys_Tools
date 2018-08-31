<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class B站催更器
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
        Me.LabID = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.ButTell = New System.Windows.Forms.Button()
        Me.LabOut = New System.Windows.Forms.Label()
        Me.CoolDown = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LabID
        '
        Me.LabID.AutoSize = True
        Me.LabID.Location = New System.Drawing.Point(12, 9)
        Me.LabID.Name = "LabID"
        Me.LabID.Size = New System.Drawing.Size(93, 19)
        Me.LabID.TabIndex = 1
        Me.LabID.Text = "你的B站UID："
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(111, 6)
        Me.TxtID.MaxLength = 100
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(275, 25)
        Me.TxtID.TabIndex = 2
        Me.TxtID.TabStop = False
        '
        'ButTell
        '
        Me.ButTell.Enabled = False
        Me.ButTell.Location = New System.Drawing.Point(76, 46)
        Me.ButTell.Name = "ButTell"
        Me.ButTell.Size = New System.Drawing.Size(222, 36)
        Me.ButTell.TabIndex = 3
        Me.ButTell.TabStop = False
        Me.ButTell.Text = "告诉我残酷的现实"
        Me.ButTell.UseVisualStyleBackColor = True
        '
        'LabOut
        '
        Me.LabOut.AutoSize = True
        Me.LabOut.Location = New System.Drawing.Point(12, 108)
        Me.LabOut.Name = "LabOut"
        Me.LabOut.Size = New System.Drawing.Size(141, 19)
        Me.LabOut.TabIndex = 4
        Me.LabOut.Text = "你已经 x 天没有更新了"
        '
        'CoolDown
        '
        Me.CoolDown.Interval = 20000
        '
        'B站催更器
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(398, 208)
        Me.Controls.Add(Me.LabOut)
        Me.Controls.Add(Me.ButTell)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.LabID)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "B站催更器"
        Me.Text = "B站催更器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabID As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents ButTell As Button
    Friend WithEvents LabOut As Label
    Friend WithEvents CoolDown As Forms.Timer
End Class
