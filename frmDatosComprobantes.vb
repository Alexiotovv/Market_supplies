Imports System.Data.OleDb
Public Class frmDatosComprobantes
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FORM_DATOSCOMPROBANTE = True
        Dim frm As New frmComprobantes
        frm.ShowDialog()
        dgvComprobante.Focus() 'importante que este al ultimo
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvComprobante.RowCount > 0 Then
            FORM_DATOSCOMPROBANTE = False
            Dim frm As New frmComprobantes
            frm.txtId.Text = dgvComprobante.Item(0, dgvComprobante.CurrentCell.RowIndex).Value.ToString
            frm.txtComprobante.Text = dgvComprobante.Item(1, dgvComprobante.CurrentCell.RowIndex).Value
            frm.nudSerie.Value = dgvComprobante.Item(2, dgvComprobante.CurrentCell.RowIndex).Value
            frm.nudNumero.Value = dgvComprobante.Item(3, dgvComprobante.CurrentCell.RowIndex).Value
            frm.ShowDialog()
            dgvComprobante.Focus() 'importante que este al ultimo
        End If

    End Sub
    Private Sub dgvEmpresas_GotFocus(sender As Object, e As EventArgs) Handles dgvComprobante.GotFocus
        LlenaGrid()
    End Sub
    Public Sub LlenaGrid()
        Dim DA As New OleDbDataAdapter
        Dim DT As New DataTable
        DA = New OleDbDataAdapter("SELECT * FROM COMPROBANTE", bd)
        DA.Fill(DT)
        dgvComprobante.DataSource = DT
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class