Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class NuevaReserva

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Pagina1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Dim isWebCam = False
    Dim isDogTV = False

    Private Function agendar(CICliente As Integer, metodo As String)
        Dim datos = New Datos

        Dim idReserva As Integer = datos.getIncrementalReservaNumber + 1

        datos.getConnection().Close()
        datos.getConnection().Open()

        Dim command = New MySqlCommand

        command.Connection = datos.getConnection
        Using transactions As MySqlTransaction = datos.getConnection().BeginTransaction

            command.Transaction = transactions

            Try

                For Each row As DataGridViewRow In dgvMascotas.Rows

                    If (row.Cells(9).Value = True) Then
                        isWebCam = True
                    End If

                    If (row.Cells(10).Value = True) Then
                        isDogTV = True
                    End If

                Next

                command.Parameters.AddWithValue("@idr", idReserva)
                command.Parameters.AddWithValue("@estado", "P")
                command.Parameters.AddWithValue("@cantidad", cantidadmascotas.Text)
                command.Parameters.AddWithValue("@fechaIni", fechainicio.Value)
                command.Parameters.AddWithValue("@fechaFin", fechaTerminacion.Value)
                command.Parameters.AddWithValue("@metodo", metodo)
                command.Parameters.AddWithValue("@webcam", isWebCam)
                command.Parameters.AddWithValue("@dogtv", isDogTV)
                command.Parameters.AddWithValue("@CIE", Datos.CILogged)

                command.CommandText = "INSERT INTO reserva (`ID_Reserva`, `Estado`, `CantidadDeMascotas`, `FechaYHoraDesde`, `FechaYHoraHasta`, `MetodoDePago`, `WebCam`, `DogTV`, `CIEmpleado`) VALUES (@idr, @estado, @cantidad, @fechaIni, @FechaFin, @metodo, @webcam, @dogtv, @CIE);"
                command.ExecuteNonQuery()

                For Each row As DataGridViewRow In dgvMascotas.Rows
                    command.Parameters.Clear()

                    command.Parameters.AddWithValue("@idr", idReserva)
                    command.Parameters.AddWithValue("@id", row.Cells(0).Value)
                    command.Parameters.AddWithValue("@nombre", row.Cells(1).Value)
                    command.Parameters.AddWithValue("@fecha", row.Cells(2).Value)
                    command.Parameters.AddWithValue("@vacunas", row.Cells(3).Value)
                    command.Parameters.AddWithValue("@comida", row.Cells(4).Value)
                    command.Parameters.AddWithValue("@peso", row.Cells(5).Value)
                    command.Parameters.AddWithValue("@raza", row.Cells(6).Value)
                    command.Parameters.AddWithValue("@sexo", row.Cells(7).Value)
                    command.Parameters.AddWithValue("@habitacion", row.Cells(8).Value)
                    command.Parameters.AddWithValue("@cicliente", CICliente)

                    command.CommandText = "INSERT INTO mascota VALUES (@id, @nombre, @fecha, @vacunas, @comida, @peso, @raza, @sexo, @cicliente); INSERT INTO aloja VALUES (@id, @habitacion); INSERT into tiene VALUES (@idr, @id, @habitacion);"
                    command.ExecuteNonQuery()
                Next

                For Each row As DataGridViewRow In dgvMedicamentos.Rows
                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("@id", row.Cells(0).Value)
                    command.Parameters.AddWithValue("@nombre", row.Cells(2).Value)
                    command.Parameters.AddWithValue("@mascota", row.Cells(1).Value)
                    command.Parameters.AddWithValue("@dosis", row.Cells(3).Value)
                    command.Parameters.AddWithValue("@horario", row.Cells(4).Value)
                    command.CommandText = "INSERT INTO consume VALUES (@horario, @mascota, @id, @dosis);"
                    command.ExecuteNonQuery()
                Next

                For Each row As DataGridViewRow In dgvTransportes.Rows
                    command.Parameters.Clear()
                    command.Parameters.AddWithValue("@id", row.Cells(0).Value)
                    command.Parameters.AddWithValue("@vehiculo", row.Cells(1).Value)
                    command.Parameters.AddWithValue("@fecha", row.Cells(2).Value)
                    command.Parameters.AddWithValue("@horario", row.Cells(3).Value)
                    command.Parameters.AddWithValue("@tipo", row.Cells(4).Value)
                    command.Parameters.AddWithValue("@direccion", row.Cells(5).Value)

                    If (row.Cells(3).Value = "M") Then
                        command.CommandText = "INSERT INTO transporte VALUES (@id, @vehiculo, @fecha, @horario, 'P', @tipo, @direccion, '1');"
                    ElseIf row.Cells(3).Value = "Ta" Then
                        command.CommandText = "INSERT INTO transporte VALUES (@id, @vehiculo, @fecha, @horario, 'P', @tipo, @direccion, '2');"
                    ElseIf row.Cells(3).Value = "N" Then
                        command.CommandText = "INSERT INTO transporte VALUES (@id, @vehiculo, @fecha, @horario, 'P', @tipo, @direccion, '3');"
                    End If
                    command.ExecuteNonQuery()
                Next

                transactions.Commit()

                Return True
            Catch ex As MySqlException
                transactions.Rollback()
                Debug.Write(ex.Message)
                Debug.Write(ex.StackTrace)
                datos.getConnection.Close()
                Return False
            End Try
        End Using
        datos.getConnection.Close()
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles registrar.Click
        Dim metodo
        If metodoDePago.selectedIndex = 1 Then
            metodo = "T"
        Else
            metodo = "C"
        End If
        If Not clientes.selectedIndex < 0 Then
            Dim ci = clientes.selectedValue.Split(" ")
            If fechainicio.Value >= Today Then
                If fechaTerminacion.Value > fechainicio.Value Then
                    If validarNumero(cantidadmascotas) Then
                        If dgvMascotas.Rows.Count > 0 Then
                            If Not cantidadmascotas.Text > dgvMascotas.Rows.Count Then
                                If Not cantidadmascotas.Text < dgvMascotas.Rows.Count Then
                                    If agendar(ci(0), metodo) Then
                                        FormSucess.callFormWithMessage("¡Se ha guardado con éxito!")
                                        Close()
                                    Else
                                        FormInfo.callFormWithMessage("¡Ha ocurrido un error al guardar la reserva!")
                                    End If
                                Else
                                    FormInfo.callFormWithMessage("La cantidad ingresada de mascotas tienen que coincidir")
                                End If
                            Else
                                FormInfo.callFormWithMessage("La cantidad ingresada de mascotas tienen que coincidir")
                            End If
                        Else
                            FormInfo.callFormWithMessage("Tienes que ingresar al menos una mascota")
                        End If
                    End If
                Else
                    FormInfo.callFormWithMessage("¡La Fecha de terminación tiene que ser superior a la fecha de inicio!")
                End If
            Else
                FormInfo.callFormWithMessage("¡La Fecha de inicio no puede ser menor a hoy!")
            End If
        Else
            FormInfo.callFormWithMessage("¡Eliga un cliente!")
        End If
    End Sub

    Private Sub NuevaReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos = New Datos
        fechainicio.Value = Now
        fechaTerminacion.Value = Now
        datos.loadClientes(clientes)
    End Sub

    Private Sub agregarMascota_Click(sender As Object, e As EventArgs) Handles agregarMascota.Click
        If Not clientes.selectedIndex = -1 Then
            Dim ci = clientes.selectedValue.Split(" ")
            Dim añadirMascota = New AgregarMascota
            añadirMascota.ShowDialog()
            If añadirMascota.fill(dgvMascotas) Then
                FormInfo.callFormWithMessage("¡Mascota añadida correctamente!")
            End If
        Else
            FormInfo.callFormWithMessage("¡Seleccione un cliente primero!")
        End If
    End Sub

    Private Sub dgvMascotas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMascotas.CellContentClick
        If e.ColumnIndex = 13 Then
            dgvMascotas.Rows.RemoveAt(e.RowIndex)
        ElseIf e.ColumnIndex = 12 Then
            If dgvTransportes.Rows.Count < (dgvMascotas.Rows.Count * 2) Then
                Dim agregarTransporte = New AgregarTransporte
                agregarTransporte.mascota.Text = dgvMascotas.Rows(e.RowIndex).Cells(0).Value
                agregarTransporte.ShowDialog()
                If agregarTransporte.fill(dgvTransportes) Then
                    FormInfo.callFormWithMessage("¡Transporte añadido correctamente!")
                End If
            Else
                FormInfo.callFormWithMessage("No puedes añadir mas transportes")
            End If
        ElseIf e.ColumnIndex = 11 Then
            Dim añadirMedicamento = New AgregarMedicamento
            añadirMedicamento.id.Text = dgvMascotas.Rows(e.RowIndex).Cells(0).Value
            añadirMedicamento.ShowDialog()
            If añadirMedicamento.fill(dgvMedicamentos) Then
                FormInfo.callFormWithMessage("¡Medicamento añadido correctamente!")
            End If
        End If
    End Sub

    Private Sub dgvMedicamentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedicamentos.CellContentClick
        If e.ColumnIndex = 5 Then
            dgvMedicamentos.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub dgvTransportes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransportes.CellContentClick
        If e.ColumnIndex = 6 Then
            dgvTransportes.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub
End Class