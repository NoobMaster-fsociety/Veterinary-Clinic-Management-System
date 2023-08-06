<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERegistration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbFrstN = New System.Windows.Forms.TextBox()
        Me.tblMI = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Mstatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.yy = New System.Windows.Forms.ComboBox()
        Me.DD = New System.Windows.Forms.ComboBox()
        Me.MM = New System.Windows.Forms.ComboBox()
        Me.tbdate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.browse = New System.Windows.Forms.PictureBox()
        Me.browseImage = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbpos = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.empnum = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tblstN = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.browse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbFrstN
        '
        Me.tbFrstN.ForeColor = System.Drawing.Color.Silver
        Me.tbFrstN.Location = New System.Drawing.Point(183, 38)
        Me.tbFrstN.Name = "tbFrstN"
        Me.tbFrstN.Size = New System.Drawing.Size(164, 22)
        Me.tbFrstN.TabIndex = 1
        Me.tbFrstN.Text = "First Name"
        '
        'tblMI
        '
        Me.tblMI.ForeColor = System.Drawing.Color.Silver
        Me.tblMI.Location = New System.Drawing.Point(362, 38)
        Me.tblMI.Name = "tblMI"
        Me.tblMI.Size = New System.Drawing.Size(32, 22)
        Me.tblMI.TabIndex = 2
        Me.tblMI.Text = "M.I"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tblstN)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tblMI)
        Me.GroupBox1.Controls.Add(Me.tbFrstN)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 68)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(365, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "M.I"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Marital Status"
        '
        'Mstatus
        '
        Me.Mstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Mstatus.FormattingEnabled = True
        Me.Mstatus.Items.AddRange(New Object() {"Single", "Married", "Widowed"})
        Me.Mstatus.Location = New System.Drawing.Point(9, 36)
        Me.Mstatus.Name = "Mstatus"
        Me.Mstatus.Size = New System.Drawing.Size(88, 24)
        Me.Mstatus.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(122, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sex"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbSex)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Mstatus)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(447, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 68)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'cmbSex
        '
        Me.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"M", "F"})
        Me.cmbSex.Location = New System.Drawing.Point(121, 36)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(53, 24)
        Me.cmbSex.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Date of Birth (MMDDYY)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.yy)
        Me.GroupBox3.Controls.Add(Me.DD)
        Me.GroupBox3.Controls.Add(Me.MM)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.tbdate)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(309, 67)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'yy
        '
        Me.yy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yy.FormattingEnabled = True
        Me.yy.Items.AddRange(New Object() {"2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964"})
        Me.yy.Location = New System.Drawing.Point(197, 29)
        Me.yy.Name = "yy"
        Me.yy.Size = New System.Drawing.Size(88, 24)
        Me.yy.TabIndex = 15
        '
        'DD
        '
        Me.DD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DD.FormattingEnabled = True
        Me.DD.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.DD.Location = New System.Drawing.Point(103, 30)
        Me.DD.Name = "DD"
        Me.DD.Size = New System.Drawing.Size(88, 24)
        Me.DD.TabIndex = 14
        '
        'MM
        '
        Me.MM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MM.FormattingEnabled = True
        Me.MM.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.MM.Location = New System.Drawing.Point(9, 30)
        Me.MM.Name = "MM"
        Me.MM.Size = New System.Drawing.Size(88, 24)
        Me.MM.TabIndex = 13
        '
        'tbdate
        '
        Me.tbdate.Location = New System.Drawing.Point(8, 31)
        Me.tbdate.Name = "tbdate"
        Me.tbdate.Size = New System.Drawing.Size(213, 22)
        Me.tbdate.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Address"
        '
        'tbAddress
        '
        Me.tbAddress.ForeColor = System.Drawing.Color.Black
        Me.tbAddress.Location = New System.Drawing.Point(10, 33)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(384, 22)
        Me.tbAddress.TabIndex = 15
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.tbAddress)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 215)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(415, 64)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.browse)
        Me.GroupBox5.Location = New System.Drawing.Point(449, 140)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(225, 211)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        '
        'browse
        '
        Me.browse.BackgroundImage = Global.Group5System.My.Resources.Resources._1280px__Insert_image_here__svg
        Me.browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.browse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.browse.Location = New System.Drawing.Point(14, 17)
        Me.browse.Name = "browse"
        Me.browse.Size = New System.Drawing.Size(199, 184)
        Me.browse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.browse.TabIndex = 18
        Me.browse.TabStop = False
        '
        'browseImage
        '
        Me.browseImage.Location = New System.Drawing.Point(463, 357)
        Me.browseImage.Name = "browseImage"
        Me.browseImage.Size = New System.Drawing.Size(199, 29)
        Me.browseImage.TabIndex = 20
        Me.browseImage.Text = "[Browse Image]"
        Me.browseImage.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Position"
        '
        'tbpos
        '
        Me.tbpos.ForeColor = System.Drawing.Color.Black
        Me.tbpos.Location = New System.Drawing.Point(10, 32)
        Me.tbpos.Name = "tbpos"
        Me.tbpos.Size = New System.Drawing.Size(130, 22)
        Me.tbpos.TabIndex = 17
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.tbpos)
        Me.GroupBox6.Location = New System.Drawing.Point(15, 285)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(149, 65)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(118, 411)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(110, 32)
        Me.btnsave.TabIndex = 22
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(252, 411)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(110, 32)
        Me.btnupdate.TabIndex = 23
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(383, 411)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 32)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'empnum
        '
        Me.empnum.Enabled = False
        Me.empnum.ForeColor = System.Drawing.Color.Silver
        Me.empnum.Location = New System.Drawing.Point(186, 31)
        Me.empnum.Name = "empnum"
        Me.empnum.Size = New System.Drawing.Size(176, 22)
        Me.empnum.TabIndex = 25
        Me.empnum.Text = "[Auto]"
        Me.empnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(63, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Employee ID:"
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.Silver
        Me.TextBox1.Location = New System.Drawing.Point(210, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 22)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "0"
        Me.TextBox1.Visible = False
        '
        'tblstN
        '
        Me.tblstN.ForeColor = System.Drawing.Color.Silver
        Me.tblstN.Location = New System.Drawing.Point(10, 38)
        Me.tblstN.Name = "tblstN"
        Me.tblstN.Size = New System.Drawing.Size(164, 22)
        Me.tblstN.TabIndex = 9
        Me.tblstN.Text = "Last Name"
        '
        'ERegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(689, 463)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.empnum)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.browseImage)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ERegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ERegistration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.browse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbFrstN As System.Windows.Forms.TextBox
    Friend WithEvents tblMI As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Mstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSex As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbAddress As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents browse As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents browseImage As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbpos As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tbdate As System.Windows.Forms.TextBox
    Friend WithEvents MM As System.Windows.Forms.ComboBox
    Friend WithEvents yy As System.Windows.Forms.ComboBox
    Friend WithEvents DD As System.Windows.Forms.ComboBox
    Friend WithEvents empnum As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents tblstN As TextBox
End Class
