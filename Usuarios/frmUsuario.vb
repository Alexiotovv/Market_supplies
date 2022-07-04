Imports System.Data.OleDb
Public Class frmUsuario

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmdcommand As OleDbCommand
        Dim i As Integer = 0
        Dim num2 As Integer
        num2 = DataGridView1.RowCount - 2
        Dim str3 As String
        Dim str2 As String
        Do While (i <= num2)
            str3 = DataGridView1.Rows.Item(i).Cells.Item(1).Value
            str2 = DataGridView1.Rows.Item(i).Cells.Item(2).Value
            Dim text As String = TextBox3.Text
            If ((str3 = TextBox1.Text) And (str2 = TextBox2.Text)) Then
                cmdcommand = New OleDbCommand("update usuarios set pas='" & text & "' where user='" & str3 & "'", bd)
                cmdcommand.ExecuteNonQuery()
                MsgBox("The password change was successful", vbInformation, Nothing)
                Exit Sub
            End If
            i += 1
        Loop
        MsgBox("User or Password incorrect", MsgBoxStyle.Critical, "User")
    End Sub

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New OleDbDataAdapter("select * from usuarios", bd)
        Dim dataSet As New DataSet
        adapter.Fill(dataSet, "usu")
        DataGridView1.DataSource = dataSet.Tables(0)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class