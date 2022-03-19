Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Datos

#Region "Conexion"

    Private connection As MySqlConnection = New MySqlConnection("datasource=localhost; username=fbravo; password=52059150; database=fbravo") 'Conexion con la Base de Datos'

    Public Shared CILogged As Integer

    Public Function checkConnection() 'Comprueba la Conexion con la Base de datos'
        Try
            connection.Open()
            Return True
        Catch ex As Exception
            FormInfo.callFormWithMessage("Compruebe su conectividad a internet")
            Return False
        End Try
    End Function

    Public Function getConnection() As MySqlConnection 'Metodo para Obtener la Conexion'
        Return connection
    End Function

#End Region

#Region "Reservas Entradas/Salidas Confirmadas"

    Public Function confirmarTransportes(id As String, vehiculo As String, fecha As Date, horario As String) 'Metodo para ver si hay transportes disponibles en cierta fecha'
        Try
            getConnection().Close()
            getConnection().Open()
            Dim command = New MySqlCommand("UPDATE transporte SET Estado = 'C' WHERE ID_Mascota=@id and ID_Vehículo=@vehiculo and Horario=@horario and FechaDEtransporte=@fecha; INSERT into confirma VALUES (@id, @vehiculo, @fecha, @horario, @empleado);", getConnection())
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@vehiculo", vehiculo)
            command.Parameters.AddWithValue("@fecha", fecha)
            command.Parameters.AddWithValue("@horario", horario)
            command.Parameters.AddWithValue("@empleado", Datos.CILogged)
            command.CommandType = CommandType.Text
            Return command.ExecuteNonQuery
            getConnection.Close()
        Catch ex As MySqlException
            Debug.Write(ex.Message)
            getConnection.Close()
            Return False
        End Try
    End Function

    Public Sub searchTransporteDeEntrada(txt As String, dgv As DataGridView) 'Busca un transporte de entrada apartir de un texto ingresado'
        Try
            getConnection().Close()
            getConnection().Open()
            Dim command = New MySqlCommand("SELECT ID_Mascota, ID_Vehículo, FechaDEtransporte, Horario, Tipo FROM transporte WHERE Tipo='T' and Estado='P' and ID_Mascota LIKE '" + txt + "%' or ID_Vehículo LIKE '" + txt + "%' or Horario LIKE '" + txt + "%';", getConnection())
            Dim reader = command.ExecuteReader
            dgv.Rows.Clear()
            While reader.Read
                dgv.Rows.Add(reader(0), reader(1), Date.Parse(reader(2)).ToString("yyyy/MM/dd"), reader(3))
            End While
            reader.Close()
            getConnection.Close()
        Catch ex As MySqlException
            Debug.Write(ex.Message)
            getConnection.Close()
        End Try
    End Sub

    Public Sub searchTransporteDeSalida(txt As String, dgv As DataGridView) 'Busca un transporte de salida apartir de un texto ingresado'
        Try
            getConnection().Close()
            getConnection().Open()
            Dim command = New MySqlCommand("SELECT ID_Mascota, ID_Vehículo, FechaDEtransporte, Horario, Tipo FROM transporte WHERE Tipo='LL' and Estado='P' and ID_Mascota LIKE '" + txt + "%' or ID_Vehículo LIKE '" + txt + "%' or Horario LIKE '" + txt + "%';", getConnection())
            Dim reader = command.ExecuteReader
            dgv.Rows.Clear()
            While reader.Read
                dgv.Rows.Add(reader(0), reader(1), Date.Parse(reader(2)).ToString("yyyy/MM/dd"), reader(3))
            End While
            reader.Close()
            getConnection.Close()
        Catch ex As MySqlException
            Debug.Write(ex.Message)
            getConnection.Close()
        End Try
    End Sub

    Public Sub obtenerTransportesDeSalida(dgv As DataGridView) 'Metodo para obtener transporte de salida'
        Try
            getConnection().Close()
            getConnection().Open()
            Dim command = New MySqlCommand("SELECT ID_Mascota, ID_Vehículo, FechaDEtransporte, Horario, Tipo FROM transporte WHERE Tipo='LL' and Estado='P';", getConnection())
            Dim reader = command.ExecuteReader
            dgv.Rows.Clear()

            While reader.Read
                dgv.Rows.Add(reader(0), reader(1), Date.Parse(reader(2)).ToString("yyyy/MM/dd"), reader(3))
            End While
            reader.Close()
            getConnection.Close()
        Catch ex As MySqlException
            Debug.Write(ex.Message)
            getConnection.Close()
        End Try
    End Sub

    Public Sub obtenerTransportesDeEntrada(dgv As DataGridView) 'Metodo para obtener transporte de entrada'
        Try
            getConnection().Close()
            getConnection().Open()
            Dim command = New MySqlCommand("SELECT ID_Mascota, ID_Vehículo, FechaDEtransporte, Horario, Tipo FROM transporte WHERE Tipo='T' and Estado='P';", getConnection())
            Dim reader = command.ExecuteReader
            dgv.Rows.Clear()
            While reader.Read
                dgv.Rows.Add(reader(0), reader(1), Date.Parse(reader(2)).ToString("yyyy/MM/dd"), reader(3))
            End While
            reader.Close()
            getConnection.Close()
        Catch ex As MySqlException
            Debug.Write(ex.Message)
            getConnection.Close()
        End Try
    End Sub

