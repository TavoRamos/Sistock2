Public Class Principal
#Region "Reloj"
    Private Sub reloj()
        timer_tick()
        Dim fecha As Date = TimeOfDay
        LBLReloj.Text = fecha.Hour.ToString + ":" + fecha.Minute.ToString
        Dim timer As New Timer
        AddHandler timer.Tick, AddressOf timer_tick
        timer.Interval = 1000 * 30
        timer.Enabled = True
        timer.Start()
    End Sub
    Public Sub timer_tick()
        Dim fecha As Date = TimeOfDay
        LBLReloj.Text = fecha.Hour.ToString + ":" + fecha.Minute.ToString
    End Sub
#End Region
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        reloj()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        ClientesProveedores.Show()
    End Sub
    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        Configuracion.Show()
    End Sub
End Class