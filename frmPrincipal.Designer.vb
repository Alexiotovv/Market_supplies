<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.btnRealizarPedido = New System.Windows.Forms.Button()
        Me.btnDespacharPedido = New System.Windows.Forms.Button()
        Me.btnMateriales = New System.Windows.Forms.Button()
        Me.btnTrabajadores = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnIngresoSuministros = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArichvoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DespacharPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerMaterialesInsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDeSuministrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorregirÓrdenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalDeNamruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorProtocoloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockDeSuministrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminarProductoDespachadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarListaDePedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasAnuladasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaDeHoyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegistrarUnaCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReimpresiónDeTicketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarDatosDeLaEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpuestosYOtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrAvisoInsumos = New System.Windows.Forms.Timer(Me.components)
        Me.Insumos = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.tmrAvisoVencimiento = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRealizarPedido
        '
        Me.btnRealizarPedido.BackColor = System.Drawing.SystemColors.Control
        Me.btnRealizarPedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRealizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRealizarPedido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealizarPedido.Location = New System.Drawing.Point(77, 56)
        Me.btnRealizarPedido.Name = "btnRealizarPedido"
        Me.btnRealizarPedido.Size = New System.Drawing.Size(216, 124)
        Me.btnRealizarPedido.TabIndex = 0
        Me.btnRealizarPedido.Text = "Realizar Ventas"
        Me.btnRealizarPedido.UseVisualStyleBackColor = False
        '
        'btnDespacharPedido
        '
        Me.btnDespacharPedido.BackColor = System.Drawing.SystemColors.Control
        Me.btnDespacharPedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDespacharPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDespacharPedido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDespacharPedido.Location = New System.Drawing.Point(311, 56)
        Me.btnDespacharPedido.Name = "btnDespacharPedido"
        Me.btnDespacharPedido.Size = New System.Drawing.Size(216, 124)
        Me.btnDespacharPedido.TabIndex = 1
        Me.btnDespacharPedido.Text = "Despachar Pedidos No Entregados"
        Me.btnDespacharPedido.UseVisualStyleBackColor = False
        '
        'btnMateriales
        '
        Me.btnMateriales.BackColor = System.Drawing.SystemColors.Control
        Me.btnMateriales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMateriales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnMateriales.Location = New System.Drawing.Point(543, 56)
        Me.btnMateriales.Name = "btnMateriales"
        Me.btnMateriales.Size = New System.Drawing.Size(216, 124)
        Me.btnMateriales.TabIndex = 2
        Me.btnMateriales.Text = "Materiales"
        Me.btnMateriales.UseVisualStyleBackColor = False
        '
        'btnTrabajadores
        '
        Me.btnTrabajadores.BackColor = System.Drawing.SystemColors.Control
        Me.btnTrabajadores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTrabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTrabajadores.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTrabajadores.Location = New System.Drawing.Point(194, 201)
        Me.btnTrabajadores.Name = "btnTrabajadores"
        Me.btnTrabajadores.Size = New System.Drawing.Size(216, 124)
        Me.btnTrabajadores.TabIndex = 3
        Me.btnTrabajadores.Text = "Clientes"
        Me.btnTrabajadores.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(666, 429)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(150, 35)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Salir"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnIngresoSuministros
        '
        Me.btnIngresoSuministros.BackColor = System.Drawing.SystemColors.Control
        Me.btnIngresoSuministros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresoSuministros.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIngresoSuministros.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnIngresoSuministros.Location = New System.Drawing.Point(430, 201)
        Me.btnIngresoSuministros.Name = "btnIngresoSuministros"
        Me.btnIngresoSuministros.Size = New System.Drawing.Size(216, 124)
        Me.btnIngresoSuministros.TabIndex = 5
        Me.btnIngresoSuministros.Text = "Ingreso de Materiales"
        Me.btnIngresoSuministros.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 448)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(138, 448)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(271, 448)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(326, 448)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArichvoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(855, 28)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArichvoToolStripMenuItem
        '
        Me.ArichvoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RealizarPedidoToolStripMenuItem, Me.DespacharPedidoToolStripMenuItem, Me.VerMaterialesInsumosToolStripMenuItem, Me.IngresoDeSuministrosToolStripMenuItem, Me.CorregirÓrdenesToolStripMenuItem, Me.PersonalDeNamruToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArichvoToolStripMenuItem.Name = "ArichvoToolStripMenuItem"
        Me.ArichvoToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ArichvoToolStripMenuItem.Text = "Acciones"
        '
        'RealizarPedidoToolStripMenuItem
        '
        Me.RealizarPedidoToolStripMenuItem.Name = "RealizarPedidoToolStripMenuItem"
        Me.RealizarPedidoToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.RealizarPedidoToolStripMenuItem.Text = "Realizar Venta"
        '
        'DespacharPedidoToolStripMenuItem
        '
        Me.DespacharPedidoToolStripMenuItem.Name = "DespacharPedidoToolStripMenuItem"
        Me.DespacharPedidoToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.DespacharPedidoToolStripMenuItem.Text = "Despachar Pedido"
        '
        'VerMaterialesInsumosToolStripMenuItem
        '
        Me.VerMaterialesInsumosToolStripMenuItem.Name = "VerMaterialesInsumosToolStripMenuItem"
        Me.VerMaterialesInsumosToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.VerMaterialesInsumosToolStripMenuItem.Text = "Ver Artículos"
        '
        'IngresoDeSuministrosToolStripMenuItem
        '
        Me.IngresoDeSuministrosToolStripMenuItem.Name = "IngresoDeSuministrosToolStripMenuItem"
        Me.IngresoDeSuministrosToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.IngresoDeSuministrosToolStripMenuItem.Text = "Ingreso de Suministros"
        '
        'CorregirÓrdenesToolStripMenuItem
        '
        Me.CorregirÓrdenesToolStripMenuItem.Name = "CorregirÓrdenesToolStripMenuItem"
        Me.CorregirÓrdenesToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.CorregirÓrdenesToolStripMenuItem.Text = "Corregir Pedidos"
        '
        'PersonalDeNamruToolStripMenuItem
        '
        Me.PersonalDeNamruToolStripMenuItem.Name = "PersonalDeNamruToolStripMenuItem"
        Me.PersonalDeNamruToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.PersonalDeNamruToolStripMenuItem.Text = "Usuarios"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorProtocoloToolStripMenuItem, Me.StockDeSuministrosToolStripMenuItem, Me.ToolStripSeparator2, Me.EliminarProductoDespachadoToolStripMenuItem, Me.EliminarListaDePedidoToolStripMenuItem, Me.VentasAnuladasToolStripMenuItem, Me.VentaDeHoyToolStripMenuItem, Me.ToolStripSeparator3, Me.RegistrarUnaCompraToolStripMenuItem, Me.ReportesComprasToolStripMenuItem, Me.ToolStripSeparator1, Me.ReimpresiónDeTicketsToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.ReportesToolStripMenuItem.Text = "Utilidades"
        '
        'PorProtocoloToolStripMenuItem
        '
        Me.PorProtocoloToolStripMenuItem.Name = "PorProtocoloToolStripMenuItem"
        Me.PorProtocoloToolStripMenuItem.Size = New System.Drawing.Size(291, 24)
        Me.PorProtocoloToolStripMenuItem.Text = "Todos los Productos x Categoría"
        '
        'StockDeSuministrosToolStripMenuItem
        '
        Me.StockDeSuministrosToolStripMenuItem.Name = "StockDeSuministrosToolStripMenuItem"
        Me.StockDeSuministrosToolStripMenuItem.Size = New System.Drawing.Size(291, 24)
        Me.StockDeSuministrosToolStripMenuItem.Text = "Stock de Suministros"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(288, 6)
        '
        'EliminarProductoDespachadoToolStripMenuItem
        '
        Me.EliminarProductoDespachadoToolStripMenuItem.Name = "EliminarProductoDespachadoToolStripMenuItem"
        Me.EliminarProductoDespachadoToolStripMenuItem.Size = New System.Drawing.Size(291, 24)
        Me.EliminarProductoDespachadoToolStripMenuItem.Text = "Eliminar Producto Vendido"
        '
        'EliminarListaDePedidoToolStripMenuItem
        '
        Me.EliminarListaDePedidoToolStripMenuItem.Name = "EliminarListaDePedidoToolStripMenuItem"
        Me.EliminarListaDePedidoToolStripMenuItem.Size = New System.Drawing.Size(291, 24)
        Me.EliminarListaDePedidoToolStripMenuItem.Text = "Anular una Venta"
        '
        'VentasAnuladasToolStripMenuItem
        '
        Me.VentasAnuladasToolStripMenuItem.Name = "VentasAnuladasToolStripMenuItem"
        Me.VentasAnuladasToolStripMenuItem.Size = New System.Drawing.Size(291, 24)
        Me.VentasAnuladasToolStripMenuItem.Text = "Ventas Anuladas"
        '
        'VentaDeHoyToolStripMenuItem
        '
        Me.VentaDeHoyToolStripMenuItem.Name = "VentaDeHoyToolStripMenuItem"
        Me.VentaDeHoyToolStripMenuItem.Size = New System.Drawing.Size(291, 24)
        Me.VentaDeHoyToolStripMenuItem.Text = "Ventas Realizadas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(288, 6)
        '
        'RegistrarUnaCompraToolStripMenuItem
        '
        Me.RegistrarUnaCompraToolStripMenuItem.Name = "RegistrarUnaCompraToolStripMenuItem"
        Me.RegistrarUnaCompraToolStripMenuItem.Size = New System.Drawing.Size(291, 24)
        Me.RegistrarUnaCompraToolStripMenuItem.Text = "Registrar Compra"
        '
        'ReportesComprasToolStripMenuItem
        '
        Me.ReportesComprasToolStripMenuItem.Name = "ReportesComprasToolStripMenuItem"
        Me.ReportesComprasToolStripMenuItem.Size = New System.Drawing.Size(291, 24)
        Me.ReportesComprasToolStripMenuItem.Text = "Reportes Compras"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(288, 6)
        '
        'ReimpresiónDeTicketsToolStripMenuItem
        '
        Me.ReimpresiónDeTicketsToolStripMenuItem.Name = "ReimpresiónDeTicketsToolStripMenuItem"
        Me.ReimpresiónDeTicketsToolStripMenuItem.Size = New System.Drawing.Size(291, 24)
        Me.ReimpresiónDeTicketsToolStripMenuItem.Text = "Reimpresión de Comprobantes"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUsuarioToolStripMenuItem, Me.ContactoToolStripMenuItem, Me.RegistrarDatosDeLaEmpresaToolStripMenuItem, Me.ComprobantesToolStripMenuItem, Me.ImpuestosYOtrosToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'AgregarUsuarioToolStripMenuItem
        '
        Me.AgregarUsuarioToolStripMenuItem.Name = "AgregarUsuarioToolStripMenuItem"
        Me.AgregarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(215, 24)
        Me.AgregarUsuarioToolStripMenuItem.Text = "Usuarios"
        '
        'ContactoToolStripMenuItem
        '
        Me.ContactoToolStripMenuItem.Name = "ContactoToolStripMenuItem"
        Me.ContactoToolStripMenuItem.Size = New System.Drawing.Size(215, 24)
        Me.ContactoToolStripMenuItem.Text = "Contacto..."
        '
        'RegistrarDatosDeLaEmpresaToolStripMenuItem
        '
        Me.RegistrarDatosDeLaEmpresaToolStripMenuItem.Name = "RegistrarDatosDeLaEmpresaToolStripMenuItem"
        Me.RegistrarDatosDeLaEmpresaToolStripMenuItem.Size = New System.Drawing.Size(215, 24)
        Me.RegistrarDatosDeLaEmpresaToolStripMenuItem.Text = "Datos de la Empresa"
        '
        'ComprobantesToolStripMenuItem
        '
        Me.ComprobantesToolStripMenuItem.Name = "ComprobantesToolStripMenuItem"
        Me.ComprobantesToolStripMenuItem.Size = New System.Drawing.Size(215, 24)
        Me.ComprobantesToolStripMenuItem.Text = "Comprobantes"
        '
        'ImpuestosYOtrosToolStripMenuItem
        '
        Me.ImpuestosYOtrosToolStripMenuItem.Name = "ImpuestosYOtrosToolStripMenuItem"
        Me.ImpuestosYOtrosToolStripMenuItem.Size = New System.Drawing.Size(215, 24)
        Me.ImpuestosYOtrosToolStripMenuItem.Text = "Impuestos y Otros"
        '
        'tmrAvisoInsumos
        '
        Me.tmrAvisoInsumos.Enabled = True
        Me.tmrAvisoInsumos.Interval = 1000
        '
        'Insumos
        '
        Me.Insumos.Icon = CType(resources.GetObject("Insumos.Icon"), System.Drawing.Icon)
        Me.Insumos.Text = "NotifyIcon1"
        Me.Insumos.Visible = True
        '
        'tmrAvisoVencimiento
        '
        Me.tmrAvisoVencimiento.Enabled = True
        Me.tmrAvisoVencimiento.Interval = 1000
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(855, 495)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIngresoSuministros)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnTrabajadores)
        Me.Controls.Add(Me.btnMateriales)
        Me.Controls.Add(Me.btnDespacharPedido)
        Me.Controls.Add(Me.btnRealizarPedido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main-XiotoSistemas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRealizarPedido As System.Windows.Forms.Button
    Friend WithEvents btnDespacharPedido As System.Windows.Forms.Button
    Friend WithEvents btnMateriales As System.Windows.Forms.Button
    Friend WithEvents btnTrabajadores As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnIngresoSuministros As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArichvoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DespacharPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerMaterialesInsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoDeSuministrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalDeNamruToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorProtocoloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmrAvisoInsumos As Timer
    Friend WithEvents Insumos As NotifyIcon
    Friend WithEvents StockDeSuministrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarProductoDespachadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmrAvisoVencimiento As Timer
    Friend WithEvents CorregirÓrdenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaDeHoyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarListaDePedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarDatosDeLaEmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprobantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpuestosYOtrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ReimpresiónDeTicketsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents VentasAnuladasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents RegistrarUnaCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesComprasToolStripMenuItem As ToolStripMenuItem
End Class
