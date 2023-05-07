﻿Imports System.Drawing.Drawing2D

Public Class frmCalculos

    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        Dim numero1, numero2, resultado As Double
        Dim operacion As String
        Dim arrOperaciones() As String = {"SUMA", "RESTA", "PRODUCTO", "DIVISION"}
        Dim operacionValida As Boolean = False

        numero1 = CDbl(txtNumero1.Text)
        numero2 = CDbl(txtNumero2.Text)

        operacion = (txtOperacion.Text).ToUpper()

        For Each op In arrOperaciones
            If operacion = op Then
                operacionValida = True
            End If
        Next

        If operacionValida Then
            Select Case operacion
                Case "SUMA"
                    labelOperacion.Text = "+"
                    resultado = numero1 + numero2
                Case "RESTA"
                    labelOperacion.Text = "-"
                    resultado = numero1 - numero2
                Case "PRODUCTO"
                    labelOperacion.Text = "x"
                    resultado = numero1 * numero2
                Case "DIVISION"
                    labelOperacion.Text = "÷"
                    If numero1 = 0 Then
                        MsgBox("Error al intentar dividir por cero.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                    Else
                        resultado = numero1 / numero2
                    End If
            End Select
        Else
            MsgBox("La operacion introducida no es valida.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End If

        labelNumero1.Text = CStr(numero1)
        labelNumero2.Text = CStr(numero2)

        txtResultado.Text = resultado

    End Sub

    Private Sub volver_Click(sender As Object, e As EventArgs) Handles volver.Click
        Me.Hide()
        Formulario1.Show()
    End Sub

    Private Sub txtOperacion_TextChanged(sender As Object, e As EventArgs) Handles txtOperacion.TextChanged

    End Sub

    Private Sub frmCalculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtNumero1.Text = String.Empty
        txtNumero2.Text = String.Empty
        txtResultado.Text = String.Empty
        txtOperacion.Text = String.Empty
        labelNumero1.Text = String.Empty
        labelNumero2.Text = String.Empty
        labelOperacion.Text = String.Empty
    End Sub
End Class