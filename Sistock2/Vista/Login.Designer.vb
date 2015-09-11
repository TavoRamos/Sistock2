<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TimerInicio = New System.Windows.Forms.Timer(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.TimerFin = New System.Windows.Forms.Timer(Me.components)
        Me.TXTUsuario = New System.Windows.Forms.TextBox()
        Me.TXTContrasenia = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TimerInicio
        '
        Me.TimerInicio.Enabled = True
        Me.TimerInicio.Interval = 10
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(305, 500)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OvalShape1.BorderColor = System.Drawing.Color.Transparent
        Me.OvalShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.OvalShape1.FillColor = System.Drawing.Color.SteelBlue
        Me.OvalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape1.Location = New System.Drawing.Point(-46, -32)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(74, 74)
        '
        'TimerFin
        '
        Me.TimerFin.Enabled = True
        Me.TimerFin.Interval = 10
        '
        'TXTUsuario
        '
        Me.TXTUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTUsuario.Font = New System.Drawing.Font("Aller", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUsuario.Location = New System.Drawing.Point(92, 316)
        Me.TXTUsuario.Name = "TXTUsuario"
        Me.TXTUsuario.Size = New System.Drawing.Size(213, 20)
        Me.TXTUsuario.TabIndex = 1
        '
        'TXTContrasenia
        '
        Me.TXTContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTContrasenia.Font = New System.Drawing.Font("Aller", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTContrasenia.Location = New System.Drawing.Point(110, 370)
        Me.TXTContrasenia.Name = "TXTContrasenia"
        Me.TXTContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TXTContrasenia.Size = New System.Drawing.Size(195, 20)
        Me.TXTContrasenia.TabIndex = 2
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(305, 500)
        Me.Controls.Add(Me.TXTContrasenia)
        Me.Controls.Add(Me.TXTUsuario)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Opacity = 0.0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incio de sesión"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerInicio As System.Windows.Forms.Timer
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents TimerFin As System.Windows.Forms.Timer
    Friend WithEvents TXTUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TXTContrasenia As System.Windows.Forms.TextBox

End Class
