<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TXTnombre = New TextBox()
        TXTtelefono = New TextBox()
        TXTdui = New TextBox()
        TXTentrada = New TextBox()
        TXTsalida = New TextBox()
        BTNLIMPIAR = New Button()
        BTNSIGUIENTE = New Button()
        txtcorreo = New TextBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 1
        Label2.Text = "Teléfono:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 15)
        Label3.TabIndex = 2
        Label3.Text = "Dui:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(38, 148)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 15)
        Label4.TabIndex = 3
        Label4.Text = "fecha entrada:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(134, 148)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 15)
        Label5.TabIndex = 4
        Label5.Text = "fecha salida:"
        ' 
        ' TXTnombre
        ' 
        TXTnombre.Location = New Point(112, 13)
        TXTnombre.Name = "TXTnombre"
        TXTnombre.Size = New Size(100, 23)
        TXTnombre.TabIndex = 5
        ' 
        ' TXTtelefono
        ' 
        TXTtelefono.Location = New Point(112, 45)
        TXTtelefono.Name = "TXTtelefono"
        TXTtelefono.Size = New Size(100, 23)
        TXTtelefono.TabIndex = 6
        ' 
        ' TXTdui
        ' 
        TXTdui.Location = New Point(112, 113)
        TXTdui.Name = "TXTdui"
        TXTdui.Size = New Size(100, 23)
        TXTdui.TabIndex = 7
        ' 
        ' TXTentrada
        ' 
        TXTentrada.Location = New Point(28, 168)
        TXTentrada.Name = "TXTentrada"
        TXTentrada.Size = New Size(100, 23)
        TXTentrada.TabIndex = 8
        ' 
        ' TXTsalida
        ' 
        TXTsalida.Location = New Point(134, 168)
        TXTsalida.Name = "TXTsalida"
        TXTsalida.Size = New Size(100, 23)
        TXTsalida.TabIndex = 9
        ' 
        ' BTNLIMPIAR
        ' 
        BTNLIMPIAR.BackColor = SystemColors.ActiveBorder
        BTNLIMPIAR.Location = New Point(37, 197)
        BTNLIMPIAR.Name = "BTNLIMPIAR"
        BTNLIMPIAR.Size = New Size(75, 23)
        BTNLIMPIAR.TabIndex = 10
        BTNLIMPIAR.Text = "Limpiar"
        BTNLIMPIAR.UseVisualStyleBackColor = False
        ' 
        ' BTNSIGUIENTE
        ' 
        BTNSIGUIENTE.BackColor = SystemColors.ActiveBorder
        BTNSIGUIENTE.Location = New Point(137, 197)
        BTNSIGUIENTE.Name = "BTNSIGUIENTE"
        BTNSIGUIENTE.Size = New Size(75, 23)
        BTNSIGUIENTE.TabIndex = 11
        BTNSIGUIENTE.Text = "verificar"
        BTNSIGUIENTE.UseVisualStyleBackColor = False
        ' 
        ' txtcorreo
        ' 
        txtcorreo.Location = New Point(112, 84)
        txtcorreo.Name = "txtcorreo"
        txtcorreo.Size = New Size(100, 23)
        txtcorreo.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(7, 87)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 15)
        Label6.TabIndex = 12
        Label6.Text = "Correo electronico:"
        ' 
        ' registro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(290, 235)
        Controls.Add(txtcorreo)
        Controls.Add(Label6)
        Controls.Add(BTNSIGUIENTE)
        Controls.Add(BTNLIMPIAR)
        Controls.Add(TXTsalida)
        Controls.Add(TXTentrada)
        Controls.Add(TXTdui)
        Controls.Add(TXTtelefono)
        Controls.Add(TXTnombre)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "registro"
        Text = "registro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTnombre As TextBox
    Friend WithEvents TXTtelefono As TextBox
    Friend WithEvents TXTdui As TextBox
    Friend WithEvents TXTentrada As TextBox
    Friend WithEvents TXTsalida As TextBox
    Friend WithEvents BTNLIMPIAR As Button
    Friend WithEvents BTNSIGUIENTE As Button
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents Label6 As Label
End Class
