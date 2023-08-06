Imports MySql.Data.MySqlClient
Imports System.IO





Public Class ERegistration

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browseImage.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then

            browse.Image = Image.FromFile(opf.FileName)
            OpenFileDialog1.FileName = opf.FileName



        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        tbdate.Text = MM.Text & "/" & DD.Text & "/" & yy.Text
        empnum.Text = "Emp" & tblstN.Text & "2021"
        Connection()


        Try

            If OpenFileDialog1.FileName = "OpenFileDialog1" Then
                MsgBox("Please Select A Image", vbCritical)
                Return


                If tbFrstN.Text = String.Empty Or tblstN.Text = String.Empty Or tblMI.Text = String.Empty Then

                    MsgBox("Please Complete the Name of the Employee", vbCritical)


                End If
                If MM.Text = String.Empty Or DD.Text = String.Empty Or yy.Text = String.Empty Then

                    MsgBox("Please Complete the Date Of Birth", vbCritical)

                End If
                If cmbSex.Text = String.Empty Then

                    MsgBox("Please Fill Up [Marital Status]", vbCritical)
                End If
                If Mstatus.Text = String.Empty Then


                    MsgBox("Please Fill Up [Sex]", vbCritical)

                End If



            End If




            If MsgBox("Save This Item?", vbYesNo) = vbYes Then
                Dim ms As New MemoryStream
                browse.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = ms.GetBuffer


                cn.Open()
                cm = New MySqlCommand("INSERT INTO `employeedata`(`EmployeeID`,`First Name`,`Middle Name`,`Last Name`,`Birthdate`,`Gender`,`Address`,`Status`,`Position`,`Image`) VALUES ('" &
                                      empnum.Text & "','" & tbFrstN.Text & "','" & tblMI.Text & "','" & tblstN.Text & "','" & tbdate.Text & "','" & cmbSex.Text & "','" &
                                      tbAddress.Text & "','" & Mstatus.Text & "','" & tbpos.Text & "',@Image)", cn)
                With cm

                    .Parameters.AddWithValue("@Image", arrImage)
                    .ExecuteNonQuery()

                End With
                cn.Close()

                MsgBox("Item Has Been Save", vbInformation)
                clear()
                With Adminform

                    .loadRecords()

                End With



            End If

        Catch ex As Exception


            MsgBox(ex.Message, vbCritical)



        End Try









    End Sub

  
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Dispose()


    End Sub

    Private Sub ERegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click

        Connection()


        Try

        


                If tbFrstN.Text = String.Empty Or tblstN.Text = String.Empty Or tblMI.Text = String.Empty Then

                    MsgBox("Please Complete the Name of the Employee", vbCritical)


                End If
                If tbAddress.Text = String.Empty Then

                    MsgBox("Please Fill Up the Address", vbCritical)

                End If
                If cmbSex.Text = String.Empty Then

                    MsgBox("Please Fill Up [Marital Status]", vbCritical)
                End If
                If Mstatus.Text = String.Empty Then


                    MsgBox("Please Fill Up [Sex]", vbCritical)

                End If





#Disable Warning BC42016 ' Implicit conversion
            If MsgBox("Update This Item?", vbYesNo + vbQuestion) = vbYes Then
#Enable Warning BC42016 ' Implicit conversion
                Dim ms As New MemoryStream
                browse.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = ms.GetBuffer


                cn.Open()
                cm = New MySqlCommand("UPDATE `employeedata` SET `Address`='" & tbAddress.Text & "',`Status`='" & Mstatus.Text & "',`Position`='" & tbpos.Text & "',`Image`=@Image WHERE EmployeeID = '" & empnum.Text & "'", cn)
                With cm

                    .Parameters.AddWithValue("@Image", arrImage)
                    .ExecuteNonQuery()

                End With
                cn.Close()

                MsgBox("Account Has Been Updated", vbInformation)
                Me.Dispose()

                With Adminform

                    .loadRecords()

                End With



            End If

        Catch ex As Exception


            MsgBox(ex.Message, vbCritical)



        End Try





    End Sub
    Sub clear()


        empnum.Clear()
        tbFrstN.Clear()
        tblMI.Clear()
        tblstN.Clear()
        tbAddress.Clear()
        tbdate.Clear()
        tbpos.Clear()
        MM.SelectedIndex = -1
        DD.SelectedIndex = -1
        yy.SelectedIndex = -1
        Mstatus.SelectedIndex = -1
        cmbSex.SelectedIndex = -1
        browse.Image = Nothing




    End Sub



    Private Sub tbFrstN_Enter(sender As Object, e As EventArgs) Handles tbFrstN.Enter

        If tbFrstN.Text = "First Name" Then



            tbFrstN.Text = ""
            tbFrstN.ForeColor = Color.Black


        End If





    End Sub

    Private Sub tbFrstN_Leave(sender As Object, e As EventArgs) Handles tbFrstN.Leave



        If tbFrstN.Text = "" Then



            tbFrstN.Text = "First Name"
            tbFrstN.ForeColor = Color.Silver


        End If



    End Sub

    Private Sub tblMI_Enter(sender As Object, e As EventArgs) Handles tblMI.Enter
        If tblMI.Text = "M.I" Then



            tblMI.Text = ""
            tblMI.ForeColor = Color.Black


        End If




    End Sub

    Private Sub tblMI_Leave(sender As Object, e As EventArgs) Handles tblMI.Leave
        If tblMI.Text = "" Then



            tblMI.Text = "M.I"
            tblMI.ForeColor = Color.Silver


        End If

    End Sub

    Private Sub tblstN_Enter(sender As Object, e As EventArgs) Handles tblstN.Enter
        If tblstN.Text = "Last Name" Then



            tblstN.Text = ""
            tblstN.ForeColor = Color.Black


        End If





    End Sub

    Private Sub tblstN_Leave(sender As Object, e As EventArgs) Handles tblstN.Leave
        If tblstN.Text = "" Then



            tblstN.Text = "Last Name"
            tblstN.ForeColor = Color.Silver


        End If

    End Sub
End Class