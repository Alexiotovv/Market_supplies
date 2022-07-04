Imports System.Data.OleDb
Public Class frmAtenderPedidos
    Dim cmd As New OleDbCommand
    Dim adapter As New OleDbDataAdapter
    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        llenacombo()

    End Sub
    Public Sub limpiar()
        dgvListaPedidos.DataSource = ""
        lblCliente.Text = "--"
        lblFechaOrden.Text = "--"
    End Sub

    Public Sub llenacombo()
        cmbOrden.Items.Clear()
        cmd = New OleDbCommand("select distinct(prodsalidas.Orden_id) from prodsalidas where prodsalidas.despachado='no' order by prodsalidas.Orden_id desc", bd)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Do While reader.Read
            cmbOrden.Items.Add(reader.Item(0).ToString)
        Loop
        reader.Close()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOrden.SelectedIndexChanged
        ''lleno los labels para saber de quien y cuando se hizo el pedido
        cmd = New OleDbCommand("select employees.fullname,prodsalidas.fechsalida from employees left join prodsalidas on prodsalidas.id_employee=employees.id_employee where prodsalidas.Orden_id=" & cmbOrden.Text & "", bd)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        If reader.Read Then
            lblCliente.Text = reader.Item(0) 'MOSTRARÁ EL NOMBRE DEL EMPLEADO
            lblFechaOrden.Text = reader.Item(1) 'MOSTRARÁ LA FECHA DE SALIDA
        End If
        reader.Close()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'lleno el grid despues de llenar los labels
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        llenagrid()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        dgvListaPedidos.Columns.Item(0).Width = 60 'ID
        dgvListaPedidos.Columns.Item(1).Width = 60 'SUPCODE
        dgvListaPedidos.Columns.Item(2).Width = 400 'DESCRIPTION
        dgvListaPedidos.Columns.Item(3).Width = 50 'CANTIDAD
        dgvListaPedidos.Columns.Item(4).Width = 80 'PROTOCOLO
        dgvListaPedidos.Columns.Item(5).Width = 90 'LOTE
        dgvListaPedidos.Columns.Item(6).Width = 50 'DESPACHADO
        dgvListaPedidos.Columns.Item(7).Width = 0 ' ID del products_detalle en la tabla prodsalidas para poder restar el stock
        dgvListaPedidos.Columns.Item(7).Visible = False
        dgvListaPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListaPedidos.CellDoubleClick
        If dgvListaPedidos.Item(6, dgvListaPedidos.CurrentCell.RowIndex).Value = "no" Then
            dgvListaPedidos.Item(6, dgvListaPedidos.CurrentCell.RowIndex).Value = "si"
        Else
            dgvListaPedidos.Item(6, dgvListaPedidos.CurrentCell.RowIndex).Value = "no"
        End If
    End Sub

    Public Sub llenagrid()
        adapter = New OleDbDataAdapter("SELECT prodsalidas.id, " &
                                       " products.description, " &
                                       " prodsalidas.precio, " &
                                       " prodsalidas.cantidad, " &
                                       " prodsalidas.total, " &
                                       " prodsalidas.fechsalida, " &
                                       " prodsalidas.serie, " &
                                       " prodsalidas.numero " &
                                       " FROM products INNER JOIN " &
                                       " prodsalidas ON prodsalidas.id_products = products.id " &
                                       " where prodsalidas.Orden_id = " & cmbOrden.Text & " " &
                                       " And prodsalidas.despachado='No'", bd)
        Dim dataset As New DataSet
        adapter.Fill(dataset, "nombre")
        dgvListaPedidos.DataSource = dataset.Tables(0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If cmbOrden.Text = "" Then

        Else
            If dgvListaPedidos.RowCount = 0 Then
            Else
                llenagrid()
            End If
        End If
    End Sub
    Private Sub btnDespacharPedido_Click(sender As Object, e As EventArgs) Handles btnDespacharPedido.Click
        If dgvListaPedidos.RowCount > 0 Then
            If MsgBox("Está seguro de realizar esta acción", vbExclamation + vbYesNo, "Ventas") = vbYes Then
                Dim CMD As OleDbCommand
                CMD = New OleDbCommand("update prodsalidas set despachado='Si' where orden_id=" & Convert.ToInt32(cmbOrden.Text) & "", bd)
                CMD.ExecuteNonQuery()
                MsgBox("La Lista fue despachada exitosamente", vbInformation)
                dgvListaPedidos.DataSource = ""
                llenacombo()
                limpiar()
            End If
        End If

    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvListaPedidos.RowCount > 0 Then
            If MsgBox("Está seguro de realizar esta acción Eliminar", vbExclamation + vbYesNo, "Ventas") = vbYes Then
                If cmbOrden.Text = "" Then
                    MsgBox("Debe seleccionar una Orden para poder eliminar", vbInformation, "Mensaje")
                Else
                    'SELECCIONA EL ID DEL PRODUCTO Y LA CANTIDAD PARA LUEGO ATUALIZAR EL STOCK
                    Dim reader As OleDbDataReader
                    cmd = New OleDbCommand("select prodsalidas.id_products, " &
                                           " prodsalidas.cantidad " &
                                           " from prodsalidas where " &
                                           " prodsalidas.Orden_id = " & cmbOrden.Text & " And prodsalidas.despachado ='si'", bd)
                    cmd.ExecuteNonQuery()
                    reader = cmd.ExecuteReader
                    '---------------------------------------------
                    'ACTUALIZA EL STOCK 
                    While reader.Read
                        cmd = New OleDbCommand("update products set products.stock=products.stock + " & Convert.ToDecimal(reader.Item(1)) & " where products.ID=" & reader.Item(0) & "", bd)
                        cmd.ExecuteNonQuery()
                    End While
                    '---------------------------------------------
                    'ELIMINA LA ORDEN
                    cmd = New OleDbCommand("delete from prodsalidas where prodsalidas.Orden_id = " & Convert.ToInt32(cmbOrden.Text) & "", bd)
                    cmd.ExecuteNonQuery()
                    '---------------------------------------------
                    MsgBox("Listo!, a lista se ha elminado correctamente", vbInformation, "Mensaje")
                    reader.Close()
                    llenacombo()
                    limpiar()
                End If
            End If
        End If
    End Sub
End Class