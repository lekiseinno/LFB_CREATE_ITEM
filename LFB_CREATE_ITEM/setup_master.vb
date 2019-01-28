Public Class setup_master
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionToolStripMenuItem.Click
        MsgBox(setup_conf.chk_connection())
    End Sub

    Private Sub setup_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_footers()

        loader()


    End Sub

    Private Sub timer_datenow_Tick(sender As Object, e As EventArgs) Handles timer_datenow.Tick
        lb_datenow.Text = Now.ToString("dd-MM-yyyy HH:mm:ss")
    End Sub

    Sub set_footers()

        lb_computerName.Text = "Computername : " & Net.Dns.GetHostName()

        lb_IPAddress.Text = ""
        For i As Integer = 0 To Net.Dns.GetHostByName(Net.Dns.GetHostName()).AddressList().Length - 1
            lb_IPAddress.Text &= " IP" & i & ": " & Net.Dns.GetHostByName(Net.Dns.GetHostName()).AddressList(i).ToString() & "  |  "
        Next
    End Sub



    Sub loader()
        Dim min As Integer = 0               ' Minimum value for progress rangePrivate max As Integer = 100             ' Maximum value for progress range
        Dim val As Integer = 0               ' Current progress
        Dim barColor As Color = Color.Blue   ' Color of progress meter

        Progress_system.Value = Progress_system.Value + 100


    End Sub

End Class
