<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentasdelDia
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
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.rbVentasHoy = New System.Windows.Forms.RadioButton()
        Me.rbOtrasFechas = New System.Windows.Forms.RadioButton()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.lblRangoFechas = New System.Windows.Forms.Label()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(652, 25)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(155, 64)
        Me.btnMostrar.TabIndex = 0
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'rbVentasHoy
        '
        Me.rbVentasHoy.AutoSize = True
        Me.rbVentasHoy.Checked = True
        Me.rbVentasHoy.Location = New System.Drawing.Point(13, 13)
        Me.rbVentasHoy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbVentasHoy.Name = "rbVentasHoy"
        Me.rbVentasHoy.Size = New System.Drawing.Size(114, 22)
        Me.rbVentasHoy.TabIndex = 2
        Me.rbVentasHoy.TabStop = True
        Me.rbVentasHoy.Text = "Venta de Hoy"
        Me.rbVentasHoy.UseVisualStyleBackColor = True
        '
        'rbOtrasFechas
        '
        Me.rbOtrasFechas.AutoSize = True
        Me.rbOtrasFechas.Location = New System.Drawing.Point(13, 51)
        Me.rbOtrasFechas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbOtrasFechas.Name = "rbOtrasFechas"
        Me.rbOtrasFechas.Size = New System.Drawing.Size(185, 22)
        Me.rbOtrasFechas.TabIndex = 3
        Me.rbOtrasFechas.Text = "Ventas de Otras Fechas"
        Me.rbOtrasFechas.UseVisualStyleBackColor = True
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(209, 31)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(150, 24)
        Me.dtpFechaInicio.TabIndex = 4
        Me.dtpFechaInicio.Value = New Date(2020, 4, 18, 0, 0, 0, 0)
        Me.dtpFechaInicio.Visible = False
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(209, 66)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(150, 24)
        Me.dtpFechaFinal.TabIndex = 5
        Me.dtpFechaFinal.Value = New Date(2020, 4, 18, 0, 0, 0, 0)
        Me.dtpFechaFinal.Visible = False
        '
        'dgvVentas
        '
        Me.dgvVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(13, 96)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        Me.dgvVentas.Size = New System.Drawing.Size(1183, 451)
        Me.dgvVentas.TabIndex = 6
        '
        'lblRangoFechas
        '
        Me.lblRangoFechas.AutoSize = True
        Me.lblRangoFechas.Location = New System.Drawing.Point(206, 9)
        Me.lblRangoFechas.Name = "lblRangoFechas"
        Me.lblRangoFechas.Size = New System.Drawing.Size(125, 18)
        Me.lblRangoFechas.TabIndex = 7
        Me.lblRangoFechas.Text = "Rango de Fechas"
        Me.lblRangoFechas.Visible = False
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(831, 25)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(155, 64)
        Me.btnExportar.TabIndex = 8
        Me.btnExportar.Text = "Exportar Excel"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(450, 42)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(147, 35)
        Me.txtTotal.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(480, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "VentaTotal"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(993, 51)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(203, 23)
        Me.ProgressBar1.TabIndex = 13
        Me.ProgressBar1.Visible = False
        '
        'frmVentasdelDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 559)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.lblRangoFechas)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.rbOtrasFechas)
        Me.Controls.Add(Me.rbVentasHoy)
        Me.Controls.Add(Me.btnMostrar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmVentasdelDia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVentasdelDia"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMostrar As Button
    Friend WithEvents rbVentasHoy As RadioButton
    Friend WithEvents rbOtrasFechas As RadioButton
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents lblRangoFechas As Label
    Friend WithEvents btnExportar As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
