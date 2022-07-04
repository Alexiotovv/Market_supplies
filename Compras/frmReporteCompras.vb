Imports System.Data.OleDb
Public Class frmReporteCompras
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            Dim mes1 As String = ""
            Dim dia1 As String = ""
            Dim ano1 As String = ""
            Dim fech1 As String = ""

            Dim mes2 As String = ""
            Dim dia2 As String = ""
            Dim ano2 As String = ""
            Dim fech2 As String = ""

            mes1 = dtpFechaInicio.Value.Month
            dia1 = dtpFechaInicio.Value.Day
            ano1 = dtpFechaInicio.Value.Year

            mes2 = dtpFechaFinal.Value.Month
            dia2 = dtpFechaFinal.Value.Day
            ano2 = dtpFechaFinal.Value.Year

            fech1 = mes1 & "/" & dia1 & "/" & ano1
            fech2 = mes2 & "/" & dia2 & "/" & ano2

            Dim DA As New OleDbDataAdapter
            Dim DT As New DataTable

            Dim cadena As String = ""

            If rbSerieNumero.Checked = True Then
                cadena = "where prodentradas.serie =" & Convert.ToInt32(txtSerie.Text) & " and prodentradas.numero=" & Convert.ToInt32(txtNumero.Text) & ""
                If txtSerie.Text = "0" Or txtNumero.Text = "0" Then
                    MsgBox("Debe ingresar serie y numero válido de un comprobante", vbExclamation)
                    Exit Sub
                End If
            Else
                cadena = "where prodentradas.fechentrada between # " & fech1 & " # and # " & fech2 & "#"
            End If
            dgvListaCompras.DataSource = ""
            DA = New OleDbDataAdapter("SELECT products.codigo_barra," &
                                      "products.categoria," &
                                      "products.description," &
                                      "products.stock," &
                                      "products.precio_compra," &
                                      "products.presentacion," &
                                      "prodentradas.cantidad," &
                                      "prodentradas.total," &
                                      "prodentradas.comprobante," &
                                      "prodentradas.fechentrada," &
                                      "prodentradas.serie," &
                                      "prodentradas.numero" &
                                    " FROM products INNER JOIN " &
                                    "prodentradas ON " &
                                    "products.id = prodentradas.id_products " &
                                    cadena, bd)
            DA.Fill(DT)

            If DT.Rows.Count > 0 Then
                dgvListaCompras.DataSource = DT
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged

    End Sub

    Private Sub rbFecha_Click(sender As Object, e As EventArgs) Handles rbFecha.Click
        dtpFechaInicio.Visible = True
        dtpFechaFinal.Visible = True
        lblDesde.Visible = True
        lblHasta.Visible = True
        txtSerie.Visible = False
        txtNumero.Visible = False
        lblSerie.Visible = False
        lblNumero.Visible = False

    End Sub

    Private Sub rbSerieNumero_Click(sender As Object, e As EventArgs) Handles rbSerieNumero.Click
        dtpFechaInicio.Visible = False
        dtpFechaFinal.Visible = False
        lblDesde.Visible = False
        lblHasta.Visible = False
        txtSerie.Visible = True
        txtNumero.Visible = True
        lblSerie.Visible = True
        lblNumero.Visible = True
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        ExportaExcel(dgvListaCompras)
    End Sub
End Class