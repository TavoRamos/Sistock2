Public Class Login

    Private Sub Login_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TimerFin.Enabled = True
            TimerFin.Start()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(305, 0)
        'Dim TXTUsuario As New TextBoxTransparente
        'TXTUsuario.Location = New System.Drawing.Point(72, 250)
        'Me.Controls.Add(TXTUsuario)
        OvalShape1.Size = New System.Drawing.Size(0, 0)
        TimerFin.Enabled = False
        TimerFin.Stop()
    End Sub
    Private Sub TimerInicio_Tick(sender As Object, e As EventArgs) Handles TimerInicio.Tick
        If Me.Opacity < 1 Then
            Opacity += 0.04
            If Me.Height < 500 Then
                Height += 50
            End If
        Else
            TimerInicio.Stop()
        End If
    End Sub

    Private Sub TimerFin_Tick(sender As Object, e As EventArgs) Handles TimerFin.Tick
        If OvalShape1.Height < 1300 Then
            OvalShape1.Height += 150
            OvalShape1.Width += 150
            OvalShape1.Top -= 75
            OvalShape1.Left -= 75
        End If
        If Opacity > 0 Then
            Opacity -= 0.03
        Else
            TimerFin.Stop()
            Configuracion.Show()
            'Me.Close()
        End If
    End Sub
    Private Sub TXTUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTUsuario.KeyPress, TXTContrasenia.KeyPress
        If sender.Equals(TXTUsuario) And String.IsNullOrWhiteSpace(TXTContrasenia.Text) and e.KeyChar = ChrW(Keys.Enter) Then
            TXTContrasenia.Focus()
        Else
            If e.KeyChar = ChrW(Keys.Enter) Then
                TimerFin.Enabled = True
                TimerFin.Start()
            End If
        End If
    End Sub
End Class