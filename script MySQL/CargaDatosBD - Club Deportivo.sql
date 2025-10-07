-- 1. Insertar una PERSONA (será socio)
INSERT INTO PERSONA (nombre, apellido, dni, telefono, direccion, mail, apto_medico)
VALUES ('Ana', 'Gómez', 30123456, '11-1234-5678', 'Av. Siempre Viva 123', 'ana.gomez@email.com', TRUE);

-- 2. Insertar como SOCIO
INSERT INTO SOCIO (id_socio, fecha_alta, estado_membresia, carnet_entregado)
VALUES (LAST_INSERT_ID(), CURDATE(), 'Activo', TRUE);

-- 3. Insertar una CUOTA PENDIENTE para ese socio (ej: cuota de mayo 2025)
INSERT INTO CUOTA (id_socio, mes_a_pagar, valor_cuota, estado_pago)
VALUES (LAST_INSERT_ID(), '2025-05-01', 2500.00, 'Pendiente');

-- 4. Insertar otra PERSONA (será no socio)
INSERT INTO PERSONA (nombre, apellido, dni, telefono, direccion, mail, apto_medico)
VALUES ('Luis', 'Martínez', 31654321, '11-8765-4321', 'Calle Falsa 456', 'luis.martinez@email.com', FALSE);

-- 5. Insertar como NO_SOCIO
INSERT INTO NO_SOCIO (id_no_socio, fecha_ingreso)
VALUES (LAST_INSERT_ID(), CURDATE());

-- 6. Insertar una ACTIVIDAD
INSERT INTO ACTIVIDAD (nombre_actividad, valor_actividad, cupo_maximo)
VALUES ('Fútbol', 2500.00, 20);