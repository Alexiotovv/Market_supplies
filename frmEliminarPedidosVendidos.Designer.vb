<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarPedidosVendidos
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
        Me.txtNumeroPedido = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.rbNumeroPedido = New System.Windows.Forms.RadioButton()
        Me.rbNumeroBoleta = New System.Windows.Forms.RadioButton()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.cmbTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.lblTipoComprobante = New System.Windows.Forms.Label()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar"
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroPedido.Location = New System.Drawing.Point(196, 14)
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.Size = New System.Drawing.Size(115, 26)
        Me.txtNumeroPedido.TabIndex = 2
        Me.txtNumeroPedido.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(908, 14)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(82, 40)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvLista.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Location = New System.Drawing.Point(15, 95)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(1103, 388)
        Me.dgvLista.TabIndex = 3
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(1012, 14)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(106, 40)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "&Anular Venta"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'rbNumeroPedido
        '
        Me.rbNumeroPedido.AutoSize = True
        Me.rbNumeroPedido.Location = New System.Drawing.Point(655, 44)
        Me.rbNumeroPedido.Name = "rbNumeroPedido"
        Me.rbNumeroPedido.Size = New System.Drawing.Size(150, 22)
        Me.rbNumeroPedido.TabIndex = 5
        Me.rbNumeroPedido.Text = "Número de Pedido"
        Me.rbNumeroPedido.UseVisualStyleBackColor = True
        '
        'rbNumeroBoleta
        '
        Me.rbNumeroBoleta.AutoSize = True
        Me.rbNumeroBoleta.Checked = True
        Me.rbNumeroBoleta.Location = New System.Drawing.Point(655, 16)
        Me.rbNumeroBoleta.Name = "rbNumeroBoleta"
        Me.rbNumeroBoleta.Size = New System.Drawing.Size(234, 22)
        Me.rbNumeroBoleta.TabIndex = 6
        Me.rbNumeroBoleta.TabStop = True
        Me.rbNumeroBoleta.Text = "Serie-Número de Comprobante"
        Me.rbNumeroBoleta.UseVisualStyleBackColor = True
        '
        'txtSerie
        '
        Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(226, 31)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(67, 26)
        Me.txtSerie.TabIndex = 0
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(299, 31)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(133, 26)
        Me.txtNumero.TabIndex = 1
        '
        'cmbTipoComprobante
        '
        Me.cmbTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoComprobante.FormattingEnabled = True
        Me.cmbTipoComprobante.Location = New System.Drawing.Point(454, 31)
        Me.cmbTipoComprobante.Name = "cmbTipoComprobante"
        Me.cmbTipoComprobante.Size = New System.Drawing.Size(195, 26)
        Me.cmbTipoComprobante.TabIndex = 7
        '
        'lblTipoComprobante
        '
        Me.lblTipoComprobante.AutoSize = True
        Me.lblTipoComprobante.Location = New System.Drawing.Point(478, 9)
        Me.lblTipoComprobante.Name = "lblTipoComprobante"
        Me.lblTipoComprobante.Size = New System.Drawing.Size(86, 18)
        Me.lblTipoComprobante.TabIndex = 8
        Me.lblTipoComprobante.Text = "Tipo Comp."
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(240, 10)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(42, 18)
        Me.lblSerie.TabIndex = 9
        Me.lblSerie.Text = "Serie"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(335, 10)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(62, 18)
        Me.lblNumero.TabIndex = 10
        Me.lblNumero.Text = "Número"
        '
        'frmEliminarPedidosVendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 495)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.lblSerie)
        Me.Controls.Add(Me.lblTipoComprobante)
        Me.Controls.Add(Me.cmbTipoComprobante)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.rbNumeroBoleta)
        Me.Controls.Add(Me.rbNumeroPedido)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtNumeroPedido)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEliminarPedidosVendidos"
        Me.Text = "frmAnularVenta"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumeroPedido As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvLista As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents rbNumeroPedido As RadioButton
    Friend WithEvents rbNumeroBoleta As RadioButton
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents cmbTipoComprobante As ComboBox
    Friend WithEvents lblTipoComprobante As Label
    Friend WithEvents lblSerie As Label
    Friend WithEvents lblNumero As Label
End Class
