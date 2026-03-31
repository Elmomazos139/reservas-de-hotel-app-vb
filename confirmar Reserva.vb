Public Class confirmar_Reserva

    'Variables para recibir datos
    Public nombre As String
    Public telefono As String
    Public dui As String
    Public entrada As String
    Public salida As String
    Public correo As String

    Private Sub confirmar_Reserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Mostrar datos
        TXTnombre.Text = nombre
        TXTtelefono.Text = telefono
        TXTdui.Text = dui
        TXTentrada.Text = entrada
        TXTsalida.Text = salida
        txtcorreo.Text = correo

        BTNCONFIRMAR.BackColor = Color.LightGray
        BTNCONFIRMAR.FlatStyle = FlatStyle.Flat

        BTNVOLVER.BackColor = Color.LightGray
        BTNVOLVER.FlatStyle = FlatStyle.Flat

    End Sub

    Private Sub BTNCONFIRMAR_Click(sender As Object, e As EventArgs) Handles BTNCONFIRMAR.Click

        MessageBox.Show("Muchas gracias por usar nuestro hotel los guapos.
       Le estaremos enviando un correo electronico confirmando su reserva,si desea modificar sus datos escriba 
       a hotellosguapos@gmail.com,si desea cancelar su reserva puede hacerlo 
       siempre en nuestro contacto en menos de 48H para no aplicarle cargos")



        menu_principal.Show()

        Me.Close()

    End Sub

    Private Sub BTNVOLVER_Click(sender As Object, e As EventArgs) Handles BTNVOLVER.Click

        registro.Show()

        Me.Close()

    End Sub

End Class