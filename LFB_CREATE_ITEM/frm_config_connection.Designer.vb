<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_config_connection
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
        Me.txt_SV = New System.Windows.Forms.TextBox()
        Me.txt_UA = New System.Windows.Forms.TextBox()
        Me.txt_PW = New System.Windows.Forms.TextBox()
        Me.txt_DB = New System.Windows.Forms.TextBox()
        Me.btn_view_password = New System.Windows.Forms.Button()
        Me.btn_save_connection = New System.Windows.Forms.Button()
        Me.btn_check_connection = New System.Windows.Forms.Button()
        Me.gb_main = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gb_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_SV
        '
        Me.txt_SV.Font = New System.Drawing.Font("Browallia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_SV.Location = New System.Drawing.Point(157, 33)
        Me.txt_SV.Name = "txt_SV"
        Me.txt_SV.Size = New System.Drawing.Size(226, 34)
        Me.txt_SV.TabIndex = 2
        '
        'txt_UA
        '
        Me.txt_UA.Font = New System.Drawing.Font("Browallia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_UA.Location = New System.Drawing.Point(157, 73)
        Me.txt_UA.Name = "txt_UA"
        Me.txt_UA.Size = New System.Drawing.Size(226, 34)
        Me.txt_UA.TabIndex = 3
        '
        'txt_PW
        '
        Me.txt_PW.Font = New System.Drawing.Font("Browallia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_PW.Location = New System.Drawing.Point(157, 113)
        Me.txt_PW.Name = "txt_PW"
        Me.txt_PW.Size = New System.Drawing.Size(226, 34)
        Me.txt_PW.TabIndex = 4
        '
        'txt_DB
        '
        Me.txt_DB.Font = New System.Drawing.Font("Browallia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_DB.Location = New System.Drawing.Point(157, 153)
        Me.txt_DB.Name = "txt_DB"
        Me.txt_DB.Size = New System.Drawing.Size(226, 34)
        Me.txt_DB.TabIndex = 5
        '
        'btn_view_password
        '
        Me.btn_view_password.Font = New System.Drawing.Font("Browallia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_view_password.Location = New System.Drawing.Point(389, 114)
        Me.btn_view_password.Name = "btn_view_password"
        Me.btn_view_password.Size = New System.Drawing.Size(30, 30)
        Me.btn_view_password.TabIndex = 8
        Me.btn_view_password.UseVisualStyleBackColor = True
        '
        'btn_save_connection
        '
        Me.btn_save_connection.Font = New System.Drawing.Font("Browallia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save_connection.Location = New System.Drawing.Point(157, 268)
        Me.btn_save_connection.Name = "btn_save_connection"
        Me.btn_save_connection.Size = New System.Drawing.Size(226, 35)
        Me.btn_save_connection.TabIndex = 7
        Me.btn_save_connection.Text = "Save"
        Me.btn_save_connection.UseVisualStyleBackColor = True
        '
        'btn_check_connection
        '
        Me.btn_check_connection.Font = New System.Drawing.Font("Browallia New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_check_connection.Location = New System.Drawing.Point(157, 193)
        Me.btn_check_connection.Name = "btn_check_connection"
        Me.btn_check_connection.Size = New System.Drawing.Size(226, 27)
        Me.btn_check_connection.TabIndex = 6
        Me.btn_check_connection.Text = "Test Connect"
        Me.btn_check_connection.UseVisualStyleBackColor = True
        '
        'gb_main
        '
        Me.gb_main.Controls.Add(Me.Label4)
        Me.gb_main.Controls.Add(Me.Label3)
        Me.gb_main.Controls.Add(Me.Label2)
        Me.gb_main.Controls.Add(Me.Label1)
        Me.gb_main.Controls.Add(Me.btn_view_password)
        Me.gb_main.Controls.Add(Me.btn_check_connection)
        Me.gb_main.Controls.Add(Me.txt_SV)
        Me.gb_main.Controls.Add(Me.btn_save_connection)
        Me.gb_main.Controls.Add(Me.txt_UA)
        Me.gb_main.Controls.Add(Me.txt_PW)
        Me.gb_main.Controls.Add(Me.txt_DB)
        Me.gb_main.Font = New System.Drawing.Font("Browallia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.gb_main.Location = New System.Drawing.Point(12, 12)
        Me.gb_main.Name = "gb_main"
        Me.gb_main.Size = New System.Drawing.Size(460, 337)
        Me.gb_main.TabIndex = 1
        Me.gb_main.TabStop = False
        Me.gb_main.Text = "  C o n n e c t i o n  "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Browallia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SERVER : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Browallia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 26)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Username : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Browallia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 26)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Browallia New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 26)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Database : "
        '
        'frm_config_connection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.gb_main)
        Me.Name = "frm_config_connection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_config_connection"
        Me.gb_main.ResumeLayout(False)
        Me.gb_main.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_SV As TextBox
    Friend WithEvents txt_UA As TextBox
    Friend WithEvents txt_PW As TextBox
    Friend WithEvents txt_DB As TextBox
    Friend WithEvents btn_view_password As Button
    Friend WithEvents btn_save_connection As Button
    Friend WithEvents btn_check_connection As Button
    Friend WithEvents gb_main As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
