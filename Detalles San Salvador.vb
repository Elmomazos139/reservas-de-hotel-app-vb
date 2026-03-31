Public Class Detalles_San_Salvador

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNVOLVER.Click
        SanSalvador.Show()


        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNCONFIRMAR.Click
        registro.Show()


        Me.Close()

    End Sub

    Private Sub detalleslapaz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTNVOLVER.BackColor = Color.LightGray
        BTNVOLVER.FlatStyle = FlatStyle.Flat
    End Sub
End Class