Public Class ReservasConfirmadas
    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        Dim datos = New Datos
        If txtBuscar.Text = " " Or txtBuscar.Text = "" Then
            datos.updateDataGridViewConfirmadas(dgvConfirmadas)
        Else
            datos.searchReservaConfirmada(txtBuscar.Text, dgvConfirmadas)
        End If
    End Sub

    Private Sub ReservasConfirmadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos = New Datos
        datos.updateDataGridViewConfirmadas(dgvConfirmadas)
    End Sub

    Private Sub filtro_onItemSelected(sender As Object, e As EventArgs) Handles filtro.onItemSelected
        Dim datos = New Datos
        If (filtro.selectedIndex = 0) Then
            datos.updateDataGridViewReserva(dgvConfirmadas)
        ElseIf (filtro.selectedIndex = 1) Then
            datos.filterByLastMonth(dgvConfirmadas)
        ElseIf (filtro.selectedIndex = 2) Then
            datos.filterByLastAlquiler(dgvConfirmadas)
        End If
    End Sub
End Class