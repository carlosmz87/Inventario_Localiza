CREATE DATABASE INVENTARIO_TEST;
USE INVENTARIO_TEST;

CREATE TABLE ACTIVO 
(
 ACT_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 PLACA VARCHAR(10) UNIQUE,
 CHASIS VARCHAR(50) NOT NULL UNIQUE,
 TIPO VARCHAR(50) NOT NULL,
 MARCA VARCHAR(50) NOT NULL,
 MODELO VARCHAR(50) NOT NULL,
 COLOR VARCHAR(25),
 ANIO VARCHAR(5) NOT NULL,
 ESTADO VARCHAR(25) NOT NULL
);

CREATE TABLE BAJAS_EQUIPOS 
(
 BAJAS_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 IMEI VARCHAR(15) NOT NULL UNIQUE,
 FECHA_BAJA DATETIME NOT NULL
);

CREATE TABLE CLIENTE 
(
 CLI_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 NOMBRE VARCHAR(100) NOT NULL,
 TELEFONO VARCHAR(15),
 CORREO VARCHAR(150)
);

CREATE TABLE MARCA_GPS(
    ID_MARCA INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    MARCA VARCHAR(25) NOT NULL
);

CREATE TABLE MODELO_GPS(
    ID_MODELO INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    ID_MARCA INT NOT NULL,
    MODELO VARCHAR(25) NOT NULL,
    FOREIGN KEY (ID_MARCA) REFERENCES MARCA_GPS(ID_MARCA)
);

CREATE TABLE EQUIPO 
(
 EQUI_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 ID_MODELO INT NOT NULL,
 IMEI VARCHAR(15) NOT NULL UNIQUE,
 ESTADO VARCHAR(25) NOT NULL,
 FOREIGN KEY (ID_MODELO) REFERENCES MODELO_GPS(ID_MODELO)
);

CREATE TABLE PLATAFORMA 
(
 PLAT_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 NOMBRE VARCHAR(50) NOT NULL
);

CREATE TABLE SIM 
(
 SIM_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 COMPANIA VARCHAR(15) NOT NULL,
 NUMERO VARCHAR(15) NOT NULL UNIQUE,
 ICC VARCHAR(30) NOT NULL UNIQUE,
 VENCE DATETIME NOT NULL,
 PROPIETARIO VARCHAR(75) NOT NULL,
 ESTADO VARCHAR(25) NOT NULL,
 PLAN_DATOS VARCHAR(250) NOT NULL
);

CREATE TABLE USUARIOS 
(
 ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 USUARIO VARCHAR(15) NOT NULL UNIQUE,
 CONTRASENIA TEXT NOT NULL,
 ROL VARCHAR(15) NOT NULL
);

CREATE TABLE MIGRACION_SIM 
(
 SIM_SIM_ID INT NOT NULL PRIMARY KEY,
 ICC_ACTUAL VARCHAR(30) NOT NULL UNIQUE,
 ICC_NUEVA VARCHAR(30) NOT NULL UNIQUE,
 FECHA_MIGRACION DATETIME NOT NULL,
 FOREIGN KEY (SIM_SIM_ID) REFERENCES SIM (SIM_ID)
);

CREATE TABLE ASIGNACION_SIM 
(
    ID_ASIGNACION INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 EQUIPO_EQUI_ID INT NOT NULL,
 SIM_SIM_ID INT NOT NULL,
 FECHA_ASIGNACION_SIM DATETIME NOT NULL,
 FOREIGN KEY (EQUIPO_EQUI_ID) REFERENCES EQUIPO (EQUI_ID),
 FOREIGN KEY (SIM_SIM_ID) REFERENCES SIM (SIM_ID)
);

CREATE TABLE ASIGNACION_PLATAFORMA 
(
ID_ASIGNACION INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 ACTIVO_ACT_ID INT NOT NULL,
 PLATAFORMA_PLAT_ID INT NOT NULL,
 FECHA_ASIGNACION DATETIME NOT NULL,
 FOREIGN KEY (ACTIVO_ACT_ID) REFERENCES ACTIVO (ACT_ID),
 FOREIGN KEY (PLATAFORMA_PLAT_ID) REFERENCES PLATAFORMA (PLAT_ID)
);

