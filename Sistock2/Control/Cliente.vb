Public Class Cliente
    Inherits Persona

    Public Property TipoDeDocumento As Byte
    Public Property NumeroDeDocumento As ULong
    Public Property TipoContribuyente As Byte
    Public Property SituacionIIBB As Byte
    Public Property CodIIBB As ULong
    Public Property CondicionDeVenta As Byte
    Public Property LimiteDeCredito As Decimal
    Public Property Bonificacion As UInteger
    Public Property Activo As Boolean

    Public Sub New(ByRef tipo_de_documento As Byte, ByRef numero_de_documento As ULong, ByRef tipo_contribuyente As Byte, ByRef nombre As String,
                   ByRef Optional cod_iibb As ULong = Nothing, Optional ByRef situacion_iibb As Byte = 2, ByRef Optional nombre_comercial As String = Nothing,
                   ByRef Optional telefono As String = Nothing, ByRef Optional condicion_de_venta As Byte = 0, ByRef Optional limite_de_credito As Decimal = 0,
                   ByRef Optional email As String = Nothing, ByRef Optional id_persona As UInteger = Nothing, ByRef Optional bonificacion As UInteger = 0,
                   ByRef Optional activo As Boolean = True)

        MyBase.New(nombre, nombre_comercial, telefono, email, id_persona)
        TipoDeDocumento = tipo_de_documento
        NumeroDeDocumento = numero_de_documento
        TipoContribuyente = tipo_contribuyente
        SituacionIIBB = situacion_iibb
        If situacion_iibb = 2 Then
            CodIIBB = Nothing
        Else
            CodIIBB = cod_iibb
        End If
        CondicionDeVenta = condicion_de_venta
            LimiteDeCredito = limite_de_credito
            Me.Bonificacion = bonificacion
            Me.Activo = activo

    End Sub
End Class
