<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesProveedores
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesProveedores))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.tipo_contribuyente = New System.Windows.Forms.DataGridViewImageColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTNSlider = New System.Windows.Forms.Button()
        Me.SLabel8 = New Sistock2.SLabel()
        Me.SLabel7 = New Sistock2.SLabel()
        Me.SLabel6 = New Sistock2.SLabel()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.SLabel5 = New Sistock2.SLabel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.SLabel4 = New Sistock2.SLabel()
        Me.WindowsSwitchButton1 = New SwitchButton.WindowsSwitchButton()
        Me.GmapClienteProveedor = New GMap.NET.WindowsForms.GMapControl()
        Me.SLabel3 = New Sistock2.SLabel()
        Me.CBLocalidad = New System.Windows.Forms.ComboBox()
        Me.CBProvincia = New System.Windows.Forms.ComboBox()
        Me.CBTipoContribuyente = New System.Windows.Forms.ComboBox()
        Me.CBIIBB = New System.Windows.Forms.ComboBox()
        Me.STextbox7 = New Sistock2.STextbox()
        Me.CBTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.STextbox6 = New Sistock2.STextbox()
        Me.SLabel2 = New Sistock2.SLabel()
        Me.SLabel1 = New Sistock2.SLabel()
        Me.LBLClientes = New Sistock2.SLabel()
        Me.BTNCerrar = New Sistock2.SButton2()
        Me.TXTDireccion = New Sistock2.STextbox()
        Me.STextbox4 = New Sistock2.STextbox()
        Me.STextbox3 = New Sistock2.STextbox()
        Me.STextbox2 = New Sistock2.STextbox()
        Me.STextbox1 = New Sistock2.STextbox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.DGVClientes)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.BTNSlider)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SLabel8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SLabel7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SLabel6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.NumericUpDown2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SLabel5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SLabel4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.WindowsSwitchButton1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GmapClienteProveedor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SLabel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBLocalidad)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBProvincia)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBTipoContribuyente)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBIIBB)
        Me.SplitContainer1.Panel2.Controls.Add(Me.STextbox7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBTipoDocumento)
        Me.SplitContainer1.Panel2.Controls.Add(Me.STextbox6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SLabel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SLabel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LBLClientes)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BTNCerrar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TXTDireccion)
        Me.SplitContainer1.Panel2.Controls.Add(Me.STextbox4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.STextbox3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.STextbox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.STextbox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(916, 480)
        Me.SplitContainer1.SplitterDistance = 238
        Me.SplitContainer1.TabIndex = 2
        '
        'DGVClientes
        '
        Me.DGVClientes.AllowUserToAddRows = False
        Me.DGVClientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.DGVClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DGVClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.DGVClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClientes.ColumnHeadersVisible = False
        Me.DGVClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipo_contribuyente, Me.nombre})
        Me.DGVClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVClientes.Location = New System.Drawing.Point(0, 0)
        Me.DGVClientes.MultiSelect = False
        Me.DGVClientes.Name = "DGVClientes"
        Me.DGVClientes.ReadOnly = True
        Me.DGVClientes.RowHeadersVisible = False
        Me.DGVClientes.RowTemplate.Height = 45
        Me.DGVClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVClientes.Size = New System.Drawing.Size(238, 480)
        Me.DGVClientes.TabIndex = 30
        '
        'tipo_contribuyente
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.NullValue = CType(resources.GetObject("DataGridViewCellStyle3.NullValue"), Object)
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.tipo_contribuyente.DefaultCellStyle = DataGridViewCellStyle3
        Me.tipo_contribuyente.HeaderText = "Tipo"
        Me.tipo_contribuyente.Name = "tipo_contribuyente"
        Me.tipo_contribuyente.ReadOnly = True
        Me.tipo_contribuyente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tipo_contribuyente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.tipo_contribuyente.Width = 5
        '
        'nombre
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.nombre.DefaultCellStyle = DataGridViewCellStyle4
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 5
        '
        'BTNSlider
        '
        Me.BTNSlider.BackgroundImage = Global.Sistock2.My.Resources.Resources.BGBTNSlider
        Me.BTNSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNSlider.FlatAppearance.BorderSize = 0
        Me.BTNSlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSlider.Image = Global.Sistock2.My.Resources.Resources.SliderArrow
        Me.BTNSlider.Location = New System.Drawing.Point(-5, 202)
        Me.BTNSlider.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNSlider.Name = "BTNSlider"
        Me.BTNSlider.Size = New System.Drawing.Size(24, 89)
        Me.BTNSlider.TabIndex = 30
        Me.BTNSlider.UseVisualStyleBackColor = True
        '
        'SLabel8
        '
        Me.SLabel8.AutoSize = True
        Me.SLabel8.BackColor = System.Drawing.Color.Transparent
        Me.SLabel8.Font = New System.Drawing.Font("Dustismo", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.SLabel8.Location = New System.Drawing.Point(347, 411)
        Me.SLabel8.Name = "SLabel8"
        Me.SLabel8.Size = New System.Drawing.Size(123, 20)
        Me.SLabel8.TabIndex = 29
        Me.SLabel8.Text = "Cliente activo:"
        '
        'SLabel7
        '
        Me.SLabel7.AutoSize = True
        Me.SLabel7.BackColor = System.Drawing.Color.Transparent
        Me.SLabel7.Font = New System.Drawing.Font("Dustismo", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.SLabel7.Location = New System.Drawing.Point(347, 377)
        Me.SLabel7.Name = "SLabel7"
        Me.SLabel7.Size = New System.Drawing.Size(59, 22)
        Me.SLabel7.TabIndex = 28
        Me.SLabel7.Text = "Otros"
        '
        'SLabel6
        '
        Me.SLabel6.AutoSize = True
        Me.SLabel6.BackColor = System.Drawing.Color.Transparent
        Me.SLabel6.Font = New System.Drawing.Font("Dustismo", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.SLabel6.Location = New System.Drawing.Point(347, 342)
        Me.SLabel6.Name = "SLabel6"
        Me.SLabel6.Size = New System.Drawing.Size(109, 20)
        Me.SLabel6.TabIndex = 27
        Me.SLabel6.Text = "Bonificación:"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(526, 342)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown2.TabIndex = 26
        '
        'SLabel5
        '
        Me.SLabel5.AutoSize = True
        Me.SLabel5.BackColor = System.Drawing.Color.Transparent
        Me.SLabel5.Font = New System.Drawing.Font("Dustismo", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.SLabel5.Location = New System.Drawing.Point(347, 316)
        Me.SLabel5.Name = "SLabel5"
        Me.SLabel5.Size = New System.Drawing.Size(151, 20)
        Me.SLabel5.TabIndex = 25
        Me.SLabel5.Text = "Límite de crédito:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(526, 316)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 24
        '
        'SLabel4
        '
        Me.SLabel4.AutoSize = True
        Me.SLabel4.BackColor = System.Drawing.Color.Transparent
        Me.SLabel4.Font = New System.Drawing.Font("Dustismo", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.SLabel4.Location = New System.Drawing.Point(347, 290)
        Me.SLabel4.Name = "SLabel4"
        Me.SLabel4.Size = New System.Drawing.Size(171, 20)
        Me.SLabel4.TabIndex = 23
        Me.SLabel4.Text = "Condicion de venta:"
        '
        'WindowsSwitchButton1
        '
        Me.WindowsSwitchButton1.Activated = False
        Me.WindowsSwitchButton1.Location = New System.Drawing.Point(596, 412)
        Me.WindowsSwitchButton1.MaximumSize = New System.Drawing.Size(50, 19)
        Me.WindowsSwitchButton1.MinimumSize = New System.Drawing.Size(50, 19)
        Me.WindowsSwitchButton1.Name = "WindowsSwitchButton1"
        Me.WindowsSwitchButton1.Size = New System.Drawing.Size(50, 19)
        Me.WindowsSwitchButton1.SwitchColor = SwitchButton.WindowsSwitchButton.ColorScheme.Blue
        Me.WindowsSwitchButton1.TabIndex = 22
        '
        'GmapClienteProveedor
        '
        Me.GmapClienteProveedor.Bearing = 0!
        Me.GmapClienteProveedor.CanDragMap = True
        Me.GmapClienteProveedor.EmptyTileColor = System.Drawing.Color.Navy
        Me.GmapClienteProveedor.GrayScaleMode = False
        Me.GmapClienteProveedor.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.GmapClienteProveedor.LevelsKeepInMemmory = 5
        Me.GmapClienteProveedor.Location = New System.Drawing.Point(24, 316)
        Me.GmapClienteProveedor.MarkersEnabled = True
        Me.GmapClienteProveedor.MaxZoom = 18
        Me.GmapClienteProveedor.MinZoom = 0
        Me.GmapClienteProveedor.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.ViewCenter
        Me.GmapClienteProveedor.Name = "GmapClienteProveedor"
        Me.GmapClienteProveedor.NegativeMode = False
        Me.GmapClienteProveedor.PolygonsEnabled = False
        Me.GmapClienteProveedor.RetryLoadTile = 0
        Me.GmapClienteProveedor.RoutesEnabled = False
        Me.GmapClienteProveedor.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.GmapClienteProveedor.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GmapClienteProveedor.ShowTileGridLines = False
        Me.GmapClienteProveedor.Size = New System.Drawing.Size(295, 152)
        Me.GmapClienteProveedor.TabIndex = 21
        Me.GmapClienteProveedor.Zoom = 2.0R
        '
        'SLabel3
        '
        Me.SLabel3.AutoSize = True
        Me.SLabel3.BackColor = System.Drawing.Color.Transparent
        Me.SLabel3.Font = New System.Drawing.Font("Dustismo", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.SLabel3.Location = New System.Drawing.Point(347, 262)
        Me.SLabel3.Name = "SLabel3"
        Me.SLabel3.Size = New System.Drawing.Size(153, 22)
        Me.SLabel3.TabIndex = 19
        Me.SLabel3.Text = "Venta y crédito"
        '
        'CBLocalidad
        '
        Me.CBLocalidad.FormattingEnabled = True
        Me.CBLocalidad.Items.AddRange(New Object() {"Saladillo"})
        Me.CBLocalidad.Location = New System.Drawing.Point(24, 289)
        Me.CBLocalidad.Name = "CBLocalidad"
        Me.CBLocalidad.Size = New System.Drawing.Size(295, 21)
        Me.CBLocalidad.TabIndex = 18
        Me.CBLocalidad.Text = "Seleccione una localidad..."
        '
        'CBProvincia
        '
        Me.CBProvincia.FormattingEnabled = True
        Me.CBProvincia.Items.AddRange(New Object() {"Buenos Aires", "Catamarca", "Ciudad Autónoma de Buenos Aires", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Tucumán"})
        Me.CBProvincia.Location = New System.Drawing.Point(24, 262)
        Me.CBProvincia.Name = "CBProvincia"
        Me.CBProvincia.Size = New System.Drawing.Size(295, 21)
        Me.CBProvincia.TabIndex = 17
        Me.CBProvincia.Text = "Seleccione una provincia..."
        '
        'CBTipoContribuyente
        '
        Me.CBTipoContribuyente.FormattingEnabled = True
        Me.CBTipoContribuyente.Items.AddRange(New Object() {"Cliente del exterior", "Consumidor Final", "Eventual", "Exento", "Monotributista", "No categorizado", "No responsable", "Proveedor del exterior", "Responsable inscripto"})
        Me.CBTipoContribuyente.Location = New System.Drawing.Point(351, 171)
        Me.CBTipoContribuyente.Name = "CBTipoContribuyente"
        Me.CBTipoContribuyente.Size = New System.Drawing.Size(295, 21)
        Me.CBTipoContribuyente.TabIndex = 16
        Me.CBTipoContribuyente.Text = "Tipo de contribuyente..."
        '
        'CBIIBB
        '
        Me.CBIIBB.FormattingEnabled = True
        Me.CBIIBB.Items.AddRange(New Object() {"Local", "Convenio", "No Inscripto"})
        Me.CBIIBB.Location = New System.Drawing.Point(351, 202)
        Me.CBIIBB.Name = "CBIIBB"
        Me.CBIIBB.Size = New System.Drawing.Size(295, 21)
        Me.CBIIBB.TabIndex = 15
        Me.CBIIBB.Text = "Situación IIBB..."
        '
        'STextbox7
        '
        Me.STextbox7.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Italic)
        Me.STextbox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.STextbox7.Location = New System.Drawing.Point(351, 231)
        Me.STextbox7.Multiline = True
        Me.STextbox7.Name = "STextbox7"
        Me.STextbox7.NewText = ""
        Me.STextbox7.OriText = "Código IIBB..."
        Me.STextbox7.Size = New System.Drawing.Size(295, 25)
        Me.STextbox7.TabIndex = 14
        Me.STextbox7.Text = "Código IIBB..."
        Me.STextbox7.Texthaschanged = False
        Me.STextbox7.ValidarVacio = False
        '
        'CBTipoDocumento
        '
        Me.CBTipoDocumento.FormattingEnabled = True
        Me.CBTipoDocumento.Items.AddRange(New Object() {"CDI", "CUIL", "CUIT", "DNI", "LC", "LE", "Pasaporte"})
        Me.CBTipoDocumento.Location = New System.Drawing.Point(351, 111)
        Me.CBTipoDocumento.Name = "CBTipoDocumento"
        Me.CBTipoDocumento.Size = New System.Drawing.Size(295, 21)
        Me.CBTipoDocumento.TabIndex = 13
        Me.CBTipoDocumento.Text = "Tipo de documento..."
        '
        'STextbox6
        '
        Me.STextbox6.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Italic)
        Me.STextbox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.STextbox6.Location = New System.Drawing.Point(351, 138)
        Me.STextbox6.Multiline = True
        Me.STextbox6.Name = "STextbox6"
        Me.STextbox6.NewText = ""
        Me.STextbox6.OriText = "Número de documento..."
        Me.STextbox6.Size = New System.Drawing.Size(295, 25)
        Me.STextbox6.TabIndex = 12
        Me.STextbox6.Text = "Número de documento..."
        Me.STextbox6.Texthaschanged = False
        Me.STextbox6.ValidarVacio = False
        '
        'SLabel2
        '
        Me.SLabel2.AutoSize = True
        Me.SLabel2.BackColor = System.Drawing.Color.Transparent
        Me.SLabel2.Font = New System.Drawing.Font("Dustismo", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.SLabel2.Location = New System.Drawing.Point(347, 82)
        Me.SLabel2.Name = "SLabel2"
        Me.SLabel2.Size = New System.Drawing.Size(63, 22)
        Me.SLabel2.TabIndex = 11
        Me.SLabel2.Text = "Fiscal"
        '
        'SLabel1
        '
        Me.SLabel1.AutoSize = True
        Me.SLabel1.BackColor = System.Drawing.Color.Transparent
        Me.SLabel1.Font = New System.Drawing.Font("Dustismo", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.SLabel1.Location = New System.Drawing.Point(20, 82)
        Me.SLabel1.Name = "SLabel1"
        Me.SLabel1.Size = New System.Drawing.Size(244, 22)
        Me.SLabel1.TabIndex = 10
        Me.SLabel1.Text = "Información de contacto"
        '
        'LBLClientes
        '
        Me.LBLClientes.AutoSize = True
        Me.LBLClientes.BackColor = System.Drawing.Color.Transparent
        Me.LBLClientes.Font = New System.Drawing.Font("Dustismo", 48.0!, System.Drawing.FontStyle.Italic)
        Me.LBLClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.LBLClientes.Location = New System.Drawing.Point(12, 9)
        Me.LBLClientes.Name = "LBLClientes"
        Me.LBLClientes.Size = New System.Drawing.Size(247, 68)
        Me.LBLClientes.TabIndex = 9
        Me.LBLClientes.Text = "Clientes"
        '
        'BTNCerrar
        '
        Me.BTNCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BTNCerrar.FlatAppearance.BorderSize = 0
        Me.BTNCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCerrar.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BTNCerrar.ForeColor = System.Drawing.Color.White
        Me.BTNCerrar.Location = New System.Drawing.Point(568, 12)
        Me.BTNCerrar.Name = "BTNCerrar"
        Me.BTNCerrar.Size = New System.Drawing.Size(94, 25)
        Me.BTNCerrar.TabIndex = 8
        Me.BTNCerrar.Text = "X | Cerrar"
        Me.BTNCerrar.UseVisualStyleBackColor = False
        '
        'TXTDireccion
        '
        Me.TXTDireccion.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Italic)
        Me.TXTDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.TXTDireccion.Location = New System.Drawing.Point(24, 231)
        Me.TXTDireccion.Multiline = True
        Me.TXTDireccion.Name = "TXTDireccion"
        Me.TXTDireccion.NewText = ""
        Me.TXTDireccion.OriText = "Dirección..."
        Me.TXTDireccion.Size = New System.Drawing.Size(295, 25)
        Me.TXTDireccion.TabIndex = 7
        Me.TXTDireccion.Text = "Dirección..."
        Me.TXTDireccion.Texthaschanged = False
        Me.TXTDireccion.ValidarVacio = False
        '
        'STextbox4
        '
        Me.STextbox4.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Italic)
        Me.STextbox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.STextbox4.Location = New System.Drawing.Point(24, 200)
        Me.STextbox4.Multiline = True
        Me.STextbox4.Name = "STextbox4"
        Me.STextbox4.NewText = ""
        Me.STextbox4.OriText = "E-mail..."
        Me.STextbox4.Size = New System.Drawing.Size(295, 25)
        Me.STextbox4.TabIndex = 6
        Me.STextbox4.Text = "E-mail..."
        Me.STextbox4.Texthaschanged = False
        Me.STextbox4.ValidarVacio = False
        '
        'STextbox3
        '
        Me.STextbox3.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Italic)
        Me.STextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.STextbox3.Location = New System.Drawing.Point(24, 169)
        Me.STextbox3.Multiline = True
        Me.STextbox3.Name = "STextbox3"
        Me.STextbox3.NewText = ""
        Me.STextbox3.OriText = "Telefono..."
        Me.STextbox3.Size = New System.Drawing.Size(295, 25)
        Me.STextbox3.TabIndex = 5
        Me.STextbox3.Text = "Telefono..."
        Me.STextbox3.Texthaschanged = False
        Me.STextbox3.ValidarVacio = False
        '
        'STextbox2
        '
        Me.STextbox2.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Italic)
        Me.STextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.STextbox2.Location = New System.Drawing.Point(24, 138)
        Me.STextbox2.Multiline = True
        Me.STextbox2.Name = "STextbox2"
        Me.STextbox2.NewText = ""
        Me.STextbox2.OriText = "Nombre comercial..."
        Me.STextbox2.Size = New System.Drawing.Size(295, 25)
        Me.STextbox2.TabIndex = 4
        Me.STextbox2.Text = "Nombre comercial..."
        Me.STextbox2.Texthaschanged = False
        Me.STextbox2.ValidarVacio = False
        '
        'STextbox1
        '
        Me.STextbox1.Font = New System.Drawing.Font("Dustismo", 12.0!, System.Drawing.FontStyle.Italic)
        Me.STextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.STextbox1.Location = New System.Drawing.Point(24, 107)
        Me.STextbox1.Multiline = True
        Me.STextbox1.Name = "STextbox1"
        Me.STextbox1.NewText = ""
        Me.STextbox1.OriText = "Nombre o razón social..."
        Me.STextbox1.Size = New System.Drawing.Size(295, 25)
        Me.STextbox1.TabIndex = 3
        Me.STextbox1.Text = "Nombre o razón social..."
        Me.STextbox1.Texthaschanged = False
        Me.STextbox1.ValidarVacio = False
        '
        'ClientesProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 480)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClientesProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClientesProveedores"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TXTDireccion As STextbox
    Friend WithEvents STextbox4 As STextbox
    Friend WithEvents STextbox3 As STextbox
    Friend WithEvents STextbox2 As STextbox
    Friend WithEvents STextbox1 As STextbox
    Friend WithEvents BTNCerrar As SButton2
    Friend WithEvents LBLClientes As SLabel
    Friend WithEvents SLabel1 As SLabel
    Friend WithEvents SLabel3 As SLabel
    Friend WithEvents CBLocalidad As ComboBox
    Friend WithEvents CBProvincia As ComboBox
    Friend WithEvents CBTipoContribuyente As ComboBox
    Friend WithEvents CBIIBB As ComboBox
    Friend WithEvents STextbox7 As STextbox
    Friend WithEvents CBTipoDocumento As ComboBox
    Friend WithEvents STextbox6 As STextbox
    Friend WithEvents SLabel2 As SLabel
    Friend WithEvents GmapClienteProveedor As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents WindowsSwitchButton1 As SwitchButton.WindowsSwitchButton
    Friend WithEvents SLabel4 As SLabel
    Friend WithEvents DGVClientes As DataGridView
    Friend WithEvents SLabel8 As SLabel
    Friend WithEvents SLabel7 As SLabel
    Friend WithEvents SLabel6 As SLabel
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents SLabel5 As SLabel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents tipo_contribuyente As DataGridViewImageColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents BTNSlider As Button
End Class
