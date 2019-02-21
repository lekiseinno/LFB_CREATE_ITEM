<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_cus
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
        Me.DataGrid_Cus = New System.Windows.Forms.DataGridView()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_copy = New System.Windows.Forms.Button()
        Me.btn_excel = New System.Windows.Forms.Button()
        CType(Me.DataGrid_Cus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid_Cus
        '
        Me.DataGrid_Cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Cus.Location = New System.Drawing.Point(0, 22)
        Me.DataGrid_Cus.Name = "DataGrid_Cus"
        Me.DataGrid_Cus.Size = New System.Drawing.Size(1153, 378)
        Me.DataGrid_Cus.TabIndex = 0
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(953, 1)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(200, 20)
        Me.txt_search.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(894, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search . . ."
        '
        'btn_copy
        '
        Me.btn_copy.Location = New System.Drawing.Point(0, 0)
        Me.btn_copy.Name = "btn_copy"
        Me.btn_copy.Size = New System.Drawing.Size(100, 22)
        Me.btn_copy.TabIndex = 3
        Me.btn_copy.Text = "Copy"
        Me.btn_copy.UseVisualStyleBackColor = True
        '
        'btn_excel
        '
        Me.btn_excel.Location = New System.Drawing.Point(99, 0)
        Me.btn_excel.Name = "btn_excel"
        Me.btn_excel.Size = New System.Drawing.Size(100, 22)
        Me.btn_excel.TabIndex = 4
        Me.btn_excel.Text = "Export Excel"
        Me.btn_excel.UseVisualStyleBackColor = True
        '
        'data_cus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1155, 400)
        Me.Controls.Add(Me.btn_excel)
        Me.Controls.Add(Me.btn_copy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.DataGrid_Cus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "data_cus"
        Me.Text = "frm_cus"
        CType(Me.DataGrid_Cus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGrid_Cus As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_copy As Button
    Friend WithEvents btn_excel As Button
End Class
