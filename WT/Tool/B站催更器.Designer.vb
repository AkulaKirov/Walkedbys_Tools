<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class B站催更器
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
        Me.LabID = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.ButTell = New System.Windows.Forms.Button()
        Me.LabOut = New System.Windows.Forms.Label()
        Me.CheckAuto = New System.Windows.Forms.CheckBox()
        Me.Pn = New System.Windows.Forms.Panel()
        Me.Pn.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabID
        '
        Me.LabID.AutoSize = True
        Me.LabID.Location = New System.Drawing.Point(5, 22)
        Me.LabID.Name = "LabID"
        Me.LabID.Size = New System.Drawing.Size(93, 19)
        Me.LabID.TabIndex = 1
        Me.LabID.Text = "你的B站UID："
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(104, 19)
        Me.TxtID.MaxLength = 100
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(275, 25)
        Me.TxtID.TabIndex = 2
        Me.TxtID.TabStop = False
        '
        'ButTell
        '
        Me.ButTell.Enabled = False
        Me.ButTell.Location = New System.Drawing.Point(71, 59)
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
        Me.LabOut.Location = New System.Drawing.Point(12, 159)
        Me.LabOut.Name = "LabOut"
        Me.LabOut.Size = New System.Drawing.Size(141, 19)
        Me.LabOut.TabIndex = 4
        Me.LabOut.Text = "你已经 x 天没有更新了"
        '
        'CheckAuto
        '
        Me.CheckAuto.AutoSize = True
        Me.CheckAuto.Location = New System.Drawing.Point(9, 101)
        Me.CheckAuto.Name = "CheckAuto"
        Me.CheckAuto.Size = New System.Drawing.Size(145, 23)
        Me.CheckAuto.TabIndex = 5
        Me.CheckAuto.TabStop = False
        Me.CheckAuto.Text = "启动的时候检查一次"
        Me.CheckAuto.UseVisualStyleBackColor = True
        '
        'Pn
        '
        Me.Pn.Controls.Add(Me.ButTell)
        Me.Pn.Controls.Add(Me.CheckAuto)
        Me.Pn.Controls.Add(Me.LabID)
        Me.Pn.Controls.Add(Me.TxtID)
        Me.Pn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn.Location = New System.Drawing.Point(0, 0)
        Me.Pn.Name = "Pn"
        Me.Pn.Size = New System.Drawing.Size(399, 145)
        Me.Pn.TabIndex = 6
        '
        'B站催更器
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(399, 206)
        Me.Controls.Add(Me.Pn)
        Me.Controls.Add(Me.LabOut)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "B站催更器"
        Me.Text = "B站催更器"
        Me.Pn.ResumeLayout(False)
        Me.Pn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabID As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents ButTell As Button
    Friend WithEvents LabOut As Label
    Friend WithEvents CheckAuto As CheckBox
    Friend WithEvents Pn As Panel
End Class
