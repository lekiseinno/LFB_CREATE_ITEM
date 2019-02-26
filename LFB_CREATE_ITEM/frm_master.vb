Public Class frm_master
    Dim close_data()
    Dim close_frm()
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionToolStripMenuItem.Click
        MsgBox(setup_conf.chk_connection())
    End Sub

    Private Sub setup_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_footers()
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

    Private Sub btn_PL_Click(sender As Object, e As EventArgs) Handles btn_PL.Click

        close_data = {data_cus, data_input}
        close_frm = {frm_cus, frm_input}

        customize_datagrid(data_PL, close_frm)
        customize_frm(frm_PL, close_frm)

    End Sub

    Private Sub btn_cus_Click(sender As Object, e As EventArgs) Handles btn_cus.Click

        close_data = {data_PL, data_input}
        close_frm = {frm_PL, frm_input}

        customize_datagrid(data_cus, close_data)
        customize_frm(frm_cus, close_frm)

    End Sub

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click

        close_data = {data_cus, data_PL}
        close_frm = {frm_cus, frm_PL}

        customize_datagrid(data_input, close_data)
        customize_frm(frm_input, close_frm)

    End Sub


    Sub customize_datagrid(frm, x_frm)

        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Visible = False
        panel_datagrid.Controls.Add(frm)

        frm.show()

        For i = 0 To x_frm.length - 1
            x_frm(i).hide()
        Next
    End Sub

    Sub customize_frm(frm, x_frm)

        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Visible = False
        panel_frm.Controls.Add(frm)

        frm.show()

        For i = 0 To x_frm.length - 1
            x_frm(i).hide()
        Next
    End Sub



End Class
