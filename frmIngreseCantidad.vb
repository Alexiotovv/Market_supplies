Imports System.Data.OleDb
Public Class frmIngreseCantidad
    Dim adp As New OleDbDataAdapter
    Dim cmd As New OleDbCommand

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            adp = New OleDbDataAdapter("select ID,protocolo as PROTOCOLO,precio_venta as PRECIO,fecha as FVcmto,cantidad as STOCK,lote as LOTE from products_detalle where id_products=" & id_product & " and vigente='Si' order by protocolo", bd)
            Dim ds As New DataSet
            adp.Fill(ds, "products_detalle")
            DgvProductsDetalle.DataSource = ds.Tables(0)
            DgvProductsDetalle.Columns.Item(0).Visible = False 'ID_PRODUCT
            DgvProductsDetalle.Columns.Item(1).Visible = False 'PROTOCOLO
            DgvProductsDetalle.Columns.Item(2).Width = 170 'PRECIO VENTA
            DgvProductsDetalle.Columns.Item(3).Visible = False 'FECHA VCMTO
            DgvProductsDetalle.Columns.Item(4).Width = 200 'STOCK
            DgvProductsDetalle.Columns.Item(5).Visible = False 'LOTE
            'DgvProductsDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            txtCantidad.Focus()

            If DgvProductsDetalle.RowCount >= 1 Then
                'DgvProductsDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DgvProductsDetalle.CurrentCell = DgvProductsDetalle.Item(2, 0)
            End If
            txtCantidad.Text = 1
            txtCantidad.SelectionStart = 0
            txtCantidad.SelectionLength = txtCantidad.Text.Length
            'DgvProductsDetalle.Rows(0).Height = 150
        Catch ex As Exception

        End Try

    End Sub
    Public Sub aceptar()
        Try
            If txtCantidad.Text.Trim = "" Then
                MsgBox("Debe ingresar un numero porfavor,", vbInformation, "Insumos")
                Exit Sub
            End If
            For X = 1 To txtCantidad.Text.Trim.Length
                If Mid(txtCantidad.Text, X, 1) = "1" Or Mid(txtCantidad.Text, X, 1) = "2" Or Mid(txtCantidad.Text, X, 1) = "3" Or Mid(txtCantidad.Text, X, 1) = "4" Or Mid(txtCantidad.Text, X, 1) = "5" Or Mid(txtCantidad.Text, X, 1) = "6" Or Mid(txtCantidad.Text, X, 1) = "7" Or Mid(txtCantidad.Text, X, 1) = "8" Or Mid(txtCantidad.Text, X, 1) = "9" Or Mid(txtCantidad.Text, X, 1) = "0" Or Mid(txtCantidad.Text, X, 1) = "." Then
                Else
                    MsgBox("No es un nummero valido, porfavor ingrese un numero correcto", vbExclamation, "Insumos")
                    Exit Sub
                End If
            Next
            If modo = "3" Then 'pregunta si vino desde la ventana de ingreso de suministros

            Else
                If llave_orden = "editar" Then
                    'ID_PRODSALIDAS
                    frmEditarItem.lbProdsalidasID.Text = frmCorregirOrden.DataGridView1.Item(0, frmCorregirOrden.DataGridView1.CurrentCell.RowIndex).Value
                    'ID_PRODUCT
                    frmEditarItem.lbProduct_ID.Text = frmEditarItem.dgvArticulos.Item(0, frmEditarItem.dgvArticulos.CurrentCell.RowIndex).Value
                    'ID_PRODUCT_DETALLE
                    frmEditarItem.lbPruduct_Detalle_ID.Text = DgvProductsDetalle.Item(0, DgvProductsDetalle.CurrentCell.RowIndex).Value
                    'NOMBRE DE PRODUCTO
                    frmEditarItem.txtBusqueda.Text = frmEditarItem.dgvArticulos.Item(3, frmEditarItem.dgvArticulos.CurrentCell.RowIndex).Value
                    'CANTIDAD
                    frmEditarItem.txtCantidad.Text = txtCantidad.Text

                    frmEditarItem.dgvArticulos.Visible = False
                    txtCantidad.Text = ""
                    Me.Close()
                ElseIf llave_orden = "agregar" Then
                    'ORDEN_ID
                    '---->Se enuentra en el Combobox1.Text del frmCorregirOrden
                    'ID_EMPLOYEE
                    '----->Se encuentra en el DataGridView1 del frmCorregirOrden.DatagridView1.Item(5,1).Value
                    'ID_PRODUCT
                    frmEditarItem.lbProduct_ID.Text = frmEditarItem.dgvArticulos.Item(0, frmEditarItem.dgvArticulos.CurrentCell.RowIndex).Value
                    'ID_PRODUCTS_DETALLE
                    frmEditarItem.lbPruduct_Detalle_ID.Text = DgvProductsDetalle.Item(0, DgvProductsDetalle.CurrentCell.RowIndex).Value
                    'NOMBRE DE PRODUCTO
                    frmEditarItem.txtBusqueda.Text = frmEditarItem.dgvArticulos.Item(3, frmEditarItem.dgvArticulos.CurrentCell.RowIndex).Value
                    'CANTIDAD
                    frmEditarItem.txtCantidad.Text = txtCantidad.Text
                    frmEditarItem.dgvArticulos.Visible = False
                    Me.Close()
                    'FECHSALIDA
                    '----->La fecha de Salida es la de Hoy DIA ToDay
                    'DESPACHADO
                    '"no"
                    'USU
                    'el usuario es USU
                ElseIf llave_orden = "ingreso" Then
                    'registra en la tabla de entradas
                    cmd = New OleDbCommand("insert into prodentradas(id_products,id_products_detalle,cantidad,fechentrada,confirmado,usu) values (" & id_product & "," & DgvProductsDetalle.Item(0, DgvProductsDetalle.CurrentCell.RowIndex).Value & "," & txtCantidad.Text.Trim & ",'" & Today & "','Si','" & usu & "')", bd)
                    cmd.ExecuteNonQuery()
                    'actualiza el producto en la tabla de detalle products
                    cmd = New OleDbCommand("update products_detalle set cantidad=cantidad+" & txtCantidad.Text & " where ID=" & DgvProductsDetalle.Item(0, DgvProductsDetalle.CurrentCell.RowIndex).Value & "", bd)
                    cmd.ExecuteNonQuery()
                    frmActualizarArticulo.txtInsumos.Text = ""
                    frmActualizarArticulo.txtInsumos.Focus()
                    MsgBox("El Stock del Producto ha sido Actualizado", vbInformation)
                    Me.Close()

                ElseIf llave_orden = "pedido" Then ' este else es por que viene de la ventana principal de pedidos

                    AceptarCantidad()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error controlado, contactese con el administrador de sistemas")
        End Try
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.GotFocus
        txtCantidad.BackColor = Color.GreenYellow
    End Sub

    Private Sub txtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
        Try
            If e.KeyCode = 40 Then
                If (DgvProductsDetalle.CurrentCell.RowIndex < DgvProductsDetalle.RowCount - 2) Then
                    DgvProductsDetalle.CurrentCell = DgvProductsDetalle.Item(0, DgvProductsDetalle.CurrentCell.RowIndex + 1)
                End If
            ElseIf e.KeyCode = 38 Then
                If (DgvProductsDetalle.CurrentCell.RowIndex > 0) Then
                    DgvProductsDetalle.CurrentCell = DgvProductsDetalle.Item(0, DgvProductsDetalle.CurrentCell.RowIndex - 1)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error controlado, contactese con el administrador de sistemas")
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.LostFocus
        txtCantidad.BackColor = Color.White
    End Sub
    Private Sub DgvProductsDetalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DgvProductsDetalle.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCantidad.Focus()
        End If
    End Sub
    Private Function EsEntero(valor)
        Dim regresa As Boolean = True
        For index = 1 To Len(valor)
            If Mid(valor, index, 1) = "." Then
                regresa = False
                Exit For
            End If
        Next
        Return regresa
    End Function
    Public Sub AceptarCantidad()
        frmRealizarPedido.dgvListaPedido.Rows.Add()
        ' ID_PRODUCTS_DETALLE
        frmRealizarPedido.dgvListaPedido.Rows(frmRealizarPedido.dgvListaPedido.NewRowIndex - 1).Cells(0).Value = DgvProductsDetalle(0, DgvProductsDetalle.CurrentCell.RowIndex).Value
        'CODIGO_BARRA
        frmRealizarPedido.dgvListaPedido.Rows(frmRealizarPedido.dgvListaPedido.NewRowIndex - 1).Cells(1).Value = frmRealizarPedido.dgvArticulos.Item(1, frmRealizarPedido.dgvArticulos.CurrentCell.RowIndex).Value 'nombre de material
        'SKU
        frmRealizarPedido.dgvListaPedido.Rows(frmRealizarPedido.dgvListaPedido.NewRowIndex - 1).Cells(2).Value = frmRealizarPedido.dgvArticulos.Item(2, frmRealizarPedido.dgvArticulos.CurrentCell.RowIndex).Value
        'ARTICULO
        frmRealizarPedido.dgvListaPedido.Rows(frmRealizarPedido.dgvListaPedido.NewRowIndex - 1).Cells(3).Value = frmRealizarPedido.dgvArticulos.Item(3, frmRealizarPedido.dgvArticulos.CurrentCell.RowIndex).Value & " " & frmRealizarPedido.dgvArticulos.Item(4, frmRealizarPedido.dgvArticulos.CurrentCell.RowIndex).Value & " " & frmRealizarPedido.dgvArticulos.Item(5, frmRealizarPedido.dgvArticulos.CurrentCell.RowIndex).Value
        'CANTIDAD
        frmRealizarPedido.dgvListaPedido.Rows(frmRealizarPedido.dgvListaPedido.NewRowIndex - 1).Cells(4).Value = txtCantidad.Text
        'PROTOCOLO esto es la nueva columna agregada para ponerlo en el gridview 1 de la lista pedido
        frmRealizarPedido.dgvListaPedido.Rows(frmRealizarPedido.dgvListaPedido.NewRowIndex - 1).Cells(5).Value = DgvProductsDetalle(1, DgvProductsDetalle.CurrentCell.RowIndex).Value
        'LOTE
        frmRealizarPedido.dgvListaPedido.Rows(frmRealizarPedido.dgvListaPedido.NewRowIndex - 1).Cells(6).Value = DgvProductsDetalle(5, DgvProductsDetalle.CurrentCell.RowIndex).Value
        'ID_PRODUCT
        frmRealizarPedido.dgvListaPedido.Rows(frmRealizarPedido.dgvListaPedido.NewRowIndex - 1).Cells(7).Value = frmRealizarPedido.dgvArticulos.Item(0, frmRealizarPedido.dgvArticulos.CurrentCell.RowIndex).Value
        'PRECIO
        Dim precio As String = DgvProductsDetalle(2, DgvProductsDetalle.CurrentCell.RowIndex).Value
        If EsEntero(precio) = True Then
            precio = precio & ".0"
        End If
        frmRealizarPedido.dgvListaPedido.Rows(frmRealizarPedido.dgvListaPedido.NewRowIndex - 1).Cells(8).Value = precio
        'TOTAL
        Dim PRECIOXCANTIDAD As Decimal = 0
        PRECIOXCANTIDAD = Math.Round(DgvProductsDetalle(2, DgvProductsDetalle.CurrentCell.RowIndex).Value * Convert.ToDecimal(txtCantidad.Text), 1)
        If EsEntero(PRECIOXCANTIDAD) = True Then
            PRECIOXCANTIDAD = PRECIOXCANTIDAD & ".0"
        End If
        frmRealizarPedido.dgvListaPedido.Rows(frmRealizarPedido.dgvListaPedido.NewRowIndex - 1).Cells(9).Value = PRECIOXCANTIDAD

        frmRealizarPedido.dgvArticulos.Visible = False
        txtCantidad.Text = ""
        frmRealizarPedido.txtInsumos.Text = ""
        frmRealizarPedido.txtInsumos.Focus()
        Dim TotalPagar As Decimal = 0
        Dim CantidadItem As Decimal = 0
        Dim CantidadArticulos As Integer = 0
        For index = 0 To frmRealizarPedido.dgvListaPedido.RowCount - 1
            TotalPagar = TotalPagar + Convert.ToDecimal(frmRealizarPedido.dgvListaPedido.Item(9, index).Value)
            CantidadItem = CantidadItem + Convert.ToDecimal(frmRealizarPedido.dgvListaPedido.Item(4, index).Value)
        Next
        CantidadArticulos = frmRealizarPedido.dgvListaPedido.RowCount - 1
        frmRealizarPedido.txtTotalPagar.Text = TotalPagar
        frmRealizarPedido.txtCantidadItems.Text = CantidadItem
        frmRealizarPedido.txtCantidadArticulos.Text = CantidadArticulos
    End Sub
    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If txtCantidad.Text.Trim = "" Then
            MsgBox("Debe ingresar un numero porfavor,", vbInformation, "Insumos")
        Else
            If Asc(e.KeyChar) = 13 Then
                aceptar()
                Close()
            End If
            If Asc(e.KeyChar) = 27 Then
                Close()
            End If
        End If
    End Sub
End Class