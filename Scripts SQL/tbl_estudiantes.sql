CREATE USER 'usuario1'@'%' IDENTIFIED BY '123456';

CREATE DATABASE asignacion;
USE asignacion;

GRANT ALL ON asignacion.* TO 'usuario1'@'%';
FLUSH PRIVILEGES;

CREATE TABLE Admin_catedratico (
ID_admin INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
Nombre VARCHAR(50) NOT NULL,
Contra VARCHAR(50) NOT NULL,
Correo VARCHAR(50) UNIQUE NOT NULL,
Direccion VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_estudiante (
    ID_ESTUDIANTE INT AUTO_INCREMENT PRIMARY KEY,
    NOMBRE VARCHAR(50) NOT NULL,
    APELLIDO VARCHAR(50) NOT NULL,
    FECHA_NAC DATE NOT NULL,
    CARNE INT NOT NULL,
    CREDITOS_ACUMULADOS INT NOT NULL,
    ID_CARRERA INT NOT NULL,
    ID_CURSOS INT NOT NULL,
    SECCION VARCHAR(10) NOT NULL
);



INSERT INTO tbl_estudiante (NOMBRE, APELLIDO, FECHA_NAC, CARNE, CREDITOS_ACUMULADOS, ID_CARRERA, ID_CURSOS, SECCION)
VALUES
('Juan', 'Pérez', '2000-01-15', 123456, 30, 101, 202, 'A'),
('María', 'García', '1999-05-20', 654321, 45, 102, 203, 'B'),
('Carlos', 'Martínez', '2001-07-10', 789012, 60, 103, 204, 'A'),
('Laura', 'López', '2000-11-25', 345678, 50, 104, 205, 'C');

-- Insertar más registros en la tabla ESTUDIANTE

INSERT INTO tbl_estudiante (NOMBRE, APELLIDO, FECHA_NAC, CARNE, CREDITOS_ACUMULADOS, ID_CARRERA, ID_CURSOS, SECCION)
VALUES
('Ana', 'Torres', '2000-03-14', 123457, 25, 101, 202, 'A'),
('Luis', 'Morales', '1999-08-05', 654322, 40, 101, 202, 'A'),
('Paula', 'Ramírez', '2001-12-10', 789013, 55, 101, 202, 'A'),
('Jorge', 'Castro', '2000-06-21', 345679, 45, 101, 202, 'A'),
('Sofia', 'Vásquez', '1999-11-18', 123458, 35, 101, 202, 'A'),

('Carla', 'Mendoza', '2001-02-27', 654323, 42, 102, 203, 'B'),
('Fernando', 'Gutiérrez', '2000-07-16', 789014, 50, 102, 203, 'B'),
('Gabriela', 'Pineda', '1999-04-12', 345680, 38, 102, 203, 'B'),
('Pedro', 'Jiménez', '2000-09-23', 123459, 47, 102, 203, 'B'),
('Lorena', 'García', '1999-10-30', 654324, 53, 102, 203, 'B'),

('Diego', 'Ortega', '2000-05-14', 789015, 30, 103, 204, 'C'),
('Marta', 'Herrera', '1999-12-05', 345681, 48, 103, 204, 'C'),
('Ricardo', 'Pérez', '2001-01-30', 123460, 50, 103, 204, 'C'),
('Natalia', 'Ruiz', '2000-11-19', 654325, 55, 103, 204, 'C'),
('Marcelo', 'Sánchez', '1999-06-20', 789016, 37, 103, 204, 'C'),

('Valeria', 'Gómez', '2000-10-15', 345682, 29, 104, 205, 'D'),
('Andrés', 'Cordero', '1999-09-10', 123461, 44, 104, 205, 'D'),
('Cristina', 'López', '2001-04-20', 654326, 52, 104, 205, 'D'),
('Oscar', 'Rivas', '2000-02-28', 789017, 46, 104, 205, 'D'),
('Isabel', 'Figueroa', '1999-07-17', 345683, 41, 104, 205, 'D');
