<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conectividad
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
        Me.BTN_conectar = New System.Windows.Forms.Button()
        Me.TB_baseDatos = New System.Windows.Forms.TextBox()
        Me.TB_contrasenia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_usuario = New System.Windows.Forms.TextBox()
        Me.TB_puerto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_host = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BTN_conectar)
        Me.Panel1.Controls.Add(Me.TB_baseDatos)
        Me.Panel1.Controls.Add(Me.TB_contrasenia)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TB_usuario)
        Me.Panel1.Controls.Add(Me.TB_puerto)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TB_host)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(18, 161)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(702, 398)
        Me.Panel1.TabIndex = 0
        '
        'BTN_conectar
        '
        Me.BTN_conectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_conectar.Location = New System.Drawing.Point(422, 322)
        Me.BTN_conectar.Name = "BTN_conectar"
        Me.BTN_conectar.Size = New System.Drawing.Size(161, 54)
        Me.BTN_conectar.TabIndex = 22
        Me.BTN_conectar.Text = "CONECTAR"
        Me.BTN_conectar.UseVisualStyleBackColor = True
        '
        'TB_baseDatos
        '
        Me.TB_baseDatos.Location = New System.Drawing.Point(315, 270)
        Me.TB_baseDatos.Name = "TB_baseDatos"
        Me.TB_baseDatos.Size = New System.Drawing.Size(268, 24)
        Me.TB_baseDatos.TabIndex = 21
        '
        'TB_contrasenia
        '
        Me.TB_contrasenia.Location = New System.Drawing.Point(315, 212)
        Me.TB_contrasenia.Name = "TB_contrasenia"
        Me.TB_contrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_contrasenia.Size = New System.Drawing.Size(268, 24)
        Me.TB_contrasenia.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(113, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 22)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "BASE DE DATOS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(113, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 22)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "CONTRASEÑA:"
        '
        'TB_usuario
        '
        Me.TB_usuario.Location = New System.Drawing.Point(315, 161)
        Me.TB_usuario.Name = "TB_usuario"
        Me.TB_usuario.Size = New System.Drawing.Size(268, 24)
        Me.TB_usuario.TabIndex = 17
        '
        'TB_puerto
        '
        Me.TB_puerto.Location = New System.Drawing.Point(315, 103)
        Me.TB_puerto.Name = "TB_puerto"
        Me.TB_puerto.Size = New System.Drawing.Size(268, 24)
        Me.TB_puerto.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 22)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "USUARIO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 22)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "PUERTO:"
        '
        'TB_host
        '
        Me.TB_host.Location = New System.Drawing.Point(315, 54)
        Me.TB_host.Name = "TB_host"
        Me.TB_host.Size = New System.Drawing.Size(268, 24)
        Me.TB_host.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(113, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 22)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "HOST:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(699, 63)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CONECTIVIDAD REMOTA"
        '
        'Conectividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(733, 581)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Conectividad"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conectividad"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_host As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BTN_conectar As Button
    Friend WithEvents TB_baseDatos As TextBox
    Friend WithEvents TB_contrasenia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_usuario As TextBox
    Friend WithEvents TB_puerto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
