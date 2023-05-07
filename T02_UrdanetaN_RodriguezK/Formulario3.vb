Public Class Formulario3
    Private Sub Formulario3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdTerminar.Click
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
    End Sub
End Class