Public Class Form1
    Private Sub cmdIniciar_Click(sender As Object, e As EventArgs) Handles cmdIniciar.Click

        Dim contador As Integer
        contador = 0

        While (contador <= txtNumero.Text)

            contador = (contador + 1)
            rtfSalida.Text = rtfSalida.Text & contador & vbCr


        End While

    End Sub

    Private Sub cmdLimp_Click(sender As Object, e As EventArgs) Handles cmdLimp.Click

        txtNumero.Text = " "
        rtfSalida.Text = " "

    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click

        End

    End Sub
End Class
