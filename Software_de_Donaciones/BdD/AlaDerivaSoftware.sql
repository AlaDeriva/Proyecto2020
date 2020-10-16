Create Database AlaDerivaSoftware
Use AlaDerivaSoftware


CREATE TABLE Usuario(
NombreUsuario VARCHAR (30) NOT NULL PRIMARY KEY,
Cargo ENUM ("Cliente", "Encargado", "Administrador") NOT NULL, 
Hash VARCHAR (100) NOT NULL, 
sal VARCHAR (100) NOT NULL);

CREATE TABLE Perfil(
NombreUsuario VARCHAR (30) NOT NULL PRIMARY KEY,
CI INT (8) NOT NULL unique,
Email VARCHAR (12) NOT NULL unique,
Nombre VARCHAR (12) NOT NULL,
Apellido VARCHAR (12) NOT NULL,
Telefono INT (20) NOT NULL unique);
o
CREATE TABLE Sesion(
ID INT (10) NOT NULL PRIMARY KEY AUTO_INCREMENT,
Estado ENUM ("Abierta","Cerrada") NOT NULL default "Abierta",
Fecha_Hora TIMESTAMP NOT NULL default current_timestamp);

CREATE TABLE Beneficiario(
ID INT (10) NOT NULL PRIMARY KEY AUTO_INCREMENT,
CI INT (8) NOT NULL unique,
Tipo ENUM ("Donante", "Destinatario") NOT NULL,
Nombre VARCHAR (12) NOT NULL,
Apellido VARCHAR (12) NOT NULL,
Telefono INT (20) NOT NULL unique,
Email VARCHAR (12) NOT NULL unique,
Direccion VARCHAR (12) NOT NULL unique);

CREATE TABLE Deposito(
ID INT (10) NOT NULL PRIMARY KEY AUTO_INCREMENT,
Ubicacion VARCHAR (20) NOT NULL unique,
Nombre VARCHAR (12) NOT NULL,
Telefono VARCHAR (20) NOT NULL unique,
Seccion VARCHAR (4) NOT NULL);

CREATE TABLE Donacion(
ID INT (10) NOT NULL PRIMARY KEY AUTO_INCREMENT,
Cantidad INT (10) NOT NULL,
Destino VARCHAR (20) NOT NULL unique,
Fecha_Hora Envio TIMESTAMP NOT NULL default current_timestamp
Fecha_Hora Entrega TIMESTAMP NOT NULL default current_timestamp);

CREATE TABLE Tiene(
NombreUsuario_Usuario VARCHAR (30) NOT NULL PRIMARY KEY,
NombreUsuario_Perfil VARCHAR (30) NOT NULL); 

CREATE TABLE Inicia(
ID_Sesion INT (10) NOT NULL PRIMARY KEY,
ID_Usuario INT (10) NOT NULL);

CREATE TABLE Supervisa(
ID INT (10) NOT NULL PRIMARY KEY AUTO_INCREMENT,
Donacion_ID INT (10) NOT NULL,
Usuario_NombreUsuario VARCHAR (20) NOT NULL,
Tipo ENUM ("Encargado", "AdmivcVnistrador") NOT NULL);

CREATE TABLE Recibe(
ID_Cliente INT (10) NOT NULL PRIMARY KEY,
ID_Donacion INT (10) NOT NULL);

CREATE TABLE Realiza(
ID_Donacion INT (10) NOT NULL PRIMARY KEY,
ID_Donante INT (10) NOT NULL);

CREATE TABLE Manejo(
ID INT (10) NOT NULL PRIMARY KEY AUTO_INCREMENT,
ID_Usuario INT (10) NOT NULL,
ID_Deposito INT (10) NOT NULL);

CREATE TABLE Almacenada(
ID_Donacion INT (10) NOT NULL PRIMARY KEY,
ID_Deposito INT (10) NOT NULL,
Direccion VARCHAR (20) NOT NULL,
Numero INT (10) NOT NULL,
Capcidad VARCHAR (20) NOT NULL,
Condicion VARCHAR (20) NOT NULL);

ALTER TABLE Tiene(
add constraint FK_Usuario_Tiene
foreign key (Usuario_NombreUsuario)
references Usuario(NombreUsuario)
on update cascade
on delete cascade);

ALTER TABLE Tiene(
add constraint FK_Perfil_Tiene
foreign key (Perfil_NombreUsuario)
references Perfil(NombreUsuario)
on update cascade
on delete cascade);

ALTER TABLE Inicia(
add constraint FK_Usuario_Inicia
foreign key (Usuario_UsuarioNombre)
references Usuario(UsuarioNombre)
on update cascade
on delete cascade);












