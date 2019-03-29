Imports System.Data.SqlClient
Imports System.IO

Public Module setup_conf

    Public fileconn As String = "\Resources\conn.ini"

    'For Dev
    Public fileserver As String = (Application.StartupPath).Substring(0, (Application.StartupPath).Length - 10) + fileconn

    'For Client
    'Public fileserver As String = (Application.StartupPath) & fineconf
    'Public fileserver As String = My.Application.Info.DirectoryPath & fineconf

    Public file_resource1 As String = (Application.StartupPath) & fileconn
    Public file_resource2 As String = My.Application.Info.DirectoryPath & fileconn

    Public connection As SqlConnection = New SqlConnection(get_connectionstring)

    Public Function get_connectionstring() As String
        Dim connectionstring As String = ""

        'Dim SV As String
        'Dim UA As String
        'Dim PW As String
        'Dim DB As String

        'If File.Exists(fileserver) Then
        '    Dim line() As String = IO.File.ReadAllLines(fileserver)
        '    If line.LongLength = 4 Then
        '        SV = line(0)
        '        UA = line(1)
        '        PW = line(2)
        '        DB = line(3)
        '        connectionstring = "Data Source=" & SV & ";Initial Catalog=" & DB & ";Persist Security Info=True;User ID=" & UA & ";Password=" & PW
        '    Else
        '        Dim objStreamWriter As StreamWriter = New StreamWriter(fileserver)
        '        objStreamWriter.WriteLine("1")
        '        objStreamWriter.WriteLine("2")
        '        objStreamWriter.WriteLine("3")
        '        objStreamWriter.WriteLine("4")
        '        objStreamWriter.Close()
        '    End If
        'End If


        'Dim SV As String = "192.168.110.125"
        'Dim UA As String = "innovation"
        'Dim PW As String = "Inno20i9"
        'Dim DB As String = "LFB_ITEM$"



        Dim SV As String = "127.0.0.1"
        Dim UA As String = "sa"
        Dim PW As String = "Passw0rd@1"
        Dim DB As String = "LFB_ITEM$"

        connectionstring = "Data Source=" & SV & ";Initial Catalog=" & DB & ";Persist Security Info=True;User ID=" & UA & ";Password=" & PW

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



    Sub gen_excel(datagridname, filename)

        Try

            'Me.Cursor = Cursors.WaitCursor

            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkSheet.Columns.AutoFit()

            For i = 0 To datagridname.RowCount - 2
                For j = 0 To datagridname.ColumnCount - 1
                    For k As Integer = 1 To datagridname.Columns.Count
                        xlWorkSheet.Cells(1, k) = datagridname.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = datagridname(j, i).Value.ToString()
                    Next
                Next
            Next

            xlWorkSheet.SaveAs((filename))
            xlWorkBook.Close()
            xlApp.Quit()


            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub



    Sub gen_txt()
        Dim nowstring = Now.ToString("yyyyMMdd_HHmm")
        Dim filePath = "D:\create_item\" + nowstring + "_code.txt"

        Using writer As New System.IO.StreamWriter(filePath)
            For row As Integer = 0 To data_excelfile.DataGrid_codetxt.RowCount - 2
                For col As Integer = 0 To data_excelfile.DataGrid_codetxt.ColumnCount - 1
                    writer.WriteLine(data_excelfile.DataGrid_codetxt.Rows(row).Cells(col).Value)
                Next
            Next
        End Using
    End Sub

End Module
