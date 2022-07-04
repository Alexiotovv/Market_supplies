<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteCompras
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.rbSerieNumero = New System.Windows.Forms.RadioButton()
        Me.dgvListaCompras = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListaCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSerie)
        Me.GroupBox1.Controls.Add(Me.lblNumero)
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.lblDesde)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.txtSerie)
        Me.GroupBox1.Controls.Add(Me.rbFecha)
        Me.GroupBox1.Controls.Add(Me.rbSerieNumero)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(944, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Búsqueda"
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(335, 25)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(40, 16)
        Me.lblSerie.TabIndex = 11
        Me.lblSerie.Text = "Serie"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(559, 25)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(56, 16)
        Me.lblNumero.TabIndex = 10
        Me.lblNumero.Text = "Número"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(571, 59)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(44, 16)
        Me.lblHasta.TabIndex = 9
        Me.lblHasta.Text = "Hasta"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(326, 59)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(49, 16)
        Me.lblDesde.TabIndex = 8
        Me.lblDesde.Text = "Desde"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(620, 56)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(144, 22)
        Me.dtpFechaFinal.TabIndex = 7
        Me.dtpFechaFinal.Visible = False
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(823, 53)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(102, 31)
        Me.btnExportar.TabIndex = 6
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(823, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 31)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(380, 56)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(126, 22)
        Me.dtpFechaInicio.TabIndex = 4
        Me.dtpFechaInicio.Visible = False
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(620, 22)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(144, 22)
        Me.txtNumero.TabIndex = 3
        Me.txtNumero.Text = "0"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(380, 22)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(126, 22)
        Me.txtSerie.TabIndex = 2
        Me.txtSerie.Text = "0"
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Location = New System.Drawing.Point(19, 56)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(202, 20)
        Me.rbFecha.TabIndex = 1
        Me.rbFecha.Text = "Buscar por Rango de Fechas"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'rbSerieNumero
        '
        Me.rbSerieNumero.AutoSize = True
        Me.rbSerieNumero.Checked = True
        Me.rbSerieNumero.Location = New System.Drawing.Point(19, 21)
        Me.rbSerieNumero.Name = "rbSerieNumero"
        Me.rbSerieNumero.Size = New System.Drawing.Size(291, 20)
        Me.rbSerieNumero.TabIndex = 0
        Me.rbSerieNumero.TabStop = True
        Me.rbSerieNumero.Text = "Buscar por Serie y Número de Comprobante"
        Me.rbSerieNumero.UseVisualStyleBackColor = True
        '
        'dgvListaCompras
        '
        Me.dgvListaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaCompras.Location = New System.Drawing.Point(9, 122)
        Me.dgvListaCompras.Name = "dgvListaCompras"
        Me.dgvListaCompras.Size = New System.Drawing.Size(944, 351)
        Me.dgvListaCompras.TabIndex = 1
        '
        'frmReporteCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 488)
        Me.Controls.Add(Me.dgvListaCompras)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReporteCompras"
        Me.Text = "frmReporteCompras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListaCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents rbFecha As RadioButton
    Friend WithEvents rbSerieNumero As RadioButton
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvListaCompras As DataGridView
    Friend WithEvents btnExportar As Button
    Friend WithEvents lblSerie As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblHasta As Label
    Friend WithEvents lblDesde As Label
    Friend WithEvents dtpFechaFinal As DateTimePicker
End Class
