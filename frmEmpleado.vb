Imports System.Data.OleDb
Public Class frmEmpleado
    Dim cmd As New OleDbCommand
    Private Sub frmEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "Registrar Nuevo Empleado" Then
            limpiar()
            txtNombre.Focus()
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar()

    End Sub
    Public Sub limpiar()
        txtId.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtFono.Text = ""
        txtCorreo.Text = ""
        txtRucDni.Clear()
        chkHabilitado.Checked = True
        txtNombre.Focus()
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim hab As String = ""
            If chkHabilitado.Checked = True Then
                hab = "Si"
            Else
                hab = "No"
            End If
            If Me.Text = "Registrar Nuevo Cliente" Then
                If txtNombre.Text.Trim = "" Then
                    MsgBox("No puede Dejar vacio el campo Nombre del Empleado")
                    Exit Sub
                End If

                cmd = New OleDbCommand("insert into employees(fullname,address,phone,email,activate,ruc_dni) values('" & txtNombre.Text & "','" & txtDireccion.Text & "','" & txtFono.Text & "','" & txtCorreo.Text & "','" & hab & "','" & txtRucDni.Text.Trim & "')", bd)
                cmd.ExecuteNonQuery()
                MsgBox("Registro Guardado")
                frmEmpleados.llenagrid()
                Close()
            Else
                cmd = New OleDbCommand("update employees set fullname='" & txtNombre.Text & "',address='" & txtDireccion.Text & "',phone='" & txtFono.Text & "',email='" & txtCorreo.Text & "',activate='" & hab & "', ruc_dni='" & txtRucDni.Text.Trim & "' where id_employee=" & Convert.ToInt32(txtId.Text) & "", bd)
                cmd.ExecuteNonQuery()
                MsgBox("Registro Actualizado")
                frmEmpleados.llenagrid()
                Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDireccion.Focus()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtFono.Focus()
        End If
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFono.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCorreo.Focus()
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            chkHabilitado.Focus()
        End If
    End Sub
    Private Sub CheckBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkHabilitado.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAceptar.Focus()
        End If
    End Sub

    Private Sub txtRucDni_KeyPress(sender As Object, e As KeyPressEventArgs)
        txtNombre.Focus()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        cmd = New OleDbCommand("select id_employee as COD_EMPLEADO,fullname as NOMBRE_COMPLETO,address as DIRECCION,phone as TELEFONO,email as CORREO,activate as ACTIVO, ruc_dni from employees where id_employee =" & IDEMPLEADO & " and Activate ='Si'", bd)

        dr = cmd.ExecuteReader
        If dr.Read Then
            txtId.Text = dr.Item(0).ToString
            txtRucDni.Text = dr.Item(6).ToString
            txtNombre.Text = dr.Item(1).ToString
            txtDireccion.Text = dr.Item(2).ToString
            txtFono.Text = dr.Item(3).ToString
            txtCorreo.Text = dr.Item(4).ToString

        End If

    End Sub
    Private Sub txtCorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAceptar.Focus()
        End If
    End Sub
End Class