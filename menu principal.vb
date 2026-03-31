Public Class menu_principal
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click

        ' Verificar que se seleccionó un departamento
        If CBDEPARTAMENTO.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un departamento")
            Exit Sub
        End If

        Dim dep As String = CBDEPARTAMENTO.SelectedItem.ToString()

        If dep = "La Paz" Then

            Dim f As New La_paz
            f.adultos = TXTADULTOS.Text
            f.niños = TXTNIÑOS.Text
            f.habitaciones = CBHABITACIONES.Text
            f.mascotas = chkmascotas.Checked
            f.Show()

        ElseIf dep = "SanSalvador" Then

            SanSalvador.Show()
            Dim f As New SanSalvador
            f.adultos = TXTADULTOS.Text
            f.niños = TXTNIÑOS.Text
            f.habitaciones = CBHABITACIONES.Text
            f.mascotas = chkmascotas.Checked
            f.Show()

        ElseIf dep = "SanVicente" Then
            SanVicente.Show()



        End If

        ' Cerrar el menu principal

    End Sub

    Private Sub menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnsiguiente.BackColor = Color.LightGray
        btnsiguiente.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub
End Class