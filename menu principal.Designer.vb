<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_principal
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
        CBDEPARTAMENTO = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        chkmascotas = New CheckBox()
        TXTADULTOS = New TextBox()
        TXTNIÑOS = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnsiguiente = New Button()
        BTNSALIR = New Button()
        CBHABITACIONES = New ComboBox()
        SuspendLayout()
        ' 
        ' CBDEPARTAMENTO
        ' 
        CBDEPARTAMENTO.FormattingEnabled = True
        CBDEPARTAMENTO.Items.AddRange(New Object() {"La Paz", "San Vicente", "San Salvador"})
        CBDEPARTAMENTO.Location = New Point(28, 36)
        CBDEPARTAMENTO.Name = "CBDEPARTAMENTO"
        CBDEPARTAMENTO.Size = New Size(121, 23)
        CBDEPARTAMENTO.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 15)
        Label1.TabIndex = 2
        Label1.Text = "Depto. donde quiere hospedarse"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(224, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 15)
        Label2.TabIndex = 3
        Label2.Text = "Informacion Adicional:"
        ' 
        ' chkmascotas
        ' 
        chkmascotas.AutoSize = True
        chkmascotas.Location = New Point(28, 71)
        chkmascotas.Name = "chkmascotas"
        chkmascotas.Size = New Size(111, 19)
        chkmascotas.TabIndex = 4
        chkmascotas.Text = "Lleva mascotas?"
        chkmascotas.UseVisualStyleBackColor = True
        ' 
        ' TXTADULTOS
        ' 
        TXTADULTOS.Location = New Point(305, 32)
        TXTADULTOS.Name = "TXTADULTOS"
        TXTADULTOS.Size = New Size(60, 23)
        TXTADULTOS.TabIndex = 5
        ' 
        ' TXTNIÑOS
        ' 
        TXTNIÑOS.Location = New Point(305, 69)
        TXTNIÑOS.Name = "TXTNIÑOS"
        TXTNIÑOS.Size = New Size(60, 23)
        TXTNIÑOS.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(208, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 15)
        Label3.TabIndex = 8
        Label3.Text = "Cuantos adultos:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(195, 72)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 15)
        Label4.TabIndex = 9
        Label4.Text = "Cantidad  de niños:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(205, 106)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 15)
        Label5.TabIndex = 10
        Label5.Text = "Nº habitaciones:"
        ' 
        ' btnsiguiente
        ' 
        btnsiguiente.BackColor = SystemColors.ActiveBorder
        btnsiguiente.Location = New Point(39, 113)
        btnsiguiente.Name = "btnsiguiente"
        btnsiguiente.Size = New Size(100, 26)
        btnsiguiente.TabIndex = 11
        btnsiguiente.Text = "Siguiente"
        btnsiguiente.UseVisualStyleBackColor = False
        ' 
        ' BTNSALIR
        ' 
        BTNSALIR.BackColor = SystemColors.ActiveBorder
        BTNSALIR.Location = New Point(305, 127)
        BTNSALIR.Name = "BTNSALIR"
        BTNSALIR.Size = New Size(75, 24)
        BTNSALIR.TabIndex = 12
        BTNSALIR.Text = "Salir"
        BTNSALIR.UseVisualStyleBackColor = False
        ' 
        ' CBHABITACIONES
        ' 
        CBHABITACIONES.FormattingEnabled = True
        CBHABITACIONES.Items.AddRange(New Object() {"1"})
        CBHABITACIONES.Location = New Point(305, 98)
        CBHABITACIONES.Name = "CBHABITACIONES"
        CBHABITACIONES.Size = New Size(65, 23)
        CBHABITACIONES.TabIndex = 13
        ' 
        ' menu_principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(392, 170)
        Controls.Add(CBHABITACIONES)
        Controls.Add(BTNSALIR)
        Controls.Add(btnsiguiente)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TXTNIÑOS)
        Controls.Add(TXTADULTOS)
        Controls.Add(chkmascotas)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CBDEPARTAMENTO)
        Name = "menu_principal"
        Text = "menu_principal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CBDEPARTAMENTO As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkmascotas As CheckBox
    Friend WithEvents TXTADULTOS As TextBox
    Friend WithEvents TXTNIÑOS As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnsiguiente As Button
    Friend WithEvents BTNSALIR As Button
    Friend WithEvents CBHABITACIONES As ComboBox
End Class
