Imports System.Data.OleDb
Public Class frmComprobantes
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub
    Public Sub Limpiar()
        txtId.Clear()
        txtComprobante.Clear()
        nudSerie.Value = 0
        nudNumero.Value = 0
        txtComprobante.Focus()
    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If FORM_DATOSCOMPROBANTE = True Then
            If txtComprobante.Text.Trim <> "" Then
                Dim CMD As New OleDbCommand

                CMD = New OleDbCommand("INSERT INTO COMPROBANTE(NOMBRE,SERIE,NUMERO)VALUES('" &
                                          txtComprobante.Text.Trim & "'," &
                                          nudSerie.Value & "," &
                                          nudNumero.Value & ")", bd)
                CMD.ExecuteNonQuery()
                MsgBox("Registro Guardado", vbInformation)
                Me.Close()
            End If
        Else
            If txtComprobante.Text.Trim <> "" Then
                Dim CMD As New OleDbCommand
                CMD = New OleDbCommand("UPDATE Comprobante SET Nombre='" &
                                      txtComprobante.Text.Trim &
                                      "',Serie=" & nudSerie.Value &
                                      ",Numero=" & nudNumero.Value & " where Id=" & Convert.ToInt32(txtId.Text) & "", bd)
                CMD.ExecuteNonQuery()
                MsgBox("Registro Actualizado", vbInformation)
                Me.Close()
            End If

        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmComprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class