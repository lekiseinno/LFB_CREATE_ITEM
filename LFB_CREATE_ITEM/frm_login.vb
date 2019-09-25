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

        lb_version.Text = "Versions. " & GetVersion()
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
            ''dbsql = New SqlConnection("Database=PAIWAN_CAFE;Data Source=RTII-NOTEBOOK;User Id=sa;Password=034413218")

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
End Class