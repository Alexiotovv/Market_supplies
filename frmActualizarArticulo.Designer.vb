<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmActualizarArticulo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.txtInsumos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.rbCodBarra = New System.Windows.Forms.RadioButton()
        Me.dgvEntradas = New System.Windows.Forms.DataGridView()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.btnPunto = New System.Windows.Forms.Button()
        Me.btnCe = New System.Windows.Forms.Button()
        Me.btnNueve = New System.Windows.Forms.Button()
        Me.btnOcho = New System.Windows.Forms.Button()
        Me.btnCero = New System.Windows.Forms.Button()
        Me.btnSiete = New System.Windows.Forms.Button()
        Me.btnSeis = New System.Windows.Forms.Button()
        Me.btnCinco = New System.Windows.Forms.Button()
        Me.btnCuatro = New System.Windows.Forms.Button()
        Me.btnTres = New System.Windows.Forms.Button()
        Me.btnDos = New System.Windows.Forms.Button()
        Me.btnUno = New System.Windows.Forms.Button()
        Me.btnRegistrarIngreso = New System.Windows.Forms.Button()
        Me.btnMostrarTeclado = New System.Windows.Forms.Button()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvArticulos
        '
        Me.dgvArticulos.AllowUserToAddRows = False
        Me.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Location = New System.Drawing.Point(38, 63)
        Me.dgvArticulos.MultiSelect = False
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.ReadOnly = True
        Me.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArticulos.Size = New System.Drawing.Size(767, 156)
        Me.dgvArticulos.TabIndex = 29
        Me.dgvArticulos.Visible = False
        '
        'txtInsumos
        '
        Me.txtInsumos.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtInsumos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsumos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtInsumos.Location = New System.Drawing.Point(84, 18)
        Me.txtInsumos.Name = "txtInsumos"
        Me.txtInsumos.Size = New System.Drawing.Size(302, 26)
        Me.txtInsumos.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Búsqueda"
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombre.Location = New System.Drawing.Point(638, 12)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(119, 33)
        Me.rbNombre.TabIndex = 31
        Me.rbNombre.Text = "Nombre"
        Me.rbNombre.UseVisualStyleBackColor = True
        '
        'rbCodBarra
        '
        Me.rbCodBarra.AutoSize = True
        Me.rbCodBarra.Checked = True
        Me.rbCodBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCodBarra.Location = New System.Drawing.Point(404, 12)
        Me.rbCodBarra.Name = "rbCodBarra"
        Me.rbCodBarra.Size = New System.Drawing.Size(220, 33)
        Me.rbCodBarra.TabIndex = 30
        Me.rbCodBarra.TabStop = True
        Me.rbCodBarra.Text = "Codigo de Barras"
        Me.rbCodBarra.UseVisualStyleBackColor = True
        '
        'dgvEntradas
        '
        Me.dgvEntradas.AllowUserToAddRows = False
        Me.dgvEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvEntradas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvEntradas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEntradas.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEntradas.Location = New System.Drawing.Point(7, 101)
        Me.dgvEntradas.Name = "dgvEntradas"
        Me.dgvEntradas.ReadOnly = True
        Me.dgvEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEntradas.Size = New System.Drawing.Size(750, 354)
        Me.dgvEntradas.TabIndex = 42
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(1036, 383)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(170, 47)
        Me.txtCantidad.TabIndex = 86
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1094, 435)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 24)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Cantidad"
        '
        'btnMas
        '
        Me.btnMas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMas.Location = New System.Drawing.Point(1270, 380)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(53, 52)
        Me.btnMas.TabIndex = 84
        Me.btnMas.Text = "+"
        Me.btnMas.UseVisualStyleBackColor = True
        '
        'btnPunto
        '
        Me.btnPunto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPunto.Location = New System.Drawing.Point(1232, 287)
        Me.btnPunto.Name = "btnPunto"
        Me.btnPunto.Size = New System.Drawing.Size(92, 87)
        Me.btnPunto.TabIndex = 83
        Me.btnPunto.Text = "."
        Me.btnPunto.UseVisualStyleBackColor = True
        '
        'btnCe
        '
        Me.btnCe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCe.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCe.Location = New System.Drawing.Point(1134, 287)
        Me.btnCe.Name = "btnCe"
        Me.btnCe.Size = New System.Drawing.Size(92, 87)
        Me.btnCe.TabIndex = 82
        Me.btnCe.Text = "C"
        Me.btnCe.UseVisualStyleBackColor = True
        '
        'btnNueve
        '
        Me.btnNueve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNueve.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNueve.Location = New System.Drawing.Point(1232, 8)
        Me.btnNueve.Name = "btnNueve"
        Me.btnNueve.Size = New System.Drawing.Size(92, 87)
        Me.btnNueve.TabIndex = 81
        Me.btnNueve.Text = "9"
        Me.btnNueve.UseVisualStyleBackColor = True
        '
        'btnOcho
        '
        Me.btnOcho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOcho.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcho.Location = New System.Drawing.Point(1134, 8)
        Me.btnOcho.Name = "btnOcho"
        Me.btnOcho.Size = New System.Drawing.Size(92, 87)
        Me.btnOcho.TabIndex = 79
        Me.btnOcho.Text = "8"
        Me.btnOcho.UseVisualStyleBackColor = True
        '
        'btnCero
        '
        Me.btnCero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCero.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCero.Location = New System.Drawing.Point(1036, 287)
        Me.btnCero.Name = "btnCero"
        Me.btnCero.Size = New System.Drawing.Size(92, 87)
        Me.btnCero.TabIndex = 80
        Me.btnCero.Text = "0"
        Me.btnCero.UseVisualStyleBackColor = True
        '
        'btnSiete
        '
        Me.btnSiete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiete.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiete.Location = New System.Drawing.Point(1036, 8)
        Me.btnSiete.Name = "btnSiete"
        Me.btnSiete.Size = New System.Drawing.Size(92, 87)
        Me.btnSiete.TabIndex = 78
        Me.btnSiete.Text = "7"
        Me.btnSiete.UseVisualStyleBackColor = True
        '
        'btnSeis
        '
        Me.btnSeis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeis.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeis.Location = New System.Drawing.Point(1232, 101)
        Me.btnSeis.Name = "btnSeis"
        Me.btnSeis.Size = New System.Drawing.Size(92, 87)
        Me.btnSeis.TabIndex = 77
        Me.btnSeis.Text = "6"
        Me.btnSeis.UseVisualStyleBackColor = True
        '
        'btnCinco
        '
        Me.btnCinco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCinco.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCinco.Location = New System.Drawing.Point(1134, 101)
        Me.btnCinco.Name = "btnCinco"
        Me.btnCinco.Size = New System.Drawing.Size(92, 87)
        Me.btnCinco.TabIndex = 76
        Me.btnCinco.Text = "5"
        Me.btnCinco.UseVisualStyleBackColor = True
        '
        'btnCuatro
        '
        Me.btnCuatro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCuatro.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuatro.Location = New System.Drawing.Point(1036, 101)
        Me.btnCuatro.Name = "btnCuatro"
        Me.btnCuatro.Size = New System.Drawing.Size(92, 87)
        Me.btnCuatro.TabIndex = 75
        Me.btnCuatro.Text = "4"
        Me.btnCuatro.UseVisualStyleBackColor = True
        '
        'btnTres
        '
        Me.btnTres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTres.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTres.Location = New System.Drawing.Point(1232, 194)
        Me.btnTres.Name = "btnTres"
        Me.btnTres.Size = New System.Drawing.Size(92, 87)
        Me.btnTres.TabIndex = 74
        Me.btnTres.Text = "3"
        Me.btnTres.UseVisualStyleBackColor = True
        '
        'btnDos
        '
        Me.btnDos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDos.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDos.Location = New System.Drawing.Point(1134, 194)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(92, 87)
        Me.btnDos.TabIndex = 73
        Me.btnDos.Text = "2"
        Me.btnDos.UseVisualStyleBackColor = True
        '
        'btnUno
        '
        Me.btnUno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUno.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUno.Location = New System.Drawing.Point(1036, 194)
        Me.btnUno.Name = "btnUno"
        Me.btnUno.Size = New System.Drawing.Size(92, 87)
        Me.btnUno.TabIndex = 72
        Me.btnUno.Text = "1"
        Me.btnUno.UseVisualStyleBackColor = True
        '
        'btnRegistrarIngreso
        '
        Me.btnRegistrarIngreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarIngreso.Location = New System.Drawing.Point(843, 23)
        Me.btnRegistrarIngreso.Name = "btnRegistrarIngreso"
        Me.btnRegistrarIngreso.Size = New System.Drawing.Size(157, 64)
        Me.btnRegistrarIngreso.TabIndex = 87
        Me.btnRegistrarIngreso.Text = "&Registrar"
        Me.btnRegistrarIngreso.UseVisualStyleBackColor = True
        '
        'btnMostrarTeclado
        '
        Me.btnMostrarTeclado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMostrarTeclado.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarTeclado.Location = New System.Drawing.Point(843, 101)
        Me.btnMostrarTeclado.Name = "btnMostrarTeclado"
        Me.btnMostrarTeclado.Size = New System.Drawing.Size(157, 64)
        Me.btnMostrarTeclado.TabIndex = 88
        Me.btnMostrarTeclado.Text = "&Teclado"
        Me.btnMostrarTeclado.UseVisualStyleBackColor = True
        '
        'btnMenos
        '
        Me.btnMenos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenos.Location = New System.Drawing.Point(1211, 380)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(53, 52)
        Me.btnMenos.TabIndex = 89
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(843, 387)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(157, 68)
        Me.btnSalir.TabIndex = 90
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(843, 306)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(157, 68)
        Me.btnEliminar.TabIndex = 91
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'frmActualizarArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 515)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnMenos)
        Me.Controls.Add(Me.btnMostrarTeclado)
        Me.Controls.Add(Me.dgvArticulos)
        Me.Controls.Add(Me.btnRegistrarIngreso)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnMas)
        Me.Controls.Add(Me.btnPunto)
        Me.Controls.Add(Me.btnCe)
        Me.Controls.Add(Me.btnNueve)
        Me.Controls.Add(Me.btnOcho)
        Me.Controls.Add(Me.btnCero)
        Me.Controls.Add(Me.btnSiete)
        Me.Controls.Add(Me.btnSeis)
        Me.Controls.Add(Me.btnCinco)
        Me.Controls.Add(Me.btnCuatro)
        Me.Controls.Add(Me.btnTres)
        Me.Controls.Add(Me.btnDos)
        Me.Controls.Add(Me.btnUno)
        Me.Controls.Add(Me.rbNombre)
        Me.Controls.Add(Me.rbCodBarra)
        Me.Controls.Add(Me.txtInsumos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvEntradas)
        Me.Name = "frmActualizarArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione Material"
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents txtInsumos As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodBarra As System.Windows.Forms.RadioButton
    Friend WithEvents dgvEntradas As DataGridView
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnMas As Button
    Friend WithEvents btnPunto As Button
    Friend WithEvents btnCe As Button
    Friend WithEvents btnNueve As Button
    Friend WithEvents btnOcho As Button
    Friend WithEvents btnCero As Button
    Friend WithEvents btnSiete As Button
    Friend WithEvents btnSeis As Button
    Friend WithEvents btnCinco As Button
    Friend WithEvents btnCuatro As Button
    Friend WithEvents btnTres As Button
    Friend WithEvents btnDos As Button
    Friend WithEvents btnUno As Button
    Friend WithEvents btnRegistrarIngreso As Button
    Friend WithEvents btnMostrarTeclado As Button
    Friend WithEvents btnMenos As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
End Class
