Imports System.Data.OleDb
Public Class frmCorregirOrden
    Dim adapter As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If ComboBox1.Text = "TODOS" Then
            MsgBox("Debe seleccionar un numero Orden para poder eliminar un articulo/insumo", vbInformation)
            Exit Sub
        End If

        If DataGridView1.RowCount > 2 Then
            If MsgBox("Esta seguro de querer eliminar " & DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value.ToString & " de la orden", vbExclamation + vbYesNo, "Insumo") = vbYes Then
                cmd = New OleDbCommand("delete from prodsalidas where ID=" & DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value & "", bd)
                cmd.ExecuteNonQuery()
                mostrarpedidos()
            End If
        Else
            MsgBox("No esta permitido esta Accón, puede hacer click en la opción Eliminar Toda la Orden", vbInformation, "Insumos")
        End If
    End Sub
    Public Sub mostrarpedidos()
        If ComboBox1.Text = "" Then
            MsgBox("<<<<----Debe seleccionar una opcion", vbExclamation, "Insumos")
        Else
            If ComboBox1.Text = "TODOS" Then
                adapter = New OleDbDataAdapter("Select prodsalidas.ID as ID," &
                                           "products.description as ARTICULO," &
                                           "prodsalidas.cantidad as CANTIDAD," &
                                           "prodsalidas.fechsalida as FECHA," &
                                           "prodsalidas.id_employee as COD_TRAB," &
                                           "prodsalidas.precio," &
                                           "prodsalidas.total," &
                                           "prodsalidas.efectivo," &
                                           "prodsalidas.vuelto," &
                                           "prodsalidas.tipopago," &
                                           "prodsalidas.despachado," &
                                           "prodsalidas.usu," &
                                           "prodsalidas.serie," &
                                           "prodsalidas.numero," &
                                           "prodsalidas.comprobante," &
                                           "prodsalidas.anulado," &
                                           "employees.fullname as NOMBRE_TRABAJADOR from ((prodsalidas " &
                                           "left join products on products.id = prodsalidas.id_products) " &
                                           "left join employees on employees.id_employee = prodsalidas.id_employee) " &
                                           "where prodsalidas.usu='" & usu & "' and prodsalidas.despachado='No'", bd)
            Else
                adapter = New OleDbDataAdapter("Select prodsalidas.ID as ID," &
                                           "products.description as ARTICULO," &
                                           "prodsalidas.cantidad as CANTIDAD," &
                                           "prodsalidas.fechsalida as FECHA," &
                                           "prodsalidas.id_employee as COD_TRAB," &
                                           "prodsalidas.precio," &
                                           "prodsalidas.total," &
                                           "prodsalidas.vuelto," &
                                           "prodsalidas.tipopago," &
                                           "prodsalidas.despachado," &
                                           "prodsalidas.usu," &
                                           "prodsalidas.serie," &
                                           "prodsalidas.numero," &
                                           "prodsalidas.comprobante," &
                                           "prodsalidas.anulado," &
                                           "employees.fullname as NOMBRE_TRABAJADOR from ((prodsalidas " &
                                           "left join products on products.id = prodsalidas.id_products) " &
                                           "left join employees on employees.id_employee = prodsalidas.id_employee) " &
                                           "where prodsalidas.usu='" & usu & "' and prodsalidas.Orden_id =" & ComboBox1.Text & " and prodsalidas.despachado='No'", bd)
            End If

            Dim dataset As New DataSet
            adapter.Fill(dataset, "MUESTRA")
            DataGridView1.DataSource = dataset.Tables(0)

            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub
    Public Sub llenacombo()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("TODOS")
        cmd = New OleDbCommand("select distinct(Orden_id) from prodsalidas where despachado='no' order by Orden_id desc", bd)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Do While reader.Read
            ComboBox1.Items.Add(reader.Item(0).ToString)
        Loop
        ComboBox1.Text = "TODOS"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        EditarItem()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        EditarItem()
    End Sub
    Private Sub EditarItem()
        Try
            llave_orden = "editar"
            frmEditarItem.lbProdsalidasID.Text = DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value
            frmEditarItem.txtBusqueda.Text = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
            frmEditarItem.txtCantidad.Text = DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value
            frmEditarItem.Text = "Editar_Item"
            frmEditarItem.btnGuardar.Text = "Guardar Cambios"
            frmEditarItem.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If DataGridView1.RowCount > 1 Then
            If ComboBox1.Text = "TODOS" Then
                MsgBox("Debe seleccionar un numero Orden para poder agregar un articulo/insumo", vbInformation)
            Else
                llave_orden = "agregar"
                frmEditarItem.txtBusqueda.Text = ""
                frmEditarItem.txtCantidad.Text = ""
                frmEditarItem.Text = "Agregar_Item"
                frmEditarItem.btnGuardar.Text = "Guardar Item"
                frmEditarItem.ShowDialog()
            End If
        Else
            MsgBox("No se puede agregar a la lista", vbInformation, "Insumos")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "TODOS" Then
            MsgBox("Debe seleccionar un Número Orden para poder Eliminar", vbExclamation, "Mensaje")
        Else
            If (MsgBox("Esta a punto de eliminar una orden!, esta seguro realizar esta operacioón?", vbInformation + MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                cmd = New OleDbCommand("delete from prodsalidas where prodsalidas.Orden_id = " & ComboBox1.Text & " and prodsalidas.despachado='no'", bd)
                cmd.ExecuteNonQuery()
                MsgBox("Listo! se ha eliminado", vbInformation, "Mensaje")
                llenacombo()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub frmCorregirOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenacombo()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        mostrarpedidos()
    End Sub
End Class