#End Region

#Region "Transporte"

    Public Function comprobarSiHayTransporte(estado As String, fecha As Date, vehiculo As Integer) 'Metodo para ver si hay transportes disponibles en cierta fecha'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("SELECT COUNT(Horario) FROM transporte where Horario='M' and FechaDEtransporte=@date and ID_Vehículo=@vehiculo", getConnection())
        command.Parameters.AddWithValue("@estado", estado)
        command.Parameters.AddWithValue("@vehiculo", vehiculo)
        command.Parameters.AddWithValue("@date", fecha.ToString("yyyy/MM/dd"))
        command.CommandType = CommandType.Text
        Dim reader = command.ExecuteReader
        If reader.Read Then
            If reader(0) < 3 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
        reader.Close()
        getConnection.Close()
    End Function

    Public Function eliminarTransporte(id As Integer) 'Metodo para dar de baja un transporte a partir del id'
        getConnection().Close()
        getConnection().Open()
        Try
            Dim command = New MySqlCommand("UPDATE transporte SET Estado='C' where ID_Mascota in (SELECT IDMascota from tiene where IDReserva=@id)", getConnection())
            command.Parameters.AddWithValue("@id", id)
            command.CommandType = CommandType.Text
            Return command.ExecuteNonQuery
            getConnection.Close()
        Catch ex As MySqlException
            Debug.Write(ex.Message)
            getConnection.Close()
            Return False
        End Try
    End Function

#End Region

#Region "ModificarPrecioHabitacion"

    Public Function getAllImages(type As String) 'Obtiene todas las imagenes de un tipo de habitacion'

        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("SELECT Imagen,Nombre_Tipo from descripción_tipo D join foto on IDTipoHabitacion = D.ID_TipoHabitación", getConnection())
        Dim reader = command.ExecuteReader
        Dim i = 0
        Dim imgPictures(6) As Image 'Empieza el Array con 6'
        If type.Equals("M") Then 'En caso de ser Mini Suite el tamaño del Aray cambia a 4'
            ReDim imgPictures(4)
        ElseIf type.Equals("E") Then 'En caso de ser Estandar el tamaño del Aray cambia a 3'
            ReDim imgPictures(3)
        End If
        While reader.Read 'Se almacena la imagen en el index correspondiente'
            If type.Equals("S") And reader(1).Equals("S") Then
                imgPictures(i) = ByteToStream(reader(0))
                i = i + 1
            ElseIf type.Equals("J") And reader(1).Equals("J") Then
                imgPictures(i) = ByteToStream(reader(0))
                i = i + 1
            ElseIf type.Equals("M") And reader(1).Equals("M") Then
                imgPictures(i) = ByteToStream(reader(0))
                i = i + 1
            ElseIf type.Equals("E") And reader(1).Equals("E") Then
                imgPictures(i) = ByteToStream(reader(0))
                i = i + 1
            End If
        End While
        Return imgPictures
        reader.Close()
        getConnection.Close()
    End Function

    Public Sub updateDataGridViewHabitacion(dgvHabitaciones As DataGridView) 'Metodo para actualizar un datagridview con los datos de las habitaciones'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("SELECT T.ID_TipoHabitación,Nombre_Tipo,CantidadDeMascotas,PrecioDia from tipo_habitación T join descripción_tipo D on T.ID_TipoHabitación=D.ID_TipoHabitación", getConnection())
        Dim reader = command.ExecuteReader
        dgvHabitaciones.Rows.Clear()
        While reader.Read
            dgvHabitaciones.Rows.Add("Click para ver", reader(0), reader(1), reader(2), reader(3))
        End While
        reader.Close()
        getConnection.Close()
    End Sub

    Public Function modificarHabitacion(id As Integer, precio As Integer, amount As Integer) 'Metodo para modificar una habitacion '
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("UPDATE tipo_habitación SET PrecioDia=@precio WHERE ID_TipoHabitación=@id and CantidadDeMascotas=@amount;", getConnection())
        command.Parameters.AddWithValue("@id", id)
        command.Parameters.AddWithValue("@amount", amount)
        command.Parameters.AddWithValue("@precio", precio)
        command.CommandType = CommandType.Text
        Try
            Return command.ExecuteNonQuery()
        Catch ex As MySqlException
            Debug.Write(ex.Message)
            getConnection.Close()
            Return False
        End Try
        getConnection().Close()
    End Function

