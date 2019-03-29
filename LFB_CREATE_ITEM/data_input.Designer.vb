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
        Me.btn_csv = New System.Windows.Forms.Button()
        Me.btn_excel = New System.Windows.Forms.Button()
        Me.btn_copy = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.DataGrid_input = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_to_excel = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.DataGrid_input, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_csv
        '
        Me.btn_csv.Location = New System.Drawing.Point(208, 0)
        Me.btn_csv.Name = "btn_csv"
        Me.btn_csv.Size = New System.Drawing.Size(130, 22)
        Me.btn_csv.TabIndex = 17
        Me.btn_csv.Text = "Export Excel (*.csv)"
        Me.btn_csv.UseVisualStyleBackColor = True
        '
        'btn_excel
        '
        Me.btn_excel.Location = New System.Drawing.Point(79, 0)
        Me.btn_excel.Name = "btn_excel"
        Me.btn_excel.Size = New System.Drawing.Size(130, 22)
        Me.btn_excel.TabIndex = 16
        Me.btn_excel.Text = "Export Excel (*.xlsx)"
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
        Me.DataGrid_input.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_input.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGrid_input.Location = New System.Drawing.Point(0, 22)
        Me.DataGrid_input.Name = "DataGrid_input"
        Me.DataGrid_input.Size = New System.Drawing.Size(1153, 378)
        Me.DataGrid_input.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(337, 0)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(80, 22)
        Me.btn_print.TabIndex = 18
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_to_excel
        '
        Me.btn_to_excel.Location = New System.Drawing.Point(797, 0)
        Me.btn_to_excel.Name = "btn_to_excel"
        Me.btn_to_excel.Size = New System.Drawing.Size(75, 22)
        Me.btn_to_excel.TabIndex = 19
        Me.btn_to_excel.Text = "excel"
        Me.btn_to_excel.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'data_input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1155, 400)
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
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As DataGridViewCheckBoxColumn
    Friend WithEvents btn_print As Button
    Friend WithEvents btn_to_excel As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
