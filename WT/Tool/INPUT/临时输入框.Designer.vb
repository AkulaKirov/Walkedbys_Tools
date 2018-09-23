<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 临时输入框
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
        Me.TxtIN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtIN
        '
        Me.TxtIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtIN.Location = New System.Drawing.Point(0, 0)
        Me.TxtIN.MaxLength = 100
        Me.TxtIN.Multiline = True
        Me.TxtIN.Name = "TxtIN"
        Me.TxtIN.Size = New System.Drawing.Size(297, 28)
        Me.TxtIN.TabIndex = 0
        Me.TxtIN.TabStop = False
        '
        '临时输入框
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(297, 28)
        Me.Controls.Add(Me.TxtIN)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(0, -540)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "临时输入框"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "按回车结束"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtIN As TextBox
End Class
