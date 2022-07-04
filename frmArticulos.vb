Imports System.Data.OleDb
Public Class frmArticulos
    Dim DA As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim textobusqueda As String
    Dim ID_PROD As Integer = 0
    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbNombre.Click
        txtBusqueda.Focus()
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbCodBarra.Click
        txtBusqueda.Focus()
    End Sub
    Private Sub RadioButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        txtBusqueda.Focus()
    End Sub

    Private Sub frmArticulos_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        llenagrid()
    End Sub
    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenagrid()
        Me.Top = 0
        Me.Left = 0
        txtBusqueda.Focus()
    End Sub
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBusqueda.GotFocus
        txtBusqueda.BackColor = Color.GreenYellow
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyDown
        If dgvArticulos.RowCount < 1 Then
        Else
            If e.KeyCode = 40 Then 'este key code es haca abajo
                If (dgvArticulos.CurrentCell.RowIndex < dgvArticulos.RowCount - 1) Then
                    dgvArticulos.CurrentCell = dgvArticulos.Item(0, dgvArticulos.CurrentCell.RowIndex + 1)
                End If
            ElseIf e.KeyCode = 38 Then ' este key code es hacia arriba
                If (dgvArticulos.CurrentCell.RowIndex > 0) Then
                    dgvArticulos.CurrentCell = dgvArticulos.Item(0, dgvArticulos.CurrentCell.RowIndex - 1)
                End If
            End If

        End If
        If e.KeyCode = Keys.F1 Then
            BotonNuevo()
        End If
        If e.KeyCode = Keys.F2 Then
            BotonEditar()
        End If
        If e.KeyCode = Keys.F3 Then
            BotonEliminar()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If rbCodBarra.Checked = True Then
                DA = New OleDbDataAdapter("select id as ID,codigo_barra as CODIGO_BARRA,categoria as CATEGORIA, description as ARTICULO,presentacion as PRESENTACION, Stock as STOCK, precio as PRECIO,act as ACTIVO from products where codigo_barra ='" & txtBusqueda.Text & "'", bd)
                Dim DT As New DataTable
                DA.Fill(DT)
                If DT.Rows.Count = 1 Then
                    dgvArticulos.DataSource = DT
                Else
                    MsgBox("No existe artículo con este código de Barra", vbExclamation)
                End If

            End If
            If dgvArticulos.RowCount < 1 Then
                MsgBox("No existe este artículo ", vbExclamation, "Insumos")
            Else
                If rbEdicion.Checked = True Then
                    BotonEditar()
                End If
            End If
        End If
        If Asc(e.KeyChar) = 27 Then
            Close()
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Close()
    End Sub
    Public Sub llenagrid()
        Dim ACTIVOS As String
        If chkListarActivos.Checked Then
            ACTIVOS = "Si"
        Else
            ACTIVOS = "%"
        End If
        textobusqueda = txtBusqueda.Text
        If txtBusqueda.Text.Trim = "" Then
            textobusqueda = "%"
        End If

        'OBTENER ID DEL PRODUCTO ACTUALIZADO PARA LUEGO RESALTARLO DE AZUL EN EL GRID
        If dgvArticulos.RowCount > 0 Then

            ID_PROD = dgvArticulos.CurrentRow.Cells(0).Value
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If rbNombre.Checked = True Or rbCodBarra.Checked = True Then
            If rbNombre.Checked = True Then
                DA = New OleDbDataAdapter("select id as ID,codigo_barra as CODIGO_BARRA,categoria as CATEGORIA,description as ARTICULO,presentacion as PRESENTACION,stock as STOCK, precio as PRECIO, act as ACTIVO from products where description like'%" & textobusqueda.Trim & "%' AND act like'%" & ACTIVOS & "%' order by products.id desc", bd)
            ElseIf rbCodBarra.Checked = True Then
                DA = New OleDbDataAdapter("select id as ID,codigo_barra as CODIGO_BARRA,categoria as CATEGORIA,description as ARTICULO,presentacion as PRESENTACION,stock as STOCK, precio as PRECIO, act as ACTIVO from products where codigo_barra ='" & textobusqueda.Trim & "' AND act ='" & ACTIVOS & "' order by products.id desc", bd)
            End If
            Dim dataset As New DataSet
            DA.Fill(dataset, "nombre")
            dgvArticulos.DataSource = dataset.Tables(0)

            If dgvArticulos.RowCount > 0 Then
                If modo = "1" Then
                    'SEÑALA EL REGISTRO NUEVO RESALTADO DE COLOR AZUL
                    dgvArticulos.CurrentCell = dgvArticulos.Item(0, 0)
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ElseIf modo = "2" Then
                    For index = 0 To dgvArticulos.RowCount - 1
                        If dgvArticulos.Item(0, index).Value = ID_PROD Then
                            'SEÑALA EL REGISTRO NUEVO RESALTADO DE COLOR AZUL
                            dgvArticulos.CurrentCell = dgvArticulos.Item(0, index)
                            ''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        End If
                    Next
                End If
            End If
        End If
        txtCantidadProductos.Text = dgvArticulos.RowCount
    End Sub
    Private Sub BotonNuevo()
        modo = "1"
        frmArticuloNE.Text = "Nuevo"
        frmArticuloNE.ShowDialog()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BotonNuevo()
    End Sub

    Private Sub BotonEliminar()
        If dgvArticulos.RowCount > 1 Then
            If MsgBox("Esta seguro de querer eliminar el articulo no se recomienda eliminar el producto, puede inhabilitar en la opcion editar:" & dgvArticulos.Item(3, dgvArticulos.CurrentCell.RowIndex).Value.ToString, vbExclamation + vbYesNo, "Insumo") = vbYes Then
                cmd = New OleDbCommand("delete from products where ID=" & dgvArticulos.Item(0, dgvArticulos.CurrentCell.RowIndex).Value & "", bd)
                cmd.ExecuteNonQuery()
                llenagrid()
            End If
        Else
            MsgBox("No hay articulos a eliminar", vbExclamation, "Insumos")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombre.CheckedChanged
        limpiatextbox()
        txtBusqueda.Focus()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodBarra.CheckedChanged
        limpiatextbox()
        txtBusqueda.Focus()
    End Sub
    Public Sub limpiatextbox()
        txtBusqueda.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        BotonEditar()
    End Sub
    Public Sub BotonEditar()
        If dgvArticulos.RowCount > 0 Then
            modo = "2"
            frmArticuloNE.Text = "Editar Articulo"
            frmArticuloNE.ShowDialog()
        Else
            MsgBox("No hay un Artíclulo seleccionado Para Editar", vbExclamation)
        End If
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArticulos.CellDoubleClick
        BotonEditar()
    End Sub

    Private Sub chkListarActivos_CheckedChanged(sender As Object, e As EventArgs) Handles chkListarActivos.CheckedChanged
        txtBusqueda.Clear()
    End Sub

    Private Sub dgvArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvArticulos.KeyDown
        If e.KeyCode = Keys.F1 Then
            BotonNuevo()
        End If
        If e.KeyCode = Keys.F2 Then
            BotonEditar()
        End If
        If e.KeyCode = Keys.F3 Then
            BotonEliminar()
        End If
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        BotonEliminar()
    End Sub
    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            ''Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            '' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = dgvArticulos.ColumnCount
            Dim NRow As Integer = dgvArticulos.RowCount
            ''Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = dgvArticulos.Columns(i - 1).Name.ToString
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = dgvArticulos.Rows(Fila).Cells(Col).Value
                Next
            Next
            ''Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            ''Aplicación visible
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        llenagrid()
    End Sub

End Class