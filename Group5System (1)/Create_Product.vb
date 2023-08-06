Imports MySql.Data.MySqlClient
Imports System.IO


Public Class Create_Product
    Private Sub Create_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        txtformulation.Enabled = False
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try


            If txtdescription.Text = String.Empty Or txtPrice.Text = String.Empty Or txtstock.Text = String.Empty Or cmbCategory.Text = String.Empty Or txtformulation.Text = String.Empty Then

                MsgBox("Please Complete Data!", vbCritical)
                Return

            End If
            If txtstock.Text = String.Empty Or cmbCategory.Text = String.Empty Then

                MsgBox("[Category][Stock] One of this is Empty!", vbCritical)

            End If
            If txtformulation.Text = String.Empty Then

                MsgBox("Please Input Data!", vbCritical)
            End If








            If MsgBox("Save This Item?", vbYesNo + vbQuestion) = vbYes Then






                cn.Open()
                cm = New MySqlCommand("INSERT INTO `product` (`Barcode`,`Description`, `Category`, `Price` , `Stock`,Status) VALUES (@Barcode,@Description,@Category,@Price,@Stock,@Status)", cn)
                With cm
                    .Parameters.AddWithValue("@Barcode", txtProductID.Text)
                    .Parameters.AddWithValue("@Description", txtdescription.Text)
                    .Parameters.AddWithValue("@Category", cmbCategory.Text)
                    .Parameters.AddWithValue("@Price", txtPrice.Text)

                    .Parameters.AddWithValue("@Status", txtformulation.Text)
                    .Parameters.AddWithValue("@Stock", txtstock.Text)
                    .ExecuteNonQuery()

                End With
                cn.Close()

                MsgBox("Item Has Been Save", vbInformation)
                Clear()
                Adminform.loadproduct()





            End If

        Catch ex As Exception

            cn.Close()
            MsgBox(ex.Message, vbCritical)



        End Try
    End Sub

    Sub Clear()

        txtdescription.Clear()
        txtProductID.Clear()

        txtPrice.Clear()
        cmbCategory.Text = ""
        txtstock.Text = ""


        btnsave.Enabled = True
        btnupdate.Enabled = False
        txtProductID.Focus()









    End Sub
    Private Sub txtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select





    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try


            If txtProductID.Text = String.Empty Or txtdescription.Text = String.Empty Or txtPrice.Text = String.Empty Or txtstock.Text = String.Empty Or cmbCategory.Text = String.Empty Or txtformulation.Text = String.Empty Then

                MsgBox("Please Complete Data!", vbCritical)
                Return

            End If

            If txtdescription.Text = String.Empty Or txtPrice.Text = String.Empty Then

                MsgBox("[Description][Price] One of this is Empty!!", vbCritical)


            End If
            If txtstock.Text = String.Empty Or cmbCategory.Text = String.Empty Then

                MsgBox("[Category][Stock] One of this is Empty!", vbCritical)

            End If





            If MsgBox("Update This Item?", vbYesNo) = vbYes Then




                cn.Open()
                cm = New MySqlCommand("UPDATE `product` SET Barcode='" & txtProductID.Text & "',Description='" & txtdescription.Text & "',Category='" & cmbCategory.Text & "',Price='" & txtPrice.Text & "',Stock='" & txtstock.Text & "',Status='" & txtformulation.Text & "' where PID=@PID", cn)
                With cm


                    .Parameters.AddWithValue("@PID", TextBox1.Text)


                    .ExecuteNonQuery()
                End With
                cn.Close()

                MsgBox("Item Has Been Updated", vbInformation)
                Me.Dispose()
                Adminform.loadproduct()


            End If


        Catch ex As Exception

            cn.Close()
            MsgBox(ex.Message, vbCritical)



        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Dispose()
        Adminform.loadproduct()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs)

        Me.Dispose()
        Adminform.loadproduct()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncancel_Click_1(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub txtstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstock.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtformulation_Enter(sender As Object, e As EventArgs) Handles txtformulation.Enter
        If txtformulation.Text = "Milligrams(mg)" Then



            txtformulation.Text = ""
            txtformulation.ForeColor = Color.Black


        End If
    End Sub

    Private Sub txtformulation_Leave(sender As Object, e As EventArgs) Handles txtformulation.Leave
        If txtformulation.Text = "" Then

            txtformulation.Text = "Milligrams(mg)"
            txtformulation.ForeColor = Color.Silver



        End If
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged

        If cmbCategory.Text = "Medicine" Then
            txtformulation.Text = "Milligrams(mg)"
            txtformulation.Enabled = True




        End If
        If cmbCategory.Text = "Food" Then

            txtformulation.Text = "[None] "
            txtformulation.Enabled = False


        ElseIf cmbCategory.Text = "Accesories" Then

            txtformulation.Text = "[None] "
            txtformulation.Enabled = False


        End If



    End Sub


End Class