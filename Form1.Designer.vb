<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        CheckMostrar = New CheckBox()
        TXTcontraseña = New TextBox()
        TXTusuario = New TextBox()
        BTNLOGGIN = New Button()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CheckMostrar
        ' 
        CheckMostrar.AutoSize = True
        CheckMostrar.Font = New Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckMostrar.Location = New Point(121, 381)
        CheckMostrar.Name = "CheckMostrar"
        CheckMostrar.Size = New Size(362, 40)
        CheckMostrar.TabIndex = 0
        CheckMostrar.Text = "Mostrar Contraseña"
        CheckMostrar.UseVisualStyleBackColor = True
        ' 
        ' TXTcontraseña
        ' 
        TXTcontraseña.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TXTcontraseña.Location = New Point(121, 325)
        TXTcontraseña.Name = "TXTcontraseña"
        TXTcontraseña.Size = New Size(362, 50)
        TXTcontraseña.TabIndex = 1
        ' 
        ' TXTusuario
        ' 
        TXTusuario.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TXTusuario.Location = New Point(121, 267)
        TXTusuario.Name = "TXTusuario"
        TXTusuario.Size = New Size(362, 50)
        TXTusuario.TabIndex = 2
        ' 
        ' BTNLOGGIN
        ' 
        BTNLOGGIN.BackColor = SystemColors.ActiveBorder
        BTNLOGGIN.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNLOGGIN.Location = New Point(217, 427)
        BTNLOGGIN.Name = "BTNLOGGIN"
        BTNLOGGIN.Size = New Size(170, 49)
        BTNLOGGIN.TabIndex = 3
        BTNLOGGIN.Text = "LOGGIN"
        BTNLOGGIN.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(38, 286)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 25)
        Label1.TabIndex = 4
        Label1.Text = "Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(4, 343)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 25)
        Label2.TabIndex = 5
        Label2.Text = "Contraseña"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-50, -29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(314, 290)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(586, 488)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BTNLOGGIN)
        Controls.Add(TXTusuario)
        Controls.Add(TXTcontraseña)
        Controls.Add(CheckMostrar)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckMostrar As CheckBox
    Friend WithEvents TXTcontraseña As TextBox
    Friend WithEvents TXTusuario As TextBox
    Friend WithEvents BTNLOGGIN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
