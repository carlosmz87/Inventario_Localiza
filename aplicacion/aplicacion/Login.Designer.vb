<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.label3 = New System.Windows.Forms.Label()
        Me.BTN_iniciarSesion = New System.Windows.Forms.Button()
        Me.TB_contrasena = New System.Windows.Forms.TextBox()
        Me.TB_usuario = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Vensim Sans Tamil", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(108, 58)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(604, 79)
        Me.label3.TabIndex = 11
        Me.label3.Text = "INICIO DE SESIÓN"
        '
        'BTN_iniciarSesion
        '
        Me.BTN_iniciarSesion.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_iniciarSesion.Location = New System.Drawing.Point(510, 333)
        Me.BTN_iniciarSesion.Name = "BTN_iniciarSesion"
        Me.BTN_iniciarSesion.Size = New System.Drawing.Size(122, 29)
        Me.BTN_iniciarSesion.TabIndex = 10
        Me.BTN_iniciarSesion.Text = "Iniciar sesión"
        Me.BTN_iniciarSesion.UseVisualStyleBackColor = True
        '
        'TB_contrasena
        '
        Me.TB_contrasena.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_contrasena.Location = New System.Drawing.Point(364, 263)
        Me.TB_contrasena.Name = "TB_contrasena"
        Me.TB_contrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_contrasena.Size = New System.Drawing.Size(268, 26)
        Me.TB_contrasena.TabIndex = 9
        '
        'TB_usuario
        '
        Me.TB_usuario.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_usuario.Location = New System.Drawing.Point(364, 202)
        Me.TB_usuario.Name = "TB_usuario"
        Me.TB_usuario.Size = New System.Drawing.Size(268, 26)
        Me.TB_usuario.TabIndex = 8
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(169, 266)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(91, 19)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Contraseña:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(169, 205)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(147, 19)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Nombre de usuario:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.BTN_iniciarSesion)
        Me.Controls.Add(Me.TB_contrasena)
        Me.Controls.Add(Me.TB_usuario)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label3 As Label
    Private WithEvents BTN_iniciarSesion As Button
    Private WithEvents TB_contrasena As TextBox
    Private WithEvents TB_usuario As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
