<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detalles_San_Vicente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(detalles_San_Vicente))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        BTNCONFIRMAR = New Button()
        BTNVOLVER = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(151, 156)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(188, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(128, 156)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-8, 174)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(190, 182)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(188, 174)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(137, 182)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(344, 12)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(360, 191)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveBorder
        Label2.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(331, 253)
        Label2.Name = "Label2"
        Label2.Size = New Size(373, 68)
        Label2.TabIndex = 8
        Label2.Text = "Nuestro hotel te garantiza una buena experiencia en:" & vbCrLf & "comodidad,espacios sofisticados,un amplio menú en comidas." & vbCrLf & "Ademas contamos con otros servicios, que le aseguraran una " & vbCrLf & "buena estadia."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlDark
        Label1.Location = New Point(331, 225)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 7
        Label1.Text = "informacion:"
        ' 
        ' BTNCONFIRMAR
        ' 
        BTNCONFIRMAR.Location = New Point(359, 340)
        BTNCONFIRMAR.Name = "BTNCONFIRMAR"
        BTNCONFIRMAR.Size = New Size(132, 23)
        BTNCONFIRMAR.TabIndex = 9
        BTNCONFIRMAR.Text = "Confirmar Reserva"
        BTNCONFIRMAR.UseVisualStyleBackColor = True
        ' 
        ' BTNVOLVER
        ' 
        BTNVOLVER.Location = New Point(543, 340)
        BTNVOLVER.Name = "BTNVOLVER"
        BTNVOLVER.Size = New Size(75, 23)
        BTNVOLVER.TabIndex = 10
        BTNVOLVER.Text = "Volver"
        BTNVOLVER.UseVisualStyleBackColor = True
        ' 
        ' detalles_San_Vicente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(710, 371)
        Controls.Add(BTNVOLVER)
        Controls.Add(BTNCONFIRMAR)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "detalles_San_Vicente"
        Text = "detalles_San_Vicente"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNCONFIRMAR As Button
    Friend WithEvents BTNVOLVER As Button
End Class
