<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Discountfrm
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
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtDIS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDisName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnsave.BackColor = System.Drawing.Color.DarkOrange
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsave.Location = New System.Drawing.Point(154, 167)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(69, 27)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'txtDIS
        '
        Me.txtDIS.Location = New System.Drawing.Point(123, 120)
        Me.txtDIS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDIS.Name = "txtDIS"
        Me.txtDIS.Size = New System.Drawing.Size(57, 20)
        Me.txtDIS.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Discount %:"
        '
        'txtDisName
        '
        Me.txtDisName.Location = New System.Drawing.Point(123, 74)
        Me.txtDisName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDisName.Name = "txtDisName"
        Me.txtDisName.Size = New System.Drawing.Size(220, 20)
        Me.txtDisName.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Discount Name:"
        '
        'Discountfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 207)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtDIS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDisName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Discountfrm"
        Me.Text = "Discountfrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsave As Button
    Friend WithEvents txtDIS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDisName As TextBox
    Friend WithEvents Label1 As Label
End Class
