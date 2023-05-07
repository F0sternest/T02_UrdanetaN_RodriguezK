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
        Me.txtInfoOut.Location = New System.Drawing.Point(142, 108)
        Me.txtInfoOut.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtInfoOut.Multiline = True
        Me.txtInfoOut.Name = "txtInfoOut"
        Me.txtInfoOut.ReadOnly = True
        Me.txtInfoOut.Size = New System.Drawing.Size(297, 126)
        Me.txtInfoOut.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Información registrada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 253)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Última captura"
        '
        'txtInfUltima
        '
        Me.txtInfUltima.Location = New System.Drawing.Point(142, 274)
        Me.txtInfUltima.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtInfUltima.Name = "txtInfUltima"
        Me.txtInfUltima.ReadOnly = True
        Me.txtInfUltima.Size = New System.Drawing.Size(297, 24)
        Me.txtInfUltima.TabIndex = 8
        '
        'cmdVolver
        '
        Me.cmdVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.cmdVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdVolver.Location = New System.Drawing.Point(142, 341)
        Me.cmdVolver.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(138, 57)
        Me.cmdVolver.TabIndex = 9
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = False
        '
        'cmdTerminar
        '
        Me.cmdTerminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.cmdTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTerminar.Location = New System.Drawing.Point(290, 341)
        Me.cmdTerminar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdTerminar.Name = "cmdTerminar"
        Me.cmdTerminar.Size = New System.Drawing.Size(149, 57)
        Me.cmdTerminar.TabIndex = 10
        Me.cmdTerminar.Text = "Terminar"
        Me.cmdTerminar.UseVisualStyleBackColor = False
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(586, 554)
        Me.Controls.Add(Me.cmdTerminar)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.txtInfUltima)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInfoOut)
        Me.Font = New System.Drawing.Font("Fira Code", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
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
