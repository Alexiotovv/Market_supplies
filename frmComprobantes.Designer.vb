<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobantes
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtComprobante = New System.Windows.Forms.TextBox()
        Me.nudNumero = New System.Windows.Forms.NumericUpDown()
        Me.nudSerie = New System.Windows.Forms.NumericUpDown()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.nudNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Número"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Serie"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(93, 18)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(100, 24)
        Me.txtId.TabIndex = 0
        '
        'txtComprobante
        '
        Me.txtComprobante.Location = New System.Drawing.Point(93, 56)
        Me.txtComprobante.Name = "txtComprobante"
        Me.txtComprobante.Size = New System.Drawing.Size(323, 24)
        Me.txtComprobante.TabIndex = 1
        '
        'nudNumero
        '
        Me.nudNumero.Location = New System.Drawing.Point(93, 132)
        Me.nudNumero.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudNumero.Name = "nudNumero"
        Me.nudNumero.Size = New System.Drawing.Size(116, 24)
        Me.nudNumero.TabIndex = 2
        Me.nudNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudSerie
        '
        Me.nudSerie.Location = New System.Drawing.Point(93, 94)
        Me.nudSerie.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nudSerie.Name = "nudSerie"
        Me.nudSerie.Size = New System.Drawing.Size(116, 24)
        Me.nudSerie.TabIndex = 3
        Me.nudSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(20, 173)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(113, 66)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(162, 173)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(113, 66)
        Me.btnGrabar.TabIndex = 4
        Me.btnGrabar.Text = "&Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(297, 173)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(113, 66)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 251)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.nudSerie)
        Me.Controls.Add(Me.nudNumero)
        Me.Controls.Add(Me.txtComprobante)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmComprobantes"
        Me.Text = "frmComprobantes"
        CType(Me.nudNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtComprobante As TextBox
    Friend WithEvents nudNumero As NumericUpDown
    Friend WithEvents nudSerie As NumericUpDown
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnSalir As Button
End Class
