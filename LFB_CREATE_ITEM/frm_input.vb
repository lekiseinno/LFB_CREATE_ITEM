Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System
Imports System.Windows.Forms
Imports GemBox.Spreadsheet
Imports GemBox.Spreadsheet.WinFormsUtilities
Public Class frm_input



    Private Sub btn_excel_Click(sender As Object, e As EventArgs)
        Try
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

            For i = 0 To data_cus.DataGrid_Cus.RowCount - 2
                For j = 0 To data_cus.DataGrid_Cus.ColumnCount - 1
                    For k As Integer = 1 To data_cus.DataGrid_Cus.Columns.Count
                        xlWorkSheet.Cells(1, k) = data_cus.DataGrid_Cus.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = data_cus.DataGrid_Cus(j, i).Value.ToString()
                    Next
                Next
            Next

            xlWorkSheet.SaveAs("D:\vbexcel.xlsx")
            xlWorkBook.Close()
            xlApp.Quit()

            Me.Cursor = Cursors.WaitCursor

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            MsgBox("You can find the file D:\vbexcel.xlsx")
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

End Class