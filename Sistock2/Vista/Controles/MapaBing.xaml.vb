Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports Microsoft.Maps.MapControl.WPF
Imports System.Xml
Imports System.Net
Public Class MapaBing
    'Sistock2
    'Private ClaveAPI As String = "AkVK7t9ikSMg_tiqwXjzlk-KfDBAq3OCxjMYLMqhxdybHcUhBdewy1fxFPTsaFei"
    'MetalControl
    'Private ClaveAPI As String = "ApO6yYNKWRj9gvJvppe_JEfGU530U3smR4IOw0qHU8PVlHHIFVqVlSTIsUBMHQ-a"
    'Prueba
    Private ClaveAPI As String = "Ap0BLqYOqiQLn_hrgFGG7L76X8dXhnh6yPyue73nHRx9xA-HMc_WzO34b-YS--GX"
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub Localizar(ByVal Direccion As String, ByVal Localidad As String, ByVal Provincia As String, ByVal Optional Pais As String = "Argentina")
        Dim tb As New TextBlock()
        Dim respuesta As New XmlDocument
        Dim consulta As String = "http://dev.virtualearth.net/REST/v1/Locations?q=" + Direccion + ", " + Localidad + ", " + Provincia + ", " + Pais + "&c=es" + "&output=xml" + "&key=" + ClaveAPI

        System.Diagnostics.Trace.WriteLine("Request URL (XML): " & consulta)
        Dim request As HttpWebRequest = TryCast(WebRequest.Create(consulta), HttpWebRequest)
        Using response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
            If response.StatusCode <> HttpStatusCode.OK Then
                Throw New Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription))
            End If
            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load(response.GetResponseStream())
            'Dim nodo As XmlElement = xmlDoc.SelectSingleNode("/Response/ResourceSets/ResourceSet[1]/Resources/Location/GeocodePoint[1]/Latitude")
            'nodo = xmlDoc.SelectSingleNode("//Response/ResourceSets[1]/ResourceSet/Resources/Location/Point/Longitude")
            If Integer.Parse(xmlDoc.GetElementsByTagName("EstimatedTotal").Item(0).InnerText) = 0 Then
                tb.Foreground = New SolidColorBrush(Color.FromArgb(255, 128, 255, 128))
                tb.Width = Me.Mapa.Width - 10
                tb.Height = Me.Mapa.Height - 10
                tb.Background = New SolidColorBrush(Color.FromArgb(50, 100, 0, 255))
                tb.Margin = New Thickness(5)
                tb.TextAlignment = TextAlignment.Center
                tb.VerticalAlignment = Windows.VerticalAlignment.Center

                tb.FontSize = 15
                tb.Text = "Sin datos de ubicación" + vbCrLf + "(o sin sin conexión)"
                Me.Mapa.Children.Clear()
                Me.Mapa.Children.Add(tb)
                Return
            Else
                Me.Mapa.Children.Clear()
            End If
            Dim longitud As String = xmlDoc.GetElementsByTagName("GeocodePoint").Item(0).ChildNodes.Item(1).InnerText
            Dim latitud As String = xmlDoc.GetElementsByTagName("GeocodePoint").Item(0).ChildNodes.Item(0).InnerText
            'My.Settings.CantPedidosMapa += 1
            ' book = root.SelectSingleNode("descendant::book[title=""'Emma'""]")
            Dim ubicacion As New Location(Double.Parse(latitud), Double.Parse(longitud))
            Dim marcador As New Pushpin
            marcador.Location = ubicacion
            'Me.Mapa.Children.Clear()
            Me.Mapa.Children.Add(marcador)
            Me.Mapa.Mode = New AerialMode
            Me.Mapa.SetView(ubicacion, 4)

            tb.Foreground = New SolidColorBrush(Color.FromArgb(255, 128, 255, 128))
            tb.Width = Me.Mapa.Width - 10
            tb.Height = Me.Mapa.Height - 10
            tb.Background = New SolidColorBrush(Color.FromArgb(50, 100, 0, 255))
            tb.Margin = New Thickness(5)
            tb.TextAlignment = TextAlignment.Center
            tb.VerticalAlignment = Windows.VerticalAlignment.Center

            tb.FontSize = 15
            tb.Text = ubicacion.ToString
            Me.Mapa.Children.Clear()
            Me.Mapa.Children.Add(tb)
            'DLGMapa.TXTLat.Text = marcador.Location.Latitude.ToString
            'DLGMapa.TXTLong.Text = marcador.Location.Longitude.ToString
        End Using
    End Sub
End Class
