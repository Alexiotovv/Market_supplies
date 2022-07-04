Imports System.Data.OleDb
Public Class frmActualizarArticulo
    Dim cmd As New OleDbCommand
    Dim adapter As New OleDbDataAdapter
    Dim cant As Double
    Dim idproduc As Integer
    Dim EncuentraProductoBarra As Boolean = False
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbCodBarra.Checked = True
        Me.Top = 0
        LLENA_GRID_INGRESOS()
    End Sub
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInsumos.GotFocus
        txtInsumos.BackColor = Color.GreenYellow
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInsumos.LostFocus
        txtInsumos.BackColor = Color.White
    End Sub
    Public Sub BuscaPorNombre()
        If txtInsumos.Text.Trim = "" Then
            dgvArticulos.Visible = False
        Else
            dgvArticulos.Visible = True
            If rbNombre.Checked = True Then
                adapter = New OleDbDataAdapter("select id as ID,codigo_barra as CODIGO_BARRA,categoria as CATEGORIA, description as ARTICULO, presentacion as PRESENTACION, act as ACTIVO from products where description like'%" & txtInsumos.Text & "%' and act='Si'", bd)
                Dim dataset As New DataSet
                adapter.Fill(dataset, "nombre")
                dgvArticulos.DataSource = dataset.Tables(0)
            End If

        End If
    End Sub
    Public Sub BuscarPorCodigoBarra()
        Dim DA = New OleDbDataAdapter
        Dim DT = New DataTable
        DA = New OleDbDataAdapter("select id as ID,codigo_barra as COD_BARRA,description as ARTICULO,presentacion as PRESENTACION from products where codigo_barra='" & txtInsumos.Text.Trim & "'", bd)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            dgvArticulos.DataSource = DT
            EncuentraProductoBarra = True
        Else
            EncuentraProductoBarra = False
            MsgBox("No existe este artículo con este Código de Barra")
            dgvArticulos.DataSource = ""
            dgvArticulos.Visible = False
            txtInsumos.Clear()
            txtInsumos.Focus()
        End If
    End Sub
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtInsumos.TextChanged
        BuscaPorNombre()
    End Sub
    Private Sub pidecantidad()
        frmIngreseCantidad.ShowDialog()
    End Sub
    Public Sub registrar()
        Try
            Dim cantidad As Decimal = 0
            If txtCantidad.Text.Trim = "" Then
                cantidad = 1
            Else
                cantidad = Convert.ToDecimal(txtCantidad.Text)
            End If

            'aqui registra el ingreso de merca
            cmd = New OleDbCommand("INSERT INTO prodentradas(id_products," &
                                       "cantidad,fechentrada,confirmado,usu)" &
                                       " VALUES (" & dgvArticulos.Item(0, dgvArticulos.CurrentCell.RowIndex).Value & "," &
                                       cantidad & ",'" &
                                       Today & "','" &
                                       "Si" & "','" &
                                       usu & "')", bd)
            cmd.ExecuteNonQuery()
            'luego actualiza el stock
            ActualizaStock()
            limpiar()
            MsgBox("Registro Correcto", vbInformation)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub limpiar()
        txtInsumos.Clear()
        txtCantidad.Clear()
        dgvArticulos.DataSource = ""
        dgvArticulos.Visible = False
        LLENA_GRID_INGRESOS()
        txtInsumos.Focus()
    End Sub

    Public Sub LLENA_GRID_INGRESOS()
        Dim DA As New OleDbDataAdapter
        Dim DT As New DataTable
        Dim fecha As Date

        fecha = Today()
        'fecha = Today

        DA = New OleDbDataAdapter("SELECT prodentradas.ID, " &
                                  "products.id, products.description, " &
                                  "prodentradas.cantidad, " &
                                  "prodentradas.fechentrada, " &
                                  "prodentradas.usu " &
               "FROM products INNER JOIN prodentradas ON " &
               "products.id = prodentradas.id_products " &
                "WHERE (((prodentradas.fechentrada)=#" & fecha & "#))" &
                "ORDER BY prodentradas.ID DESC", bd)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            dgvEntradas.DataSource = DT
        End If
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInsumos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If rbCodBarra.Checked = True Then
                BuscarPorCodigoBarra()
            Else
                BuscaPorNombre()
            End If
            registrar()
        End If
    End Sub
    Private Sub btnRegistrarIngreso_Click(sender As Object, e As EventArgs) Handles btnRegistrarIngreso.Click
        boton_registro()
    End Sub
    Public Sub boton_registro()
        If rbCodBarra.Checked = True Or rbNombre.Checked = True Then
            If EncuentraProductoBarra = True Or dgvArticulos.RowCount > 0 Then
                registrar()
            Else
                MsgBox("No hay Producto para ingresar o no se encuentra")
                dgvArticulos.DataSource = ""
                dgvArticulos.Visible = False
                txtInsumos.Clear()
                txtInsumos.Focus()
            End If
        End If
    End Sub
    Private Sub btnUno_Click(sender As Object, e As EventArgs) Handles btnUno.Click
        txtCantidad.Text = txtCantidad.Text + "1"
        txtInsumos.Focus()
    End Sub
    Private Sub btnDos_Click(sender As Object, e As EventArgs) Handles btnDos.Click
        txtCantidad.Text = txtCantidad.Text + "2"
        txtInsumos.Focus()
    End Sub

    Private Sub btnTres_Click(sender As Object, e As EventArgs) Handles btnTres.Click
        txtCantidad.Text = txtCantidad.Text + "3"
        txtInsumos.Focus()
    End Sub

    Private Sub btnCuatro_Click(sender As Object, e As EventArgs) Handles btnCuatro.Click
        txtCantidad.Text = txtCantidad.Text + "4"
        txtInsumos.Focus()
    End Sub

    Private Sub btnCinco_Click(sender As Object, e As EventArgs) Handles btnCinco.Click
        txtCantidad.Text = txtCantidad.Text + "5"
        txtInsumos.Focus()
    End Sub

    Private Sub btnSeis_Click(sender As Object, e As EventArgs) Handles btnSeis.Click
        txtCantidad.Text = txtCantidad.Text + "6"
        txtInsumos.Focus()
    End Sub

    Private Sub btnSiete_Click(sender As Object, e As EventArgs) Handles btnSiete.Click
        txtCantidad.Text = txtCantidad.Text + "7"
        txtInsumos.Focus()
    End Sub

    Private Sub btnOcho_Click(sender As Object, e As EventArgs) Handles btnOcho.Click
        txtCantidad.Text = txtCantidad.Text + "8"
        txtInsumos.Focus()
    End Sub

    Private Sub btnNueve_Click(sender As Object, e As EventArgs) Handles btnNueve.Click
        txtCantidad.Text = txtCantidad.Text + "9"
        txtInsumos.Focus()
    End Sub

    Private Sub btnCero_Click(sender As Object, e As EventArgs) Handles btnCero.Click
        txtCantidad.Text = txtCantidad.Text + "0"
        txtInsumos.Focus()
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        If VerificaPunto(txtCantidad.Text) Then
        Else
            txtCantidad.Text = txtCantidad.Text + "."
            txtInsumos.Focus()
        End If
    End Sub
    Private Function VerificaPunto(cadena)
        Dim punto As String = ""
        Dim devuelve As Boolean
        For index = 1 To cadena.ToString.Length
            punto = Mid(cadena, index, 1)
            If punto = "." Then
                devuelve = True
                Exit For
            End If
        Next
        Return devuelve
    End Function
    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        For X = 1 To txtCantidad.Text.Trim.Length
            If Mid(txtCantidad.Text, X, 1) = "1" Or Mid(txtCantidad.Text, X, 1) = "2" Or Mid(txtCantidad.Text, X, 1) = "3" Or Mid(txtCantidad.Text, X, 1) = "4" Or Mid(txtCantidad.Text, X, 1) = "5" Or Mid(txtCantidad.Text, X, 1) = "6" Or Mid(txtCantidad.Text, X, 1) = "7" Or Mid(txtCantidad.Text, X, 1) = "8" Or Mid(txtCantidad.Text, X, 1) = "9" Or Mid(txtCantidad.Text, X, 1) = "0" Or Mid(txtCantidad.Text, X, 1) = "." Then
            Else
                MsgBox("No es un nummero valido, porfavor ingrese un numero correcto", vbExclamation, "Insumos")
                Exit Sub
            End If
        Next
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

    Private Sub btnCe_Click(sender As Object, e As EventArgs) Handles btnCe.Click
        txtCantidad.Clear()
        txtCantidad.Focus()
    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        If txtCantidad.Text.Trim = "" Then
            txtCantidad.Text = "0"
        End If
        txtCantidad.Text = Convert.ToDecimal(txtCantidad.Text) + 1
        txtInsumos.Focus()
    End Sub
    Private Sub btnMostrarTeclado_Click(sender As Object, e As EventArgs) Handles btnMostrarTeclado.Click
        Dim frm As New frmTeclado
        frm.ShowDialog()
    End Sub

    Private Sub rbCodBarra_Click(sender As Object, e As EventArgs) Handles rbCodBarra.Click
        txtInsumos.Clear()
        txtInsumos.Focus()
        dgvArticulos.DataSource = ""
    End Sub
    Private Sub rbNombre_Click(sender As Object, e As EventArgs) Handles rbNombre.Click
        txtInsumos.Clear()
        txtInsumos.Focus()
        dgvArticulos.DataSource = ""
    End Sub
    Private Sub txtInsumos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInsumos.KeyDown
        If dgvArticulos.RowCount > 0 Then
            If e.KeyCode = 40 Then
                If (dgvArticulos.CurrentCell.RowIndex < dgvArticulos.RowCount - 1) Then
                    dgvArticulos.CurrentCell = dgvArticulos.Item(0, dgvArticulos.CurrentCell.RowIndex + 1)
                End If
            ElseIf e.KeyCode = 38 Then
                If (dgvArticulos.CurrentCell.RowIndex > 0) Then
                    dgvArticulos.CurrentCell = dgvArticulos.Item(0, dgvArticulos.CurrentCell.RowIndex - 1)
                End If
            End If
        End If
    End Sub
    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        If txtCantidad.Text.Trim = "" Then
            txtCantidad.Text = "0"
        End If
        If Convert.ToDecimal(txtCantidad.Text) > 0 Then
            txtCantidad.Text = Convert.ToDecimal(txtCantidad.Text) - 1
            txtInsumos.Focus()
        End If
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvEntradas.RowCount > 0 Then
            If MsgBox("Esta seguro de eliminar este Registro?", vbExclamation + vbYesNo, "Eliminar Ingreso") = vbYes Then
                cmd = New OleDbCommand("DELETE FROM PRODENTRADAS WHERE ID=" & dgvEntradas.Item(0, dgvEntradas.CurrentCell.RowIndex).Value & "", bd)
                cmd.ExecuteNonQuery()

                'luego actualiza el stock
                cmd = New OleDbCommand("UPDATE PRODUCTS SET STOCK=STOCK-" &
                dgvEntradas.Item(3, dgvEntradas.CurrentCell.RowIndex).Value & " WHERE ID=" & dgvEntradas.Item(1, dgvEntradas.CurrentCell.RowIndex).Value & "", bd)
                cmd.ExecuteNonQuery()

                LLENA_GRID_INGRESOS()
                MsgBox("Se eliminó correctamente", vbInformation)
            End If
        End If
    End Sub

    Public Sub ActualizaStock()
        Dim cantidad As Decimal = 0
        If txtCantidad.Text.Trim = "" Then
            cantidad = 1
        Else
            cantidad = Convert.ToDecimal(txtCantidad.Text)
        End If
        'luego actualiza el stock
        cmd = New OleDbCommand("UPDATE PRODUCTS SET STOCK=STOCK+" &
                               cantidad & " WHERE ID=" & dgvArticulos.Item(0, dgvArticulos.CurrentCell.RowIndex).Value & "", bd)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub dtFecha1_ValueChanged(sender As Object, e As EventArgs) 
        LLENA_GRID_INGRESOS()
    End Sub
End Class