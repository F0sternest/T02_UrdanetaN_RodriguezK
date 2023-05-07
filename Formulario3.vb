Public Class Formulario3
    Private Sub cmdTerminar_Click(sender As Object, e As EventArgs) Handles cmdTerminar.Click
        Close()
    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        Me.Hide()
        Formulario1.Show()
    End Sub

    Private Sub cmdVisual_Click(sender As Object, e As EventArgs) Handles cmdVisual.Click
        Me.Hide()
        frmInfo.Show()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        frmInfo.txtInfoOut.Text = frmInfo.txtInfoOut.Text & txtUserIn.Text
        frmInfo.txtInfoOut.Text = frmInfo.txtInfoOut.Text & "  " & txtContrIn.Text & vbNewLine
        frmInfo.txtInfUltima.Text = txtUserIn.Text + "  " & txtContrIn.Text
        txtUserIn.Text = ""
        txtContrIn.Text = ""
        txtUserIn.Focus()
        MsgBox("Datos guardados con exito", MsgBoxStyle.Information)

    End Sub
End Class