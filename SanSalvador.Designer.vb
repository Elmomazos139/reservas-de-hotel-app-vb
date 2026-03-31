<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SanSalvador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SanSalvador))
        PictureBox1 = New PictureBox()
        Label10 = New Label()
        LBLADULTOS = New Label()
        LBLNIÑOS = New Label()
        LBLHABITACIONES = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Label6 = New Label()
        BTNVER = New Button()
        BTNVOLVER = New Button()
        LBLMASCOTAS = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(161, 215)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.AppWorkspace
        Label10.Location = New Point(182, 159)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 15)
        Label10.TabIndex = 32
        Label10.Text = "Mascotas:"
        ' 
        ' LBLADULTOS
        ' 
        LBLADULTOS.AutoSize = True
        LBLADULTOS.BackColor = SystemColors.AppWorkspace
        LBLADULTOS.Location = New Point(298, 35)
        LBLADULTOS.Name = "LBLADULTOS"
        LBLADULTOS.Size = New Size(32, 15)
        LBLADULTOS.TabIndex = 30
        LBLADULTOS.Text = "label"
        ' 
        ' LBLNIÑOS
        ' 
        LBLNIÑOS.AutoSize = True
        LBLNIÑOS.BackColor = SystemColors.AppWorkspace
        LBLNIÑOS.Location = New Point(182, 130)
        LBLNIÑOS.Name = "LBLNIÑOS"
        LBLNIÑOS.Size = New Size(32, 15)
        LBLNIÑOS.TabIndex = 28
        LBLNIÑOS.Text = "label"
        ' 
        ' LBLHABITACIONES
        ' 
        LBLHABITACIONES.AutoSize = True
        LBLHABITACIONES.BackColor = SystemColors.AppWorkspace
        LBLHABITACIONES.Location = New Point(298, 130)
        LBLHABITACIONES.Name = "LBLHABITACIONES"
        LBLHABITACIONES.Size = New Size(32, 15)
        LBLHABITACIONES.TabIndex = 26
        LBLHABITACIONES.Text = "label"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlDark
        Label3.Location = New Point(298, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 45)
        Label3.TabIndex = 24
        Label3.Text = "Camas:" & vbCrLf & "1 doble  o" & vbCrLf & "2 individuales"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.AppWorkspace
        Label2.Location = New Point(179, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 30)
        Label2.TabIndex = 23
        Label2.Text = "Habitacion " & vbCrLf & "Doble Estandar" & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonShadow
        Label5.Location = New Point(298, 159)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 15)
        Label5.TabIndex = 22
        Label5.Text = "Precio: $100" & vbCrLf
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.AppWorkspace
        Label4.Location = New Point(179, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 30)
        Label4.TabIndex = 21
        Label4.Text = "Depto. San Salvador" & vbCrLf & "Colonia Escalon" & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Location = New Point(179, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 15)
        Label1.TabIndex = 20
        Label1.Text = "Hotel Los Guapos"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.AppWorkspace
        Label6.Location = New Point(298, 115)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 15)
        Label6.TabIndex = 25
        Label6.Text = "Solo quedan:"
        ' 
        ' BTNVER
        ' 
        BTNVER.Location = New Point(182, 204)
        BTNVER.Name = "BTNVER"
        BTNVER.Size = New Size(75, 23)
        BTNVER.TabIndex = 33
        BTNVER.Text = "Ver más..."
        BTNVER.UseVisualStyleBackColor = True
        ' 
        ' BTNVOLVER
        ' 
        BTNVOLVER.Location = New Point(293, 204)
        BTNVOLVER.Name = "BTNVOLVER"
        BTNVOLVER.Size = New Size(75, 23)
        BTNVOLVER.TabIndex = 34
        BTNVOLVER.Text = "Volver"
        BTNVOLVER.UseVisualStyleBackColor = True
        ' 
        ' LBLMASCOTAS
        ' 
        LBLMASCOTAS.AutoSize = True
        LBLMASCOTAS.BackColor = SystemColors.AppWorkspace
        LBLMASCOTAS.Location = New Point(182, 174)
        LBLMASCOTAS.Name = "LBLMASCOTAS"
        LBLMASCOTAS.Size = New Size(0, 15)
        LBLMASCOTAS.TabIndex = 35
        ' 
        ' SanSalvador
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 261)
        Controls.Add(LBLMASCOTAS)
        Controls.Add(BTNVOLVER)
        Controls.Add(BTNVER)
        Controls.Add(Label10)
        Controls.Add(LBLADULTOS)
        Controls.Add(LBLNIÑOS)
        Controls.Add(LBLHABITACIONES)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "SanSalvador"
        Text = "SanSalvador"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLADULTOS As Label
    Friend WithEvents LBLNIÑOS As Label
    Friend WithEvents LBLHABITACIONES As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BTNVER As Button
    Friend WithEvents BTNVOLVER As Button
    Friend WithEvents LBLMASCOTAS As Label
End Class
