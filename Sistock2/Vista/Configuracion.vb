Imports System.Data.SqlClient

Public Class Configuracion
    Private Sub BTNConfiguracionSistema_Click(sender As Object, e As EventArgs) Handles BTNConfiguracionSistema.Click, BTNConfiguracionPredeterminadas.Click
        LBLConfiguracion.Visible = True
        LBLConfiguracion.Text = sender.Text
        For Each BTN As SButton In Me.Controls.OfType(Of SButton)
            If BTN.Equals(sender) = False Then
                BTN.DesactivarBTN()
            End If
        Next
        If sender.Equals(BTNConfiguracionSistema) Then
            For Each control As Control In Me.Controls
                If Not (TypeOf control Is SButton Or TypeOf control Is Label) And control.Tag <> "*" Then
                    If control.Tag = "ConfigSistema" Then
                        control.Visible = True
                    Else
                        control.Visible = False
                    End If
                End If
            Next
        Else
            For Each control As Control In Me.Controls
                If Not (TypeOf control Is SButton Or TypeOf control Is Label) And control.Tag <> "*" Then
                    If control.Tag = "ConfigPredeterminadas" Then
                        control.Visible = True
                    Else
                        control.Visible = False
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTNConfiguracionSistema.PerformClick()
        If Not String.IsNullOrWhiteSpace(My.Settings.CNS) Then
            TXTContraseña.Text = My.Settings.ContraseñaBD
            TXTNombreBD.Text = My.Settings.NombreBD
            TXTNombreServidor.Text = My.Settings.NombreServidorSQL
            TXTNombreUsuario.Text = My.Settings.UsuarioBD
            TXTContraseña.ForeColor = Color.Black
            TXTNombreBD.ForeColor = Color.Black
            TXTNombreServidor.ForeColor = Color.Black
            TXTNombreUsuario.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
    Private Sub SButton22_Click(sender As Object, e As EventArgs) Handles BTNProbarConexion.Click
        'data source = ServidorSQL; initial catalog = BaseDatos; user id = Usuario; password = Contraseña
        Dim CNS As String = "data source = " + TXTNombreServidor.Text.Trim + "; initial catalog = " + TXTNombreBD.Text.Trim + "; user id = " + TXTNombreUsuario.Text.Trim +
            "; password = " + TXTContraseña.Text.Trim
        Try
            Using conexion As New SqlConnection(CNS)
                conexion.Open()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try
        My.Settings.CNS = CNS
        My.Settings.NombreServidorSQL = TXTNombreServidor.Text.Trim
        My.Settings.NombreBD = TXTNombreBD.Text.Trim
        My.Settings.UsuarioBD = TXTNombreUsuario.Text.Trim
        My.Settings.ContraseñaBD = TXTContraseña.Text.Trim
        My.Settings.Save()
    End Sub
    Private Sub BTNCerrarConfiguracion_Click(sender As Object, e As EventArgs) Handles BTNCerrarConfiguracion.Click
        Me.Close()
    End Sub

    Private Sub BTNCerrarConfiguracion_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class