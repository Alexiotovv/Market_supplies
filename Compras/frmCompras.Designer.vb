<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtIGV = New System.Windows.Forms.TextBox()
        Me.txtMontoTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.cmbTipoPago = New System.Windows.Forms.ComboBox()
        Me.dtpFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblIgv = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.dgvListaCompra = New System.Windows.Forms.DataGridView()
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_BARRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVaciar = New System.Windows.Forms.Button()
        Me.dgvBuscaProductos = New System.Windows.Forms.DataGridView()
        Me.lblNombreProveedor = New System.Windows.Forms.Label()
        Me.lblID_PROVEEDOR = New System.Windows.Forms.Label()
        CType(Me.dgvListaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBuscaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnRegistrar.Location = New System.Drawing.Point(276, 404)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(142, 55)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "&Guardar Compra"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código Barra o Nombre Producto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProducto
        '
        Me.txtProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(217, 11)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(470, 26)
        Me.txtProducto.TabIndex = 2
        Me.txtProducto.Tag = ""
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(917, 161)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(124, 22)
        Me.txtSerie.TabIndex = 6
        Me.txtSerie.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(937, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Serie"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(1068, 161)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(121, 22)
        Me.txtNumero.TabIndex = 8
        Me.txtNumero.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1065, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Número"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(914, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Documento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(696, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(31, 33)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "+"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(1037, 353)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(152, 22)
        Me.txtSubTotal.TabIndex = 13
        Me.txtSubTotal.Text = "0.00"
        '
        'txtIGV
        '
        Me.txtIGV.Location = New System.Drawing.Point(1037, 381)
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.Size = New System.Drawing.Size(152, 22)
        Me.txtIGV.TabIndex = 15
        Me.txtIGV.Text = "0.00"
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.BackColor = System.Drawing.Color.IndianRed
        Me.txtMontoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoTotal.ForeColor = System.Drawing.SystemColors.Window
        Me.txtMontoTotal.Location = New System.Drawing.Point(917, 16)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(280, 44)
        Me.txtMontoTotal.TabIndex = 17
        Me.txtMontoTotal.Text = "S/ 0.00"
        Me.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1065, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Tipo Pago"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.Items.AddRange(New Object() {"FACTURA", "BOLETA"})
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(920, 101)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(121, 24)
        Me.cmbTipoDocumento.TabIndex = 19
        '
        'cmbTipoPago
        '
        Me.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoPago.FormattingEnabled = True
        Me.cmbTipoPago.Items.AddRange(New Object() {"EFECTIVO", "CRÉDITO", "TARJETA"})
        Me.cmbTipoPago.Location = New System.Drawing.Point(1068, 101)
        Me.cmbTipoPago.Name = "cmbTipoPago"
        Me.cmbTipoPago.Size = New System.Drawing.Size(121, 24)
        Me.cmbTipoPago.TabIndex = 20
        '
        'dtpFechaCompra
        '
        Me.dtpFechaCompra.Location = New System.Drawing.Point(920, 225)
        Me.dtpFechaCompra.Name = "dtpFechaCompra"
        Me.dtpFechaCompra.Size = New System.Drawing.Size(269, 22)
        Me.dtpFechaCompra.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(914, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Fecha de Compra"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(914, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Proveedor"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(917, 285)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(272, 22)
        Me.txtProveedor.TabIndex = 10
        Me.txtProveedor.Tag = "Ruc o DNI"
        Me.txtProveedor.Text = "Ruc o DNI"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(919, 356)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "SubTotal"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIgv
        '
        Me.lblIgv.AutoSize = True
        Me.lblIgv.Location = New System.Drawing.Point(919, 384)
        Me.lblIgv.Name = "lblIgv"
        Me.lblIgv.Size = New System.Drawing.Size(30, 16)
        Me.lblIgv.TabIndex = 25
        Me.lblIgv.Text = "IGV"
        Me.lblIgv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(919, 412)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 16)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "TOTAL"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(1037, 409)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(152, 22)
        Me.txtTotal.TabIndex = 27
        Me.txtTotal.Text = "0.00"
        '
        'dgvListaCompra
        '
        Me.dgvListaCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvListaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM, Me.COD_BARRA, Me.CATEGORIA, Me.DESCRIPCION, Me.PRECIO, Me.CANTIDAD, Me.IMPORTE, Me.IDPRODUCTO})
        Me.dgvListaCompra.Location = New System.Drawing.Point(12, 43)
        Me.dgvListaCompra.Name = "dgvListaCompra"
        Me.dgvListaCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaCompra.Size = New System.Drawing.Size(896, 347)
        Me.dgvListaCompra.TabIndex = 28
        '
        'ITEM
        '
        Me.ITEM.HeaderText = "ITEM"
        Me.ITEM.Name = "ITEM"
        Me.ITEM.Width = 65
        '
        'COD_BARRA
        '
        Me.COD_BARRA.HeaderText = "CÓDIGO DE BARRA"
        Me.COD_BARRA.Name = "COD_BARRA"
        Me.COD_BARRA.Width = 143
        '
        'CATEGORIA
        '
        Me.CATEGORIA.HeaderText = "CATEGORÍA"
        Me.CATEGORIA.Name = "CATEGORIA"
        Me.CATEGORIA.Width = 111
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.HeaderText = "DESCRIPCIÓN"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Width = 124
        '
        'PRECIO
        '
        Me.PRECIO.HeaderText = "PRECIO"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.Width = 83
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANT."
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.Width = 73
        '
        'IMPORTE
        '
        Me.IMPORTE.HeaderText = "IMPORTE"
        Me.IMPORTE.Name = "IMPORTE"
        Me.IMPORTE.Width = 94
        '
        'IDPRODUCTO
        '
        Me.IDPRODUCTO.HeaderText = "ID_PROD"
        Me.IDPRODUCTO.Name = "IDPRODUCTO"
        Me.IDPRODUCTO.Width = 92
        '
        'btnVaciar
        '
        Me.btnVaciar.BackColor = System.Drawing.Color.IndianRed
        Me.btnVaciar.Location = New System.Drawing.Point(523, 404)
        Me.btnVaciar.Name = "btnVaciar"
        Me.btnVaciar.Size = New System.Drawing.Size(142, 55)
        Me.btnVaciar.TabIndex = 29
        Me.btnVaciar.Text = "&Vaciar Formulario"
        Me.btnVaciar.UseVisualStyleBackColor = False
        '
        'dgvBuscaProductos
        '
        Me.dgvBuscaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBuscaProductos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvBuscaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscaProductos.Location = New System.Drawing.Point(36, 35)
        Me.dgvBuscaProductos.Name = "dgvBuscaProductos"
        Me.dgvBuscaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBuscaProductos.Size = New System.Drawing.Size(711, 129)
        Me.dgvBuscaProductos.TabIndex = 30
        Me.dgvBuscaProductos.Visible = False
        '
        'lblNombreProveedor
        '
        Me.lblNombreProveedor.AutoSize = True
        Me.lblNombreProveedor.BackColor = System.Drawing.Color.Turquoise
        Me.lblNombreProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreProveedor.Location = New System.Drawing.Point(1019, 310)
        Me.lblNombreProveedor.Name = "lblNombreProveedor"
        Me.lblNombreProveedor.Size = New System.Drawing.Size(16, 16)
        Me.lblNombreProveedor.TabIndex = 31
        Me.lblNombreProveedor.Text = "--"
        Me.lblNombreProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblID_PROVEEDOR
        '
        Me.lblID_PROVEEDOR.AutoSize = True
        Me.lblID_PROVEEDOR.BackColor = System.Drawing.Color.Turquoise
        Me.lblID_PROVEEDOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID_PROVEEDOR.Location = New System.Drawing.Point(1077, 266)
        Me.lblID_PROVEEDOR.Name = "lblID_PROVEEDOR"
        Me.lblID_PROVEEDOR.Size = New System.Drawing.Size(114, 16)
        Me.lblID_PROVEEDOR.TabIndex = 32
        Me.lblID_PROVEEDOR.Text = "ID_PROVEEDOR"
        Me.lblID_PROVEEDOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblID_PROVEEDOR.Visible = False
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 469)
        Me.Controls.Add(Me.lblID_PROVEEDOR)
        Me.Controls.Add(Me.lblNombreProveedor)
        Me.Controls.Add(Me.dgvBuscaProductos)
        Me.Controls.Add(Me.btnVaciar)
        Me.Controls.Add(Me.dgvListaCompra)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblIgv)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpFechaCompra)
        Me.Controls.Add(Me.cmbTipoPago)
        Me.Controls.Add(Me.cmbTipoDocumento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMontoTotal)
        Me.Controls.Add(Me.txtIGV)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCompras"
        CType(Me.dgvListaCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBuscaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtIGV As TextBox
    Friend WithEvents txtMontoTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbTipoDocumento As ComboBox
    Friend WithEvents cmbTipoPago As ComboBox
    Friend WithEvents dtpFechaCompra As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblIgv As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents dgvListaCompra As DataGridView
    Friend WithEvents btnVaciar As Button
    Friend WithEvents dgvBuscaProductos As DataGridView
    Friend WithEvents lblNombreProveedor As Label
    Friend WithEvents lblID_PROVEEDOR As Label
    Friend WithEvents ITEM As DataGridViewTextBoxColumn
    Friend WithEvents COD_BARRA As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORIA As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE As DataGridViewTextBoxColumn
    Friend WithEvents IDPRODUCTO As DataGridViewTextBoxColumn
End Class
