<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 博客系统
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(博客系统))
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.TabMain = New System.Windows.Forms.TabPage()
        Me.TxtFriendsLink = New System.Windows.Forms.TextBox()
        Me.LabFriendsLink = New System.Windows.Forms.Label()
        Me.TxtWebDescription = New System.Windows.Forms.TextBox()
        Me.LabWebDescription = New System.Windows.Forms.Label()
        Me.TxtWebTitle = New System.Windows.Forms.TextBox()
        Me.LabWebTitle = New System.Windows.Forms.Label()
        Me.TabHead = New System.Windows.Forms.TabPage()
        Me.TxtHead = New System.Windows.Forms.TextBox()
        Me.TxtHeadLocked = New System.Windows.Forms.TextBox()
        Me.LabHeadInfo = New System.Windows.Forms.Label()
        Me.TabPosts = New System.Windows.Forms.TabPage()
        Me.ButNewPost = New System.Windows.Forms.Button()
        Me.TxtNewPost = New System.Windows.Forms.TextBox()
        Me.ButCheckPosts = New System.Windows.Forms.Button()
        Me.LabPostsNote = New System.Windows.Forms.Label()
        Me.ButRefreshPostList = New System.Windows.Forms.Button()
        Me.ListPosts = New System.Windows.Forms.ListBox()
        Me.ButGenerate = New System.Windows.Forms.Button()
        Me.Tabs.SuspendLayout()
        Me.TabMain.SuspendLayout()
        Me.TabHead.SuspendLayout()
        Me.TabPosts.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.TabMain)
        Me.Tabs.Controls.Add(Me.TabHead)
        Me.Tabs.Controls.Add(Me.TabPosts)
        Me.Tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabs.Location = New System.Drawing.Point(0, 0)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(757, 449)
        Me.Tabs.TabIndex = 0
        Me.Tabs.TabStop = False
        '
        'TabMain
        '
        Me.TabMain.Controls.Add(Me.ButGenerate)
        Me.TabMain.Controls.Add(Me.TxtFriendsLink)
        Me.TabMain.Controls.Add(Me.LabFriendsLink)
        Me.TabMain.Controls.Add(Me.TxtWebDescription)
        Me.TabMain.Controls.Add(Me.LabWebDescription)
        Me.TabMain.Controls.Add(Me.TxtWebTitle)
        Me.TabMain.Controls.Add(Me.LabWebTitle)
        Me.TabMain.Location = New System.Drawing.Point(4, 28)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMain.Size = New System.Drawing.Size(749, 417)
        Me.TabMain.TabIndex = 0
        Me.TabMain.Text = "整体选项"
        Me.TabMain.UseVisualStyleBackColor = True
        '
        'TxtFriendsLink
        '
        Me.TxtFriendsLink.Location = New System.Drawing.Point(12, 134)
        Me.TxtFriendsLink.Multiline = True
        Me.TxtFriendsLink.Name = "TxtFriendsLink"
        Me.TxtFriendsLink.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtFriendsLink.Size = New System.Drawing.Size(329, 233)
        Me.TxtFriendsLink.TabIndex = 5
        Me.TxtFriendsLink.WordWrap = False
        '
        'LabFriendsLink
        '
        Me.LabFriendsLink.AutoSize = True
        Me.LabFriendsLink.Location = New System.Drawing.Point(8, 93)
        Me.LabFriendsLink.Name = "LabFriendsLink"
        Me.LabFriendsLink.Size = New System.Drawing.Size(204, 38)
        Me.LabFriendsLink.TabIndex = 4
        Me.LabFriendsLink.Text = "自定义网站顶部链接，示例如下：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "百度：https://baidu.com/"
        '
        'TxtWebDescription
        '
        Me.TxtWebDescription.Location = New System.Drawing.Point(88, 53)
        Me.TxtWebDescription.MaxLength = 200
        Me.TxtWebDescription.Name = "TxtWebDescription"
        Me.TxtWebDescription.Size = New System.Drawing.Size(653, 25)
        Me.TxtWebDescription.TabIndex = 3
        Me.TxtWebDescription.TabStop = False
        '
        'LabWebDescription
        '
        Me.LabWebDescription.AutoSize = True
        Me.LabWebDescription.Location = New System.Drawing.Point(8, 53)
        Me.LabWebDescription.Name = "LabWebDescription"
        Me.LabWebDescription.Size = New System.Drawing.Size(74, 19)
        Me.LabWebDescription.TabIndex = 2
        Me.LabWebDescription.Text = "网站简介："
        '
        'TxtWebTitle
        '
        Me.TxtWebTitle.Location = New System.Drawing.Point(88, 15)
        Me.TxtWebTitle.MaxLength = 100
        Me.TxtWebTitle.Name = "TxtWebTitle"
        Me.TxtWebTitle.Size = New System.Drawing.Size(653, 25)
        Me.TxtWebTitle.TabIndex = 1
        Me.TxtWebTitle.TabStop = False
        '
        'LabWebTitle
        '
        Me.LabWebTitle.AutoSize = True
        Me.LabWebTitle.Location = New System.Drawing.Point(8, 18)
        Me.LabWebTitle.Name = "LabWebTitle"
        Me.LabWebTitle.Size = New System.Drawing.Size(74, 19)
        Me.LabWebTitle.TabIndex = 0
        Me.LabWebTitle.Text = "网站标题："
        '
        'TabHead
        '
        Me.TabHead.Controls.Add(Me.TxtHead)
        Me.TabHead.Controls.Add(Me.TxtHeadLocked)
        Me.TabHead.Controls.Add(Me.LabHeadInfo)
        Me.TabHead.Location = New System.Drawing.Point(4, 28)
        Me.TabHead.Name = "TabHead"
        Me.TabHead.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHead.Size = New System.Drawing.Size(749, 417)
        Me.TabHead.TabIndex = 1
        Me.TabHead.Text = "<head>"
        Me.TabHead.UseVisualStyleBackColor = True
        '
        'TxtHead
        '
        Me.TxtHead.Location = New System.Drawing.Point(12, 170)
        Me.TxtHead.Multiline = True
        Me.TxtHead.Name = "TxtHead"
        Me.TxtHead.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtHead.Size = New System.Drawing.Size(729, 239)
        Me.TxtHead.TabIndex = 2
        Me.TxtHead.WordWrap = False
        '
        'TxtHeadLocked
        '
        Me.TxtHeadLocked.Location = New System.Drawing.Point(12, 25)
        Me.TxtHeadLocked.Multiline = True
        Me.TxtHeadLocked.Name = "TxtHeadLocked"
        Me.TxtHeadLocked.ReadOnly = True
        Me.TxtHeadLocked.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtHeadLocked.Size = New System.Drawing.Size(729, 139)
        Me.TxtHeadLocked.TabIndex = 1
        Me.TxtHeadLocked.WordWrap = False
        '
        'LabHeadInfo
        '
        Me.LabHeadInfo.AutoSize = True
        Me.LabHeadInfo.Location = New System.Drawing.Point(8, 3)
        Me.LabHeadInfo.Name = "LabHeadInfo"
        Me.LabHeadInfo.Size = New System.Drawing.Size(228, 19)
        Me.LabHeadInfo.TabIndex = 0
        Me.LabHeadInfo.Text = "以下信息会写在每一个HTML的开头："
        '
        'TabPosts
        '
        Me.TabPosts.Controls.Add(Me.ButNewPost)
        Me.TabPosts.Controls.Add(Me.TxtNewPost)
        Me.TabPosts.Controls.Add(Me.ButCheckPosts)
        Me.TabPosts.Controls.Add(Me.LabPostsNote)
        Me.TabPosts.Controls.Add(Me.ButRefreshPostList)
        Me.TabPosts.Controls.Add(Me.ListPosts)
        Me.TabPosts.Location = New System.Drawing.Point(4, 28)
        Me.TabPosts.Name = "TabPosts"
        Me.TabPosts.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPosts.Size = New System.Drawing.Size(749, 417)
        Me.TabPosts.TabIndex = 2
        Me.TabPosts.Text = "文章"
        Me.TabPosts.UseVisualStyleBackColor = True
        '
        'ButNewPost
        '
        Me.ButNewPost.Enabled = False
        Me.ButNewPost.Location = New System.Drawing.Point(589, 321)
        Me.ButNewPost.Name = "ButNewPost"
        Me.ButNewPost.Size = New System.Drawing.Size(115, 25)
        Me.ButNewPost.TabIndex = 7
        Me.ButNewPost.TabStop = False
        Me.ButNewPost.Text = "新建文章"
        Me.ButNewPost.UseVisualStyleBackColor = True
        '
        'TxtNewPost
        '
        Me.TxtNewPost.Location = New System.Drawing.Point(200, 321)
        Me.TxtNewPost.MaxLength = 100
        Me.TxtNewPost.Name = "TxtNewPost"
        Me.TxtNewPost.Size = New System.Drawing.Size(383, 25)
        Me.TxtNewPost.TabIndex = 6
        Me.TxtNewPost.TabStop = False
        '
        'ButCheckPosts
        '
        Me.ButCheckPosts.Location = New System.Drawing.Point(200, 278)
        Me.ButCheckPosts.Name = "ButCheckPosts"
        Me.ButCheckPosts.Size = New System.Drawing.Size(182, 37)
        Me.ButCheckPosts.TabIndex = 5
        Me.ButCheckPosts.TabStop = False
        Me.ButCheckPosts.Text = "查看文件夹"
        Me.ButCheckPosts.UseVisualStyleBackColor = True
        '
        'LabPostsNote
        '
        Me.LabPostsNote.AutoSize = True
        Me.LabPostsNote.Location = New System.Drawing.Point(200, 6)
        Me.LabPostsNote.Name = "LabPostsNote"
        Me.LabPostsNote.Size = New System.Drawing.Size(355, 266)
        Me.LabPostsNote.TabIndex = 4
        Me.LabPostsNote.Text = resources.GetString("LabPostsNote.Text")
        '
        'ButRefreshPostList
        '
        Me.ButRefreshPostList.Location = New System.Drawing.Point(8, 6)
        Me.ButRefreshPostList.Name = "ButRefreshPostList"
        Me.ButRefreshPostList.Size = New System.Drawing.Size(186, 37)
        Me.ButRefreshPostList.TabIndex = 3
        Me.ButRefreshPostList.TabStop = False
        Me.ButRefreshPostList.Text = "刷新文章列表"
        Me.ButRefreshPostList.UseVisualStyleBackColor = True
        '
        'ListPosts
        '
        Me.ListPosts.FormattingEnabled = True
        Me.ListPosts.ItemHeight = 19
        Me.ListPosts.Location = New System.Drawing.Point(8, 49)
        Me.ListPosts.Name = "ListPosts"
        Me.ListPosts.Size = New System.Drawing.Size(186, 346)
        Me.ListPosts.TabIndex = 2
        Me.ListPosts.TabStop = False
        '
        'ButGenerate
        '
        Me.ButGenerate.Location = New System.Drawing.Point(12, 373)
        Me.ButGenerate.Name = "ButGenerate"
        Me.ButGenerate.Size = New System.Drawing.Size(329, 36)
        Me.ButGenerate.TabIndex = 6
        Me.ButGenerate.TabStop = False
        Me.ButGenerate.Text = "生成全部文件到 public 文件夹"
        Me.ButGenerate.UseVisualStyleBackColor = True
        '
        '博客系统
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(757, 449)
        Me.Controls.Add(Me.Tabs)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "博客系统"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "博客系统"
        Me.Tabs.ResumeLayout(False)
        Me.TabMain.ResumeLayout(False)
        Me.TabMain.PerformLayout()
        Me.TabHead.ResumeLayout(False)
        Me.TabHead.PerformLayout()
        Me.TabPosts.ResumeLayout(False)
        Me.TabPosts.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tabs As TabControl
    Friend WithEvents TabMain As TabPage
    Friend WithEvents LabWebTitle As Label
    Friend WithEvents TxtWebTitle As TextBox
    Friend WithEvents LabWebDescription As Label
    Friend WithEvents TxtWebDescription As TextBox
    Friend WithEvents TabHead As TabPage
    Friend WithEvents LabHeadInfo As Label
    Friend WithEvents TxtHeadLocked As TextBox
    Friend WithEvents TxtHead As TextBox
    Friend WithEvents TabPosts As TabPage
    Friend WithEvents ListPosts As ListBox
    Friend WithEvents ButRefreshPostList As Button
    Friend WithEvents LabPostsNote As Label
    Friend WithEvents ButCheckPosts As Button
    Friend WithEvents ButNewPost As Button
    Friend WithEvents TxtNewPost As TextBox
    Friend WithEvents LabFriendsLink As Label
    Friend WithEvents TxtFriendsLink As TextBox
    Friend WithEvents ButGenerate As Button
End Class
