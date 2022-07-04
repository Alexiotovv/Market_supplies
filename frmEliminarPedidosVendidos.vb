Imports System.Data.OleDb
Public Class frmEliminarPedidosVendidos
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvLista.Item(9, 0).Value = False Then
                If dgvLista.RowCount > 0 Then
                    If MsgBox("Esta seguro de realizar esta acción", vbExclamation + vbYesNo, "Insumo") = vbYes Then
                        Dim numid As Integer
                        numid = dgvLista.Item(0, 0).Value

                        Dim cmd As New OleDbCommand
                        cmd = New OleDbCommand("update prodsalidas set anulado=True where orden_id=" & numid & "", bd)
                        cmd.ExecuteNonQuery()
                        ActualizaStock()
                        MsgBox("Venta Anulada Correctamente", vbExclamation)
                        buscar()
                    End If

                End If
            Else
                MsgBox("Esta venta ya fue anulada", vbExclamation)
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub ActualizaStock()
        Try
            Dim cmd As New OleDbCommand
            Dim numid_products As Integer = 0
            Dim cant As Decimal = 0

            For index = 0 To dgvLista.RowCount - 1
                numid_products = dgvLista.Item(1, index).Value
                cant = dgvLista.Item(5, index).Value
                cmd = New OleDbCommand("update products set stock=stock+" & cant & " where id=" &
                                       numid_products & "", bd)
                cmd.ExecuteNonQuery()
            Next

        Catch ex As Exception

        End Try


    End Sub
    Private Sub txtOrdenID_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroPedido.TextChanged
        Limpiar()
    End Sub
    Public Sub Limpiar()
        dgvLista.DataSource = ""
    End Sub

    Private Sub txtOrdenID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroPedido.KeyPress
        If Asc(e.KeyChar) = 13 Then
            buscar()
        End If
    End Sub
    Private Sub buscar()
        dgvLista.DataSource = ""
        ' me quede aqui para buscar un comprobante y eliminarlo
        Dim DA As New OleDbDataAdapter
        Dim DT As New DataTable
        Dim cadena As String = ""

        If rbNumeroBoleta.Checked = True Then
            cadena = "prodsalidas.serie=" & txtSerie.Text & " and prodsalidas.numero=" & txtNumero.Text & " and comprobante='" & cmbTipoComprobante.Text & "'"
            If txtSerie.Text.Trim = "" Or txtNumero.Text.Trim = "" Then
                MsgBox("Ingrese Serie y Número para realizar una búsqueda")
                Exit Sub
            End If
        Else
            cadena = "prodsalidas.orden_id= " & txtNumeroPedido.Text & ""
            If txtNumeroPedido.Text.Trim = "" Then
                MsgBox("Ingrese Número de Pedido para realizar una búsqueda")
                Exit Sub
            End If
        End If


        DA = New OleDbDataAdapter("SELECT prodsalidas.Orden_id, " &
                                                    "products.id, " &
                                                    "products.categoria, " &
                                                    "products.description, " &
                                                    "products.presentacion, " &
                                                    "prodsalidas.cantidad, " &
                                                    "prodsalidas.precio, " &
                                                    "prodsalidas.total, " &
                                                    "prodsalidas.fechsalida, " &
                                                    "prodsalidas.anulado " &
                                                    "FROM products INNER JOIN " &
                                                    "prodsalidas ON " &
                                                    "products.id = prodsalidas.id_products where " &
                                                cadena, bd)

        DA.Fill(DT)

            If DT.Rows.Count > 0 Then
                dgvLista.DataSource = DT
            Else
            MsgBox("No existen Registros de los parámetros ingresados", vbInformation)
        End If


    End Sub
    Private Sub rbNumeroBoleta_Click(sender As Object, e As EventArgs) Handles rbNumeroBoleta.Click
        If rbNumeroBoleta.Checked = True Then
            txtSerie.Visible = True
            txtNumero.Visible = True
            txtNumeroPedido.Visible = False
            Label1.Text = "Buscar por Comprobante"
            lblTipoComprobante.Visible = True
            cmbTipoComprobante.Visible = True
            lblSerie.Visible = True
            lblNumero.Visible = True
            txtSerie.Focus()
        End If
    End Sub
    Private Sub rbNumeroPedido_Click(sender As Object, e As EventArgs) Handles rbNumeroPedido.Click
        If rbNumeroPedido.Checked = True Then
            txtSerie.Visible = False
            txtNumero.Visible = False
            txtNumeroPedido.Visible = True
            Label1.Text = "Buscar por N° de Pedido"
            lblTipoComprobante.Visible = False
            cmbTipoComprobante.Visible = False
            lblSerie.Visible = False
            lblNumero.Visible = False
            txtNumeroPedido.Focus()
        End If
    End Sub
    Private Sub LlenarCombo()
        Try
            Dim DA As New OleDbDataAdapter
            Dim DT As New DataTable
            DA = New OleDbDataAdapter("SELECT ID, NOMBRE FROM COMPROBANTE", bd)
            DA.Fill(DT)
            If DT.Rows.Count > 0 Then
                cmbTipoComprobante.DataSource = DT
                cmbTipoComprobante.DisplayMember = "NOMBRE"
                cmbTipoComprobante.ValueMember = "ID"
            End If
        Catch ex As Exception

        End Try




    End Sub
    Private Sub frmEliminarPedidosVendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombo()
    End Sub

    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged
        Limpiar()
    End Sub

    Private Sub txtSerie_TextChanged(sender As Object, e As EventArgs) Handles txtSerie.TextChanged
        Limpiar()
    End Sub

End Class