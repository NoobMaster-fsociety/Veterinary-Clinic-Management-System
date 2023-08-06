<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settle
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
        Me.tbTotalA = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnchange = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbTotalA
        '
        Me.tbTotalA.BackColor = System.Drawing.Color.PapayaWhip
        Me.tbTotalA.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalA.Location = New System.Drawing.Point(109, 109)
        Me.tbTotalA.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tbTotalA.Name = "tbTotalA"
        Me.tbTotalA.Size = New System.Drawing.Size(212, 49)
        Me.tbTotalA.TabIndex = 0
        Me.tbTotalA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txttotal.Font = New System.Drawing.Font("Minecraftia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.Lime
        Me.txttotal.Location = New System.Drawing.Point(8, 29)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(212, 65)
        Me.txttotal.TabIndex = 1
        Me.txttotal.Text = "0.00"
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Amount"
        '
        'btnchange
        '
        Me.btnchange.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnchange.Font = New System.Drawing.Font("Minecraftia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchange.ForeColor = System.Drawing.Color.Lime
        Me.btnchange.Location = New System.Drawing.Point(225, 29)
        Me.btnchange.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnchange.Name = "btnchange"
        Me.btnchange.ReadOnly = True
        Me.btnchange.Size = New System.Drawing.Size(212, 65)
        Me.btnchange.TabIndex = 3
        Me.btnchange.Text = "0.00"
        Me.btnchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Settle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 173)
        Me.Controls.Add(Me.btnchange)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.tbTotalA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Settle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbTotalA As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnchange As TextBox
End Class
