<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignarEquipo
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DGV_equipos = New System.Windows.Forms.DataGridView()
        Me.imeiEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeroEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LB_equipoSeleccionado = New System.Windows.Forms.Label()
        Me.BTN_seleccionarEquipo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_buscarEquipos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGV_Activos = New System.Windows.Forms.DataGridView()
        Me.PlacaActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChasisActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LB_activoSeleccionado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_seleccionarActivo = New System.Windows.Forms.Button()
        Me.TB_buscarActivos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTN_desasignarEquipo = New System.Windows.Forms.Button()
        Me.DGV_asignaciones = New System.Windows.Forms.DataGridView()
        Me.PlacaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMEIAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB_buscarAsignaciones = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CB_adquisicion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_plataforma = New System.Windows.Forms.ComboBox()
        Me.BTN_asignar = New System.Windows.Forms.Button()
        Me.BTN_regresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_exportar = New System.Windows.Forms.Button()
        Me.Panel6.SuspendLayout()
        CType(Me.DGV_equipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Activos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV_asignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.DGV_equipos)
        Me.Panel6.Controls.Add(Me.LB_equipoSeleccionado)
        Me.Panel6.Controls.Add(Me.BTN_seleccionarEquipo)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.TB_buscarEquipos)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(516, 18)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(475, 283)
        Me.Panel6.TabIndex = 32
        '
        'DGV_equipos
        '
        Me.DGV_equipos.AllowUserToAddRows = False
        Me.DGV_equipos.AllowUserToDeleteRows = False
        Me.DGV_equipos.AllowUserToResizeRows = False
        Me.DGV_equipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_equipos.BackgroundColor = System.Drawing.Color.White
        Me.DGV_equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_equipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.imeiEquipo, Me.ModeloEquipo, Me.MarcaEquipo, Me.numeroEquipo})
        Me.DGV_equipos.Location = New System.Drawing.Point(19, 41)
        Me.DGV_equipos.Name = "DGV_equipos"
        Me.DGV_equipos.ReadOnly = True
        Me.DGV_equipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_equipos.Size = New System.Drawing.Size(440, 202)
        Me.DGV_equipos.TabIndex = 33
        '
        'imeiEquipo
        '
        Me.imeiEquipo.HeaderText = "IMEI"
        Me.imeiEquipo.Name = "imeiEquipo"
        Me.imeiEquipo.ReadOnly = True
        '
        'ModeloEquipo
        '
        Me.ModeloEquipo.HeaderText = "Modelo"
        Me.ModeloEquipo.Name = "ModeloEquipo"
        Me.ModeloEquipo.ReadOnly = True
        '
        'MarcaEquipo
        '
        Me.MarcaEquipo.HeaderText = "Marca"
        Me.MarcaEquipo.Name = "MarcaEquipo"
        Me.MarcaEquipo.ReadOnly = True
        '
        'numeroEquipo
        '
        Me.numeroEquipo.HeaderText = "Numero SIM"
        Me.numeroEquipo.Name = "numeroEquipo"
        Me.numeroEquipo.ReadOnly = True
        '
        'LB_equipoSeleccionado
        '
        Me.LB_equipoSeleccionado.AutoSize = True
        Me.LB_equipoSeleccionado.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_equipoSeleccionado.Location = New System.Drawing.Point(159, 253)
        Me.LB_equipoSeleccionado.Name = "LB_equipoSeleccionado"
        Me.LB_equipoSeleccionado.Size = New System.Drawing.Size(104, 15)
        Me.LB_equipoSeleccionado.TabIndex = 32
        Me.LB_equipoSeleccionado.Text = "No seleccionado"
        '
        'BTN_seleccionarEquipo
        '
        Me.BTN_seleccionarEquipo.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_seleccionarEquipo.Location = New System.Drawing.Point(368, 249)
        Me.BTN_seleccionarEquipo.Name = "BTN_seleccionarEquipo"
        Me.BTN_seleccionarEquipo.Size = New System.Drawing.Size(91, 23)
        Me.BTN_seleccionarEquipo.TabIndex = 31
        Me.BTN_seleccionarEquipo.Text = "Seleccionar"
        Me.BTN_seleccionarEquipo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 15)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Equipo seleccionado:"
        '
        'TB_buscarEquipos
        '
        Me.TB_buscarEquipos.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_buscarEquipos.Location = New System.Drawing.Point(291, 8)
        Me.TB_buscarEquipos.Name = "TB_buscarEquipos"
        Me.TB_buscarEquipos.Size = New System.Drawing.Size(168, 22)
        Me.TB_buscarEquipos.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Equipos"
        '
        'DGV_Activos
        '
        Me.DGV_Activos.AllowUserToAddRows = False
        Me.DGV_Activos.AllowUserToDeleteRows = False
        Me.DGV_Activos.AllowUserToResizeRows = False
        Me.DGV_Activos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Activos.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Activos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Activos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PlacaActivo, Me.ChasisActivo, Me.MarcaActivo})
        Me.DGV_Activos.Location = New System.Drawing.Point(19, 41)
        Me.DGV_Activos.Name = "DGV_Activos"
        Me.DGV_Activos.ReadOnly = True
        Me.DGV_Activos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Activos.Size = New System.Drawing.Size(440, 202)
        Me.DGV_Activos.TabIndex = 30
        '
        'PlacaActivo
        '
        Me.PlacaActivo.HeaderText = "Placa"
        Me.PlacaActivo.Name = "PlacaActivo"
        Me.PlacaActivo.ReadOnly = True
        '
        'ChasisActivo
        '
        Me.ChasisActivo.HeaderText = "Chásis"
        Me.ChasisActivo.Name = "ChasisActivo"
        Me.ChasisActivo.ReadOnly = True
        '
        'MarcaActivo
        '
        Me.MarcaActivo.HeaderText = "Marca"
        Me.MarcaActivo.Name = "MarcaActivo"
        Me.MarcaActivo.ReadOnly = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.LB_activoSeleccionado)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.BTN_seleccionarActivo)
        Me.Panel5.Controls.Add(Me.TB_buscarActivos)
        Me.Panel5.Controls.Add(Me.DGV_Activos)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(22, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(475, 283)
        Me.Panel5.TabIndex = 31
        '
        'LB_activoSeleccionado
        '
        Me.LB_activoSeleccionado.AutoSize = True
        Me.LB_activoSeleccionado.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_activoSeleccionado.Location = New System.Drawing.Point(158, 253)
        Me.LB_activoSeleccionado.Name = "LB_activoSeleccionado"
        Me.LB_activoSeleccionado.Size = New System.Drawing.Size(104, 15)
        Me.LB_activoSeleccionado.TabIndex = 30
        Me.LB_activoSeleccionado.Text = "No seleccionado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Activo seleccionado:"
        '
        'BTN_seleccionarActivo
        '
        Me.BTN_seleccionarActivo.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_seleccionarActivo.Location = New System.Drawing.Point(368, 249)
        Me.BTN_seleccionarActivo.Name = "BTN_seleccionarActivo"
        Me.BTN_seleccionarActivo.Size = New System.Drawing.Size(91, 23)
        Me.BTN_seleccionarActivo.TabIndex = 29
        Me.BTN_seleccionarActivo.Text = "Seleccionar"
        Me.BTN_seleccionarActivo.UseVisualStyleBackColor = True
        '
        'TB_buscarActivos
        '
        Me.TB_buscarActivos.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_buscarActivos.Location = New System.Drawing.Point(291, 8)
        Me.TB_buscarActivos.Name = "TB_buscarActivos"
        Me.TB_buscarActivos.Size = New System.Drawing.Size(168, 22)
        Me.TB_buscarActivos.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Activos"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BTN_exportar)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.BTN_desasignarEquipo)
        Me.Panel3.Controls.Add(Me.DGV_asignaciones)
        Me.Panel3.Controls.Add(Me.TB_buscarAsignaciones)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(35, 442)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1020, 307)
        Me.Panel3.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Vensim Sans Tamil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 17)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Equipos asignados a activos:"
        '
        'BTN_desasignarEquipo
        '
        Me.BTN_desasignarEquipo.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_desasignarEquipo.Location = New System.Drawing.Point(793, 257)
        Me.BTN_desasignarEquipo.Name = "BTN_desasignarEquipo"
        Me.BTN_desasignarEquipo.Size = New System.Drawing.Size(127, 31)
        Me.BTN_desasignarEquipo.TabIndex = 35
        Me.BTN_desasignarEquipo.Text = "Desasignar equipo"
        Me.BTN_desasignarEquipo.UseVisualStyleBackColor = True
        '
        'DGV_asignaciones
        '
        Me.DGV_asignaciones.AllowUserToAddRows = False
        Me.DGV_asignaciones.AllowUserToDeleteRows = False
        Me.DGV_asignaciones.AllowUserToResizeRows = False
        Me.DGV_asignaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_asignaciones.BackgroundColor = System.Drawing.Color.White
        Me.DGV_asignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_asignaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PlacaAsignacion, Me.NumeroAsignacion, Me.IMEIAsignacion, Me.ModeloAsignacion, Me.MarcaAsignacion, Me.FechaAsignacion})
        Me.DGV_asignaciones.Location = New System.Drawing.Point(87, 43)
        Me.DGV_asignaciones.Name = "DGV_asignaciones"
        Me.DGV_asignaciones.ReadOnly = True
        Me.DGV_asignaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_asignaciones.Size = New System.Drawing.Size(833, 208)
        Me.DGV_asignaciones.TabIndex = 34
        '
        'PlacaAsignacion
        '
        Me.PlacaAsignacion.HeaderText = "Placa (Activo)"
        Me.PlacaAsignacion.Name = "PlacaAsignacion"
        Me.PlacaAsignacion.ReadOnly = True
        '
        'NumeroAsignacion
        '
        Me.NumeroAsignacion.HeaderText = "Numero"
        Me.NumeroAsignacion.Name = "NumeroAsignacion"
        Me.NumeroAsignacion.ReadOnly = True
        '
        'IMEIAsignacion
        '
        Me.IMEIAsignacion.HeaderText = "IMEI"
        Me.IMEIAsignacion.Name = "IMEIAsignacion"
        Me.IMEIAsignacion.ReadOnly = True
        '
        'ModeloAsignacion
        '
        Me.ModeloAsignacion.HeaderText = "Modelo"
        Me.ModeloAsignacion.Name = "ModeloAsignacion"
        Me.ModeloAsignacion.ReadOnly = True
        '
        'MarcaAsignacion
        '
        Me.MarcaAsignacion.HeaderText = "Marca"
        Me.MarcaAsignacion.Name = "MarcaAsignacion"
        Me.MarcaAsignacion.ReadOnly = True
        '
        'FechaAsignacion
        '
        Me.FechaAsignacion.HeaderText = "Fecha"
        Me.FechaAsignacion.Name = "FechaAsignacion"
        Me.FechaAsignacion.ReadOnly = True
        '
        'TB_buscarAsignaciones
        '
        Me.TB_buscarAsignaciones.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_buscarAsignaciones.Location = New System.Drawing.Point(752, 13)
        Me.TB_buscarAsignaciones.Name = "TB_buscarAsignaciones"
        Me.TB_buscarAsignaciones.Size = New System.Drawing.Size(168, 22)
        Me.TB_buscarAsignaciones.TabIndex = 33
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(0, 311)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(960, 227)
        Me.Panel4.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CB_adquisicion)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CB_plataforma)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.BTN_asignar)
        Me.Panel1.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(35, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 356)
        Me.Panel1.TabIndex = 27
        '
        'CB_adquisicion
        '
        Me.CB_adquisicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_adquisicion.Font = New System.Drawing.Font("Vensim Sans Tamil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_adquisicion.FormattingEnabled = True
        Me.CB_adquisicion.Items.AddRange(New Object() {"VENTA", "RENTA"})
        Me.CB_adquisicion.Location = New System.Drawing.Point(571, 320)
        Me.CB_adquisicion.Name = "CB_adquisicion"
        Me.CB_adquisicion.Size = New System.Drawing.Size(206, 23)
        Me.CB_adquisicion.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(448, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 15)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Tipo de adquisición:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 15)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Tipo de plataforma:"
        '
        'CB_plataforma
        '
        Me.CB_plataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_plataforma.Font = New System.Drawing.Font("Vensim Sans Tamil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_plataforma.FormattingEnabled = True
        Me.CB_plataforma.Location = New System.Drawing.Point(161, 316)
        Me.CB_plataforma.Name = "CB_plataforma"
        Me.CB_plataforma.Size = New System.Drawing.Size(206, 23)
        Me.CB_plataforma.TabIndex = 31
        '
        'BTN_asignar
        '
        Me.BTN_asignar.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_asignar.Location = New System.Drawing.Point(837, 317)
        Me.BTN_asignar.Name = "BTN_asignar"
        Me.BTN_asignar.Size = New System.Drawing.Size(154, 27)
        Me.BTN_asignar.TabIndex = 29
        Me.BTN_asignar.Text = "Finalizar asignación"
        Me.BTN_asignar.UseVisualStyleBackColor = True
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Font = New System.Drawing.Font("Vensim Sans Tamil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_regresar.Location = New System.Drawing.Point(12, 12)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 30
        Me.BTN_regresar.Text = "Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(511, 47)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ASIGNACION DE EQUIPOS"
        '
        'BTN_exportar
        '
        Me.BTN_exportar.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_exportar.Location = New System.Drawing.Point(86, 261)
        Me.BTN_exportar.Name = "BTN_exportar"
        Me.BTN_exportar.Size = New System.Drawing.Size(107, 23)
        Me.BTN_exportar.TabIndex = 34
        Me.BTN_exportar.Text = "Exportar tabla"
        Me.BTN_exportar.UseVisualStyleBackColor = True
        '
        'AsignarEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1091, 761)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AsignarEquipo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignacion de equipos"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.DGV_equipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Activos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGV_asignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents LB_equipoSeleccionado As Label
    Friend WithEvents BTN_seleccionarEquipo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_buscarEquipos As TextBox
    Friend WithEvents DGV_Activos As DataGridView
    Friend WithEvents PlacaActivo As DataGridViewTextBoxColumn
    Friend WithEvents ChasisActivo As DataGridViewTextBoxColumn
    Friend WithEvents MarcaActivo As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LB_activoSeleccionado As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BTN_seleccionarActivo As Button
    Friend WithEvents TB_buscarActivos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTN_desasignarEquipo As Button
    Friend WithEvents DGV_asignaciones As DataGridView
    Friend WithEvents TB_buscarAsignaciones As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_asignar As Button
    Friend WithEvents BTN_regresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV_equipos As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_adquisicion As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CB_plataforma As ComboBox
    Friend WithEvents imeiEquipo As DataGridViewTextBoxColumn
    Friend WithEvents ModeloEquipo As DataGridViewTextBoxColumn
    Friend WithEvents MarcaEquipo As DataGridViewTextBoxColumn
    Friend WithEvents numeroEquipo As DataGridViewTextBoxColumn
    Friend WithEvents PlacaAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents NumeroAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents IMEIAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents ModeloAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents MarcaAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents FechaAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents BTN_exportar As Button
End Class
