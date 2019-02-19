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
        CType(Me.DataGrid_Cus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid_Cus
        '
        Me.DataGrid_Cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_Cus.Location = New System.Drawing.Point(113, 99)
        Me.DataGrid_Cus.Name = "DataGrid_Cus"
        Me.DataGrid_Cus.Size = New System.Drawing.Size(240, 150)
        Me.DataGrid_Cus.TabIndex = 0
        '
        'data_cus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1155, 400)
        Me.Controls.Add(Me.DataGrid_Cus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "data_cus"
        Me.Text = "frm_cus"
        CType(Me.DataGrid_Cus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGrid_Cus As DataGridView
End Class