#End Region

#Region "Medicamentos"

    Public Function checkIfExistMedicamento(name As String) 'Metodo para ver si un medicamento ya existe'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("SELECT Nombre_Medicamento from medicamento where Nombre_Medicamento=@name", getConnection())
        command.Parameters.AddWithValue("@name", name)
        command.CommandType = CommandType.Text
        Dim reader = command.ExecuteReader
        If reader.Read Then
            Return True
        Else
            Return False
        End If
        reader.Close()
        getConnection.Close()
    End Function

    Public Sub loadAllMedicamentos(medicamentos As Bunifu.Framework.UI.BunifuDropdown) 'Añade los medicamentos a una lista de medicamentos'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("SELECT * from medicamento", getConnection())
        Dim reader = command.ExecuteReader
        While reader.Read
            medicamentos.AddItem(reader(0).ToString + " " + reader(1).ToString)
        End While
        reader.Close()
        getConnection.Close()
    End Sub

    Public Function agregarMedicamento(nombre As String) 'Metodo para agregar medicamento a la bd'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("INSERT into `medicamento` (`Nombre_Medicamento`) values(@nombre);", getConnection())
        command.Parameters.AddWithValue("@nombre", nombre)
        command.CommandType = CommandType.Text
        Try
            Return command.ExecuteNonQuery()
        Catch ex As MySqlException
            Debug.Write(ex.Message)
            getConnection.Close()
            Return False
        End Try
        getConnection.Close()
    End Function

#End Region

