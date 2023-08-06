Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmDisplayAppointment
    Private listFlDay As New List(Of FlowLayoutPanel)
    Private currentDate As DateTime = DateTime.Today
    Public AppID As Integer = 0
    Private Sub frmDisplayAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDayPanel(42)
        DisplayCurrentDate()
        Apprecord()
    End Sub

    Private Sub AddNewAppointment(ByVal sender As Object, e As EventArgs)
        Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        If day <> 0 Then
            With frmManageAppointment
                .AppID = 0
                .txtName.Clear()
                .txtAddress.SelectedIndex = -1
                .txtComment.SelectedIndex = -1
                .dtpDate.Value = New Date(currentDate.Year, currentDate.Month, day)
                .ShowDialog()
            End With
            DisplayCurrentDate()
        End If
    End Sub

    Private Sub ShowAppointmentDetail(sender As Object, e As EventArgs)
#Disable Warning BC42016 ' Implicit conversion
        Dim appID As Integer = CType(sender, LinkLabel).Tag
#Enable Warning BC42016 ' Implicit conversion
        Dim sql As String = $"select * from appointment where ID = {appID}"
        Dim dt As DataTable = QueryAsDataTable(sql)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            With frmManageAppointment
                .AppID = appID
#Disable Warning BC42016 ' Implicit conversion
                .txtName.Text = row("ContactName")
#Enable Warning BC42016 ' Implicit conversion
#Disable Warning BC42016 ' Implicit conversion
                .txtAddress.Text = row("Address")
#Enable Warning BC42016 ' Implicit conversion
#Enable Warning BC42016 ' Implicit conversion
#Disable Warning BC42016 ' Implicit conversion
                .txtComment.Text = row("Comment")
#Enable Warning BC42016 ' Implicit conversion
#Disable Warning BC42016 ' Implicit conversion
                .dtpDate.Value = row("AppDate")
#Enable Warning BC42016 ' Implicit conversion
                .ShowDialog()
            End With
            DisplayCurrentDate()
        End If
    End Sub

    Private Sub AddAppointmentToFlDay(ByVal startDayAtFlNumber As Integer)
        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)

        Dim sql As String = $"select * from appointment where AppDate between #{startDate.ToShortDateString()}# and #{endDate.ToShortDateString()}#"
        Dim dt As DataTable = QueryAsDataTable(sql)

        For Each row As DataRow In dt.Rows
#Disable Warning BC42016 ' Implicit conversion
            Dim appDay As DateTime = DateTime.Parse(row("AppDate"))
#Enable Warning BC42016 ' Implicit conversion
            Dim link As New LinkLabel
            link.Tag = row("ID")
            link.Name = $"link{row("ID")}"
#Disable Warning BC42016 ' Implicit conversion
            link.Text = row("ContactName") + " " + row("Address")
#Enable Warning BC42016 ' Implicit conversion
            AddHandler link.Click, AddressOf ShowAppointmentDetail
            listFlDay((appDay.Day - 1) + (startDayAtFlNumber - 1)).Controls.Add(link)
        Next
    End Sub

    Private Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim firstDayOfMonth As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfMonth.DayOfWeek + 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim firstDayOfCurrentDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Private Sub DisplayCurrentDate()
        lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy")
        Dim firstDayAtFlNumber As Integer = GetFirstDayOfWeekOfCurrentDate()
        Dim totalDay As Integer = GetTotalDaysOfCurrentDate()
        AddLabelDayToFlDay(firstDayAtFlNumber, totalDay)
        AddAppointmentToFlDay(firstDayAtFlNumber)
    End Sub

    Private Sub PrevMonth()
        currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()
    End Sub

    Private Sub NextMonth()
        currentDate = currentDate.AddMonths(1)
        DisplayCurrentDate()
    End Sub

    Private Sub Today()
        currentDate = DateTime.Today
        DisplayCurrentDate()
    End Sub

    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        flDays.Controls.Clear()
        listFlDay.Clear()
        For i As Integer = 1 To totalDays
            Dim fl As New FlowLayoutPanel
            fl.Name = $"flDay{i}"
            fl.Size = New Size(128, 99)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            fl.AutoScroll = True
            AddHandler fl.Click, AddressOf AddNewAppointment
            flDays.Controls.Add(fl)
            listFlDay.Add(fl)
        Next
    End Sub

    Private Sub AddLabelDayToFlDay(ByVal startDayAtFlNumber As Integer, ByVal totalDaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In listFlDay
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.White
        Next

        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label
            lbl.Name = $"lblDay{i}"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(110, 22)
            lbl.Text = i
            lbl.Font = New Font("Microsoft Sans Serif", 12)
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Tag = i
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Controls.Add(lbl)

            If New Date(currentDate.Year, currentDate.Month, i) = Date.Today Then
                listFlDay((i - 1) + (startDayAtFlNumber - 1)).BackColor = Color.Aqua
            End If

        Next
    End Sub

    Sub Apprecord()


        Connection()

        DataGridView1.Rows.Clear()
        Dim i As Integer


        cn.Open()

        cm = New MySqlCommand("Select*From appointment", cn)
        dr = cm.ExecuteReader
        While dr.Read

            i += 1

            DataGridView1.Rows.Add(i, dr.Item("ID").ToString, dr.Item("Date").ToString, dr.Item("Name").ToString, dr.Item("Time").ToString, dr.Item("Service").ToString)


        End While
        dr.Close()
        cn.Close()

        For i = 0 To DataGridView1.Rows.Count - 1


        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
        Accessfrm.ShowDialog()
    End Sub

    Private Sub btnNextMonth_Click_1(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        NextMonth()
    End Sub

    Private Sub btnPrevMonth_Click_1(sender As Object, e As EventArgs) Handles btnPrevMonth.Click
        PrevMonth()
    End Sub

    Private Sub btnToday_Click_1(sender As Object, e As EventArgs) Handles btnToday.Click
        Today()
    End Sub
End Class