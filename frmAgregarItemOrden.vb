Imports System.Data.OleDb
Public Class frmAgregarItemOrden
    Dim adapter As New OleDbDataAdapter
    Dim adapter1 As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Public Sub gridatexboxempleado()
        If DataGridView2.Visible = False Then
            TextBox2.Focus()
        Else
            Label5.Text = DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value.ToString
            TextBox1.Text = DataGridView2.Item(1, DataGridView2.CurrentCell.RowIndex).Value.ToString
            DataGridView2.Visible = False
        End If
    End Sub
    Public Sub gridatextboxinsumos()
        DataGridView3.Visible = False
        TextBox3.Focus()
        Label7.Text = DataGridView3.Item(0, DataGridView3.CurrentCell.RowIndex).Value.ToString
        TextBox2.Text = DataGridView3.Item(1, DataGridView3.CurrentCell.RowIndex).Value.ToString
        DataGridView3.Visible = False
    End Sub

    Private Sub DataGridView2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        gridatexboxempleado()
    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        TextBox2.BackColor = Color.GreenYellow
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = 40 Then
            If (DataGridView3.CurrentCell.RowIndex < DataGridView3.RowCount - 2) Then
                DataGridView3.CurrentCell = DataGridView3.Item(0, DataGridView3.CurrentCell.RowIndex + 1)
            End If
        ElseIf e.KeyCode = 38 Then
            If (DataGridView3.CurrentCell.RowIndex > 0) Then
                DataGridView3.CurrentCell = DataGridView3.Item(0, DataGridView3.CurrentCell.RowIndex - 1)
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If DataGridView3.RowCount < 2 Then
                MsgBox("Debe seleccionar un insumo ", vbExclamation, "Insumos")
            Else
                gridatextboxinsumos()
                TextBox3.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        TextBox2.BackColor = Color.White
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        DataGridView3.Visible = True

        If DataGridView3.RowCount < 2 Then
        Else
            DataGridView3.Columns.Item(0).Width = 40
            DataGridView3.Columns.Item(1).Width = 400
            DataGridView3.Columns.Item(2).Width = 70
            DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
        If TextBox2.Text.Trim = "" Then
            DataGridView3.Visible = False
        End If
        If RadioButton3.Checked = True Then
            adapter = New OleDbDataAdapter("select supcode,description,stock from products where supcode like '%" & TextBox2.Text & "%'", bd)
        ElseIf RadioButton4.Checked = True Then
            adapter = New OleDbDataAdapter("select supcode,description,stock from products where description like '%" & TextBox2.Text & "%'", bd)
        End If
        Dim dataset As New DataSet
        adapter.Fill(dataset, "nombre")
        DataGridView3.DataSource = dataset.Tables(0)
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.BackColor = Color.GreenYellow
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = 40 Then 'este key code es haca abajo
            If (DataGridView2.CurrentCell.RowIndex < DataGridView2.RowCount - 2) Then
                DataGridView2.CurrentCell = DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex + 1)
            End If
        ElseIf e.KeyCode = 38 Then ' este key code es hacia arriba
            If (DataGridView2.CurrentCell.RowIndex > 0) Then
                DataGridView2.CurrentCell = DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex - 1)
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            gridatexboxempleado()
        End If
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        DataGridView2.Visible = True
        If DataGridView2.RowCount < 2 Then
        Else
            DataGridView2.Columns.Item(0).Width = 40
            DataGridView2.Columns.Item(1).Width = 400
            DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
        If TextBox1.Text.Trim = "" Then
            DataGridView2.Visible = False
        End If
        If RadioButton2.Checked = True Then
            adapter1 = New OleDbDataAdapter("select empcode,fullname from employees where empcode like '%" & TextBox1.Text & "%'", bd)
        ElseIf RadioButton1.Checked = True Then
            adapter1 = New OleDbDataAdapter("select empcode,fullname from employees where fullname like '%" & TextBox1.Text & "%'", bd)
        End If
        Dim dataset As New DataSet
        adapter1.Fill(dataset, "nombre")
        DataGridView2.DataSource = dataset.Tables(0)
    End Sub
    Private Sub DataGridView3_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellDoubleClick
        gridatextboxinsumos()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text.Trim = "" Or TextBox3.Text.Trim = "" Then
            MsgBox("Debe ingresar datos", vbInformation, "Insumos")
            Exit Sub
        End If
        For X = 1 To TextBox3.Text.Trim.Length
            If Mid(TextBox3.Text, X, 1) = "1" Or Mid(TextBox3.Text, X, 1) = "2" Or Mid(TextBox3.Text, X, 1) = "3" Or Mid(TextBox3.Text, X, 1) = "4" Or Mid(TextBox3.Text, X, 1) = "5" Or Mid(TextBox3.Text, X, 1) = "6" Or Mid(TextBox3.Text, X, 1) = "7" Or Mid(TextBox3.Text, X, 1) = "8" Or Mid(TextBox3.Text, X, 1) = "9" Or Mid(TextBox3.Text, X, 1) = "0" Or Mid(TextBox3.Text, X, 1) = "." Then
            Else
                MsgBox("No es un nummero valido para la cantidad, porfavor ingrese un numero correcto", vbExclamation, "Insumos")
                TextBox2.Text = ""
                TextBox2.Focus()
                Exit Sub
            End If
        Next
        cmd = New OleDbCommand("insert into prodsalidas(Orden_id,codtra,codma,cantidad,fechsalida,despachado,usu) values ('" & frmCorregirOrden.ComboBox1.Text & "','" & Label5.Text & "','" & Label7.Text & "'," & TextBox3.Text & ",'" & DTPicker1.Value & "','no','" & usu & "')", bd)
        cmd.ExecuteNonQuery()
        frmCorregirOrden.mostrarpedidos()
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.GotFocus
        TextBox3.BackColor = Color.GreenYellow
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Button1.Focus()
        End If
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        TextBox3.BackColor = Color.White
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DTPicker1.Value = Today
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox2.Focus()
    End Sub
End Class