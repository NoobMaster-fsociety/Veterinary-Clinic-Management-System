
Imports MySql.Data.MySqlClient
Imports System.IO


Public Class CashierLogin
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Connection()

        Try
            Dim found As Boolean = False
            If EmpId.Text = String.Empty Or tbpass.Text = String.Empty Then


                MsgBox("Please Fill Up the form Completely", vbInformation)

            End If


            cn.Open()
            cm = New MySqlCommand("SELECT * FROM `loginform` WHERE `EmployeeID` = '" & EmpId.Text & "' and `Password` = '" & tbpass.Text & "' ", cn)

            dr = cm.ExecuteReader
            dr.Read()


            If dr.HasRows Then
                found = True
                User = dr.Item("EmployeeID").ToString
                Password = dr.Item("Password").ToString
            Else
                found = False
            End If
            dr.Close()
            cn.Close()
            If found = True Then


                Me.Dispose()
                frmDisplayAppointment.ShowDialog()



            Else
                MsgBox("Invalid Employee ID or Password", vbCritical)

            End If

        Catch ex As Exception

            MsgBox(ex.Message, vbCritical)



        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
        RegistrationEmplye.ShowDialog()

    End Sub

    Private Sub CashierLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbpass.UseSystemPasswordChar = True

    End Sub
End Class