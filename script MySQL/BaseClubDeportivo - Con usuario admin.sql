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