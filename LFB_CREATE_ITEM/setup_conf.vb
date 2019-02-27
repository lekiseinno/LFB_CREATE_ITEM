Imports System.Data.SqlClient
Imports System.IO

Public Module setup_conf

    'Public fileconn As String = "\Resources\conn.ini"

    Public fileconn As String = My.Resources.conn

    'For Dev
    Public fileserver As String = (Application.StartupPath).Substring(0, (Application.StartupPath).Length - 10) + fileconn

    'For Client
    'Public fileserver As String = (Application.StartupPath) & fileconn
    'Public fileserver As String = My.Application.Info.DirectoryPath & fileconn

    Public connection As SqlConnection = New SqlConnection(get_connectionstring)

    Public Function get_connectionstring() As String

        Dim connectionstring As String = ""

        Dim SV As String
        Dim UA As String
        Dim PW As String
        Dim DB As String

        If File.Exists(fileserver) Then
            Dim line() As String = IO.File.ReadAllLines(fileserver)
            If line.LongLength = 4 Then
                SV = line(0)
                UA = line(1)
                PW = line(2)
                DB = line(3)
                connectionstring = "Data Source=" & SV & ";Initial Catalog=" & DB & ";Persist Security Info=True;User ID=" & UA & ";Password=" & PW

            Else
                Dim objStreamWriter As StreamWriter = New StreamWriter(fileserver)
                objStreamWriter.WriteLine("1")
                objStreamWriter.WriteLine("2")
                objStreamWriter.WriteLine("3")
                objStreamWriter.WriteLine("4")
                objStreamWriter.Close()
            End If
        End If
        Return connectionstring

    End Function

    Function chk_connection()
        
        Dim MS As String = ""
        connection.Open()
        If connection.State = ConnectionState.Open Then
            MS = "Connection to server : success"
        ElseIf connection.State = ConnectionState.Closed Then
            MS = "Your database connection is closed"
        Else
            MS = "Your database connection state: " & connection.State.ToString
        End If
        connection.Close()
        Return MS
    End Function
End Module
