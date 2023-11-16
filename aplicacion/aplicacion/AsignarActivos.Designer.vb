<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignarActivos
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
        Me.BTN_regresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LB_clienteSeleccionado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_seleccionarCliente = New System.Windows.Forms.Button()
        Me.DGV_Clientes = New System.Windows.Forms.DataGridView()
        Me.NombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB_buscarCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_asignar = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LB_activoSeleccionado = New System.Windows.Forms.Label()
        Me.BTN_seleccionarActivo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_buscarActivo = New System.Windows.Forms.TextBox()
        Me.DGV_Activos = New System.Windows.Forms.DataGridView()
        Me.PlacaActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChasisActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMEIActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlataformaActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTN_desasignarActivo = New System.Windows.Forms.Button()
        Me.DGV_asignaciones = New System.Windows.Forms.DataGridView()
        Me.NombreAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlacaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChasisAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImeiAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB_buscarAsignaciones = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BTN_exportar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.DGV_Activos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV_asignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_regresar.Location = New System.Drawing.Point(12, 12)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 24
        Me.BTN_regresar.Text = "Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 47)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ASIGNACION DE ACTIVOS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.BTN_asignar)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(35, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 356)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.LB_clienteSeleccionado)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.BTN_seleccionarCliente)
        Me.Panel5.Controls.Add(Me.DGV_Clientes)
        Me.Panel5.Controls.Add(Me.TB_buscarCliente)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(22, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(441, 283)
        Me.Panel5.TabIndex = 25
        '
        'LB_clienteSeleccionado
        '
        Me.LB_clienteSeleccionado.AutoSize = True
        Me.LB_clienteSeleccionado.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_clienteSeleccionado.Location = New System.Drawing.Point(147, 253)
        Me.LB_clienteSeleccionado.Name = "LB_clienteSeleccionado"
        Me.LB_clienteSeleccionado.Size = New System.Drawing.Size(104, 15)
        Me.LB_clienteSeleccionado.TabIndex = 30
        Me.LB_clienteSeleccionado.Text = "No seleccionado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Cliente seleccionado:"
        '
        'BTN_seleccionarCliente
        '
        Me.BTN_seleccionarCliente.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_seleccionarCliente.Location = New System.Drawing.Point(328, 250)
        Me.BTN_seleccionarCliente.Name = "BTN_seleccionarCliente"
        Me.BTN_seleccionarCliente.Size = New System.Drawing.Size(91, 23)
        Me.BTN_seleccionarCliente.TabIndex = 29
        Me.BTN_seleccionarCliente.Text = "Seleccionar"
        Me.BTN_seleccionarCliente.UseVisualStyleBackColor = True
        '
        'DGV_Clientes
        '
        Me.DGV_Clientes.AllowUserToAddRows = False
        Me.DGV_Clientes.AllowUserToDeleteRows = False
        Me.DGV_Clientes.AllowUserToResizeRows = False
        Me.DGV_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Clientes.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreCliente, Me.TelefonoCliente, Me.CorreoCliente})
        Me.DGV_Clientes.Location = New System.Drawing.Point(19, 41)
        Me.DGV_Clientes.Name = "DGV_Clientes"
        Me.DGV_Clientes.ReadOnly = True
        Me.DGV_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Clientes.Size = New System.Drawing.Size(400, 202)
        Me.DGV_Clientes.TabIndex = 27
        '
        'NombreCliente
        '
        Me.NombreCliente.HeaderText = "Nombre"
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.ReadOnly = True
        '
        'TelefonoCliente
        '
        Me.TelefonoCliente.HeaderText = "Telefono"
        Me.TelefonoCliente.Name = "TelefonoCliente"
        Me.TelefonoCliente.ReadOnly = True
        '
        'CorreoCliente
        '
        Me.CorreoCliente.HeaderText = "Correo"
        Me.CorreoCliente.Name = "CorreoCliente"
        Me.CorreoCliente.ReadOnly = True
        '
        'TB_buscarCliente
        '
        Me.TB_buscarCliente.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_buscarCliente.Location = New System.Drawing.Point(251, 9)
        Me.TB_buscarCliente.Name = "TB_buscarCliente"
        Me.TB_buscarCliente.Size = New System.Drawing.Size(168, 22)
        Me.TB_buscarCliente.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Clientes:"
        '
        'BTN_asignar
        '
        Me.BTN_asignar.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_asignar.Location = New System.Drawing.Point(434, 317)
        Me.BTN_asignar.Name = "BTN_asignar"
        Me.BTN_asignar.Size = New System.Drawing.Size(136, 27)
        Me.BTN_asignar.TabIndex = 29
        Me.BTN_asignar.Text = "Finalizar asignación"
        Me.BTN_asignar.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.LB_activoSeleccionado)
        Me.Panel6.Controls.Add(Me.BTN_seleccionarActivo)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.TB_buscarActivo)
        Me.Panel6.Controls.Add(Me.DGV_Activos)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(482, 18)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(513, 283)
        Me.Panel6.TabIndex = 26
        '
        'LB_activoSeleccionado
        '
        Me.LB_activoSeleccionado.AutoSize = True
        Me.LB_activoSeleccionado.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_activoSeleccionado.Location = New System.Drawing.Point(161, 253)
        Me.LB_activoSeleccionado.Name = "LB_activoSeleccionado"
        Me.LB_activoSeleccionado.Size = New System.Drawing.Size(104, 15)
        Me.LB_activoSeleccionado.TabIndex = 32
        Me.LB_activoSeleccionado.Text = "No seleccionado"
        '
        'BTN_seleccionarActivo
        '
        Me.BTN_seleccionarActivo.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_seleccionarActivo.Location = New System.Drawing.Point(404, 249)
        Me.BTN_seleccionarActivo.Name = "BTN_seleccionarActivo"
        Me.BTN_seleccionarActivo.Size = New System.Drawing.Size(91, 23)
        Me.BTN_seleccionarActivo.TabIndex = 31
        Me.BTN_seleccionarActivo.Text = "Seleccionar"
        Me.BTN_seleccionarActivo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 15)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Activo seleccionado:"
        '
        'TB_buscarActivo
        '
        Me.TB_buscarActivo.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_buscarActivo.Location = New System.Drawing.Point(327, 6)
        Me.TB_buscarActivo.Name = "TB_buscarActivo"
        Me.TB_buscarActivo.Size = New System.Drawing.Size(168, 22)
        Me.TB_buscarActivo.TabIndex = 30
        '
        'DGV_Activos
        '
        Me.DGV_Activos.AllowUserToAddRows = False
        Me.DGV_Activos.AllowUserToDeleteRows = False
        Me.DGV_Activos.AllowUserToResizeRows = False
        Me.DGV_Activos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Activos.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Activos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Activos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PlacaActivo, Me.ChasisActivo, Me.IMEIActivo, Me.ModeloActivo, Me.PlataformaActivo})
        Me.DGV_Activos.Location = New System.Drawing.Point(21, 41)
        Me.DGV_Activos.Name = "DGV_Activos"
        Me.DGV_Activos.ReadOnly = True
        Me.DGV_Activos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Activos.Size = New System.Drawing.Size(474, 202)
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
        'IMEIActivo
        '
        Me.IMEIActivo.HeaderText = "IMEI (Equipo)"
        Me.IMEIActivo.Name = "IMEIActivo"
        Me.IMEIActivo.ReadOnly = True
        '
        'ModeloActivo
        '
        Me.ModeloActivo.HeaderText = "Modelo (equipo)"
        Me.ModeloActivo.Name = "ModeloActivo"
        Me.ModeloActivo.ReadOnly = True
        '
        'PlataformaActivo
        '
        Me.PlataformaActivo.HeaderText = "Plataforma"
        Me.PlataformaActivo.Name = "PlataformaActivo"
        Me.PlataformaActivo.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Activos"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BTN_exportar)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.BTN_desasignarActivo)
        Me.Panel3.Controls.Add(Me.DGV_asignaciones)
        Me.Panel3.Controls.Add(Me.TB_buscarAsignaciones)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(35, 442)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1020, 294)
        Me.Panel3.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Vensim Sans Tamil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 17)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Asignación de activos al cliente:"
        '
        'BTN_desasignarActivo
        '
        Me.BTN_desasignarActivo.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_desasignarActivo.Location = New System.Drawing.Point(793, 257)
        Me.BTN_desasignarActivo.Name = "BTN_desasignarActivo"
        Me.BTN_desasignarActivo.Size = New System.Drawing.Size(127, 27)
        Me.BTN_desasignarActivo.TabIndex = 35
        Me.BTN_desasignarActivo.Text = "Desasignar activo"
        Me.BTN_desasignarActivo.UseVisualStyleBackColor = True
        '
        'DGV_asignaciones
        '
        Me.DGV_asignaciones.AllowUserToAddRows = False
        Me.DGV_asignaciones.AllowUserToDeleteRows = False
        Me.DGV_asignaciones.AllowUserToResizeRows = False
        Me.DGV_asignaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_asignaciones.BackgroundColor = System.Drawing.Color.White
        Me.DGV_asignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_asignaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreAsignacion, Me.PlacaAsignacion, Me.ChasisAsignacion, Me.NumeroAsignacion, Me.ImeiAsignacion, Me.ModeloAsignacion, Me.FechaAsignacion})
        Me.DGV_asignaciones.Location = New System.Drawing.Point(87, 43)
        Me.DGV_asignaciones.Name = "DGV_asignaciones"
        Me.DGV_asignaciones.ReadOnly = True
        Me.DGV_asignaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_asignaciones.Size = New System.Drawing.Size(833, 208)
        Me.DGV_asignaciones.TabIndex = 34
        '
        'NombreAsignacion
        '
        Me.NombreAsignacion.HeaderText = "Nombre (Cliente)"
        Me.NombreAsignacion.Name = "NombreAsignacion"
        Me.NombreAsignacion.ReadOnly = True
        '
        'PlacaAsignacion
        '
        Me.PlacaAsignacion.HeaderText = "Placa"
        Me.PlacaAsignacion.Name = "PlacaAsignacion"
        Me.PlacaAsignacion.ReadOnly = True
        '
        'ChasisAsignacion
        '
        Me.ChasisAsignacion.HeaderText = "Chásis"
        Me.ChasisAsignacion.Name = "ChasisAsignacion"
        Me.ChasisAsignacion.ReadOnly = True
        '
        'NumeroAsignacion
        '
        Me.NumeroAsignacion.HeaderText = "Numero"
        Me.NumeroAsignacion.Name = "NumeroAsignacion"
        Me.NumeroAsignacion.ReadOnly = True
        '
        'ImeiAsignacion
        '
        Me.ImeiAsignacion.HeaderText = "IMEI (Equipo)"
        Me.ImeiAsignacion.Name = "ImeiAsignacion"
        Me.ImeiAsignacion.ReadOnly = True
        '
        'ModeloAsignacion
        '
        Me.ModeloAsignacion.HeaderText = "Modelo"
        Me.ModeloAsignacion.Name = "ModeloAsignacion"
        Me.ModeloAsignacion.ReadOnly = True
        '
        'FechaAsignacion
        '
        Me.FechaAsignacion.HeaderText = "Fecha de asignación"
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
        'BTN_exportar
        '
        Me.BTN_exportar.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_exportar.Location = New System.Drawing.Point(87, 259)
        Me.BTN_exportar.Name = "BTN_exportar"
        Me.BTN_exportar.Size = New System.Drawing.Size(106, 23)
        Me.BTN_exportar.TabIndex = 33
        Me.BTN_exportar.Text = "Exportar tabla"
        Me.BTN_exportar.UseVisualStyleBackColor = True
        '
        'AsignarActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 761)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Controls.Add(Me.Label1)
        Me.MinimizeBox = False
        Me.Name = "AsignarActivos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignacion de activos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.DGV_Activos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGV_asignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_regresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BTN_asignar As Button
    Friend WithEvents BTN_seleccionarCliente As Button
    Friend WithEvents DGV_Clientes As DataGridView
    Friend WithEvents TB_buscarCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_seleccionarActivo As Button
    Friend WithEvents TB_buscarActivo As TextBox
    Friend WithEvents DGV_Activos As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_desasignarActivo As Button
    Friend WithEvents DGV_asignaciones As DataGridView
    Friend WithEvents TB_buscarAsignaciones As TextBox
    Friend WithEvents NombreCliente As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoCliente As DataGridViewTextBoxColumn
    Friend WithEvents CorreoCliente As DataGridViewTextBoxColumn
    Friend WithEvents LB_clienteSeleccionado As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LB_activoSeleccionado As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PlacaActivo As DataGridViewTextBoxColumn
    Friend WithEvents ChasisActivo As DataGridViewTextBoxColumn
    Friend WithEvents IMEIActivo As DataGridViewTextBoxColumn
    Friend WithEvents ModeloActivo As DataGridViewTextBoxColumn
    Friend WithEvents PlataformaActivo As DataGridViewTextBoxColumn
    Friend WithEvents NombreAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents PlacaAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents ChasisAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents NumeroAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents ImeiAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents ModeloAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents FechaAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents BTN_exportar As Button
End Class
