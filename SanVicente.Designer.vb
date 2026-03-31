<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SanVicente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SanVicente))
        PictureBox1 = New PictureBox()
        LBLMASCOTAS = New Label()
        Label10 = New Label()
        LBLADULTOS = New Label()
        LBLNIÑOS = New Label()
        LBLHABITACIONES = New Label()
        BTNVOLVER = New Button()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        BTNVER = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(159, 194)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' LBLMASCOTAS
        ' 
        LBLMASCOTAS.AutoSize = True
        LBLMASCOTAS.BackColor = SystemColors.AppWorkspace
        LBLMASCOTAS.Location = New Point(152, 171)
        LBLMASCOTAS.Name = "LBLMASCOTAS"
        LBLMASCOTAS.Size = New Size(0, 15)
        LBLMASCOTAS.TabIndex = 36
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.AppWorkspace
        Label10.Location = New Point(190, 156)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 15)
        Label10.TabIndex = 35
        Label10.Text = "Mascotas:"
        ' 
        ' LBLADULTOS
        ' 
        LBLADULTOS.AutoSize = True
        LBLADULTOS.BackColor = SystemColors.AppWorkspace
        LBLADULTOS.Location = New Point(306, 32)
        LBLADULTOS.Name = "LBLADULTOS"
        LBLADULTOS.Size = New Size(32, 15)
        LBLADULTOS.TabIndex = 33
        LBLADULTOS.Text = "label"
        ' 
        ' LBLNIÑOS
        ' 
        LBLNIÑOS.AutoSize = True
        LBLNIÑOS.BackColor = SystemColors.AppWorkspace
        LBLNIÑOS.Location = New Point(190, 127)
        LBLNIÑOS.Name = "LBLNIÑOS"
        LBLNIÑOS.Size = New Size(32, 15)
        LBLNIÑOS.TabIndex = 31
        LBLNIÑOS.Text = "label"
        ' 
        ' LBLHABITACIONES
        ' 
        LBLHABITACIONES.AutoSize = True
        LBLHABITACIONES.BackColor = SystemColors.AppWorkspace
        LBLHABITACIONES.Location = New Point(306, 127)
        LBLHABITACIONES.Name = "LBLHABITACIONES"
        LBLHABITACIONES.Size = New Size(32, 15)
        LBLHABITACIONES.TabIndex = 29
        LBLHABITACIONES.Text = "label"
        ' 
        ' BTNVOLVER
        ' 
        BTNVOLVER.BackColor = SystemColors.ActiveBorder
        BTNVOLVER.Location = New Point(303, 193)
        BTNVOLVER.Name = "BTNVOLVER"
        BTNVOLVER.Size = New Size(82, 26)
        BTNVOLVER.TabIndex = 28
        BTNVOLVER.Text = "Volver"
        BTNVOLVER.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.AppWorkspace
        Label6.Location = New Point(306, 112)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 15)
        Label6.TabIndex = 27
        Label6.Text = "Solo quedan:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlDark
        Label3.Location = New Point(306, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 45)
        Label3.TabIndex = 26
        Label3.Text = "Camas:" & vbCrLf & "1 doble  o" & vbCrLf & "2 individuales"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.AppWorkspace
        Label2.Location = New Point(187, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 30)
        Label2.TabIndex = 25
        Label2.Text = "Habitacion " & vbCrLf & "Doble Estandar" & vbCrLf
        ' 
        ' BTNVER
        ' 
        BTNVER.BackColor = SystemColors.ActiveBorder
        BTNVER.Location = New Point(187, 193)
        BTNVER.Name = "BTNVER"
        BTNVER.Size = New Size(82, 26)
        BTNVER.TabIndex = 24
        BTNVER.Text = "ver màs..."
        BTNVER.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonShadow
        Label5.Location = New Point(306, 156)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 15)
        Label5.TabIndex = 23
        Label5.Text = "Precio: $100" & vbCrLf
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.AppWorkspace
        Label4.Location = New Point(187, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 30)
        Label4.TabIndex = 22
        Label4.Text = "Depto. La Paz " & vbCrLf & "Zacatecóluca" & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Location = New Point(187, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 15)
        Label1.TabIndex = 21
        Label1.Text = "Hotel Los Guapos"
        ' 
        ' SanVicente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 226)
        Controls.Add(LBLMASCOTAS)
        Controls.Add(Label10)
        Controls.Add(LBLADULTOS)
        Controls.Add(LBLNIÑOS)
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
        Name = "SanVicente"
        Text = "SanVicente"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LBLMASCOTAS As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLADULTOS As Label
    Friend WithEvents LBLNIÑOS As Label
    Friend WithEvents LBLHABITACIONES As Label
    Friend WithEvents BTNVOLVER As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNVER As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
