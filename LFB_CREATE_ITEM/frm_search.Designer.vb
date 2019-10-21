<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_search))
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.data_search_cus = New System.Windows.Forms.DataGridView()
        CType(Me.data_search_cus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_search.Location = New System.Drawing.Point(0, 0)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(484, 26)
        Me.txt_search.TabIndex = 0
        '
        'data_search_cus
        '
        Me.data_search_cus.AllowUserToAddRows = False
        Me.data_search_cus.AllowUserToDeleteRows = False
        Me.data_search_cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_search_cus.Location = New System.Drawing.Point(0, 26)
        Me.data_search_cus.Name = "data_search_cus"
        Me.data_search_cus.ReadOnly = True
        Me.data_search_cus.RowHeadersVisible = False
        Me.data_search_cus.Size = New System.Drawing.Size(484, 295)
        Me.data_search_cus.TabIndex = 1
        '
        'frm_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 321)
        Me.Controls.Add(Me.data_search_cus)
        Me.Controls.Add(Me.txt_search)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: Search :: "
        CType(Me.data_search_cus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_search As TextBox
    Friend WithEvents data_search_cus As DataGridView
End Class
