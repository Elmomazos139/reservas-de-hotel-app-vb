<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detalleslapaz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(detalleslapaz))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
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
        PictureBox1.Location = New Point(3, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(124, 158)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(142, 176)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(117, 131)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(12, 176)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(115, 131)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(133, 26)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(126, 144)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(315, 12)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(348, 204)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlDark
        Label1.Location = New Point(315, 231)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 5
        Label1.Text = "informacion:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveBorder
        Label2.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(315, 259)
        Label2.Name = "Label2"
        Label2.Size = New Size(373, 68)
        Label2.TabIndex = 6
        Label2.Text = "Nuestro hotel te garantiza una buena experiencia en:" & vbCrLf & "comodidad,espacios sofisticados,un amplio menú en comidas." & vbCrLf & "Ademas contamos con otros servicios, que le aseguraran una " & vbCrLf & "buena estadia."
        ' 
        ' BTNCONFIRMAR
        ' 
        BTNCONFIRMAR.BackColor = SystemColors.ActiveBorder
        BTNCONFIRMAR.Location = New Point(3, 325)
        BTNCONFIRMAR.Name = "BTNCONFIRMAR"
        BTNCONFIRMAR.Size = New Size(124, 37)
        BTNCONFIRMAR.TabIndex = 7
        BTNCONFIRMAR.Text = "confirmar reserva"
        BTNCONFIRMAR.UseVisualStyleBackColor = False
        ' 
        ' BTNVOLVER
        ' 
        BTNVOLVER.BackColor = SystemColors.ActiveBorder
        BTNVOLVER.Location = New Point(142, 328)
        BTNVOLVER.Name = "BTNVOLVER"
        BTNVOLVER.Size = New Size(104, 31)
        BTNVOLVER.TabIndex = 8
        BTNVOLVER.Text = "Volver"
        BTNVOLVER.UseVisualStyleBackColor = False
        ' 
        ' detalleslapaz
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(698, 367)
        Controls.Add(BTNVOLVER)
        Controls.Add(BTNCONFIRMAR)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "detalleslapaz"
        Text = "detalleslapaz"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNCONFIRMAR As Button
    Friend WithEvents BTNVOLVER As Button
End Class
