CREATE USER 'usuario1'@'%' IDENTIFIED BY '123456';

CREATE DATABASE asignacion;
USE asignacion;

GRANT ALL ON asignacion.* TO 'usuario1'@'%';
FLUSH PRIVILEGES;

#CREACION DE CATEDRATICOS
CREATE TABLE TBL_CATEDRATICO(
ID_CATEDRATICO INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE VARCHAR(255) NOT NULL,
APELLIDO VARCHAR(255) NOT NULL,
FECHA_NAC DATE NOT NULL,
CARNE INT NOT NULL UNIQUE,
CORREO_ELECTRONICO VARCHAR(255) NOT NULL UNIQUE,
TELEFONO INT NOT NULL UNIQUE,
ID_CURSOS INT NOT NULL
);

#CREACION DE CURSOS
CREATE TABLE TBL_CURSOS(
ID_CURSOS INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE_C VARCHAR(255) NOT NULL,
HORARIO DATETIME NOT NULL,
REQUISITOS VARCHAR(255) NOT NULL,	
CREDITOS INT NOT NULL,
SALON VARCHAR(255) NOT NULL,
SECCION VARCHAR(255) NOT NULL,
LABORATORIO VARCHAR(255) NOT NULL,
ID_FACULTAD INT NOT NULL,
FOREIGN KEY (ID_FACULTAD) REFERENCES TBL_FACULTAD(ID_FACULTAD)
);

#CREACION DE SEMESTRES
CREATE TABLE TBL_SEMESTRE(
ID_SEMESTRE INT AUTO_INCREMENT PRIMARY KEY,
CALENDARIO DATE NOT NULL, -- se dejo como date porque no es necesario el tiempo para este campo
NO_SEMESTRE INT NOT NULL,
ID_CURSOS INT NOT NULL,
FOREIGN KEY (ID_CURSOS) REFERENCES TBL_CURSOS(ID_CURSOS)
);

#CREACION DE FACULTADES
CREATE TABLE TBL_FACULTAD(
ID_FACULTAD INT AUTO_INCREMENT PRIMARY KEY,
COD_CARRERA INT NOT NULL,
NOMBRE_FACU VARCHAR(255) NOT NULL,
EDIFICIOS VARCHAR(255) NOT NULL,
ID_SEDE INT NOT NULL,
ID_JORNADA INT NOT NULL,
ID_CARRERA INT NOT NULL,
FOREIGN KEY (ID_SEDE) REFERENCES TBL_SEDE(ID_SEDE),
FOREIGN KEY (ID_JORNADA) REFERENCES TBL_JORNADA(ID_JORNADA),
FOREIGN KEY (ID_CARRERA) REFERENCES TBL_CARRERA (ID_CARRERA)
);

#CREACION DE CARRERAS
CREATE TABLE TBL_CARRERA(
ID_CARRERA INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE_CARRERA VARCHAR(255) NOT NULL,
CODIGO_CARRERA VARCHAR(255) NOT NULL,
PENSUM VARCHAR(255) NOT NULL
);

#CREACION DE LAS JORNADAS
CREATE TABLE TBL_JORNADA(
ID_JORNADA INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE_JORNADA VARCHAR(255) NOT NULL,
HORARIO TIME NOT NULL
);

#CREACION DE ESTUDIANTE
CREATE TABLE TBL_ESTUDIANTE (
ID_ESTUDIANTE INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE VARCHAR(50) NOT NULL,
APELLIDO VARCHAR(50) NOT NULL,
FECHA_NAC DATE NOT NULL,
CARNE INT NOT NULL UNIQUE,
CREDITOS_ACUMULADOS INT NOT NULL,
ID_CARRERA INT NOT NULL,
ID_CURSOS INT NOT NULL,
SECCION VARCHAR(10) NOT NULL
);

INSERT INTO TBL_ESTUDIANTE (NOMBRE, APELLIDO, FECHA_NAC, CARNE, CREDITOS_ACUMULADOS, ID_CARRERA, ID_CURSOS, SECCION)
VALUES
('Juan', 'Pérez', '2000-01-15', 123456, 30, 101, 202, 'A'),
('María', 'García', '1999-05-20', 654321, 45, 102, 203, 'B'),
('Carlos', 'Martínez', '2001-07-10', 789012, 60, 103, 204, 'A'),
('Laura', 'López', '2000-11-25', 345678, 50, 104, 205, 'C');

#CREACION DE TESORERIA
CREATE TABLE TBL_TESORERIA(
ID_TESORERIA INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE_PAGO VARCHAR(255) NOT NULL,
MONTO DECIMAL(8,2) NOT NULL,
FECHA_PAGO TIMESTAMP DEFAULT NOW(), -- creamos este comando para que registre la hora y fecha de cuando se hace el pago
ID_ESTUDIANTE INT NOT NULL,
FOREIGN KEY (ID_ESTUDIANTE) REFERENCES TBL_ESTUDIANTE(ID_ESTUDIANTE)
);

#CREACION DE LA SEDE PARA MAYOR CONTROL
CREATE TABLE TBL_SEDE(
ID_SEDE INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE_SEDE VARCHAR(255) NOT NULL,
UBICACION VARCHAR(255) NOT NULL
);

#CREACION DE USUARIOS PARA LA APLICACION
CREATE TABLE TBL_USUARIOS(
ID_USUARIO INT AUTO_INCREMENT PRIMARY KEY,
NOMBRE_USUARIO VARCHAR(255) NOT NULL,
CONTRASEÑA VARCHAR(255) NOT NULL,
CORREO_ELECTRONICO VARCHAR(255) NOT NULL UNIQUE,
TIPO_USUARIO ENUM('ESTUDIANTE', 'CATEDRATICO', 'ADMINISTRADOR') NOT NULL, -- se dejo estos 3 roles para nosotros
FECHA_CREACION TIMESTAMP DEFAULT NOW() -- se puso este campo para tener registro de los usuarios
);

INSERT INTO TBL_USUARIOS (NOMBRE_USUARIO, CONTRASEÑA, CORREO_ELECTRONICO, TIPO_USUARIO)
VALUES
('admin1', 'Contra215', 'administrador1@umg.com', 'ADMINISTRADOR');