<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignarSIM
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
        Me.LB_equipoSeleccionado = New System.Windows.Forms.Label()
        Me.BTN_seleccionarEquipo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_buscarEquipos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LB_simSeleccionado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_seleccionarSim = New System.Windows.Forms.Button()
        Me.TB_buscarSim = New System.Windows.Forms.TextBox()
        Me.DGV_sim = New System.Windows.Forms.DataGridView()
        Me.ICCSim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroSim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropietarioSim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompaniaSim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTN_desasignarEquipo = New System.Windows.Forms.Button()
        Me.DGV_asignaciones = New System.Windows.Forms.DataGridView()
        Me.IMEIAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ICCAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropietarioAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompaniaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB_buscarAsignaciones = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_asignar = New System.Windows.Forms.Button()
        Me.BTN_regresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_exportar = New System.Windows.Forms.Button()
        Me.Panel6.SuspendLayout()
        CType(Me.DGV_equipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.DGV_sim, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel6.Location = New System.Drawing.Point(22, 18)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(475, 283)
        Me.Panel6.TabIndex = 38
        '
        'DGV_equipos
        '
        Me.DGV_equipos.AllowUserToAddRows = False
        Me.DGV_equipos.AllowUserToDeleteRows = False
        Me.DGV_equipos.AllowUserToResizeRows = False
        Me.DGV_equipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_equipos.BackgroundColor = System.Drawing.Color.White
        Me.DGV_equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_equipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.imeiEquipo, Me.ModeloEquipo, Me.MarcaEquipo})
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
        'LB_equipoSeleccionado
        '
        Me.LB_equipoSeleccionado.AutoSize = True
        Me.LB_equipoSeleccionado.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_equipoSeleccionado.Location = New System.Drawing.Point(160, 253)
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
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.LB_simSeleccionado)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.BTN_seleccionarSim)
        Me.Panel5.Controls.Add(Me.TB_buscarSim)
        Me.Panel5.Controls.Add(Me.DGV_sim)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(516, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(475, 283)
        Me.Panel5.TabIndex = 37
        '
        'LB_simSeleccionado
        '
        Me.LB_simSeleccionado.AutoSize = True
        Me.LB_simSeleccionado.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_simSeleccionado.Location = New System.Drawing.Point(151, 253)
        Me.LB_simSeleccionado.Name = "LB_simSeleccionado"
        Me.LB_simSeleccionado.Size = New System.Drawing.Size(104, 15)
        Me.LB_simSeleccionado.TabIndex = 30
        Me.LB_simSeleccionado.Text = "No seleccionado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Activo seleccionado:"
        '
        'BTN_seleccionarSim
        '
        Me.BTN_seleccionarSim.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_seleccionarSim.Location = New System.Drawing.Point(368, 249)
        Me.BTN_seleccionarSim.Name = "BTN_seleccionarSim"
        Me.BTN_seleccionarSim.Size = New System.Drawing.Size(91, 23)
        Me.BTN_seleccionarSim.TabIndex = 29
        Me.BTN_seleccionarSim.Text = "Seleccionar"
        Me.BTN_seleccionarSim.UseVisualStyleBackColor = True
        '
        'TB_buscarSim
        '
        Me.TB_buscarSim.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_buscarSim.Location = New System.Drawing.Point(291, 8)
        Me.TB_buscarSim.Name = "TB_buscarSim"
        Me.TB_buscarSim.Size = New System.Drawing.Size(168, 22)
        Me.TB_buscarSim.TabIndex = 28
        '
        'DGV_sim
        '
        Me.DGV_sim.AllowUserToAddRows = False
        Me.DGV_sim.AllowUserToDeleteRows = False
        Me.DGV_sim.AllowUserToResizeRows = False
        Me.DGV_sim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_sim.BackgroundColor = System.Drawing.Color.White
        Me.DGV_sim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_sim.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ICCSim, Me.NumeroSim, Me.PropietarioSim, Me.CompaniaSim})
        Me.DGV_sim.Location = New System.Drawing.Point(19, 41)
        Me.DGV_sim.Name = "DGV_sim"
        Me.DGV_sim.ReadOnly = True
        Me.DGV_sim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_sim.Size = New System.Drawing.Size(440, 202)
        Me.DGV_sim.TabIndex = 30
        '
        'ICCSim
        '
        Me.ICCSim.HeaderText = "ICC"
        Me.ICCSim.Name = "ICCSim"
        Me.ICCSim.ReadOnly = True
        '
        'NumeroSim
        '
        Me.NumeroSim.HeaderText = "Numero"
        Me.NumeroSim.Name = "NumeroSim"
        Me.NumeroSim.ReadOnly = True
        '
        'PropietarioSim
        '
        Me.PropietarioSim.HeaderText = "Propietario"
        Me.PropietarioSim.Name = "PropietarioSim"
        Me.PropietarioSim.ReadOnly = True
        '
        'CompaniaSim
        '
        Me.CompaniaSim.HeaderText = "Compañia"
        Me.CompaniaSim.Name = "CompaniaSim"
        Me.CompaniaSim.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "SIM:"
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
        Me.Panel3.Location = New System.Drawing.Point(35, 442)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1020, 294)
        Me.Panel3.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Vensim Sans Tamil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "SIM asignadas a equipos:"
        '
        'BTN_desasignarEquipo
        '
        Me.BTN_desasignarEquipo.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_desasignarEquipo.Location = New System.Drawing.Point(793, 257)
        Me.BTN_desasignarEquipo.Name = "BTN_desasignarEquipo"
        Me.BTN_desasignarEquipo.Size = New System.Drawing.Size(127, 23)
        Me.BTN_desasignarEquipo.TabIndex = 35
        Me.BTN_desasignarEquipo.Text = "Desasignar SIM"
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
        Me.DGV_asignaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IMEIAsignacion, Me.ICCAsignacion, Me.NumeroAsignacion, Me.PropietarioAsignacion, Me.CompaniaAsignacion, Me.FechaAsignacion})
        Me.DGV_asignaciones.Location = New System.Drawing.Point(87, 43)
        Me.DGV_asignaciones.Name = "DGV_asignaciones"
        Me.DGV_asignaciones.ReadOnly = True
        Me.DGV_asignaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_asignaciones.Size = New System.Drawing.Size(833, 208)
        Me.DGV_asignaciones.TabIndex = 34
        '
        'IMEIAsignacion
        '
        Me.IMEIAsignacion.HeaderText = "IMEI (Equipo)"
        Me.IMEIAsignacion.Name = "IMEIAsignacion"
        Me.IMEIAsignacion.ReadOnly = True
        '
        'ICCAsignacion
        '
        Me.ICCAsignacion.HeaderText = "ICC"
        Me.ICCAsignacion.Name = "ICCAsignacion"
        Me.ICCAsignacion.ReadOnly = True
        '
        'NumeroAsignacion
        '
        Me.NumeroAsignacion.HeaderText = "Numero"
        Me.NumeroAsignacion.Name = "NumeroAsignacion"
        Me.NumeroAsignacion.ReadOnly = True
        '
        'PropietarioAsignacion
        '
        Me.PropietarioAsignacion.HeaderText = "Propietario"
        Me.PropietarioAsignacion.Name = "PropietarioAsignacion"
        Me.PropietarioAsignacion.ReadOnly = True
        '
        'CompaniaAsignacion
        '
        Me.CompaniaAsignacion.HeaderText = "Compañia"
        Me.CompaniaAsignacion.Name = "CompaniaAsignacion"
        Me.CompaniaAsignacion.ReadOnly = True
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
        Me.TB_buscarAsignaciones.Location = New System.Drawing.Point(752, 11)
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
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.BTN_asignar)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Location = New System.Drawing.Point(35, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 356)
        Me.Panel1.TabIndex = 33
        '
        'BTN_asignar
        '
        Me.BTN_asignar.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_asignar.Location = New System.Drawing.Point(434, 317)
        Me.BTN_asignar.Name = "BTN_asignar"
        Me.BTN_asignar.Size = New System.Drawing.Size(154, 27)
        Me.BTN_asignar.TabIndex = 29
        Me.BTN_asignar.Text = "Finalizar asignación"
        Me.BTN_asignar.UseVisualStyleBackColor = True
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_regresar.Location = New System.Drawing.Point(12, 12)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 36
        Me.BTN_regresar.Text = "Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(342, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 46)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "ASIGNACION DE SIM"
        '
        'BTN_exportar
        '
        Me.BTN_exportar.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_exportar.Location = New System.Drawing.Point(87, 257)
        Me.BTN_exportar.Name = "BTN_exportar"
        Me.BTN_exportar.Size = New System.Drawing.Size(100, 23)
        Me.BTN_exportar.TabIndex = 34
        Me.BTN_exportar.Text = "Exportar tabla"
        Me.BTN_exportar.UseVisualStyleBackColor = True
        '
        'AsignarSIM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 761)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AsignarSIM"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignacion de SIM"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.DGV_equipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DGV_sim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGV_asignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents DGV_equipos As DataGridView
    Friend WithEvents imeiEquipo As DataGridViewTextBoxColumn
    Friend WithEvents ModeloEquipo As DataGridViewTextBoxColumn
    Friend WithEvents MarcaEquipo As DataGridViewTextBoxColumn
    Friend WithEvents LB_equipoSeleccionado As Label
    Friend WithEvents BTN_seleccionarEquipo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_buscarEquipos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LB_simSeleccionado As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BTN_seleccionarSim As Button
    Friend WithEvents TB_buscarSim As TextBox
    Friend WithEvents DGV_sim As DataGridView
    Friend WithEvents ICCSim As DataGridViewTextBoxColumn
    Friend WithEvents NumeroSim As DataGridViewTextBoxColumn
    Friend WithEvents PropietarioSim As DataGridViewTextBoxColumn
    Friend WithEvents CompaniaSim As DataGridViewTextBoxColumn
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
    Friend WithEvents Label5 As Label
    Friend WithEvents IMEIAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents ICCAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents NumeroAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents PropietarioAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents CompaniaAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents FechaAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents BTN_exportar As Button
End Class
