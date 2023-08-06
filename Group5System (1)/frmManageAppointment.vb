Imports MySql.Data.MySqlClient
Imports System.IO


Public Class frmManageAppointment
    Public AppID As Integer = 0

    Private Sub frmManageAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Visible = AppID <> 0
        BtnUpdate.Visible = AppID <> 0
        frmDisplayAppointment.Apprecord()
        Connection()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MsgBox("Customer or Contact name is required.")
            Return
        End If

        If IsConfirm("Do you want to save ?") Then





            'phpmyadmin'
            cn.Open()

            cm = New MySqlCommand("INSERT INTO `appointment`( `Date`, `Name`, `Time`, `Service`) VALUES ('" &
                                      dtpDate.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtComment.Text & "')", cn)
            With cm


                .ExecuteNonQuery()

            End With
            cn.Close()




            'access'
            Dim sql As String = $"insert into appointment(AppDate, ContactName, Address, Comment) 
                                values('{dtpDate.Value.ToShortDateString()}', '{txtName.Text}', '{txtAddress.Text}', '{txtComment.Text}')"

            If InsertUpdateDelete(sql) Then
                MsgBox("Inserted")
                With frmDisplayAppointment
                    .Apprecord()
                End With

                Close()
            Else
                MsgBox("Failed")
            End If
        End If
    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If IsConfirm("Do you want to delete this appointment ?") Then


            cn.Open()
            cm = New MySqlCommand("Delete From `appointment` where `ID` like ID ", cn)
            cm.ExecuteNonQuery()
            cn.Close()

            Dim sql As String = $"delete from appointment where ID = {AppID}"
            If InsertUpdateDelete(sql) Then
                MsgBox("Deleted")
                frmDisplayAppointment.Apprecord()
                Close()
            Else
                MsgBox("Delete Failed")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If AppID = 0 Then
            btnSave.Enabled = False

            Dim sql As String = $"update appointment set AppDate = '{dtpDate.Value.ToShortDateString()}', 
                                                ContactName = '{txtName.Text}', Address = '{txtAddress.Text}', 
                                                Comment = '{txtComment.Text}'
                                      where ID = {AppID}"
            If InsertUpdateDelete(sql) Then
                MsgBox("Updated")
                Close()
            Else
                MsgBox("Update Failed")
            End If
        End If



    End Sub
End Class
