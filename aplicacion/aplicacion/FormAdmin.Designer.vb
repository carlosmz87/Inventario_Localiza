<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeDeActivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaDeEquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SIMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MigracionesDeSIMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcasYModelosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SallirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelCliente = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_exportarClientes = New System.Windows.Forms.Button()
        Me.BTN_asignarActivo_Clientes = New System.Windows.Forms.Button()
        Me.BTN_eliminarClientes = New System.Windows.Forms.Button()
        Me.BTN_editarClientes = New System.Windows.Forms.Button()
        Me.BTN_agregarClientes = New System.Windows.Forms.Button()
        Me.TB_buscarClientes = New System.Windows.Forms.TextBox()
        Me.DGV_clientes = New System.Windows.Forms.DataGridView()
        Me.Nombre_C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono_C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo_C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelActivos = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTN_exportarActivos = New System.Windows.Forms.Button()
        Me.BTN_asignarEquipo_Activos = New System.Windows.Forms.Button()
        Me.BTN_eliminarActivos = New System.Windows.Forms.Button()
        Me.BTN_editarActivos = New System.Windows.Forms.Button()
        Me.BTN_agregarActivos = New System.Windows.Forms.Button()
        Me.TB_buscarActivos = New System.Windows.Forms.TextBox()
        Me.DGV_Activos = New System.Windows.Forms.DataGridView()
        Me.Placa_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chasis_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Color_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anio_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelEquipos = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTN_exportarEquipos = New System.Windows.Forms.Button()
        Me.BTN_asignarSIM_Equipos = New System.Windows.Forms.Button()
        Me.BTN_bajaEquipos = New System.Windows.Forms.Button()
        Me.BTN_agregarEquipos = New System.Windows.Forms.Button()
        Me.TB_buscarEquipos = New System.Windows.Forms.TextBox()
        Me.DGV_Equipos = New System.Windows.Forms.DataGridView()
        Me.IMEI_E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo_E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca_E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelSIM = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BTN_exportarSim = New System.Windows.Forms.Button()
        Me.BTN_migrarSim = New System.Windows.Forms.Button()
        Me.BTN_eliminarSim = New System.Windows.Forms.Button()
        Me.BTN_editarSIM = New System.Windows.Forms.Button()
        Me.BTN_agregarSIM = New System.Windows.Forms.Button()
        Me.TB_buscarSim = New System.Windows.Forms.TextBox()
        Me.DGV_Sim = New System.Windows.Forms.DataGridView()
        Me.ICC_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Propietario_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vence_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Plan_Datos_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Compania_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelUsuario = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BTN_exportarUsuarios = New System.Windows.Forms.Button()
        Me.BTN_eliminarUsuarios = New System.Windows.Forms.Button()
        Me.BTN_editarUsuario = New System.Windows.Forms.Button()
        Me.BTN_agregarUsuario = New System.Windows.Forms.Button()
        Me.TB_buscarUsuario = New System.Windows.Forms.TextBox()
        Me.DGV_Usuarios = New System.Windows.Forms.DataGridView()
        Me.Nombre_U = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol_U = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelMarcaYModelos = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGV_Modelos = New System.Windows.Forms.DataGridView()
        Me.ModeloMyM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca2MyM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTN_agregarModelo = New System.Windows.Forms.Button()
        Me.BTN_agregarMarca = New System.Windows.Forms.Button()
        Me.DGV_Marcas = New System.Windows.Forms.DataGridView()
        Me.MarcaMyM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelCliente.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelActivos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGV_Activos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEquipos.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV_Equipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSIM.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DGV_Sim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUsuario.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DGV_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMarcaYModelos.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DGV_Modelos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Marcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Vensim Sans Tamil", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ActivosToolStripMenuItem, Me.EquiposToolStripMenuItem, Me.SIMToolStripMenuItem, Me.MarcasYModelosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.SallirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1091, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ActivosToolStripMenuItem
        '
        Me.ActivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformeDeActivosToolStripMenuItem})
        Me.ActivosToolStripMenuItem.Name = "ActivosToolStripMenuItem"
        Me.ActivosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ActivosToolStripMenuItem.Text = "Activos"
        '
        'InformeDeActivosToolStripMenuItem
        '
        Me.InformeDeActivosToolStripMenuItem.Name = "InformeDeActivosToolStripMenuItem"
        Me.InformeDeActivosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.InformeDeActivosToolStripMenuItem.Text = "Informe de activos"
        '
        'EquiposToolStripMenuItem
        '
        Me.EquiposToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaDeEquiposToolStripMenuItem})
        Me.EquiposToolStripMenuItem.Name = "EquiposToolStripMenuItem"
        Me.EquiposToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.EquiposToolStripMenuItem.Text = "Equipos"
        '
        'BajaDeEquiposToolStripMenuItem
        '
        Me.BajaDeEquiposToolStripMenuItem.Name = "BajaDeEquiposToolStripMenuItem"
        Me.BajaDeEquiposToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BajaDeEquiposToolStripMenuItem.Text = "Baja de equipos"
        '
        'SIMToolStripMenuItem
        '
        Me.SIMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MigracionesDeSIMToolStripMenuItem})
        Me.SIMToolStripMenuItem.Name = "SIMToolStripMenuItem"
        Me.SIMToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.SIMToolStripMenuItem.Text = "SIM"
        '
        'MigracionesDeSIMToolStripMenuItem
        '
        Me.MigracionesDeSIMToolStripMenuItem.Name = "MigracionesDeSIMToolStripMenuItem"
        Me.MigracionesDeSIMToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.MigracionesDeSIMToolStripMenuItem.Text = "Migraciones de SIM"
        '
        'MarcasYModelosToolStripMenuItem
        '
        Me.MarcasYModelosToolStripMenuItem.Name = "MarcasYModelosToolStripMenuItem"
        Me.MarcasYModelosToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.MarcasYModelosToolStripMenuItem.Text = "Marcas y modelos"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'SallirToolStripMenuItem
        '
        Me.SallirToolStripMenuItem.Name = "SallirToolStripMenuItem"
        Me.SallirToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.SallirToolStripMenuItem.Text = "Sallir"
        '
        'PanelCliente
        '
        Me.PanelCliente.BackColor = System.Drawing.Color.Transparent
        Me.PanelCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCliente.Controls.Add(Me.Panel1)
        Me.PanelCliente.Controls.Add(Me.Label1)
        Me.PanelCliente.Location = New System.Drawing.Point(0, 88)
        Me.PanelCliente.Name = "PanelCliente"
        Me.PanelCliente.Size = New System.Drawing.Size(1088, 614)
        Me.PanelCliente.TabIndex = 3
        Me.PanelCliente.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BTN_exportarClientes)
        Me.Panel1.Controls.Add(Me.BTN_asignarActivo_Clientes)
        Me.Panel1.Controls.Add(Me.BTN_eliminarClientes)
        Me.Panel1.Controls.Add(Me.BTN_editarClientes)
        Me.Panel1.Controls.Add(Me.BTN_agregarClientes)
        Me.Panel1.Controls.Add(Me.TB_buscarClientes)
        Me.Panel1.Controls.Add(Me.DGV_clientes)
        Me.Panel1.Location = New System.Drawing.Point(62, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 419)
        Me.Panel1.TabIndex = 5
        '
        'BTN_exportarClientes
        '
        Me.BTN_exportarClientes.Location = New System.Drawing.Point(52, 273)
        Me.BTN_exportarClientes.Name = "BTN_exportarClientes"
        Me.BTN_exportarClientes.Size = New System.Drawing.Size(109, 27)
        Me.BTN_exportarClientes.TabIndex = 15
        Me.BTN_exportarClientes.Text = "Exportar tabla"
        Me.BTN_exportarClientes.UseVisualStyleBackColor = True
        '
        'BTN_asignarActivo_Clientes
        '
        Me.BTN_asignarActivo_Clientes.Location = New System.Drawing.Point(801, 361)
        Me.BTN_asignarActivo_Clientes.Name = "BTN_asignarActivo_Clientes"
        Me.BTN_asignarActivo_Clientes.Size = New System.Drawing.Size(109, 27)
        Me.BTN_asignarActivo_Clientes.TabIndex = 14
        Me.BTN_asignarActivo_Clientes.Text = "Asignar activos"
        Me.BTN_asignarActivo_Clientes.UseVisualStyleBackColor = True
        '
        'BTN_eliminarClientes
        '
        Me.BTN_eliminarClientes.Location = New System.Drawing.Point(52, 227)
        Me.BTN_eliminarClientes.Name = "BTN_eliminarClientes"
        Me.BTN_eliminarClientes.Size = New System.Drawing.Size(109, 27)
        Me.BTN_eliminarClientes.TabIndex = 13
        Me.BTN_eliminarClientes.Text = "Eliminar"
        Me.BTN_eliminarClientes.UseVisualStyleBackColor = True
        '
        'BTN_editarClientes
        '
        Me.BTN_editarClientes.Location = New System.Drawing.Point(52, 182)
        Me.BTN_editarClientes.Name = "BTN_editarClientes"
        Me.BTN_editarClientes.Size = New System.Drawing.Size(109, 27)
        Me.BTN_editarClientes.TabIndex = 12
        Me.BTN_editarClientes.Text = "Editar"
        Me.BTN_editarClientes.UseVisualStyleBackColor = True
        '
        'BTN_agregarClientes
        '
        Me.BTN_agregarClientes.Location = New System.Drawing.Point(52, 134)
        Me.BTN_agregarClientes.Name = "BTN_agregarClientes"
        Me.BTN_agregarClientes.Size = New System.Drawing.Size(109, 27)
        Me.BTN_agregarClientes.TabIndex = 9
        Me.BTN_agregarClientes.Text = "Agregar"
        Me.BTN_agregarClientes.UseVisualStyleBackColor = True
        '
        'TB_buscarClientes
        '
        Me.TB_buscarClientes.Location = New System.Drawing.Point(680, 28)
        Me.TB_buscarClientes.Name = "TB_buscarClientes"
        Me.TB_buscarClientes.Size = New System.Drawing.Size(230, 20)
        Me.TB_buscarClientes.TabIndex = 11
        '
        'DGV_clientes
        '
        Me.DGV_clientes.AllowUserToAddRows = False
        Me.DGV_clientes.AllowUserToDeleteRows = False
        Me.DGV_clientes.AllowUserToResizeColumns = False
        Me.DGV_clientes.AllowUserToResizeRows = False
        Me.DGV_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_clientes.BackgroundColor = System.Drawing.Color.White
        Me.DGV_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre_C, Me.Telefono_C, Me.Correo_C})
        Me.DGV_clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_clientes.Location = New System.Drawing.Point(287, 61)
        Me.DGV_clientes.MultiSelect = False
        Me.DGV_clientes.Name = "DGV_clientes"
        Me.DGV_clientes.ReadOnly = True
        Me.DGV_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_clientes.Size = New System.Drawing.Size(623, 291)
        Me.DGV_clientes.StandardTab = True
        Me.DGV_clientes.TabIndex = 10
        '
        'Nombre_C
        '
        Me.Nombre_C.HeaderText = "Nombre"
        Me.Nombre_C.Name = "Nombre_C"
        Me.Nombre_C.ReadOnly = True
        '
        'Telefono_C
        '
        Me.Telefono_C.HeaderText = "Télefono"
        Me.Telefono_C.Name = "Telefono_C"
        Me.Telefono_C.ReadOnly = True
        '
        'Correo_C
        '
        Me.Correo_C.HeaderText = "Correo"
        Me.Correo_C.Name = "Correo_C"
        Me.Correo_C.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 79)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CLIENTES"
        '
        'PanelActivos
        '
        Me.PanelActivos.BackColor = System.Drawing.Color.Transparent
        Me.PanelActivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelActivos.Controls.Add(Me.Panel2)
        Me.PanelActivos.Controls.Add(Me.Label2)
        Me.PanelActivos.Location = New System.Drawing.Point(24, 71)
        Me.PanelActivos.Name = "PanelActivos"
        Me.PanelActivos.Size = New System.Drawing.Size(1088, 614)
        Me.PanelActivos.TabIndex = 4
        Me.PanelActivos.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BTN_exportarActivos)
        Me.Panel2.Controls.Add(Me.BTN_asignarEquipo_Activos)
        Me.Panel2.Controls.Add(Me.BTN_eliminarActivos)
        Me.Panel2.Controls.Add(Me.BTN_editarActivos)
        Me.Panel2.Controls.Add(Me.BTN_agregarActivos)
        Me.Panel2.Controls.Add(Me.TB_buscarActivos)
        Me.Panel2.Controls.Add(Me.DGV_Activos)
        Me.Panel2.Location = New System.Drawing.Point(62, 142)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(965, 419)
        Me.Panel2.TabIndex = 5
        '
        'BTN_exportarActivos
        '
        Me.BTN_exportarActivos.Location = New System.Drawing.Point(52, 277)
        Me.BTN_exportarActivos.Name = "BTN_exportarActivos"
        Me.BTN_exportarActivos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_exportarActivos.TabIndex = 16
        Me.BTN_exportarActivos.Text = "Exportar tabla"
        Me.BTN_exportarActivos.UseVisualStyleBackColor = True
        '
        'BTN_asignarEquipo_Activos
        '
        Me.BTN_asignarEquipo_Activos.Location = New System.Drawing.Point(801, 361)
        Me.BTN_asignarEquipo_Activos.Name = "BTN_asignarEquipo_Activos"
        Me.BTN_asignarEquipo_Activos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_asignarEquipo_Activos.TabIndex = 14
        Me.BTN_asignarEquipo_Activos.Text = "Asignar equipo"
        Me.BTN_asignarEquipo_Activos.UseVisualStyleBackColor = True
        '
        'BTN_eliminarActivos
        '
        Me.BTN_eliminarActivos.Location = New System.Drawing.Point(52, 227)
        Me.BTN_eliminarActivos.Name = "BTN_eliminarActivos"
        Me.BTN_eliminarActivos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_eliminarActivos.TabIndex = 13
        Me.BTN_eliminarActivos.Text = "Eliminar"
        Me.BTN_eliminarActivos.UseVisualStyleBackColor = True
        '
        'BTN_editarActivos
        '
        Me.BTN_editarActivos.Location = New System.Drawing.Point(52, 182)
        Me.BTN_editarActivos.Name = "BTN_editarActivos"
        Me.BTN_editarActivos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_editarActivos.TabIndex = 12
        Me.BTN_editarActivos.Text = "Editar"
        Me.BTN_editarActivos.UseVisualStyleBackColor = True
        '
        'BTN_agregarActivos
        '
        Me.BTN_agregarActivos.Location = New System.Drawing.Point(52, 134)
        Me.BTN_agregarActivos.Name = "BTN_agregarActivos"
        Me.BTN_agregarActivos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_agregarActivos.TabIndex = 9
        Me.BTN_agregarActivos.Text = "Agregar"
        Me.BTN_agregarActivos.UseVisualStyleBackColor = True
        '
        'TB_buscarActivos
        '
        Me.TB_buscarActivos.Location = New System.Drawing.Point(680, 28)
        Me.TB_buscarActivos.Name = "TB_buscarActivos"
        Me.TB_buscarActivos.Size = New System.Drawing.Size(230, 20)
        Me.TB_buscarActivos.TabIndex = 11
        '
        'DGV_Activos
        '
        Me.DGV_Activos.AllowUserToAddRows = False
        Me.DGV_Activos.AllowUserToDeleteRows = False
        Me.DGV_Activos.AllowUserToResizeColumns = False
        Me.DGV_Activos.AllowUserToResizeRows = False
        Me.DGV_Activos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Activos.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Activos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Activos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Placa_A, Me.Chasis_A, Me.Tipo_A, Me.Marca_A, Me.Modelo_A, Me.Color_A, Me.Anio_A})
        Me.DGV_Activos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Activos.Location = New System.Drawing.Point(287, 61)
        Me.DGV_Activos.MultiSelect = False
        Me.DGV_Activos.Name = "DGV_Activos"
        Me.DGV_Activos.ReadOnly = True
        Me.DGV_Activos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Activos.Size = New System.Drawing.Size(623, 294)
        Me.DGV_Activos.StandardTab = True
        Me.DGV_Activos.TabIndex = 10
        '
        'Placa_A
        '
        Me.Placa_A.HeaderText = "Placa"
        Me.Placa_A.Name = "Placa_A"
        Me.Placa_A.ReadOnly = True
        '
        'Chasis_A
        '
        Me.Chasis_A.HeaderText = "Chásis"
        Me.Chasis_A.Name = "Chasis_A"
        Me.Chasis_A.ReadOnly = True
        '
        'Tipo_A
        '
        Me.Tipo_A.HeaderText = "Tipo"
        Me.Tipo_A.Name = "Tipo_A"
        Me.Tipo_A.ReadOnly = True
        '
        'Marca_A
        '
        Me.Marca_A.HeaderText = "Marca"
        Me.Marca_A.Name = "Marca_A"
        Me.Marca_A.ReadOnly = True
        '
        'Modelo_A
        '
        Me.Modelo_A.HeaderText = "Modelo"
        Me.Modelo_A.Name = "Modelo_A"
        Me.Modelo_A.ReadOnly = True
        '
        'Color_A
        '
        Me.Color_A.HeaderText = "Color"
        Me.Color_A.Name = "Color_A"
        Me.Color_A.ReadOnly = True
        '
        'Anio_A
        '
        Me.Anio_A.HeaderText = "Año"
        Me.Anio_A.Name = "Anio_A"
        Me.Anio_A.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Vensim Sans Tamil", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 79)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ACTIVOS"
        '
        'PanelEquipos
        '
        Me.PanelEquipos.BackColor = System.Drawing.Color.Transparent
        Me.PanelEquipos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelEquipos.Controls.Add(Me.Panel3)
        Me.PanelEquipos.Controls.Add(Me.Label3)
        Me.PanelEquipos.Location = New System.Drawing.Point(48, 55)
        Me.PanelEquipos.Name = "PanelEquipos"
        Me.PanelEquipos.Size = New System.Drawing.Size(1088, 614)
        Me.PanelEquipos.TabIndex = 5
        Me.PanelEquipos.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BTN_exportarEquipos)
        Me.Panel3.Controls.Add(Me.BTN_asignarSIM_Equipos)
        Me.Panel3.Controls.Add(Me.BTN_bajaEquipos)
        Me.Panel3.Controls.Add(Me.BTN_agregarEquipos)
        Me.Panel3.Controls.Add(Me.TB_buscarEquipos)
        Me.Panel3.Controls.Add(Me.DGV_Equipos)
        Me.Panel3.Location = New System.Drawing.Point(62, 142)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(965, 419)
        Me.Panel3.TabIndex = 0
        '
        'BTN_exportarEquipos
        '
        Me.BTN_exportarEquipos.Location = New System.Drawing.Point(52, 231)
        Me.BTN_exportarEquipos.Name = "BTN_exportarEquipos"
        Me.BTN_exportarEquipos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_exportarEquipos.TabIndex = 16
        Me.BTN_exportarEquipos.Text = "Exportar tabla"
        Me.BTN_exportarEquipos.UseVisualStyleBackColor = True
        '
        'BTN_asignarSIM_Equipos
        '
        Me.BTN_asignarSIM_Equipos.Location = New System.Drawing.Point(801, 361)
        Me.BTN_asignarSIM_Equipos.Name = "BTN_asignarSIM_Equipos"
        Me.BTN_asignarSIM_Equipos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_asignarSIM_Equipos.TabIndex = 13
        Me.BTN_asignarSIM_Equipos.Text = "Asignar SIM"
        Me.BTN_asignarSIM_Equipos.UseVisualStyleBackColor = True
        '
        'BTN_bajaEquipos
        '
        Me.BTN_bajaEquipos.Location = New System.Drawing.Point(52, 182)
        Me.BTN_bajaEquipos.Name = "BTN_bajaEquipos"
        Me.BTN_bajaEquipos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_bajaEquipos.TabIndex = 12
        Me.BTN_bajaEquipos.Text = "Dar de baja"
        Me.BTN_bajaEquipos.UseVisualStyleBackColor = True
        '
        'BTN_agregarEquipos
        '
        Me.BTN_agregarEquipos.Location = New System.Drawing.Point(52, 134)
        Me.BTN_agregarEquipos.Name = "BTN_agregarEquipos"
        Me.BTN_agregarEquipos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_agregarEquipos.TabIndex = 9
        Me.BTN_agregarEquipos.Text = "Agregar"
        Me.BTN_agregarEquipos.UseVisualStyleBackColor = True
        '
        'TB_buscarEquipos
        '
        Me.TB_buscarEquipos.Location = New System.Drawing.Point(680, 28)
        Me.TB_buscarEquipos.Name = "TB_buscarEquipos"
        Me.TB_buscarEquipos.Size = New System.Drawing.Size(230, 20)
        Me.TB_buscarEquipos.TabIndex = 11
        '
        'DGV_Equipos
        '
        Me.DGV_Equipos.AllowUserToAddRows = False
        Me.DGV_Equipos.AllowUserToDeleteRows = False
        Me.DGV_Equipos.AllowUserToResizeColumns = False
        Me.DGV_Equipos.AllowUserToResizeRows = False
        Me.DGV_Equipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Equipos.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Equipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IMEI_E, Me.Modelo_E, Me.Marca_E})
        Me.DGV_Equipos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Equipos.Location = New System.Drawing.Point(287, 61)
        Me.DGV_Equipos.MultiSelect = False
        Me.DGV_Equipos.Name = "DGV_Equipos"
        Me.DGV_Equipos.ReadOnly = True
        Me.DGV_Equipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Equipos.Size = New System.Drawing.Size(623, 291)
        Me.DGV_Equipos.StandardTab = True
        Me.DGV_Equipos.TabIndex = 10
        '
        'IMEI_E
        '
        Me.IMEI_E.HeaderText = "IMEI"
        Me.IMEI_E.Name = "IMEI_E"
        Me.IMEI_E.ReadOnly = True
        '
        'Modelo_E
        '
        Me.Modelo_E.HeaderText = "Modelo"
        Me.Modelo_E.Name = "Modelo_E"
        Me.Modelo_E.ReadOnly = True
        '
        'Marca_E
        '
        Me.Marca_E.HeaderText = "Marca"
        Me.Marca_E.Name = "Marca_E"
        Me.Marca_E.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Vensim Sans Tamil", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(324, 79)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "EQUIPOS"
        '
        'PanelSIM
        '
        Me.PanelSIM.BackColor = System.Drawing.Color.Transparent
        Me.PanelSIM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSIM.Controls.Add(Me.Panel4)
        Me.PanelSIM.Controls.Add(Me.Label4)
        Me.PanelSIM.Location = New System.Drawing.Point(62, 42)
        Me.PanelSIM.Name = "PanelSIM"
        Me.PanelSIM.Size = New System.Drawing.Size(1088, 614)
        Me.PanelSIM.TabIndex = 6
        Me.PanelSIM.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BTN_exportarSim)
        Me.Panel4.Controls.Add(Me.BTN_migrarSim)
        Me.Panel4.Controls.Add(Me.BTN_eliminarSim)
        Me.Panel4.Controls.Add(Me.BTN_editarSIM)
        Me.Panel4.Controls.Add(Me.BTN_agregarSIM)
        Me.Panel4.Controls.Add(Me.TB_buscarSim)
        Me.Panel4.Controls.Add(Me.DGV_Sim)
        Me.Panel4.Location = New System.Drawing.Point(62, 142)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(965, 419)
        Me.Panel4.TabIndex = 0
        '
        'BTN_exportarSim
        '
        Me.BTN_exportarSim.Location = New System.Drawing.Point(52, 277)
        Me.BTN_exportarSim.Name = "BTN_exportarSim"
        Me.BTN_exportarSim.Size = New System.Drawing.Size(109, 27)
        Me.BTN_exportarSim.TabIndex = 16
        Me.BTN_exportarSim.Text = "Exportar tabla"
        Me.BTN_exportarSim.UseVisualStyleBackColor = True
        '
        'BTN_migrarSim
        '
        Me.BTN_migrarSim.Location = New System.Drawing.Point(801, 361)
        Me.BTN_migrarSim.Name = "BTN_migrarSim"
        Me.BTN_migrarSim.Size = New System.Drawing.Size(109, 27)
        Me.BTN_migrarSim.TabIndex = 14
        Me.BTN_migrarSim.Text = "Migrar SIM"
        Me.BTN_migrarSim.UseVisualStyleBackColor = True
        '
        'BTN_eliminarSim
        '
        Me.BTN_eliminarSim.Location = New System.Drawing.Point(52, 227)
        Me.BTN_eliminarSim.Name = "BTN_eliminarSim"
        Me.BTN_eliminarSim.Size = New System.Drawing.Size(109, 27)
        Me.BTN_eliminarSim.TabIndex = 13
        Me.BTN_eliminarSim.Text = "Eliminar"
        Me.BTN_eliminarSim.UseVisualStyleBackColor = True
        '
        'BTN_editarSIM
        '
        Me.BTN_editarSIM.Location = New System.Drawing.Point(52, 182)
        Me.BTN_editarSIM.Name = "BTN_editarSIM"
        Me.BTN_editarSIM.Size = New System.Drawing.Size(109, 27)
        Me.BTN_editarSIM.TabIndex = 12
        Me.BTN_editarSIM.Text = "Editar"
        Me.BTN_editarSIM.UseVisualStyleBackColor = True
        '
        'BTN_agregarSIM
        '
        Me.BTN_agregarSIM.Location = New System.Drawing.Point(52, 134)
        Me.BTN_agregarSIM.Name = "BTN_agregarSIM"
        Me.BTN_agregarSIM.Size = New System.Drawing.Size(109, 27)
        Me.BTN_agregarSIM.TabIndex = 9
        Me.BTN_agregarSIM.Text = "Agregar"
        Me.BTN_agregarSIM.UseVisualStyleBackColor = True
        '
        'TB_buscarSim
        '
        Me.TB_buscarSim.Location = New System.Drawing.Point(680, 28)
        Me.TB_buscarSim.Name = "TB_buscarSim"
        Me.TB_buscarSim.Size = New System.Drawing.Size(230, 20)
        Me.TB_buscarSim.TabIndex = 11
        '
        'DGV_Sim
        '
        Me.DGV_Sim.AllowUserToAddRows = False
        Me.DGV_Sim.AllowUserToDeleteRows = False
        Me.DGV_Sim.AllowUserToResizeRows = False
        Me.DGV_Sim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Sim.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Sim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Sim.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ICC_S, Me.Numero_S, Me.Propietario_S, Me.Vence_S, Me.Plan_Datos_S, Me.Compania_S})
        Me.DGV_Sim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Sim.Location = New System.Drawing.Point(287, 61)
        Me.DGV_Sim.MultiSelect = False
        Me.DGV_Sim.Name = "DGV_Sim"
        Me.DGV_Sim.ReadOnly = True
        Me.DGV_Sim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Sim.Size = New System.Drawing.Size(623, 288)
        Me.DGV_Sim.StandardTab = True
        Me.DGV_Sim.TabIndex = 10
        '
        'ICC_S
        '
        Me.ICC_S.HeaderText = "ICC"
        Me.ICC_S.Name = "ICC_S"
        Me.ICC_S.ReadOnly = True
        '
        'Numero_S
        '
        Me.Numero_S.HeaderText = "Numero"
        Me.Numero_S.Name = "Numero_S"
        Me.Numero_S.ReadOnly = True
        '
        'Propietario_S
        '
        Me.Propietario_S.HeaderText = "Propietario"
        Me.Propietario_S.Name = "Propietario_S"
        Me.Propietario_S.ReadOnly = True
        '
        'Vence_S
        '
        Me.Vence_S.HeaderText = "Vence"
        Me.Vence_S.Name = "Vence_S"
        Me.Vence_S.ReadOnly = True
        '
        'Plan_Datos_S
        '
        Me.Plan_Datos_S.HeaderText = "Plan de datos"
        Me.Plan_Datos_S.Name = "Plan_Datos_S"
        Me.Plan_Datos_S.ReadOnly = True
        '
        'Compania_S
        '
        Me.Compania_S.HeaderText = "Compañia"
        Me.Compania_S.Name = "Compania_S"
        Me.Compania_S.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Vensim Sans Tamil", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 79)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SIM"
        '
        'PanelUsuario
        '
        Me.PanelUsuario.BackColor = System.Drawing.Color.Transparent
        Me.PanelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelUsuario.Controls.Add(Me.Panel5)
        Me.PanelUsuario.Controls.Add(Me.Label5)
        Me.PanelUsuario.Location = New System.Drawing.Point(87, 32)
        Me.PanelUsuario.Name = "PanelUsuario"
        Me.PanelUsuario.Size = New System.Drawing.Size(1088, 614)
        Me.PanelUsuario.TabIndex = 7
        Me.PanelUsuario.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.BTN_exportarUsuarios)
        Me.Panel5.Controls.Add(Me.BTN_eliminarUsuarios)
        Me.Panel5.Controls.Add(Me.BTN_editarUsuario)
        Me.Panel5.Controls.Add(Me.BTN_agregarUsuario)
        Me.Panel5.Controls.Add(Me.TB_buscarUsuario)
        Me.Panel5.Controls.Add(Me.DGV_Usuarios)
        Me.Panel5.Location = New System.Drawing.Point(62, 142)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(965, 419)
        Me.Panel5.TabIndex = 0
        '
        'BTN_exportarUsuarios
        '
        Me.BTN_exportarUsuarios.Location = New System.Drawing.Point(52, 271)
        Me.BTN_exportarUsuarios.Name = "BTN_exportarUsuarios"
        Me.BTN_exportarUsuarios.Size = New System.Drawing.Size(109, 27)
        Me.BTN_exportarUsuarios.TabIndex = 16
        Me.BTN_exportarUsuarios.Text = "Exportar tabla"
        Me.BTN_exportarUsuarios.UseVisualStyleBackColor = True
        '
        'BTN_eliminarUsuarios
        '
        Me.BTN_eliminarUsuarios.Location = New System.Drawing.Point(52, 227)
        Me.BTN_eliminarUsuarios.Name = "BTN_eliminarUsuarios"
        Me.BTN_eliminarUsuarios.Size = New System.Drawing.Size(109, 27)
        Me.BTN_eliminarUsuarios.TabIndex = 12
        Me.BTN_eliminarUsuarios.Text = "Eliminar"
        Me.BTN_eliminarUsuarios.UseVisualStyleBackColor = True
        '
        'BTN_editarUsuario
        '
        Me.BTN_editarUsuario.Location = New System.Drawing.Point(52, 182)
        Me.BTN_editarUsuario.Name = "BTN_editarUsuario"
        Me.BTN_editarUsuario.Size = New System.Drawing.Size(109, 27)
        Me.BTN_editarUsuario.TabIndex = 11
        Me.BTN_editarUsuario.Text = "Editar"
        Me.BTN_editarUsuario.UseVisualStyleBackColor = True
        '
        'BTN_agregarUsuario
        '
        Me.BTN_agregarUsuario.Location = New System.Drawing.Point(52, 134)
        Me.BTN_agregarUsuario.Name = "BTN_agregarUsuario"
        Me.BTN_agregarUsuario.Size = New System.Drawing.Size(109, 27)
        Me.BTN_agregarUsuario.TabIndex = 8
        Me.BTN_agregarUsuario.Text = "Agregar"
        Me.BTN_agregarUsuario.UseVisualStyleBackColor = True
        '
        'TB_buscarUsuario
        '
        Me.TB_buscarUsuario.Location = New System.Drawing.Point(680, 28)
        Me.TB_buscarUsuario.Name = "TB_buscarUsuario"
        Me.TB_buscarUsuario.Size = New System.Drawing.Size(230, 20)
        Me.TB_buscarUsuario.TabIndex = 10
        '
        'DGV_Usuarios
        '
        Me.DGV_Usuarios.AllowUserToAddRows = False
        Me.DGV_Usuarios.AllowUserToDeleteRows = False
        Me.DGV_Usuarios.AllowUserToResizeColumns = False
        Me.DGV_Usuarios.AllowUserToResizeRows = False
        Me.DGV_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Usuarios.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre_U, Me.Rol_U})
        Me.DGV_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Usuarios.Location = New System.Drawing.Point(287, 61)
        Me.DGV_Usuarios.MultiSelect = False
        Me.DGV_Usuarios.Name = "DGV_Usuarios"
        Me.DGV_Usuarios.ReadOnly = True
        Me.DGV_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Usuarios.Size = New System.Drawing.Size(623, 308)
        Me.DGV_Usuarios.StandardTab = True
        Me.DGV_Usuarios.TabIndex = 9
        '
        'Nombre_U
        '
        Me.Nombre_U.HeaderText = "Nombre"
        Me.Nombre_U.Name = "Nombre_U"
        Me.Nombre_U.ReadOnly = True
        '
        'Rol_U
        '
        Me.Rol_U.HeaderText = "Rol"
        Me.Rol_U.Name = "Rol_U"
        Me.Rol_U.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Vensim Sans Tamil", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(366, 79)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "USUARIOS"
        '
        'PanelMarcaYModelos
        '
        Me.PanelMarcaYModelos.BackColor = System.Drawing.Color.Transparent
        Me.PanelMarcaYModelos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMarcaYModelos.Controls.Add(Me.Panel7)
        Me.PanelMarcaYModelos.Controls.Add(Me.Label6)
        Me.PanelMarcaYModelos.Location = New System.Drawing.Point(102, 19)
        Me.PanelMarcaYModelos.Name = "PanelMarcaYModelos"
        Me.PanelMarcaYModelos.Size = New System.Drawing.Size(1088, 614)
        Me.PanelMarcaYModelos.TabIndex = 8
        Me.PanelMarcaYModelos.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.DGV_Modelos)
        Me.Panel7.Controls.Add(Me.BTN_agregarModelo)
        Me.Panel7.Controls.Add(Me.BTN_agregarMarca)
        Me.Panel7.Controls.Add(Me.DGV_Marcas)
        Me.Panel7.Location = New System.Drawing.Point(62, 142)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(965, 419)
        Me.Panel7.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(540, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Modelos:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(284, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Marcas:"
        '
        'DGV_Modelos
        '
        Me.DGV_Modelos.AllowUserToAddRows = False
        Me.DGV_Modelos.AllowUserToDeleteRows = False
        Me.DGV_Modelos.AllowUserToResizeColumns = False
        Me.DGV_Modelos.AllowUserToResizeRows = False
        Me.DGV_Modelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Modelos.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Modelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Modelos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ModeloMyM, Me.Marca2MyM})
        Me.DGV_Modelos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Modelos.Location = New System.Drawing.Point(543, 80)
        Me.DGV_Modelos.MultiSelect = False
        Me.DGV_Modelos.Name = "DGV_Modelos"
        Me.DGV_Modelos.ReadOnly = True
        Me.DGV_Modelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Modelos.Size = New System.Drawing.Size(367, 289)
        Me.DGV_Modelos.StandardTab = True
        Me.DGV_Modelos.TabIndex = 13
        '
        'ModeloMyM
        '
        Me.ModeloMyM.HeaderText = "Modelo"
        Me.ModeloMyM.Name = "ModeloMyM"
        Me.ModeloMyM.ReadOnly = True
        '
        'Marca2MyM
        '
        Me.Marca2MyM.HeaderText = "Marca"
        Me.Marca2MyM.Name = "Marca2MyM"
        Me.Marca2MyM.ReadOnly = True
        '
        'BTN_agregarModelo
        '
        Me.BTN_agregarModelo.Location = New System.Drawing.Point(52, 182)
        Me.BTN_agregarModelo.Name = "BTN_agregarModelo"
        Me.BTN_agregarModelo.Size = New System.Drawing.Size(109, 27)
        Me.BTN_agregarModelo.TabIndex = 11
        Me.BTN_agregarModelo.Text = "Agregar modelo"
        Me.BTN_agregarModelo.UseVisualStyleBackColor = True
        '
        'BTN_agregarMarca
        '
        Me.BTN_agregarMarca.Location = New System.Drawing.Point(52, 134)
        Me.BTN_agregarMarca.Name = "BTN_agregarMarca"
        Me.BTN_agregarMarca.Size = New System.Drawing.Size(109, 27)
        Me.BTN_agregarMarca.TabIndex = 8
        Me.BTN_agregarMarca.Text = "Agregar marca"
        Me.BTN_agregarMarca.UseVisualStyleBackColor = True
        '
        'DGV_Marcas
        '
        Me.DGV_Marcas.AllowUserToAddRows = False
        Me.DGV_Marcas.AllowUserToDeleteRows = False
        Me.DGV_Marcas.AllowUserToResizeColumns = False
        Me.DGV_Marcas.AllowUserToResizeRows = False
        Me.DGV_Marcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Marcas.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Marcas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MarcaMyM})
        Me.DGV_Marcas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Marcas.Location = New System.Drawing.Point(287, 80)
        Me.DGV_Marcas.MultiSelect = False
        Me.DGV_Marcas.Name = "DGV_Marcas"
        Me.DGV_Marcas.ReadOnly = True
        Me.DGV_Marcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Marcas.Size = New System.Drawing.Size(236, 289)
        Me.DGV_Marcas.StandardTab = True
        Me.DGV_Marcas.TabIndex = 9
        '
        'MarcaMyM
        '
        Me.MarcaMyM.HeaderText = "Marca"
        Me.MarcaMyM.Name = "MarcaMyM"
        Me.MarcaMyM.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Vensim Sans Tamil", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(696, 79)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "MARCAS Y MODELOS"
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1091, 671)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelSIM)
        Me.Controls.Add(Me.PanelEquipos)
        Me.Controls.Add(Me.PanelUsuario)
        Me.Controls.Add(Me.PanelActivos)
        Me.Controls.Add(Me.PanelCliente)
        Me.Controls.Add(Me.PanelMarcaYModelos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormAdmin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelCliente.ResumeLayout(False)
        Me.PanelCliente.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelActivos.ResumeLayout(False)
        Me.PanelActivos.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGV_Activos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEquipos.ResumeLayout(False)
        Me.PanelEquipos.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGV_Equipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSIM.ResumeLayout(False)
        Me.PanelSIM.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DGV_Sim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DGV_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMarcaYModelos.ResumeLayout(False)
        Me.PanelMarcaYModelos.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.DGV_Modelos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Marcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaDeEquiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SIMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MigracionesDeSIMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SallirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelCliente As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelActivos As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelEquipos As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelSIM As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelUsuario As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_asignarActivo_Clientes As Button
    Friend WithEvents BTN_eliminarClientes As Button
    Friend WithEvents BTN_editarClientes As Button
    Friend WithEvents BTN_agregarClientes As Button
    Friend WithEvents TB_buscarClientes As TextBox
    Friend WithEvents DGV_clientes As DataGridView
    Friend WithEvents Nombre_C As DataGridViewTextBoxColumn
    Friend WithEvents Telefono_C As DataGridViewTextBoxColumn
    Friend WithEvents Correo_C As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTN_asignarEquipo_Activos As Button
    Friend WithEvents BTN_eliminarActivos As Button
    Friend WithEvents BTN_editarActivos As Button
    Friend WithEvents BTN_agregarActivos As Button
    Friend WithEvents TB_buscarActivos As TextBox
    Friend WithEvents DGV_Activos As DataGridView
    Friend WithEvents Placa_A As DataGridViewTextBoxColumn
    Friend WithEvents Chasis_A As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_A As DataGridViewTextBoxColumn
    Friend WithEvents Marca_A As DataGridViewTextBoxColumn
    Friend WithEvents Modelo_A As DataGridViewTextBoxColumn
    Friend WithEvents Color_A As DataGridViewTextBoxColumn
    Friend WithEvents Anio_A As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTN_asignarSIM_Equipos As Button
    Friend WithEvents BTN_bajaEquipos As Button
    Friend WithEvents BTN_agregarEquipos As Button
    Friend WithEvents TB_buscarEquipos As TextBox
    Friend WithEvents DGV_Equipos As DataGridView
    Friend WithEvents IMEI_E As DataGridViewTextBoxColumn
    Friend WithEvents Modelo_E As DataGridViewTextBoxColumn
    Friend WithEvents Marca_E As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BTN_migrarSim As Button
    Friend WithEvents BTN_eliminarSim As Button
    Friend WithEvents BTN_editarSIM As Button
    Friend WithEvents BTN_agregarSIM As Button
    Friend WithEvents TB_buscarSim As TextBox
    Friend WithEvents DGV_Sim As DataGridView
    Friend WithEvents ICC_S As DataGridViewTextBoxColumn
    Friend WithEvents Numero_S As DataGridViewTextBoxColumn
    Friend WithEvents Propietario_S As DataGridViewTextBoxColumn
    Friend WithEvents Vence_S As DataGridViewTextBoxColumn
    Friend WithEvents Plan_Datos_S As DataGridViewTextBoxColumn
    Friend WithEvents Compania_S As DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BTN_eliminarUsuarios As Button
    Friend WithEvents BTN_editarUsuario As Button
    Friend WithEvents BTN_agregarUsuario As Button
    Friend WithEvents TB_buscarUsuario As TextBox
    Friend WithEvents DGV_Usuarios As DataGridView
    Friend WithEvents Nombre_U As DataGridViewTextBoxColumn
    Friend WithEvents Rol_U As DataGridViewTextBoxColumn
    Friend WithEvents InformeDeActivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelMarcaYModelos As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents BTN_agregarModelo As Button
    Friend WithEvents BTN_agregarMarca As Button
    Friend WithEvents DGV_Marcas As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents MarcasYModelosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGV_Modelos As DataGridView
    Friend WithEvents MarcaMyM As DataGridViewTextBoxColumn
    Friend WithEvents ModeloMyM As DataGridViewTextBoxColumn
    Friend WithEvents Marca2MyM As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BTN_exportarClientes As Button
    Friend WithEvents BTN_exportarActivos As Button
    Friend WithEvents BTN_exportarEquipos As Button
    Friend WithEvents BTN_exportarSim As Button
    Friend WithEvents BTN_exportarUsuarios As Button
End Class
