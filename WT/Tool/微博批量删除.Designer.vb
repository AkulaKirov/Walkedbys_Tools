<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 微博批量删除
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtCookie = New System.Windows.Forms.TextBox()
        Me.LabCookie = New System.Windows.Forms.Label()
        Me.LabRange = New System.Windows.Forms.Label()
        Me.LabWhitelist = New System.Windows.Forms.Label()
        Me.TxtWhiteList = New System.Windows.Forms.TextBox()
        Me.ListWhite = New System.Windows.Forms.ComboBox()
        Me.ButGo = New System.Windows.Forms.Button()
        Me.TxtLog = New System.Windows.Forms.TextBox()
        Me.Pn = New System.Windows.Forms.Panel()
        Me.ButHowToCookie = New System.Windows.Forms.Button()
        Me.ButOld = New System.Windows.Forms.Button()
        Me.LabBUG = New System.Windows.Forms.Label()
        Me.TxtLink2 = New System.Windows.Forms.TextBox()
        Me.TxtLink1 = New System.Windows.Forms.TextBox()
        Me.ListIDs = New System.Windows.Forms.ListBox()
        Me.LabIDcount = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pn.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCookie
        '
        Me.TxtCookie.Location = New System.Drawing.Point(72, 13)
        Me.TxtCookie.Name = "TxtCookie"
        Me.TxtCookie.Size = New System.Drawing.Size(655, 25)
        Me.TxtCookie.TabIndex = 0
        Me.TxtCookie.UseSystemPasswordChar = True
        '
        'LabCookie
        '
        Me.LabCookie.AutoSize = True
        Me.LabCookie.Location = New System.Drawing.Point(2, 16)
        Me.LabCookie.Name = "LabCookie"
        Me.LabCookie.Size = New System.Drawing.Size(64, 19)
        Me.LabCookie.TabIndex = 1
        Me.LabCookie.Text = "Cookie："
        '
        'LabRange
        '
        Me.LabRange.AutoSize = True
        Me.LabRange.Location = New System.Drawing.Point(2, 56)
        Me.LabRange.Name = "LabRange"
        Me.LabRange.Size = New System.Drawing.Size(399, 19)
        Me.LabRange.TabIndex = 2
        Me.LabRange.Text = "要删除微博的范围（头尾的微博的链接，填写不全表示全部删除）："
        '
        'LabWhitelist
        '
        Me.LabWhitelist.AutoSize = True
        Me.LabWhitelist.Location = New System.Drawing.Point(637, 66)
        Me.LabWhitelist.Name = "LabWhitelist"
        Me.LabWhitelist.Size = New System.Drawing.Size(269, 19)
        Me.LabWhitelist.TabIndex = 6
        Me.LabWhitelist.Text = "特殊用词列表（用回车分隔，大小写不分）："
        '
        'TxtWhiteList
        '
        Me.TxtWhiteList.Location = New System.Drawing.Point(637, 88)
        Me.TxtWhiteList.Multiline = True
        Me.TxtWhiteList.Name = "TxtWhiteList"
        Me.TxtWhiteList.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtWhiteList.Size = New System.Drawing.Size(273, 119)
        Me.TxtWhiteList.TabIndex = 7
        Me.TxtWhiteList.WordWrap = False
        '
        'ListWhite
        '
        Me.ListWhite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListWhite.FormattingEnabled = True
        Me.ListWhite.Items.AddRange(New Object() {"只删除包含特殊用词的微博", "跳过包含特殊用词的微博", "不处理特殊用词"})
        Me.ListWhite.Location = New System.Drawing.Point(637, 223)
        Me.ListWhite.Name = "ListWhite"
        Me.ListWhite.Size = New System.Drawing.Size(277, 27)
        Me.ListWhite.TabIndex = 8
        '
        'ButGo
        '
        Me.ButGo.Enabled = False
        Me.ButGo.Location = New System.Drawing.Point(450, 185)
        Me.ButGo.Name = "ButGo"
        Me.ButGo.Size = New System.Drawing.Size(150, 30)
        Me.ButGo.TabIndex = 9
        Me.ButGo.Text = "开始删除微博"
        Me.ButGo.UseVisualStyleBackColor = True
        '
        'TxtLog
        '
        Me.TxtLog.Location = New System.Drawing.Point(10, 288)
        Me.TxtLog.MaxLength = 0
        Me.TxtLog.Multiline = True
        Me.TxtLog.Name = "TxtLog"
        Me.TxtLog.ReadOnly = True
        Me.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLog.Size = New System.Drawing.Size(613, 243)
        Me.TxtLog.TabIndex = 10
        '
        'Pn
        '
        Me.Pn.Controls.Add(Me.ButHowToCookie)
        Me.Pn.Controls.Add(Me.ButOld)
        Me.Pn.Controls.Add(Me.ButGo)
        Me.Pn.Controls.Add(Me.LabBUG)
        Me.Pn.Controls.Add(Me.TxtLink2)
        Me.Pn.Controls.Add(Me.TxtLink1)
        Me.Pn.Controls.Add(Me.TxtWhiteList)
        Me.Pn.Controls.Add(Me.TxtCookie)
        Me.Pn.Controls.Add(Me.LabCookie)
        Me.Pn.Controls.Add(Me.ListWhite)
        Me.Pn.Controls.Add(Me.LabRange)
        Me.Pn.Controls.Add(Me.LabWhitelist)
        Me.Pn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn.Location = New System.Drawing.Point(0, 0)
        Me.Pn.Name = "Pn"
        Me.Pn.Size = New System.Drawing.Size(926, 270)
        Me.Pn.TabIndex = 11
        '
        'ButHowToCookie
        '
        Me.ButHowToCookie.Location = New System.Drawing.Point(733, 11)
        Me.ButHowToCookie.Name = "ButHowToCookie"
        Me.ButHowToCookie.Size = New System.Drawing.Size(181, 28)
        Me.ButHowToCookie.TabIndex = 15
        Me.ButHowToCookie.Text = "如何获取微博 Cookie"
        Me.ButHowToCookie.UseVisualStyleBackColor = True
        '
        'ButOld
        '
        Me.ButOld.Location = New System.Drawing.Point(406, 149)
        Me.ButOld.Name = "ButOld"
        Me.ButOld.Size = New System.Drawing.Size(194, 30)
        Me.ButOld.TabIndex = 12
        Me.ButOld.Text = "直接填写最远古微博链接"
        Me.ButOld.UseVisualStyleBackColor = True
        '
        'LabBUG
        '
        Me.LabBUG.AutoSize = True
        Me.LabBUG.Location = New System.Drawing.Point(3, 158)
        Me.LabBUG.Name = "LabBUG"
        Me.LabBUG.Size = New System.Drawing.Size(282, 76)
        Me.LabBUG.TabIndex = 11
        Me.LabBUG.Text = "已知BUG：一些早期微博可能会出现问题，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "尤其是2016年及之前的，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "可能会存在误删或者获取不到对应微博的问题。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "建议删除的比较早的话按一下右边的远古按钮。" &
    ""
        '
        'TxtLink2
        '
        Me.TxtLink2.Location = New System.Drawing.Point(6, 118)
        Me.TxtLink2.MaxLength = 300
        Me.TxtLink2.Name = "TxtLink2"
        Me.TxtLink2.Size = New System.Drawing.Size(607, 25)
        Me.TxtLink2.TabIndex = 10
        '
        'TxtLink1
        '
        Me.TxtLink1.Location = New System.Drawing.Point(6, 87)
        Me.TxtLink1.MaxLength = 300
        Me.TxtLink1.Name = "TxtLink1"
        Me.TxtLink1.Size = New System.Drawing.Size(607, 25)
        Me.TxtLink1.TabIndex = 9
        '
        'ListIDs
        '
        Me.ListIDs.FormattingEnabled = True
        Me.ListIDs.ItemHeight = 19
        Me.ListIDs.Location = New System.Drawing.Point(629, 320)
        Me.ListIDs.Name = "ListIDs"
        Me.ListIDs.Size = New System.Drawing.Size(285, 194)
        Me.ListIDs.Sorted = True
        Me.ListIDs.TabIndex = 12
        '
        'LabIDcount
        '
        Me.LabIDcount.AutoSize = True
        Me.LabIDcount.Location = New System.Drawing.Point(629, 288)
        Me.LabIDcount.Name = "LabIDcount"
        Me.LabIDcount.Size = New System.Drawing.Size(48, 19)
        Me.LabIDcount.TabIndex = 13
        Me.LabIDcount.Text = "个数："
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        '微博批量删除
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(926, 533)
        Me.Controls.Add(Me.LabIDcount)
        Me.Controls.Add(Me.ListIDs)
        Me.Controls.Add(Me.Pn)
        Me.Controls.Add(Me.TxtLog)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "微博批量删除"
        Me.Text = "微博批量删除"
        Me.Pn.ResumeLayout(False)
        Me.Pn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCookie As TextBox
    Friend WithEvents LabCookie As Label
    Friend WithEvents LabRange As Label
    Friend WithEvents LabWhitelist As Label
    Friend WithEvents TxtWhiteList As TextBox
    Friend WithEvents ListWhite As ComboBox
    Friend WithEvents ButGo As Button
    Friend WithEvents TxtLog As TextBox
    Friend WithEvents Pn As Panel
    Friend WithEvents TxtLink1 As TextBox
    Friend WithEvents TxtLink2 As TextBox
    Friend WithEvents ListIDs As ListBox
    Friend WithEvents LabIDcount As Label
    Friend WithEvents LabBUG As Label
    Friend WithEvents ButOld As Button
    Friend WithEvents Timer1 As Forms.Timer
    Friend WithEvents ButHowToCookie As Button
End Class
