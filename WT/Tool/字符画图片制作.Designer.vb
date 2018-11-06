<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 字符画图片制作
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
        Me.LabHeight = New System.Windows.Forms.Label()
        Me.TxtHeight = New System.Windows.Forms.NumericUpDown()
        Me.ButGetPic = New System.Windows.Forms.Button()
        Me.TxtOut = New System.Windows.Forms.TextBox()
        Me.LabStyle = New System.Windows.Forms.Label()
        Me.ListStyle = New System.Windows.Forms.ComboBox()
        CType(Me.TxtHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabHeight
        '
        Me.LabHeight.AutoSize = True
        Me.LabHeight.Location = New System.Drawing.Point(12, 9)
        Me.LabHeight.Name = "LabHeight"
        Me.LabHeight.Size = New System.Drawing.Size(48, 19)
        Me.LabHeight.TabIndex = 0
        Me.LabHeight.Text = "高度："
        '
        'TxtHeight
        '
        Me.TxtHeight.Location = New System.Drawing.Point(74, 7)
        Me.TxtHeight.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.TxtHeight.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.TxtHeight.Name = "TxtHeight"
        Me.TxtHeight.Size = New System.Drawing.Size(52, 25)
        Me.TxtHeight.TabIndex = 1
        Me.TxtHeight.TabStop = False
        Me.TxtHeight.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'ButGetPic
        '
        Me.ButGetPic.Location = New System.Drawing.Point(347, 7)
        Me.ButGetPic.Name = "ButGetPic"
        Me.ButGetPic.Size = New System.Drawing.Size(231, 25)
        Me.ButGetPic.TabIndex = 2
        Me.ButGetPic.TabStop = False
        Me.ButGetPic.Text = "从剪贴板获取图片并输出"
        Me.ButGetPic.UseVisualStyleBackColor = True
        '
        'TxtOut
        '
        Me.TxtOut.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOut.Location = New System.Drawing.Point(12, 38)
        Me.TxtOut.Multiline = True
        Me.TxtOut.Name = "TxtOut"
        Me.TxtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtOut.Size = New System.Drawing.Size(908, 457)
        Me.TxtOut.TabIndex = 3
        Me.TxtOut.TabStop = False
        Me.TxtOut.WordWrap = False
        '
        'LabStyle
        '
        Me.LabStyle.AutoSize = True
        Me.LabStyle.Location = New System.Drawing.Point(132, 10)
        Me.LabStyle.Name = "LabStyle"
        Me.LabStyle.Size = New System.Drawing.Size(48, 19)
        Me.LabStyle.TabIndex = 4
        Me.LabStyle.Text = "样式："
        '
        'ListStyle
        '
        Me.ListStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListStyle.FormattingEnabled = True
        Me.ListStyle.Items.AddRange(New Object() {"$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\|()1{}[]?-_+~<>i!lI;:,\"" ^`'. ", "█ "})
        Me.ListStyle.Location = New System.Drawing.Point(186, 5)
        Me.ListStyle.Name = "ListStyle"
        Me.ListStyle.Size = New System.Drawing.Size(155, 27)
        Me.ListStyle.TabIndex = 5
        Me.ListStyle.TabStop = False
        '
        '字符画图片制作
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(932, 507)
        Me.Controls.Add(Me.ListStyle)
        Me.Controls.Add(Me.LabStyle)
        Me.Controls.Add(Me.TxtOut)
        Me.Controls.Add(Me.ButGetPic)
        Me.Controls.Add(Me.TxtHeight)
        Me.Controls.Add(Me.LabHeight)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "字符画图片制作"
        Me.Text = "字符画图片制作"
        CType(Me.TxtHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabHeight As Label
    Friend WithEvents TxtHeight As NumericUpDown
    Friend WithEvents ButGetPic As Button
    Friend WithEvents TxtOut As TextBox
    Friend WithEvents LabStyle As Label
    Friend WithEvents ListStyle As ComboBox
End Class
