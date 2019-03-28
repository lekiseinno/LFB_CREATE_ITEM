Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frm_input


    Private Sub frm_input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_item_customer()
    End Sub

    Sub get_item_customer()
        Try

            Dim sql As String
            sql = "SELECT * FROM [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer]"


            Dim query As New SqlCommand(sql, connection)
            Dim dataadapter As New SqlDataAdapter(query)
            Dim dt As New DataTable
            Dim ds As New DataSet

            dataadapter.Fill(ds, "a")

            dt = ds.Tables(0)

            Dim idataView As DataView

            idataView = New DataView(dt)
            idataView.Sort = "Customer_Name ASC"
            dt = idataView.ToTable
            Dim dr As DataRow = dt.NewRow
            dr("Customer_Name") = ""
            dt.Rows.InsertAt(dr, 0)

            With txt_customer
                .DataSource = dt
                .DisplayMember = "Customer_Name"
                .ValueMember = "Customer_Code"
            End With

            dt = Nothing
            ds = Nothing


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'add_data_input(txt_no.Text, txt_type.Text, txt_pono.Text, txt_width.Text, txt_workinch.Text, txt_cut.Text, txt_long.Text, txt_cutoff.Text, txt_F1.Text, txt_F2.Text, txt_F3.Text, txt_F4.Text, txt_F5.Text, "chk", txt_trim.Text, "chk", txt_paper.Text, txt_lon.Text, txt_count.Text, txt_count_cut.Text, txt_duedate.Text, txt_pl.Text, txt_pl_sp.Text, txt_pl_net.Text, txt_net_unit.Text, txt_met.Text, txt_sumdiscount.Text, txt_price.Text, txt_discount.Text, txt_meth.Text, txt_meth2.Text, txt_note.Text)
        add_data_input()
    End Sub


    'Sub add_data_input(txt_no, txt_type, txt_pono, txt_width, txt_workinch, txt_cut, txt_long, txt_cutoff, txt_F1, txt_F2, txt_F3, txt_F4, txt_F5, chk_1, txt_trim, chk_2, txt_paper, txt_lon, txt_count, txt_count_cut, txt_duedate, txt_pl, txt_pl_sp, txt_pl_net, txt_net_unit, txt_met, txt_sumdiscount, txt_price, txt_discount, txt_meth, txt_meth2, txt_note)
    Sub add_data_input()
        data_input.DataGrid_input.ColumnCount = 32
        data_input.DataGrid_input.Columns(0).Name = "No."
        data_input.DataGrid_input.Columns(1).Name = "Type"
        data_input.DataGrid_input.Columns(2).Name = "PO"
        data_input.DataGrid_input.Columns(3).Name = "กว้าง"
        data_input.DataGrid_input.Columns(4).Name = "หน้าเดินงาน นิ้ว"
        data_input.DataGrid_input.Columns(5).Name = "ผ่า"
        data_input.DataGrid_input.Columns(6).Name = "ยาว"
        data_input.DataGrid_input.Columns(7).Name = "หน้าผ่าเล็ก"
        data_input.DataGrid_input.Columns(8).Name = "F1"
        data_input.DataGrid_input.Columns(9).Name = "F2"
        data_input.DataGrid_input.Columns(10).Name = "F3"
        data_input.DataGrid_input.Columns(11).Name = "F4"
        data_input.DataGrid_input.Columns(12).Name = "F5"
        data_input.DataGrid_input.Columns(13).Name = "CHECKED"
        data_input.DataGrid_input.Columns(14).Name = "Trim"
        data_input.DataGrid_input.Columns(15).Name = "CHECKED"
        data_input.DataGrid_input.Columns(16).Name = "Paper Combination/สั่งผลิต"
        data_input.DataGrid_input.Columns(17).Name = "ลอน"
        data_input.DataGrid_input.Columns(18).Name = "จำนวนเต็ม"
        data_input.DataGrid_input.Columns(19).Name = "จำนวนแผ่นเล็ก"
        data_input.DataGrid_input.Columns(20).Name = "Due ส่งของ"
        data_input.DataGrid_input.Columns(21).Name = "P/L"
        data_input.DataGrid_input.Columns(22).Name = "@special P/ L"
        data_input.DataGrid_input.Columns(23).Name = "@NET P/ L"
        data_input.DataGrid_input.Columns(24).Name = "@NET unit Price "
        data_input.DataGrid_input.Columns(25).Name = "เมตรรวมหาส่วนลด"
        data_input.DataGrid_input.Columns(26).Name = "เมตรรวม เดินงานพ่วง"
        data_input.DataGrid_input.Columns(27).Name = "เมตรรวมหาส่วนลด "
        data_input.DataGrid_input.Columns(28).Name = "Discount"
        data_input.DataGrid_input.Columns(29).Name = "ส่วนลดเงินสด"
        data_input.DataGrid_input.Columns(30).Name = "ราคาต่อแผ่น "
        data_input.DataGrid_input.Columns(31).Name = "หมายเหตุ"

        'data_input.DataGrid_input.Columns(0).Width = 175
        'data_input.DataGrid_input.Columns(1).Width = 400
        'data_input.DataGrid_input.Columns(2).Width = 150
        'data_input.DataGrid_input.Columns(3).Width = 150

        Dim row As String()

        'row = New String() {txt_no, txt_type, txt_pono, txt_width, txt_workinch, txt_cut, txt_long, txt_cutoff, txt_F1, txt_F2, txt_F3, txt_F4, txt_F5, chk_1, txt_trim, chk_2, txt_paper, txt_lon, txt_count, txt_count_cut, txt_duedate, txt_pl, txt_pl_sp, txt_pl_net, txt_net_unit, txt_met, txt_sumdiscount, txt_price, txt_discount, txt_meth, txt_meth2, txt_note}
        row = New String() {txt_no.Text, txt_type.Text, txt_pono.Text, txt_width.Text, txt_workinch.Text, txt_cut.Text, txt_long.Text, txt_cutoff.Text, txt_F1.Text, txt_F2.Text, txt_F3.Text, txt_F4.Text, txt_F5.Text, "chk", txt_trim.Text, "chk", txt_paper.Text, txt_lon.Text, txt_count.Text, txt_count_cut.Text, txt_duedate.Text, txt_pl.Text, txt_pl_sp.Text, txt_pl_net.Text, txt_net_unit.Text, txt_met.Text, txt_sumdiscount.Text, txt_price.Text, txt_discount.Text, txt_meth.Text, txt_meth2.Text, txt_note.Text}
        data_input.DataGrid_input.Rows.Add(row)
    End Sub




    Dim cut_total

    Dim F1
    Dim F2
    Dim F3
    Dim F4
    Dim F5

    Private Sub txt_F1_TextChanged(sender As Object, e As EventArgs) Handles txt_F1.TextChanged
        F1 = txt_F1.Text
        cut_total = (F1 + F2 + F3 + F4 + F5)

        txt_cutoff.Text = cut_total

    End Sub

    Private Sub txt_F2_TextChanged(sender As Object, e As EventArgs) Handles txt_F2.TextChanged

        F2 = txt_F2.Text
        cut_total = (F1 + F2 + F3 + F4 + F5)

        txt_cutoff.Text = cut_total

    End Sub

    Private Sub txt_F3_TextChanged(sender As Object, e As EventArgs) Handles txt_F3.TextChanged

        F3 = txt_F3.Text
        cut_total = (F1 + F2 + F3 + F4 + F5)

        txt_cutoff.Text = cut_total

    End Sub

    Private Sub txt_F4_TextChanged(sender As Object, e As EventArgs) Handles txt_F4.TextChanged

        F4 = txt_F4.Text
        cut_total = (F1 + F2 + F3 + F4 + F5)

        txt_cutoff.Text = cut_total

    End Sub

    Private Sub txt_F5_TextChanged(sender As Object, e As EventArgs) Handles txt_F5.TextChanged

        F5 = txt_F5.Text
        cut_total = (F1 + F2 + F3 + F4 + F5)

        txt_cutoff.Text = cut_total

    End Sub
End Class