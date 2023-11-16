<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteGeneral
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP_final = New System.Windows.Forms.DateTimePicker()
        Me.DTP_inicial = New System.Windows.Forms.DateTimePicker()
        Me.BTN_reporteIntervalo = New System.Windows.Forms.Button()
        Me.RB_reporteGeneral = New System.Windows.Forms.RadioButton()
        Me.DGV_reporteGeneral = New System.Windows.Forms.DataGridView()
        Me.TB_buscarActivo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_regresar = New System.Windows.Forms.Button()
        Me.BTN_exportar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_reporteGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BTN_exportar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DTP_final)
        Me.Panel1.Controls.Add(Me.DTP_inicial)
        Me.Panel1.Controls.Add(Me.BTN_reporteIntervalo)
        Me.Panel1.Controls.Add(Me.RB_reporteGeneral)
        Me.Panel1.Controls.Add(Me.DGV_reporteGeneral)
        Me.Panel1.Controls.Add(Me.TB_buscarActivo)
        Me.Panel1.Location = New System.Drawing.Point(13, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 402)
        Me.Panel1.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Vensim Sans Tamil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(278, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Fecha final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Vensim Sans Tamil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Fecha inicial:"
        '
        'DTP_final
        '
        Me.DTP_final.Location = New System.Drawing.Point(281, 34)
        Me.DTP_final.Name = "DTP_final"
        Me.DTP_final.Size = New System.Drawing.Size(200, 20)
        Me.DTP_final.TabIndex = 48
        '
        'DTP_inicial
        '
        Me.DTP_inicial.Location = New System.Drawing.Point(35, 34)
        Me.DTP_inicial.Name = "DTP_inicial"
        Me.DTP_inicial.Size = New System.Drawing.Size(200, 20)
        Me.DTP_inicial.TabIndex = 47
        '
        'BTN_reporteIntervalo
        '
        Me.BTN_reporteIntervalo.Font = New System.Drawing.Font("Vensim Sans Tamil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_reporteIntervalo.Location = New System.Drawing.Point(35, 71)
        Me.BTN_reporteIntervalo.Name = "BTN_reporteIntervalo"
        Me.BTN_reporteIntervalo.Size = New System.Drawing.Size(158, 26)
        Me.BTN_reporteIntervalo.TabIndex = 44
        Me.BTN_reporteIntervalo.Text = "Generar reporte"
        Me.BTN_reporteIntervalo.UseVisualStyleBackColor = True
        '
        'RB_reporteGeneral
        '
        Me.RB_reporteGeneral.AutoSize = True
        Me.RB_reporteGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_reporteGeneral.Location = New System.Drawing.Point(606, 23)
        Me.RB_reporteGeneral.Name = "RB_reporteGeneral"
        Me.RB_reporteGeneral.Size = New System.Drawing.Size(158, 19)
        Me.RB_reporteGeneral.TabIndex = 41
        Me.RB_reporteGeneral.TabStop = True
        Me.RB_reporteGeneral.Text = "REPORTE GENERAL"
        Me.RB_reporteGeneral.UseVisualStyleBackColor = True
        '
        'DGV_reporteGeneral
        '
        Me.DGV_reporteGeneral.AllowUserToAddRows = False
        Me.DGV_reporteGeneral.AllowUserToDeleteRows = False
        Me.DGV_reporteGeneral.AllowUserToResizeColumns = False
        Me.DGV_reporteGeneral.AllowUserToResizeRows = False
        Me.DGV_reporteGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_reporteGeneral.BackgroundColor = System.Drawing.Color.White
        Me.DGV_reporteGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_reporteGeneral.Location = New System.Drawing.Point(35, 107)
        Me.DGV_reporteGeneral.Name = "DGV_reporteGeneral"
        Me.DGV_reporteGeneral.ReadOnly = True
        Me.DGV_reporteGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_reporteGeneral.Size = New System.Drawing.Size(729, 248)
        Me.DGV_reporteGeneral.TabIndex = 40
        '
        'TB_buscarActivo
        '
        Me.TB_buscarActivo.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_buscarActivo.Location = New System.Drawing.Point(553, 71)
        Me.TB_buscarActivo.Name = "TB_buscarActivo"
        Me.TB_buscarActivo.Size = New System.Drawing.Size(211, 22)
        Me.TB_buscarActivo.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(442, 47)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "REPORTES GENERALES"
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Font = New System.Drawing.Font("Vensim Sans Tamil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_regresar.Location = New System.Drawing.Point(13, 12)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 44
        Me.BTN_regresar.Text = "Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
        'BTN_exportar
        '
        Me.BTN_exportar.Font = New System.Drawing.Font("Vensim Sans Tamil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_exportar.Location = New System.Drawing.Point(652, 371)
        Me.BTN_exportar.Name = "BTN_exportar"
        Me.BTN_exportar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_exportar.TabIndex = 50
        Me.BTN_exportar.Text = "Exportar reporte"
        Me.BTN_exportar.UseVisualStyleBackColor = True
        '
        'ReporteGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Name = "ReporteGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteGeneral"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_reporteGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DTP_final As DateTimePicker
    Friend WithEvents DTP_inicial As DateTimePicker
    Friend WithEvents BTN_reporteIntervalo As Button
    Friend WithEvents RB_reporteGeneral As RadioButton
    Friend WithEvents DGV_reporteGeneral As DataGridView
    Friend WithEvents TB_buscarActivo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_regresar As Button
    Friend WithEvents BTN_exportar As Button
End Class