CREATE TABLE ASIGNACION_EQUIPO 
(
    ID_ASIGNACION INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 ACTIVO_ACT_ID INT NOT NULL,
 EQUIPO_EQUI_ID INT NOT NULL,
 FECHA_ASIGNACION_EQUIPO DATETIME NOT NULL,
 ESTADO VARCHAR(25) NOT NULL,
 FOREIGN KEY (ACTIVO_ACT_ID) REFERENCES ACTIVO (ACT_ID),
 FOREIGN KEY (EQUIPO_EQUI_ID) REFERENCES EQUIPO (EQUI_ID)
);

CREATE TABLE ASIGNACION_ACTIVO 
(
ID_ASIGNACION INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 ACTIVO_ACT_ID INT NOT NULL,
 CLIENTE_CLI_ID INT NOT NULL,
 FECHA DATETIME NOT NULL,
 FOREIGN KEY (ACTIVO_ACT_ID) REFERENCES ACTIVO (ACT_ID),
 FOREIGN KEY (CLIENTE_CLI_ID) REFERENCES CLIENTE (CLI_ID)
);

INSERT INTO USUARIOS( USUARIO, CONTRASENIA, ROL) VALUES
("admin", "d033e22ae348aeb5660fc2140aec35850c4da997", "ADMINISTRADOR");

INSERT INTO PLATAFORMA(NOMBRE) VALUES("POSITION LOGIC");
INSERT INTO PLATAFORMA(NOMBRE) VALUES("RED GPS");

-- QUECLINK: GV55, GV55N, GV55W, G300, GV300N, GV300W, GL300W
-- TELTONIKA:  FMC125, FMC130, FMC920, FMB910, FMB920

INSERT INTO MARCA_GPS(MARCA) VALUES("QUECLINK");
INSERT INTO MARCA_GPS(MARCA) VALUES("TELTONIKA");

INSERT INTO MODELO_GPS(ID_MARCA, MODELO) VALUES(1, "GV55");
INSERT INTO MODELO_GPS(ID_MARCA, MODELO) VALUES(1, "GV55N");
INSERT INTO MODELO_GPS(ID_MARCA, MODELO) VALUES(1, "GV55W");
INSERT INTO MODELO_GPS(ID_MARCA, MODELO) VALUES(1, "G300");
INSERT INTO MODELO_GPS(ID_MARCA, MODELO) VALUES(1, "GV300N");
INSERT INTO MODELO_GPS(ID_MARCA, MODELO) VALUES(1, "GV300W");
INSERT INTO MODELO_GPS(ID_MARCA, MODELO) VALUES(1, "GL300W");
INSERT INTO MODELO_GPS(ID_MARCA, MODELO) VALUES(2, "FMC125");
INSERT INTO MODELO_GPS(ID_MARCA, MODELO) VALUES(2, "FMC130");
INSERT INTO MODELO_GPS(ID_MARCA, MODELO) VALUES(2, "FMC920");
INSERT INTO MODELO_GPS(ID_MARCA, MODELO) VALUES(2, "FMB910");
INSERT INTO MODELO_GPS(ID_MARCA, MODELO) VALUES(2, "FMB920");

-- SELECT * FROM PLATAFORMA;

-- Apartado para las clausulas de creacion de procedimientos

-- PROCEDIMIENTO PARA LA BAJA DE EQUIPOS
DELIMITER //

CREATE PROCEDURE darBajaEquipo(
    IN p_imei VARCHAR(15)
)
BEGIN

    DECLARE estado VARCHAR(25);
    
    SELECT e.ESTADO INTO estado
    FROM EQUIPO e
    WHERE e.IMEI = p_imei;

    IF estado != 'INHABILITADO' THEN 
        SIGNAL SQLSTATE '45000' 
        SET MESSAGE_TEXT = 'Error: no se puede dar de baja al equipo porque se encuentra asignado.';
    END IF;
    
    INSERT INTO BAJAS_EQUIPOS (IMEI, FECHA_BAJA) 
    VALUES (p_imei, NOW());
    
    DELETE FROM EQUIPO WHERE IMEI = p_imei;

END //

DELIMITER ;

