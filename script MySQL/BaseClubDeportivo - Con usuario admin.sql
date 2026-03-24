-- 0. Crear la base de datos (si no existe)
CREATE DATABASE IF NOT EXISTS BaseClubDeportivo;
USE BaseClubDeportivo;

-- 1. Tabla PERSONA (base para todos)
CREATE TABLE PERSONA (
    id_persona INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    dni INT UNIQUE NOT NULL,
    telefono VARCHAR(20),
    direccion VARCHAR(100),
    mail VARCHAR(100),
    apto_medico BOOLEAN NOT NULL DEFAULT FALSE
);

-- 2. Tabla SOCIO (Relacionada con la tabla PERSONA)
CREATE TABLE SOCIO (
    id_socio INT PRIMARY KEY,                              -- Clave Primaria. También es una Clave Foránea a la tabla PERSONA
    fecha_alta DATE NOT NULL,
    estado_membresia VARCHAR(50) NOT NULL,                 -- Ej: 'Activo', 'Suspendido'
    carnet_entregado BOOLEAN DEFAULT FALSE,                -- TRUE si ya se le dio el carnet
    FOREIGN KEY (id_socio) REFERENCES PERSONA(id_persona)  -- Relación 1 a 1 con PERSONA
);

-- 3. Tabla NO_SOCIO (Para personas que pagan por día)
CREATE TABLE NO_SOCIO (
    id_no_socio INT PRIMARY KEY,                              -- Clave Primaria. También es una Clave Foránea a la tabla PERSONA
    fecha_ingreso DATE NOT NULL,
    FOREIGN KEY (id_no_socio) REFERENCES PERSONA(id_persona)  -- Relación 1 a 1 con PERSONA
);

-- 4. Tabla ACTIVIDAD
CREATE TABLE ACTIVIDAD (
    id_actividad INT AUTO_INCREMENT PRIMARY KEY,
    nombre_actividad VARCHAR(100) NOT NULL UNIQUE,
    valor_actividad DECIMAL(10, 2) NOT NULL,                  -- Valor mensual de la actividad
    cupo_maximo INT                                           -- Para controlar cuántas personas pueden inscribirse
);

-- 5. Tabla PAGO_DIARIO
CREATE TABLE PAGO_DIARIO (
    id_recibo INT AUTO_INCREMENT PRIMARY KEY,
    id_no_socio INT NOT NULL,
    fecha_pago DATE NOT NULL,
    monto DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (id_no_socio) REFERENCES NO_SOCIO(id_no_socio)
);

-- 6. Tabla CUOTA (Registro de pagos de Socios)
CREATE TABLE CUOTA (
    id_cuota INT AUTO_INCREMENT PRIMARY KEY,
    id_socio INT NOT NULL,
    mes_a_pagar DATE NOT NULL,                        -- Ejemplo: '2025-10-01' para la cuota de Octubre 2025
    valor_cuota DECIMAL(10, 2) NOT NULL,
    fecha_pago DATE,                                  -- NULL si no se ha pagado, la fecha cuando se pagó
    forma_de_pago VARCHAR(50),                        -- Ej: 'Efectivo', 'Tarjeta'
    estado_pago VARCHAR(50) NOT NULL,                 -- Ej: 'Pagada', 'Pendiente', 'Vencida'
    FOREIGN KEY (id_socio) REFERENCES SOCIO(id_socio),
    UNIQUE KEY uk_socio_mes (id_socio, mes_a_pagar)   -- Un socio solo puede tener una cuota por mes
);

-- 7. Tabla INSCRIPCION (Para registrar a qué actividades asiste un Socio/No Socio)
CREATE TABLE INSCRIPCION (
    id_inscripcion INT AUTO_INCREMENT PRIMARY KEY,
    id_persona INT NOT NULL,                          -- Puede ser socio o no socio
    id_actividad INT NOT NULL,
    fecha_inscripcion DATE NOT NULL,
    FOREIGN KEY (id_persona) REFERENCES PERSONA(id_persona),
    FOREIGN KEY (id_actividad) REFERENCES ACTIVIDAD(id_actividad)
);

-- 8. TABLA: USUARIO (para login)
CREATE TABLE USUARIO (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nombre_usuario VARCHAR(50) NOT NULL UNIQUE,
    contrasena VARCHAR(100) NOT NULL,                 -- Por ahora en texto plano
    rol VARCHAR(30) DEFAULT 'Admin',
    activo BOOLEAN DEFAULT TRUE
);

-- Insertar un usuario administrador pre-cargado (para pruebas)
INSERT INTO USUARIO (nombre_usuario, contrasena, rol, activo)
VALUES ('admin', 'admin123', 'Admin', TRUE);

-- Insertar la forma en que paga el cliente
USE BaseClubDeportivo;
ALTER TABLE PAGO_DIARIO
ADD COLUMN forma_de_pago VARCHAR(50) NOT NULL DEFAULT 'Efectivo';

-- Ultimas modificaciones para incorporar a la estructura
USE BaseClubDeportivo;

-- 1. Agregar vencimiento del apto médico a la tabla PERSONA
ALTER TABLE PERSONA
ADD COLUMN fecha_venc_apto DATE NULL DEFAULT NULL AFTER apto_medico;

-- 2. Agregar detalles de pago a la tabla PAGO_DIARIO
ALTER TABLE PAGO_DIARIO
ADD COLUMN forma_de_pago VARCHAR(50) NOT NULL DEFAULT 'Efectivo',
ADD COLUMN num_cuotas INT NOT NULL DEFAULT 1;

