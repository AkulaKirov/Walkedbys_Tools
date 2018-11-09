<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SteamCookie窗体
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
        Me.ButHowToGetCookie = New System.Windows.Forms.Button()
        Me.LabLoginSecure = New System.Windows.Forms.Label()
        Me.LabSession = New System.Windows.Forms.Label()
        Me.TxtLoginSecure = New System.Windows.Forms.TextBox()
        Me.TxtSession = New System.Windows.Forms.TextBox()
        Me.ButCheckMy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButHowToGetCookie
        '
        Me.ButHowToGetCookie.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButHowToGetCookie.Location = New System.Drawing.Point(8, 68)
        Me.ButHowToGetCookie.Name = "ButHowToGetCookie"
        Me.ButHowToGetCookie.Size = New System.Drawing.Size(216, 30)
        Me.ButHowToGetCookie.TabIndex = 66
        Me.ButHowToGetCookie.TabStop = False
        Me.ButHowToGetCookie.Text = "如何获得 Steam Cookie"
        Me.ButHowToGetCookie.UseVisualStyleBackColor = True
        '
        'LabLoginSecure
        '
        Me.LabLoginSecure.AutoSize = True
        Me.LabLoginSecure.Location = New System.Drawing.Point(4, 37)
        Me.LabLoginSecure.Name = "LabLoginSecure"
        Me.LabLoginSecure.Size = New System.Drawing.Size(132, 19)
        Me.LabLoginSecure.TabIndex = 1
        Me.LabLoginSecure.Text = "steamLoginSecure="
        '
        'LabSession
        '
        Me.LabSession.AutoSize = True
        Me.LabSession.Location = New System.Drawing.Point(62, 9)
        Me.LabSession.Name = "LabSession"
        Me.LabSession.Size = New System.Drawing.Size(74, 19)
        Me.LabSession.TabIndex = 0
        Me.LabSession.Text = "sessionid="
        '
        'TxtLoginSecure
        '
        Me.TxtLoginSecure.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtLoginSecure.Location = New System.Drawing.Point(142, 34)
        Me.TxtLoginSecure.MaxLength = 63
        Me.TxtLoginSecure.Name = "TxtLoginSecure"
        Me.TxtLoginSecure.Size = New System.Drawing.Size(494, 22)
        Me.TxtLoginSecure.TabIndex = 63
        Me.TxtLoginSecure.TabStop = False
        Me.TxtLoginSecure.UseSystemPasswordChar = True
        '
        'TxtSession
        '
        Me.TxtSession.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtSession.Location = New System.Drawing.Point(142, 6)
        Me.TxtSession.MaxLength = 24
        Me.TxtSession.Name = "TxtSession"
        Me.TxtSession.Size = New System.Drawing.Size(494, 22)
        Me.TxtSession.TabIndex = 2
        Me.TxtSession.TabStop = False
        '
        'ButCheckMy
        '
        Me.ButCheckMy.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButCheckMy.Location = New System.Drawing.Point(230, 68)
        Me.ButCheckMy.Name = "ButCheckMy"
        Me.ButCheckMy.Size = New System.Drawing.Size(355, 30)
        Me.ButCheckMy.TabIndex = 67
        Me.ButCheckMy.TabStop = False
        Me.ButCheckMy.Text = "查看我的 Steam 个人主页"
        Me.ButCheckMy.UseVisualStyleBackColor = True
        '
        'SteamCookie窗体
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(648, 111)
        Me.Controls.Add(Me.ButCheckMy)
        Me.Controls.Add(Me.ButHowToGetCookie)
        Me.Controls.Add(Me.LabLoginSecure)
        Me.Controls.Add(Me.LabSession)
        Me.Controls.Add(Me.TxtSession)
        Me.Controls.Add(Me.TxtLoginSecure)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SteamCookie窗体"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "请填写你的 Steam Cookie，填写完成后就可以关闭本窗口了。"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButHowToGetCookie As Button
    Friend WithEvents LabLoginSecure As Label
    Friend WithEvents LabSession As Label
    Friend WithEvents TxtLoginSecure As TextBox
    Friend WithEvents TxtSession As TextBox
    Friend WithEvents ButCheckMy As Button
End Class