-- PROCEDIMIENTO PARA MIGRAR SIM
DELIMITER //

CREATE PROCEDURE migrarSIM(
    IN p_icc_actual VARCHAR(30), 
    IN p_icc_nueva VARCHAR(30)
    )
BEGIN

    DECLARE estado VARCHAR(25);

    SELECT s.ESTADO INTO estado
    FROM SIM s
    WHERE s.ICC = p_icc_actual;

    IF estado != 'INHABILITADO' THEN 
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: no se puede migrar porque la SIM se encuentra asignada.';
    END IF;

    UPDATE SIM 
    SET ICC = p_icc_nueva
    WHERE ICC = p_icc_actual;

    INSERT INTO MIGRACION_SIM (SIM_SIM_ID, ICC_ACTUAL, ICC_NUEVA, FECHA_MIGRACION)
    SELECT SIM_ID, p_icc_actual, p_icc_nueva, NOW() 
    FROM SIM
    WHERE ICC = p_icc_nueva;

END //

DELIMITER ;

-- PROCEDIMIENTO PARA ASGINAR SIM A EQUIPO
DELIMITER //

CREATE PROCEDURE asignarSIM(
    IN p_icc_sim VARCHAR(30), 
    IN p_imei_equipo VARCHAR(15)
)
BEGIN

    DECLARE estado_sim VARCHAR(25);
    DECLARE estado_equipo VARCHAR(25);

    SELECT s.ESTADO INTO estado_sim
    FROM SIM s
    WHERE s.ICC = p_icc_sim;

    SELECT e.ESTADO INTO estado_equipo 
    FROM EQUIPO e
    WHERE e.IMEI = p_imei_equipo;

    IF estado_sim != 'INHABILITADO' THEN 
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: al asignar la SIM (SIM asignada)';
    END IF;

    IF estado_equipo != 'INHABILITADO' THEN
        SIGNAL SQLSTATE '45000' 
        SET MESSAGE_TEXT = 'Error: al asignar la SIM (Equipo asignado)';
    END IF;

    INSERT INTO ASIGNACION_SIM(EQUIPO_EQUI_ID, SIM_SIM_ID, FECHA_ASIGNACION_SIM)
    SELECT EQUIPO.EQUI_ID, SIM.SIM_ID, NOW()
    FROM EQUIPO 
    INNER JOIN SIM ON EQUIPO.IMEI = p_imei_equipo AND SIM.ICC = p_icc_sim
    LIMIT 1;

    UPDATE EQUIPO 
    SET ESTADO = 'HABILITADO' 
    WHERE IMEI = p_imei_equipo;

    UPDATE SIM
    SET ESTADO = 'HABILITADO'
    WHERE ICC = p_icc_sim;

END//

DELIMITER ;

-- PROCEDIMIENTO PARA DESASIGNAR SIM DE EQUIPO
DELIMITER //
CREATE PROCEDURE desasignarSIM(
    IN p_imei_equipo VARCHAR(15),
    IN p_icc_sim VARCHAR(30)
)
BEGIN
    DECLARE estado_equipo VARCHAR(25);
    
    SELECT ESTADO INTO estado_equipo
    FROM EQUIPO
    WHERE IMEI = p_imei_equipo;

    IF estado_equipo = 'ACTIVADO' THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: no se puede desasignar la SIM (equipo asignado a activo).'; 
    END IF;

    DELETE FROM ASIGNACION_SIM
    WHERE EQUIPO_EQUI_ID = (SELECT EQUI_ID FROM EQUIPO WHERE IMEI = p_imei_equipo);
        
    UPDATE SIM SET ESTADO = 'INHABILITADO' 
    WHERE ICC = p_icc_sim;

    UPDATE EQUIPO  SET ESTADO = 'INHABILITADO'
    WHERE IMEI = p_imei_equipo;
  
END//

DELIMITER ;

