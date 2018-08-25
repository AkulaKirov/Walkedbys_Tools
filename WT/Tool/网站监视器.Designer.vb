<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 网站监视器
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
        Me.ListWebs = New System.Windows.Forms.ComboBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.ButNew = New System.Windows.Forms.Button()
        Me.ButREAD = New System.Windows.Forms.Button()
        Me.ListWhen = New System.Windows.Forms.ComboBox()
        Me.GBweb = New System.Windows.Forms.GroupBox()
        Me.ButIE = New System.Windows.Forms.Button()
        Me.ButiPhone = New System.Windows.Forms.Button()
        Me.ButChrome = New System.Windows.Forms.Button()
        Me.ButSave = New System.Windows.Forms.Button()
        Me.TxtLast = New System.Windows.Forms.TextBox()
        Me.LabLast = New System.Windows.Forms.Label()
        Me.TxtCookie = New System.Windows.Forms.TextBox()
        Me.LabCookie = New System.Windows.Forms.Label()
        Me.TxtOrigin = New System.Windows.Forms.TextBox()
        Me.LabOrigin = New System.Windows.Forms.Label()
        Me.TxtUA = New System.Windows.Forms.TextBox()
        Me.LabUA = New System.Windows.Forms.Label()
        Me.TxtReferer = New System.Windows.Forms.TextBox()
        Me.LabReferer = New System.Windows.Forms.Label()
        Me.TxtURL = New System.Windows.Forms.TextBox()
        Me.LabURL = New System.Windows.Forms.Label()
        Me.ButRM = New System.Windows.Forms.Button()
        Me.LabREGEX = New System.Windows.Forms.Label()
        Me.TxtRegex = New System.Windows.Forms.TextBox()
        Me.GBweb.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListWebs
        '
        Me.ListWebs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListWebs.FormattingEnabled = True
        Me.ListWebs.Location = New System.Drawing.Point(12, 34)
        Me.ListWebs.Name = "ListWebs"
        Me.ListWebs.Size = New System.Drawing.Size(233, 27)
        Me.ListWebs.TabIndex = 0
        Me.ListWebs.TabStop = False
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(251, 34)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(153, 25)
        Me.TxtName.TabIndex = 1
        Me.TxtName.TabStop = False
        '
        'ButNew
        '
        Me.ButNew.Location = New System.Drawing.Point(410, 34)
        Me.ButNew.Name = "ButNew"
        Me.ButNew.Size = New System.Drawing.Size(135, 27)
        Me.ButNew.TabIndex = 2
        Me.ButNew.TabStop = False
        Me.ButNew.Text = "新增监视项目"
        Me.ButNew.UseVisualStyleBackColor = True
        '
        'ButREAD
        '
        Me.ButREAD.Location = New System.Drawing.Point(551, 34)
        Me.ButREAD.Name = "ButREAD"
        Me.ButREAD.Size = New System.Drawing.Size(75, 27)
        Me.ButREAD.TabIndex = 3
        Me.ButREAD.TabStop = False
        Me.ButREAD.Text = "读取"
        Me.ButREAD.UseVisualStyleBackColor = True
        Me.ButREAD.Visible = False
        '
        'ListWhen
        '
        Me.ListWhen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListWhen.FormattingEnabled = True
        Me.ListWhen.Items.AddRange(New Object() {"只在本工具运行的时候", "本软件运行的时候", "现在不记录"})
        Me.ListWhen.Location = New System.Drawing.Point(12, 1)
        Me.ListWhen.Name = "ListWhen"
        Me.ListWhen.Size = New System.Drawing.Size(212, 27)
        Me.ListWhen.TabIndex = 4
        '
        'GBweb
        '
        Me.GBweb.Controls.Add(Me.TxtRegex)
        Me.GBweb.Controls.Add(Me.LabREGEX)
        Me.GBweb.Controls.Add(Me.ButIE)
        Me.GBweb.Controls.Add(Me.ButiPhone)
        Me.GBweb.Controls.Add(Me.ButChrome)
        Me.GBweb.Controls.Add(Me.ButSave)
        Me.GBweb.Controls.Add(Me.TxtLast)
        Me.GBweb.Controls.Add(Me.LabLast)
        Me.GBweb.Controls.Add(Me.TxtCookie)
        Me.GBweb.Controls.Add(Me.LabCookie)
        Me.GBweb.Controls.Add(Me.TxtOrigin)
        Me.GBweb.Controls.Add(Me.LabOrigin)
        Me.GBweb.Controls.Add(Me.TxtUA)
        Me.GBweb.Controls.Add(Me.LabUA)
        Me.GBweb.Controls.Add(Me.TxtReferer)
        Me.GBweb.Controls.Add(Me.LabReferer)
        Me.GBweb.Controls.Add(Me.TxtURL)
        Me.GBweb.Controls.Add(Me.LabURL)
        Me.GBweb.Controls.Add(Me.ButRM)
        Me.GBweb.Location = New System.Drawing.Point(12, 67)
        Me.GBweb.Name = "GBweb"
        Me.GBweb.Size = New System.Drawing.Size(744, 344)
        Me.GBweb.TabIndex = 5
        Me.GBweb.TabStop = False
        '
        'ButIE
        '
        Me.ButIE.Location = New System.Drawing.Point(658, 107)
        Me.ButIE.Name = "ButIE"
        Me.ButIE.Size = New System.Drawing.Size(80, 27)
        Me.ButIE.TabIndex = 17
        Me.ButIE.TabStop = False
        Me.ButIE.Text = "IE11"
        Me.ButIE.UseVisualStyleBackColor = True
        '
        'ButiPhone
        '
        Me.ButiPhone.Location = New System.Drawing.Point(572, 107)
        Me.ButiPhone.Name = "ButiPhone"
        Me.ButiPhone.Size = New System.Drawing.Size(80, 27)
        Me.ButiPhone.TabIndex = 16
        Me.ButiPhone.TabStop = False
        Me.ButiPhone.Text = "iPhone"
        Me.ButiPhone.UseVisualStyleBackColor = True
        '
        'ButChrome
        '
        Me.ButChrome.Location = New System.Drawing.Point(486, 107)
        Me.ButChrome.Name = "ButChrome"
        Me.ButChrome.Size = New System.Drawing.Size(80, 27)
        Me.ButChrome.TabIndex = 15
        Me.ButChrome.TabStop = False
        Me.ButChrome.Text = "Chrome"
        Me.ButChrome.UseVisualStyleBackColor = True
        '
        'ButSave
        '
        Me.ButSave.Enabled = False
        Me.ButSave.Location = New System.Drawing.Point(614, 261)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(127, 43)
        Me.ButSave.TabIndex = 13
        Me.ButSave.Text = "保存此项目信息"
        Me.ButSave.UseVisualStyleBackColor = True
        '
        'TxtLast
        '
        Me.TxtLast.Location = New System.Drawing.Point(95, 205)
        Me.TxtLast.MaxLength = 2000
        Me.TxtLast.Multiline = True
        Me.TxtLast.Name = "TxtLast"
        Me.TxtLast.ReadOnly = True
        Me.TxtLast.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLast.Size = New System.Drawing.Size(519, 131)
        Me.TxtLast.TabIndex = 12
        Me.TxtLast.TabStop = False
        Me.TxtLast.WordWrap = False
        '
        'LabLast
        '
        Me.LabLast.AutoSize = True
        Me.LabLast.Location = New System.Drawing.Point(6, 205)
        Me.LabLast.Name = "LabLast"
        Me.LabLast.Size = New System.Drawing.Size(74, 19)
        Me.LabLast.TabIndex = 11
        Me.LabLast.Text = "最后回应："
        '
        'TxtCookie
        '
        Me.TxtCookie.Location = New System.Drawing.Point(86, 141)
        Me.TxtCookie.MaxLength = 2000
        Me.TxtCookie.Name = "TxtCookie"
        Me.TxtCookie.Size = New System.Drawing.Size(652, 25)
        Me.TxtCookie.TabIndex = 10
        Me.TxtCookie.TabStop = False
        '
        'LabCookie
        '
        Me.LabCookie.AutoSize = True
        Me.LabCookie.Location = New System.Drawing.Point(6, 141)
        Me.LabCookie.Name = "LabCookie"
        Me.LabCookie.Size = New System.Drawing.Size(64, 19)
        Me.LabCookie.TabIndex = 9
        Me.LabCookie.Text = "Cookie："
        '
        'TxtOrigin
        '
        Me.TxtOrigin.Location = New System.Drawing.Point(86, 80)
        Me.TxtOrigin.MaxLength = 300
        Me.TxtOrigin.Name = "TxtOrigin"
        Me.TxtOrigin.Size = New System.Drawing.Size(652, 25)
        Me.TxtOrigin.TabIndex = 8
        Me.TxtOrigin.TabStop = False
        '
        'LabOrigin
        '
        Me.LabOrigin.AutoSize = True
        Me.LabOrigin.Location = New System.Drawing.Point(6, 80)
        Me.LabOrigin.Name = "LabOrigin"
        Me.LabOrigin.Size = New System.Drawing.Size(60, 19)
        Me.LabOrigin.TabIndex = 7
        Me.LabOrigin.Text = "Origin："
        '
        'TxtUA
        '
        Me.TxtUA.Location = New System.Drawing.Point(86, 111)
        Me.TxtUA.MaxLength = 300
        Me.TxtUA.Name = "TxtUA"
        Me.TxtUA.Size = New System.Drawing.Size(394, 25)
        Me.TxtUA.TabIndex = 6
        Me.TxtUA.TabStop = False
        Me.TxtUA.Text = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) C" &
    "hrome/69.0.3497.12 Safari/537.36"
        '
        'LabUA
        '
        Me.LabUA.AutoSize = True
        Me.LabUA.Location = New System.Drawing.Point(6, 111)
        Me.LabUA.Name = "LabUA"
        Me.LabUA.Size = New System.Drawing.Size(41, 19)
        Me.LabUA.TabIndex = 5
        Me.LabUA.Text = "UA："
        '
        'TxtReferer
        '
        Me.TxtReferer.Location = New System.Drawing.Point(86, 49)
        Me.TxtReferer.MaxLength = 300
        Me.TxtReferer.Name = "TxtReferer"
        Me.TxtReferer.Size = New System.Drawing.Size(652, 25)
        Me.TxtReferer.TabIndex = 4
        Me.TxtReferer.TabStop = False
        '
        'LabReferer
        '
        Me.LabReferer.AutoSize = True
        Me.LabReferer.Location = New System.Drawing.Point(6, 52)
        Me.LabReferer.Name = "LabReferer"
        Me.LabReferer.Size = New System.Drawing.Size(66, 19)
        Me.LabReferer.TabIndex = 3
        Me.LabReferer.Text = "Referer："
        '
        'TxtURL
        '
        Me.TxtURL.Location = New System.Drawing.Point(86, 18)
        Me.TxtURL.MaxLength = 300
        Me.TxtURL.Name = "TxtURL"
        Me.TxtURL.Size = New System.Drawing.Size(652, 25)
        Me.TxtURL.TabIndex = 2
        Me.TxtURL.TabStop = False
        '
        'LabURL
        '
        Me.LabURL.AutoSize = True
        Me.LabURL.Location = New System.Drawing.Point(6, 21)
        Me.LabURL.Name = "LabURL"
        Me.LabURL.Size = New System.Drawing.Size(74, 19)
        Me.LabURL.TabIndex = 1
        Me.LabURL.Text = "请求链接："
        '
        'ButRM
        '
        Me.ButRM.Location = New System.Drawing.Point(614, 310)
        Me.ButRM.Name = "ButRM"
        Me.ButRM.Size = New System.Drawing.Size(127, 26)
        Me.ButRM.TabIndex = 0
        Me.ButRM.Text = "删除本监视项目"
        Me.ButRM.UseVisualStyleBackColor = True
        '
        'LabREGEX
        '
        Me.LabREGEX.AutoSize = True
        Me.LabREGEX.Location = New System.Drawing.Point(8, 175)
        Me.LabREGEX.Name = "LabREGEX"
        Me.LabREGEX.Size = New System.Drawing.Size(152, 19)
        Me.LabREGEX.TabIndex = 18
        Me.LabREGEX.Text = "只查找（正则表达式）："
        '
        'TxtRegex
        '
        Me.TxtRegex.Location = New System.Drawing.Point(166, 172)
        Me.TxtRegex.MaxLength = 300
        Me.TxtRegex.Name = "TxtRegex"
        Me.TxtRegex.Size = New System.Drawing.Size(572, 25)
        Me.TxtRegex.TabIndex = 19
        Me.TxtRegex.TabStop = False
        '
        '网站监视器
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(765, 423)
        Me.Controls.Add(Me.GBweb)
        Me.Controls.Add(Me.ListWhen)
        Me.Controls.Add(Me.ButREAD)
        Me.Controls.Add(Me.ButNew)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.ListWebs)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MaximizeBox = False
        Me.Name = "网站监视器"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "网站监视器"
        Me.GBweb.ResumeLayout(False)
        Me.GBweb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListWebs As ComboBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents ButNew As Button
    Friend WithEvents ButREAD As Button
    Friend WithEvents ListWhen As ComboBox
    Friend WithEvents GBweb As GroupBox
    Friend WithEvents ButRM As Button
    Friend WithEvents LabURL As Label
    Friend WithEvents TxtURL As TextBox
    Friend WithEvents LabReferer As Label
    Friend WithEvents TxtReferer As TextBox
    Friend WithEvents LabUA As Label
    Friend WithEvents TxtUA As TextBox
    Friend WithEvents LabOrigin As Label
    Friend WithEvents TxtOrigin As TextBox
    Friend WithEvents TxtCookie As TextBox
    Friend WithEvents LabCookie As Label
    Friend WithEvents LabLast As Label
    Friend WithEvents TxtLast As TextBox
    Friend WithEvents ButSave As Button
    Friend WithEvents ButChrome As Button
    Friend WithEvents ButiPhone As Button
    Friend WithEvents ButIE As Button
    Friend WithEvents LabREGEX As Label
    Friend WithEvents TxtRegex As TextBox
End Class
