Public Class setup_master
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionToolStripMenuItem.Click
        MsgBox(setup_conf.chk_connection())
    End Sub

    Private Sub setup_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_footers()
        cmds()
    End Sub

    Private Sub timer_datenow_Tick(sender As Object, e As EventArgs) Handles timer_datenow.Tick
        lb_datenow.Text = Now.ToString("dd-MM-yyyy HH:mm:ss")
    End Sub


    Sub set_footers()
        lb_computerName.Text = "Computername : " & Net.Dns.GetHostName()
        'array ipaddress
        lb_IPAddress.Text = "IPV4 : " & Net.Dns.GetHostByName(Net.Dns.GetHostName()).AddressList(3).ToString()
    End Sub


    Sub get_IP()

        Dim strHostName As String

        Dim strIPAddress As String



        strHostName = Net.Dns.GetHostName()

        strIPAddress = Net.Dns.GetHostByName(strHostName).AddressList(3).ToString()


        MessageBox.Show("Host Name: " & strHostName & "; IP Address: " & strIPAddress)

    End Sub




    Sub cmds()
        Dim CMDprocess As New Process
        Dim StartInfo As New System.Diagnostics.ProcessStartInfo
        StartInfo.FileName = "cmd"
        StartInfo.CreateNoWindow = True
        StartInfo.RedirectStandardInput = True
        StartInfo.RedirectStandardOutput = True
        StartInfo.UseShellExecute = False
        CMDprocess.StartInfo = StartInfo
        CMDprocess.Start()

        Dim SR As System.IO.StreamReader = CMDprocess.StandardOutput
        Dim SW As System.IO.StreamWriter = CMDprocess.StandardInput

        'SW.WriteLine("ping 8.8.8.8")

        'SW.WriteLine("exit")

        MsgBox(SR.ReadToEnd)

        SW.Close()
        SR.Close()


        ' Process.Start("cmd", "/c reg query HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\TeamViewer /v ClientID")
        ' Dim id = Process.Start("cmd", "/c reg query HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\TeamViewer /v ClientID").ToString()
        ' MsgBox(output)
    End Sub
End Class
