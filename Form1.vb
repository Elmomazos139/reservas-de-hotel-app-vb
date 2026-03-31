Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TXTcontraseña.UseSystemPasswordChar = True


        BTNLOGGIN.BackColor = Color.LightGray
        BTNLOGGIN.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub checkmostrar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMostrar.CheckedChanged
        If CheckMostrar.Checked Then
            TXTcontraseña.UseSystemPasswordChar = False
        Else
            TXTcontraseña.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub btnloggin_Click(sender As Object, e As EventArgs) Handles BTNLOGGIN.Click
        Dim usuario As String = TXTusuario.Text
        Dim contraseña As String = TXTcontraseña.Text

        If usuario = "admin" And contraseña = "1234" Then
            MessageBox.Show("Bienvenido " & usuario, "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim menu As New menu_principal
            menu_principal.Show()



            Me.Hide()

        Else
            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnloggin_MouseEnter(sender As Object, e As EventArgs) Handles BTNLOGGIN.MouseEnter
        BTNLOGGIN.BackColor = Color.DeepSkyBlue
        BTNLOGGIN.ForeColor = Color.White
    End Sub

    Private Sub btnloggin_MouseLeave(sender As Object, e As EventArgs) Handles BTNLOGGIN.MouseLeave
        BTNLOGGIN.BackColor = Color.LightGray
        BTNLOGGIN.ForeColor = Color.Black
    End Sub

End Class