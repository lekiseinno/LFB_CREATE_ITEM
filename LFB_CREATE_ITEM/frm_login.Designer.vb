<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_signin = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.header = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectDataBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lb_OnDev = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.dev_path_resource = New System.Windows.Forms.ToolStripMenuItem()
        Me.dev_path_startup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.lb_OnClient = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.client_path_resource = New System.Windows.Forms.ToolStripMenuItem()
        Me.client_path_startup = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.get_versions = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.header.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_exit)
        Me.GroupBox1.Controls.Add(Me.btn_signin)
        Me.GroupBox1.Controls.Add(Me.txt_password)
        Me.GroupBox1.Controls.Add(Me.txt_username)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(50)
        Me.GroupBox1.Size = New System.Drawing.Size(324, 260)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "S i g n  i n "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(171, 177)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(100, 30)
        Me.btn_exit.TabIndex = 3
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_signin
        '
        Me.btn_signin.Location = New System.Drawing.Point(53, 177)
        Me.btn_signin.Name = "btn_signin"
        Me.btn_signin.Size = New System.Drawing.Size(100, 30)
        Me.btn_signin.TabIndex = 2
        Me.btn_signin.Text = "Signin"
        Me.btn_signin.UseVisualStyleBackColor = True
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_password.Location = New System.Drawing.Point(53, 131)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(218, 29)
        Me.txt_password.TabIndex = 1
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_username.Location = New System.Drawing.Point(53, 67)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(218, 29)
        Me.txt_username.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.LFB_CREATE_ITEM.My.Resources.Resources.pricelist_Pic
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(83, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(218, 218)
        Me.Panel1.TabIndex = 1
        '
        'header
        '
        Me.header.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PathToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(384, 24)
        Me.header.TabIndex = 2
        Me.header.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectDataBaseToolStripMenuItem, Me.ConnectionToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem, Me.ToolStripSeparator2})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ConnectDataBaseToolStripMenuItem
        '
        Me.ConnectDataBaseToolStripMenuItem.Name = "ConnectDataBaseToolStripMenuItem"
        Me.ConnectDataBaseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConnectDataBaseToolStripMenuItem.Text = "Connect DataBase"
        '
        'ConnectionToolStripMenuItem
        '
        Me.ConnectionToolStripMenuItem.Name = "ConnectionToolStripMenuItem"
        Me.ConnectionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConnectionToolStripMenuItem.Text = "Cechk Connection"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'PathToolStripMenuItem
        '
        Me.PathToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lb_OnDev, Me.ToolStripSeparator3, Me.dev_path_resource, Me.dev_path_startup, Me.ToolStripSeparator4, Me.lb_OnClient, Me.ToolStripSeparator5, Me.client_path_resource, Me.client_path_startup})
        Me.PathToolStripMenuItem.Name = "PathToolStripMenuItem"
        Me.PathToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.PathToolStripMenuItem.Text = "Check Path"
        '
        'lb_OnDev
        '
        Me.lb_OnDev.Name = "lb_OnDev"
        Me.lb_OnDev.Size = New System.Drawing.Size(182, 22)
        Me.lb_OnDev.Text = "On Dev."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(179, 6)
        '
        'dev_path_resource
        '
        Me.dev_path_resource.Name = "dev_path_resource"
        Me.dev_path_resource.Size = New System.Drawing.Size(182, 22)
        Me.dev_path_resource.Text = "dev_path_resource"
        '
        'dev_path_startup
        '
        Me.dev_path_startup.Name = "dev_path_startup"
        Me.dev_path_startup.Size = New System.Drawing.Size(182, 22)
        Me.dev_path_startup.Text = "dev_path_startup"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(179, 6)
        '
        'lb_OnClient
        '
        Me.lb_OnClient.Name = "lb_OnClient"
        Me.lb_OnClient.Size = New System.Drawing.Size(182, 22)
        Me.lb_OnClient.Text = "On Client"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(179, 6)
        '
        'client_path_resource
        '
        Me.client_path_resource.Name = "client_path_resource"
        Me.client_path_resource.Size = New System.Drawing.Size(182, 22)
        Me.client_path_resource.Text = "client_path_resource"
        '
        'client_path_startup
        '
        Me.client_path_startup.Name = "client_path_startup"
        Me.client_path_startup.Size = New System.Drawing.Size(182, 22)
        Me.client_path_startup.Text = "client_path_startup"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.get_versions})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'get_versions
        '
        Me.get_versions.Name = "get_versions"
        Me.get_versions.Size = New System.Drawing.Size(180, 22)
        Me.get_versions.Text = "?"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 600)
        Me.MinimumSize = New System.Drawing.Size(400, 600)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_signin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents header As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectDataBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents PathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lb_OnDev As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents dev_path_resource As ToolStripMenuItem
    Friend WithEvents dev_path_startup As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents lb_OnClient As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents client_path_resource As ToolStripMenuItem
    Friend WithEvents client_path_startup As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents get_versions As ToolStripMenuItem
End Class
