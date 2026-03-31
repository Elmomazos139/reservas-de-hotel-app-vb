<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class confirmar_Reserva
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
        Label1 = New Label()
        TXTSALIDA = New TextBox()
        TXTENTRADA = New TextBox()
        TXTDUI = New TextBox()
        TXTTELEFONO = New TextBox()
        TXTNOMBRE = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        BTNCONFIRMAR = New Button()
        BTNVOLVER = New Button()
        txtcorreo = New TextBox()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Engravers MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(47, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 28)
        Label1.TabIndex = 0
        Label1.Text = "Verifica Tus Datos" & vbCrLf & "        Por Favor"
        ' 
        ' TXTSALIDA
        ' 
        TXTSALIDA.Enabled = False
        TXTSALIDA.Location = New Point(167, 214)
        TXTSALIDA.Name = "TXTSALIDA"
        TXTSALIDA.Size = New Size(100, 23)
        TXTSALIDA.TabIndex = 19
        ' 
        ' TXTENTRADA
        ' 
        TXTENTRADA.Enabled = False
        TXTENTRADA.Location = New Point(58, 214)
        TXTENTRADA.Name = "TXTENTRADA"
        TXTENTRADA.Size = New Size(100, 23)
        TXTENTRADA.TabIndex = 18
        ' 
        ' TXTDUI
        ' 
        TXTDUI.Enabled = False
        TXTDUI.Location = New Point(142, 160)
        TXTDUI.Name = "TXTDUI"
        TXTDUI.Size = New Size(100, 23)
        TXTDUI.TabIndex = 17
        ' 
        ' TXTTELEFONO
        ' 
        TXTTELEFONO.Enabled = False
        TXTTELEFONO.Location = New Point(142, 102)
        TXTTELEFONO.Name = "TXTTELEFONO"
        TXTTELEFONO.Size = New Size(100, 23)
        TXTTELEFONO.TabIndex = 16
        ' 
        ' TXTNOMBRE
        ' 
        TXTNOMBRE.Enabled = False
        TXTNOMBRE.Location = New Point(142, 70)
        TXTNOMBRE.Name = "TXTNOMBRE"
        TXTNOMBRE.Size = New Size(100, 23)
        TXTNOMBRE.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(184, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 15)
        Label5.TabIndex = 14
        Label5.Text = "fecha salida:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(68, 194)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 15)
        Label4.TabIndex = 13
        Label4.Text = "fecha entrada:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(68, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 15)
        Label3.TabIndex = 12
        Label3.Text = "Dui:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(67, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 11
        Label2.Text = "Teléfono:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(68, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 15)
        Label6.TabIndex = 10
        Label6.Text = "Nombre:"
        ' 
        ' BTNCONFIRMAR
        ' 
        BTNCONFIRMAR.BackColor = SystemColors.ActiveBorder
        BTNCONFIRMAR.Location = New Point(68, 243)
        BTNCONFIRMAR.Name = "BTNCONFIRMAR"
        BTNCONFIRMAR.Size = New Size(75, 23)
        BTNCONFIRMAR.TabIndex = 20
        BTNCONFIRMAR.Text = "Confirmar"
        BTNCONFIRMAR.UseVisualStyleBackColor = False
        ' 
        ' BTNVOLVER
        ' 
        BTNVOLVER.BackColor = SystemColors.ActiveBorder
        BTNVOLVER.Location = New Point(178, 243)
        BTNVOLVER.Name = "BTNVOLVER"
        BTNVOLVER.Size = New Size(75, 23)
        BTNVOLVER.TabIndex = 21
        BTNVOLVER.Text = "Volver"
        BTNVOLVER.UseVisualStyleBackColor = False
        ' 
        ' txtcorreo
        ' 
        txtcorreo.Enabled = False
        txtcorreo.Location = New Point(142, 131)
        txtcorreo.Name = "txtcorreo"
        txtcorreo.Size = New Size(100, 23)
        txtcorreo.TabIndex = 23
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(31, 134)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 15)
        Label7.TabIndex = 22
        Label7.Text = "Correo electronico:"
        ' 
        ' confirmar_Reserva
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(305, 295)
        Controls.Add(txtcorreo)
        Controls.Add(Label7)
        Controls.Add(BTNVOLVER)
        Controls.Add(BTNCONFIRMAR)
        Controls.Add(TXTSALIDA)
        Controls.Add(TXTENTRADA)
        Controls.Add(TXTDUI)
        Controls.Add(TXTTELEFONO)
        Controls.Add(TXTNOMBRE)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Name = "confirmar_Reserva"
        Text = "confirmar_Reserva"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXTSALIDA As TextBox
    Friend WithEvents TXTENTRADA As TextBox
    Friend WithEvents TXTDUI As TextBox
    Friend WithEvents TXTTELEFONO As TextBox
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BTNCONFIRMAR As Button
    Friend WithEvents BTNVOLVER As Button
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents Label7 As Label
End Class
