<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LBLConfiguracion = New System.Windows.Forms.Label()
        Me.BTNProbarConexion = New Sistock2.SButton2()
        Me.BTNCerrarConfiguracion = New Sistock2.SButton2()
        Me.TXTContraseña = New Sistock2.STextbox()
        Me.TXTNombreUsuario = New Sistock2.STextbox()
        Me.TXTNombreBD = New Sistock2.STextbox()
        Me.TXTNombreServidor = New Sistock2.STextbox()
        Me.BTNConfiguracionSistema = New Sistock2.SButton()
        Me.BTNConfiguracionPredeterminadas = New Sistock2.SButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBLConfiguracion
        '
        Me.LBLConfiguracion.BackColor = System.Drawing.Color.White
        Me.LBLConfiguracion.Font = New System.Drawing.Font("Dustismo", 30.0!, System.Drawing.FontStyle.Italic)
        Me.LBLConfiguracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LBLConfiguracion.Location = New System.Drawing.Point(165, 48)
        Me.LBLConfiguracion.Name = "LBLConfiguracion"
        Me.LBLConfiguracion.Size = New System.Drawing.Size(323, 93)
        Me.LBLConfiguracion.TabIndex = 2
        Me.LBLConfiguracion.Text = "Configuraciones predeterminadas"
        '
        'BTNProbarConexion
        '
        Me.BTNProbarConexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BTNProbarConexion.FlatAppearance.BorderSize = 0
        Me.BTNProbarConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNProbarConexion.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTNProbarConexion.ForeColor = System.Drawing.Color.White
        Me.BTNProbarConexion.Location = New System.Drawing.Point(325, 295)
        Me.BTNProbarConexion.Name = "BTNProbarConexion"
        Me.BTNProbarConexion.Size = New System.Drawing.Size(163, 25)
        Me.BTNProbarConexion.TabIndex = 12
        Me.BTNProbarConexion.Tag = "ConfigSistema"
        Me.BTNProbarConexion.Text = "PROBAR CONEXIÓN"
        Me.BTNProbarConexion.UseVisualStyleBackColor = False
        Me.BTNProbarConexion.Visible = False
        '
        'BTNCerrarConfiguracion
        '
        Me.BTNCerrarConfiguracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BTNCerrarConfiguracion.FlatAppearance.BorderSize = 0
        Me.BTNCerrarConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCerrarConfiguracion.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTNCerrarConfiguracion.ForeColor = System.Drawing.Color.White
        Me.BTNCerrarConfiguracion.Location = New System.Drawing.Point(399, 12)
        Me.BTNCerrarConfiguracion.Name = "BTNCerrarConfiguracion"
        Me.BTNCerrarConfiguracion.Size = New System.Drawing.Size(89, 25)
        Me.BTNCerrarConfiguracion.TabIndex = 11
        Me.BTNCerrarConfiguracion.Tag = "*"
        Me.BTNCerrarConfiguracion.Text = "X | Cerrar"
        Me.BTNCerrarConfiguracion.UseVisualStyleBackColor = False
        '
        'TXTContraseña
        '
        Me.TXTContraseña.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Italic)
        Me.TXTContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TXTContraseña.Location = New System.Drawing.Point(172, 266)
        Me.TXTContraseña.Multiline = True
        Me.TXTContraseña.Name = "TXTContraseña"
        Me.TXTContraseña.NewText = ""
        Me.TXTContraseña.OriText = "Contraseña..."
        Me.TXTContraseña.Size = New System.Drawing.Size(314, 23)
        Me.TXTContraseña.TabIndex = 9
        Me.TXTContraseña.Tag = "ConfigSistema"
        Me.TXTContraseña.Text = "Contraseña..."
        Me.TXTContraseña.Texthaschanged = False
        Me.TXTContraseña.ValidarVacio = True
        Me.TXTContraseña.Visible = False
        '
        'TXTNombreUsuario
        '
        Me.TXTNombreUsuario.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Italic)
        Me.TXTNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TXTNombreUsuario.Location = New System.Drawing.Point(172, 237)
        Me.TXTNombreUsuario.Multiline = True
        Me.TXTNombreUsuario.Name = "TXTNombreUsuario"
        Me.TXTNombreUsuario.NewText = ""
        Me.TXTNombreUsuario.OriText = "Nombre de usuario..."
        Me.TXTNombreUsuario.Size = New System.Drawing.Size(314, 23)
        Me.TXTNombreUsuario.TabIndex = 8
        Me.TXTNombreUsuario.Tag = "ConfigSistema"
        Me.TXTNombreUsuario.Text = "Nombre de usuario..."
        Me.TXTNombreUsuario.Texthaschanged = False
        Me.TXTNombreUsuario.ValidarVacio = True
        Me.TXTNombreUsuario.Visible = False
        '
        'TXTNombreBD
        '
        Me.TXTNombreBD.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Italic)
        Me.TXTNombreBD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TXTNombreBD.Location = New System.Drawing.Point(172, 208)
        Me.TXTNombreBD.Multiline = True
        Me.TXTNombreBD.Name = "TXTNombreBD"
        Me.TXTNombreBD.NewText = ""
        Me.TXTNombreBD.OriText = "Nombre de base de datos..."
        Me.TXTNombreBD.Size = New System.Drawing.Size(314, 23)
        Me.TXTNombreBD.TabIndex = 7
        Me.TXTNombreBD.Tag = "ConfigSistema"
        Me.TXTNombreBD.Text = "Nombre de base de datos..."
        Me.TXTNombreBD.Texthaschanged = False
        Me.TXTNombreBD.ValidarVacio = True
        Me.TXTNombreBD.Visible = False
        '
        'TXTNombreServidor
        '
        Me.TXTNombreServidor.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Italic)
        Me.TXTNombreServidor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TXTNombreServidor.Location = New System.Drawing.Point(172, 179)
        Me.TXTNombreServidor.Multiline = True
        Me.TXTNombreServidor.Name = "TXTNombreServidor"
        Me.TXTNombreServidor.NewText = ""
        Me.TXTNombreServidor.OriText = "Nombre del servidor..."
        Me.TXTNombreServidor.Size = New System.Drawing.Size(314, 23)
        Me.TXTNombreServidor.TabIndex = 6
        Me.TXTNombreServidor.Tag = "ConfigSistema"
        Me.TXTNombreServidor.Text = "Nombre del servidor..."
        Me.TXTNombreServidor.Texthaschanged = False
        Me.TXTNombreServidor.ValidarVacio = True
        Me.TXTNombreServidor.Visible = False
        '
        'BTNConfiguracionSistema
        '
        Me.BTNConfiguracionSistema.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BTNConfiguracionSistema.FlatAppearance.BorderSize = 0
        Me.BTNConfiguracionSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNConfiguracionSistema.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTNConfiguracionSistema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BTNConfiguracionSistema.Location = New System.Drawing.Point(0, 175)
        Me.BTNConfiguracionSistema.Name = "BTNConfiguracionSistema"
        Me.BTNConfiguracionSistema.Size = New System.Drawing.Size(150, 35)
        Me.BTNConfiguracionSistema.TabIndex = 4
        Me.BTNConfiguracionSistema.Text = "Sistema"
        Me.BTNConfiguracionSistema.UseVisualStyleBackColor = False
        '
        'BTNConfiguracionPredeterminadas
        '
        Me.BTNConfiguracionPredeterminadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BTNConfiguracionPredeterminadas.FlatAppearance.BorderSize = 0
        Me.BTNConfiguracionPredeterminadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNConfiguracionPredeterminadas.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTNConfiguracionPredeterminadas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BTNConfiguracionPredeterminadas.Location = New System.Drawing.Point(0, 210)
        Me.BTNConfiguracionPredeterminadas.Name = "BTNConfiguracionPredeterminadas"
        Me.BTNConfiguracionPredeterminadas.Size = New System.Drawing.Size(150, 70)
        Me.BTNConfiguracionPredeterminadas.TabIndex = 3
        Me.BTNConfiguracionPredeterminadas.Text = "Configuraciones predeterminadas"
        Me.BTNConfiguracionPredeterminadas.UseVisualStyleBackColor = False
        Me.BTNConfiguracionPredeterminadas.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Dustismo", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(167, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Tag = "ConfigSistema"
        Me.Label1.Text = "Persistencia"
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistock2.My.Resources.Resources.Configuracion
        Me.ClientSize = New System.Drawing.Size(499, 600)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNProbarConexion)
        Me.Controls.Add(Me.BTNCerrarConfiguracion)
        Me.Controls.Add(Me.TXTContraseña)
        Me.Controls.Add(Me.TXTNombreUsuario)
        Me.Controls.Add(Me.TXTNombreBD)
        Me.Controls.Add(Me.TXTNombreServidor)
        Me.Controls.Add(Me.BTNConfiguracionSistema)
        Me.Controls.Add(Me.BTNConfiguracionPredeterminadas)
        Me.Controls.Add(Me.LBLConfiguracion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Configuracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLConfiguracion As Label
    Friend WithEvents BTNConfiguracionPredeterminadas As SButton
    Friend WithEvents BTNConfiguracionSistema As SButton
    Friend WithEvents TXTNombreServidor As STextbox
    Friend WithEvents TXTNombreBD As STextbox
    Friend WithEvents TXTNombreUsuario As STextbox
    Friend WithEvents TXTContraseña As STextbox
    Friend WithEvents BTNCerrarConfiguracion As SButton2
    Friend WithEvents BTNProbarConexion As SButton2
    Friend WithEvents Label1 As Label
End Class
