Imports System.Data.OleDb
Public Class frmEmpresa
    Dim CMD As New OleDbCommand
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub
    Public Sub Limpiar()
        txtId.Clear()
        txtNombreComercial.Clear()
        txtRazon.Clear()
        txtRuc.Clear()
        txtTelefono.Clear()
        txtCelular.Clear()
        txtDireccion.Clear()
        txtRegion.Clear()
        txtNombreComercial.Focus()
    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim NC, RA, TEL, CEL, DIR, REG, RUC As String
        Dim ID As Integer

        NC = txtNombreComercial.Text.Trim
        RA = txtRazon.Text.Trim
        RUC = txtRuc.Text.Trim
        TEL = txtTelefono.Text.Trim
        CEL = txtCelular.Text.Trim
        DIR = txtDireccion.Text.Trim
        REG = txtRegion.Text.Trim

        If NC = "" Or RA = "" Or RUC = "" Or CEL = "" Or DIR = "" Or REG = "" Then
            MsgBox("No puede dejar algunos datos vacíos", vbExclamation)
            Exit Sub
        End If
        If FORM_DATOSEMPRESA = True Then 'Verdadero es Registro
            CMD = New OleDbCommand("INSERT INTO DATOSEMPRESA(NombreComercial," &
            "RazonSocial,Ruc,Telefono,Celular,Direccion,PaisRegion) VALUES('" &
            NC & "','" & RA & "','" & RUC & "','" & TEL & "','" & CEL & "','" &
            DIR & "','" & REG & "')", bd)
            CMD.ExecuteNonQuery()
            MsgBox("Registro Guardado", vbInformation)
            Me.Close()
        Else 'Falso es Actualizar
            ID = Convert.ToInt32(txtId.Text.Trim)
            CMD = New OleDbCommand("UPDATE DATOSEMPRESA SET " &
                              "NombreComercial='" & NC &
                               "',RazonSocial='" & RA &
                               "',Ruc='" & RUC &
                               "',Telefono='" & TEL &
                               "',Celular='" & CEL &
                               "',Direccion='" & DIR &
                               "',PaisRegion='" & REG &
                               "' where ID=" & ID & "", bd)
            CMD.ExecuteNonQuery()
            MsgBox("Registro Actualizado", vbInformation)
            Me.Close()
        End If

    End Sub
    Private Sub frmEmpresa_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub
    Private Sub frmEmpresa_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Dim frm As New frmDatosEmpresa
        frm.LlenaGrid()
    End Sub

    Private Sub frmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class