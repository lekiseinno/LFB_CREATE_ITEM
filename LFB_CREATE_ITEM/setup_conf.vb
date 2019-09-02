Imports System.Data.SqlClient
Imports System.IO

Imports Excel = Microsoft.Office.Interop.Excel

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


        Dim SV As String = "192.168.110.125"
        Dim UA As String = "innovation"
        Dim PW As String = "Inno20i9"
        Dim DB As String = "LFB_ITEM$"



        'Dim SV As String = "127.0.0.1"
        'Dim UA As String = "sa"
        'Dim PW As String = "Passw0rd@1"
        'Dim DB As String = "LFB_ITEM$"

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






            Cursor.Current = Cursors.WaitCursor

            If ((datagridname.Columns.Count = 0) Or (datagridname.Rows.Count = 0)) Then
                Exit Sub
            End If

            Dim dset As New DataSet

            dset.Tables.Add()
            For i As Integer = 0 To datagridname.ColumnCount - 1
                ' ok
                dset.Tables(0).Columns.Add(datagridname.Columns(i).Name)
            Next

            Dim dr1 As DataRow

            For i As Integer = 0 To datagridname.RowCount - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To datagridname.Columns.Count - 1
                    dr1(j) = datagridname.Rows(i).Cells(j).Value
                Next
                dset.Tables(0).Rows.Add(dr1)
            Next

            Dim excel As New Microsoft.Office.Interop.Excel.Application
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

            wBook = excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            Dim dt As System.Data.DataTable = dset.Tables(0)
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow

            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0











            For Each dc In dt.Columns
                'colIndex = colIndex + 0
                'excel.Cells(1, colIndex) = dc.ColumnName
            Next




            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    excel.Cells(rowIndex + 0, colIndex) = dr(dc.ColumnName)
                Next
            Next





            With wSheet.Range("A1", "AZ1")
                '.Font.Bold = True
                .HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
            End With

            With wSheet.Range("A1", "AZ1")
                .Font.Size = 10
            End With

            wSheet.Columns.AutoFit()

            Dim blnFileOpen As Boolean = False

            Try
                Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(filename)
                fileTemp.Close()
            Catch ex As Exception
                blnFileOpen = False
            End Try

            If System.IO.File.Exists(filename) Then
                System.IO.File.Delete(filename)
            End If

            wBook.SaveAs(filename)
            excel.Quit()
            releaseObject(excel)
            releaseObject(wBook)
            releaseObject(wSheet)


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

        Dim nowdate = Now.ToString("yyyy-MM-dd")
        Dim nowtime = Now.ToString("HHmm")


        Dim filePath = "D:\create_item\" + nowdate + "\" + nowtime + "_code.txt"

        Using writer As New System.IO.StreamWriter(filePath)
            For row As Integer = 0 To data_excelfile.DataGrid_codetxt.RowCount - 1
                For col As Integer = 0 To data_excelfile.DataGrid_codetxt.ColumnCount - 1
                    writer.WriteLine(data_excelfile.DataGrid_codetxt.Rows(row).Cells(col).Value)
                Next
            Next
        End Using
    End Sub


End Module
