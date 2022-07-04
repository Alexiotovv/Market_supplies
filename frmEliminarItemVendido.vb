Imports System.Data.OleDb
Public Class frmEliminarItemVendido
    Dim cmd As New OleDbCommand
    Private Sub frmEliminarItemVendido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFecha1.Value = Today
        dtFecha2.Value = Today
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        LlenarGrid()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If dgDespachados.RowCount > 1 Then
            If MsgBox("Esta seguro de querer eliminar el Producto Despachado", vbExclamation + vbYesNo, "Insumo") = vbYes Then
                Dim id As Integer 'PRODUCTS
                Dim cantidad As Decimal
                cantidad = dgDespachados.Item(2, dgDespachados.CurrentCell.RowIndex).Value
                id = dgDespachados.Item(0, dgDespachados.CurrentCell.RowIndex).Value

                RevertirStock(cantidad, id)
                cmd = New OleDbCommand("delete from prodsalidas where ID=" & id & "", bd)
                cmd.ExecuteNonQuery()
                LlenarGrid()
                MsgBox("Item Eliminado", vbInformation)

            End If
        Else
            MsgBox("No hay pedidos para eliminar", vbExclamation, "Insumos")
        End If
    End Sub

    Private Sub LlenarGrid()
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

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

        da = New OleDbDataAdapter(
       "SELECT prodsalidas.ID, " &
       "products.description, " &
       " prodsalidas.cantidad, " &
       " prodsalidas.precio, " &
       " prodsalidas.total, " &
       " prodsalidas.efectivo, " &
       " prodsalidas.vuelto, " &
       " prodsalidas.tipopago, " &
       " prodsalidas.fechsalida as FechaVenta " &
       " FROM products INNER JOIN prodsalidas ON prodsalidas.id_products = products.id" &
       " WHERE ((prodsalidas.fechsalida) between #" & fech1 & "# and #" & fech2 & "#)", bd)
        da.Fill(dt)
        dgDespachados.DataSource = dt
    End Sub
    Private Sub RevertirStock(cantidad, id)
        cmd = New OleDbCommand("update products set stock=stock + " & cantidad & " where ID=" & id & "", bd)
        cmd.ExecuteNonQuery()
    End Sub
End Class










