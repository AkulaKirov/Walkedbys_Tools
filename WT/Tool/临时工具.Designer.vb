﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 临时工具
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
        Me.RTB = New System.Windows.Forms.RichTextBox()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'RTB
        '
        Me.RTB.Location = New System.Drawing.Point(12, 43)
        Me.RTB.Name = "RTB"
        Me.RTB.Size = New System.Drawing.Size(683, 400)
        Me.RTB.TabIndex = 0
        Me.RTB.Text = ""
        '
        'TxtPath
        '
        Me.TxtPath.Location = New System.Drawing.Point(12, 12)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(384, 25)
        Me.TxtPath.TabIndex = 1
        '
        '临时工具
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(730, 467)
        Me.Controls.Add(Me.TxtPath)
        Me.Controls.Add(Me.RTB)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "临时工具"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "临时工具"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RTB As RichTextBox
    Friend WithEvents TxtPath As TextBox
End Class
