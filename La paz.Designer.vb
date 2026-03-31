<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class La_paz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(La_paz))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        BTNVER = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        BTNVOLVER = New Button()
        LBLHABITACIONES = New Label()
        Label7 = New Label()
        LBLNIÑOS = New Label()
        Label8 = New Label()
        LBLADULTOS = New Label()
        Label9 = New Label()
        Label10 = New Label()
        LBLMASCOTAS = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(24, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(142, 176)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Location = New Point(172, 1)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 15)
        Label1.TabIndex = 3
        Label1.Text = "Hotel Los Guapos"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.AppWorkspace
        Label4.Location = New Point(172, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 30)
        Label4.TabIndex = 6
        Label4.Text = "Depto. La Paz " & vbCrLf & "Zacatecóluca" & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonShadow
        Label5.Location = New Point(291, 148)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 15)
        Label5.TabIndex = 7
        Label5.Text = "Precio: $100" & vbCrLf
        ' 
        ' BTNVER
        ' 
        BTNVER.BackColor = SystemColors.ActiveBorder
        BTNVER.Location = New Point(172, 185)
        BTNVER.Name = "BTNVER"
        BTNVER.Size = New Size(82, 26)
        BTNVER.TabIndex = 8
        BTNVER.Text = "ver màs..."
        BTNVER.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.AppWorkspace
        Label2.Location = New Point(172, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 30)
        Label2.TabIndex = 9
        Label2.Text = "Habitacion " & vbCrLf & "Doble Estandar" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlDark
        Label3.Location = New Point(291, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 45)
        Label3.TabIndex = 10
        Label3.Text = "Camas:" & vbCrLf & "1 doble  o" & vbCrLf & "2 individuales"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.AppWorkspace
        Label6.Location = New Point(291, 104)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 15)
        Label6.TabIndex = 11
        Label6.Text = "Solo quedan:"
        ' 
        ' BTNVOLVER
        ' 
        BTNVOLVER.BackColor = SystemColors.ActiveBorder
        BTNVOLVER.Location = New Point(288, 185)
        BTNVOLVER.Name = "BTNVOLVER"
        BTNVOLVER.Size = New Size(82, 26)
        BTNVOLVER.TabIndex = 12
        BTNVOLVER.Text = "Volver"
        BTNVOLVER.UseVisualStyleBackColor = False
        ' 
        ' LBLHABITACIONES
        ' 
        LBLHABITACIONES.AutoSize = True
        LBLHABITACIONES.BackColor = SystemColors.AppWorkspace
        LBLHABITACIONES.Location = New Point(291, 119)
        LBLHABITACIONES.Name = "LBLHABITACIONES"
        LBLHABITACIONES.Size = New Size(32, 15)
        LBLHABITACIONES.TabIndex = 13
        LBLHABITACIONES.Text = "label"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.AppWorkspace
        Label7.Location = New Point(176, 104)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 14
        Label7.Text = "niños:"
        ' 
        ' LBLNIÑOS
        ' 
        LBLNIÑOS.AutoSize = True
        LBLNIÑOS.BackColor = SystemColors.AppWorkspace
        LBLNIÑOS.Location = New Point(175, 119)
        LBLNIÑOS.Name = "LBLNIÑOS"
        LBLNIÑOS.Size = New Size(32, 15)
        LBLNIÑOS.TabIndex = 15
        LBLNIÑOS.Text = "label"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.AppWorkspace
        Label8.Location = New Point(291, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 15)
        Label8.TabIndex = 16
        Label8.Text = "Adultos"
        ' 
        ' LBLADULTOS
        ' 
        LBLADULTOS.AutoSize = True
        LBLADULTOS.BackColor = SystemColors.AppWorkspace
        LBLADULTOS.Location = New Point(291, 24)
        LBLADULTOS.Name = "LBLADULTOS"
        LBLADULTOS.Size = New Size(32, 15)
        LBLADULTOS.TabIndex = 17
        LBLADULTOS.Text = "label"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.AppWorkspace
        Label9.Location = New Point(175, 104)
        Label9.Name = "Label9"
        Label9.Size = New Size(41, 15)
        Label9.TabIndex = 18
        Label9.Text = "Niños:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.AppWorkspace
        Label10.Location = New Point(175, 148)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 15)
        Label10.TabIndex = 19
        Label10.Text = "Mascotas:"
        ' 
        ' LBLMASCOTAS
        ' 
        LBLMASCOTAS.AutoSize = True
        LBLMASCOTAS.BackColor = SystemColors.AppWorkspace
        LBLMASCOTAS.Location = New Point(175, 163)
        LBLMASCOTAS.Name = "LBLMASCOTAS"
        LBLMASCOTAS.Size = New Size(0, 15)
        LBLMASCOTAS.TabIndex = 20
        ' 
        ' La_paz
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(388, 223)
        Controls.Add(LBLMASCOTAS)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(LBLADULTOS)
        Controls.Add(Label8)
        Controls.Add(LBLNIÑOS)
        Controls.Add(Label7)
        Controls.Add(LBLHABITACIONES)
        Controls.Add(BTNVOLVER)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BTNVER)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "La_paz"
        Text = "La_paz"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BTNVER As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BTNVOLVER As Button
    Friend WithEvents LBLHABITACIONES As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBLNIÑOS As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LBLADULTOS As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLMASCOTAS As Label
End Class
