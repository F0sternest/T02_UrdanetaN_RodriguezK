Public Class frmInfo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdTerminar.Click
        Close()
    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        Me.Hide()
        Formulario3.Show()
    End Sub
End Class