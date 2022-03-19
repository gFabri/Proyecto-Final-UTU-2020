Public Class ReservasSalidaConfirmada
    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        Dim datos = New Datos
        If txtBuscar.Text = " " Or txtBuscar.Text = "" Then
            datos.obtenerTransportesDeSalida(dgvSalidas)
        Else
            dgvSalidas.Rows.Clear()
            datos.searchTransporteDeSalida(txtBuscar.Text, dgvSalidas)
        End If
    End Sub

    Private Sub dgvReservas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalidas.CellContentClick
        If (e.ColumnIndex = 4) Then
            Dim datos = New Datos
            Dim result As DialogResult = New DialogResult()
            result = FormWarn.callFormWithMessage("AVISO", "¿Estas seguro que deseas confirmar esta reserva?")
            If result = DialogResult.OK Then
                If datos.confirmarTransportes(dgvSalidas.Rows(e.RowIndex).Cells(0).Value, dgvSalidas.Rows(e.RowIndex).Cells(1).Value, dgvSalidas.Rows(e.RowIndex).Cells(2).Value, dgvSalidas.Rows(e.RowIndex).Cells(3).Value) Then
                    FormSucess.callFormWithMessage("Se ha confirmado correctamente")
                    datos.obtenerTransportesDeEntrada(dgvSalidas)
                Else
                    FormInfo.callFormWithMessage("Ha ocurrido un error al confirmar")
                End If
            End If
        End If
    End Sub

    Private Sub ReservasSalidaConfirmada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos = New Datos
        datos.obtenerTransportesDeSalida(dgvSalidas)
    End Sub
End Class