Imports System.Data.OleDb
Public Class frmUsuarios
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frm As New frmRegistroUsuario
        frm.Text = "Nuevo"
        frm.ShowDialog()


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim frm As New frmRegistroUsuario
        frm.Text = "Editar"
        frm.txtId.Text = dgvUsuarios.Item(0, dgvUsuarios.CurrentCell.RowIndex).Value
        frm.txtNombre.Text = dgvUsuarios.Item(1, dgvUsuarios.CurrentCell.RowIndex).Value
        frm.txtNombreUsuario.Text = dgvUsuarios.Item(2, dgvUsuarios.CurrentCell.RowIndex).Value
        frm.txtContraseña.Text = dgvUsuarios.Item(3, dgvUsuarios.CurrentCell.RowIndex).Value
        frm.txtRepetirContraseña.Text = dgvUsuarios.Item(3, dgvUsuarios.CurrentCell.RowIndex).Value
        frm.ShowDialog()
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarUsuarios()
    End Sub
    Public Sub LlenarUsuarios()
        Dim DA As New OleDbDataAdapter
        Dim DT As New DataTable
        DA = New OleDbDataAdapter("SELECT * FROM USUARIOS", bd)
        DA.Fill(DT)
        dgvUsuarios.DataSource = DT
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim cmd As New OleDbCommand
        cmd = New OleDbCommand("delete from usuarios where id=" &
                              dgvUsuarios.Item(0, dgvUsuarios.CurrentCell.RowIndex).Value & "", bd)
        cmd.ExecuteNonQuery()
        MsgBox("Usuario Eliminado Correctamente", vbInformation)
        LlenarUsuarios()
    End Sub
End Class