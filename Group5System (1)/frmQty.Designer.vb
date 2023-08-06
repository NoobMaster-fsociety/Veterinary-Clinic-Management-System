<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQty
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Desc = New System.Windows.Forms.TextBox()
        Me.tbprice = New System.Windows.Forms.TextBox()
        Me.Categ = New System.Windows.Forms.TextBox()
        Me.tbStock = New System.Windows.Forms.TextBox()
        Me.tbformula = New System.Windows.Forms.TextBox()
        Me.invoice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.ForeColor = System.Drawing.Color.Black
        Me.txtQty.Location = New System.Drawing.Point(7, 6)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(212, 80)
        Me.txtQty.TabIndex = 3
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Desc
        '
        Me.Desc.Enabled = False
        Me.Desc.Location = New System.Drawing.Point(12, 12)
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(100, 20)
        Me.Desc.TabIndex = 4
        '
        'tbprice
        '
        Me.tbprice.Enabled = False
        Me.tbprice.Location = New System.Drawing.Point(12, 38)
        Me.tbprice.Name = "tbprice"
        Me.tbprice.Size = New System.Drawing.Size(100, 20)
        Me.tbprice.TabIndex = 5
        '
        'Categ
        '
        Me.Categ.Enabled = False
        Me.Categ.Location = New System.Drawing.Point(12, 64)
        Me.Categ.Name = "Categ"
        Me.Categ.Size = New System.Drawing.Size(100, 20)
        Me.Categ.TabIndex = 6
        '
        'tbStock
        '
        Me.tbStock.Enabled = False
        Me.tbStock.Location = New System.Drawing.Point(119, 38)
        Me.tbStock.Name = "tbStock"
        Me.tbStock.Size = New System.Drawing.Size(100, 20)
        Me.tbStock.TabIndex = 8
        '
        'tbformula
        '
        Me.tbformula.Enabled = False
        Me.tbformula.Location = New System.Drawing.Point(118, 64)
        Me.tbformula.Name = "tbformula"
        Me.tbformula.Size = New System.Drawing.Size(100, 20)
        Me.tbformula.TabIndex = 9
        '
        'invoice
        '
        Me.invoice.Enabled = False
        Me.invoice.Location = New System.Drawing.Point(118, 12)
        Me.invoice.Name = "invoice"
        Me.invoice.Size = New System.Drawing.Size(100, 20)
        Me.invoice.TabIndex = 10
        '
        'frmQty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 92)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.tbStock)
        Me.Controls.Add(Me.Categ)
        Me.Controls.Add(Me.tbprice)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.tbformula)
        Me.Controls.Add(Me.invoice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQty As TextBox
    Friend WithEvents Desc As TextBox
    Friend WithEvents tbprice As TextBox
    Friend WithEvents Categ As TextBox
    Friend WithEvents tbStock As TextBox
    Friend WithEvents tbformula As TextBox
    Friend WithEvents invoice As TextBox
End Class
