Public Class ModificarPrecioHabitacion

    Private Sub ModificarPrecioHabitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos = New Datos
        datos.updateDataGridViewHabitacion(dgvHabitaciones)
    End Sub

    Private Sub dgvHabitaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHabitaciones.CellContentClick
        Dim datos = New Datos
        If Not datos.checkConnection() Then
            Return
        End If
        If e.ColumnIndex.Equals(5) Then
            Dim openModify = New ModificarHabitaciones
            openModify.setDataGridView(dgvHabitaciones.Rows(e.RowIndex).Cells(1).Value, dgvHabitaciones.Rows(e.RowIndex).Cells(4).Value, dgvHabitaciones.Rows(e.RowIndex).Cells(3).Value)
            openModify.ShowDialog()
            datos.updateDataGridViewHabitacion(dgvHabitaciones)
        ElseIf e.ColumnIndex.Equals(0) Then
            Dim prevHab = New PrevisualizarHabitacion
            prevHab.applyImage(dgvHabitaciones.Rows(e.RowIndex).Cells(2).Value)
            prevHab.Show()

        End If
    End Sub

End Class