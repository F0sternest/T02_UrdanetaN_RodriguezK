<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario2
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
        Me.volver = New System.Windows.Forms.Button()
        Me.txtNumero1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnResultado = New System.Windows.Forms.Button()
        Me.labelNumero1 = New System.Windows.Forms.Label()
        Me.labelOperacion = New System.Windows.Forms.Label()
        Me.labelNumero2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOperacion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'volver
        '
        Me.volver.Location = New System.Drawing.Point(211, 346)
        Me.volver.Name = "volver"
        Me.volver.Size = New System.Drawing.Size(124, 42)
        Me.volver.TabIndex = 0
        Me.volver.Text = "Volver al Inicio"
        Me.volver.UseVisualStyleBackColor = True
        '
        'txtNumero1
        '
        Me.txtNumero1.Location = New System.Drawing.Point(137, 65)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Numero 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Numero 2:"
        '
        'txtNumero2
        '
        Me.txtNumero2.Location = New System.Drawing.Point(137, 103)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(442, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Resultado:"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(504, 160)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 5
        '
        'btnResultado
        '
        Me.btnResultado.Location = New System.Drawing.Point(358, 346)
        Me.btnResultado.Name = "btnResultado"
        Me.btnResultado.Size = New System.Drawing.Size(124, 42)
        Me.btnResultado.TabIndex = 7
        Me.btnResultado.Text = "Calcular"
        Me.btnResultado.UseVisualStyleBackColor = True
        '
        'labelNumero1
        '
        Me.labelNumero1.AutoSize = True
        Me.labelNumero1.Location = New System.Drawing.Point(498, 106)
        Me.labelNumero1.Name = "labelNumero1"
        Me.labelNumero1.Size = New System.Drawing.Size(13, 13)
        Me.labelNumero1.TabIndex = 8
        Me.labelNumero1.Text = "0"
        '
        'labelOperacion
        '
        Me.labelOperacion.AutoSize = True
        Me.labelOperacion.Location = New System.Drawing.Point(517, 117)
        Me.labelOperacion.Name = "labelOperacion"
        Me.labelOperacion.Size = New System.Drawing.Size(56, 13)
        Me.labelOperacion.TabIndex = 9
        Me.labelOperacion.Text = "Operacion"
        Me.labelOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelNumero2
        '
        Me.labelNumero2.AutoSize = True
        Me.labelNumero2.Location = New System.Drawing.Point(498, 130)
        Me.labelNumero2.Name = "labelNumero2"
        Me.labelNumero2.Size = New System.Drawing.Size(13, 13)
        Me.labelNumero2.TabIndex = 10
        Me.labelNumero2.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Operacion: (Escriba suma, resta, producto, division)"
        '
        'txtOperacion
        '
        Me.txtOperacion.Location = New System.Drawing.Point(78, 183)
        Me.txtOperacion.Name = "txtOperacion"
        Me.txtOperacion.Size = New System.Drawing.Size(100, 20)
        Me.txtOperacion.TabIndex = 16
        '
        'Formulario2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOperacion)
        Me.Controls.Add(Me.labelNumero2)
        Me.Controls.Add(Me.labelOperacion)
        Me.Controls.Add(Me.labelNumero1)
        Me.Controls.Add(Me.btnResultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumero2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumero1)
        Me.Controls.Add(Me.volver)
        Me.Name = "Formulario2"
        Me.Text = "Formulario2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents volver As Button
    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnResultado As Button
    Friend WithEvents labelNumero1 As Label
    Friend WithEvents labelOperacion As Label
    Friend WithEvents labelNumero2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOperacion As TextBox
End Class
