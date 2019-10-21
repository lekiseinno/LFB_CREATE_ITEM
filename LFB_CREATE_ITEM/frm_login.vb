Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.Reflection

Public Class frm_login
    Private Sub Btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub Btn_signin_Click(sender As Object, e As EventArgs) Handles btn_signin.Click
        get_login()
    End Sub

    Private Sub Frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Signin System :: v. " & GetVersion()

        get_versions.Text = "versions " & GetVersion() & " [ On Build ]"

        dev_path_resource.Text = setup_conf.fileconn
        dev_path_startup.Text = setup_conf.fileserver

        client_path_resource.Text = setup_conf.file_resource1
        client_path_startup.Text = setup_conf.file_resource2

        lb_OnClient.Enabled = False
        lb_OnDev.Enabled = False

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

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            get_login()
        End If
    End Sub


    Sub get_login()
        Dim dbsql As New SqlConnection
        Dim sql_1 As New SqlCommand
        Dim sql_read As SqlDataReader
        Dim result As String

        Try
            Dim user = txt_username.Text
            Dim pass = txt_password.Text

            connection.Open()

            sql_1 = connection.CreateCommand
            sql_1.CommandText = "SELECT COUNT(users_ID) FROM [LFB_ITEM$].[dbo].[LFB_USER$] WHERE users_username = '" + user + "' and users_password = '" + pass + "'"
            sql_1.ExecuteNonQuery()
            sql_read = sql_1.ExecuteReader()
            sql_read.Read()
            result = sql_read.GetInt32(0)
            If result = "0" Then 'Have Data in SqlDB
                MsgBox("Please check your username or password")
            Else
                MsgBox("Welcome : " + user)
                Me.Hide()
                frm_master.Show()
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ConnectDataBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectDataBaseToolStripMenuItem.Click
        frm_config_connection.Show()

    End Sub

    Private Sub ConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionToolStripMenuItem.Click
        MsgBox(chk_connection())
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
End Class