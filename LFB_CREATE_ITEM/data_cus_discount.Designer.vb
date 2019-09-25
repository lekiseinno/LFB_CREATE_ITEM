<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_cus_discount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_csv = New System.Windows.Forms.Button()
        Me.btn_excel = New System.Windows.Forms.Button()
        Me.btn_copy = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.DataGrid_Cus_discount = New System.Windows.Forms.DataGridView()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        CType(Me.DataGrid_Cus_discount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_csv
        '
        Me.btn_csv.Location = New System.Drawing.Point(209, 1)
        Me.btn_csv.Name = "btn_csv"
        Me.btn_csv.Size = New System.Drawing.Size(130, 22)
        Me.btn_csv.TabIndex = 32
        Me.btn_csv.Text = "Export Excel (*.csv)"
        Me.btn_csv.UseVisualStyleBackColor = True
        '
        'btn_excel
        '
        Me.btn_excel.Location = New System.Drawing.Point(80, 1)
        Me.btn_excel.Name = "btn_excel"
        Me.btn_excel.Size = New System.Drawing.Size(130, 22)
        Me.btn_excel.TabIndex = 31
        Me.btn_excel.Text = "Export Excel (*.xls)"
        Me.btn_excel.UseVisualStyleBackColor = True
        '
        'btn_copy
        '
        Me.btn_copy.Location = New System.Drawing.Point(1, 1)
        Me.btn_copy.Name = "btn_copy"
        Me.btn_copy.Size = New System.Drawing.Size(80, 22)
        Me.btn_copy.TabIndex = 30
        Me.btn_copy.Text = "Copy"
        Me.btn_copy.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(894, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Search . . ."
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(953, 2)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(200, 20)
        Me.txt_search.TabIndex = 28
        '
        'DataGrid_Cus_discount
        '
        Me.DataGrid_Cus_discount.AllowUserToAddRows = False
        Me.DataGrid_Cus_discount.AllowUserToDeleteRows = False
        Me.DataGrid_Cus_discount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Cus_discount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGrid_Cus_discount.Location = New System.Drawing.Point(1, 23)
        Me.DataGrid_Cus_discount.Name = "DataGrid_Cus_discount"
        Me.DataGrid_Cus_discount.ReadOnly = True
        Me.DataGrid_Cus_discount.Size = New System.Drawing.Size(1152, 280)
        Me.DataGrid_Cus_discount.TabIndex = 27
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(1053, 304)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(100, 23)
        Me.btn_clear.TabIndex = 33
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(953, 304)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(100, 23)
        Me.btn_save.TabIndex = 34
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'data_cus_discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1155, 328)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_csv)
        Me.Controls.Add(Me.btn_excel)
        Me.Controls.Add(Me.btn_copy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.DataGrid_Cus_discount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "data_cus_discount"
        Me.Text = "data_cus_discount"
        CType(Me.DataGrid_Cus_discount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_csv As Button
    Friend WithEvents btn_excel As Button
    Friend WithEvents btn_copy As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents DataGrid_Cus_discount As DataGridView
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_save As Button
End Class
