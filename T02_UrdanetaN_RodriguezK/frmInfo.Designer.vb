<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.cmdTerminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInfoOut = New System.Windows.Forms.TextBox()
        Me.txtInfUltima = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(48, 243)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(104, 45)
        Me.cmdVolver.TabIndex = 0
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'cmdTerminar
        '
        Me.cmdTerminar.Location = New System.Drawing.Point(168, 242)
        Me.cmdTerminar.Name = "cmdTerminar"
        Me.cmdTerminar.Size = New System.Drawing.Size(111, 46)
        Me.cmdTerminar.TabIndex = 1
        Me.cmdTerminar.Text = "Terminar"
        Me.cmdTerminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Información registrada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Última captura"
        '
        'txtInfoOut
        '
        Me.txtInfoOut.Location = New System.Drawing.Point(168, 38)
        Me.txtInfoOut.Multiline = True
        Me.txtInfoOut.Name = "txtInfoOut"
        Me.txtInfoOut.ReadOnly = True
        Me.txtInfoOut.Size = New System.Drawing.Size(200, 54)
        Me.txtInfoOut.TabIndex = 4
        '
        'txtInfUltima
        '
        Me.txtInfUltima.Location = New System.Drawing.Point(140, 113)
        Me.txtInfUltima.Name = "txtInfUltima"
        Me.txtInfUltima.ReadOnly = True
        Me.txtInfUltima.Size = New System.Drawing.Size(120, 20)
        Me.txtInfUltima.TabIndex = 5
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtInfUltima)
        Me.Controls.Add(Me.txtInfoOut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdTerminar)
        Me.Controls.Add(Me.cmdVolver)
        Me.Name = "frmInfo"
        Me.Text = "Visualizar información"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdVolver As Button
    Friend WithEvents cmdTerminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInfoOut As TextBox
    Friend WithEvents txtInfUltima As TextBox
End Class
