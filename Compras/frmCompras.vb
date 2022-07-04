Imports System.Data.OleDb
Public Class frmCompras
    Dim tenter As Boolean = True
    Private Sub txtProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProducto.KeyPress
        Try
            If txtProducto.Text.Trim <> "" Then
                Dim prod As String
                prod = txtProducto.Text
                If IsNumeric(prod) Then

                    If Asc(e.KeyChar) = 13 Then
                        If tenter Then
                            Dim DA As New OleDbDataAdapter
                            Dim DT As New DataTable
                            'consulta por codigo de barra
                            DA = New OleDbDataAdapter("select codigo_barra as CÓDIGO_DE_BARRA, categoria as CATEGORÍA, description as DESCRIPCIÓN_DEL_PRODUCTO, precio_compra as PRECIO_COMPRA,id" &
                                                      " from products where codigo_barra='" & prod & "'", bd)
                            DA.Fill(DT)
                            dgvBuscaProductos.DataSource = DT
                            tenter = False
                        Else
                            'pasa de dgvbuscar a listaproductos
                            dgvListaCompra.Rows.Add()
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(0).Value = dgvListaCompra.RowCount - 1
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(1).Value = dgvBuscaProductos(0, dgvBuscaProductos.CurrentCell.RowIndex).Value
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(2).Value = dgvBuscaProductos(1, dgvBuscaProductos.CurrentCell.RowIndex).Value
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(3).Value = dgvBuscaProductos(2, dgvBuscaProductos.CurrentCell.RowIndex).Value
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(4).Value = dgvBuscaProductos(3, dgvBuscaProductos.CurrentCell.RowIndex).Value
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(5).Value = 1
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(6).Value = dgvBuscaProductos(3, dgvBuscaProductos.CurrentCell.RowIndex).Value
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(7).Value = dgvBuscaProductos(4, dgvBuscaProductos.CurrentCell.RowIndex).Value
                            dgvBuscaProductos.Visible = False
                            tenter = True
                            LimpiarCaja()
                            SumarMontos()
                        End If

                    End If
                Else
                    If Asc(e.KeyChar) = 13 Then
                        If dgvBuscaProductos.RowCount - 1 > 0 Then
                            'pasa de dgvbuscar a listaproductos
                            dgvListaCompra.Rows.Add()
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(0).Value = dgvListaCompra.RowCount - 1
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(1).Value = dgvBuscaProductos(0, dgvBuscaProductos.CurrentCell.RowIndex).Value
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(2).Value = dgvBuscaProductos(1, dgvBuscaProductos.CurrentCell.RowIndex).Value
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(3).Value = dgvBuscaProductos(2, dgvBuscaProductos.CurrentCell.RowIndex).Value
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(4).Value = dgvBuscaProductos(3, dgvBuscaProductos.CurrentCell.RowIndex).Value
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(5).Value = 1
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(6).Value = dgvBuscaProductos(3, dgvBuscaProductos.CurrentCell.RowIndex).Value
                            dgvListaCompra.Rows(dgvListaCompra.NewRowIndex - 1).Cells(7).Value = dgvBuscaProductos(4, dgvBuscaProductos.CurrentCell.RowIndex).Value
                            dgvBuscaProductos.Visible = False
                            LimpiarCaja()
                            SumarMontos()
                        End If

                    End If
                End If
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtProducto_TextChanged(sender As Object, e As EventArgs) Handles txtProducto.TextChanged
        Dim prod As String
        prod = txtProducto.Text
        Dim DA As New OleDbDataAdapter
        Dim DT As New DataTable
        If txtProducto.TextLength > 0 Then
            dgvBuscaProductos.Visible = True
            If IsNumeric(prod) Then

            Else
                dgvBuscaProductos.Visible = True
                'consulta por nombre
                DA = New OleDbDataAdapter("select codigo_barra as CÓDIGO_DE_BARRA, categoria as CATEGORÍA, description as DESCRIPCIÓN_DEL_PRODUCTO, precio_compra as PRECIO_COMPRA,id" &
                                          " from products where description like'%" & prod & "%'", bd)
                DA.Fill(DT)
                dgvBuscaProductos.DataSource = DT

            End If
        Else
            dgvBuscaProductos.Visible = False
        End If



    End Sub
    Private Sub LimpiarCaja()
        txtProducto.Clear()
        dgvBuscaProductos.Visible = False
        txtProducto.Focus()
    End Sub

    Private Sub txtProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProducto.KeyDown
        Try
            If e.KeyCode = 40 Then 'este key code es haca abajo
                If (dgvBuscaProductos.CurrentCell.RowIndex < dgvBuscaProductos.RowCount - 2) Then
                    dgvBuscaProductos.CurrentCell = dgvBuscaProductos.Item(0, dgvBuscaProductos.CurrentCell.RowIndex + 1)
                End If
            ElseIf e.KeyCode = 38 Then ' este key code es hacia arriba
                If (dgvBuscaProductos.CurrentCell.RowIndex > 0) Then
                    dgvBuscaProductos.CurrentCell = dgvBuscaProductos.Item(0, dgvBuscaProductos.CurrentCell.RowIndex - 1)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error controlado, contactase con el administrador de sistemas")
        End Try
    End Sub
    Private Sub nuevacompra()
        dgvBuscaProductos.DataSource = ""
        dgvBuscaProductos.Visible = False
        dgvListaCompra.DataSource = ""
        txtSerie.Text = "0"
        txtNumero.Text = "0"
        txtProveedor.Text = "RUC o DNI"
        lblID_PROVEEDOR.Text = "ID_PROVEEDOR"
        lblNombreProveedor.Text = "--"
        txtSubTotal.Text = "0.00"
        txtTotal.Text = "0.00"
        txtMontoTotal.Text = "S/0.00"
        txtProducto.Clear()
        txtProducto.Focus()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            If lblNombreProveedor.Text = "--" Then
                MsgBox("No existe un Proveedor Seleccionado")
                Exit Sub
            End If
            If dgvBuscaProductos.RowCount - 1 < 1 Then
                MsgBox("No existen Productos para guardar")
                Exit Sub
            End If


            Dim IDPRODUCTO As Integer = 0
            Dim IDPROVEEDOR As Integer = 0
            Dim CANTIDAD As Decimal = 0
            Dim CPRECIO As Decimal = 0
            Dim CTOTAL As Decimal = 0
            Dim CIGV As Decimal = 0
            Dim CFECH As Date
            Dim CSERIE As Integer = 0
            Dim CNUMERO As Integer = 0


            IDPROVEEDOR = Convert.ToInt32(lblID_PROVEEDOR.Text)
            CSERIE = txtSerie.Text
            CNUMERO = txtNumero.Text

            For index = 0 To dgvListaCompra.RowCount - 2
                IDPRODUCTO = dgvListaCompra.Item(7, index).Value
                IDPROVEEDOR = lblID_PROVEEDOR.Text
                CANTIDAD = dgvListaCompra.Item(5, index).Value
                CPRECIO = dgvListaCompra.Item(4, index).Value

                CTOTAL = dgvListaCompra.Item(4, index).Value * dgvListaCompra.Item(5, index).Value
                CIGV = Convert.ToDecimal(txtIGV.Text)
                CFECH = dtpFechaCompra.Value

                Dim CMD As New OleDbCommand
                CMD = New OleDbCommand("INSERT INTO PRODENTRADAS(id_products" &
                                       ",id_proveedor" &
                                       ",cantidad" &
                                       ",precio" &
                                       ",total" &
                                       ",igv" &
                                       ",fechentrada" &
                                       ",serie" &
                                       ",numero" &
                                       ",comprobante" &
                                       ",confirmado" &
                                       ",usu) values (" & IDPRODUCTO & "," &
                                       IDPROVEEDOR & "," &
                                       CANTIDAD & "," &
                                       CPRECIO & "," &
                                       CTOTAL & "," &
                                       CIGV & ",'" &
                                       CFECH & "'," &
                                       CSERIE & "," &
                                       CNUMERO & ",'" &
                                       cmbTipoDocumento.Text & "','" &
                                       "Si" & "','" &
                                       usu & "'" &
                                       ")", bd)
                CMD.ExecuteNonQuery()
            Next

            MsgBox("Compra Guardada correctamente", vbInformation)
            nuevacompra()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgvListaCompra_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaCompra.CellContentClick

    End Sub
    Private Sub SumarMontos()
        Dim total As Decimal = 0
        For index = 0 To dgvListaCompra.RowCount - 1
            total = total + dgvListaCompra.Item(6, index).Value
            txtSubTotal.Text = total
            txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtSubTotal.Text) - Convert.ToDecimal(txtIGV.Text))
            txtMontoTotal.Text = txtTotal.Text
        Next

    End Sub
    Private Sub dgvListaCompra_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaCompra.CellEndEdit
        Try
            If dgvListaCompra.CurrentCell.ColumnIndex = 4 Or dgvListaCompra.CurrentCell.ColumnIndex = 5 Then
                dgvListaCompra.CurrentRow.Cells(6).Value = dgvListaCompra(4, dgvListaCompra.CurrentCell.RowIndex).Value * dgvListaCompra(5, dgvListaCompra.CurrentCell.RowIndex).Value
                SumarMontos()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtProveedor.TextChanged

    End Sub

    Private Sub txtProveedor_GotFocus(sender As Object, e As EventArgs) Handles txtProveedor.GotFocus
        txtProveedor.SelectionStart = 0
        txtProveedor.SelectionLength = txtProveedor.Text.Length
    End Sub
    Private Sub txtProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProveedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If IsNumeric(txtProveedor.Text.Trim) Then
                Dim DA As New OleDbDataAdapter
                Dim DT As New DataTable
                DA = New OleDbDataAdapter("SELECT ID, RUC_DNI, NOMBRE_RAZON FROM PROVEEDORES WHERE " &
                                           " RUC_DNI='" & txtProveedor.Text.Trim & "'", bd)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    lblNombreProveedor.Text = DT(0)(2)
                    lblID_PROVEEDOR.Text = DT(0)(0)
                Else
                    MsgBox("No existe Proveedor con el Ruc o Dni ingresado", vbExclamation)
                    txtProveedor.Text.Clone()
                End If
            Else
                MsgBox("Ruc o Dni inválidos", vbExclamation)
                txtProveedor.Text.Clone()
            End If

        End If
    End Sub

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaCompra.Value = Today
        cmbTipoDocumento.SelectedIndex = 0
        cmbTipoPago.SelectedIndex = 0

    End Sub
    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        nuevacompra()
    End Sub
End Class