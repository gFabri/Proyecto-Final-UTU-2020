Public Class GestionClientes

    Private Sub nuevocliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Dim datos = New Datos
        If Not datos.checkConnection() Then
            Return
        End If
        Dim newClient As NuevoCliente = New NuevoCliente
        newClient.ShowDialog()
        datos.updateDataGridViewCliente(dgvClientes)
    End Sub

    Private Sub GestionReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos = New Datos
        If Not datos.checkConnection() Then
            Return
        End If
        datos.updateDataGridViewCliente(dgvClientes)
    End Sub

    Private Sub clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        Dim datos = New Datos
        If Not datos.checkConnection() Then
            Return
        End If
        If e.ColumnIndex.Equals(6) Then
            Dim openModify As ModificarCliente = New ModificarCliente
            openModify.setDataGridView(dgvClientes.Rows(e.RowIndex).Cells(0).Value, dgvClientes.Rows(e.RowIndex).Cells(1).Value, dgvClientes.Rows(e.RowIndex).Cells(2).Value,
            dgvClientes.Rows(e.RowIndex).Cells(3).Value, dgvClientes.Rows(e.RowIndex).Cells(4).Value, dgvClientes.Rows(e.RowIndex).Cells(5).Value)
            openModify.ShowDialog()
            datos.updateDataGridViewCliente(dgvClientes)
        ElseIf e.ColumnIndex.Equals(7) Then
            Dim result As DialogResult = New DialogResult()
            result = FormWarn.callFormWithMessage("AVISO", "¿Estas seguro que deseas eliminar este cliente?")
            If result = DialogResult.OK Then
                If datos.eliminarCliente(dgvClientes.Rows(e.RowIndex).Cells(0).Value) Then
                    FormSucess.callFormWithMessage("La Eliminación ha sido exitosa!")
                    dgvClientes.Rows.RemoveAt(e.RowIndex)
                Else
                    FormInfo.callFormWithMessage("Ha ocurrido un error al borrar el cliente!")
                End If
            End If
        End If
    End Sub

    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        Dim datos = New Datos
        If txtBuscar.Text = " " Or txtBuscar.Text = "" Then
            datos.updateDataGridViewCliente(dgvClientes)
        Else
            datos.searchCliente(txtBuscar.Text, dgvClientes)
        End If
    End Sub

End Class