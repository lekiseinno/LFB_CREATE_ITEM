<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cus_discount
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
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.DataGrid_Cus_discount = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGrid_Cus_discount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(952, 1)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(200, 20)
        Me.txt_search.TabIndex = 22
        '
        'DataGrid_Cus_discount
        '
        Me.DataGrid_Cus_discount.AllowUserToAddRows = False
        Me.DataGrid_Cus_discount.AllowUserToDeleteRows = False
        Me.DataGrid_Cus_discount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Cus_discount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGrid_Cus_discount.Location = New System.Drawing.Point(0, 22)
        Me.DataGrid_Cus_discount.Name = "DataGrid_Cus_discount"
        Me.DataGrid_Cus_discount.ReadOnly = True
        Me.DataGrid_Cus_discount.Size = New System.Drawing.Size(1152, 304)
        Me.DataGrid_Cus_discount.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(893, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Search . . ."
        '
        'frm_cus_discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 326)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.DataGrid_Cus_discount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cus_discount"
        Me.Text = "frm_cus_discount"
        CType(Me.DataGrid_Cus_discount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_search As TextBox
    Friend WithEvents DataGrid_Cus_discount As DataGridView
    Friend WithEvents Label1 As Label
End Class
