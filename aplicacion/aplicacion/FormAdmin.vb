Imports System.Text.RegularExpressions
Imports Excel = Microsoft.Office.Interop.Excel

Public Class FormAdmin

    ' LLamamos a nuestro controlador
    Dim controlador As New Controlador()
    Dim conn As New Conexion()
    Dim aux As New Auxiliares()
    ' Variable global para la seleccion de dato en cualquier tabla
    Dim valorSeleccionado As String = ""
    Dim valorSeleccionadoMarca As String = ""
    Private bloquearClicks As Boolean

    Private Sub SallirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SallirToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
    End Sub

    ' Navegación de los paneles
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        If (PanelCliente.Visible = False) Then
            ' Agregamos color al menu strip, y tambien a cada item al dar click para 
            ' asi tener una mejor vista sobre la navegación dentro del programa
            MenuStrip1.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            ClientesToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FFFFFF")
            ActivosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            EquiposToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            SIMToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            UsuariosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            MarcasYModelosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            'Ocultamos o mostramos los paneles
            PanelActivos.Visible = False
            PanelEquipos.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = False
            PanelMarcaYModelos.Visible = False
            PanelCliente.Visible = True
            PanelCliente.Location = New Point(0, 0)
            PanelCliente.Dock = DockStyle.Fill
        End If
    End Sub
    Private Sub ActivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivosToolStripMenuItem.Click
        If (PanelActivos.Visible = False) Then
            ' Agregamos color al menu strip, y tambien a cada item al dar click para 
            ' asi tener una mejor vista sobre la navegación dentro del programa
            MenuStrip1.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            ClientesToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            ActivosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FFFFFF")
            EquiposToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            SIMToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            UsuariosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            MarcasYModelosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            'Ocultamos o mostramos los paneles
            PanelCliente.Visible = False
            PanelEquipos.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = False
            PanelMarcaYModelos.Visible = False
            PanelActivos.Visible = True
            PanelActivos.Location = New Point(0, 0)
            PanelActivos.Dock = DockStyle.Fill
        End If
    End Sub
    Private Sub EquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquiposToolStripMenuItem.Click
        If (PanelEquipos.Visible = False) Then
            ' Agregamos color al menu strip, y tambien a cada item al dar click para 
            ' asi tener una mejor vista sobre la navegación dentro del programa
            MenuStrip1.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            ClientesToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            ActivosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            EquiposToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FFFFFF")
            SIMToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            UsuariosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            MarcasYModelosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            'Ocultamos o mostramos los paneles
            PanelActivos.Visible = False
            PanelCliente.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = False
            PanelMarcaYModelos.Visible = False
            PanelEquipos.Visible = True
            PanelEquipos.Location = New Point(0, 0)
            PanelEquipos.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub SIMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIMToolStripMenuItem.Click
        If (PanelSIM.Visible = False) Then
            ' Agregamos color al menu strip, y tambien a cada item al dar click para 
            ' asi tener una mejor vista sobre la navegación dentro del programa
            MenuStrip1.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            ClientesToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            ActivosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            EquiposToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            SIMToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FFFFFF")
            UsuariosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            MarcasYModelosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            'Ocultamos o mostramos los paneles
            PanelActivos.Visible = False
            PanelCliente.Visible = False
            PanelEquipos.Visible = False
            PanelUsuario.Visible = False
            PanelMarcaYModelos.Visible = False
            PanelSIM.Visible = True
            PanelSIM.Location = New Point(0, 0)
            PanelSIM.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        If (PanelUsuario.Visible = False) Then
            ' Agregamos color al menu strip, y tambien a cada item al dar click para 
            ' asi tener una mejor vista sobre la navegación dentro del programa
            MenuStrip1.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            ClientesToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            ActivosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            EquiposToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            SIMToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            UsuariosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FFFFFF")
            MarcasYModelosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            'Ocultamos o mostramos los paneles
            PanelActivos.Visible = False
            PanelCliente.Visible = False
            PanelEquipos.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = True
            PanelMarcaYModelos.Visible = False
            PanelUsuario.Location = New Point(0, 0)
            PanelUsuario.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub MarcasYModelosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasYModelosToolStripMenuItem.Click
        If (PanelMarcaYModelos.Visible = False) Then
            ' Agregamos color al menu strip, y tambien a cada item al dar click para 
            ' asi tener una mejor vista sobre la navegación dentro del programa
            MenuStrip1.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            ClientesToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            ActivosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            EquiposToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            SIMToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            UsuariosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            MarcasYModelosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FFFFFF")
            'Ocultamos o mostramos los paneles
            PanelActivos.Visible = False
            PanelCliente.Visible = False
            PanelEquipos.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = False
            PanelMarcaYModelos.Visible = True
            PanelMarcaYModelos.Location = New Point(0, 0)
            PanelMarcaYModelos.Dock = DockStyle.Fill
        End If
    End Sub

    ' Navegación hacia otras pestañas
    Private Sub BTN_agregarClientes_Click(sender As Object, e As EventArgs) Handles BTN_agregarClientes.Click
        Me.Hide()
        AgregarCliente.Show()
        AgregarCliente.BackColor = ColorTranslator.FromHtml("#A7E0EA")
    End Sub
    Private Sub BTN_agregarActivos_Click(sender As Object, e As EventArgs) Handles BTN_agregarActivos.Click
        Me.Hide()
        AgregarActivo.Show()
        AgregarActivo.BackColor = ColorTranslator.FromHtml("#A7E0EA")
    End Sub

    Private Sub BTN_agregarEquipos_Click(sender As Object, e As EventArgs) Handles BTN_agregarEquipos.Click
        Me.Hide()
        AgregarEquipo.Show()
        AgregarEquipo.BackColor = ColorTranslator.FromHtml("#A7E0EA")
    End Sub

    Private Sub BTN_agregarSIM_Click(sender As Object, e As EventArgs) Handles BTN_agregarSIM.Click
        Me.Hide()
        AgregarSIM.Show()
        AgregarSIM.BackColor = ColorTranslator.FromHtml("#A7E0EA")
    End Sub

    Private Sub BTN_agregarUsuario_Click(sender As Object, e As EventArgs) Handles BTN_agregarUsuario.Click
        Me.Hide()
        AgregarUsuario.Show()
        AgregarUsuario.BackColor = ColorTranslator.FromHtml("#A7E0EA")
    End Sub
    Private Sub BajaDeEquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaDeEquiposToolStripMenuItem.Click
        Me.Hide()
        BajaEquipos.Show()
        BajaEquipos.BackColor = ColorTranslator.FromHtml("#A7E0EA")
    End Sub

    Private Sub MigracionesDeSIMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MigracionesDeSIMToolStripMenuItem.Click
        Me.Hide()
        MigracionSIM.Show()
        MigracionSIM.BackColor = ColorTranslator.FromHtml("#A7E0EA")
    End Sub

    Private Sub BTN_asignarActivo_Cliente_Click(sender As Object, e As EventArgs) Handles BTN_asignarActivo_Clientes.Click
        Me.Hide()
        AsignarActivos.Show()
        AsignarActivos.BackColor = ColorTranslator.FromHtml("#A7E0EA")
    End Sub

    Private Sub BTN_asignarEquipo_Activos_Click(sender As Object, e As EventArgs) Handles BTN_asignarEquipo_Activos.Click
        Me.Hide()
        AsignarEquipo.Show()
        AsignarEquipo.BackColor = ColorTranslator.FromHtml("#A7E0EA")
    End Sub

    Private Sub BTN_asignarSIM_Equipos_Click(sender As Object, e As EventArgs) Handles BTN_asignarSIM_Equipos.Click
        Me.Hide()
        AsignarSIM.Show()
        AsignarSIM.BackColor = ColorTranslator.FromHtml("#A7E0EA")
    End Sub
    Private Sub BTN_migrarSim_Click(sender As Object, e As EventArgs) Handles BTN_migrarSim.Click
        aux.MigrarSim(valorSeleccionado)
    End Sub

    Private Sub InformeDeActivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeDeActivosToolStripMenuItem.Click
        Me.Hide()
        InformeActivos.Show()
    End Sub

    Private Sub BTN_agregarMarca_Click(sender As Object, e As EventArgs) Handles BTN_agregarMarca.Click
        aux.agregarMarca()
    End Sub

    ' En este metodo se cargan todas las tablas al iniciar sesión
    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#A7E0EA")
        If (PanelCliente.Visible = False) Then
            ' Agregamos color al menu strip, y tambien a cada item al dar click para 
            ' asi tener una mejor vista sobre la navegación dentro del programa
            MenuStrip1.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            ClientesToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FFFFFF")
            ActivosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            EquiposToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            SIMToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            UsuariosToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#A7E0EA")
            ' Ocultamos o mostramos los paneles
            PanelCliente.Visible = True
            PanelActivos.Visible = False
            PanelEquipos.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = False
            PanelCliente.Location = New Point(0, 0)
            PanelCliente.Dock = DockStyle.Fill
        End If
        Try
            If controlador.CargarTablaClientes() = False Then
                MessageBox.Show("No se pudo cargar la tabla de clientes.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If controlador.CargarTablaActivos() = False Then
                MessageBox.Show("No se pudo cargar la tabla de activos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If controlador.CargarTablaEquipos() = False Then
                MessageBox.Show("No se pudo cargar la tabla de equipos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If controlador.CargarTablaSIM() = False Then
                MessageBox.Show("No se pudo cargar la tabla de sim.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If controlador.CargarTablaUsuarios() = False Then
                MessageBox.Show("No se pudo cargar la tabla de usuarios.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If controlador.CargarTablaMarcas() = False Then
                MessageBox.Show("No se pudo cargar la tabla de marcas gps.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If controlador.CargarTablaModelos() = False Then
                MessageBox.Show("No se pudo cargar la tabla de modelos gps.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió algo inesperado (" & ex.Message & ").", "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Editar tablas
    Private Sub BTN_editarClientes_Click(sender As Object, e As EventArgs) Handles BTN_editarClientes.Click
        DGV_clientes.ReadOnly = False
        DGV_clientes.Columns("Telefono_C").ReadOnly = False
        DGV_clientes.Columns("Correo_C").ReadOnly = False
    End Sub
    Private Sub DGV_clientes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_clientes.CellEndEdit

        If e.ColumnIndex = DGV_clientes.Columns("Telefono_C").Index OrElse
            e.ColumnIndex = DGV_clientes.Columns("Correo_C").Index Then
            'Aquí va tu código para guardar cambios
            Try
                Dim resultado = MessageBox.Show("¿Desea editar la información del cliente " & valorSeleccionado & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                DGV_clientes.SelectionMode = False
                If resultado = DialogResult.OK Then
                    Dim telefono = DGV_clientes.CurrentRow.Cells("Telefono_C").Value
                    Dim correo = DGV_clientes.CurrentRow.Cells("Correo_C").Value
                    If (controlador.Editarcliente(valorSeleccionado, telefono, correo)) Then
                        MessageBox.Show("Se editó la información del cliente " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        bloquearCeldasClientes()
                    End If
                Else
                    conn.desconexion()
                    bloquearCeldasClientes()
                    controlador.CargarTablaClientes()
                End If
            Catch ex As Exception
                MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                bloquearCeldasClientes()
            End Try
        End If
    End Sub

    Private Sub bloquearCeldasClientes()
        DGV_clientes.Columns("Telefono_C").ReadOnly = True
        DGV_clientes.Columns("Correo_C").ReadOnly = True
    End Sub

    Private Sub BTN_editarActivos_Click(sender As Object, e As EventArgs) Handles BTN_editarActivos.Click
        DGV_Activos.ReadOnly = False
        DGV_Activos.Columns("Placa_A").ReadOnly = True
        DGV_Activos.Columns("Chasis_A").ReadOnly = False
        DGV_Activos.Columns("Tipo_A").ReadOnly = False
        DGV_Activos.Columns("Marca_A").ReadOnly = False
        DGV_Activos.Columns("Modelo_A").ReadOnly = False
        DGV_Activos.Columns("Color_A").ReadOnly = False
        DGV_Activos.Columns("Anio_A").ReadOnly = False
    End Sub
    Private Sub DGV_Activos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Activos.CellEndEdit

        If e.ColumnIndex = DGV_Activos.Columns("Chasis_A").Index OrElse e.ColumnIndex = DGV_Activos.Columns("Tipo_A").Index OrElse
            e.ColumnIndex = DGV_Activos.Columns("Marca_A").Index OrElse e.ColumnIndex = DGV_Activos.Columns("Modelo_A").Index OrElse
            e.ColumnIndex = DGV_Activos.Columns("Color_A").Index OrElse e.ColumnIndex = DGV_Activos.Columns("Anio_A").Index Then
            'Aquí va tu código para guardar cambios
            Try
                Dim resultado = MessageBox.Show("¿Desea editar la información del activo con placa " & valorSeleccionado & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                If resultado = DialogResult.OK Then
                    Dim chasis = DGV_Activos.CurrentRow.Cells("Chasis_A").Value
                    Dim tipo = DGV_Activos.CurrentRow.Cells("Tipo_A").Value
                    Dim marca = DGV_Activos.CurrentRow.Cells("Marca_A").Value
                    Dim modelo = DGV_Activos.CurrentRow.Cells("Modelo_A").Value
                    Dim color = DGV_Activos.CurrentRow.Cells("Color_A").Value
                    Dim anio = DGV_Activos.CurrentRow.Cells("Anio_A").Value
                    If (controlador.EditarActivo(valorSeleccionado, chasis, tipo, marca, modelo, color, anio)) Then
                        MessageBox.Show("Se editó la información del activo con placa: " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'DGV_clientes.ReadOnly = True
                        bloquearCeldasActivos()
                    End If
                Else
                    conn.desconexion()
                    bloquearCeldasActivos()
                    controlador.CargarTablaActivos()
                End If
            Catch ex As Exception
                MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                bloquearCeldasActivos()
            End Try
            'DGV_Activos.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
        End If

    End Sub
    Public Sub bloquearCeldasActivos()
        DGV_Activos.Columns("Chasis_A").ReadOnly = True
        DGV_Activos.Columns("Tipo_A").ReadOnly = True
        DGV_Activos.Columns("Marca_A").ReadOnly = True
        DGV_Activos.Columns("Modelo_A").ReadOnly = True
        DGV_Activos.Columns("Color_A").ReadOnly = True
        DGV_Activos.Columns("Anio_A").ReadOnly = True
    End Sub

    Private Sub BTN_editarSIM_Click(sender As Object, e As EventArgs) Handles BTN_editarSIM.Click
        DGV_Sim.ReadOnly = False
        DGV_Sim.Columns("ICC_S").ReadOnly = True
        DGV_Sim.Columns("Numero_S").ReadOnly = False
        DGV_Sim.Columns("Propietario_S").ReadOnly = False
        DGV_Sim.Columns("Vence_S").ReadOnly = False
        DGV_Sim.Columns("Plan_Datos_S").ReadOnly = False
        DGV_Sim.Columns("Compania_S").ReadOnly = False
    End Sub

    Private Sub DGV_Sim_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Sim.CellEndEdit

        If e.ColumnIndex = DGV_Sim.Columns("ICC_S").Index OrElse e.ColumnIndex = DGV_Sim.Columns("Numero_S").Index OrElse
            e.ColumnIndex = DGV_Sim.Columns("Propietario_S").Index OrElse e.ColumnIndex = DGV_Sim.Columns("Vence_S").Index OrElse
            e.ColumnIndex = DGV_Sim.Columns("Plan_Datos_S").Index OrElse e.ColumnIndex = DGV_Sim.Columns("Compania_S").Index Then
            'Aquí va tu código para guardar cambios
            Try
                Dim resultado = MessageBox.Show("¿Desea editar la información del SIM con ICC " & valorSeleccionado & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                If resultado = DialogResult.OK Then
                    Dim icc = DGV_Sim.CurrentRow.Cells("ICC_S").Value
                    Dim numero = DGV_Sim.CurrentRow.Cells("Numero_S").Value
                    Dim propietario = DGV_Sim.CurrentRow.Cells("Propietario_S").Value
                    Dim vence = DGV_Sim.CurrentRow.Cells("Vence_S").Value
                    Dim plan_datos = DGV_Sim.CurrentRow.Cells("Plan_Datos_S").Value
                    Dim compania = DGV_Sim.CurrentRow.Cells("Compania_S").Value
                    If (controlador.EditarSim(icc, numero, propietario, vence, plan_datos, compania)) Then
                        MessageBox.Show("Se editó la información del SIM con ICC: " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'DGV_clientes.ReadOnly = True
                        bloquearCeldasSIM()
                    End If
                Else
                    conn.desconexion()
                    bloquearCeldasSIM()
                    controlador.CargarTablaActivos()
                End If
            Catch ex As Exception
                MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                bloquearCeldasSIM()
            End Try
            'DGV_Activos.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
        End If
    End Sub
    Private Sub bloquearCeldasSIM()
        DGV_Sim.Columns("Numero_S").ReadOnly = True
        DGV_Sim.Columns("Propietario_S").ReadOnly = True
        DGV_Sim.Columns("Vence_S").ReadOnly = True
        DGV_Sim.Columns("Plan_Datos_S").ReadOnly = True
        DGV_Sim.Columns("Compania_S").ReadOnly = True
    End Sub

    Private Sub BTN_editarUsuario_Click(sender As Object, e As EventArgs) Handles BTN_editarUsuario.Click
        DGV_Usuarios.ReadOnly = False
        DGV_Usuarios.Columns("Nombre_U").ReadOnly = False
        DGV_Usuarios.Columns("Rol_U").ReadOnly = False
    End Sub
    Private Sub DGV_Usuarios_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Usuarios.CellEndEdit

        If e.ColumnIndex = DGV_Usuarios.Columns("Nombre_U").Index OrElse
            e.ColumnIndex = DGV_Usuarios.Columns("Rol_U").Index Then
            'Aquí va tu código para guardar cambios
            Try
                Dim resultado = MessageBox.Show("¿Desea editar la información del usuario " & valorSeleccionado & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                If resultado = DialogResult.OK Then
                    Dim usuario = DGV_Usuarios.CurrentRow.Cells("Nombre_U").Value
                    Dim rol = DGV_Usuarios.CurrentRow.Cells("Rol_U").Value
                    If (controlador.EditarUsuario(valorSeleccionado, usuario, rol)) Then
                        MessageBox.Show("Se editó la información del usuario " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'DGV_Usuarios.ReadOnly = True
                        bloquearCeldasUsuarios()
                    End If
                Else
                    conn.desconexion()
                    bloquearCeldasUsuarios()
                    controlador.CargarTablaClientes()
                End If
            Catch ex As Exception
                MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                bloquearCeldasUsuarios()
            End Try
            'DGV_Usuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
        End If
    End Sub
    Private Sub bloquearCeldasUsuarios()
        DGV_Usuarios.Columns("Nombre_U").ReadOnly = True
        DGV_Usuarios.Columns("Rol_U").ReadOnly = True
    End Sub

    ' Funcionalidades de los botonoes eliminar
    Private Sub BTN_eliminarClientes_Click(sender As Object, e As EventArgs) Handles BTN_eliminarClientes.Click
        Try
            Dim resultado = MessageBox.Show("¿Desea eliminar al cliente " & valorSeleccionado & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            If resultado = DialogResult.OK Then
                If (controlador.EliminarCliente(valorSeleccionado)) Then
                    MessageBox.Show("Se eliminó al cliente " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TB_buscarClientes.Text = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BTN_eliminarActivos_Click(sender As Object, e As EventArgs) Handles BTN_eliminarActivos.Click
        Try
            Dim resultado = MessageBox.Show("¿Desea eliminar el activo " & valorSeleccionado & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If resultado = DialogResult.OK Then
                If (controlador.EliminarActivo(valorSeleccionado)) Then
                    MessageBox.Show("Se eliminó el activo con placa " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TB_buscarActivos.Text = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BTN_eliminarSim_Click(sender As Object, e As EventArgs) Handles BTN_eliminarSim.Click
        Try
            Dim resultado = MessageBox.Show("¿Desea eliminar la sim con icc " & valorSeleccionado & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If resultado = DialogResult.OK Then
                If (controlador.EliminarSim(valorSeleccionado.ToString())) Then
                    MessageBox.Show("Se eliminó la sim con icc " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TB_buscarSim.Text = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BTN_eliminarUsuarios_Click(sender As Object, e As EventArgs) Handles BTN_eliminarUsuarios.Click
        Try
            Dim resultado = MessageBox.Show("¿Desea eliminar al usuario " & valorSeleccionado & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If resultado = DialogResult.OK Then
                If (controlador.EliminarUsuario(valorSeleccionado)) Then
                    MessageBox.Show("Se eliminó al usuario " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TB_buscarUsuario.Text = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Metodos para poder obtener el item de la primera columna de cada tabla
    Private Sub DGV_clientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_clientes.CellClick
        If DGV_clientes.SelectedRows.Count > 0 Then
            valorSeleccionado = DGV_clientes.CurrentRow.Cells(0)?.Value
        End If
    End Sub
    Private Sub DGV_Activos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Activos.CellClick
        If DGV_Activos.SelectedRows.Count > 0 Then
            valorSeleccionado = DGV_Activos.CurrentRow.Cells(0)?.Value
        End If
    End Sub
    Private Sub DGV_Equipos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Equipos.CellClick
        If DGV_Equipos.SelectedRows.Count > 0 Then
            valorSeleccionado = DGV_Equipos.CurrentRow.Cells(0)?.Value
        End If
    End Sub
    Private Sub DGV_Sim_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Sim.CellClick
        If DGV_Sim.SelectedRows.Count > 0 Then
            valorSeleccionado = DGV_Sim.CurrentRow.Cells(0)?.Value
        End If
    End Sub
    Private Sub DGV_Usuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Usuarios.CellClick
        If DGV_Usuarios.SelectedRows.Count > 0 Then
            valorSeleccionado = DGV_Usuarios.CurrentRow.Cells(0)?.Value
        End If
    End Sub
    Private Sub DGV_Marcas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Marcas.CellClick
        If DGV_Marcas.SelectedRows.Count > 0 Then
            valorSeleccionadoMarca = DGV_Marcas.CurrentRow.Cells(0)?.Value
        End If
    End Sub
    Private Sub DGV_Modelos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Modelos.CellClick
        If DGV_Modelos.SelectedRows.Count > 0 Then
            valorSeleccionado = DGV_Modelos.CurrentRow.Cells(0)?.Value
        End If
    End Sub

    Private Sub PanelCliente_Paint(sender As Object, e As PaintEventArgs) Handles PanelCliente.Paint
        DGV_clientes.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5") ' Establecemos el color al encabezado del datagridview.
        DGV_clientes.EnableHeadersVisualStyles = False ' Inhabilitamos el visual styles del header para poder implementar el color aplicado anteriormente.
    End Sub

    Private Sub PanelActivos_Paint(sender As Object, e As PaintEventArgs) Handles PanelActivos.Paint
        DGV_Activos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5") ' Establecemos el color al encabezado del datagridview.
        DGV_Activos.EnableHeadersVisualStyles = False ' Inhabilitamos el visual styles del header para poder implementar el color aplicado anteriormente.
    End Sub

    Private Sub PanelEquipos_Paint(sender As Object, e As PaintEventArgs) Handles PanelEquipos.Paint
        DGV_Equipos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5") ' Establecemos el color al encabezado del datagridview.
        DGV_Equipos.EnableHeadersVisualStyles = False ' Inhabilitamos el visual styles del header para poder implementar el color aplicado anteriormente.
    End Sub

    Private Sub PanelSIM_Paint(sender As Object, e As PaintEventArgs) Handles PanelSIM.Paint
        DGV_Sim.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5") ' Establecemos el color al encabezado del datagridview.
        DGV_Sim.EnableHeadersVisualStyles = False ' Inhabilitamos el visual styles del header para poder implementar el color aplicado anteriormente.
    End Sub

    Private Sub PanelUsuario_Paint(sender As Object, e As PaintEventArgs) Handles PanelUsuario.Paint
        DGV_Usuarios.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5") ' Establecemos el color al encabezado del datagridview.
        DGV_Usuarios.EnableHeadersVisualStyles = False ' Inhabilitamos el visual styles del header para poder implementar el color aplicado anteriormente.
    End Sub

    ' Busquedas en las tablas
    Private Sub TB_buscarClientes_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarClientes.TextChanged
        Dim searchText As String = TB_buscarClientes.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_clientes.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_clientes.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera (Nombre)
                Dim cellValue1 As String = row.Cells(0).Value.ToString().ToLower()

                ' Verificar si el texto de búsqueda está contenido en alguna de las celdas
                If cellValue1.Contains(searchText) Then
                    row.Visible = True ' Mostrar la fila si se encuentra una coincidencia
                Else
                    row.Visible = False ' Ocultar la fila si no hay coincidencia
                End If
            End If
        Next
    End Sub

    Private Sub TB_buscarActivos_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarActivos.TextChanged
        Dim searchText As String = TB_buscarActivos.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_Activos.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_Activos.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera y segunda columna (Placa o Chásis)
                Dim cellValue1 As String = row.Cells(0).Value.ToString().ToLower()
                Dim cellValue2 As String = row.Cells(1).Value.ToString().ToLower()

                ' Verificar si el texto de búsqueda está contenido en alguna de las celdas
                If cellValue1.Contains(searchText) Or cellValue2.Contains(searchText) Then
                    row.Visible = True ' Mostrar la fila si se encuentra una coincidencia
                Else
                    row.Visible = False ' Ocultar la fila si no hay coincidencia
                End If
            End If
        Next
    End Sub

    Private Sub TB_buscarEquipos_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarEquipos.TextChanged
        Dim searchText As String = TB_buscarEquipos.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_Equipos.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_Equipos.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera (IMEI)
                Dim cellValue1 As String = row.Cells(0).Value.ToString().ToLower()

                ' Verificar si el texto de búsqueda está contenido en alguna de las celdas
                If cellValue1.Contains(searchText) Then
                    row.Visible = True ' Mostrar la fila si se encuentra una coincidencia
                Else
                    row.Visible = False ' Ocultar la fila si no hay coincidencia
                End If
            End If
        Next
    End Sub

    Private Sub TB_buscarSim_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarSim.TextChanged
        Dim searchText As String = TB_buscarSim.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_Sim.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_Sim.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera y segunda columna (Icc y numero)
                Dim cellValue1 As String = row.Cells(0).Value.ToString().ToLower()
                Dim cellValue2 As String = row.Cells(1).Value.ToString().ToLower()

                ' Verificar si el texto de búsqueda está contenido en alguna de las celdas
                If cellValue1.Contains(searchText) Or cellValue2.Contains(searchText) Then
                    row.Visible = True ' Mostrar la fila si se encuentra una coincidencia
                Else
                    row.Visible = False ' Ocultar la fila si no hay coincidencia
                End If
            End If
        Next
    End Sub

    Private Sub TB_buscarUsuario_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarUsuario.TextChanged
        Dim searchText As String = TB_buscarUsuario.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_Usuarios.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_Usuarios.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera (Nombre de usuario)
                Dim cellValue1 As String = row.Cells(0).Value.ToString().ToLower()

                ' Verificar si el texto de búsqueda está contenido en alguna de las celdas
                If cellValue1.Contains(searchText) Then
                    row.Visible = True ' Mostrar la fila si se encuentra una coincidencia
                Else
                    row.Visible = False ' Ocultar la fila si no hay coincidencia
                End If
            End If
        Next
    End Sub

    Private Sub BTN_bajaEquipos_Click(sender As Object, e As EventArgs) Handles BTN_bajaEquipos.Click
        If controlador.DarBajaEquipo(valorSeleccionado) Then
            MessageBox.Show("Se dió de baja al equipo " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_buscarEquipos.Clear()
        End If
    End Sub

    Private Sub BTN_agregarModelo_Click(sender As Object, e As EventArgs) Handles BTN_agregarModelo.Click
        If valorSeleccionadoMarca <> "" Then
            Dim resultado = MessageBox.Show("¿Desea agregar un nuevo modelo a la marca " & valorSeleccionadoMarca & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If resultado = DialogResult.OK Then
                aux.agregarModelo(valorSeleccionadoMarca)
            End If
        Else
            MessageBox.Show("No se ha seleccionado ninguna marca de la tabla para agregar un nuevo modelo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' EXPORTAR TABLAS
    Private Sub BTN_exportarClientes_Click(sender As Object, e As EventArgs) Handles BTN_exportarClientes.Click

        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim worksheet As Excel.Worksheet = workbook.ActiveSheet

        ' Agregar encabezados
        For i As Integer = 0 To DGV_clientes.ColumnCount - 1
            worksheet.Cells(1, i + 1) = DGV_clientes.Columns(i).HeaderText
        Next

        ' Agregar datos 
        For i As Integer = 0 To DGV_clientes.RowCount - 1
            For j As Integer = 0 To DGV_clientes.ColumnCount - 1
                worksheet.Cells(i + 2, j + 1) = DGV_clientes.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        'Mostrar cuadro de diálogo para guardar archivo
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            workbook.SaveAs(saveDialog.FileName)
        End If

        excelApp.Quit()
    End Sub

    Private Sub BTN_exportarActivos_Click(sender As Object, e As EventArgs) Handles BTN_exportarActivos.Click
        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim worksheet As Excel.Worksheet = workbook.ActiveSheet

        ' Agregar encabezados
        For i As Integer = 0 To DGV_Activos.ColumnCount - 1
            worksheet.Cells(1, i + 1) = DGV_Activos.Columns(i).HeaderText
        Next

        ' Agregar datos 
        For i As Integer = 0 To DGV_Activos.RowCount - 1
            For j As Integer = 0 To DGV_Activos.ColumnCount - 1
                worksheet.Cells(i + 2, j + 1) = DGV_Activos.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        'Mostrar cuadro de diálogo para guardar archivo
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            workbook.SaveAs(saveDialog.FileName)
        End If

        excelApp.Quit()
    End Sub

    Private Sub BTN_exportarEquipos_Click(sender As Object, e As EventArgs) Handles BTN_exportarEquipos.Click
        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim worksheet As Excel.Worksheet = workbook.ActiveSheet

        ' Agregar encabezados
        For i As Integer = 0 To DGV_Equipos.ColumnCount - 1
            worksheet.Cells(1, i + 1) = DGV_Equipos.Columns(i).HeaderText
        Next

        ' Agregar datos 
        For i As Integer = 0 To DGV_Equipos.RowCount - 1
            For j As Integer = 0 To DGV_Equipos.ColumnCount - 1
                worksheet.Cells(i + 2, j + 1) = DGV_Equipos.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        'Mostrar cuadro de diálogo para guardar archivo
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            workbook.SaveAs(saveDialog.FileName)
        End If

        excelApp.Quit()
    End Sub

    Private Sub BTN_exportarSim_Click(sender As Object, e As EventArgs) Handles BTN_exportarSim.Click
        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim worksheet As Excel.Worksheet = workbook.ActiveSheet

        ' Agregar encabezados
        For i As Integer = 0 To DGV_Sim.ColumnCount - 1
            worksheet.Cells(1, i + 1) = DGV_Sim.Columns(i).HeaderText
        Next

        ' Agregar datos 
        For i As Integer = 0 To DGV_Sim.RowCount - 1
            For j As Integer = 0 To DGV_Sim.ColumnCount - 1
                worksheet.Cells(i + 2, j + 1) = DGV_Sim.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        'Mostrar cuadro de diálogo para guardar archivo
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            workbook.SaveAs(saveDialog.FileName)
        End If

        excelApp.Quit()
    End Sub

    Private Sub BTN_exportarUsuarios_Click(sender As Object, e As EventArgs) Handles BTN_exportarUsuarios.Click
        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim worksheet As Excel.Worksheet = workbook.ActiveSheet

        ' Agregar encabezados
        For i As Integer = 0 To DGV_Usuarios.ColumnCount - 1
            worksheet.Cells(1, i + 1) = DGV_Usuarios.Columns(i).HeaderText
        Next

        ' Agregar datos 
        For i As Integer = 0 To DGV_Usuarios.RowCount - 1
            For j As Integer = 0 To DGV_Usuarios.ColumnCount - 1
                worksheet.Cells(i + 2, j + 1) = DGV_Usuarios.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        'Mostrar cuadro de diálogo para guardar archivo
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            workbook.SaveAs(saveDialog.FileName)
        End If

        excelApp.Quit()
    End Sub
End Class