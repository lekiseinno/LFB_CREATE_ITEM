﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class setup_master
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setup_master))
        Me.header = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectDataBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.footer = New System.Windows.Forms.StatusStrip()
        Me.lb_datenow = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lb_computerName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lb_IPAddress = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Progress_system = New System.Windows.Forms.ToolStripProgressBar()
        Me.timer_datenow = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_PL = New System.Windows.Forms.Button()
        Me.btn_cus = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.panel_main = New System.Windows.Forms.Panel()
        Me.header.SuspendLayout()
        Me.footer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1350, 24)
        Me.header.TabIndex = 0
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
        Me.ConnectDataBaseToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ConnectDataBaseToolStripMenuItem.Text = "Connect DataBase"
        '
        'ConnectionToolStripMenuItem
        '
        Me.ConnectionToolStripMenuItem.Name = "ConnectionToolStripMenuItem"
        Me.ConnectionToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ConnectionToolStripMenuItem.Text = "Cechk Connection"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(169, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(169, 6)
        '
        'footer
        '
        Me.footer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lb_datenow, Me.ToolStripStatusLabel4, Me.lb_computerName, Me.ToolStripStatusLabel5, Me.lb_IPAddress, Me.Progress_system})
        Me.footer.Location = New System.Drawing.Point(0, 707)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(1350, 22)
        Me.footer.TabIndex = 1
        Me.footer.Text = "StatusStrip1"
        '
        'lb_datenow
        '
        Me.lb_datenow.Name = "lb_datenow"
        Me.lb_datenow.Size = New System.Drawing.Size(68, 17)
        Me.lb_datenow.Text = "lb_datenow"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(16, 17)
        Me.ToolStripStatusLabel4.Text = " | "
        '
        'lb_computerName
        '
        Me.lb_computerName.Name = "lb_computerName"
        Me.lb_computerName.Size = New System.Drawing.Size(106, 17)
        Me.lb_computerName.Text = "lb_computerName"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(16, 17)
        Me.ToolStripStatusLabel5.Text = " | "
        '
        'lb_IPAddress
        '
        Me.lb_IPAddress.Name = "lb_IPAddress"
        Me.lb_IPAddress.Size = New System.Drawing.Size(73, 17)
        Me.lb_IPAddress.Text = "lb_IPAddress"
        '
        'Progress_system
        '
        Me.Progress_system.Name = "Progress_system"
        Me.Progress_system.Size = New System.Drawing.Size(100, 16)
        '
        'timer_datenow
        '
        Me.timer_datenow.Enabled = True
        Me.timer_datenow.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_PL)
        Me.GroupBox1.Controls.Add(Me.btn_cus)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 677)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Menu "
        '
        'btn_PL
        '
        Me.btn_PL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_PL.Font = New System.Drawing.Font("Sukhumvit Set", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_PL.Image = Global.LFB_CREATE_ITEM.My.Resources.Resources.folder
        Me.btn_PL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_PL.Location = New System.Drawing.Point(6, 75)
        Me.btn_PL.Name = "btn_PL"
        Me.btn_PL.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btn_PL.Size = New System.Drawing.Size(168, 50)
        Me.btn_PL.TabIndex = 101
        Me.btn_PL.Text = "PL"
        Me.btn_PL.UseVisualStyleBackColor = True
        '
        'btn_cus
        '
        Me.btn_cus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cus.Font = New System.Drawing.Font("Sukhumvit Set", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_cus.Image = Global.LFB_CREATE_ITEM.My.Resources.Resources.contacts
        Me.btn_cus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cus.Location = New System.Drawing.Point(6, 19)
        Me.btn_cus.Name = "btn_cus"
        Me.btn_cus.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btn_cus.Size = New System.Drawing.Size(168, 50)
        Me.btn_cus.TabIndex = 100
        Me.btn_cus.Text = "ลูกค้า"
        Me.btn_cus.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(192, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1155, 278)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Header "
        '
        'panel_main
        '
        Me.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_main.Location = New System.Drawing.Point(192, 304)
        Me.panel_main.Name = "panel_main"
        Me.panel_main.Size = New System.Drawing.Size(1155, 400)
        Me.panel_main.TabIndex = 4
        '
        'setup_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.panel_main)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.header
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1366, 768)
        Me.Name = "setup_master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Config - Master"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        Me.footer.ResumeLayout(False)
        Me.footer.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents header As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents footer As StatusStrip
    Friend WithEvents lb_IPAddress As ToolStripStatusLabel
    Friend WithEvents ConnectDataBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Progress_system As ToolStripProgressBar
    Friend WithEvents lb_datenow As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents timer_datenow As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents lb_computerName As ToolStripStatusLabel
    Friend WithEvents btn_cus As Button
    Friend WithEvents btn_PL As Button
    Friend WithEvents panel_main As Panel
End Class
