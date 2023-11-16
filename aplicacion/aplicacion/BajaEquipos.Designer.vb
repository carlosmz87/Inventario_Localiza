<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BajaEquipos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_regresar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_bajaEquipos = New System.Windows.Forms.DataGridView()
        Me.IMEI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB_buscarBajaEquipo = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_bajaEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(630, 79)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "BAJAS DE EQUIPOS"
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Font = New System.Drawing.Font("Vensim Sans Tamil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_regresar.Location = New System.Drawing.Point(12, 12)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 36
        Me.BTN_regresar.Text = "Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DGV_bajaEquipos)
        Me.Panel1.Controls.Add(Me.TB_buscarBajaEquipo)
        Me.Panel1.Location = New System.Drawing.Point(12, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 340)
        Me.Panel1.TabIndex = 37
        '
        'DGV_bajaEquipos
        '
        Me.DGV_bajaEquipos.AllowUserToAddRows = False
        Me.DGV_bajaEquipos.AllowUserToDeleteRows = False
        Me.DGV_bajaEquipos.AllowUserToResizeColumns = False
        Me.DGV_bajaEquipos.AllowUserToResizeRows = False
        Me.DGV_bajaEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_bajaEquipos.BackgroundColor = System.Drawing.Color.White
        Me.DGV_bajaEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_bajaEquipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IMEI, Me.fecha})
        Me.DGV_bajaEquipos.Location = New System.Drawing.Point(35, 52)
        Me.DGV_bajaEquipos.Name = "DGV_bajaEquipos"
        Me.DGV_bajaEquipos.ReadOnly = True
        Me.DGV_bajaEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_bajaEquipos.Size = New System.Drawing.Size(729, 275)
        Me.DGV_bajaEquipos.TabIndex = 40
        '
        'IMEI
        '
        Me.IMEI.HeaderText = "IMEI"
        Me.IMEI.Name = "IMEI"
        Me.IMEI.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'TB_buscarBajaEquipo
        '
        Me.TB_buscarBajaEquipo.Font = New System.Drawing.Font("Vensim Sans Tamil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_buscarBajaEquipo.Location = New System.Drawing.Point(553, 14)
        Me.TB_buscarBajaEquipo.Name = "TB_buscarBajaEquipo"
        Me.TB_buscarBajaEquipo.Size = New System.Drawing.Size(211, 22)
        Me.TB_buscarBajaEquipo.TabIndex = 39
        '
        'BajaEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 477)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BajaEquipos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de equipos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_bajaEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_regresar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGV_bajaEquipos As DataGridView
    Friend WithEvents TB_buscarBajaEquipo As TextBox
    Friend WithEvents IMEI As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
End Class
