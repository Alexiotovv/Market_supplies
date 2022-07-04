Imports System.Data.OleDb
Public Class frmVentasAnuladas
    Private Sub frmVentasAnuladas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFecha1.Value = Today
        dtFecha2.Value = Today
        txtCantidad.Clear()
    End Sub
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        dgvVentasAnuladas.DataSource = ""
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

        mes1 = dtFecha1.Value.Month
        dia1 = dtFecha1.Value.Day
        ano1 = dtFecha1.Value.Year

        mes2 = dtFecha2.Value.Month
        dia2 = dtFecha2.Value.Day
        ano2 = dtFecha2.Value.Year

        fech1 = mes1 & "/" & dia1 & "/" & ano1
        fech2 = mes2 & "/" & dia2 & "/" & ano2

        DA = New OleDbDataAdapter("SELECT prodsalidas.Orden_id, " &
                                 "prodsalidas.serie, " &
                                 "prodsalidas.numero, " &
                                 "prodsalidas.comprobante, " &
                                 "products.categoria, " &
                                 "products.description, " &
                                 "products.presentacion, " &
                                 "prodsalidas.cantidad, " &
                                 "prodsalidas.precio, " &
                                 "prodsalidas.total, " &
                                 "prodsalidas.fechsalida, " &
                                 "prodsalidas.anulado " &
       " FROM products LEFT JOIN prodsalidas ON prodsalidas.id_products = products.id" &
       " Where ((prodsalidas.fechsalida) between #" & fech1 & "# and #" & fech2 & "# and prodsalidas.anulado=True)", bd)
        '" WHERE ((prodsalidas.fechsalida) between #" & dtpDesde.Value & "# and #" & dtpHasta.Value & "#)", bd)
        DA.Fill(DT)
        dgvVentasAnuladas.DataSource = DT
        txtCantidad.Text = dgvVentasAnuladas.RowCount - 1
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
            Dim NCol As Integer = dgvVentasAnuladas.ColumnCount
            Dim NRow As Integer = dgvVentasAnuladas.RowCount
            ''Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = dgvVentasAnuladas.Columns(i - 1).Name.ToString
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = dgvVentasAnuladas.Rows(Fila).Cells(Col).Value
                Next
            Next
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