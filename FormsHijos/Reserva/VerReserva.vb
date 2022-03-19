Public Class VerReserva

    Private Sub gerenteSalir_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Close()
    End Sub

    Public Sub fill(id As Integer)
        Dim datos = New Datos
        Dim array() = datos.loadAllData(id)
        reserva.Text = id

        fechaV.Text = array(1)
        cliente.Text = array(7)
        nombreApellido.Text = array(8) + " " + array(9)
        direccion.Text = array(10)
        celular.Text = array(11)
        If (array(2) = "T") Then
            metodo.Text = "Tarjeta Debito"
        Else
            metodo.Text = "Contado"
        End If

        mascotas.Text = "x" + array(0) + " Mascotas"

        Dim price As Integer = datos.getPrice(array(6), array(0))
        Dim days As Integer = datos.getDays(id)
        If array(3) And array(4) Then
            dogtv.Text = "$" + (4 * days).ToString
            webcam.Text = "$" + (2 * days).ToString
            servicios.Text = "Servicios Extra: WebCam, DogTV"
        ElseIf array(4) Then
            servicios.Text = "Servicios Extra: DogTV"
            dogtv.Text = (4 * days).ToString
        ElseIf array(3) Then
            servicios.Text = "Servicios Extra: WebCam"
            webcam.Text = (2 * days).ToString
        End If

        reservado.Text = "Reservado por: " + days.ToString + " dias"
        Dim sum As Integer = (days * price) + dogtv.Text.Replace("$", "") + webcam.Text.Replace("$", "")
        final.Text = "$" + sum.ToString

    End Sub
End Class