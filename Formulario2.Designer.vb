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
        Me.operacionesGB = New System.Windows.Forms.GroupBox()
        Me.radioBtnDivision = New System.Windows.Forms.RadioButton()
        Me.radioBtnProducto = New System.Windows.Forms.RadioButton()
        Me.radioBtnResta = New System.Windows.Forms.RadioButton()
        Me.radioBtnSuma = New System.Windows.Forms.RadioButton()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.operacionesGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'volver
        '
        Me.volver.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.volver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volver.Location = New System.Drawing.Point(170, 424)
        Me.volver.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.volver.Name = "volver"
        Me.volver.Size = New System.Drawing.Size(166, 52)
        Me.volver.TabIndex = 0
        Me.volver.Text = "Volver al Inicio"
        Me.volver.UseVisualStyleBackColor = False
        '
        'txtNumero1
        '
        Me.txtNumero1.Location = New System.Drawing.Point(131, 88)
        Me.txtNumero1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(132, 23)
        Me.txtNumero1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Numero 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 130)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Numero 2:"
        '
        'txtNumero2
        '
        Me.txtNumero2.Location = New System.Drawing.Point(131, 151)
        Me.txtNumero2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(132, 23)
        Me.txtNumero2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(492, 290)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Resultado:"
        '
        'txtResultado
        '
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(495, 311)
        Me.txtResultado.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(286, 29)
        Me.txtResultado.TabIndex = 5
        '
        'btnResultado
        '
        Me.btnResultado.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnResultado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResultado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultado.ForeColor = System.Drawing.SystemColors.Control
        Me.btnResultado.Location = New System.Drawing.Point(346, 424)
        Me.btnResultado.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnResultado.Name = "btnResultado"
        Me.btnResultado.Size = New System.Drawing.Size(166, 52)
        Me.btnResultado.TabIndex = 7
        Me.btnResultado.Text = "Calcular"
        Me.btnResultado.UseVisualStyleBackColor = False
        '
        'labelNumero1
        '
        Me.labelNumero1.AutoSize = True
        Me.labelNumero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNumero1.Location = New System.Drawing.Point(558, 190)
        Me.labelNumero1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.labelNumero1.Name = "labelNumero1"
        Me.labelNumero1.Size = New System.Drawing.Size(0, 31)
        Me.labelNumero1.TabIndex = 8
        '
        'labelOperacion
        '
        Me.labelOperacion.AutoSize = True
        Me.labelOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelOperacion.Location = New System.Drawing.Point(516, 223)
        Me.labelOperacion.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.labelOperacion.Name = "labelOperacion"
        Me.labelOperacion.Size = New System.Drawing.Size(0, 31)
        Me.labelOperacion.TabIndex = 9
        Me.labelOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelNumero2
        '
        Me.labelNumero2.AutoSize = True
        Me.labelNumero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNumero2.Location = New System.Drawing.Point(558, 223)
        Me.labelNumero2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.labelNumero2.Name = "labelNumero2"
        Me.labelNumero2.Size = New System.Drawing.Size(0, 31)
        Me.labelNumero2.TabIndex = 10
        '
        'operacionesGB
        '
        Me.operacionesGB.Controls.Add(Me.radioBtnDivision)
        Me.operacionesGB.Controls.Add(Me.radioBtnProducto)
        Me.operacionesGB.Controls.Add(Me.radioBtnResta)
        Me.operacionesGB.Controls.Add(Me.radioBtnSuma)
        Me.operacionesGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.operacionesGB.ForeColor = System.Drawing.SystemColors.Control
        Me.operacionesGB.Location = New System.Drawing.Point(104, 201)
        Me.operacionesGB.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.operacionesGB.Name = "operacionesGB"
        Me.operacionesGB.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.operacionesGB.Size = New System.Drawing.Size(266, 151)
        Me.operacionesGB.TabIndex = 18
        Me.operacionesGB.TabStop = False
        Me.operacionesGB.Text = "Operaciones"
        '
        'radioBtnDivision
        '
        Me.radioBtnDivision.AutoSize = True
        Me.radioBtnDivision.Location = New System.Drawing.Point(27, 110)
        Me.radioBtnDivision.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radioBtnDivision.Name = "radioBtnDivision"
        Me.radioBtnDivision.Size = New System.Drawing.Size(75, 21)
        Me.radioBtnDivision.TabIndex = 3
        Me.radioBtnDivision.TabStop = True
        Me.radioBtnDivision.Text = "Division"
        Me.radioBtnDivision.UseVisualStyleBackColor = True
        '
        'radioBtnProducto
        '
        Me.radioBtnProducto.AutoSize = True
        Me.radioBtnProducto.Location = New System.Drawing.Point(27, 82)
        Me.radioBtnProducto.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radioBtnProducto.Name = "radioBtnProducto"
        Me.radioBtnProducto.Size = New System.Drawing.Size(83, 21)
        Me.radioBtnProducto.TabIndex = 2
        Me.radioBtnProducto.TabStop = True
        Me.radioBtnProducto.Text = "Producto"
        Me.radioBtnProducto.UseVisualStyleBackColor = True
        '
        'radioBtnResta
        '
        Me.radioBtnResta.AutoSize = True
        Me.radioBtnResta.Location = New System.Drawing.Point(27, 54)
        Me.radioBtnResta.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radioBtnResta.Name = "radioBtnResta"
        Me.radioBtnResta.Size = New System.Drawing.Size(63, 21)
        Me.radioBtnResta.TabIndex = 1
        Me.radioBtnResta.TabStop = True
        Me.radioBtnResta.Text = "Resta"
        Me.radioBtnResta.UseVisualStyleBackColor = True
        '
        'radioBtnSuma
        '
        Me.radioBtnSuma.AutoSize = True
        Me.radioBtnSuma.Location = New System.Drawing.Point(27, 25)
        Me.radioBtnSuma.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radioBtnSuma.Name = "radioBtnSuma"
        Me.radioBtnSuma.Size = New System.Drawing.Size(62, 21)
        Me.radioBtnSuma.TabIndex = 0
        Me.radioBtnSuma.TabStop = True
        Me.radioBtnSuma.Text = "Suma"
        Me.radioBtnSuma.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLimpiar.Location = New System.Drawing.Point(522, 424)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(166, 52)
        Me.btnLimpiar.TabIndex = 19
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Formulario2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(881, 560)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.operacionesGB)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Formulario2"
        Me.Text = "Cálculos matemáticos"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.operacionesGB.ResumeLayout(False)
        Me.operacionesGB.PerformLayout()
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
    Friend WithEvents operacionesGB As GroupBox
    Friend WithEvents radioBtnSuma As RadioButton
    Friend WithEvents radioBtnDivision As RadioButton
    Friend WithEvents radioBtnProducto As RadioButton
    Friend WithEvents radioBtnResta As RadioButton
    Friend WithEvents btnLimpiar As Button
End Class
