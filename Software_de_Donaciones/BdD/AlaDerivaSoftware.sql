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
Email VARCHAR (30) NOT NULL unique,
Nombre VARCHAR (12) NOT NULL,
Apellido VARCHAR (12) NOT NULL,
Telefono VARCHAR (20) NOT NULL unique);

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
Telefono VARCHAR (20) NOT NULL unique,
Email VARCHAR (30) NOT NULL unique,
Direccion VARCHAR (30) NOT NULL unique);

CREATE TABLE Deposito(
ID INT (10) NOT NULL PRIMARY KEY AUTO_INCREMENT,
Ubicacion VARCHAR (20) NOT NULL unique,
Nombre VARCHAR (12) NOT NULL,
Telefono VARCHAR (20) NOT NULL unique);

CREATE TABLE Chatea(
ID INT (10) NOT NULL PRIMARY KEY AUTO_INCREMENT,
Mensaje VARCHAR (120) NOT NULL,
UsuarioE VARCHAR (30) NOT NULL,
UsuarioR VARCHAR (30) NOT NULL,
EstadoMsg ENUM ("Leido", "No_Leido") NOT NULL default "No_Leido",
Hora TIMESTAMP NOT NULL default current_timestamp);

CREATE TABLE Donacion(
ID INT (10) NOT NULL PRIMARY KEY AUTO_INCREMENT,
Cantidad INT (4) NOT NULL,
Destino VARCHAR (20) NOT NULL unique,
Fecha_Hora_Envio TIMESTAMP NOT NULL default current_timestamp,
Fecha_Hora_Entrega TIMESTAMP NOT NULL default current_timestamp
Categoria ENUM ("Comida","Dinero","Ropa","Miscélaneo") NOT NULL default "Miscélaneo");

CREATE TABLE Tiene(
NombreUsuario_Usuario VARCHAR (30) NOT NULL PRIMARY KEY,
NombreUsuario_Perfil VARCHAR (30) NOT NULL); 

CREATE TABLE Inicia(
ID_Sesion INT (10) NOT NULL PRIMARY KEY,
NombreUsuario_Usuario VARCHAR (30) NOT NULL);

CREATE TABLE Supervisa(
ID INT (10) NOT NULL PRIMARY KEY AUTO_INCREMENT,
Donacion_ID INT (10) NOT NULL,
Usuario_NombreUsuario VARCHAR (20) NOT NULL,
Tipo ENUM ("Encargado", "Administrador") NOT NULL);

CREATE TABLE Recibe(
ID_Beneficiario INT (10) NOT NULL,
ID_Donacion INT (10) NOT NULL PRIMARY KEY);

CREATE TABLE Realiza(
ID_Donacion INT (10) NOT NULL PRIMARY KEY,
ID_Beneficiario INT (10) NOT NULL);

CREATE TABLE Manejo(
ID INT (10) NOT NULL PRIMARY KEY AUTO_INCREMENT,
NombreUsuario_Usuario VARCHAR (20) NOT NULL,
ID_Deposito INT (10) NOT NULL);

CREATE TABLE Almacenada(
ID_Donacion INT (10) NOT NULL PRIMARY KEY,
ID_Deposito INT (10) NOT NULL,
Direccion VARCHAR (20) NOT NULL,
Numero INT (10) NOT NULL,
Capacidad VARCHAR (20) NOT NULL,
Seccion_Almacenada VARCHAR (4) NOT NULL,
Observacion VARCHAR (120));

ALTER TABLE Tiene
add constraint FK_Usuario_Tiene
foreign key (NombreUsuario_Usuario)
references Usuario(NombreUsuario)
on update cascade
on delete cascade;

ALTER TABLE Tiene
add constraint FK_Tiene_Perfil
foreign key (NombreUsuario_Perfil)
references Perfil(NombreUsuario)
on update cascade
on delete cascade;

ALTER TABLE Inicia
add constraint FK_Usuario_Inicia
foreign key (NombreUsuario_Usuario)
references Usuario(NombreUsuario)
on update cascade
on delete cascade;

ALTER TABLE Inicia
add constraint FK_Inicia_Sesion
foreign key (ID_Sesion)
references Sesion(ID)
on update cascade
on delete cascade;

ALTER TABLE Chatea
add constraint FK_Usuario_Chatea
Foreign key (UsuarioE)
references Usuario(NombreUsuario)
on update cascade
on delete cascade;

ALTER TABLE Chatea
add constraint FK_Usuario_Chatea
Foreign key (UsuarioR)
references Usuario(NombreUsuario)
on update cascade
on delete cascade;

ALTER TABLE Manejo
add constraint FK_Usuario_Maneja 
Foreign Key (NombreUsuario_Usuario)
references Usuario(NombreUsuario)
on update cascade
on delete cascade;

ALTER TABLE Manejo
add constraint FK_Maneja_Deposito 
Foreign Key (ID_Deposito)
references Deposito(ID)
on update cascade
on delete cascade;

ALTER TABLE Supervisa
add constraint FK_Usuario_Supervisa
Foreign Key (Usuario_NombreUsuario)
References Usuario(NombreUsuario)
on update cascade
on delete cascade;

ALTER TABLE Supervisa
add constraint FK_Supervisa_Donacion
foreign key (Donacion_ID)
references Donacion(ID)
on update cascade
on delete cascade;

ALTER TABLE Recibe
add constraint FK_Beneficiaro_Recibe
Foreign Key (ID_Beneficiario)
references Beneficiario(ID)
on update cascade
on delete cascade;

ALTER TABLE Recibe
add constraint FK_Recibe_Donacion
Foreign Key (ID_Donacion)
references Donacion(ID)
on update cascade
on delete cascade;

ALTER TABLE Realiza
add constraint FK_Beneficiario_Realiza
Foreign Key (ID_Beneficiario)
references Beneficiario(ID)
on update cascade
on delete cascade;

ALTER TABLE Realiza
add constraint FK_Realiza_Donacion
Foreign Key (ID_Donacion)
references Donacion(ID)
on update cascade
on delete cascade;

ALTER TABLE Almacenada
add constraint FK_Donacion_Almacenada
Foreign Key (ID_Donacion)
references Donacion(ID)
on update cascade
on delete cascade;

ALTER TABLE Almacenada
add constraint FK_Almacenada_Deposito
Foreign Key (ID_Deposito)
references Deposito(ID)
on update cascade
on delete cascade;

















