Public Class frmPagar
    Private Sub txtEfectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEfectivo.KeyPress
        Dim correcto As String = ""
        If Asc(e.KeyChar) = 13 Then
            btnGrabarPago.Focus()
            Exit Sub
        End If
        If Asc(e.KeyChar) = 48 Or Asc(e.KeyChar) = 49 Or Asc(e.KeyChar) = 50 Or Asc(e.KeyChar) = 51 Or Asc(e.KeyChar) = 52 Or Asc(e.KeyChar) = 53 Or Asc(e.KeyChar) = 54 Or Asc(e.KeyChar) = 55 Or Asc(e.KeyChar) = 56 Or Asc(e.KeyChar) = 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
            'correcto = correcto & txtEfectivo.Text
            'txtEfectivo.Text = correcto
        Else
            If Asc(e.KeyChar) = 27 Then
                Me.Close()
            Else
                MsgBox("Solo Números por favor")
            End If
        End If
    End Sub


    Private Sub txtEfectivo_TextChanged(sender As Object, e As EventArgs) Handles txtEfectivo.TextChanged
        Try
            Dim totalpagar As String = ""
            If txtEfectivo.Text.Trim = "" Then
                efectivo = "0"
            Else
                efectivo = txtEfectivo.Text
            End If
            totalpagar = txtTotalPagar.Text
            txtVuelto.Text = Convert.ToDecimal(efectivo) - Convert.ToDecimal(totalpagar)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEfectivo.Focus()
    End Sub

    Private Sub btnGrabarPago_Click(sender As Object, e As EventArgs) Handles btnGrabarPago.Click
        If MsgBox("Está seguro de realizar el pago", vbInformation + vbYesNo, "Pagar") = vbYes Then


            efectivo = Mid(txtEfectivo.Text, 1, 3).Trim
            vuelto = Mid(txtVuelto.Text, 1, 3).Trim
            Dim TPago As String = ""
            If rbEfectivo.Checked = True Then
                TPago = "EFECTIVO"
            ElseIf rbTarjeta.Checked = True Then
                TPago = "TARJETA"
            End If
            tipopago = TPago
            Me.Close()
            frmRealizarPedido.GrabarPedido()
        Else
            Me.Close()
        End If
    End Sub
    Private Sub btnGrabarPago_GotFocus(sender As Object, e As EventArgs) Handles btnGrabarPago.GotFocus
        btnGrabarPago.BackColor = Color.Green
    End Sub

    Private Sub btnGrabarPago_LostFocus(sender As Object, e As EventArgs) Handles btnGrabarPago.LostFocus
        btnGrabarPago.BackColor = Color.Gray
    End Sub
    Public Function CompruebaEfectivo(letra)
        Dim devuelve As Boolean
        If letra = "0" Then
            devuelve = True
        Else
            If letra = "1" Then
                devuelve = True
            Else
                If letra = "2" Then
                    devuelve = True
                Else
                    If letra = "3" Then
                        devuelve = True
                    Else
                        If letra = "4" Then
                            devuelve = True
                        Else
                            If letra = "5" Then
                                devuelve = True
                            Else
                                If letra = "6" Then
                                    devuelve = True
                                Else
                                    If letra = "7" Then
                                        devuelve = True
                                    Else
                                        If letra = "8" Then
                                            devuelve = True
                                        Else
                                            If letra = "9" Then
                                                devuelve = True
                                            Else
                                                If letra = "." Then
                                                    devuelve = True
                                                Else
                                                    devuelve = False
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        Return devuelve

    End Function
    Private Sub txtEfectivo_GotFocus(sender As Object, e As EventArgs) Handles txtEfectivo.GotFocus
        txtEfectivo.SelectionStart = 0
        txtEfectivo.SelectionLength = txtEfectivo.Text.Length
    End Sub

    Private Sub btnGrabarPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnGrabarPago.KeyPress
        If Asc(e.KeyChar) = 27 Then
            Me.Close()
        End If
    End Sub
End Class