Imports System.Data.OleDb
Public Class frmEmpleados
    Dim cmd As New OleDb.OleDbCommand
    Dim dap As New OleDb.OleDbDataAdapter
    Dim hab As String

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        llenagrid()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        frmEmpleado.Text = "Registrar Nuevo Empleado"
        frmEmpleado.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        editarempleado()
    End Sub
    Public Sub editarempleado()
        If dgvClientes.CurrentCell.RowIndex <> dgvClientes.RowCount - 1 Then
            frmEmpleado.Text = "Editar Empleado"
            frmEmpleado.txtId.Text = dgvClientes.Item(0, dgvClientes.CurrentCell.RowIndex).Value
            frmEmpleado.txtRucDni.Text = dgvClientes.Item(1, dgvClientes.CurrentCell.RowIndex).Value
            frmEmpleado.txtNombre.Text = dgvClientes.Item(2, dgvClientes.CurrentCell.RowIndex).Value
            frmEmpleado.txtDireccion.Text = dgvClientes.Item(3, dgvClientes.CurrentCell.RowIndex).Value
            frmEmpleado.txtFono.Text = dgvClientes.Item(4, dgvClientes.CurrentCell.RowIndex).Value
            frmEmpleado.txtCorreo.Text = dgvClientes.Item(5, dgvClientes.CurrentCell.RowIndex).Value
            If dgvClientes.Item(6, dgvClientes.CurrentCell.RowIndex).Value = "Si" Then
                frmEmpleado.chkHabilitado.Checked = True
            Else
                frmEmpleado.chkHabilitado.Checked = False
            End If
            frmEmpleado.ShowDialog()
        End If
    End Sub
    Public Sub llenagrid()
        If chkHabilitados.Checked = True Then
            hab = "%"
        Else
            hab = "Si"
        End If

        If txtBusqueda.Text.Trim = "" Then
            dap = New OleDbDataAdapter("select id_employee as Codigo, " &
                                       " ruc_dni as RucDni, " &
                                       " fullname as Nombre, " &
                                       " address as Direccion, " &
                                       " phone as Telefono, " &
                                       "email as Correo, " &
                                       "activate as Activado " &
                                       " from employees where Activate Like '" & hab & "'", bd)
        Else
            If RadioButton1.Checked = True Then
                dap = New OleDbDataAdapter("select id_employee as Codigo, " &
                                       " ruc_dni as RucDni, " &
                                       " fullname as Nombre, " &
                                       " address as Direccion, " &
                                       " phone as Telefono, " &
                                       "email as Correo, " &
                                       "activate as Activado from employees Where id_employee Like'" & txtBusqueda.Text & "' and Activate like'" & hab & "'", bd)
            Else
                dap = New OleDbDataAdapter("select id_employee as Codigo, " &
                                       " ruc_dni as RucDni, " &
                                       " fullname as Nombre, " &
                                       " address as Direccion, " &
                                       " phone as Telefono, " &
                                       "email as Correo, " &
                                       "activate as Activado  from employees Where fullname Like '%" & txtBusqueda.Text & "%' and Activate like'" & hab & "'", bd)
            End If
        End If

        Dim dataset As New DataSet
        dap.Fill(dataset, "nombre")
        dgvClientes.DataSource = dataset.Tables(0)
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBusqueda.GotFocus
        txtBusqueda.BackColor = Color.GreenYellow
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBusqueda.LostFocus
        txtBusqueda.BackColor = Color.White
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        llenagrid()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        txtBusqueda.Focus()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        txtBusqueda.Focus()
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellContentDoubleClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        editarempleado()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        cmd = New OleDbCommand("update employees set Activate='No' where id_employee=" & dgvClientes.Item(0, dgvClientes.CurrentCell.RowIndex).Value & "", bd)
        cmd.ExecuteNonQuery()
        MsgBox("EMpleado Desactivado", vbInformation)
        llenagrid()
    End Sub

    Private Sub chkHabilitados_CheckedChanged(sender As Object, e As EventArgs) Handles chkHabilitados.CheckedChanged
        txtBusqueda.Focus()
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
            Dim NCol As Integer = dgvClientes.ColumnCount
            Dim NRow As Integer = dgvClientes.RowCount
            ''Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = dgvClientes.Columns(i - 1).Name.ToString
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = dgvClientes.Rows(Fila).Cells(Col).Value
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
End Class