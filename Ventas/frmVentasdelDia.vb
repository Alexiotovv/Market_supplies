Imports System.Data.OleDb
Public Class frmVentasdelDia
    Private Sub rbOtrasFechas_CheckedChanged(sender As Object, e As EventArgs) Handles rbOtrasFechas.CheckedChanged
        Inicializar()

        If rbOtrasFechas.Checked = True Then
            dtpFechaInicio.Visible = True
            dtpFechaFinal.Visible = True
            lblRangoFechas.Visible = True

        Else
            dtpFechaInicio.Visible = False
            dtpFechaFinal.Visible = False
            lblRangoFechas.Visible = False
        End If
    End Sub

    Private Sub frmVentasdelDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Public Sub Inicializar()
        dtpFechaInicio.Value = Today
        dtpFechaFinal.Value = Today
    End Sub
    Public Sub Limpiar()
        txtTotal.Clear()
        dgvVentas.DataSource = ""
    End Sub
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

        Limpiar()

        Dim DA As New OleDbDataAdapter
        Dim DT As New DataTable

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

        Dim cadena As String
        If rbVentasHoy.Checked = True Then
            cadena = "where prodsalidas.fechsalida between # " & Today & " # and # " & Today & "#"
        Else
            cadena = "where prodsalidas.fechsalida between # " & fech1 & " # and # " & fech2 & "#"
        End If

        DA = New OleDbDataAdapter("SELECT products.codigo_barra," &
                                  "products.categoria," &
                                  "products.description," &
                                  "products.stock," &
                                  "products.precio," &
                                  "products.presentacion," &
                                  "prodsalidas.cantidad," &
                                  "prodsalidas.total," &
                                  "prodsalidas.efectivo," &
                                  "prodsalidas.comprobante," &
                                  "prodsalidas.vuelto," &
                                  "prodsalidas.tipopago," &
                                  "prodsalidas.fechsalida," &
                                  "prodsalidas.serie," &
                                  "prodsalidas.numero" &
                                " FROM products INNER JOIN " &
                                "prodsalidas ON " &
                                "products.id = prodsalidas.id_products " &
                                cadena, bd)

        DA.Fill(DT)

        If DT.Rows.Count > 0 Then
            dgvVentas.DataSource = DT
        End If
        Dim total As Decimal
        Dim VentaTotal As String
        For index = 1 To dgvVentas.RowCount - 1
            total = total + dgvVentas.Item(7, index).Value
        Next
        VentaTotal = "S/ " & total
        txtTotal.Text = VentaTotal
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
            Dim NCol As Integer = dgvVentas.ColumnCount
            Dim NRow As Integer = dgvVentas.RowCount


            ProgressBar1.Visible = True
            ProgressBar1.Maximum = NRow

            ''Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = dgvVentas.Columns(i - 1).Name.ToString
            Next

            For Fila As Integer = 0 To NRow - 1
                ProgressBar1.Value = Fila
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = dgvVentas.Rows(Fila).Cells(Col).Value
                Next
            Next


            ProgressBar1.Visible = False
            ProgressBar1.Value = 0
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