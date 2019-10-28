Imports System.Data.SqlClient

Public Class data_input

    Private Sub Data_input_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGrid_input_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) _
  Handles DataGrid_input.RowPostPaint
        'สร้างเลขบรรทัด
        Using b As SolidBrush = New SolidBrush(DataGrid_input.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture),
                  sender.DefaultCellStyle.Font,
                  b,
                  e.RowBounds.Location.X + 40,
                  e.RowBounds.Location.Y + 3,
                  New StringFormat(StringFormatFlags.DirectionRightToLeft))
        End Using
        'Me.DataGrid_input("Index", e.RowIndex).Value = e.RowIndex
    End Sub
    Private Sub btn_excel_Click(sender As Object, e As EventArgs) Handles btn_excel.Click

        Me.Cursor = Cursors.WaitCursor

        Dim nowdate = Now.ToString("yyyy-MM-dd")
        Dim nowtime = Now.ToString("HHmm")


        If System.IO.Directory.Exists("D:\create_item\" & nowdate) Then

        Else
            MkDir("D:\create_item\" & nowdate)
        End If





        setup_conf.gen_excel(data_excelfile.DataGrid_bom_header_0, "D:\create_item\" + nowdate + "\" + nowtime + "_Bom Header_0.xls")
        setup_conf.gen_excel(data_excelfile.DataGrid_bom_header_1, "D:\create_item\" + nowdate + "\" + nowtime + "_Bom Header_1.xls")
        setup_conf.gen_excel(data_excelfile.DataGrid_bom_line, "D:\create_item\" + nowdate + "\" + nowtime + "_Bom Line.xls")
        setup_conf.gen_excel(data_excelfile.DataGrid_Default_dimension, "D:\create_item\" + nowdate + "\" + nowtime + "_Default_dimension.xls")
        setup_conf.gen_excel(data_excelfile.DataGrid_Item_master, "D:\create_item\" + nowdate + "\" + nowtime + "_Item_master.xls")
        setup_conf.gen_excel(data_excelfile.DataGrid_Item_unit, "D:\create_item\" + nowdate + "\" + nowtime + "_Item_unit.xls")

        setup_conf.gen_txt()

        MsgBox("Create File : Success !")

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btn_to_excel_Click(sender As Object, e As EventArgs) Handles btn_to_excel.Click
        data_excelfile.TopLevel = False
        data_excelfile.FormBorderStyle = FormBorderStyle.None
        data_excelfile.Visible = False
        frm_master.panel_datagrid.Controls.Add(data_excelfile)
        data_excelfile.Show()
        Me.Hide()
    End Sub



    Private Sub btn_csv_Click(sender As Object, e As EventArgs) Handles btn_csv.Click
        Me.Cursor = Cursors.WaitCursor

        Dim nowdate = Now.ToString("yyyy-MM-dd")
        Dim nowtime = Now.ToString("HHmm")


        If System.IO.Directory.Exists("D:\create_item\" & nowdate) Then

        Else
            MkDir("D:\create_item\" & nowdate)
        End If

        setup_conf.gen_excel(data_excelfile.DataGrid_bom_header_0, "D:\create_item\" + nowdate + "\" + nowtime + "_Bom Header_0.csv")
        setup_conf.gen_excel(data_excelfile.DataGrid_bom_header_1, "D:\create_item\" + nowdate + "\" + nowtime + "_Bom Header_1.csv")
        setup_conf.gen_excel(data_excelfile.DataGrid_bom_line, "D:\create_item\" + nowdate + "\" + nowtime + "_Bom Line.csv")
        setup_conf.gen_excel(data_excelfile.DataGrid_Default_dimension, "D:\create_item\" + nowdate + "\" + nowtime + "_Default_dimension.csv")
        setup_conf.gen_excel(data_excelfile.DataGrid_Item_master, "D:\create_item\" + nowdate + "\" + nowtime + "_Item_master.csv")
        setup_conf.gen_excel(data_excelfile.DataGrid_Item_unit, "D:\create_item\" + nowdate + "\" + nowtime + "_Item_unit.csv")

        setup_conf.gen_txt()


        MsgBox("Create File : Success !")
        Me.Cursor = Cursors.Default
    End Sub

    Private bitmap As Bitmap

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim bm As New Bitmap(Me.DataGrid_input.Width, Me.DataGrid_input.Height)
        DataGrid_input.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGrid_input.Width, Me.DataGrid_input.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click


        PrintDialog1.Document = PrintDocument1
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If

    End Sub




    Private Sub Txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If txt_search.Text = "" Then
            For i As Integer = 0 To DataGrid_input.RowCount - 1
                DataGrid_input.Rows(i).Visible = True
            Next
        Else
            For i As Integer = 0 To DataGrid_input.RowCount - 1
                If DataGrid_input.Rows(i).Cells(0).Value IsNot Nothing Then
                    For j As Integer = 0 To DataGrid_input.ColumnCount - 1
                        If DataGrid_input.Rows(i).Cells(j).Value IsNot Nothing Then
                            If DataGrid_input.Columns(j) IsNot Nothing Then
                                If DataGrid_input.Rows(i).Cells(j).Value.ToString Like "*" & txt_search.Text & "*" Then
                                    DataGrid_input.Rows(i).Visible = True
                                    'TextBox1.Text &= "DT = [" & i & "][" & j & "] [" & Trim(DataGrid_input.Rows(i).Cells(j).Value.ToString) & "] txt_search = [" & Trim(txt_search.Text) & "] " & vbCrLf
                                    Exit For
                                Else
                                    DataGrid_input.Rows(i).Visible = False
                                End If
                            End If
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGrid_input.Width, Me.DataGrid_input.Height)
        DataGrid_input.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGrid_input.Width, Me.DataGrid_input.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub





    Private Sub DataGrid_input_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_input.CellClick
        'If e.ColumnIndex = 0 Then
        '    If DataGrid_input.Item(e.ColumnIndex, e.RowIndex).Value = False Then
        '        DataGrid_input.Item(e.ColumnIndex, e.RowIndex).Value = True
        '        'กรณี ติ๊กหลังจากใส่ค่าเมตรรวมหาส่วนลด 
        '        If IsNumeric(frm_input.txt_meth2.Text) = True Then
        '            DataGrid_input.Item(31, e.RowIndex).Value = frm_input.txt_meth2.Text
        '        Else
        '            DataGrid_input.Item(31, e.RowIndex).Value = 0
        '        End If
        '    Else
        '            DataGrid_input.Item(e.ColumnIndex, e.RowIndex).Value = False
        '    End If
        '    '   MsgBox(DataGrid_input.Item(e.ColumnIndex, e.RowIndex).Value.ToString())
        'End If





    End Sub

    Private Sub btn_to_cal_Click(sender As Object, e As EventArgs) Handles btn_to_cal.Click

        Dim ilon As String = ""
        For Each v As String In
        From row
        In DataGrid_input.Rows
        Group By val = DirectCast(row, DataGridViewRow).Cells("Group").Value
        Into Group
        Where val IsNot Nothing
        Select str = val.ToString



            Dim barCount = DataGrid_input.Rows.
                             Cast(Of DataGridViewRow)().
                             Where(Function(row) CStr(row.Cells(0).Value) = v.ToString).
                             Sum(Function(row) CInt(row.Cells(31).Value))


            For i As Integer = 0 To DataGrid_input.RowCount - 1

                If v.ToString <> "" Then

                    If DataGrid_input.Rows(i).Cells(0).Value = v.ToString Then

                        ilon = DataGrid_input.Rows(i).Cells(8).Value

                        DataGrid_input.Rows(i).Cells(32).Value = barCount

                        DataGrid_input.Rows(i).Cells(23).Value = get_discounts(barCount, ilon)

                    End If

                End If




            Next

            '   MsgBox(barCount)



        Next



    End Sub

    Function get_discounts(ByVal imeth As Integer, ByVal vlon As String) As String



        '  Dim text_lon As String = frm_input.txt_lon.Text
        Dim cuscode As String = frm_input.lb_cuscode.Text
        Dim discount As Integer = 0

        If vlon = "" Then
            Return discount & " %"
            Exit Function
        End If

        connection.Close()
        connection.Open()


        Dim sql11 As String



        If imeth > 0 Then
            sql11 = "
                    SELECT  [" & vlon & "]
                    FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_Discount] 
                    WHERE   [Customer_Code] =   '" & cuscode & "'
                    AND     [MeterStart]    <   '" & imeth & "'
                    AND     [MeterEnd]      >   '" & imeth & "'
                    "
        Else
            sql11 = "
                SELECT  [" & vlon & "]
                FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_Discount] 
                WHERE   [Customer_Code] =   '" & cuscode & "'
                "
        End If



        'TextBox3.Text = sql1



        frm_input.TextBox3.Text = sql11



        Dim sqlcmd1 As New SqlCommand(sql11, connection)
        Dim myreader1 As SqlDataReader
        myreader1 = sqlcmd1.ExecuteReader()
        myreader1.Read()
        If myreader1.HasRows Then
            discount = myreader1.Item(vlon).ToString
        End If
        connection.Close()

        'txt_discount.Text = discount & " %"
        Return discount & " %"
    End Function

End Class