-- PROCEDIMIENTO PARA ASIGNAR EQUIPO A ACTIVO 
DELIMITER //
CREATE PROCEDURE asignarEquipo(
  IN placa_activo VARCHAR(10),
  IN imei_equipo VARCHAR(15),
  IN plataforma VARCHAR(50),
  IN adquisicion VARCHAR(25)
)
BEGIN

    DECLARE estado_activo VARCHAR(25);
    DECLARE estado_equipo VARCHAR(25);

    SELECT a.ESTADO INTO estado_activo
    FROM ACTIVO a 
    WHERE a.PLACA = placa_activo;

    SELECT e.ESTADO INTO estado_equipo
    FROM EQUIPO e
    WHERE e.IMEI = imei_equipo;

    IF estado_activo != 'INHABILITADO' THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: al asignar el activo (activo asignado).';
    END IF;

    IF estado_equipo != 'HABILITADO' THEN 
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: al asignar el activo (equipo asignado a cliente o el equipo no contiene SIM asignada).';
    END IF;

    -- Primero se inserta la asignacion a ASIGNACION_EQUIPO
    INSERT INTO ASIGNACION_EQUIPO(ACTIVO_ACT_ID, EQUIPO_EQUI_ID, ESTADO, FECHA_ASIGNACION_EQUIPO)
    SELECT (SELECT ACT_ID FROM ACTIVO WHERE PLACA = placa_activo), AEI.EQUIPO_EQUI_ID, adquisicion, NOW()
    FROM ASIGNACION_SIM AEI
    WHERE AEI.EQUIPO_EQUI_ID = (SELECT EQUI_ID FROM EQUIPO WHERE IMEI = imei_equipo)
    LIMIT 1;

    -- Luego se inserta la asignacion a ASIGNACION_PLATAFORMA
    INSERT INTO ASIGNACION_PLATAFORMA(ACTIVO_ACT_ID, PLATAFORMA_PLAT_ID, FECHA_ASIGNACION)  
    SELECT AE.ACTIVO_ACT_ID,  (SELECT PLAT_ID FROM PLATAFORMA WHERE NOMBRE = plataforma), NOW()
    FROM ASIGNACION_EQUIPO AE 
    WHERE AE.ACTIVO_ACT_ID = (SELECT ACT_ID FROM ACTIVO WHERE PLACA = placa_activo)
    LIMIT 1;

    -- Luego se actualiza el estado del activo y del equipo
    UPDATE EQUIPO SET ESTADO = 'ACTIVADO'
    WHERE IMEI = imei_equipo;

    UPDATE ACTIVO  SET ESTADO = 'HABILITADO'
    WHERE PLACA = placa_activo;

END//
DELIMITER ; 

-- PROCEDIMIENTO PARA DESASIGNAR EQUIPO
DELIMITER //
CREATE PROCEDURE desasignarEquipo(
    IN placa_activo VARCHAR(10),
    IN imei_equipo VARCHAR(15)
)
BEGIN

    DECLARE estado VARCHAR(25);
  
    SELECT a.ESTADO INTO estado
    FROM ACTIVO a
    WHERE a.PLACA = placa_activo;

    IF estado = 'ACTIVADO' THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: al desasignar el equipo (activo asignado a cliente).';
    END IF;

    -- Eliminamos la asignacion de plataforma
    DELETE FROM ASIGNACION_PLATAFORMA
    WHERE ACTIVO_ACT_ID = (SELECT ACTIVO_ACT_ID FROM ASIGNACION_EQUIPO
    WHERE ACTIVO_ACT_ID = (SELECT ACT_ID FROM ACTIVO WHERE PLACA = placa_activo))
    LIMIT 1;
    
    -- Eliminamos la asignacion de equipo
    DELETE FROM ASIGNACION_EQUIPO 
    WHERE ACTIVO_ACT_ID = (SELECT ACT_ID FROM ACTIVO WHERE PLACA = placa_activo)
    AND EQUIPO_EQUI_ID = (SELECT EQUIPO_EQUI_ID FROM ASIGNACION_SIM 
    WHERE EQUIPO_EQUI_ID = (SELECT EQUI_ID FROM EQUIPO WHERE IMEI = imei_equipo))
    LIMIT 1;
                        
    -- Se cambia los estados del activo y del equipo
    UPDATE ACTIVO SET ESTADO = 'INHABILITADO' 
    WHERE PLACA = placa_activo;
    
    UPDATE EQUIPO SET ESTADO = 'HABILITADO'
    WHERE IMEI = imei_equipo;
        
  
