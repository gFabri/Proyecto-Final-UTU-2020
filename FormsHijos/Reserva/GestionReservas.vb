Public Class GestionReservas

    Private Sub nuevareserva_Click(sender As Object, e As EventArgs) Handles btnNuevaReserva.Click
        Dim datos = New Datos
        If Not datos.checkConnection() Then
            Return
        End If
        Dim newReserv = New NuevaReserva
        newReserv.ShowDialog()
        datos.updateDataGridViewReserva(dgvReservas)
    End Sub

    Private Sub GestionReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos = New Datos
        If Not datos.checkConnection() Then
            Return
        End If
        datos.updateDataGridViewReserva(dgvReservas)
    End Sub

    Private Sub clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservas.CellContentClick
        Dim datos = New Datos
        If Not datos.checkConnection() Then
            Return
        End If
        If e.ColumnIndex.Equals(11) Then
            Dim openModify As EditarReserva = New EditarReserva
            openModify.cliente.Text = dgvReservas.Rows(e.RowIndex).Cells(0).Value
            openModify.fechainicio.Value = dgvReservas.Rows(e.RowIndex).Cells(5).Value
            openModify.fechaTerminacion.Value = dgvReservas.Rows(e.RowIndex).Cells(6).Value
            openModify.ShowDialog()
            datos.updateDataGridViewReserva(dgvReservas)
        ElseIf e.ColumnIndex.Equals(12) Then
            Dim result As DialogResult = New DialogResult()
            result = FormWarn.callFormWithMessage("AVISO", "¿Estas seguro que deseas eliminar esta reserva?")
            If result = DialogResult.OK Then
                If datos.eliminarReserva(dgvReservas.Rows(e.RowIndex).Cells(0).Value) Then
                    datos.eliminarTransporte(dgvReservas.Rows(e.RowIndex).Cells(0).Value)
                    FormSucess.callFormWithMessage("La Baja ha sido exitosa!")
                    dgvReservas.Rows.RemoveAt(e.RowIndex)
                Else
                    FormInfo.callFormWithMessage("¡Ha ocurrido un error al borrar la reserva!")
                End If
            End If
        ElseIf e.ColumnIndex.Equals(13) Then
            Dim result As DialogResult = New DialogResult()
            result = FormWarn.callFormWithMessage("AVISO", "¿Estas seguro que deseas confirmar esta reserva?")
            If result = DialogResult.OK Then
                If datos.confirmarReserva(dgvReservas.Rows(e.RowIndex).Cells(0).Value) Then
                    FormSucess.callFormWithMessage("¡La Confirmación ha sido exitosa!")
                    datos.updateDataGridViewReserva(dgvReservas)
                Else
                    FormInfo.callFormWithMessage("¡Ha ocurrido un error al confirmar la reserva!")
                End If
            End If
        ElseIf e.ColumnIndex.Equals(14) Then
            Dim view As VerReserva = New VerReserva
            view.fill(dgvReservas.Rows(e.RowIndex).Cells(0).Value)
            view.ShowDialog()
        End If
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        Dim datos = New Datos
        If txtBuscar.Text = " " Or txtBuscar.Text = "" Then
            datos.updateDataGridViewReserva(dgvReservas)
        Else
            datos.searchReserva(txtBuscar.Text, dgvReservas)
        End If
    End Sub
End Class