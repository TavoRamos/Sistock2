<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasCorrientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasCorrientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoInformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RubrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TalonariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.BTNInformes = New Sistock2.SButton()
        Me.BTNClientes = New Sistock2.SButton()
        Me.BTNProductos = New Sistock2.SButton()
        Me.BTNCompras = New Sistock2.SButton()
        Me.SButton21 = New Sistock2.SButton2()
        Me.BTNVentas = New Sistock2.SButton()
        Me.LBLReloj = New Sistock2.SLabel()
        Me.Menu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.ClientesProveedoresToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.TalonariosToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Menu.Size = New System.Drawing.Size(1024, 24)
        Me.Menu.TabIndex = 11
        Me.Menu.Text = "MenuPrincipal"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVentaToolStripMenuItem, Me.ListadoToolStripMenuItem, Me.CuentasCorrientesToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VentasToolStripMenuItem.Text = "&Ventas"
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.NuevaVentaToolStripMenuItem.Text = "Nueva venta..."
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ListadoToolStripMenuItem.Text = "Listado / Informes"
        '
        'CuentasCorrientesToolStripMenuItem
        '
        Me.CuentasCorrientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagosToolStripMenuItem})
        Me.CuentasCorrientesToolStripMenuItem.Name = "CuentasCorrientesToolStripMenuItem"
        Me.CuentasCorrientesToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.CuentasCorrientesToolStripMenuItem.Text = "Cuentas corrientes"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaCompraToolStripMenuItem, Me.ListadoToolStripMenuItem1, Me.CuentasCorrientesToolStripMenuItem1})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ComprasToolStripMenuItem.Text = "&Compras"
        '
        'NuevaCompraToolStripMenuItem
        '
        Me.NuevaCompraToolStripMenuItem.Name = "NuevaCompraToolStripMenuItem"
        Me.NuevaCompraToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.NuevaCompraToolStripMenuItem.Text = "Nueva compra..."
        '
        'ListadoToolStripMenuItem1
        '
        Me.ListadoToolStripMenuItem1.Name = "ListadoToolStripMenuItem1"
        Me.ListadoToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.ListadoToolStripMenuItem1.Text = "Listado / Informes"
        '
        'CuentasCorrientesToolStripMenuItem1
        '
        Me.CuentasCorrientesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagosToolStripMenuItem1})
        Me.CuentasCorrientesToolStripMenuItem1.Name = "CuentasCorrientesToolStripMenuItem1"
        Me.CuentasCorrientesToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.CuentasCorrientesToolStripMenuItem1.Text = "Cuentas corrientes"
        '
        'PagosToolStripMenuItem1
        '
        Me.PagosToolStripMenuItem1.Name = "PagosToolStripMenuItem1"
        Me.PagosToolStripMenuItem1.Size = New System.Drawing.Size(106, 22)
        Me.PagosToolStripMenuItem1.Text = "Pagos"
        '
        'ClientesProveedoresToolStripMenuItem
        '
        Me.ClientesProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ListadoToolStripMenuItem2})
        Me.ClientesProveedoresToolStripMenuItem.Name = "ClientesProveedoresToolStripMenuItem"
        Me.ClientesProveedoresToolStripMenuItem.Size = New System.Drawing.Size(137, 20)
        Me.ClientesProveedoresToolStripMenuItem.Text = "Clientes / Proveedores"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo..."
        '
        'ListadoToolStripMenuItem2
        '
        Me.ListadoToolStripMenuItem2.Name = "ListadoToolStripMenuItem2"
        Me.ListadoToolStripMenuItem2.Size = New System.Drawing.Size(125, 22)
        Me.ListadoToolStripMenuItem2.Text = "Consultar"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoProductoToolStripMenuItem, Me.StockToolStripMenuItem, Me.ListadoInformesToolStripMenuItem, Me.LotesToolStripMenuItem, Me.RubrosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "&Productos"
        '
        'NuevoProductoToolStripMenuItem
        '
        Me.NuevoProductoToolStripMenuItem.Name = "NuevoProductoToolStripMenuItem"
        Me.NuevoProductoToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.NuevoProductoToolStripMenuItem.Text = "Nuevo producto"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'ListadoInformesToolStripMenuItem
        '
        Me.ListadoInformesToolStripMenuItem.Name = "ListadoInformesToolStripMenuItem"
        Me.ListadoInformesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ListadoInformesToolStripMenuItem.Text = "Listado / Informes"
        '
        'LotesToolStripMenuItem
        '
        Me.LotesToolStripMenuItem.Name = "LotesToolStripMenuItem"
        Me.LotesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.LotesToolStripMenuItem.Text = "Lotes"
        '
        'RubrosToolStripMenuItem
        '
        Me.RubrosToolStripMenuItem.Name = "RubrosToolStripMenuItem"
        Me.RubrosToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RubrosToolStripMenuItem.Text = "Rubros"
        '
        'TalonariosToolStripMenuItem
        '
        Me.TalonariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoToolStripMenuItem3})
        Me.TalonariosToolStripMenuItem.Name = "TalonariosToolStripMenuItem"
        Me.TalonariosToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.TalonariosToolStripMenuItem.Text = "&Talonarios"
        '
        'ListadoToolStripMenuItem3
        '
        Me.ListadoToolStripMenuItem3.Name = "ListadoToolStripMenuItem3"
        Me.ListadoToolStripMenuItem3.Size = New System.Drawing.Size(112, 22)
        Me.ListadoToolStripMenuItem3.Text = "Listado"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImage = Global.Sistock2.My.Resources.Resources.BarraLateralPrincipal
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SplitContainer1.Panel1.Controls.Add(Me.BTNInformes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BTNClientes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BTNProductos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BTNCompras)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SButton21)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BTNVentas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LBLReloj)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel2.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Size = New System.Drawing.Size(1024, 637)
        Me.SplitContainer1.SplitterDistance = 157
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 13
        '
        'BTNInformes
        '
        Me.BTNInformes.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BTNInformes.FlatAppearance.BorderSize = 0
        Me.BTNInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNInformes.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTNInformes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BTNInformes.Location = New System.Drawing.Point(0, 530)
        Me.BTNInformes.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.BTNInformes.Name = "BTNInformes"
        Me.BTNInformes.Size = New System.Drawing.Size(150, 35)
        Me.BTNInformes.TabIndex = 16
        Me.BTNInformes.Text = "Informes"
        Me.BTNInformes.UseVisualStyleBackColor = False
        '
        'BTNClientes
        '
        Me.BTNClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BTNClientes.FlatAppearance.BorderSize = 0
        Me.BTNClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNClientes.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTNClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BTNClientes.Location = New System.Drawing.Point(0, 495)
        Me.BTNClientes.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.BTNClientes.Name = "BTNClientes"
        Me.BTNClientes.Size = New System.Drawing.Size(150, 35)
        Me.BTNClientes.TabIndex = 15
        Me.BTNClientes.Text = "Clientes"
        Me.BTNClientes.UseVisualStyleBackColor = False
        '
        'BTNProductos
        '
        Me.BTNProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BTNProductos.FlatAppearance.BorderSize = 0
        Me.BTNProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNProductos.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTNProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BTNProductos.Location = New System.Drawing.Point(0, 460)
        Me.BTNProductos.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.BTNProductos.Name = "BTNProductos"
        Me.BTNProductos.Size = New System.Drawing.Size(150, 35)
        Me.BTNProductos.TabIndex = 14
        Me.BTNProductos.Text = "Productos"
        Me.BTNProductos.UseVisualStyleBackColor = False
        '
        'BTNCompras
        '
        Me.BTNCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BTNCompras.FlatAppearance.BorderSize = 0
        Me.BTNCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCompras.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTNCompras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BTNCompras.Location = New System.Drawing.Point(0, 425)
        Me.BTNCompras.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.BTNCompras.Name = "BTNCompras"
        Me.BTNCompras.Size = New System.Drawing.Size(150, 35)
        Me.BTNCompras.TabIndex = 13
        Me.BTNCompras.Text = "Compras"
        Me.BTNCompras.UseVisualStyleBackColor = False
        '
        'SButton21
        '
        Me.SButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.SButton21.FlatAppearance.BorderSize = 0
        Me.SButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SButton21.ForeColor = System.Drawing.Color.White
        Me.SButton21.Location = New System.Drawing.Point(12, 247)
        Me.SButton21.Name = "SButton21"
        Me.SButton21.Size = New System.Drawing.Size(124, 25)
        Me.SButton21.TabIndex = 12
        Me.SButton21.Text = "NUEVA VENTA"
        Me.SButton21.UseVisualStyleBackColor = False
        '
        'BTNVentas
        '
        Me.BTNVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BTNVentas.FlatAppearance.BorderSize = 0
        Me.BTNVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNVentas.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTNVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BTNVentas.Location = New System.Drawing.Point(0, 390)
        Me.BTNVentas.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.BTNVentas.Name = "BTNVentas"
        Me.BTNVentas.Size = New System.Drawing.Size(150, 35)
        Me.BTNVentas.TabIndex = 11
        Me.BTNVentas.Text = "Ventas"
        Me.BTNVentas.UseVisualStyleBackColor = False
        '
        'LBLReloj
        '
        Me.LBLReloj.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.LBLReloj.Font = New System.Drawing.Font("Calibri Light", 36.0!)
        Me.LBLReloj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LBLReloj.Location = New System.Drawing.Point(8, 159)
        Me.LBLReloj.Name = "LBLReloj"
        Me.LBLReloj.Size = New System.Drawing.Size(134, 59)
        Me.LBLReloj.TabIndex = 10
        Me.LBLReloj.Text = "00:00"
        Me.LBLReloj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Sistock2.My.Resources.Resources.Configuracion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1024, 661)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Menu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.Menu
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SistocK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menu As MenuStrip
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentasCorrientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CuentasCorrientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientesProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoInformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RubrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TalonariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BTNInformes As SButton
    Friend WithEvents BTNClientes As SButton
    Friend WithEvents BTNProductos As SButton
    Friend WithEvents BTNCompras As SButton
    Friend WithEvents SButton21 As SButton2
    Friend WithEvents BTNVentas As SButton
    Friend WithEvents LBLReloj As SLabel
End Class
