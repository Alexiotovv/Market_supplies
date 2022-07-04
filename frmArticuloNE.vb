Imports System.Data.OleDb
Public Class frmArticuloNE
    Dim cmd As New OleDbCommand
    Public act As String
    Dim cant As Double
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodBarra.GotFocus
        txtCodBarra.BackColor = Color.GreenYellow
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodBarra.LostFocus
        txtCodBarra.BackColor = Color.White
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtDescription.Focus()
        End If
    End Sub
    Private Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescription.GotFocus
        txtDescription.BackColor = Color.GreenYellow
    End Sub


    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescription.LostFocus
        txtDescription.BackColor = Color.White
    End Sub
    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            btnGrabar.Focus()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Form12_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenacombo()
        If modo = "1" Then ' Cuando Intenta REgistrar un Articulo Nuevo desde la Venta Principal
            limpia_cajas()
        ElseIf modo = "2" Then 'Intenta Editar un Artículo
            txtId.Text = frmArticulos.dgvArticulos.Item(0, frmArticulos.dgvArticulos.CurrentCell.RowIndex).Value.ToString
            txtCodBarra.Text = frmArticulos.dgvArticulos.Item(1, frmArticulos.dgvArticulos.CurrentCell.RowIndex).Value.ToString
            cmbCategoria.Text = frmArticulos.dgvArticulos.Item(2, frmArticulos.dgvArticulos.CurrentCell.RowIndex).Value.ToString.ToString
            txtDescription.Text = frmArticulos.dgvArticulos.Item(3, frmArticulos.dgvArticulos.CurrentCell.RowIndex).Value.ToString
            txtPresentacion.Text = frmArticulos.dgvArticulos.Item(4, frmArticulos.dgvArticulos.CurrentCell.RowIndex).Value.ToString
            txtStock.Text = frmArticulos.dgvArticulos.Item(5, frmArticulos.dgvArticulos.CurrentCell.RowIndex).Value.ToString
            txtPrecio.Text = frmArticulos.dgvArticulos.Item(6, frmArticulos.dgvArticulos.CurrentCell.RowIndex).Value.ToString

            If frmArticulos.dgvArticulos.Item(7, frmArticulos.dgvArticulos.CurrentCell.RowIndex).Value = "Si" Then
                chkActivo.Checked = True
            Else
                chkActivo.Checked = False
            End If
        ElseIf modo = "3" Then
            limpia_cajas()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        If chkActivo.Checked = True Then
            act = "Si"
        Else
            act = "No"
        End If
        If modo = "1" Then
            'VERIFICA SI EXISTE EL CODIGO DE BARRA
            If txtCodBarra.Text.Trim = "0" Then

            Else
                cmd = New OleDbCommand("select codigo_barra from products where codigo_barra='" & txtCodBarra.Text.Trim & "'", bd)
                Dim reader As OleDbDataReader
                reader = cmd.ExecuteReader
                If reader.Read Then
                    MsgBox("El Código de Barra ya existe, o el producto este desactivado", vbInformation)
                    Exit Sub
                End If
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''SI TODO ESTA OK INGRESA EL PRODUCTO
            cmd = New OleDbCommand("insert into products(" &
                                   "codigo_barra," &
                                   "categoria," &
                                   "description," &
                                   "presentacion," &
                                   "stock," &
                                   "precio," &
                                   "act) values ('" &
                                   txtCodBarra.Text & "','" &
                                   cmbCategoria.Text & "','" &
                                   txtDescription.Text & "','" &
                                   txtPresentacion.Text & "','" &
                                   txtStock.Text & "','" &
                                   txtPrecio.Text & "','" &
                                   act & "')", bd)
            cmd.ExecuteNonQuery()
            MsgBox("El nuevo articulo se ha grabado correctamente", vbInformation, "Insumos")
            Close()
        ElseIf modo = "2" Then
            cmd = New OleDbCommand("update products set codigo_barra='" & txtCodBarra.Text.Trim & "', categoria='" & cmbCategoria.Text & "',description='" & txtDescription.Text & "',presentacion='" & txtPresentacion.Text & "',stock=" & Convert.ToDecimal(txtStock.Text) & ", precio=" & Convert.ToDecimal(txtPrecio.Text) & ",act='" & act & "' where id=" & txtId.Text & "", bd)
            cmd.ExecuteNonQuery()
            MsgBox("Producto actualizado", vbInformation)
        End If
        Close()
        frmArticulos.llenagrid()
    End Sub
    Public Sub limpia_cajas()
        txtId.Clear()
        txtCodBarra.Clear()
        cmbCategoria.Text = ""
        txtDescription.Clear()
        txtPresentacion.Clear()
        chkActivo.Checked = True
        txtCodBarra.Focus()
    End Sub
    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtPresentacion.Focus()
        End If
    End Sub
    Private Sub TextBox8_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPresentacion.GotFocus
        txtPresentacion.BackColor = Color.GreenYellow
    End Sub
    Private Sub llenacombo()
        cmbCategoria.Items.Clear()
        cmd = New OleDbCommand("select distinct(products.categoria) from products order by products.categoria desc", bd)
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        Do While reader.Read
            cmbCategoria.Items.Add(reader.Item(0).ToString)
        Loop
    End Sub
    Private Sub txtPresentacion_LostFocus(sender As Object, e As EventArgs) Handles txtPresentacion.LostFocus
        txtPresentacion.BackColor = Color.White
    End Sub
    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        Dim categoria As String
        categoria = InputBox("Ingrese una Nueva Categoria", "Categoria", "")
        cmbCategoria.Items.Add(categoria.ToUpper)
        cmbCategoria.Text = categoria
    End Sub
    Private Sub txtCodBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodBarra.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmbCategoria.Focus()
        End If
    End Sub
    Private Sub cmbCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCategoria.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDescription.Focus()
        End If
    End Sub
    Private Sub txtPresentacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPresentacion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtStock.Focus()
        End If
    End Sub
    Private Sub txtDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPresentacion.Focus()
        End If
    End Sub
    Private Sub txtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPrecio.Focus()
        End If
    End Sub
    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGrabar.Focus()
        End If
    End Sub
    Private Sub txtStock_GotFocus(sender As Object, e As EventArgs) Handles txtStock.GotFocus
        txtStock.BackColor = Color.GreenYellow
    End Sub

    Private Sub txtStock_LostFocus(sender As Object, e As EventArgs) Handles txtStock.LostFocus
        txtStock.BackColor = Color.White
    End Sub

    Private Sub txtPrecio_GotFocus(sender As Object, e As EventArgs) Handles txtPrecio.GotFocus
        txtPrecio.BackColor = Color.GreenYellow
    End Sub
    Private Sub txtPrecio_LostFocus(sender As Object, e As EventArgs) Handles txtPrecio.LostFocus
        txtPrecio.BackColor = Color.White
    End Sub
End Class