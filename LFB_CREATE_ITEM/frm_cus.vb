Imports System
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frm_cus
    Private Sub frm_cus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click


        Try
            Dim command As New SqlCommand

            command.CommandText = "INSERT INTO [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer] (Customer_Code, Customer_Codess, Customer_Name) VALUES (@Name, @Property, @Value)"

            command.Parameters.Add("@Name")
            command.Parameters.Add("@Property")
            command.Parameters.Add("@Value")
            connection.Open()

            command.Connection = connection

            For i As Integer = 0 To data_cus.DataGrid_Cus.Rows.Count - 1
                command.Parameters(0).Value = data_cus.DataGrid_Cus.Rows(i).Cells(0).Value
                command.Parameters(1).Value = data_cus.DataGrid_Cus.Rows(i).Cells(1).Value
                command.Parameters(2).Value = data_cus.DataGrid_Cus.Rows(i).Cells(2).Value
                command.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try



    End Sub


End Class