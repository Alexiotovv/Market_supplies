<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpuestosOtros
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreImpuesto = New System.Windows.Forms.TextBox()
        Me.txtPorcentajeImpuesto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtSimboloMoneda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreMoneda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMsjeAgradecer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkRedondeo = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Denominación del Impuesto"
        '
        'txtNombreImpuesto
        '
        Me.txtNombreImpuesto.Location = New System.Drawing.Point(225, 6)
        Me.txtNombreImpuesto.MaxLength = 5
        Me.txtNombreImpuesto.Name = "txtNombreImpuesto"
        Me.txtNombreImpuesto.Size = New System.Drawing.Size(112, 26)
        Me.txtNombreImpuesto.TabIndex = 1
        Me.txtNombreImpuesto.Text = "IGV"
        Me.txtNombreImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPorcentajeImpuesto
        '
        Me.txtPorcentajeImpuesto.Location = New System.Drawing.Point(225, 41)
        Me.txtPorcentajeImpuesto.Name = "txtPorcentajeImpuesto"
        Me.txtPorcentajeImpuesto.Size = New System.Drawing.Size(112, 26)
        Me.txtPorcentajeImpuesto.TabIndex = 3
        Me.txtPorcentajeImpuesto.Text = "0"
        Me.txtPorcentajeImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Porcentaje del Impuesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(340, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "%"
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(113, 240)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(112, 44)
        Me.btnGrabar.TabIndex = 5
        Me.btnGrabar.Text = "&Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(260, 240)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(112, 44)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtSimboloMoneda
        '
        Me.txtSimboloMoneda.Location = New System.Drawing.Point(225, 73)
        Me.txtSimboloMoneda.MaxLength = 4
        Me.txtSimboloMoneda.Name = "txtSimboloMoneda"
        Me.txtSimboloMoneda.Size = New System.Drawing.Size(112, 26)
        Me.txtSimboloMoneda.TabIndex = 8
        Me.txtSimboloMoneda.Text = "S/"
        Me.txtSimboloMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Símbolo Moneda"
        '
        'txtNombreMoneda
        '
        Me.txtNombreMoneda.Location = New System.Drawing.Point(225, 105)
        Me.txtNombreMoneda.MaxLength = 10
        Me.txtNombreMoneda.Name = "txtNombreMoneda"
        Me.txtNombreMoneda.Size = New System.Drawing.Size(112, 26)
        Me.txtNombreMoneda.TabIndex = 10
        Me.txtNombreMoneda.Text = "Soles"
        Me.txtNombreMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Denominación de Moneda"
        '
        'txtMsjeAgradecer
        '
        Me.txtMsjeAgradecer.Location = New System.Drawing.Point(225, 170)
        Me.txtMsjeAgradecer.MaxLength = 20
        Me.txtMsjeAgradecer.Multiline = True
        Me.txtMsjeAgradecer.Name = "txtMsjeAgradecer"
        Me.txtMsjeAgradecer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMsjeAgradecer.Size = New System.Drawing.Size(238, 45)
        Me.txtMsjeAgradecer.TabIndex = 29
        Me.txtMsjeAgradecer.Text = "Soles"
        Me.txtMsjeAgradecer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Mensaje Agradecimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Redondeo Importe a Pagar"
        '
        'chkRedondeo
        '
        Me.chkRedondeo.AutoSize = True
        Me.chkRedondeo.Location = New System.Drawing.Point(225, 140)
        Me.chkRedondeo.Name = "chkRedondeo"
        Me.chkRedondeo.Size = New System.Drawing.Size(103, 24)
        Me.chkRedondeo.TabIndex = 31
        Me.chkRedondeo.Text = "Redondeo"
        Me.chkRedondeo.UseVisualStyleBackColor = True
        '
        'frmImpuestosOtros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 306)
        Me.Controls.Add(Me.chkRedondeo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMsjeAgradecer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNombreMoneda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSimboloMoneda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPorcentajeImpuesto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreImpuesto)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmImpuestosOtros"
        Me.Text = "frmImpuestosOtros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreImpuesto As TextBox
    Friend WithEvents txtPorcentajeImpuesto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtSimboloMoneda As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombreMoneda As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMsjeAgradecer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents chkRedondeo As CheckBox
End Class