#Region "Reserva"

    Public Sub filterByLastMonth(dgvReservas As DataGridView) 'Metodo para filtrar por ultimo mes'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("Select DISTINCT R.ID_Reserva, M.CICliente,R.Estado,R.CantidadDeMascotas,R.FechaYHoraRegistrada,R.FechaYHoraDesde,R.FechaYHoraHasta, R.MetodoDePago,R.WebCam,R.DogTV,R.CIEmpleado from reserva R join tiene T on R.ID_Reserva = T.IDReserva join mascota M on T.IDMascota = M.ID_Mascota where Estado = 'C' and month(FechaYHoraRegistrada) = month(now())", getConnection())
        Dim reader = command.ExecuteReader
        dgvReservas.Rows.Clear()
        While reader.Read
            dgvReservas.Rows.Add(reader(0), reader(1), reader(2), reader(3), Date.Parse(reader(4)).ToString("yyyy/MM/dd"), Date.Parse(reader(5)).ToString("yyyy/MM/dd"), Date.Parse(reader(6)).ToString("yyyy/MM/dd"), reader(7), reader(8), reader(9), reader(10))
        End While
        reader.Close()
        getConnection.Close()
    End Sub

    Public Sub filterByLastAlquiler(dgvReservas As DataGridView) 'Metodo para filtrar por fecha de alquier de mini suite'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("Select DISTINCT R.ID_Reserva, M.CICliente,R.Estado,R.CantidadDeMascotas,R.FechaYHoraRegistrada,R.FechaYHoraDesde,R.FechaYHoraHasta, R.MetodoDePago,R.WebCam,R.DogTV,R.CIEmpleado from reserva R join tiene T on R.ID_Reserva = T.IDReserva join mascota M on T.IDMascota = M.ID_Mascota join habitación H on T.IDHabitacion = H.ID_Habitación where Estado = 'C' and ID_TipoHabitación = 3", getConnection())
        Dim reader = command.ExecuteReader
        dgvReservas.Rows.Clear()
        While reader.Read
            dgvReservas.Rows.Add(reader(0), reader(1), reader(2), reader(3), Date.Parse(reader(4)).ToString("yyyy/MM/dd"), Date.Parse(reader(5)).ToString("yyyy/MM/dd"), Date.Parse(reader(6)).ToString("yyyy/MM/dd"), reader(7), reader(8), reader(9), reader(10))
        End While
        reader.Close()
        getConnection.Close()
    End Sub

    Public Sub searchReserva(txt As String, dgvReservas As DataGridView) 'Busca una reserva apartir de un texto ingresado'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("Select DISTINCT R.ID_Reserva, M.CICliente,R.Estado,R.CantidadDeMascotas,R.FechaYHoraRegistrada,R.FechaYHoraDesde,R.FechaYHoraHasta, R.MetodoDePago,R.WebCam,R.DogTV,R.CIEmpleado from reserva R join tiene T on R.ID_Reserva = T.IDReserva join mascota M on T.IDMascota = M.ID_Mascota where Estado = 'P' and M.CICliente LIKE '" + txt + "%' or R.CantidadDeMascotas LIKE '" + txt + "%' or R.FechaYHoraRegistrada LIKE '" + txt + "%' or R.MetodoDePago LIKE '" + txt + "%' or R.Estado LIKE '" + txt + "%';", getConnection())
        Dim reader = command.ExecuteReader
        dgvReservas.Rows.Clear()
        While reader.Read
            dgvReservas.Rows.Add(reader(0), reader(1), reader(2), reader(3), Date.Parse(reader(4)).ToString("yyyy/MM/dd"), Date.Parse(reader(5)).ToString("yyyy/MM/dd"), Date.Parse(reader(6)).ToString("yyyy/MM/dd"), reader(7), reader(8), reader(9), reader(10))
        End While
        reader.Close()
        getConnection.Close()
    End Sub

    Public Sub searchReservaConfirmada(txt As String, dgvReservas As DataGridView) 'Busca una reserva apartir de un texto ingresado'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("Select DISTINCT R.ID_Reserva, M.CICliente,R.Estado,R.CantidadDeMascotas,R.FechaYHoraRegistrada,R.FechaYHoraDesde,R.FechaYHoraHasta, R.MetodoDePago,R.WebCam,R.DogTV,R.CIEmpleado from reserva R join tiene T on R.ID_Reserva = T.IDReserva join mascota M on T.IDMascota = M.ID_Mascota where Estado = 'C' and M.CICliente LIKE '" + txt + "%' or R.CantidadDeMascotas LIKE '" + txt + "%' or R.FechaYHoraRegistrada LIKE '" + txt + "%' or R.MetodoDePago LIKE '" + txt + "%' or R.Estado LIKE '" + txt + "%';", getConnection())
        Dim reader = command.ExecuteReader
        dgvReservas.Rows.Clear()
        While reader.Read
            dgvReservas.Rows.Add(reader(0), reader(1), reader(2), reader(3), Date.Parse(reader(4)).ToString("yyyy/MM/dd"), Date.Parse(reader(5)).ToString("yyyy/MM/dd"), Date.Parse(reader(6)).ToString("yyyy/MM/dd"), reader(7), reader(8), reader(9), reader(10))
        End While
        reader.Close()
        getConnection.Close()
    End Sub

    Public Sub updateDataGridViewReserva(dgvReservas As DataGridView) 'Recarga las reservas en un datagridview'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("Select DISTINCT R.ID_Reserva, M.CICliente,R.Estado,R.CantidadDeMascotas,R.FechaYHoraRegistrada,R.FechaYHoraDesde,R.FechaYHoraHasta, R.MetodoDePago,R.WebCam,R.DogTV,R.CIEmpleado from reserva R join tiene T on R.ID_Reserva = T.IDReserva join mascota M on T.IDMascota = M.ID_Mascota where Estado = 'P'", getConnection())
        Dim reader = command.ExecuteReader
        dgvReservas.Rows.Clear()
        While reader.Read
            dgvReservas.Rows.Add(reader(0), reader(1), reader(2), reader(3), Date.Parse(reader(4)).ToString("yyyy/MM/dd"), Date.Parse(reader(5)).ToString("yyyy/MM/dd"), Date.Parse(reader(6)).ToString("yyyy/MM/dd"), reader(7), reader(8), reader(9), reader(10))
        End While
        reader.Close()
        getConnection.Close()
    End Sub

    Public Sub updateDataGridViewConfirmadas(dgvReservas As DataGridView) 'Recarga las reservas en un datagridview'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("Select DISTINCT R.ID_Reserva, M.CICliente,R.Estado,R.CantidadDeMascotas,R.FechaYHoraRegistrada,R.FechaYHoraDesde,R.FechaYHoraHasta, R.MetodoDePago,R.WebCam,R.DogTV,R.CIEmpleado from reserva R join tiene T on R.ID_Reserva = T.IDReserva join mascota M on T.IDMascota = M.ID_Mascota where Estado = 'C'", getConnection())
        Dim reader = command.ExecuteReader
        dgvReservas.Rows.Clear()
        While reader.Read
            dgvReservas.Rows.Add(reader(0), reader(1), reader(2), reader(3), Date.Parse(reader(4)).ToString("yyyy/MM/dd"), Date.Parse(reader(5)).ToString("yyyy/MM/dd"), Date.Parse(reader(6)).ToString("yyyy/MM/dd"), reader(7), reader(8), reader(9), reader(10))
        End While
        reader.Close()
        getConnection.Close()
    End Sub

    Public Sub cargarHabitaciones(type As Integer, habitaciones As Bunifu.Framework.UI.BunifuDropdown) 'Metodo para obtener todas las habitaciones de un tipo de habitacion'
        habitaciones.Clear()
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("SELECT H.ID_Habitación from habitación H where H.ID_TipoHabitación=@type AND ID_Habitación NOT IN (SELECT IDHabitacion from tiene T join reserva R on T.IDReserva = R.ID_Reserva where R.Estado='P' OR R.Estado='C')", getConnection())
        command.Parameters.AddWithValue("@type", type)
        command.CommandType = CommandType.Text
        Dim reader = command.ExecuteReader
        While reader.Read
            habitaciones.AddItem(reader(0).ToString)
        End While
        reader.Close()
        getConnection.Close()
    End Sub

    Public Function eliminarReserva(id As Integer) 'Metodo para dar de baja una reserva a partir del id'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("UPDATE reserva SET Estado='Ca' where ID_Reserva = @id", getConnection())
        command.Parameters.AddWithValue("@id", id)
        command.CommandType = CommandType.Text
        Return command.ExecuteNonQuery
        getConnection.Close()
    End Function

    Public Function editarReserva(id As Integer, metodo As String, hasta As Date, desde As Date) 'Metodo para editar una reserva
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("UPDATE reserva SET FechaYHoraDesde=@desde, FechaYHoraHasta=@hasta, MetodoDePago=@metodo WHERE ID_Reserva = @id;", getConnection())
        command.Parameters.AddWithValue("@id", id)
        command.Parameters.AddWithValue("@metodo", metodo)
        command.Parameters.AddWithValue("@hasta", hasta.ToString("yyyy/MM/dd"))
        command.Parameters.AddWithValue("@desde", desde.ToString("yyyy/MM/dd"))
        command.CommandType = CommandType.Text
        Return command.ExecuteNonQuery
        getConnection.Close()
    End Function

    Public Function confirmarReserva(id As Integer) 'Metodo para confirmar una reserva a partir de una ID'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("UPDATE reserva SET Estado='C' where ID_Reserva = @id", getConnection())
        command.Parameters.AddWithValue("@id", id)
        command.CommandType = CommandType.Text
        Return command.ExecuteNonQuery
        getConnection.Close()
    End Function

