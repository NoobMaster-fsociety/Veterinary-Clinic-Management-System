Imports MySql.Data.MySqlClient
Imports System.IO



Public Class Adminlogin


    Dim attempts As Integer
    Private Sub Adminlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tbpass.UseSystemPasswordChar = True
        tbpass.Focus()

        lock.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginbtn.Click
        If tbpass.Text = String.Empty Then

            MsgBox("ID-Number is Empty", vbCritical)

        End If

        If Timer1.Enabled = False Then



            If tbpass.Text = "1234" = False Then
                attempts += 1
                If attempts = 3 Then
                    Timer1.Start()


                    tbpass.Clear()

                    MessageBox.Show("You Have Reached your attempts, Login form is locked ,Please wait for 5 Seconds ")
                    Timer1.Enabled = True
                End If
                If attempts < 3 Then


                    MessageBox.Show(" Incorrect ID, You have used your " & attempts & " of 3 of your login attempts")
                    tbpass.Clear()
                End If
            End If


            If tbpass.Text = "1234" = True Then


                Adminform.ShowDialog()
                Me.Dispose()





                attempts = 0

            End If
        End If

        If Timer1.Enabled = True Then


            MsgBox("Log attempt is each maximum attempts,Please Wait 5 Seconds")
            lock.Show()

        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        attempts = 0
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Dispose()
        Accessfrm.ShowDialog()
    End Sub

    


    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Receptionlogin.ShowDialog()

    End Sub
End Class