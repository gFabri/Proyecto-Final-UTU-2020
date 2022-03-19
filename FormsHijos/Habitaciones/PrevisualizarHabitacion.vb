Public Class PrevisualizarHabitacion

    Dim types

    Public Sub applyImage(type As String)
        types = type
        Dim datos = New Datos
        Dim imgPictures() As Image
        imgPictures = datos.getAllImages(types)
        picture.Image = imgPictures(0)
    End Sub

    Private Sub gerenteSalir_Click(sender As Object, e As EventArgs) Handles gerenteSalir.Click
        Close()
    End Sub

    Dim i = 0

    Private Sub right_Click(sender As Object, e As EventArgs) Handles rightImage.Click
        Dim datos = New Datos
        Dim imgPictures() As Image
        imgPictures = datos.getAllImages(types)
        If i = imgPictures.Length - 2 Then
            i = 0
            picture.Image = imgPictures(i)
            Return
        End If
        i = i + 1
        picture.Image = imgPictures(i)
    End Sub

    Private Sub left_Click(sender As Object, e As EventArgs)
        Dim datos = New Datos
        Dim imgPictures() As Image
        imgPictures = datos.getAllImages(types)
        If i <= 0 Then
            i = 0
            picture.Image = imgPictures(i)
            Return
        End If
        i = i - 1
        picture.Image = imgPictures(i)
    End Sub

End Class