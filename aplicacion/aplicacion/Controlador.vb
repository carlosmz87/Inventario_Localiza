Imports System.Numerics
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports MySqlConnector

Public Class Controlador
    Dim conn As New Conexion()
    Function IniciarSesion(ByVal usuario As String, ByVal contrasenia As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("SELECT USUARIO, CONTRASENIA, ROL FROM usuarios WHERE USUARIO=@USUARIO;", conn.connection)
            comando.Parameters.AddWithValue("@USUARIO", usuario)

            Dim dr As MySqlDataReader = comando.ExecuteReader()
            If dr.HasRows Then
                Dim usuarioDB As String = ""
                Dim contraseniaDB As String = ""
                Dim rolDB As String = ""
                While dr.Read()
                    usuarioDB = dr("USUARIO")
                    contraseniaDB = dr("CONTRASENIA")
                    rolDB = dr("ROL")
                End While
                ' Realizamos validaciones de login
                If usuario = usuarioDB And contrasenia = contraseniaDB Then
                    If rolDB = "ADMINISTRADOR" Then
                        MessageBox.Show("Bienvenido usuario administrador: " & usuarioDB & ".", "Acceso de authenticacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        conn.desconexion()
                        Login.Hide()
                        FormAdmin.Show()
                        Return True
                    End If
                    If rolDB = "USUARIO" Then
                        MessageBox.Show("Bienvenido usuario: " & usuarioDB & ".", "Acceso de authenticacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        conn.desconexion()
                        Return True
                    End If
                Else
                    MessageBox.Show("Usuario/contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    conn.desconexion()
                    Return False
                End If
            Else
                MessageBox.Show("Usuario no enocntrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                'Return False
            End If
            'conn.desconexion()
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function




    ' Clausulas para poder agregar datos a las tablas
    Function AgregarCliente(ByVal nombre As String, ByVal telefono As String, ByVal correo As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("INSERT INTO cliente(NOMBRE, TELEFONO, CORREO) VALUES(@NOMBRE, @TELEFONO, @CORREO);", conn.connection)

            comando.Parameters.Add("@NOMBRE", MySqlDbType.VarChar).Value = nombre.ToString()
            comando.Parameters.Add("@TELEFONO", MySqlDbType.VarChar).Value = telefono.ToString()
            comando.Parameters.Add("@CORREO", MySqlDbType.VarChar).Value = correo.ToString()
            'Verificamos que se haya insertado a la base datos 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaClientes()
                Return True
            Else
                MessageBox.Show("Error al intentar agregar el cliente" & nombre & " a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function AgregarActivo(ByVal placa As String, ByVal chasis As String, ByVal tipo As String, ByVal marca As String,
                           ByVal modelo As String, ByVal color As String, ByVal anio As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("INSERT INTO activo(PLACA, CHASIS, TIPO, MARCA, MODELO, COLOR, ANIO, ESTADO) 
                                            VALUES(@PLACA, @CHASIS, @TIPO, @MARCA, @MODELO, @COLOR, @ANIO, @ESTADO);", conn.connection)

            comando.Parameters.Add("@PLACA", MySqlDbType.VarChar).Value = placa.ToString()
            comando.Parameters.Add("@CHASIS", MySqlDbType.VarChar).Value = chasis.ToString()
            comando.Parameters.Add("@TIPO", MySqlDbType.VarChar).Value = tipo.ToString()
            comando.Parameters.Add("@MARCA", MySqlDbType.VarChar).Value = marca.ToString()
            comando.Parameters.Add("@MODELO", MySqlDbType.VarChar).Value = modelo.ToString()
            comando.Parameters.Add("@COLOR", MySqlDbType.VarChar).Value = color.ToString()
            comando.Parameters.Add("@ANIO", MySqlDbType.VarChar).Value = anio.ToString()
            comando.Parameters.Add("@ESTADO", MySqlDbType.VarChar).Value = "INHABILITADO"
            'Verificamos que se haya insertado a la base datos 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaActivos()
                Return True
            Else
                MessageBox.Show("Error al intentar agregar el activo con placa " & placa & " a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function AgregarEquipo_(ByVal imei As String, ByVal modelo As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("INSERT INTO EQUIPO (IMEI, ID_MODELO, ESTADO)
                                            SELECT @IMEI, (SELECT ID_MODELO  FROM MODELO_GPS WHERE MODELO = @MODELO),
                                            @ESTADO", conn.connection)

            comando.Parameters.Add("@IMEI", MySqlDbType.VarChar).Value = imei.ToString()
            comando.Parameters.Add("@MODELO", MySqlDbType.VarChar).Value = modelo.ToString()
            comando.Parameters.Add("@ESTADO", MySqlDbType.VarChar).Value = "INHABILITADO"
            'Verificamos que se haya insertado a la base datos 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaEquipos()
                Return True
            Else
                MessageBox.Show("Error al intentar agregar el equipo con " & imei & " a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function AgregarSim(ByVal icc As String, ByVal numero As String, ByVal compania As String, ByVal propietario As String,
                           ByVal plan_datos As String, ByVal fecha_vencimiento As String) As Boolean
        Try
            Dim fecha As DateTime = DateTime.Parse(fecha_vencimiento)
            Dim fechaString As String = fecha.ToString("yyyy-MM-dd")
            conn.conexion()
            Dim comando As New MySqlCommand("INSERT INTO sim(ICC, NUMERO, COMPANIA, PROPIETARIO, PLAN_DATOS, VENCE, ESTADO) 
                                            VALUES(@ICC, @NUMERO, @COMPANIA, @PROPIETARIO, @PLAN_DATOS, @VENCE, @ESTADO);", conn.connection)
            comando.Parameters.Add("@ICC", MySqlDbType.VarChar).Value = icc.ToString()
            comando.Parameters.Add("@NUMERO", MySqlDbType.VarChar).Value = numero.ToString()
            comando.Parameters.Add("@COMPANIA", MySqlDbType.VarChar).Value = compania.ToString()
            comando.Parameters.Add("@PROPIETARIO", MySqlDbType.VarChar).Value = propietario.ToString()
            comando.Parameters.Add("@PLAN_DATOS", MySqlDbType.VarChar).Value = plan_datos.ToString()
            comando.Parameters.Add("@VENCE", MySqlDbType.DateTime).Value = fechaString
            comando.Parameters.Add("@ESTADO", MySqlDbType.VarChar).Value = "INHABILITADO"
            'Verificamos que se haya insertado a la base datos 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaSIM()
                Return True
            Else
                MessageBox.Show("Error al intentar agregar la sim con icc " & icc & " a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function AgregarUsuario(ByVal nombre As String, ByVal rol As String, ByVal contrasenia As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("INSERT INTO usuarios(USUARIO, ROL, CONTRASENIA) VALUES(@USUARIO, @ROL, @CONTRASENIA);", conn.connection)

            comando.Parameters.Add("@USUARIO", MySqlDbType.VarChar).Value = nombre.ToString()
            comando.Parameters.Add("@ROL", MySqlDbType.VarChar).Value = rol.ToString()
            comando.Parameters.Add("@CONTRASENIA", MySqlDbType.VarChar).Value = contrasenia.ToString()
            'Verificamos que se haya insertado a la base datos 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaUsuarios()
                Return True
            Else
                MessageBox.Show("Error al intentar agregar al usuario " & nombre & " a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function




    ' Clausula para editar datos en las tablas
    Function Editarcliente(ByVal nombre As String, ByVal telefono As String, ByVal correo As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("UPDATE  cliente SET TELEFONO=@TELEFONO, CORREO=@CORREO WHERE NOMBRE=@NOMBRE", conn.connection)
            'comando.Parameters.Add("@ID", MySqlDbType.Int64).Value = id -----  WHERE ID=@ID
            comando.Parameters.Add("@NOMBRE", MySqlDbType.VarChar).Value = nombre
            comando.Parameters.Add("@TELEFONO", MySqlDbType.VarChar).Value = telefono
            comando.Parameters.Add("@CORREO", MySqlDbType.VarChar).Value = correo
            ' Verificamos que se haya actualizado solo 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaClientes()
                Return True
            Else
                MessageBox.Show("Error al intentar editar la información del cliente " & nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                CargarTablaClientes()
                Return False
            End If
        Catch ex As Exception
            ' MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            CargarTablaClientes()
            Return False
        End Try
    End Function
    Function EditarActivo(ByVal placa As String, ByVal chasis As String, ByVal tipo As String, ByVal marca As String,
                          ByVal modelo As String, ByVal color As String, ByVal anio As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("UPDATE  activo SET CHASIS=@CHASIS, TIPO=@TIPO, MARCA=@MARCA, MODELO=@MODELO, COLOR=@COLOR, ANIO=@ANIO WHERE PLACA=@PLACA", conn.connection)
            comando.Parameters.Add("@PLACA", MySqlDbType.VarChar).Value = placa
            comando.Parameters.Add("@CHASIS", MySqlDbType.VarChar).Value = chasis
            comando.Parameters.Add("@TIPO", MySqlDbType.VarChar).Value = tipo
            comando.Parameters.Add("@MARCA", MySqlDbType.VarChar).Value = marca
            comando.Parameters.Add("@MODELO", MySqlDbType.VarChar).Value = modelo
            comando.Parameters.Add("@COLOR", MySqlDbType.VarChar).Value = color
            comando.Parameters.Add("@ANIO", MySqlDbType.VarChar).Value = anio
            ' Verificamos que se haya actualizado solo 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaActivos()
                Return True
            Else
                MessageBox.Show("Error al intentar editar la información del activo con placa " & placa, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                CargarTablaActivos()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            CargarTablaActivos()
            Return False
        End Try
    End Function
    Function EditarSim(ByVal icc As String, ByVal numero As String, ByVal propietario As String, ByVal vence As String, ByVal plan As String, ByVal compania As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("UPDATE  sim SET NUMERO=@NUMERO, PROPIETARIO=@PROPIETARIO, VENCE=@VENCE, PLAN_DATOS=@PLAN_DATOS, COMPANIA=@COMPANIA WHERE ICC=@ICC", conn.connection)
            Dim fecha As DateTime = DateTime.Parse(vence)
            Dim fechaString As String = fecha.ToString("yyyy-MM-dd")
            comando.Parameters.Add("@ICC", MySqlDbType.VarChar).Value = icc
            comando.Parameters.Add("@NUMERO", MySqlDbType.VarChar).Value = numero
            comando.Parameters.Add("@PROPIETARIO", MySqlDbType.VarChar).Value = propietario
            comando.Parameters.Add("@VENCE", MySqlDbType.VarChar).Value = fechaString
            comando.Parameters.Add("@PLAN_DATOS", MySqlDbType.VarChar).Value = plan
            comando.Parameters.Add("@COMPANIA", MySqlDbType.VarChar).Value = compania
            ' Verificamos que se haya actualizado solo 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaSIM()
                Return True
            Else
                MessageBox.Show("Error al intentar editar la información del SIM con ICC " & icc, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function EditarUsuario(ByVal user_actual As String, ByVal usuario As String, ByVal rol As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("UPDATE  usuarios SET USUARIO=@USUARIO, ROL=@ROL WHERE USUARIO=@USUARIO_ACTUAL", conn.connection)
            comando.Parameters.Add("@USUARIO", MySqlDbType.VarChar).Value = usuario
            comando.Parameters.Add("@ROL", MySqlDbType.VarChar).Value = rol
            comando.Parameters.Add("@USUARIO_ACTUAL", MySqlDbType.VarChar).Value = user_actual
            ' Verificamos que se haya actualizado solo 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaUsuarios()
                Return True
            Else
                MessageBox.Show("Error al intentar editar la información del usuario " & user_actual, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                CargarTablaUsuarios()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            CargarTablaUsuarios()
            Return False
        End Try
    End Function




    ' Clausula para poder eliminar datos de las tablas
    Function EliminarCliente(ByVal nombre As String) As Boolean
        Try
            conn.conexion()
            Try
                Dim comando As New MySqlCommand("ELIMINARCLIENTE", conn.connection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@nombre_cliente", nombre)

                If comando.ExecuteNonQuery() > 0 Then
                    conn.desconexion()
                    ' Carga de tablas
                    CargarTablaClientes()
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End Try
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function EliminarActivo(ByVal placa As String) As Boolean
        Try
            conn.conexion()
            Try
                Dim comando As New MySqlCommand("ELIMINARACTIVO", conn.connection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@placa_activo", placa)

                If comando.ExecuteNonQuery() > 0 Then
                    conn.desconexion()
                    ' Carga de tablas
                    CargarTablaActivos()
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End Try
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function DarBajaEquipo(ByVal imei As String) As Boolean
        ' Codigo para baja de equipos aqui
        Try
            conn.conexion()
            Try
                Dim comando As New MySqlCommand("CALL darBajaEquipo(@p_imei)", conn.connection)
                comando.Parameters.AddWithValue("@p_imei", imei)
                ' Verificamos que se haya ejecutado el procedimiento
                If comando.ExecuteNonQuery() > 0 Then
                    conn.desconexion()
                    CargarTablaEquipos()
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End Try
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function EliminarSim(ByVal icc As String) As Boolean
        Try
            conn.conexion()
            Try
                Dim comando As New MySqlCommand("ELIMINARSIM", conn.connection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@icc_sim", icc)

                If comando.ExecuteNonQuery() > 0 Then
                    conn.desconexion()
                    ' Carga de tablas
                    CargarTablaSIM()
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End Try
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function EliminarUsuario(ByVal usuario As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("DELETE FROM usuarios WHERE USUARIO='" & usuario & "'", conn.connection)
            ' Verificamos que se haya eliminado 1 elemento de la tabla
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaUsuarios()
                Return True
            Else
                MessageBox.Show("Error al intentar elimnar al usuario " & usuario, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function



    ' Metodo para migrar sim
    Function MigrarSim(ByVal icc_actual As String, ByVal icc_nueva As String) As Boolean
        Try
            conn.conexion()
            Try
                Dim comando As New MySqlCommand("CALL migrarSIM(@p_icc_actual, @p_icc_nueva)", conn.connection)
                comando.Parameters.AddWithValue("@p_icc_actual", icc_actual)
                comando.Parameters.AddWithValue("@p_icc_nueva", icc_nueva)
                ' Verificamos que se haya ejecutado el procedimiento
                If comando.ExecuteNonQuery() > 0 Then
                    conn.desconexion()
                    CargarTablaSIM()
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End Try
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function


    ' Metodos para cargar las tablas 
    Function CargarTablaClientes() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT NOMBRE, TELEFONO, CORREO FROM cliente", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            FormAdmin.DGV_clientes.Columns("Nombre_C").DataPropertyName = "NOMBRE"
            FormAdmin.DGV_clientes.Columns("Telefono_C").DataPropertyName = "TELEFONO"
            FormAdmin.DGV_clientes.Columns("Correo_C").DataPropertyName = "CORREO"
            FormAdmin.DGV_clientes.DataSource = table

            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarTablaActivos() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT PLACA, CHASIS, TIPO, MARCA, MODELO, COLOR, ANIO FROM activo", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            FormAdmin.DGV_Activos.Columns("Placa_A").DataPropertyName = "PLACA"
            FormAdmin.DGV_Activos.Columns("Chasis_A").DataPropertyName = "CHASIS"
            FormAdmin.DGV_Activos.Columns("Tipo_A").DataPropertyName = "TIPO"
            FormAdmin.DGV_Activos.Columns("Marca_A").DataPropertyName = "MARCA"
            FormAdmin.DGV_Activos.Columns("Modelo_A").DataPropertyName = "MODELO"
            FormAdmin.DGV_Activos.Columns("Color_A").DataPropertyName = "COLOR"
            FormAdmin.DGV_Activos.Columns("Anio_A").DataPropertyName = "ANIO"
            FormAdmin.DGV_Activos.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarTablaEquipos() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT E.IMEI, MG.MARCA AS MARCA, MO.MODELO AS MODELO
                                                FROM EQUIPO E
                                                INNER JOIN MODELO_GPS MO ON E.ID_MODELO = MO.ID_MODELO
                                                INNER JOIN MARCA_GPS MG ON MO.ID_MARCA = MG.ID_MARCA;", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            FormAdmin.DGV_Equipos.Columns("IMEI_E").DataPropertyName = "IMEI"
            FormAdmin.DGV_Equipos.Columns("Modelo_E").DataPropertyName = "MODELO"
            FormAdmin.DGV_Equipos.Columns("Marca_E").DataPropertyName = "MARCA"
            FormAdmin.DGV_Equipos.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarTablaBajaEquipos() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT IMEI, FECHA_BAJA FROM BAJAS_EQUIPOS", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            BajaEquipos.DGV_bajaEquipos.Columns("IMEI").DataPropertyName = "IMEI"
            BajaEquipos.DGV_bajaEquipos.Columns("fecha").DataPropertyName = "FECHA_BAJA"
            BajaEquipos.DGV_bajaEquipos.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarTablaSIM() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT ICC, NUMERO, PROPIETARIO, VENCE, PLAN_DATOS, COMPANIA FROM sim", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            FormAdmin.DGV_Sim.Columns("ICC_S").DataPropertyName = "ICC"
            FormAdmin.DGV_Sim.Columns("Numero_S").DataPropertyName = "NUMERO"
            FormAdmin.DGV_Sim.Columns("Propietario_S").DataPropertyName = "PROPIETARIO"
            'FormAdmin.DGV_Sim.Columns("Vence_S").DefaultCellStyle.Format = "yyyy-MM-dd"
            FormAdmin.DGV_Sim.Columns("Vence_S").DataPropertyName = "VENCE"
            'FormAdmin.DGV_Sim.Columns("Vence_S").DefaultCellStyle.NullValue = DBNull.Value
            FormAdmin.DGV_Sim.Columns("Plan_Datos_S").DataPropertyName = "PLAN_DATOS"
            FormAdmin.DGV_Sim.Columns("Compania_S").DataPropertyName = "COMPANIA"
            FormAdmin.DGV_Sim.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarTablaUsuarios() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT USUARIO, ROL FROM usuarios;", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            FormAdmin.DGV_Usuarios.Columns("Nombre_U").DataPropertyName = "USUARIO"
            FormAdmin.DGV_Usuarios.Columns("Rol_U").DataPropertyName = "ROL"
            FormAdmin.DGV_Usuarios.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarTablaMigrarSim() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT ICC_ACTUAL, ICC_NUEVA, FECHA_MIGRACION FROM MIGRACION_SIM", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            MigracionSIM.DGV_migracionesSim.Columns("ICC_anterior").DataPropertyName = "ICC_ACTUAL"
            MigracionSIM.DGV_migracionesSim.Columns("ICC_nueva").DataPropertyName = "ICC_NUEVA"
            MigracionSIM.DGV_migracionesSim.Columns("fecha").DataPropertyName = "FECHA_MIGRACION"
            MigracionSIM.DGV_migracionesSim.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarTablaMarcas() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT MARCA FROM MARCA_GPS", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            FormAdmin.DGV_Marcas.Columns("MarcaMyM").DataPropertyName = "MARCA"
            FormAdmin.DGV_Marcas.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarTablaModelos() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT MODELO_GPS.MODELO, MARCA_GPS.MARCA
                                                FROM MODELO_GPS
                                                JOIN MARCA_GPS ON MODELO_GPS.ID_MARCA = MARCA_GPS.ID_MARCA;", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            FormAdmin.DGV_Modelos.Columns("ModeloMyM").DataPropertyName = "MODELO"
            FormAdmin.DGV_Modelos.Columns("Marca2MyM").DataPropertyName = "MARCA"
            FormAdmin.DGV_Modelos.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function




    ' Metodos para asignaciones
    Function asignacionSIM(ByVal imei_equipo As String, ByVal icc_sim As String) As Boolean
        Try
            conn.conexion()
            Try
                Dim comando As New MySqlCommand("CALL asignarSIM(@p_icc_sim, @p_imei_equipo)", conn.connection)
                comando.Parameters.AddWithValue("@p_icc_sim", icc_sim)
                comando.Parameters.AddWithValue("@p_imei_equipo", imei_equipo)
                If comando.ExecuteNonQuery() > 0 Then
                    conn.desconexion()
                    ' Carga de tablas
                    CargarTablaSim_Sim()
                    CargarTablaEquipo_Sim()
                    CargarTablaAsignaciones_Sim()
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End Try
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function asignacionEquipo(ByVal placa As String, ByVal imei_equipo As String, ByVal plataforma As String, ByVal adquisicion As String) As Boolean
        Try
            conn.conexion()
            Try
                Dim comando As New MySqlCommand("CALL asignarEquipo(@p_placa_activo, @p_imei_equipo, @p_id_plataforma, @p_tipo_adquisicion)", conn.connection)
                comando.Parameters.AddWithValue("@p_placa_activo", placa)
                comando.Parameters.AddWithValue("@p_imei_equipo", imei_equipo)
                comando.Parameters.AddWithValue("@p_id_plataforma", plataforma)
                comando.Parameters.AddWithValue("@p_tipo_adquisicion", adquisicion)
                If comando.ExecuteNonQuery() > 0 Then
                    conn.desconexion()
                    ' Carga de tablas
                    CargarTablaActivos_Equipo()
                    CargarTablaEquipo_Equipo()
                    CargarTablaAsignaciones_Equipo()
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End Try
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function asignacionActivo(ByVal cliente As String, ByVal activo As String) As Boolean
        Try
            conn.conexion()
            Try
                Dim comando As New MySqlCommand("CALL asignarActivo(@nombre_cliente, @placa_activo)", conn.connection)
                comando.Parameters.AddWithValue("@nombre_cliente", cliente)
                comando.Parameters.AddWithValue("@placa_activo", activo)
                If comando.ExecuteNonQuery() > 0 Then
                    conn.desconexion()
                    ' Carga de tablas
                    CargarTablaClientes_Activo()
                    CargarTablaActivos_Activo()
                    CargarTablaAsignaciones_Activo()
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End Try
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function



    ' Metodos para desasignaciones
    Function desasignacionSIM(ByVal imei_equipo As String, ByVal icc_sim As String) As Boolean
        Try
            conn.conexion()
            Try
                Dim comando As New MySqlCommand("desasignarSIM", conn.connection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@p_imei_equipo", imei_equipo)
                comando.Parameters.AddWithValue("@p_icc_sim", icc_sim)
                If comando.ExecuteNonQuery() > 0 Then
                    conn.desconexion()
                    ' Carga de tablas
                    CargarTablaSim_Sim()
                    CargarTablaEquipo_Sim()
                    CargarTablaAsignaciones_Sim()
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End Try
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function desasignacionEquipo(ByVal placa As String, ByVal imei_equipo As String) As Boolean
        Try
            conn.conexion()
            Try
                Dim comando As New MySqlCommand("DESASIGNAREQUIPO", conn.connection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@placa_activo", placa)
                comando.Parameters.AddWithValue("@imei_equipo", imei_equipo)
                If comando.ExecuteNonQuery() > 0 Then
                    conn.desconexion()
                    ' Carga de tablas
                    CargarTablaActivos_Equipo()
                    CargarTablaEquipo_Equipo()
                    CargarTablaAsignaciones_Equipo()
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End Try
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function desasignacionActivo(ByVal cliente As String, ByVal activo As String) As Boolean
        Try
            conn.conexion()
            Try
                Dim comando As New MySqlCommand("DESASIGNARACTIVO", conn.connection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@nombre_cliente", cliente)
                comando.Parameters.AddWithValue("@placa_activo", activo)

                If comando.ExecuteNonQuery() > 0 Then
                    conn.desconexion()
                    ' Carga de tablas
                    CargarTablaClientes_Activo()
                    CargarTablaActivos_Activo()
                    CargarTablaAsignaciones_Activo()
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End Try

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function


    ' Querys para cargar combobox's
    Function CargarModeloEquipo() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT MODELO FROM modelo_gps;", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            For Each row As DataRow In table.Rows
                AgregarEquipo.CB_modelo.Items.Add(row("MODELO"))
            Next
            conn.desconexion()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarPlataformaEquipo() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT NOMBRE FROM plataforma;", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            For Each row As DataRow In table.Rows
                AsignarEquipo.CB_plataforma.Items.Add(row("NOMBRE"))
            Next
            conn.desconexion()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function




    ' Querys para llenar tablas de asignacion de sim (equipo, sim y asignaciones)
    Function CargarTablaSim_Sim() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT ICC, NUMERO, PROPIETARIO, COMPANIA FROM sim WHERE ESTADO='INHABILITADO'", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            AsignarSIM.DGV_sim.Columns("ICCSim").DataPropertyName = "ICC"
            AsignarSIM.DGV_sim.Columns("NumeroSim").DataPropertyName = "NUMERO"
            AsignarSIM.DGV_sim.Columns("PropietarioSim").DataPropertyName = "PROPIETARIO"
            AsignarSIM.DGV_sim.Columns("CompaniaSim").DataPropertyName = "COMPANIA"
            AsignarSIM.DGV_sim.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarTablaEquipo_Sim() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT E.IMEI, MG.MARCA AS MARCA, MO.MODELO AS MODELO
                                                FROM EQUIPO E
                                                INNER JOIN MODELO_GPS MO ON E.ID_MODELO = MO.ID_MODELO
                                                INNER JOIN MARCA_GPS MG ON MO.ID_MARCA = MG.ID_MARCA
                                                WHERE E.ESTADO='INHABILITADO'", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            AsignarSIM.DGV_equipos.Columns("imeiEquipo").DataPropertyName = "IMEI"
            AsignarSIM.DGV_equipos.Columns("modeloEquipo").DataPropertyName = "MODELO"
            AsignarSIM.DGV_equipos.Columns("marcaEquipo").DataPropertyName = "MARCA"
            AsignarSIM.DGV_equipos.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarTablaAsignaciones_Sim() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT EQUIPO.IMEI AS IMEI, SIM.ICC AS ICC, SIM.NUMERO AS NUMERO, 
                                                SIM.PROPIETARIO AS PROPIETARIO, SIM.COMPANIA AS COMPANIA, ASIGNACION_SIM.FECHA_ASIGNACION_SIM
                                                FROM ASIGNACION_SIM
                                                INNER JOIN EQUIPO ON ASIGNACION_SIM.EQUIPO_EQUI_ID = EQUIPO.EQUI_ID
                                                INNER JOIN SIM ON ASIGNACION_SIM.SIM_SIM_ID = SIM.SIM_ID;", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            AsignarSIM.DGV_asignaciones.Columns("IMEIAsignacion").DataPropertyName = "IMEI"
            AsignarSIM.DGV_asignaciones.Columns("ICCAsignacion").DataPropertyName = "ICC"
            AsignarSIM.DGV_asignaciones.Columns("NumeroAsignacion").DataPropertyName = "NUMERO"
            AsignarSIM.DGV_asignaciones.Columns("PropietarioAsignacion").DataPropertyName = "PROPIETARIO"
            AsignarSIM.DGV_asignaciones.Columns("CompaniaAsignacion").DataPropertyName = "COMPANIA"
            AsignarSIM.DGV_asignaciones.Columns("FechaAsignacion").DataPropertyName = "FECHA_ASIGNACION_SIM"
            AsignarSIM.DGV_asignaciones.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function




    ' Querys para llenar tablas de asignacion de equipo (clientes, activos y asignaciones)
    Function CargarTablaActivos_Equipo() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT PLACA, CHASIS, MARCA FROM activo WHERE ESTADO='INHABILITADO'", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            AsignarEquipo.DGV_Activos.Columns("PlacaActivo").DataPropertyName = "PLACA"
            AsignarEquipo.DGV_Activos.Columns("ChasisActivo").DataPropertyName = "CHASIS"
            AsignarEquipo.DGV_Activos.Columns("MarcaActivo").DataPropertyName = "MARCA"
            AsignarEquipo.DGV_Activos.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarTablaEquipo_Equipo() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT E.IMEI, M.MODELO,  MP.MARCA, S.NUMERO
                                                FROM ASIGNACION_SIM ASig
                                                INNER JOIN EQUIPO E ON ASig.EQUIPO_EQUI_ID = E.EQUI_ID
                                                INNER JOIN MODELO_GPS M ON E.ID_MODELO = M.ID_MODELO  
                                                INNER JOIN MARCA_GPS MP ON M.ID_MARCA = MP.ID_MARCA
                                                INNER JOIN SIM S ON ASig.SIM_SIM_ID = S.SIM_ID
                                                WHERE E.ESTADO = 'HABILITADO'", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            AsignarEquipo.DGV_equipos.Columns("imeiEquipo").DataPropertyName = "IMEI"
            AsignarEquipo.DGV_equipos.Columns("modeloEquipo").DataPropertyName = "MODELO"
            AsignarEquipo.DGV_equipos.Columns("marcaEquipo").DataPropertyName = "MARCA"
            AsignarEquipo.DGV_equipos.Columns("numeroEquipo").DataPropertyName = "NUMERO"
            AsignarEquipo.DGV_equipos.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarTablaAsignaciones_Equipo() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT A.PLACA, E.IMEI, M.MODELO, MP.MARCA, AE.FECHA_ASIGNACION_EQUIPO, S.NUMERO
                                                FROM ASIGNACION_EQUIPO AE
                                                INNER JOIN ACTIVO A ON AE.ACTIVO_ACT_ID = A.ACT_ID
                                                INNER JOIN EQUIPO E ON AE.EQUIPO_EQUI_ID = E.EQUI_ID  
                                                INNER JOIN MODELO_GPS M ON E.ID_MODELO = M.ID_MODELO
                                                INNER JOIN MARCA_GPS MP ON M.ID_MARCA = MP.ID_MARCA
                                                INNER JOIN ASIGNACION_SIM ASIM ON E.EQUI_ID = ASIM.EQUIPO_EQUI_ID 
                                                INNER JOIN SIM S ON ASIM.SIM_SIM_ID = S.SIM_ID", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            AsignarEquipo.DGV_asignaciones.Columns("PlacaAsignacion").DataPropertyName = "PLACA"
            AsignarEquipo.DGV_asignaciones.Columns("NumeroAsignacion").DataPropertyName = "NUMERO"
            AsignarEquipo.DGV_asignaciones.Columns("IMEIAsignacion").DataPropertyName = "IMEI"
            AsignarEquipo.DGV_asignaciones.Columns("ModeloAsignacion").DataPropertyName = "MODELO"
            AsignarEquipo.DGV_asignaciones.Columns("MarcaAsignacion").DataPropertyName = "MARCA"
            AsignarEquipo.DGV_asignaciones.Columns("FechaAsignacion").DataPropertyName = "FECHA_ASIGNACION_EQUIPO"
            AsignarEquipo.DGV_asignaciones.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function



    ' Querys para llenar tablas de asignacion de activos (clientes, activos y asignaciones)
    Function CargarTablaClientes_Activo() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT NOMBRE, TELEFONO, CORREO FROM cliente", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            AsignarActivos.DGV_Clientes.Columns("NombreCliente").DataPropertyName = "NOMBRE"
            AsignarActivos.DGV_Clientes.Columns("TelefonoCliente").DataPropertyName = "TELEFONO"
            AsignarActivos.DGV_Clientes.Columns("CorreoCliente").DataPropertyName = "CORREO"
            AsignarActivos.DGV_Clientes.DataSource = table
            conn.desconexion()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarTablaActivos_Activo() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT A.PLACA, A.CHASIS, E.IMEI, M.MODELO, P.NOMBRE
                                                FROM ASIGNACION_EQUIPO AE
                                                INNER JOIN ACTIVO A ON AE.ACTIVO_ACT_ID = A.ACT_ID  
                                                INNER JOIN EQUIPO E ON AE.EQUIPO_EQUI_ID = E.EQUI_ID
                                                INNER JOIN MODELO_GPS M ON E.ID_MODELO = M.ID_MODELO
                                                INNER JOIN ASIGNACION_PLATAFORMA AP ON AE.ACTIVO_ACT_ID = AP.ACTIVO_ACT_ID
                                                INNER JOIN PLATAFORMA P ON AP.PLATAFORMA_PLAT_ID = P.PLAT_ID
                                                WHERE A.ESTADO = 'HABILITADO'", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            AsignarActivos.DGV_Activos.Columns("PlacaActivo").DataPropertyName = "PLACA"
            AsignarActivos.DGV_Activos.Columns("ChasisActivo").DataPropertyName = "CHASIS"
            AsignarActivos.DGV_Activos.Columns("IMEIActivo").DataPropertyName = "IMEI"
            AsignarActivos.DGV_Activos.Columns("ModeloActivo").DataPropertyName = "MODELO"
            AsignarActivos.DGV_Activos.Columns("PlataformaActivo").DataPropertyName = "NOMBRE"
            AsignarActivos.DGV_Activos.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function CargarTablaAsignaciones_Activo() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT C.NOMBRE, A.PLACA, A.CHASIS, S.NUMERO, E.IMEI, M.MODELO, AE.FECHA_ASIGNACION_EQUIPO
                                                FROM ASIGNACION_EQUIPO AE
                                                INNER JOIN ACTIVO A ON AE.ACTIVO_ACT_ID = A.ACT_ID  
                                                INNER JOIN EQUIPO E ON AE.EQUIPO_EQUI_ID = E.EQUI_ID
                                                INNER JOIN MODELO_GPS M ON E.ID_MODELO = M.ID_MODELO
                                                INNER JOIN ASIGNACION_SIM ASIM ON E.EQUI_ID = ASIM.EQUIPO_EQUI_ID
                                                INNER JOIN SIM S ON ASIM.SIM_SIM_ID = S.SIM_ID
                                                INNER JOIN ASIGNACION_ACTIVO AA ON A.ACT_ID = AA.ACTIVO_ACT_ID  
                                                INNER JOIN CLIENTE C ON AA.CLIENTE_CLI_ID = C.CLI_ID", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            AsignarActivos.DGV_asignaciones.Columns("NombreAsignacion").DataPropertyName = "NOMBRE"
            AsignarActivos.DGV_asignaciones.Columns("PlacaAsignacion").DataPropertyName = "PLACA"
            AsignarActivos.DGV_asignaciones.Columns("ChasisAsignacion").DataPropertyName = "CHASIS"
            AsignarActivos.DGV_asignaciones.Columns("NumeroAsignacion").DataPropertyName = "NUMERO"
            AsignarActivos.DGV_asignaciones.Columns("ImeiAsignacion").DataPropertyName = "IMEI"
            AsignarActivos.DGV_asignaciones.Columns("ModeloAsignacion").DataPropertyName = "MODELO"
            AsignarActivos.DGV_asignaciones.Columns("FechaAsignacion").DataPropertyName = "FECHA_ASIGNACION_EQUIPO"
            AsignarActivos.DGV_asignaciones.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    ' TABLA INFORME DE ACTIVOS
    Function CargarTablaPlataforma_InformeActivos(ByVal plataforma As String) As Boolean

        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT a.PLACA AS 'Placa', a.CHASIS AS 'Chasis', e.IMEI AS 'IMEI Equipo', m.MODELO AS 'Modelo Equipo'
                                                FROM ASIGNACION_PLATAFORMA ap
                                                INNER JOIN PLATAFORMA p ON ap.PLATAFORMA_PLAT_ID = p.PLAT_ID
                                                INNER JOIN ASIGNACION_EQUIPO ae ON ap.ACTIVO_ACT_ID = ae.ACTIVO_ACT_ID   
                                                INNER JOIN ACTIVO a ON ae.ACTIVO_ACT_ID = a.ACT_ID
                                                INNER JOIN EQUIPO e ON ae.EQUIPO_EQUI_ID = e.EQUI_ID
                                                INNER JOIN MODELO_GPS m ON e.ID_MODELO = m.ID_MODELO
                                                WHERE p.NOMBRE = '" & plataforma & "'
                                                ORDER BY a.PLACA;", conn.connection)
            Dim table As New DataTable()
            adapter.FillSchema(table, SchemaType.Source)
            adapter.Fill(table)

            InformeActivos.DGV_informeActivos.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try

    End Function
    Function CargarTablaAdquisicion_InformeActivos(ByVal adiquisiciom As String) As Boolean

        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT a.PLACA AS 'Placa', a.CHASIS AS 'Chasis', e.IMEI AS 'IMEI', m.MODELO AS 'Modelo'
                                                FROM ASIGNACION_EQUIPO ae
                                                INNER JOIN ACTIVO a ON ae.ACTIVO_ACT_ID = a.ACT_ID  
                                                INNER JOIN EQUIPO e ON ae.EQUIPO_EQUI_ID = e.EQUI_ID
                                                INNER JOIN MODELO_GPS m ON e.ID_MODELO = m.ID_MODELO
                                                WHERE ae.ESTADO = '" & adiquisiciom & "'
                                                ORDER BY a.PLACA", conn.connection)
            Dim table As New DataTable()
            adapter.FillSchema(table, SchemaType.Source)
            adapter.Fill(table)

            InformeActivos.DGV_informeActivos.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try

    End Function

    ' PARA MARCAS Y MODELOS
    Function agregarMarca(ByVal marca As String) As Boolean
        Try
            conn.conexion()
            Try
                Dim comando As New MySqlCommand("AGREGARMARCA", conn.connection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@p_nombre", marca)

                If comando.ExecuteNonQuery() > 0 Then
                    conn.desconexion()
                    ' Carga de tablas
                    CargarTablaMarcas()
                    Return True
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End Try

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function agregarModelo(ByVal marca As String, ByVal modelo As String) As Boolean
        Try
            conn.conexion()
            Try
                Dim comando As New MySqlCommand("AGREGARMODELO", conn.connection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@p_marca", marca)
                comando.Parameters.AddWithValue("@p_modelo", modelo)

                If comando.ExecuteNonQuery() > 0 Then
                    conn.desconexion()
                    ' Carga de tablas
                    CargarTablaMarcas()
                    CargarTablaModelos()
                    Return True
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End Try

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function


    ' REPORTES
    Function reportesGeneral() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("
            SELECT 
                'Equipos Totales' AS Descripcion, 
                (SELECT COUNT(*) FROM EQUIPO) AS Cantidad 
            UNION
            SELECT 
                'Equipos Habilitados' AS Descripcion, 
                (SELECT COUNT(*) FROM EQUIPO WHERE ESTADO = 'HABILITADO') AS Cantidad 
            UNION
            SELECT 
                'Equipos Inhabilitados' AS Descripcion, 
                (SELECT COUNT(*) FROM EQUIPO WHERE ESTADO = 'INHABILITADO') AS Cantidad 
            UNION
            SELECT 
                'SIMs Totales' AS Descripcion, 
                (SELECT COUNT(*) FROM SIM) AS Cantidad 
            UNION
            SELECT 
                'SIMs Habilitadas' AS Descripcion, 
                (SELECT COUNT(*) FROM SIM WHERE ESTADO = 'HABILITADO') AS Cantidad 
            UNION
            SELECT 
                'SIMs Inhabilitadas' AS Descripcion, 
                (SELECT COUNT(*) FROM SIM WHERE ESTADO = 'INHABILITADO') AS Cantidad 
            UNION
            SELECT 
                'Bajas de Equipo' AS Descripcion, 
                (SELECT COUNT(*) FROM BAJAS_EQUIPOS) AS Cantidad 
            UNION
            SELECT 
                'Migraciones de SIM' AS Descripcion, 
                (SELECT COUNT(*) FROM MIGRACION_SIM) AS Cantidad 
            UNION
            SELECT 
                'Asignaciones SIM' AS Descripcion, 
                (SELECT COUNT(*) FROM ASIGNACION_SIM) AS Cantidad 
            UNION
            SELECT 
                'Asignaciones Equipo' AS Descripcion, 
                (SELECT COUNT(*) FROM ASIGNACION_EQUIPO) AS Cantidad 
            UNION
            SELECT 
                'Asignaciones Activo' AS Descripcion, 
                (SELECT COUNT(*) FROM ASIGNACION_ACTIVO) AS Cantidad
            UNION
            SELECT 
                'Activos Activados' AS Descripcion, 
                (SELECT COUNT(*) FROM ACTIVO WHERE ESTADO = 'ACTIVADO') AS Cantidad 
            UNION
            SELECT 
                'Activos Habilitados' AS Descripcion, 
                (SELECT COUNT(*) FROM ACTIVO WHERE ESTADO = 'HABILITADO') AS Cantidad 
            UNION
            SELECT 
                'Activos Inhabilitados' AS Descripcion, 
                (SELECT COUNT(*) FROM ACTIVO WHERE ESTADO = 'INHABILITADO') AS Cantidad 
            UNION
            SELECT 
                'Activos en Venta' AS Descripcion, 
                (SELECT COUNT(*) FROM ASIGNACION_EQUIPO WHERE ESTADO = 'VENTA') AS Cantidad 
            UNION
            SELECT 
                'Activos en Renta' AS Descripcion, 
                (SELECT COUNT(*) FROM ASIGNACION_EQUIPO WHERE ESTADO = 'RENTA') AS Cantidad
            UNION
            SELECT 
                'Position Logic' AS Descripcion, 
                (SELECT COUNT(*) FROM ASIGNACION_PLATAFORMA WHERE PLATAFORMA_PLAT_ID = (SELECT PLAT_ID FROM PLATAFORMA WHERE NOMBRE = 'POSITION LOGIC')) AS Cantidad
            UNION
            SELECT 
                'Red GPS' AS Descripcion, 
                (SELECT COUNT(*)  FROM ASIGNACION_PLATAFORMA WHERE PLATAFORMA_PLAT_ID = (SELECT PLAT_ID FROM PLATAFORMA WHERE NOMBRE = 'RED GPS')) AS Cantidad;
                ", conn.connection)
            Dim table As New DataTable()
            adapter.FillSchema(table, SchemaType.Source)
            adapter.Fill(table)

            ReporteGeneral.DGV_reporteGeneral.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function reportesGeneralIntevalo(ByVal fecha_inicial As String, ByVal fecha_final As String) As Boolean
        Try
            conn.conexion()
            ' Parseamos las fechas para mysql
            Dim fechaI As DateTime = DateTime.Parse(fecha_inicial)
            Dim fechainicial As String = fechaI.ToString("yyyy-MM-dd")
            Dim fechaF As DateTime = DateTime.Parse(fecha_final)
            Dim fechafinal As String = fechaF.ToString("yyyy-MM-dd")

            Dim adapter As New MySqlDataAdapter("
            SELECT
                'Equipos asignados a activos' AS Descripcion,
                COUNT(DISTINCT AE.EQUIPO_EQUI_ID) AS Cantidad
                FROM ASIGNACION_EQUIPO AE
                LEFT JOIN EQUIPO E ON AE.EQUIPO_EQUI_ID = E.EQUI_ID
                WHERE AE.FECHA_ASIGNACION_EQUIPO BETWEEN '" & fechainicial & "' AND '" & fechafinal & "'
                AND E.ESTADO = 'ACTIVADO'
            UNION
            SELECT
                'Equipos no asignados a activos' AS Descripcion,
                COUNT(DISTINCT E.EQUI_ID) AS Cantidad
                FROM ASIGNACION_SIM ASIM
                LEFT JOIN EQUIPO E ON ASIM.EQUIPO_EQUI_ID = E.EQUI_ID
                WHERE ASIM.FECHA_ASIGNACION_SIM BETWEEN '" & fechainicial & "' AND '" & fechafinal & "'
                AND E.ESTADO = 'HABILITADO'
            UNION
            SELECT
                'Sim asignadas a equipos' AS Descripcion,
                COUNT(DISTINCT ASIM.SIM_SIM_ID) AS Cantidad
                FROM ASIGNACION_SIM ASIM
                LEFT JOIN SIM S ON ASIM.SIM_SIM_ID = S.SIM_ID
                WHERE ASIM.FECHA_ASIGNACION_SIM BETWEEN '" & fechainicial & "' AND '" & fechafinal & "'
                AND S.ESTADO = 'HABILITADO'
            UNION
            SELECT
                'Activos asignados a clientes' AS Descripcion,
                COUNT(DISTINCT AA.ACTIVO_ACT_ID) AS Cantidad
                FROM ASIGNACION_ACTIVO AA
                LEFT JOIN ACTIVO A ON AA.ACTIVO_ACT_ID = A.ACT_ID
                WHERE AA.FECHA BETWEEN '" & fechainicial & "' AND '" & fechafinal & "'
                AND A.ESTADO = 'ACTIVADO'
            UNION
            SELECT
                'Activos no asignados a clientes' AS Descripcion,
                COUNT(DISTINCT AE.ACTIVO_ACT_ID) AS Cantidad
                FROM ASIGNACION_EQUIPO AE
                LEFT JOIN ACTIVO A ON AE.ACTIVO_ACT_ID = A.ACT_ID
                WHERE AE.FECHA_ASIGNACION_EQUIPO BETWEEN '" & fechainicial & "' AND '" & fechafinal & "'
                AND A.ESTADO = 'HABILITADO'
            UNION
            SELECT
                'Activos en venta' AS Descripcion,
                COUNT(DISTINCT AE.ACTIVO_ACT_ID) AS Cantidad
                FROM ASIGNACION_EQUIPO AE
                LEFT JOIN EQUIPO E ON AE.EQUIPO_EQUI_ID = E.EQUI_ID
                WHERE AE.FECHA_ASIGNACION_EQUIPO BETWEEN '" & fechainicial & "' AND '" & fechafinal & "'
                AND AE.ESTADO = 'VENTA'
            UNION
            SELECT
                'Activos en renta' AS Descripcion,
                COUNT(DISTINCT AE.ACTIVO_ACT_ID) AS Cantidad
                FROM ASIGNACION_EQUIPO AE
                LEFT JOIN EQUIPO E ON AE.EQUIPO_EQUI_ID = E.EQUI_ID
                WHERE AE.FECHA_ASIGNACION_EQUIPO BETWEEN '" & fechainicial & "' AND '" & fechafinal & "'
                AND AE.ESTADO = 'RENTA'
            UNION
            SELECT
                'Activos con POSITION LOGIC' AS Descripcion,
                COUNT(DISTINCT AP.ACTIVO_ACT_ID) AS Cantidad
                FROM ASIGNACION_PLATAFORMA AP
                LEFT JOIN PLATAFORMA P ON AP.PLATAFORMA_PLAT_ID = P.PLAT_ID
                WHERE AP.FECHA_ASIGNACION BETWEEN '" & fechainicial & "' AND '" & fechafinal & "'
                AND P.NOMBRE = 'POSITION LOGIC'
            UNION
            SELECT
                'Activos con RED GPS' AS Descripcion,
                COUNT(DISTINCT AP.ACTIVO_ACT_ID) AS Cantidad
                FROM ASIGNACION_PLATAFORMA AP
                LEFT JOIN PLATAFORMA P ON AP.PLATAFORMA_PLAT_ID = P.PLAT_ID
                WHERE AP.FECHA_ASIGNACION BETWEEN '" & fechainicial & "' AND '" & fechafinal & "'
                AND P.NOMBRE = 'RED GPS'", conn.connection)
            Dim table As New DataTable()
            adapter.FillSchema(table, SchemaType.Source)
            adapter.Fill(table)

            ReporteGeneral.DGV_reporteGeneral.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

End Class
