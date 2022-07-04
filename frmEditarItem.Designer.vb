<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarItem
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbCodBarra = New System.Windows.Forms.RadioButton()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lbProdsalidasID = New System.Windows.Forms.Label()
        Me.lbProduct_ID = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbPruduct_Detalle_ID = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbCodBarra)
        Me.GroupBox2.Controls.Add(Me.rbNombre)
        Me.GroupBox2.Location = New System.Drawing.Point(614, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 43)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        '
        'rbCodBarra
        '
        Me.rbCodBarra.AutoSize = True
        Me.rbCodBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCodBarra.Location = New System.Drawing.Point(72, 15)
        Me.rbCodBarra.Name = "rbCodBarra"
        Me.rbCodBarra.Size = New System.Drawing.Size(103, 24)
        Me.rbCodBarra.TabIndex = 3
        Me.rbCodBarra.Text = "Cod. Barra"
        Me.rbCodBarra.UseVisualStyleBackColor = True
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Checked = True
        Me.rbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombre.Location = New System.Drawing.Point(181, 14)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(83, 24)
        Me.rbNombre.TabIndex = 4
        Me.rbNombre.TabStop = True
        Me.rbNombre.Text = "Nombre"
        Me.rbNombre.UseVisualStyleBackColor = True
        '
        'dgvArticulos
        '
        Me.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Location = New System.Drawing.Point(94, 42)
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvArticulos.Size = New System.Drawing.Size(683, 131)
        Me.dgvArticulos.TabIndex = 48
        Me.dgvArticulos.Visible = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBusqueda.Location = New System.Drawing.Point(85, 13)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(523, 24)
        Me.txtBusqueda.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Insumos"
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(783, 47)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 37)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "&Guardar Cambios"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(783, 90)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(132, 37)
        Me.btnCerrar.TabIndex = 52
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lbProdsalidasID
        '
        Me.lbProdsalidasID.AutoSize = True
        Me.lbProdsalidasID.Location = New System.Drawing.Point(10, 114)
        Me.lbProdsalidasID.Name = "lbProdsalidasID"
        Me.lbProdsalidasID.Size = New System.Drawing.Size(80, 13)
        Me.lbProdsalidasID.TabIndex = 53
        Me.lbProdsalidasID.Text = "lbProdsalidasID"
        Me.lbProdsalidasID.Visible = False
        '
        'lbProduct_ID
        '
        Me.lbProduct_ID.AutoSize = True
        Me.lbProduct_ID.Location = New System.Drawing.Point(10, 138)
        Me.lbProduct_ID.Name = "lbProduct_ID"
        Me.lbProduct_ID.Size = New System.Drawing.Size(69, 13)
        Me.lbProduct_ID.TabIndex = 56
        Me.lbProduct_ID.Text = "lbProduct_ID"
        Me.lbProduct_ID.Visible = False
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCantidad.Location = New System.Drawing.Point(85, 43)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(88, 24)
        Me.txtCantidad.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Cantidad"
        '
        'lbPruduct_Detalle_ID
        '
        Me.lbPruduct_Detalle_ID.AutoSize = True
        Me.lbPruduct_Detalle_ID.Location = New System.Drawing.Point(12, 162)
        Me.lbPruduct_Detalle_ID.Name = "lbPruduct_Detalle_ID"
        Me.lbPruduct_Detalle_ID.Size = New System.Drawing.Size(102, 13)
        Me.lbPruduct_Detalle_ID.TabIndex = 59
        Me.lbPruduct_Detalle_ID.Text = "lbPrudct_Detalle_ID"
        Me.lbPruduct_Detalle_ID.Visible = False
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(10, 90)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(39, 13)
        Me.lblPrecio.TabIndex = 60
        Me.lblPrecio.Text = "Label1"
        Me.lblPrecio.Visible = False
        '
        'frmEditarItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 178)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lbPruduct_Detalle_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbProduct_ID)
        Me.Controls.Add(Me.lbProdsalidasID)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvArticulos)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCantidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEditarItem"
        Me.Text = "Editar Item"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents dgvArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents lbProdsalidasID As System.Windows.Forms.Label
    Friend WithEvents lbProduct_ID As System.Windows.Forms.Label
    Friend WithEvents rbCodBarra As System.Windows.Forms.RadioButton
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbPruduct_Detalle_ID As Label
    Friend WithEvents lblPrecio As Label
End Class
