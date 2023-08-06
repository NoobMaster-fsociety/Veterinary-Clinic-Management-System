Imports MySql.Data.MySqlClient
Imports System.IO



Public Class RegistrationEmplye



    Private Sub RegistrationEmplye_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbpass.UseSystemPasswordChar = True
        tbCpass.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Dim found As Boolean = False
            If empnumtb.Text = String.Empty Or tbpass.Text = String.Empty Or tbCpass.Text = String.Empty Then


                MsgBox("Please Fill Up the form Completely", vbInformation)

            End If


            cn.Open()
            cm = New MySqlCommand("SELECT * FROM `employeedata` WHERE `EmployeeID` = '" & empnumtb.Text & "' ", cn)

            dr = cm.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                found = True
                User = dr.Item("EmployeeID").ToString
            Else
                found = False
            End If
            dr.Close()
            cn.Close()
            If found = True Then
             
                cn.Open()
                cm = New MySqlCommand("INSERT INTO `loginform`(`EmployeeID`, `Password`) VALUES (@EmployeeID,@Password)", cn)
                With cm

                    .Parameters.AddWithValue("@EmployeeID", empnumtb.Text)
                    .Parameters.AddWithValue("@Password", tbpass.Text)
                    .ExecuteNonQuery()

                End With
                cn.Close()

                MsgBox("Account Has been Recorded", vbInformation)
                Me.Dispose()
                Receptionlogin.ShowDialog()
                empnumtb.Clear()
                tbCpass.Clear()
                tbpass.Clear()

            Else
                MsgBox("Your Employee ID is not Registered", vbOKOnly)

            End If

        Catch ex As Exception

            MsgBox(ex.Message, vbCritical)



        End Try










    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()


    End Sub
End Class