#End Region

#Region "Clientes"

    Public Sub loadClientes(clientes As Bunifu.Framework.UI.BunifuDropdown) 'Añade los clientes a una lista de clientes'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("SELECT C.CICliente,P.Nombre,P.Apellido from persona P join cliente C on P.CI = C.CICliente", getConnection())
        Dim reader = command.ExecuteReader
        clientes.Clear()

        While reader.Read
            clientes.AddItem(reader(0).ToString + " " + reader(1).ToString + " " + reader(2).ToString)
        End While
        reader.Close()
        getConnection.Close()
    End Sub

    Public Function agregarCliente(ci As Integer, nombre As String, apellido As String, direccion As String, telefono As Integer, fechaNac As Date) 'Metodo para agregar clientes'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("INSERT into persona values(@ci, @nombre, @apellido, @fechaNac, @direccion, @telefono); INSERT into cliente values(@ci);", getConnection())
        command.Parameters.AddWithValue("@ci", ci)
        command.Parameters.AddWithValue("@nombre", nombre)
        command.Parameters.AddWithValue("@apellido", apellido)
        command.Parameters.AddWithValue("@direccion", direccion)
        command.Parameters.AddWithValue("@telefono", telefono)
        command.Parameters.AddWithValue("@fechaNac", fechaNac)
        command.CommandType = CommandType.Text
        Try
            Return command.ExecuteNonQuery()
        Catch ex As MySqlException
            Debug.Write(ex.Message)
            getConnection.Close()
            Return False
        End Try
        getConnection.Close()
    End Function

    Public Function modificarCliente(ci As Integer, nombre As String, apellido As String, direccion As String, telefono As Integer, fechaNac As Date) 'Metodo para modificar un cliente '
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("UPDATE persona SET Nombre= @nombre, Apellido = @apellido, FechaNac= @fechanac, Direccion= @direccion, Telefono= @telefono WHERE CI = @ci;", getConnection())
        command.Parameters.AddWithValue("@ci", ci)
        command.Parameters.AddWithValue("@nombre", nombre)
        command.Parameters.AddWithValue("@apellido", apellido)
        command.Parameters.AddWithValue("@fechanac", Date.Parse(fechaNac))
        command.Parameters.AddWithValue("@direccion", direccion)
        command.Parameters.AddWithValue("@telefono", telefono)
        command.CommandType = CommandType.Text
        Try
            Return command.ExecuteNonQuery()
        Catch ex As MySqlException
            Debug.Write(ex.Message)
            getConnection.Close()
            Return False
        End Try
        getConnection().Close()
    End Function

    Public Function eliminarCliente(ci As String) 'Metodo para eliminar un cliente apartir de su cedula'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("DELETE from cliente where CICliente=@ci; DELETE from persona where CI=@ci;", getConnection())
        command.Parameters.AddWithValue("@ci", ci)
        command.CommandType = CommandType.Text
        Try
            Return command.ExecuteNonQuery()
        Catch ex As MySqlException
            Debug.Write(ex.Message)
            getConnection.Close()
            Return False
        End Try
        getConnection().Close()
    End Function

    Public Sub searchCliente(txt As String, dgvClientes As DataGridView) 'Busca un cliente apartir de un texto ingresado'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("SELECT C.CICliente,P.Nombre,P.Apellido,P.FechaNac,P.Direccion,P.Telefono from persona P join cliente C on P.CI = C.CICliente where Nombre LIKE '" + txt + "%' or Apellido LIKE '" + txt + "%' or CICliente LIKE '" + txt + "%'", getConnection())
        Dim reader = command.ExecuteReader
        dgvClientes.Rows.Clear()
        While reader.Read
            dgvClientes.Rows.Add(reader(0), reader(1), reader(2), reader(4), reader(5), Date.Parse(reader(3)).ToString("yyyy-MM-dd"))
        End While
        reader.Close()
        getConnection.Close()
    End Sub

    Public Sub updateDataGridViewCliente(dgvClientes As DataGridView) 'Recarga los clientes en un datagridview'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("SELECT C.CICliente,P.Nombre,P.Apellido,P.FechaNac,P.Direccion,P.Telefono from persona P join cliente C on P.CI = C.CICliente", getConnection())
        Dim reader = command.ExecuteReader
        dgvClientes.Rows.Clear()
        While reader.Read
            dgvClientes.Rows.Add(reader(0), reader(1), reader(2), reader(4), reader(5), Date.Parse(reader(3)).ToString("yyyy-MM-dd"))
        End While
        reader.Close()
        getConnection.Close()
    End Sub

