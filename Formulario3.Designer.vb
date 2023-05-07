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
        Me.cmdGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdGuardar.FlatAppearance.BorderSize = 2
        Me.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGuardar.Font = New System.Drawing.Font("Fira Code", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(132, 300)
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(200, 60)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'cmdVisual
        '
        Me.cmdVisual.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.cmdVisual.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdVisual.FlatAppearance.BorderSize = 2
        Me.cmdVisual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdVisual.Font = New System.Drawing.Font("Fira Code", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVisual.Location = New System.Drawing.Point(368, 300)
        Me.cmdVisual.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdVisual.Name = "cmdVisual"
        Me.cmdVisual.Size = New System.Drawing.Size(200, 60)
        Me.cmdVisual.TabIndex = 1
        Me.cmdVisual.Text = "Ver información"
        Me.cmdVisual.UseVisualStyleBackColor = False
        '
        'cmdTerminar
        '
        Me.cmdTerminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.cmdTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTerminar.Location = New System.Drawing.Point(368, 382)
        Me.cmdTerminar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdTerminar.Name = "cmdTerminar"
        Me.cmdTerminar.Size = New System.Drawing.Size(200, 60)
        Me.cmdTerminar.TabIndex = 2
        Me.cmdTerminar.Text = "Terminar"
        Me.cmdTerminar.UseVisualStyleBackColor = False
        '
        'cmdVolver
        '
        Me.cmdVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.cmdVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdVolver.Location = New System.Drawing.Point(132, 382)
        Me.cmdVolver.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(200, 60)
        Me.cmdVolver.TabIndex = 3
        Me.cmdVolver.Text = "< Volver al inicio"
        Me.cmdVolver.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fira Code", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fira Code", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(263, 178)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña"
        '
        'txtUserIn
        '
        Me.txtUserIn.Location = New System.Drawing.Point(266, 122)
        Me.txtUserIn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtUserIn.Name = "txtUserIn"
        Me.txtUserIn.Size = New System.Drawing.Size(173, 24)
        Me.txtUserIn.TabIndex = 6
        '
        'txtContrIn
        '
        Me.txtContrIn.Location = New System.Drawing.Point(266, 199)
        Me.txtContrIn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtContrIn.Name = "txtContrIn"
        Me.txtContrIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrIn.Size = New System.Drawing.Size(175, 24)
        Me.txtContrIn.TabIndex = 7
        '
        'Formulario3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(705, 554)
        Me.Controls.Add(Me.txtContrIn)
        Me.Controls.Add(Me.txtUserIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdTerminar)
        Me.Controls.Add(Me.cmdVisual)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Font = New System.Drawing.Font("Fira Code", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
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
