Imports System.Data.OleDb
Public Class frmDatosEmpresa
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FORM_DATOSEMPRESA = True
        Dim frm As New frmEmpresa
        frm.ShowDialog()
        dgvEmpresas.Focus()
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dgvEmpresas.RowCount > 0 Then
                FORM_DATOSEMPRESA = False
                Dim frm As New frmEmpresa
                frm.txtId.Text = dgvEmpresas.Item(0, dgvEmpresas.CurrentCell.RowIndex).Value
                frm.txtNombreComercial.Text = dgvEmpresas.Item(1, dgvEmpresas.CurrentCell.RowIndex).Value
                frm.txtRazon.Text = dgvEmpresas.Item(2, dgvEmpresas.CurrentCell.RowIndex).Value.ToString
                frm.txtRuc.Text = dgvEmpresas.Item(3, dgvEmpresas.CurrentCell.RowIndex).Value.ToString
                frm.txtTelefono.Text = dgvEmpresas.Item(4, dgvEmpresas.CurrentCell.RowIndex).Value.ToString
                frm.txtCelular.Text = dgvEmpresas.Item(5, dgvEmpresas.CurrentCell.RowIndex).Value.ToString
                frm.txtDireccion.Text = dgvEmpresas.Item(6, dgvEmpresas.CurrentCell.RowIndex).Value.ToString
                frm.txtRegion.Text = dgvEmpresas.Item(7, dgvEmpresas.CurrentCell.RowIndex).Value.ToString
                frm.ShowDialog()
            Else
                MsgBox("No hay registros para modificar", vbExclamation)
            End If
            dgvEmpresas.Focus()
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmDatosEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaGrid()
    End Sub
    Public Sub LlenaGrid()
        dgvEmpresas.DataSource = ""
        Dim DA As New OleDbDataAdapter
        Dim DT As New DataTable

        DA = New OleDbDataAdapter("SELECT * FROM DATOSEMPRESA", bd)
        DA.Fill(DT)
        dgvEmpresas.DataSource = DT
        dgvEmpresas.Refresh()
    End Sub
    Private Sub frmDatosEmpresa_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        LlenaGrid()
    End Sub
    Private Sub dgvEmpresas_GotFocus(sender As Object, e As EventArgs) Handles dgvEmpresas.GotFocus
        LlenaGrid()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvEmpresas.RowCount > 0 Then
                If MsgBox("Esta seguro de realizar esta acción", vbExclamation + vbYesNo, "Acción") = vbYes Then
                    Dim CMD As New OleDbCommand
                    CMD = New OleDbCommand("DELETE FROM DATOSEMPRESA WHERE ID=" & dgvEmpresas.Item(0, dgvEmpresas.CurrentCell.RowIndex).Value & "", bd)
                    CMD.ExecuteNonQuery()
                    MsgBox("Registro Eliminado", vbInformation)
                End If

            End If
            dgvEmpresas.Focus()
        Catch ex As Exception

        End Try


    End Sub
End Class