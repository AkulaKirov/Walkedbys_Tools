<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 文件筛选
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
        Me.LabFa = New System.Windows.Forms.Label()
        Me.LabFB = New System.Windows.Forms.Label()
        Me.TxtFA = New System.Windows.Forms.TextBox()
        Me.TxtFB = New System.Windows.Forms.TextBox()
        Me.LabFc = New System.Windows.Forms.Label()
        Me.TxtFC = New System.Windows.Forms.TextBox()
        Me.ButAtoC = New System.Windows.Forms.Button()
        Me.ButBtoC = New System.Windows.Forms.Button()
        Me.ButAB2 = New System.Windows.Forms.Button()
        Me.ButAB = New System.Windows.Forms.Button()
        Me.Pn = New System.Windows.Forms.Panel()
        Me.LabNote = New System.Windows.Forms.Label()
        Me.LabDone = New System.Windows.Forms.Label()
        Me.Pn.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabFa
        '
        Me.LabFa.AutoSize = True
        Me.LabFa.Location = New System.Drawing.Point(12, 19)
        Me.LabFa.Name = "LabFa"
        Me.LabFa.Size = New System.Drawing.Size(70, 19)
        Me.LabFa.TabIndex = 0
        Me.LabFa.Text = "文件夹A："
        '
        'LabFB
        '
        Me.LabFB.AutoSize = True
        Me.LabFB.Location = New System.Drawing.Point(12, 58)
        Me.LabFB.Name = "LabFB"
        Me.LabFB.Size = New System.Drawing.Size(69, 19)
        Me.LabFB.TabIndex = 1
        Me.LabFB.Text = "文件夹B："
        '
        'TxtFA
        '
        Me.TxtFA.Location = New System.Drawing.Point(79, 16)
        Me.TxtFA.Name = "TxtFA"
        Me.TxtFA.Size = New System.Drawing.Size(503, 25)
        Me.TxtFA.TabIndex = 2
        Me.TxtFA.TabStop = False
        '
        'TxtFB
        '
        Me.TxtFB.Location = New System.Drawing.Point(79, 55)
        Me.TxtFB.Name = "TxtFB"
        Me.TxtFB.Size = New System.Drawing.Size(503, 25)
        Me.TxtFB.TabIndex = 3
        Me.TxtFB.TabStop = False
        '
        'LabFc
        '
        Me.LabFc.AutoSize = True
        Me.LabFc.Location = New System.Drawing.Point(13, 95)
        Me.LabFc.Name = "LabFc"
        Me.LabFc.Size = New System.Drawing.Size(70, 19)
        Me.LabFc.TabIndex = 4
        Me.LabFc.Text = "文件夹C："
        '
        'TxtFC
        '
        Me.TxtFC.Location = New System.Drawing.Point(79, 92)
        Me.TxtFC.Name = "TxtFC"
        Me.TxtFC.Size = New System.Drawing.Size(503, 25)
        Me.TxtFC.TabIndex = 5
        Me.TxtFC.TabStop = False
        '
        'ButAtoC
        '
        Me.ButAtoC.Location = New System.Drawing.Point(3, 20)
        Me.ButAtoC.Name = "ButAtoC"
        Me.ButAtoC.Size = New System.Drawing.Size(268, 33)
        Me.ButAtoC.TabIndex = 6
        Me.ButAtoC.TabStop = False
        Me.ButAtoC.Text = "把A有，但B没有的文件复制到C里"
        Me.ButAtoC.UseVisualStyleBackColor = True
        '
        'ButBtoC
        '
        Me.ButBtoC.Location = New System.Drawing.Point(3, 59)
        Me.ButBtoC.Name = "ButBtoC"
        Me.ButBtoC.Size = New System.Drawing.Size(268, 33)
        Me.ButBtoC.TabIndex = 7
        Me.ButBtoC.TabStop = False
        Me.ButBtoC.Text = "把B有，但A没有的文件复制到C里"
        Me.ButBtoC.UseVisualStyleBackColor = True
        '
        'ButAB2
        '
        Me.ButAB2.Location = New System.Drawing.Point(284, 20)
        Me.ButAB2.Name = "ButAB2"
        Me.ButAB2.Size = New System.Drawing.Size(296, 33)
        Me.ButAB2.TabIndex = 8
        Me.ButAB2.TabStop = False
        Me.ButAB2.Text = "把AB里没有同时位于AB的文件复制到C里"
        Me.ButAB2.UseVisualStyleBackColor = True
        '
        'ButAB
        '
        Me.ButAB.Location = New System.Drawing.Point(284, 59)
        Me.ButAB.Name = "ButAB"
        Me.ButAB.Size = New System.Drawing.Size(296, 33)
        Me.ButAB.TabIndex = 9
        Me.ButAB.TabStop = False
        Me.ButAB.Text = "把AB里同时位于AB的文件复制到C里"
        Me.ButAB.UseVisualStyleBackColor = True
        '
        'Pn
        '
        Me.Pn.Controls.Add(Me.ButAB2)
        Me.Pn.Controls.Add(Me.ButAB)
        Me.Pn.Controls.Add(Me.ButAtoC)
        Me.Pn.Controls.Add(Me.ButBtoC)
        Me.Pn.Enabled = False
        Me.Pn.Location = New System.Drawing.Point(2, 123)
        Me.Pn.Name = "Pn"
        Me.Pn.Size = New System.Drawing.Size(590, 109)
        Me.Pn.TabIndex = 10
        '
        'LabNote
        '
        Me.LabNote.AutoSize = True
        Me.LabNote.Location = New System.Drawing.Point(12, 235)
        Me.LabNote.Name = "LabNote"
        Me.LabNote.Size = New System.Drawing.Size(191, 19)
        Me.LabNote.TabIndex = 11
        Me.LabNote.Text = "如果文件很多很大就会卡一会。"
        '
        'LabDone
        '
        Me.LabDone.AutoSize = True
        Me.LabDone.Location = New System.Drawing.Point(373, 242)
        Me.LabDone.Name = "LabDone"
        Me.LabDone.Size = New System.Drawing.Size(48, 19)
        Me.LabDone.TabIndex = 12
        Me.LabDone.Text = "完成！"
        Me.LabDone.Visible = False
        '
        '文件筛选
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(598, 262)
        Me.Controls.Add(Me.LabDone)
        Me.Controls.Add(Me.LabNote)
        Me.Controls.Add(Me.TxtFC)
        Me.Controls.Add(Me.LabFc)
        Me.Controls.Add(Me.TxtFB)
        Me.Controls.Add(Me.TxtFA)
        Me.Controls.Add(Me.LabFB)
        Me.Controls.Add(Me.LabFa)
        Me.Controls.Add(Me.Pn)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "文件筛选"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "文件筛选"
        Me.Pn.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabFa As Label
    Friend WithEvents LabFB As Label
    Friend WithEvents TxtFA As TextBox
    Friend WithEvents TxtFB As TextBox
    Friend WithEvents LabFc As Label
    Friend WithEvents TxtFC As TextBox
    Friend WithEvents ButAtoC As Button
    Friend WithEvents ButBtoC As Button
    Friend WithEvents ButAB2 As Button
    Friend WithEvents ButAB As Button
    Friend WithEvents Pn As Panel
    Friend WithEvents LabNote As Label
    Friend WithEvents LabDone As Label
End Class
