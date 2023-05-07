<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdVisual = New System.Windows.Forms.Button()
        Me.cmdTerminar = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserIn = New System.Windows.Forms.TextBox()
        Me.txtContrIn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(38, 241)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(66, 35)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdVisual
        '
        Me.cmdVisual.Location = New System.Drawing.Point(148, 241)
        Me.cmdVisual.Name = "cmdVisual"
        Me.cmdVisual.Size = New System.Drawing.Size(85, 34)
        Me.cmdVisual.TabIndex = 1
        Me.cmdVisual.Text = "Ver información"
        Me.cmdVisual.UseVisualStyleBackColor = True
        '
        'cmdTerminar
        '
        Me.cmdTerminar.Location = New System.Drawing.Point(276, 236)
        Me.cmdTerminar.Name = "cmdTerminar"
        Me.cmdTerminar.Size = New System.Drawing.Size(94, 39)
        Me.cmdTerminar.TabIndex = 2
        Me.cmdTerminar.Text = "Terminar"
        Me.cmdTerminar.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(396, 241)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(129, 54)
        Me.cmdVolver.TabIndex = 3
        Me.cmdVolver.Text = "Volver al inicio"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña"
        '
        'txtUserIn
        '
        Me.txtUserIn.Location = New System.Drawing.Point(145, 49)
        Me.txtUserIn.Name = "txtUserIn"
        Me.txtUserIn.Size = New System.Drawing.Size(131, 20)
        Me.txtUserIn.TabIndex = 6
        '
        'txtContrIn
        '
        Me.txtContrIn.Location = New System.Drawing.Point(152, 97)
        Me.txtContrIn.Name = "txtContrIn"
        Me.txtContrIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrIn.Size = New System.Drawing.Size(133, 20)
        Me.txtContrIn.TabIndex = 7
        '
        'Formulario3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtContrIn)
        Me.Controls.Add(Me.txtUserIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdTerminar)
        Me.Controls.Add(Me.cmdVisual)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Name = "Formulario3"
        Me.Text = "Introducción a VB.Net"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cmdVisual As Button
    Friend WithEvents cmdTerminar As Button
    Friend WithEvents cmdVolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserIn As TextBox
    Friend WithEvents txtContrIn As TextBox
End Class
