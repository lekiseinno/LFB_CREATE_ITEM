<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cus
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
        Me.btn_browse_file = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.txt_pathfile = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_browse_file
        '
        Me.btn_browse_file.Location = New System.Drawing.Point(1051, 231)
        Me.btn_browse_file.Name = "btn_browse_file"
        Me.btn_browse_file.Size = New System.Drawing.Size(100, 22)
        Me.btn_browse_file.TabIndex = 0
        Me.btn_browse_file.Text = "Browse..."
        Me.btn_browse_file.UseVisualStyleBackColor = True
        '
        'txt_pathfile
        '
        Me.txt_pathfile.Location = New System.Drawing.Point(908, 232)
        Me.txt_pathfile.Name = "txt_pathfile"
        Me.txt_pathfile.Size = New System.Drawing.Size(144, 20)
        Me.txt_pathfile.TabIndex = 1
        '
        'frm_cus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1155, 257)
        Me.Controls.Add(Me.txt_pathfile)
        Me.Controls.Add(Me.btn_browse_file)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cus"
        Me.Text = "frm_cus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_browse_file As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents txt_pathfile As TextBox
End Class