END//

DELIMITER ;


-- PROCEDIMIENTO PARA LA ASIGNACION DE ACTIVOS
DELIMITER //
CREATE PROCEDURE asignarActivo(
    IN nombre_cliente VARCHAR(100),
    IN placa_activo VARCHAR(10)
)
BEGIN

    -- Insertamos a la tabla ASIGNACION:ACTIVO
    INSERT INTO ASIGNACION_ACTIVO(CLIENTE_CLI_ID, ACTIVO_ACT_ID, FECHA) 
    SELECT C.CLI_ID, AE.ACTIVO_ACT_ID, NOW()
    FROM CLIENTE C
    INNER JOIN ASIGNACION_EQUIPO AE ON AE.ACTIVO_ACT_ID = (SELECT ACT_ID FROM ACTIVO WHERE PLACA = placa_activo)
    WHERE C.NOMBRE = nombre_cliente
    LIMIT 1;

    -- Cambiamos el estado del activo
    UPDATE ACTIVO SET ESTADO = 'ACTIVADO' 
    WHERE PLACA = placa_activo;
  
END//

DELIMITER ;

-- PROCEDIMIENTO PARA DESASIGNAR ACTIVOS
DELIMITER //
CREATE PROCEDURE desasignarActivo(
    IN nombre_cliente VARCHAR(100),
    IN placa_activo VARCHAR(10)
)
BEGIN

    DECLARE estado VARCHAR(25);

    SELECT a.ESTADO INTO estado
    FROM ACTIVO a
    WHERE a.PLACA = placa_activo;

    IF estado != 'ACTIVADO' THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: el activo no ha sido asignado a un cliente.';
    END IF;

    -- Eliminamos el registro de la tabla ASIGNACION_ACTIVO
    DELETE FROM ASIGNACION_ACTIVO
    WHERE CLIENTE_CLI_ID = (SELECT CLI_ID FROM CLIENTE WHERE NOMBRE = nombre_cliente)
    AND ACTIVO_ACT_ID = (SELECT ACTIVO_ACT_ID FROM ASIGNACION_EQUIPO 
                            WHERE ACTIVO_ACT_ID = (SELECT ACT_ID FROM ACTIVO WHERE PLACA = placa_activo))
                            LIMIT 1;
                            
    UPDATE ACTIVO SET ESTADO = 'HABILITADO'
    WHERE PLACA = placa_activo;
  
END//  

DELIMITER ;

-- PROCEDIMIENTO PARA AGREGAR NUEVOS MODELOS DE GPS 
DELIMITER //
CREATE PROCEDURE agregarModelo(
    IN p_marca VARCHAR(30),
    IN p_modelo VARCHAR(30)
)
BEGIN
    DECLARE modelo INT;

    SELECT MODELO INTO modelo FROM MODELO_GPS WHERE MODELO = p_modelo;

    -- Validamos que el modelo no exista
    IF modelo IS NOT NULL THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: el modelo que desea ingresar ya existe.';
    END IF;

    INSERT INTO MODELO_GPS (ID_MARCA, MODELO)
    SELECT ID_MARCA, p_modelo
    FROM MARCA_GPS 
    WHERE MARCA = p_marca;

END //

DELIMITER ;

-- PROCEDIMIENTO PARA AGREGAR NUEVAS MARCAS DE GPS
DELIMITER //

CREATE PROCEDURE agregarMarca(IN p_nombre VARCHAR(30))
BEGIN
  
    DECLARE cantidad INT;

    SELECT COUNT(*) INTO cantidad
    FROM MARCA_GPS
    WHERE MARCA = p_nombre;

    IF cantidad > 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: la marca que desea ingresar ya existe.';
    ELSE
        INSERT INTO MARCA_GPS(MARCA) 
        VALUES (p_nombre);
    END IF;

END //

DELIMITER ;

-- PROCEDIMIENTO PARA ELIMINAR UNA SIM
DELIMITER //

