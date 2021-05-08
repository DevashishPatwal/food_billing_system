<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class finall
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(finall))
        Me.order = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtfinal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdis = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'order
        '
        Me.order.BackColor = System.Drawing.Color.White
        Me.order.Location = New System.Drawing.Point(202, 218)
        Me.order.Margin = New System.Windows.Forms.Padding(2)
        Me.order.Name = "order"
        Me.order.Size = New System.Drawing.Size(85, 28)
        Me.order.TabIndex = 0
        Me.order.Text = "Order"
        Me.order.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Final Price including GST(12%)"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(282, 61)
        Me.txtprice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(105, 20)
        Me.txtprice.TabIndex = 3
        Me.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtfinal
        '
        Me.txtfinal.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtfinal.Location = New System.Drawing.Point(282, 99)
        Me.txtfinal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfinal.Name = "txtfinal"
        Me.txtfinal.Size = New System.Drawing.Size(105, 20)
        Me.txtfinal.TabIndex = 4
        Me.txtfinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(34, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Click Here For Discount (%)"
        '
        'txtdis
        '
        Me.txtdis.Location = New System.Drawing.Point(282, 131)
        Me.txtdis.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdis.Name = "txtdis"
        Me.txtdis.Size = New System.Drawing.Size(105, 20)
        Me.txtdis.TabIndex = 6
        Me.txtdis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtdis.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 164)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "After Discount"
        Me.Label4.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(282, 158)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(105, 20)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox4.Visible = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.White
        Me.back.Location = New System.Drawing.Point(100, 218)
        Me.back.Margin = New System.Windows.Forms.Padding(2)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(85, 28)
        Me.back.TabIndex = 9
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = False
        '
        'finall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(454, 267)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtfinal)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.order)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "finall"
        Me.Text = "Final Price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents order As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents txtfinal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdis As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents back As System.Windows.Forms.Button
End Class
