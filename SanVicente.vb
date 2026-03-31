Public Class SanVicente

    ' Variables públicas para recibir datos
    Public adultos As String
    Public niños As String
    Public habitaciones As String
    Public mascotas As Boolean

    Private Sub La_paz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarDatos()
    End Sub

    ' Método para mostrar los datos en Labels
    Public Sub ActualizarDatos()
        LBLADULTOS.Text = "Adultos: " & adultos
        LBLNIÑOS.Text = "Niños: " & niños
        LBLHABITACIONES.Text = "Habitaciónes: " & habitaciones

        If mascotas Then
            LBLMASCOTAS.Text = "Con mascotas"
        Else
            LBLMASCOTAS.Text = "Sin mascotas"
        End If
    End Sub

    Private Sub BTNVOLVER_Click(sender As Object, e As EventArgs) Handles BTNVOLVER.Click
        ' Volver al menú principal
        Dim menu As New menu_principal
        menu.Show()

        Me.Close()

    End Sub

    Private Sub BTNVER_Click(sender As Object, e As EventArgs) Handles BTNVER.Click
        detalles_San_Vicente.Show()

        Me.Close()


    End Sub

    Private Sub LBLHABITACIONES_Click(sender As Object, e As EventArgs) Handles LBLHABITACIONES.Click

    End Sub
End Class