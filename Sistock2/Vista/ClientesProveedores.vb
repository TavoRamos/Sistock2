Imports System.Windows.Controls
Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Public Class ClientesProveedores
    Private Sub IniciarMapa()
        GmapClienteProveedor.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance
        GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache
    End Sub
    Private Sub ClientesProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.MdiParent = Principal
        Dim CargarMapa As New Threading.Thread(AddressOf IniciarMapa)
        CargarMapa.Start()
        Dim imageFile As Bitmap
        GmapClienteProveedor.SetPositionByKeywords("Argentina")
        Dim a = New Random
        For i As Integer = 0 To 50
            Select Case a.Next(7)
                Case 0
                    imageFile = New Bitmap("C:\Users\Tavo\Octavio\2 - Proyectos (Programación)\1 - Sistock\2\Etiqueta_exento.png")
                Case 1
                    imageFile = New Bitmap("C:\Users\Tavo\Octavio\2 - Proyectos (Programación)\1 - Sistock\2\Etiqueta_cFinal.png")
                Case 2
                    imageFile = New Bitmap("C:\Users\Tavo\Octavio\2 - Proyectos (Programación)\1 - Sistock\2\Etiqueta_Eventual.png")
                Case 3
                    imageFile = New Bitmap("C:\Users\Tavo\Octavio\2 - Proyectos (Programación)\1 - Sistock\2\Etiqueta_monotributista.png")
                Case 4
                    imageFile = New Bitmap("C:\Users\Tavo\Octavio\2 - Proyectos (Programación)\1 - Sistock\2\Etiqueta_noCategorizadol.png")
                Case 5
                    imageFile = New Bitmap("C:\Users\Tavo\Octavio\2 - Proyectos (Programación)\1 - Sistock\2\Etiqueta_noReponsable.png")
                Case 6
                    imageFile = New Bitmap("C:\Users\Tavo\Octavio\2 - Proyectos (Programación)\1 - Sistock\2\Etiqueta_provExt.png")
                Case 7
                    imageFile = New Bitmap("C:\Users\Tavo\Octavio\2 - Proyectos (Programación)\1 - Sistock\2\Etiqueta_responsableInscripto.png")
                Case Else
                    imageFile = New Bitmap("C:\Users\Tavo\Octavio\2 - Proyectos (Programación)\1 - Sistock\2\Etiqueta_monotributista.png")
            End Select

            Dim linea As New DataGridViewRow
            Dim celda1 As New DataGridViewImageCell
            Dim celda2 As New DataGridViewTextBoxCell
            linea.Height = 30
            celda1.Value = imageFile
            celda2.Value = "Octavio G. Ramos - " + i.ToString
            linea.Cells.Add(celda1)
            linea.Cells.Add(celda2)
            DGVClientes.Rows.Add(linea)
        Next
    End Sub
    Private Sub BuscarUbicacion(sender As Object, e As EventArgs) Handles TXTDireccion.LostFocus, CBProvincia.SelectedIndexChanged, CBLocalidad.SelectedIndexChanged
        GmapClienteProveedor.Overlays.Clear()
        Dim MarkerOverlay = New GMapOverlay("markers")
        Dim Direccion As String = ""
        Dim Localidad As String = ""
        Dim Provincia As String = ""
        If Not String.IsNullOrWhiteSpace(TXTDireccion.Text) And TXTDireccion.Text <> TXTDireccion.OriText Then
            Direccion = TXTDireccion.Text + ", "
        End If
        If Not IsNothing(CBLocalidad.SelectedItem) Then
            Localidad = CBLocalidad.SelectedItem.ToString + ", "
        End If
        If Not IsNothing(CBProvincia.SelectedItem) Then
            Provincia = CBProvincia.SelectedItem.ToString + ", "
        End If
        GmapClienteProveedor.SetPositionByKeywords(Direccion + Localidad + Provincia + "Argentina")
        Dim Marcador = New GMarkerGoogle(New PointLatLng(GmapClienteProveedor.Position.Lat, GmapClienteProveedor.Position.Lng), GMarkerGoogleType.blue_dot)
        MarkerOverlay.Markers.Add(Marcador)
        GmapClienteProveedor.Overlays.Add(MarkerOverlay)
        GmapClienteProveedor.Zoom = 16
    End Sub
    Private Sub BTNCerrar_Click(sender As Object, e As EventArgs) Handles BTNCerrar.Click
        Dispose()
    End Sub

    Private Sub DGVClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellContentClick
        If e.ColumnIndex = 1 Then
            Select Case DGVClientes.Item(0, e.RowIndex).Value.ToString
                Case "Responsable Inscripto"
                    Dim a As New TextBlock()
                    a.TextAlignment = Windows.TextAlignment.Center

                    'Cliente del exterior
                    'Consumidor Final
                    'Eventual
                    'Exento
                    'Monotributista
                    'No categorizado
                    'No responsable
                    'Proveedor del exterior
                    'Responsable inscripto

            End Select
        End If
    End Sub
    Private Sub SplitContainer1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SplitContainer1.MouseDoubleClick, BTNSlider.Click
        If SplitContainer1.Panel1.Width < DGVClientes.Columns().GetColumnsWidth(DataGridViewElementStates.Visible) + 15 Then
            SplitContainer1.SplitterDistance = DGVClientes.Columns().GetColumnsWidth(DataGridViewElementStates.Visible) + 15
            BTNSlider.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        Else
            SplitContainer1.SplitterDistance = 238
            BTNSlider.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        End If
    End Sub
    Private Sub BTNSlider_MouseLeave(sender As Object, e As EventArgs) Handles BTNSlider.MouseLeave
        BTNSlider.Location = New Point(-12, 202)
    End Sub
    Private Sub BTNSlider_MouseEnter(sender As Object, e As EventArgs) Handles BTNSlider.MouseEnter
        BTNSlider.Location = New Point(-5, 202)
    End Sub
End Class