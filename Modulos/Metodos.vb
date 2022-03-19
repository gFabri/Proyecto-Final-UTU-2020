Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text.RegularExpressions

Module Metodos

    Public Function validarContraseña(txtValidarContraseña As TextBox) As Boolean 'Metodo para validar la contraseña'
        Dim validador As New Regex("^\d{8,}$")

        If txtValidarContraseña.Text.Trim = "" Then
            FormInfo.callFormWithMessage("El campo para la contraseña no puede estar vacío")
            Return False
        ElseIf Not validador.IsMatch(txtValidarContraseña.Text) Then
            FormInfo.callFormWithMessage("El formato de la contraseña debe de ser solo numérico y tiene que tener un mínimo de 8 carácteres")
            txtValidarContraseña.Text = ""
            Return False
        Else
            Return True
        End If
    End Function

    Public Function validarNumeroTelefono(txtValidarTelefono As Object) As Boolean  'Metodo para validar el numero de telefono'
        Dim validador As New Regex("^\d{8}$")

        If txtValidarTelefono.Text.Trim = "" Then
            FormInfo.callFormWithMessage("El campo númerico no puede estar vacío")
            Return False
        ElseIf Not validador.IsMatch(txtValidarTelefono.Text) Then
            FormInfo.callFormWithMessage("El formato debe de ser solo numérico y tiene que tener estrictamente 8 carácteres")
            txtValidarTelefono.Text = ""
            Return False
        Else
            Return True
        End If
    End Function

    Public Function validarCedula(txtValidar As Object) As Boolean  'Metodo para validar la cedula'
        Dim validador As New Regex("^\d{8}$")

        If txtValidar.Text.Trim = "" Then
            FormInfo.callFormWithMessage("El campo númerico no puede estar vacío")
            Return False
        ElseIf Not validador.IsMatch(txtValidar.Text) Then
            FormInfo.callFormWithMessage("El formato debe de ser solo numérico y tiene que tener estrictamente 8 carácteres")
            txtValidar.Text = ""
            Return False
        Else
            Return True
        End If
    End Function

    Public Function validarTexto(txtValidarTexto As Object) As Boolean  'Metodo para validar texto'
        Dim validador As New Regex("^[a-zA-Z]{1,}$")
        If txtValidarTexto.Text.Trim = "" Then

            FormInfo.callFormWithMessage("El campo de texto no puede estar vacío")
            Return False
        ElseIf Not validador.IsMatch(txtValidarTexto.Text) Then
            FormInfo.callFormWithMessage("El campo de texto solo debe de tener letras")
            txtValidarTexto.Text = ""
            Return False
        Else
            Return True
        End If
    End Function

    Public Function validarEspacio(txtvalidarEspacio As Object) As Boolean  'Metodo para validar espacios'
        If txtvalidarEspacio.Text.Trim = "" Then
            FormInfo.callFormWithMessage("El campo de texto no puede estar vacío")
            Return False
        Else
            Return True
        End If
    End Function


    Public Function validarNumero(txtValidarNumero As Object) As Boolean  'Metodo para validar numero'
        Dim validador As New Regex("^\d{1,}$")

        If txtValidarNumero.Text.Trim = "" Then
            FormInfo.callFormWithMessage("El campo no puede estar vacío")
            Return False
        ElseIf Not validador.IsMatch(txtValidarNumero.Text) Then
            FormInfo.callFormWithMessage("El formato debe de ser solo numérico")
            txtValidarNumero.Text = ""
            Return False
        Else
            Return True
        End If
    End Function

    Public Function validarHoras(txtValidarNumero As Object) As Boolean  'Metodo para validar horas'
        Dim validador As New Regex("^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$")

        If txtValidarNumero.Text.Trim = "" Then
            FormInfo.callFormWithMessage("El campo no puede estar vacío")
            Return False
        ElseIf Not validador.IsMatch(txtValidarNumero.Text) Then
            FormInfo.callFormWithMessage("El formato debe de ser solo tipo horario")
            txtValidarNumero.Text = ""
            Return False
        Else
            Return True
        End If
    End Function

    Public Function ImageToByte(img As Image)  'Metodo para transformar una imagen a bytes'

        Dim result As Byte()
        Dim memoryStream As MemoryStream = New MemoryStream

        img.Save(memoryStream, ImageFormat.Png)
        result = memoryStream.ToArray()

        Return result
    End Function

    Public Function ByteToStream(bytes As Byte())  'Metodo para transformar bytes a imagen'
        Dim stream As MemoryStream = New MemoryStream(bytes)
        Return Image.FromStream(stream)
    End Function

End Module