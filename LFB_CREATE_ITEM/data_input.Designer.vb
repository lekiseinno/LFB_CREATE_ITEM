<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class data_input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(data_input))
        Me.btn_csv = New System.Windows.Forms.Button()
        Me.btn_excel = New System.Windows.Forms.Button()
        Me.btn_copy = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.DataGrid_input = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_to_excel = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.btn_to_cal = New System.Windows.Forms.Button()
        CType(Me.DataGrid_input, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_csv
        '
        Me.btn_csv.Location = New System.Drawing.Point(210, 0)
        Me.btn_csv.Name = "btn_csv"
        Me.btn_csv.Size = New System.Drawing.Size(130, 22)
        Me.btn_csv.TabIndex = 17
        Me.btn_csv.Text = "Export Excel (*.csv)"
        Me.btn_csv.UseVisualStyleBackColor = True
        '
        'btn_excel
        '
        Me.btn_excel.Location = New System.Drawing.Point(80, 0)
        Me.btn_excel.Name = "btn_excel"
        Me.btn_excel.Size = New System.Drawing.Size(130, 22)
        Me.btn_excel.TabIndex = 16
        Me.btn_excel.Text = "Export Excel (*.xls)"
        Me.btn_excel.UseVisualStyleBackColor = True
        '
        'btn_copy
        '
        Me.btn_copy.Location = New System.Drawing.Point(0, 0)
        Me.btn_copy.Name = "btn_copy"
        Me.btn_copy.Size = New System.Drawing.Size(80, 22)
        Me.btn_copy.TabIndex = 15
        Me.btn_copy.Text = "Copy"
        Me.btn_copy.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(894, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Search . . ."
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(953, 1)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(200, 20)
        Me.txt_search.TabIndex = 13
        '
        'DataGrid_input
        '
        Me.DataGrid_input.AllowUserToAddRows = False
        Me.DataGrid_input.AllowUserToDeleteRows = False
        Me.DataGrid_input.AllowUserToOrderColumns = True
        Me.DataGrid_input.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_input.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGrid_input.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGrid_input.Location = New System.Drawing.Point(0, 22)
        Me.DataGrid_input.Name = "DataGrid_input"
        Me.DataGrid_input.Size = New System.Drawing.Size(1153, 306)
        Me.DataGrid_input.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "Group"
        Me.Column1.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(340, 0)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(80, 22)
        Me.btn_print.TabIndex = 18
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_to_excel
        '
        Me.btn_to_excel.Location = New System.Drawing.Point(420, 0)
        Me.btn_to_excel.Name = "btn_to_excel"
        Me.btn_to_excel.Size = New System.Drawing.Size(75, 22)
        Me.btn_to_excel.TabIndex = 19
        Me.btn_to_excel.Text = "excel"
        Me.btn_to_excel.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(642, 142)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(406, 130)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'btn_to_cal
        '
        Me.btn_to_cal.Location = New System.Drawing.Point(803, 0)
        Me.btn_to_cal.Name = "btn_to_cal"
        Me.btn_to_cal.Size = New System.Drawing.Size(75, 22)
        Me.btn_to_cal.TabIndex = 21
        Me.btn_to_cal.Text = "Calculate"
        Me.btn_to_cal.UseVisualStyleBackColor = True
        '
        'data_input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1155, 328)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_to_cal)
        Me.Controls.Add(Me.btn_to_excel)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_csv)
        Me.Controls.Add(Me.btn_excel)
        Me.Controls.Add(Me.btn_copy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.DataGrid_input)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "data_input"
        Me.Text = "data_input"
        CType(Me.DataGrid_input, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_csv As Button
    Friend WithEvents btn_excel As Button
    Friend WithEvents btn_copy As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents DataGrid_input As DataGridView
    Friend WithEvents btn_print As Button
    Friend WithEvents btn_to_excel As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents btn_to_cal As Button
    Friend WithEvents Column1 As DataGridViewComboBoxColumn
End Class
