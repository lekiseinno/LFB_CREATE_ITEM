<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class data_excelfile
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
        Me.lb_search = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.DataGrid_bom_header = New System.Windows.Forms.DataGridView()
        Me.Tab_main = New System.Windows.Forms.TabControl()
        Me.Tab_bom_header = New System.Windows.Forms.TabPage()
        Me.Tab_bom_line = New System.Windows.Forms.TabPage()
        Me.DataGrid_bom_line = New System.Windows.Forms.DataGridView()
        Me.Tab_default_dimension = New System.Windows.Forms.TabPage()
        Me.DataGrid_Default_dimension = New System.Windows.Forms.DataGridView()
        Me.Tab_item_master = New System.Windows.Forms.TabPage()
        Me.DataGrid_Item_master = New System.Windows.Forms.DataGridView()
        Me.Tab_item_unit = New System.Windows.Forms.TabPage()
        Me.DataGrid_Item_unit = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGrid_codetxt = New System.Windows.Forms.DataGridView()
        Me.btn_to_input = New System.Windows.Forms.Button()
        CType(Me.DataGrid_bom_header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_main.SuspendLayout()
        Me.Tab_bom_header.SuspendLayout()
        Me.Tab_bom_line.SuspendLayout()
        CType(Me.DataGrid_bom_line, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_default_dimension.SuspendLayout()
        CType(Me.DataGrid_Default_dimension, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_item_master.SuspendLayout()
        CType(Me.DataGrid_Item_master, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_item_unit.SuspendLayout()
        CType(Me.DataGrid_Item_unit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGrid_codetxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_search
        '
        Me.lb_search.AutoSize = True
        Me.lb_search.Location = New System.Drawing.Point(893, 4)
        Me.lb_search.Name = "lb_search"
        Me.lb_search.Size = New System.Drawing.Size(59, 13)
        Me.lb_search.TabIndex = 7
        Me.lb_search.Text = "Search . . ."
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.txt_search.Location = New System.Drawing.Point(952, 1)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(200, 19)
        Me.txt_search.TabIndex = 6
        '
        'DataGrid_bom_header
        '
        Me.DataGrid_bom_header.AllowUserToAddRows = False
        Me.DataGrid_bom_header.AllowUserToDeleteRows = False
        Me.DataGrid_bom_header.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_bom_header.Location = New System.Drawing.Point(1, 2)
        Me.DataGrid_bom_header.Name = "DataGrid_bom_header"
        Me.DataGrid_bom_header.Size = New System.Drawing.Size(1142, 297)
        Me.DataGrid_bom_header.TabIndex = 5
        '
        'Tab_main
        '
        Me.Tab_main.Controls.Add(Me.Tab_bom_header)
        Me.Tab_main.Controls.Add(Me.Tab_bom_line)
        Me.Tab_main.Controls.Add(Me.Tab_default_dimension)
        Me.Tab_main.Controls.Add(Me.Tab_item_master)
        Me.Tab_main.Controls.Add(Me.Tab_item_unit)
        Me.Tab_main.Controls.Add(Me.TabPage1)
        Me.Tab_main.Location = New System.Drawing.Point(1, 1)
        Me.Tab_main.Name = "Tab_main"
        Me.Tab_main.SelectedIndex = 0
        Me.Tab_main.Size = New System.Drawing.Size(1153, 327)
        Me.Tab_main.TabIndex = 9
        '
        'Tab_bom_header
        '
        Me.Tab_bom_header.BackColor = System.Drawing.Color.Transparent
        Me.Tab_bom_header.Controls.Add(Me.DataGrid_bom_header)
        Me.Tab_bom_header.Location = New System.Drawing.Point(4, 22)
        Me.Tab_bom_header.Name = "Tab_bom_header"
        Me.Tab_bom_header.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_bom_header.Size = New System.Drawing.Size(1145, 301)
        Me.Tab_bom_header.TabIndex = 0
        Me.Tab_bom_header.Text = "BOM  H e a d e r"
        '
        'Tab_bom_line
        '
        Me.Tab_bom_line.Controls.Add(Me.DataGrid_bom_line)
        Me.Tab_bom_line.Location = New System.Drawing.Point(4, 22)
        Me.Tab_bom_line.Name = "Tab_bom_line"
        Me.Tab_bom_line.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_bom_line.Size = New System.Drawing.Size(1145, 301)
        Me.Tab_bom_line.TabIndex = 1
        Me.Tab_bom_line.Text = "BOM  L i n e"
        Me.Tab_bom_line.UseVisualStyleBackColor = True
        '
        'DataGrid_bom_line
        '
        Me.DataGrid_bom_line.AllowUserToAddRows = False
        Me.DataGrid_bom_line.AllowUserToDeleteRows = False
        Me.DataGrid_bom_line.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_bom_line.Location = New System.Drawing.Point(1, 2)
        Me.DataGrid_bom_line.Name = "DataGrid_bom_line"
        Me.DataGrid_bom_line.Size = New System.Drawing.Size(1142, 297)
        Me.DataGrid_bom_line.TabIndex = 0
        '
        'Tab_default_dimension
        '
        Me.Tab_default_dimension.Controls.Add(Me.DataGrid_Default_dimension)
        Me.Tab_default_dimension.Location = New System.Drawing.Point(4, 22)
        Me.Tab_default_dimension.Name = "Tab_default_dimension"
        Me.Tab_default_dimension.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_default_dimension.Size = New System.Drawing.Size(1145, 301)
        Me.Tab_default_dimension.TabIndex = 2
        Me.Tab_default_dimension.Text = "Default  Dimension"
        Me.Tab_default_dimension.UseVisualStyleBackColor = True
        '
        'DataGrid_Default_dimension
        '
        Me.DataGrid_Default_dimension.AllowUserToAddRows = False
        Me.DataGrid_Default_dimension.AllowUserToDeleteRows = False
        Me.DataGrid_Default_dimension.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Default_dimension.Location = New System.Drawing.Point(1, 2)
        Me.DataGrid_Default_dimension.Name = "DataGrid_Default_dimension"
        Me.DataGrid_Default_dimension.Size = New System.Drawing.Size(1142, 297)
        Me.DataGrid_Default_dimension.TabIndex = 0
        '
        'Tab_item_master
        '
        Me.Tab_item_master.Controls.Add(Me.DataGrid_Item_master)
        Me.Tab_item_master.Location = New System.Drawing.Point(4, 22)
        Me.Tab_item_master.Name = "Tab_item_master"
        Me.Tab_item_master.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_item_master.Size = New System.Drawing.Size(1145, 301)
        Me.Tab_item_master.TabIndex = 3
        Me.Tab_item_master.Text = "Item  Master"
        Me.Tab_item_master.UseVisualStyleBackColor = True
        '
        'DataGrid_Item_master
        '
        Me.DataGrid_Item_master.AllowUserToAddRows = False
        Me.DataGrid_Item_master.AllowUserToDeleteRows = False
        Me.DataGrid_Item_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Item_master.Location = New System.Drawing.Point(1, 2)
        Me.DataGrid_Item_master.Name = "DataGrid_Item_master"
        Me.DataGrid_Item_master.Size = New System.Drawing.Size(1142, 297)
        Me.DataGrid_Item_master.TabIndex = 0
        '
        'Tab_item_unit
        '
        Me.Tab_item_unit.Controls.Add(Me.DataGrid_Item_unit)
        Me.Tab_item_unit.Location = New System.Drawing.Point(4, 22)
        Me.Tab_item_unit.Name = "Tab_item_unit"
        Me.Tab_item_unit.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_item_unit.Size = New System.Drawing.Size(1145, 301)
        Me.Tab_item_unit.TabIndex = 4
        Me.Tab_item_unit.Text = "Item Unit of Messure"
        Me.Tab_item_unit.UseVisualStyleBackColor = True
        '
        'DataGrid_Item_unit
        '
        Me.DataGrid_Item_unit.AllowUserToAddRows = False
        Me.DataGrid_Item_unit.AllowUserToDeleteRows = False
        Me.DataGrid_Item_unit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Item_unit.Location = New System.Drawing.Point(1, 2)
        Me.DataGrid_Item_unit.Name = "DataGrid_Item_unit"
        Me.DataGrid_Item_unit.Size = New System.Drawing.Size(1142, 297)
        Me.DataGrid_Item_unit.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGrid_codetxt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1145, 301)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "Code.txt"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGrid_codetxt
        '
        Me.DataGrid_codetxt.AllowUserToAddRows = False
        Me.DataGrid_codetxt.AllowUserToDeleteRows = False
        Me.DataGrid_codetxt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_codetxt.Location = New System.Drawing.Point(1, 2)
        Me.DataGrid_codetxt.Name = "DataGrid_codetxt"
        Me.DataGrid_codetxt.Size = New System.Drawing.Size(1142, 297)
        Me.DataGrid_codetxt.TabIndex = 0
        '
        'btn_to_input
        '
        Me.btn_to_input.Location = New System.Drawing.Point(797, 0)
        Me.btn_to_input.Name = "btn_to_input"
        Me.btn_to_input.Size = New System.Drawing.Size(75, 22)
        Me.btn_to_input.TabIndex = 10
        Me.btn_to_input.Text = "input"
        Me.btn_to_input.UseVisualStyleBackColor = True
        '
        'data_excelfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1155, 328)
        Me.Controls.Add(Me.btn_to_input)
        Me.Controls.Add(Me.lb_search)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Tab_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "data_excelfile"
        Me.Text = "data_input"
        CType(Me.DataGrid_bom_header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_main.ResumeLayout(False)
        Me.Tab_bom_header.ResumeLayout(False)
        Me.Tab_bom_line.ResumeLayout(False)
        CType(Me.DataGrid_bom_line, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_default_dimension.ResumeLayout(False)
        CType(Me.DataGrid_Default_dimension, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_item_master.ResumeLayout(False)
        CType(Me.DataGrid_Item_master, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_item_unit.ResumeLayout(False)
        CType(Me.DataGrid_Item_unit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGrid_codetxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_search As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents DataGrid_bom_header As DataGridView
    Friend WithEvents Tab_main As TabControl
    Friend WithEvents Tab_bom_header As TabPage
    Friend WithEvents Tab_bom_line As TabPage
    Friend WithEvents Tab_default_dimension As TabPage
    Friend WithEvents Tab_item_master As TabPage
    Friend WithEvents Tab_item_unit As TabPage
    Friend WithEvents DataGrid_bom_line As DataGridView
    Friend WithEvents DataGrid_Default_dimension As DataGridView
    Friend WithEvents DataGrid_Item_master As DataGridView
    Friend WithEvents DataGrid_Item_unit As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGrid_codetxt As DataGridView
    Friend WithEvents btn_to_input As Button
End Class
