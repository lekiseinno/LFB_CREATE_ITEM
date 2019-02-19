﻿Public Class setup_master
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

        customize_datagrid(data_PL, data_cus)
        customize_frm(frm_PL, frm_cus)

    End Sub

    Private Sub btn_cus_Click(sender As Object, e As EventArgs) Handles btn_cus.Click

        customize_datagrid(data_cus, data_PL)
        customize_frm(frm_cus, frm_PL)

    End Sub


    Sub customize_datagrid(frm, x_frm)

        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Visible = False
        panel_datagrid.Controls.Add(frm)


        frm.show()
        x_frm.hide()

    End Sub

    Sub customize_frm(frm, x_frm)

        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Visible = False
        panel_frm.Controls.Add(frm)


        frm.show()
        x_frm.hide()

    End Sub



End Class
