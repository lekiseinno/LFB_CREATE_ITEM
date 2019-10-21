Imports System.Data.SqlClient
Imports System.IO

Public Class frm_config_connection
    Public config_fileserver As String
    Private Sub frm_config_connection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadfile()

        txt_PW.PasswordChar = "•"
    End Sub


    Sub loadfile()
        If GetVersion() = "Not Published" Then
            config_fileserver = (Application.StartupPath).Substring(0, (Application.StartupPath).Length - 10) + fileconn
        Else
            config_fileserver = (Application.StartupPath) & fileconn
        End If

        Dim SV As String
        Dim UA As String
        Dim PW As String
        Dim DB As String

        If File.Exists(config_fileserver) Then
            Dim line() As String = IO.File.ReadAllLines(config_fileserver)
            If line.LongLength = 4 Then
                SV = line(0)
                UA = line(1)
                PW = line(2)
                DB = line(3)
                txt_SV.Text = SV
                txt_UA.Text = UA
                txt_PW.Text = PW
                txt_DB.Text = DB
            End If
        End If
    End Sub


    Private Sub btn_view_password_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_view_password.MouseDown
        txt_PW.PasswordChar = ""
    End Sub


    Private Sub btn_view_password_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_view_password.MouseUp
        txt_PW.PasswordChar = "•"
    End Sub

    Private Sub btn_check_connection_Click(sender As Object, e As EventArgs) Handles btn_check_connection.Click
        Try
            Dim test_connectionstring = "Data Source=" & txt_SV.Text & ";Initial Catalog=" & txt_DB.Text & ";Persist Security Info=True;User ID=" & txt_UA.Text & ";Password=" & txt_PW.Text
            Dim test_connection As SqlConnection = New SqlConnection(test_connectionstring)
            test_connection.Open()

            Dim ms As String

            If test_connection.State = ConnectionState.Open Then
                ms = "Connection to server : success"
            End If
            test_connection.Close()

            MsgBox(ms)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btn_save_connection_Click(sender As Object, e As EventArgs) Handles btn_save_connection.Click
        Try
            Dim objStreamWriter As StreamWriter = New StreamWriter(config_fileserver)
            objStreamWriter.WriteLine(txt_SV.Text)
            objStreamWriter.WriteLine(txt_UA.Text)
            objStreamWriter.WriteLine(txt_PW.Text)
            objStreamWriter.WriteLine(txt_DB.Text)
            objStreamWriter.Close()
            MsgBox("Save Success")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class