Public Class setup_master
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionToolStripMenuItem.Click
        MsgBox(setup_conf.chk_connection())
    End Sub

    Private Sub setup_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lb_connection_file.Text = fileserver
    End Sub

End Class