-- 3. Agregar cantidad de cuotas a la tabla CUOTA (para pagos con tarjeta)
ALTER TABLE CUOTA
ADD COLUMN num_cuotas INT NOT NULL DEFAULT 1;


-- 4. Agregar SOLO la cantidad de cuotas a PAGO_DIARIO
ALTER TABLE PAGO_DIARIO
ADD COLUMN num_cuotas INT NOT NULL DEFAULT 1;

-- 5. Agregar la columna para la actividad
ALTER TABLE baseclubdeportivo.pago_diario 
ADD COLUMN id_actividad INT NOT NULL AFTER id_no_socio;

-- 6. Crea la relación (Foreign Key) para asegurar la integridad
ALTER TABLE baseclubdeportivo.pago_diario 
ADD CONSTRAINT fk_pago_actividad 
FOREIGN KEY (id_actividad) REFERENCES actividad(id_actividad);

-- 7. Crea StoreProcedures para Generación Masiva de Cuotas y el Control de Morosidad
USE BaseClubDeportivo;

DELIMITER //

-- 7.1. Procedimiento para generar las cuotas de todos los socios para el mes actual
CREATE PROCEDURE sp_GenerarCuotasMensuales(IN monto_cuota DECIMAL(10,2))
BEGIN
    INSERT INTO CUOTA (id_socio, mes_a_pagar, valor_cuota, estado_pago)
    SELECT id_socio, 
           LAST_DAY(CURDATE()), -- Vencimiento al último día del mes actual
           monto_cuota, 
           'Pendiente'
    FROM SOCIO
    WHERE estado_membresia = 'Activo'
    AND NOT EXISTS (
        SELECT 1 FROM CUOTA 
        WHERE id_socio = SOCIO.id_socio 
        AND MONTH(mes_a_pagar) = MONTH(CURDATE()) 
        AND YEAR(mes_a_pagar) = YEAR(CURDATE())
    );
END //

-- 7.2. Procedimiento para marcar automáticamente como Morosos a quienes vencieron ayer
CREATE PROCEDURE sp_ActualizarMorosos()
BEGIN
    UPDATE CUOTA 
    SET estado_pago = 'Vencido' 
    WHERE mes_a_pagar < CURDATE() 
    AND estado_pago = 'Pendiente';
END //

DELIMITER ;

-- 8 Crear un Stored Procedure que maneje la inserción en las tres tablas involucradas: PERSONA, SOCIO y la primera CUOTA.
USE BaseClubDeportivo;

DELIMITER //

CREATE PROCEDURE sp_AltaNuevoSocio(
    IN _nom VARCHAR(50), IN _ape VARCHAR(50), IN _dni INT, 
    IN _tel VARCHAR(20), IN _dir VARCHAR(100), IN _mail VARCHAR(100),
    IN _valorCuota DECIMAL(10,2)
)
BEGIN
    DECLARE _lastID INT;

    -- 1. Insertamos en la tabla base (Persona)
    INSERT INTO PERSONA (nombre, apellido, dni, telefono, direccion, mail, apto_medico)
    VALUES (_nom, _ape, _dni, _tel, _dir, _mail, 0);

    -- Obtenemos el ID generado automáticamente
    SET _lastID = LAST_INSERT_ID();

    -- 2. Insertamos en la tabla Socio (Vinculada por el ID)
    INSERT INTO SOCIO (id_socio, fecha_alta, estado_membresia, carnet_entregado)
    VALUES (_lastID, CURDATE(), 'Activo', 0);

    -- 3. Generamos la primera cuota (mes actual)
    INSERT INTO CUOTA (id_socio, mes_a_pagar, valor_cuota, estado_pago)
    VALUES (_lastID, LAST_DAY(CURDATE()), _valorCuota, 'Pendiente');
    
    -- Devolvemos el ID por si C# lo necesita
    SELECT _lastID;
END //

DELIMITER ;

-- 9. Procedimiento que registra a la persona, la marca como No Socio y le genera su primer pago diario (asociado a una actividad específica).
USE BaseClubDeportivo;

DELIMITER //

CREATE PROCEDURE sp_AltaNuevoNoSocio(
    IN _nom VARCHAR(50), IN _ape VARCHAR(50), IN _dni INT, 
    IN _tel VARCHAR(20), IN _dir VARCHAR(100), IN _mail VARCHAR(100),
    IN _idAct INT, IN _monto DECIMAL(10,2)
)
BEGIN
    DECLARE _lastID INT;

    -- 1. Insertamos en Persona
    INSERT INTO PERSONA (nombre, apellido, dni, telefono, direccion, mail, apto_medico)
    VALUES (_nom, _ape, _dni, _tel, _dir, _mail, 0);

    SET _lastID = LAST_INSERT_ID();

    -- 2. Insertamos en No Socio
    INSERT INTO NO_SOCIO (id_no_socio) VALUES (_lastID);

    -- 3. Insertamos el primer Pago Diario
    -- Usamos la columna 'monto' que verificamos en el Workbench
    INSERT INTO PAGO_DIARIO (id_no_socio, id_actividad, fecha_pago, monto, forma_de_pago)
    VALUES (_lastID, _idAct, CURDATE(), _monto, 'Efectivo');
    
    SELECT _lastID;
END //

DELIMITER ;

