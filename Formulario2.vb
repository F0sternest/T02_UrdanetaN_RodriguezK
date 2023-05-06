Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography.X509Certificates

Public Class Formulario2

    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        Dim numero1, numero2, resultado As Double
        numero1 = CDbl(txtNumero1.Text)
        numero2 = CDbl(txtNumero2.Text)
        labelNumero1.Text = txtNumero1.Text
        labelNumero2.Text = txtNumero2.Text

        If radioBtnSuma.Checked Then
            labelOperacion.Text = "+"
            resultado = numero1 + numero2
        ElseIf radioBtnResta.Checked Then
            labelOperacion.Text = "-"
            resultado = numero1 - numero2
        ElseIf radioBtnProducto.Checked Then
            labelOperacion.Text = "x"
            resultado = numero1 * numero2
        ElseIf radioBtnDivision.Checked Then
            labelOperacion.Text = "÷"
            If numero1 = 0 Then
                MsgBox("No se puede dividir entre 0", MsgBoxStyle.Exclamation)
            Else
                resultado = numero1 / numero2
            End If
        End If

        txtResultado.Text = CStr(resultado)


    End Sub

    Private Sub volver_Click(sender As Object, e As EventArgs) Handles volver.Click
        Dim formulario1 As New Formulario1()
        formulario1.Show()
        Me.Hide()
    End Sub

    Private Sub Formulario2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class