Imports System.Data.OleDb
Public Class frmEditarItem
    Dim adapter1 As New OleDbDataAdapter
    Dim adapter As New OleDbDataAdapter
    Dim cmd As New OleDbCommand


    Public Sub gridtextbox2()
        If dgvArticulos.Visible = False Then

        Else
            lbProduct_ID.Text = dgvArticulos.Item(0, dgvArticulos.CurrentCell.RowIndex).Value.ToString
            txtBusqueda.Text = dgvArticulos.Item(1, dgvArticulos.CurrentCell.RowIndex).Value.ToString
            dgvArticulos.Visible = False
        End If
    End Sub
    Private Sub DataGridView2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    End Sub

    Private Sub DataGridView3_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArticulos.CellDoubleClick
        gridtextbox2()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If llave_orden = "agregar" Then
            AgregarItem()
        ElseIf llave_orden = "editar" Then
            GuardarCambios()
        End If

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBusqueda.LostFocus
        txtBusqueda.BackColor = Color.White
    End Sub
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        If dgvArticulos.RowCount < 2 Then
        Else
        End If

        If txtBusqueda.TextLength > 0 Then
            dgvArticulos.Visible = True
        Else
            dgvArticulos.Visible = False
        End If

        If rbCodBarra.Checked = True Then
            adapter = New OleDbDataAdapter("select id as ID,codigo_barra as COD_BARRA,description as ARTICULO,presentacion as PRESENTACION, precio as PRECIO from products where codigo_barra like '%" & txtBusqueda.Text & "%'", bd)
        ElseIf rbNombre.Checked = True Then
            adapter = New OleDbDataAdapter("select id as ID,codigo_barra as COD_BARRA,description as ARTICULO,presentacion as PRESENTACION, precio as PRECIO from products where description like '%" & txtBusqueda.Text & "%'", bd)
        End If

        Dim dataset As New DataSet
        adapter.Fill(dataset, "nombre")
        dgvArticulos.DataSource = dataset.Tables(0)
        dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub GuardarCambios()
        Try
            cmd = New OleDbCommand("update prodsalidas set id_products=" & lbProduct_ID.Text &
                                   ",cantidad=" & txtCantidad.Text &
                                   " where ID=" & lbProdsalidasID.Text & "", bd)
            cmd.ExecuteNonQuery()
            MsgBox("Actualizado Correctamente", vbInformation, "Insumos")
            frmCorregirOrden.mostrarpedidos()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub AgregarItem()

        Try
            'Dim anulado As Boolean = True

            'If frmCorregirOrden.DataGridView1.Item(14, 1).Value = True Then
            '    anulado = True
            'Else
            '    anulado = False
            'End If
            cmd = New OleDbCommand("insert into prodsalidas(Orden_id," &
                                   "id_employee," &
                                   "id_products," &
                                   "cantidad," &
                                   "precio," &
                                   "total," &
                                   "efectivo," &
                                   "vuelto," &
                                   "tipopago," &
                                   "fechsalida," &
                                   "despachado," &
                                   "usu," &
                                   "serie," &
                                   "numero," &
                                   "comprobante," &
                                   "anulado) values(" &
                                   Convert.ToInt32(frmCorregirOrden.ComboBox1.Text) & "," &
                                   Convert.ToInt32(frmCorregirOrden.DataGridView1.Item(4, 1).Value) & "," &
                                   Convert.ToInt32(lbProduct_ID.Text) & "," &
                                   txtCantidad.Text & "," &
                                   Convert.ToDecimal(lblPrecio.Text) & "," &
                                   "0," &
                                   "0," &
                                   "0,'" &
                                   frmCorregirOrden.DataGridView1.Item(8, 1).Value & "'," &
                                   Today & ",'" &
                                   "No" & "','" &
                                   usu & "'," &
                                   frmCorregirOrden.DataGridView1.Item(11, 1).Value & "," &
                                   frmCorregirOrden.DataGridView1.Item(12, 1).Value & ",'" &
                                   frmCorregirOrden.DataGridView1.Item(13, 1).Value & "'," &
                                   frmCorregirOrden.DataGridView1.Item(14, 1).Value & "" &
                                    ")", bd)
            cmd.ExecuteNonQuery()
            MsgBox("Agregado un Nuevo Artículo Correctamente", vbInformation, "Insumos")
            frmCorregirOrden.mostrarpedidos()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub rbSku_CheckedChanged(sender As Object, e As EventArgs)
        txtBusqueda.Focus()
    End Sub
    Private Sub rbCodBarra_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodBarra.CheckedChanged
        txtBusqueda.Focus()
    End Sub

    Private Sub rbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombre.CheckedChanged
        txtBusqueda.Focus()
    End Sub

    Private Sub txtCantdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardar.Focus()
        End If
    End Sub

    Private Sub frmEditarItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvArticulos.Visible = False
        txtBusqueda.Focus()
    End Sub

    Private Sub txtBusqueda_GotFocus(sender As Object, e As EventArgs) Handles txtBusqueda.GotFocus
        txtBusqueda.BackColor = Color.GreenYellow
    End Sub

    Private Sub txtBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If dgvArticulos.RowCount > 0 Then
            If e.KeyCode = 40 Then
                If (dgvArticulos.CurrentCell.RowIndex < dgvArticulos.RowCount - 2) Then
                    dgvArticulos.CurrentCell = dgvArticulos.Item(0, dgvArticulos.CurrentCell.RowIndex + 1)
                End If
            ElseIf e.KeyCode = 38 Then
                If (dgvArticulos.CurrentCell.RowIndex > 0) Then
                    dgvArticulos.CurrentCell = dgvArticulos.Item(0, dgvArticulos.CurrentCell.RowIndex - 1)
                End If
            End If
        End If

    End Sub
    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress


        If Asc(e.KeyChar) = 13 Then
            If dgvArticulos.Visible = False Then
                txtCantidad.Focus()
            Else
                If dgvArticulos.RowCount > 0 Then

                    If rbCodBarra.Checked = True Then
                        adapter = New OleDbDataAdapter("select id as ID, codigo_barra as COD_BARRA,description as ARTICULO,presentacion as PRESENTACION,precio as PRECIO  from products where codigo_barra='" & txtBusqueda.Text.Trim & "'", bd)
                        Dim dataset As New DataSet
                        adapter.Fill(dataset, "nombre")
                        dgvArticulos.DataSource = dataset.Tables(0)
                        dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        dgvArticulos.Visible = False
                    End If

                    If dgvArticulos.RowCount < 2 Then
                        MsgBox("Debe seleccionar un insumo ", vbExclamation, "Insumos")
                    Else
                        If dgvArticulos.Item(0, dgvArticulos.CurrentCell.RowIndex).Value > 0 Then
                            id_product = dgvArticulos.Item(0, dgvArticulos.CurrentCell.RowIndex).Value
                            txtBusqueda.Text = dgvArticulos.Item(2, dgvArticulos.CurrentCell.RowIndex).Value
                            txtCantidad.Text = 1.0
                            lblPrecio.Text = dgvArticulos.Item(4, dgvArticulos.CurrentCell.RowIndex).Value
                            lbProduct_ID.Text = dgvArticulos.Item(0, dgvArticulos.CurrentCell.RowIndex).Value
                            dgvArticulos.Visible = False
                        Else
                            MsgBox("El stock de este articulo es insuficiente para realizar la orden", vbInformation, "Mensaje")
                        End If
                    End If
                End If

            End If

        End If
    End Sub

    Private Sub txtCantdad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        For X = 1 To txtCantidad.Text.Trim.Length
            If Mid(txtCantidad.Text, X, 1) = "1" Or Mid(txtCantidad.Text, X, 1) = "2" Or Mid(txtCantidad.Text, X, 1) = "3" Or Mid(txtCantidad.Text, X, 1) = "4" Or Mid(txtCantidad.Text, X, 1) = "5" Or Mid(txtCantidad.Text, X, 1) = "6" Or Mid(txtCantidad.Text, X, 1) = "7" Or Mid(txtCantidad.Text, X, 1) = "8" Or Mid(txtCantidad.Text, X, 1) = "9" Or Mid(txtCantidad.Text, X, 1) = "0" Or Mid(txtCantidad.Text, X, 1) = "." Then
            Else
                MsgBox("No es un nummero valido, porfavor ingrese un numero correcto", vbExclamation, "Insumos")
                txtCantidad.Text = Mid(txtCantidad.Text, 1, txtCantidad.TextLength - 1)
                Exit Sub
            End If
        Next
    End Sub
End Class