<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
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
        Me.txtInfoOut = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInfUltima = New System.Windows.Forms.TextBox()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.cmdTerminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInfoOut
        '
        Me.txtInfoOut.Location = New System.Drawing.Point(203, 57)
        Me.txtInfoOut.Multiline = True
        Me.txtInfoOut.Name = "txtInfoOut"
        Me.txtInfoOut.ReadOnly = True
        Me.txtInfoOut.Size = New System.Drawing.Size(200, 54)
        Me.txtInfoOut.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Información registrada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Última captura"
        '
        'txtInfUltima
        '
        Me.txtInfUltima.Location = New System.Drawing.Point(203, 153)
        Me.txtInfUltima.Name = "txtInfUltima"
        Me.txtInfUltima.ReadOnly = True
        Me.txtInfUltima.Size = New System.Drawing.Size(120, 20)
        Me.txtInfUltima.TabIndex = 8
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(71, 221)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(104, 45)
        Me.cmdVolver.TabIndex = 9
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'cmdTerminar
        '
        Me.cmdTerminar.Location = New System.Drawing.Point(212, 221)
        Me.cmdTerminar.Name = "cmdTerminar"
        Me.cmdTerminar.Size = New System.Drawing.Size(111, 46)
        Me.cmdTerminar.TabIndex = 10
        Me.cmdTerminar.Text = "Terminar"
        Me.cmdTerminar.UseVisualStyleBackColor = True
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdTerminar)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.txtInfUltima)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInfoOut)
        Me.Name = "frmInfo"
        Me.Text = "frmInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInfoOut As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInfUltima As TextBox
    Friend WithEvents cmdVolver As Button
    Friend WithEvents cmdTerminar As Button
End Class
