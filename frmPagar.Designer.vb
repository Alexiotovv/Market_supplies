<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rbEfectivo = New System.Windows.Forms.RadioButton()
        Me.rbTarjeta = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalPagar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVuelto = New System.Windows.Forms.TextBox()
        Me.btnGrabarPago = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rbEfectivo
        '
        Me.rbEfectivo.AutoSize = True
        Me.rbEfectivo.Checked = True
        Me.rbEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEfectivo.Location = New System.Drawing.Point(26, 12)
        Me.rbEfectivo.Name = "rbEfectivo"
        Me.rbEfectivo.Size = New System.Drawing.Size(94, 28)
        Me.rbEfectivo.TabIndex = 2
        Me.rbEfectivo.TabStop = True
        Me.rbEfectivo.Text = "Efectivo"
        Me.rbEfectivo.UseVisualStyleBackColor = True
        '
        'rbTarjeta
        '
        Me.rbTarjeta.AutoSize = True
        Me.rbTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTarjeta.Location = New System.Drawing.Point(186, 12)
        Me.rbTarjeta.Name = "rbTarjeta"
        Me.rbTarjeta.Size = New System.Drawing.Size(85, 28)
        Me.rbTarjeta.TabIndex = 3
        Me.rbTarjeta.Text = "Tarjeta"
        Me.rbTarjeta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Efectivo"
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.BackColor = System.Drawing.Color.Aqua
        Me.txtTotalPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPagar.ForeColor = System.Drawing.Color.Red
        Me.txtTotalPagar.Location = New System.Drawing.Point(183, 64)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.ReadOnly = True
        Me.txtTotalPagar.Size = New System.Drawing.Size(185, 62)
        Me.txtTotalPagar.TabIndex = 3
        Me.txtTotalPagar.TabStop = False
        Me.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Vuelto"
        '
        'txtEfectivo
        '
        Me.txtEfectivo.BackColor = System.Drawing.Color.Aqua
        Me.txtEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectivo.Location = New System.Drawing.Point(183, 131)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(185, 47)
        Me.txtEfectivo.TabIndex = 0
        Me.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total a Pagar"
        '
        'txtVuelto
        '
        Me.txtVuelto.BackColor = System.Drawing.Color.Aqua
        Me.txtVuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVuelto.Location = New System.Drawing.Point(183, 188)
        Me.txtVuelto.Name = "txtVuelto"
        Me.txtVuelto.ReadOnly = True
        Me.txtVuelto.Size = New System.Drawing.Size(185, 47)
        Me.txtVuelto.TabIndex = 7
        Me.txtVuelto.TabStop = False
        Me.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnGrabarPago
        '
        Me.btnGrabarPago.BackColor = System.Drawing.Color.Silver
        Me.btnGrabarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabarPago.Location = New System.Drawing.Point(99, 262)
        Me.btnGrabarPago.Name = "btnGrabarPago"
        Me.btnGrabarPago.Size = New System.Drawing.Size(269, 79)
        Me.btnGrabarPago.TabIndex = 1
        Me.btnGrabarPago.Text = "Pagar"
        Me.btnGrabarPago.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(132, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 39)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "S/"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(132, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 39)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "S/"
        '
        'frmPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 353)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGrabarPago)
        Me.Controls.Add(Me.txtVuelto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEfectivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalPagar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbTarjeta)
        Me.Controls.Add(Me.rbEfectivo)
        Me.Name = "frmPagar"
        Me.Text = "frmPagar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbEfectivo As RadioButton
    Friend WithEvents rbTarjeta As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalPagar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEfectivo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVuelto As TextBox
    Friend WithEvents btnGrabarPago As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