#End Region

#Region "General"

    Public Function loadAllData(id As Integer) As String() 'Metodo para obtener todos los datos de la reserva'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("Select DISTINCT R.CantidadDeMascotas,R.FechaYHoraRegistrada,R.MetodoDePago,R.WebCam,R.DogTV,H.ID_Habitación,TI.ID_TipoHabitación,C.CICliente,P.Nombre,P.Apellido,P.Direccion,P.Telefono FROM persona P Join cliente C ON P.CI = C.CICliente Join mascota M ON M.CICliente = C.CICliente Join tiene T ON T.IDMascota = M.ID_Mascota Join reserva R ON R.ID_Reserva = T.IDReserva Join habitación H ON H.ID_Habitación = T.IDHabitacion Join tipo_habitación TI on TI.ID_TipoHabitación = H.ID_TipoHabitación WHERE T.IDReserva =@id", getConnection())
        command.Parameters.AddWithValue("@id", id)
        command.CommandType = CommandType.Text
        Dim reader = command.ExecuteReader
        Dim array(11) As String
        If reader.Read Then
            array(0) = reader(0)
            array(1) = reader(1)
            array(2) = reader(2)
            array(3) = reader(3)
            array(4) = reader(4)
            array(5) = reader(5)
            array(6) = reader(6)
            array(7) = reader(7)
            array(8) = reader(8)
            array(9) = reader(9)
            array(10) = reader(10)
            array(11) = reader(11)
            Return array
        Else
            Return array
        End If
        reader.Close()
        getConnection.Close()
    End Function

    Public Function getDays(id As Integer) As Integer 'Obtiene todos los dias de una id'

        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("SELECT datediff(R.FechaYHoraHasta, R.FechaYHoraDesde) as Precio from reserva R where R.ID_Reserva=@id;", getConnection())
        command.Parameters.AddWithValue("@id", id)
        command.CommandType = CommandType.Text
        Dim reader = command.ExecuteReader()
        If reader.Read Then
            Return reader(0)
        Else
            Return 0
        End If
        reader.Close()
        getConnection.Close()
    End Function

    Public Function getPrice(tipo As Integer, cantidad As Integer) As Integer 'Obtiene el precio de un tipo y cierta cantidad de mascotas'

        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("SELECT PrecioDia FROM tipo_habitación where ID_TipoHabitación=@tipoamount and CantidadDeMascotas=@cantidad;", getConnection())
        command.Parameters.AddWithValue("@tipoamount", tipo)
        command.Parameters.AddWithValue("@cantidad", cantidad)
        command.CommandType = CommandType.Text
        Dim reader = command.ExecuteReader()
        If reader.Read Then
            Return reader(0)
        Else
            Return 0
        End If
        reader.Close()
        getConnection.Close()
    End Function

    Public Function getIncrementalMascotaNumber() As Integer 'Obtiene el numero incremental de mascota'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("Select ID_Mascota from mascota order by ID_Mascota DESC", getConnection())
        Dim reader = command.ExecuteReader()
        If reader.Read Then
            Return reader(0)
        Else
            Return 0
        End If
        reader.Close()
        getConnection.Close()
    End Function

    Public Sub checkIFReservaExpired() 'Mira si la reserva ya expiro y actualiza su estado'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("UPDATE reserva SET Estado= CASE WHEN Estado='P' and DATEDIFF(NOW(), FechaYHoraRegistrada) >= 1 THEN 'Ca' ELSE Estado END;", getConnection())
        command.ExecuteNonQuery()
        getConnection.Close()
    End Sub

    Public Sub checkIFReservaTerminated() 'Mira si la reserva ya termino y actualiza su estado'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("UPDATE reserva SET Estado= CASE WHEN Estado='C' and DATEDIFF(NOW(), FechaYHoraHasta) >= 0 THEN 'T' ELSE Estado END;", getConnection())
        command.ExecuteNonQuery()
        getConnection.Close()
    End Sub

    Public Sub checkIFTransporteLLTerminated() 'Mira si el transporte ya termino y actualiza su estado'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("UPDATE transporte SET Estado= CASE WHEN Estado='C' and Tipo='LL' and NOW() >= FechaDEtransporte THEN 'F' ELSE Estado END;", getConnection())
        command.ExecuteNonQuery()
        getConnection.Close()
    End Sub

    Public Sub checkIFTransporteTTerminated() 'Mira si el transporte ya termino y actualiza su estado'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("UPDATE transporte SET Estado= CASE WHEN Estado='C' and Tipo='T' and NOW() >= FechaDEtransporte THEN 'F' ELSE Estado END;", getConnection())
        command.ExecuteNonQuery()
        getConnection.Close()
    End Sub

    Public Function getIncrementalReservaNumber() As Integer 'Obtiene el numero incremental de reserva'

        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("Select ID_Reserva from reserva order by ID_Reserva DESC", getConnection())
        Dim reader = command.ExecuteReader()
        If reader.Read Then
            Return reader(0)
        Else
            Return 0
        End If
        reader.Close()
        getConnection.Close()
    End Function

    Public Function obtenerNombreApellido(ci As String) 'Obtiene el nombre y apellido apartir de una cedula'
        getConnection().Close()
        getConnection().Open()
        Dim command = New MySqlCommand("SELECT P.nombre, P.apellido from persona P join empleado E on P.CI = E.CIEmpleado where E.CIEmpleado=@ci", getConnection())
        command.Parameters.AddWithValue("@ci", ci)
        command.CommandType = CommandType.Text
        Dim reader = command.ExecuteReader()
        If reader.Read Then
            Return reader(0) + " " + reader(1)
            reader.Close()
            getConnection.Close()
        Else
            reader.Close()
            getConnection.Close()
            Return "Employee Name"
        End If
    End Function

    Public Function saveImage(ci As String, image As Image) 'Metodo para guardar la imagen de un cliente'
        getConnection().Close()
        getConnection().Open()
        Try
            Dim command = New MySqlCommand("UPDATE `empleado` SET `ImagenEmpleado`=@image WHERE (`CIEmpleado`=@ci);", getConnection())
            command.Parameters.AddWithValue("@ci", ci)
            command.Parameters.AddWithValue("@image", ImageToByte(image))
            command.CommandType = CommandType.Text
            command.ExecuteNonQuery()
            FormSucess.callFormWithMessage("Imagen Cambiada!")
            getConnection().Close()
            Return True
        Catch sql As MySqlException
            getConnection().Close()
            FormInfo.callFormWithMessage("La imagen es muy grande!")
            Return False
        End Try
    End Function

