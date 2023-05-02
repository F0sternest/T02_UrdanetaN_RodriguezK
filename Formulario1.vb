Public Class Formulario1
    Private Sub btnCalculos_Click(sender As Object, e As EventArgs) Handles btnCalculos.Click
        Dim formulario2 As New Formulario2()
        formulario2.Show()
        Me.Hide()

    End Sub

    Private Sub btnTexto_Click(sender As Object, e As EventArgs) Handles btnTexto.Click
        Dim formulario3 As New Formulario2()
        formulario3.Show()
        Me.Hide()
    End Sub

    Private Sub btnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        Close()
    End Sub
End Class
