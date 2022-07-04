Imports System.Data.OleDb
Public Class frmImpuestosOtros
    Private Sub frmImpuestosOtros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DA As New OleDbDataAdapter
        Dim DT As New DataTable

        DA = New OleDbDataAdapter("SELECT * FROM ImpuestosOtros", bd)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            txtNombreImpuesto.Text = DT(0)(1).ToString
            txtPorcentajeImpuesto.Text = DT(0)(2).ToString
            txtSimboloMoneda.Text = DT(0)(3).ToString
            txtNombreMoneda.Text = DT(0)(4).ToString
            txtMsjeAgradecer.Text = DT(0)(5).ToString
            chkRedondeo.Checked = DT(0)(6)
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txtPorcentajeImpuesto.Text.Trim = "" Or txtNombreImpuesto.Text.Trim = "" Or txtSimboloMoneda.Text.Trim = "" Or txtNombreMoneda.Text.Trim = "" Or txtMsjeAgradecer.Text.Trim = "" Then
            MsgBox("No está permitido dejar en blanco algunos campos", vbExclamation)
            Exit Sub
        End If
        Dim CMD As New OleDbCommand

        CMD = New OleDbCommand("UPDATE ImpuestosOtros set " &
                   "NombreImpuesto='" & txtNombreImpuesto.Text.Trim &
                   "',PorcentajeImpuesto=" & Convert.ToDecimal(txtPorcentajeImpuesto.Text.Trim) &
                   ",Moneda='" & txtSimboloMoneda.Text.Trim &
                   "',NombreMoneda='" & txtNombreMoneda.Text.Trim &
                   "',MensajeAgradecer='" & txtMsjeAgradecer.Text.Trim &
                   "',redondeo='" & chkRedondeo.CheckState & "'", bd)

        CMD.ExecuteNonQuery()
        MsgBox("Registro Actualizado", vbInformation)
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class