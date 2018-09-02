<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 未响应图片制作器
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
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LabName = New System.Windows.Forms.Label()
        Me.ButClipBoard = New System.Windows.Forms.Button()
        Me.ButOut = New System.Windows.Forms.Button()
        Me.ListStyle = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(105, 12)
        Me.TxtName.MaxLength = 30
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(386, 25)
        Me.TxtName.TabIndex = 1
        Me.TxtName.TabStop = False
        '
        'LabName
        '
        Me.LabName.AutoSize = True
        Me.LabName.Location = New System.Drawing.Point(12, 12)
        Me.LabName.Name = "LabName"
        Me.LabName.Size = New System.Drawing.Size(87, 19)
        Me.LabName.TabIndex = 2
        Me.LabName.Text = "程序的名字："
        '
        'ButClipBoard
        '
        Me.ButClipBoard.Location = New System.Drawing.Point(12, 43)
        Me.ButClipBoard.Name = "ButClipBoard"
        Me.ButClipBoard.Size = New System.Drawing.Size(230, 28)
        Me.ButClipBoard.TabIndex = 5
        Me.ButClipBoard.TabStop = False
        Me.ButClipBoard.Text = "使用剪贴板图片作为图标"
        Me.ButClipBoard.UseVisualStyleBackColor = True
        '
        'ButOut
        '
        Me.ButOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButOut.Location = New System.Drawing.Point(6, 377)
        Me.ButOut.Name = "ButOut"
        Me.ButOut.Size = New System.Drawing.Size(155, 32)
        Me.ButOut.TabIndex = 6
        Me.ButOut.TabStop = False
        Me.ButOut.Text = "输出图片到剪贴板"
        Me.ButOut.UseVisualStyleBackColor = True
        '
        'ListStyle
        '
        Me.ListStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListStyle.FormattingEnabled = True
        Me.ListStyle.Items.AddRange(New Object() {"Win7 英文", "Win10 中文", "XP 中文"})
        Me.ListStyle.Location = New System.Drawing.Point(497, 9)
        Me.ListStyle.Name = "ListStyle"
        Me.ListStyle.Size = New System.Drawing.Size(132, 27)
        Me.ListStyle.TabIndex = 7
        Me.ListStyle.TabStop = False
        '
        '未响应图片制作器
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(655, 421)
        Me.Controls.Add(Me.ListStyle)
        Me.Controls.Add(Me.ButOut)
        Me.Controls.Add(Me.ButClipBoard)
        Me.Controls.Add(Me.LabName)
        Me.Controls.Add(Me.TxtName)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "未响应图片制作器"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "未响应图片制作器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LabName As Label
    Friend WithEvents ButClipBoard As Button
    Friend WithEvents ButOut As Button
    Friend WithEvents ListStyle As ComboBox
End Class
