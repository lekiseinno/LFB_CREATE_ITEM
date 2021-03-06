﻿Imports System.ComponentModel
Public Class frm_master
    Dim close_data()
    Dim close_frm()
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub ConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionToolStripMenuItem.Click
        MsgBox(chk_connection())
    End Sub
    Private Sub setup_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_versions.Text = "versions " & GetVersion() & " [ On Build ]"
        dev_path_resource.Text = setup_conf.fileconn
        dev_path_startup.Text = setup_conf.fileserver
        client_path_resource.Text = setup_conf.file_resource1
        client_path_startup.Text = setup_conf.file_resource2
        lb_OnClient.Enabled = False
        lb_OnDev.Enabled = False
        set_footers()
    End Sub
    Public Function GetVersion() As String
        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
            Dim ver As Version
            ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
            Return String.Format("{0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision)
        Else
            Return "Not Published"
        End If
    End Function
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
    Public Sub customize_datagrid(frm, x_frm)
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
    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click
        MessageBox.Show("Access denied", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Sub dev_path_startup_Click(sender As Object, e As EventArgs) Handles dev_path_startup.Click
        Process.Start("explorer.exe", (dev_path_startup.Text).Substring(0, (dev_path_startup.Text).Length - 8))
    End Sub
    Private Sub client_path_resource_Click(sender As Object, e As EventArgs) Handles client_path_resource.Click
        Process.Start("explorer.exe", (client_path_resource.Text).Substring(0, (client_path_resource.Text).Length - 8))
        MsgBox((client_path_resource.Text).Substring(0, (client_path_resource.Text).Length - 8))
    End Sub
    Private Sub client_path_startup_Click(sender As Object, e As EventArgs) Handles client_path_startup.Click
        Process.Start("explorer.exe", (client_path_startup.Text).Substring(0, (client_path_startup.Text).Length - 8))
        MsgBox((client_path_startup.Text).Substring(0, (client_path_startup.Text).Length - 8))
    End Sub
    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        close_data = {data_cus, data_excelfile, data_item, data_PL}
        close_frm = {frm_cus, frm_item, frm_PL}
        customize_datagrid(data_input, close_data)
        customize_frm(frm_input, close_frm)
    End Sub
    Private Sub btn_item_Click(sender As Object, e As EventArgs) Handles btn_item.Click
        close_data = {data_cus, data_excelfile, data_input, data_PL}
        close_frm = {frm_cus, frm_input, frm_PL}
        customize_datagrid(data_item, close_data)
        customize_frm(frm_item, close_frm)
    End Sub
    Private Sub btn_cus_Click(sender As Object, e As EventArgs) Handles btn_cus.Click
        close_data = {data_excelfile, data_input, data_item, data_PL}
        close_frm = {frm_input, frm_item, frm_PL}
        customize_datagrid(data_cus, close_data)
        customize_frm(frm_cus, close_frm)
    End Sub
    Private Sub btn_PL_Click(sender As Object, e As EventArgs) Handles btn_PL.Click
        close_data = {data_cus, data_excelfile, data_input, data_item}
        close_frm = {frm_cus, frm_input, frm_item}
        customize_datagrid(data_PL, close_data)
        customize_frm(frm_PL, close_frm)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_print_frm.Click
        frm_listdata.Show()
    End Sub
    Private Sub Btn_discount_Click(sender As Object, e As EventArgs) Handles btn_discount.Click
        close_data = {data_cus, data_excelfile, data_input, data_item, data_PL}
        close_frm = {frm_cus, frm_input, frm_item, frm_PL, frm_listdata}
        customize_datagrid(data_cus_discount, close_data)
        customize_frm(frm_cus_discount, close_frm)
    End Sub
    Private Sub frm_master_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_login.Close()
    End Sub
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles New_Document.Click
        frm_input.Close()
        data_input.Close()
        frm_input.TopLevel = False
        data_input.TopLevel = False
        frm_input.FormBorderStyle = FormBorderStyle.None
        data_input.FormBorderStyle = FormBorderStyle.None
        frm_input.Visible = False
        data_input.Visible = False
        panel_frm.Controls.Add(frm_input)
        panel_datagrid.Controls.Add(data_input)
        frm_input.Show()
        data_input.Show()
    End Sub
End Class
