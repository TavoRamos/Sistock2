Public Class Persona
    Public Property IdPersona As UInteger
    Public Property Nombre As String
    Public Property NombreComercial As String
    Public Property Telefono As String
    Public Property Email As String
    'Public Property Direccion As Direccion

    Public Sub New(ByRef nombre As String, ByRef Optional nombre_comercial As String = Nothing, ByRef Optional telefono As String = Nothing, ByRef Optional email As String = Nothing, ByRef Optional id_persona As UInteger = Nothing)
        nombre = nombre
        If IsNothing(nombre_comercial) Then
            NombreComercial = nombre
        Else
            NombreComercial = nombre_comercial
        End If
        Me.Telefono = telefono
        Me.Email = email
        IdPersona = id_persona
    End Sub
End Class
