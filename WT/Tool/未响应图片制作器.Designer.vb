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
        Me.LabS = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LabName = New System.Windows.Forms.Label()
        Me.LabICO = New System.Windows.Forms.Label()
        Me.TxtICO = New System.Windows.Forms.TextBox()
        Me.ButClipBoard = New System.Windows.Forms.Button()
        Me.ButOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabS
        '
        Me.LabS.BackColor = System.Drawing.SystemColors.Control
        Me.LabS.Image = Global.WT.My.Resources.Resources.无响应
        Me.LabS.Location = New System.Drawing.Point(48, 90)
        Me.LabS.Name = "LabS"
        Me.LabS.Size = New System.Drawing.Size(536, 247)
        Me.LabS.TabIndex = 0
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
        'LabICO
        '
        Me.LabICO.AutoSize = True
        Me.LabICO.Location = New System.Drawing.Point(12, 44)
        Me.LabICO.Name = "LabICO"
        Me.LabICO.Size = New System.Drawing.Size(149, 19)
        Me.LabICO.TabIndex = 3
        Me.LabICO.Text = "程序的图片 (jpg, png)："
        '
        'TxtICO
        '
        Me.TxtICO.Location = New System.Drawing.Point(180, 41)
        Me.TxtICO.MaxLength = 30
        Me.TxtICO.Name = "TxtICO"
        Me.TxtICO.Size = New System.Drawing.Size(311, 25)
        Me.TxtICO.TabIndex = 4
        Me.TxtICO.TabStop = False
        '
        'ButClipBoard
        '
        Me.ButClipBoard.Location = New System.Drawing.Point(497, 41)
        Me.ButClipBoard.Name = "ButClipBoard"
        Me.ButClipBoard.Size = New System.Drawing.Size(132, 28)
        Me.ButClipBoard.TabIndex = 5
        Me.ButClipBoard.TabStop = False
        Me.ButClipBoard.Text = "使用剪贴板图片"
        Me.ButClipBoard.UseVisualStyleBackColor = True
        '
        'ButOut
        '
        Me.ButOut.Location = New System.Drawing.Point(50, 340)
        Me.ButOut.Name = "ButOut"
        Me.ButOut.Size = New System.Drawing.Size(155, 32)
        Me.ButOut.TabIndex = 6
        Me.ButOut.TabStop = False
        Me.ButOut.Text = "输出图片到剪贴板"
        Me.ButOut.UseVisualStyleBackColor = True
        '
        '未响应图片制作器
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(655, 391)
        Me.Controls.Add(Me.ButOut)
        Me.Controls.Add(Me.ButClipBoard)
        Me.Controls.Add(Me.TxtICO)
        Me.Controls.Add(Me.LabICO)
        Me.Controls.Add(Me.LabName)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LabS)
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

    Friend WithEvents LabS As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LabName As Label
    Friend WithEvents LabICO As Label
    Friend WithEvents TxtICO As TextBox
    Friend WithEvents ButClipBoard As Button
    Friend WithEvents ButOut As Button
End Class
