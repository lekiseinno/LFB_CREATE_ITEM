﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_master))
        Me.header = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectDataBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.footer = New System.Windows.Forms.StatusStrip()
        Me.lb_datenow = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lb_computerName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lb_IPAddress = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Progress_system = New System.Windows.Forms.ToolStripProgressBar()
        Me.timer_datenow = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_print_frm = New System.Windows.Forms.Button()
        Me.btn_item = New System.Windows.Forms.Button()
        Me.btn_report = New System.Windows.Forms.Button()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_discount = New System.Windows.Forms.Button()
        Me.btn_supply = New System.Windows.Forms.Button()
        Me.btn_grade_gram = New System.Windows.Forms.Button()
        Me.btn_PL = New System.Windows.Forms.Button()
        Me.btn_cus = New System.Windows.Forms.Button()
        Me.GB_header = New System.Windows.Forms.GroupBox()
        Me.panel_frm = New System.Windows.Forms.Panel()
        Me.panel_datagrid = New System.Windows.Forms.Panel()
        Me.New_Document = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.header.SuspendLayout()
        Me.footer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GB_header.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ConfigToolStripMenuItem, Me.PathToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1350, 24)
        Me.header.TabIndex = 0
        Me.header.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.New_Document, Me.ToolStripSeparator6, Me.ConnectDataBaseToolStripMenuItem, Me.ConnectionToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem, Me.ToolStripSeparator2})
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
        'ConfigToolStripMenuItem
        '
        Me.ConfigToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GradeToolStripMenuItem})
        Me.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem"
        Me.ConfigToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ConfigToolStripMenuItem.Text = "Config"
        '
        'GradeToolStripMenuItem
        '
        Me.GradeToolStripMenuItem.Name = "GradeToolStripMenuItem"
        Me.GradeToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.GradeToolStripMenuItem.Text = "เกรด กระดาษ"
        '
        'PathToolStripMenuItem
        '
        Me.PathToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lb_OnDev, Me.ToolStripSeparator3, Me.dev_path_resource, Me.dev_path_startup, Me.ToolStripSeparator4, Me.lb_OnClient, Me.ToolStripSeparator5, Me.client_path_resource, Me.client_path_startup})
        Me.PathToolStripMenuItem.Name = "PathToolStripMenuItem"
        Me.PathToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.PathToolStripMenuItem.Text = "Path"
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
        Me.get_versions.Size = New System.Drawing.Size(139, 22)
        Me.get_versions.Text = "get_versions"
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
        Me.GroupBox1.Controls.Add(Me.btn_print_frm)
        Me.GroupBox1.Controls.Add(Me.btn_item)
        Me.GroupBox1.Controls.Add(Me.btn_report)
        Me.GroupBox1.Controls.Add(Me.btn_input)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 682)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " M e n u "
        '
        'btn_print_frm
        '
        Me.btn_print_frm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_print_frm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_print_frm.Image = Global.LFB_CREATE_ITEM.My.Resources.Resources.compose1
        Me.btn_print_frm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_print_frm.Location = New System.Drawing.Point(6, 252)
        Me.btn_print_frm.Name = "btn_print_frm"
        Me.btn_print_frm.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btn_print_frm.Size = New System.Drawing.Size(172, 50)
        Me.btn_print_frm.TabIndex = 106
        Me.btn_print_frm.Text = "Print"
        Me.btn_print_frm.UseVisualStyleBackColor = True
        '
        'btn_item
        '
        Me.btn_item.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_item.Image = Global.LFB_CREATE_ITEM.My.Resources.Resources.compose1
        Me.btn_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_item.Location = New System.Drawing.Point(6, 308)
        Me.btn_item.Name = "btn_item"
        Me.btn_item.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btn_item.Size = New System.Drawing.Size(172, 50)
        Me.btn_item.TabIndex = 105
        Me.btn_item.Text = "iTem"
        Me.btn_item.UseVisualStyleBackColor = True
        '
        'btn_report
        '
        Me.btn_report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_report.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_report.Image = Global.LFB_CREATE_ITEM.My.Resources.Resources.compose1
        Me.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_report.Location = New System.Drawing.Point(6, 75)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btn_report.Size = New System.Drawing.Size(172, 50)
        Me.btn_report.TabIndex = 104
        Me.btn_report.Text = "Report"
        Me.btn_report.UseVisualStyleBackColor = True
        '
        'btn_input
        '
        Me.btn_input.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_input.Image = Global.LFB_CREATE_ITEM.My.Resources.Resources.compose1
        Me.btn_input.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_input.Location = New System.Drawing.Point(6, 19)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btn_input.Size = New System.Drawing.Size(172, 50)
        Me.btn_input.TabIndex = 103
        Me.btn_input.Text = "input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_discount)
        Me.GroupBox2.Controls.Add(Me.btn_supply)
        Me.GroupBox2.Controls.Add(Me.btn_grade_gram)
        Me.GroupBox2.Controls.Add(Me.btn_PL)
        Me.GroupBox2.Controls.Add(Me.btn_cus)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 364)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(172, 312)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "  C o n f i g  "
        '
        'btn_discount
        '
        Me.btn_discount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_discount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_discount.Location = New System.Drawing.Point(6, 276)
        Me.btn_discount.Name = "btn_discount"
        Me.btn_discount.Size = New System.Drawing.Size(160, 30)
        Me.btn_discount.TabIndex = 105
        Me.btn_discount.Text = "Customer Discount"
        Me.btn_discount.UseVisualStyleBackColor = True
        '
        'btn_supply
        '
        Me.btn_supply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_supply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_supply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_supply.Location = New System.Drawing.Point(6, 204)
        Me.btn_supply.Name = "btn_supply"
        Me.btn_supply.Size = New System.Drawing.Size(160, 30)
        Me.btn_supply.TabIndex = 104
        Me.btn_supply.Text = "Supplier"
        Me.btn_supply.UseVisualStyleBackColor = True
        '
        'btn_grade_gram
        '
        Me.btn_grade_gram.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_grade_gram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_grade_gram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_grade_gram.Location = New System.Drawing.Point(6, 19)
        Me.btn_grade_gram.Name = "btn_grade_gram"
        Me.btn_grade_gram.Size = New System.Drawing.Size(160, 30)
        Me.btn_grade_gram.TabIndex = 102
        Me.btn_grade_gram.Text = "Grade Gram"
        Me.btn_grade_gram.UseVisualStyleBackColor = True
        '
        'btn_PL
        '
        Me.btn_PL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_PL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_PL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_PL.Location = New System.Drawing.Point(6, 55)
        Me.btn_PL.Name = "btn_PL"
        Me.btn_PL.Size = New System.Drawing.Size(160, 30)
        Me.btn_PL.TabIndex = 101
        Me.btn_PL.Text = "PL"
        Me.btn_PL.UseVisualStyleBackColor = True
        '
        'btn_cus
        '
        Me.btn_cus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_cus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cus.Location = New System.Drawing.Point(6, 240)
        Me.btn_cus.Name = "btn_cus"
        Me.btn_cus.Size = New System.Drawing.Size(160, 30)
        Me.btn_cus.TabIndex = 100
        Me.btn_cus.Text = "Customer"
        Me.btn_cus.UseVisualStyleBackColor = True
        '
        'GB_header
        '
        Me.GB_header.Controls.Add(Me.panel_frm)
        Me.GB_header.Location = New System.Drawing.Point(192, 22)
        Me.GB_header.Name = "GB_header"
        Me.GB_header.Size = New System.Drawing.Size(1155, 348)
        Me.GB_header.TabIndex = 3
        Me.GB_header.TabStop = False
        Me.GB_header.Text = " Header "
        '
        'panel_frm
        '
        Me.panel_frm.Location = New System.Drawing.Point(2, 19)
        Me.panel_frm.Name = "panel_frm"
        Me.panel_frm.Size = New System.Drawing.Size(1152, 327)
        Me.panel_frm.TabIndex = 0
        '
        'panel_datagrid
        '
        Me.panel_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_datagrid.Location = New System.Drawing.Point(192, 374)
        Me.panel_datagrid.Name = "panel_datagrid"
        Me.panel_datagrid.Size = New System.Drawing.Size(1155, 330)
        Me.panel_datagrid.TabIndex = 4
        '
        'New_Document
        '
        Me.New_Document.Name = "New_Document"
        Me.New_Document.Size = New System.Drawing.Size(180, 22)
        Me.New_Document.Text = "New..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(177, 6)
        '
        'frm_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.panel_datagrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.GB_header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.header
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1366, 768)
        Me.Name = "frm_master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LFB ::"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        Me.footer.ResumeLayout(False)
        Me.footer.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GB_header.ResumeLayout(False)
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
    Friend WithEvents GB_header As GroupBox
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents lb_computerName As ToolStripStatusLabel
    Friend WithEvents btn_cus As Button
    Friend WithEvents btn_PL As Button
    Friend WithEvents panel_datagrid As Panel
    Friend WithEvents panel_frm As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_input As Button
    Friend WithEvents btn_report As Button
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents get_versions As ToolStripMenuItem
    Friend WithEvents PathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dev_path_resource As ToolStripMenuItem
    Friend WithEvents dev_path_startup As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents lb_OnDev As ToolStripMenuItem
    Friend WithEvents lb_OnClient As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents client_path_resource As ToolStripMenuItem
    Friend WithEvents client_path_startup As ToolStripMenuItem
    Friend WithEvents btn_grade_gram As Button
    Friend WithEvents ConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GradeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_supply As Button
    Friend WithEvents btn_item As Button
    Friend WithEvents btn_print_frm As Button
    Friend WithEvents btn_discount As Button
    Friend WithEvents New_Document As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
End Class
