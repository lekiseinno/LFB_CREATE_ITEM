Imports System.Data.SqlClient

Public Class data_excelfile
    Private Sub data_input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get_data(DataGrid_input)


        Me.Tab_main.BackColor = Color.Blue


    End Sub

    Private Sub btn_to_input_Click(sender As Object, e As EventArgs) Handles btn_to_input.Click
        data_input.TopLevel = False
        data_input.FormBorderStyle = FormBorderStyle.None
        data_input.Visible = False
        frm_master.panel_datagrid.Controls.Add(data_input)
        data_input.Show()
        Me.Hide()
    End Sub

End Class