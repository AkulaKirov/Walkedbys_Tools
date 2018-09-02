<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 随机生成器
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
        Me.ButGen = New System.Windows.Forms.Button()
        Me.TxtOut = New System.Windows.Forms.TextBox()
        Me.LabLen = New System.Windows.Forms.Label()
        Me.TxtLen = New System.Windows.Forms.NumericUpDown()
        Me.ListObj = New System.Windows.Forms.ComboBox()
        CType(Me.TxtLen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButGen
        '
        Me.ButGen.Location = New System.Drawing.Point(356, 6)
        Me.ButGen.Name = "ButGen"
        Me.ButGen.Size = New System.Drawing.Size(106, 27)
        Me.ButGen.TabIndex = 1
        Me.ButGen.TabStop = False
        Me.ButGen.Text = "生成"
        Me.ButGen.UseVisualStyleBackColor = True
        '
        'TxtOut
        '
        Me.TxtOut.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOut.Location = New System.Drawing.Point(12, 39)
        Me.TxtOut.Multiline = True
        Me.TxtOut.Name = "TxtOut"
        Me.TxtOut.ReadOnly = True
        Me.TxtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtOut.Size = New System.Drawing.Size(602, 307)
        Me.TxtOut.TabIndex = 2
        Me.TxtOut.TabStop = False
        '
        'LabLen
        '
        Me.LabLen.AutoSize = True
        Me.LabLen.Location = New System.Drawing.Point(12, 9)
        Me.LabLen.Name = "LabLen"
        Me.LabLen.Size = New System.Drawing.Size(48, 19)
        Me.LabLen.TabIndex = 3
        Me.LabLen.Text = "长度："
        '
        'TxtLen
        '
        Me.TxtLen.Location = New System.Drawing.Point(66, 7)
        Me.TxtLen.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.TxtLen.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TxtLen.Name = "TxtLen"
        Me.TxtLen.Size = New System.Drawing.Size(88, 25)
        Me.TxtLen.TabIndex = 4
        Me.TxtLen.TabStop = False
        Me.TxtLen.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'ListObj
        '
        Me.ListObj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListObj.FormattingEnabled = True
        Me.ListObj.Items.AddRange(New Object() {"中文句子", "英文句子", "数字", "小写字母", "大写字母", "汉字", "数字+大小写字母", "汉字+数字+大小写字母", "CDKEY"})
        Me.ListObj.Location = New System.Drawing.Point(160, 6)
        Me.ListObj.Name = "ListObj"
        Me.ListObj.Size = New System.Drawing.Size(176, 27)
        Me.ListObj.TabIndex = 5
        Me.ListObj.TabStop = False
        '
        '随机生成器
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(626, 358)
        Me.Controls.Add(Me.ListObj)
        Me.Controls.Add(Me.TxtLen)
        Me.Controls.Add(Me.LabLen)
        Me.Controls.Add(Me.TxtOut)
        Me.Controls.Add(Me.ButGen)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "随机生成器"
        Me.Text = "随机生成器"
        CType(Me.TxtLen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButGen As Button
    Friend WithEvents TxtOut As TextBox
    Friend WithEvents LabLen As Label
    Friend WithEvents TxtLen As NumericUpDown
    Friend WithEvents ListObj As ComboBox
End Class
