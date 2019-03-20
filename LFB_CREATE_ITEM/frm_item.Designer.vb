<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_item
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vat_selected = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_width = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_long = New System.Windows.Forms.TextBox()
        Me.txt_itemcode = New System.Windows.Forms.TextBox()
        Me.M1 = New System.Windows.Forms.ComboBox()
        Me.M2 = New System.Windows.Forms.ComboBox()
        Me.M3 = New System.Windows.Forms.ComboBox()
        Me.M4 = New System.Windows.Forms.ComboBox()
        Me.M5 = New System.Windows.Forms.ComboBox()
        Me.lon_selected = New System.Windows.Forms.ComboBox()
        Me.btn_add_datagrid_item = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "VAT . . . . . . . . . . ."
        '
        'vat_selected
        '
        Me.vat_selected.FormattingEnabled = True
        Me.vat_selected.Items.AddRange(New Object() {"VAT", "NO VAT"})
        Me.vat_selected.Location = New System.Drawing.Point(112, 4)
        Me.vat_selected.Name = "vat_selected"
        Me.vat_selected.Size = New System.Drawing.Size(128, 21)
        Me.vat_selected.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "M1. . . . . . . . . . . . "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "ลอน . . . . . . . . . . . "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(276, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "M2. . . . . . . . . . . . "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "M3. . . . . . . . . . . . "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "M4. . . . . . . . . . . . "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "M5. . . . . . . . . . . . "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(633, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "กว้าง . . . . . . . . . . . . "
        '
        'txt_width
        '
        Me.txt_width.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_width.Location = New System.Drawing.Point(739, 34)
        Me.txt_width.MaxLength = 4
        Me.txt_width.Name = "txt_width"
        Me.txt_width.Size = New System.Drawing.Size(128, 22)
        Me.txt_width.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(633, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "ยาว . . . . . . . . . . . . "
        '
        'txt_long
        '
        Me.txt_long.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_long.Location = New System.Drawing.Point(739, 60)
        Me.txt_long.MaxLength = 4
        Me.txt_long.Name = "txt_long"
        Me.txt_long.Size = New System.Drawing.Size(128, 22)
        Me.txt_long.TabIndex = 38
        '
        'txt_itemcode
        '
        Me.txt_itemcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_itemcode.Location = New System.Drawing.Point(12, 172)
        Me.txt_itemcode.Name = "txt_itemcode"
        Me.txt_itemcode.ReadOnly = True
        Me.txt_itemcode.Size = New System.Drawing.Size(1043, 49)
        Me.txt_itemcode.TabIndex = 40
        Me.txt_itemcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'M1
        '
        Me.M1.FormattingEnabled = True
        Me.M1.Location = New System.Drawing.Point(376, 112)
        Me.M1.Name = "M1"
        Me.M1.Size = New System.Drawing.Size(128, 21)
        Me.M1.TabIndex = 41
        '
        'M2
        '
        Me.M2.FormattingEnabled = True
        Me.M2.Location = New System.Drawing.Point(376, 87)
        Me.M2.Name = "M2"
        Me.M2.Size = New System.Drawing.Size(128, 21)
        Me.M2.TabIndex = 42
        '
        'M3
        '
        Me.M3.FormattingEnabled = True
        Me.M3.Location = New System.Drawing.Point(376, 62)
        Me.M3.Name = "M3"
        Me.M3.Size = New System.Drawing.Size(128, 21)
        Me.M3.TabIndex = 43
        '
        'M4
        '
        Me.M4.FormattingEnabled = True
        Me.M4.Location = New System.Drawing.Point(376, 37)
        Me.M4.Name = "M4"
        Me.M4.Size = New System.Drawing.Size(128, 21)
        Me.M4.TabIndex = 44
        '
        'M5
        '
        Me.M5.FormattingEnabled = True
        Me.M5.Location = New System.Drawing.Point(376, 12)
        Me.M5.Name = "M5"
        Me.M5.Size = New System.Drawing.Size(128, 21)
        Me.M5.TabIndex = 45
        '
        'lon_selected
        '
        Me.lon_selected.FormattingEnabled = True
        Me.lon_selected.Items.AddRange(New Object() {"VAT", "NO VAT"})
        Me.lon_selected.Location = New System.Drawing.Point(112, 29)
        Me.lon_selected.Name = "lon_selected"
        Me.lon_selected.Size = New System.Drawing.Size(128, 21)
        Me.lon_selected.TabIndex = 46
        '
        'btn_add_datagrid_item
        '
        Me.btn_add_datagrid_item.Location = New System.Drawing.Point(1061, 165)
        Me.btn_add_datagrid_item.Name = "btn_add_datagrid_item"
        Me.btn_add_datagrid_item.Size = New System.Drawing.Size(80, 80)
        Me.btn_add_datagrid_item.TabIndex = 47
        Me.btn_add_datagrid_item.Text = "Button1"
        Me.btn_add_datagrid_item.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(1066, 7)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 48
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'frm_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1153, 257)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_add_datagrid_item)
        Me.Controls.Add(Me.lon_selected)
        Me.Controls.Add(Me.M5)
        Me.Controls.Add(Me.M4)
        Me.Controls.Add(Me.M3)
        Me.Controls.Add(Me.M2)
        Me.Controls.Add(Me.M1)
        Me.Controls.Add(Me.txt_itemcode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_long)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_width)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vat_selected)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_item"
        Me.Text = "frm_item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents vat_selected As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_width As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_long As TextBox
    Friend WithEvents txt_itemcode As TextBox
    Friend WithEvents M1 As ComboBox
    Friend WithEvents M2 As ComboBox
    Friend WithEvents M3 As ComboBox
    Friend WithEvents M4 As ComboBox
    Friend WithEvents M5 As ComboBox
    Friend WithEvents lon_selected As ComboBox
    Friend WithEvents btn_add_datagrid_item As Button
    Friend WithEvents btn_clear As Button
End Class
