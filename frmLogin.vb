Imports System.Data.OleDb
Public Class frmLogin
    Dim cmd As New OleDbCommand
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str As String = (Application.StartupPath & "\bdinsumos.mdb")
        bd.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & str & ";")
        bd.Open()
        CargarDatosEmpresa()
    End Sub
    Private Sub CargarDatosEmpresa()
        Dim DA As New OleDbDataAdapter
        Dim DT As New DataTable
        DA = New OleDbDataAdapter("SELECT ID,NOMBRECOMERCIAL FROM DATOSEMPRESA", bd)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmbEmpresa.DataSource = DT
            cmbEmpresa.DisplayMember = "NOMBRECOMERCIAL"
            cmbEmpresa.ValueMember = "ID"
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        bd.Close()
        Close()
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            entrar()
        End If
    End Sub
    Public Sub entrar()
        'Aplicando Versión Prueba
        Dim FechaHoy As Date
        Dim FechaLimite As Date

        FechaHoy = Today
        FechaLimite = "28/11/2020"
        If FechaHoy > FechaLimite Then
            MsgBox("Lo Sentimos La Licencia expiró, Contacto: alexiotovv@gmail.com", vbExclamation)
            Me.Close()
        Else
            usu = TextBox1.Text.Trim.ToUpper
            cmd = New OleDbCommand("Select id from usuarios where user='" & usu & "' and pas='" & TextBox2.Text.Trim & "'", bd)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            If reader.Read = True Then
                Me.Visible = False
                frmPrincipal.Label2.Text = usu
                frmPrincipal.Show()
            Else
                MsgBox("Usuario o contraseña incorrecto, intente nuevamente por favor", vbInformation, "Insumos")
            End If

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        entrar()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub cmbEmpresa_Click(sender As Object, e As EventArgs) Handles cmbEmpresa.Click
        If cmbEmpresa.Items.Count = 0 Then
            MsgBox("Aún no existe empresa, Inicia Sesión y registra en la opcion Herramientas/Registrar Datos de la Empresa", vbInformation)
        End If
    End Sub

    Private Sub cmbEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresa.SelectedIndexChanged
        Try
            If cmbEmpresa.Items.Count > 0 Then
                ID_EMPRESA = cmbEmpresa.SelectedValue(0)
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class