#End Region

#Region "Login"

    Public Function login(username As TextBox, password As TextBox) 'Funcion Login'
        checkIFReservaExpired()
        checkIFReservaTerminated()
        checkIFTransporteLLTerminated()
        checkIFTransporteTTerminated()
        getConnection().Open()
        Dim command = New MySqlCommand("SELECT * from empleado where Usuario=@user", getConnection())
        command.Parameters.AddWithValue("@user", username.Text)
        command.CommandType = CommandType.Text

        Dim reader = command.ExecuteReader()
        If reader.Read Then
            If reader("Usuario").Equals(username.Text) And reader("Contrasena").Equals(password.Text) Then
                Dim general As General = New General
                CILogged = reader("CIEmpleado")
                If reader("RolPrograma").Equals("G") Then
                    username.Text = ""
                    password.Text = ""
                    general.Show()
                    If Not IsDBNull(reader("ImagenEmpleado")) Then
                        Dim bytes As Byte() = reader("ImagenEmpleado")
                        Dim stream As MemoryStream = New MemoryStream(bytes)
                        general.picture.Image = Image.FromStream(stream)
                    End If
                    general.txtNombreUsuario.Text = obtenerNombreApellido(reader("CIEmpleado").ToString())
                ElseIf reader("RolPrograma").Equals("O") Then
                    username.Text = ""
                    password.Text = ""
                    general.btnModificarPrecio.Visible = False
                    general.btnReservas.Visible = False
                    general.btnModificarPrecio.Enabled = False
                    general.btnReservas.Enabled = False
                    general.btnHEntrada.Visible = False
                    general.btnHSalida.Visible = False
                    general.btnHEntrada.Enabled = False
                    general.btnHSalida.Enabled = False
                    general.Show()
                    If Not IsDBNull(reader("ImagenEmpleado")) Then
                        Dim bytes As Byte() = reader("ImagenEmpleado")
                        Dim stream As MemoryStream = New MemoryStream(bytes)
                        general.picture.Image = Image.FromStream(stream)
                    End If
                    general.txtNombreUsuario.Text = obtenerNombreApellido(reader(0))
                ElseIf reader("RolPrograma").Equals("R") Then
                    username.Text = ""
                    password.Text = ""
                    general.btnModificarPrecio.Visible = False
                    general.btnModificarPrecio.Enabled = False
                    general.btnGestion.Visible = False
                    general.gestionClientes.Visible = False
                    general.gestionClientes.Enabled = False
                    general.btnGestion.Enabled = False
                    general.Show()
                    If Not IsDBNull(reader("ImagenEmpleado")) Then
                        Dim bytes As Byte() = reader("ImagenEmpleado")
                        Dim stream As MemoryStream = New MemoryStream(bytes)
                        general.picture.Image = Image.FromStream(stream)
                    End If
                    general.txtNombreUsuario.Text = obtenerNombreApellido(reader(0))
                Else
                    FormInfo.callFormWithMessage("Tu Rol es incorrecto o no existe")
                    reader.Close()
                End If
                Return True
                getConnection().Close()
            Else
                username.Text = ""
                password.Text = ""
                FormInfo.callFormWithMessage("Usuario o contraseña incorrectos")
                reader.Close()
                getConnection().Close()
                Return False
            End If
        Else
            password.Text = ""
            FormInfo.callFormWithMessage("Esta cuenta no existe!")
            reader.Close()
            getConnection().Close()
            Return False
        End If
    End Function

#End Region

End Class
