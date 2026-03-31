Public Class registro

    Private Sub BTNLIMPIAR_Click(sender As Object, e As EventArgs) Handles BTNLIMPIAR.Click
        TXTnombre.Clear()
        TXTdui.Clear()
        TXTentrada.Clear()
        TXTsalida.Clear()
        TXTtelefono.Clear()
        txtcorreo.Clear()
    End Sub

    Private Sub BTNSIGUIENTE_Click(sender As Object, e As EventArgs) Handles BTNSIGUIENTE.Click

        'Pasar datos al otro formulario
        confirmar_Reserva.nombre = TXTnombre.Text
        confirmar_Reserva.telefono = TXTtelefono.Text
        confirmar_Reserva.dui = TXTdui.Text
        confirmar_Reserva.entrada = TXTentrada.Text
        confirmar_Reserva.salida = TXTsalida.Text
        confirmar_Reserva.correo = txtcorreo.Text

        confirmar_Reserva.Show()

        Me.Close()


    End Sub

    Private Sub registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTNLIMPIAR.BackColor = Color.LightGray
        BTNLIMPIAR.FlatStyle = FlatStyle.Flat

        BTNSIGUIENTE.BackColor = Color.LightGray
        BTNSIGUIENTE.FlatStyle = FlatStyle.Flat
    End Sub

End Class