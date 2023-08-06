Imports MySql.Data.MySqlClient
Imports System.IO



Public Class productremove
    Private Sub productremove_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If txtreason.Text = String.Empty Then

            MsgBox("Please Input A reason why you want to remove this data!", vbCritical)
            Return
        End If


        If MsgBox("Delete This Record?", vbYesNo + vbQuestion) = vbYes Then

            cn.Open()
            cm = New MySqlCommand("Delete From product where PID like '" & TextBox1.Text & "'", cn)
            cm.ExecuteNonQuery()



                cn.Close()
                MsgBox("Record HAs been Deleted Succesfully", vbInformation)
            With Adminform

                .loadRecords()
                .loadproduct()

            End With



        End If







    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub txtreason_Enter(sender As Object, e As EventArgs) Handles txtreason.Enter
        If txtreason.Text = "Reason" Then



            txtreason.Text = ""
            txtreason.ForeColor = Color.Black


        End If
    End Sub

    Private Sub txtreason_Leave(sender As Object, e As EventArgs) Handles txtreason.Leave

        If txtreason.Text = "" Then

            txtreason.Text = "Reason"
            txtreason.ForeColor = Color.Silver



        End If




    End Sub
End Class