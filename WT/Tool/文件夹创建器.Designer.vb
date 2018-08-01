<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 文件夹创建器
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
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.ButCreate = New System.Windows.Forms.Button()
        Me.LabOut = New System.Windows.Forms.Label()
        Me.ButOpen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtPath
        '
        Me.TxtPath.Location = New System.Drawing.Point(12, 38)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(632, 25)
        Me.TxtPath.TabIndex = 0
        Me.TxtPath.TabStop = False
        '
        'ButCreate
        '
        Me.ButCreate.Location = New System.Drawing.Point(518, 77)
        Me.ButCreate.Name = "ButCreate"
        Me.ButCreate.Size = New System.Drawing.Size(125, 44)
        Me.ButCreate.TabIndex = 1
        Me.ButCreate.TabStop = False
        Me.ButCreate.Text = "新建文件夹"
        Me.ButCreate.UseVisualStyleBackColor = True
        '
        'LabOut
        '
        Me.LabOut.AutoSize = True
        Me.LabOut.Location = New System.Drawing.Point(18, 83)
        Me.LabOut.Name = "LabOut"
        Me.LabOut.Size = New System.Drawing.Size(35, 19)
        Me.LabOut.TabIndex = 2
        Me.LabOut.Text = "输出"
        '
        'ButOpen
        '
        Me.ButOpen.Location = New System.Drawing.Point(439, 76)
        Me.ButOpen.Name = "ButOpen"
        Me.ButOpen.Size = New System.Drawing.Size(67, 44)
        Me.ButOpen.TabIndex = 3
        Me.ButOpen.Text = "打开"
        Me.ButOpen.UseVisualStyleBackColor = True
        Me.ButOpen.Visible = False
        '
        '文件夹创建器
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(665, 148)
        Me.Controls.Add(Me.ButOpen)
        Me.Controls.Add(Me.LabOut)
        Me.Controls.Add(Me.ButCreate)
        Me.Controls.Add(Me.TxtPath)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "文件夹创建器"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "文件夹创建器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPath As TextBox
    Friend WithEvents ButCreate As Button
    Friend WithEvents LabOut As Label
    Friend WithEvents ButOpen As Button
End Class