CREATE PROCEDURE eliminarSIM(IN icc_sim VARCHAR(30))
BEGIN
    DECLARE sim_id1 INT;
    DECLARE sim_id2 INT;
    DECLARE sim_id3 INT;
    
    -- Buscar el ID de la SIM por su ICC
    SELECT SIM_ID INTO sim_id1 FROM SIM WHERE ICC = icc_sim;
    SELECT sim_id1;
    
    IF sim_id1 IS NOT NULL THEN


        
        -- Verificar si la SIM está asignada
        SELECT COUNT(*) INTO sim_id2 FROM ASIGNACION_SIM WHERE SIM_SIM_ID = sim_id1;
        
        IF sim_id2 > 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: la SIM está asignada y no se puede eliminar.';
        ELSE
        -- Eliminar la SIM de la tabla migraciones
        DELETE FROM MIGRACION_SIM 
        WHERE SIM_SIM_ID = sim_id1;
        -- Eliminar la SIM de la tabla SIM
        DELETE FROM SIM WHERE SIM_ID = sim_id1;
        END IF;
    ELSE
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: la SIM con ICC especificado no existe.';
    END IF;
END //

DELIMITER ;

-- PROCEDIMIENTO PARA ELIMINAR UN EQUIPO
DELIMITER //

CREATE PROCEDURE eliminarEquipo(IN imei_equipo VARCHAR(15))
BEGIN
    DECLARE equipo_id INT;
    DECLARE equipo_count INT;
    
    -- Buscar el ID del equipo por su IMEI
    SELECT EQUI_ID INTO equipo_id FROM EQUIPO WHERE IMEI = imei_equipo;
    
    IF equipo_id IS NOT NULL THEN
        
        -- Verificar si el equipo está asignado en la tabla ASIGNACION_SIM
        SELECT COUNT(*) INTO equipo_count FROM ASIGNACION_SIM WHERE EQUIPO_EQUI_ID = equipo_id;
        
        IF equipo_count > 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: el equipo está asignado y no se puede eliminar.';
        ELSE
        -- Eliminar el equipo
        DELETE FROM EQUIPO WHERE EQUI_ID = equipo_id;
        END IF;
    ELSE
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: el equipo con IMEI especificado no existe.';
    END IF;
END //

DELIMITER ;

-- PROCEDIMIENTO PARA ELIMINAR UN ACTIVO
DELIMITER //

CREATE PROCEDURE eliminarActivo(IN placa_activo VARCHAR(10))
BEGIN
    DECLARE activo_id INT;
    DECLARE activo_count INT;
    
    -- Buscar el ID del activo por su placa
    SELECT ACT_ID INTO activo_id FROM ACTIVO WHERE PLACA = placa_activo;
    
    IF activo_id IS NOT NULL THEN
        
        -- Verificar si el activo está asignado en la tabla ASIGNACION_EQUIPO
        SELECT COUNT(*) INTO activo_count FROM ASIGNACION_EQUIPO WHERE ACTIVO_ACT_ID = activo_id;
        
        IF activo_count > 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: el activo está asignado y no se puede eliminar.';
        ELSE
        -- Eliminar el activo
        DELETE FROM ACTIVO WHERE ACT_ID = activo_id;
        END IF;
    ELSE
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: el activo con la placa especificada no existe.';
    END IF;
END //

DELIMITER ;

-- PROCEDIMIENTO PARA ELIMINAR UN CLIENTE
DELIMITER //

CREATE PROCEDURE eliminarCliente(IN nombre_cliente VARCHAR(100))
BEGIN
    DECLARE cliente_id INT;
    DECLARE cliente_count INT;
    
    -- Buscar el ID del cliente por su nombre
    SELECT CLI_ID INTO cliente_id FROM CLIENTE WHERE NOMBRE = nombre_cliente;
    
    IF cliente_id IS NOT NULL THEN
        
        -- Verificar si el cliente está asignado en la tabla ASIGNACION_ACTIVO
        SELECT COUNT(*) INTO cliente_count FROM ASIGNACION_ACTIVO WHERE CLIENTE_CLI_ID = cliente_id;
        
        IF cliente_count > 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: el cliente está asignado y no se puede eliminar.';
        ELSE
        -- Eliminar el cliente
        DELETE FROM CLIENTE WHERE CLI_ID = cliente_id;
        END IF;
    ELSE
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: el cliente con el nombre especificado no existe.';
    END IF;
END //

DELIMITER ;