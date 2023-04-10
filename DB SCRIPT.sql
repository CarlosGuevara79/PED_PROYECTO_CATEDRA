use master

create database ProyectoPED

use ProyectoPED;

create table TipoUsuario
(
id INT not null primary key identity,
tipoUsuario varchar(20)
);

insert
	into
	TipoUsuario (tipoUsuario)
values
('Administrador'),
('Visor'),
('Caja'),
('Guest');

-- SQLINES LICENSE FOR EVALUATION USE ONLY
create table usuario
(
id int primary key identity,
nombres varchar(50) not null,
apellidos varchar(50) not null,
email varchar(50) unique not null,
tipoUsuario int,
foreign key (tipousuario) references TipoUsuario(id),
contrasenia varchar(30) not null,
sexo char(1),
check (sexo = 'M'
or sexo = 'F'),
fechaNacimiento date
);

-- SQLINES LICENSE FOR EVALUATION USE ONLY
insert
	into
	usuario (nombres,
	apellidos,
	email,
	tipoUsuario,
	contrasenia,
	sexo,
	fechaNacimiento)
values ('Administrador',
'01',
'administrador_1@gmail.com',
1,
'Password01',
'M',
'2010-08-12');

-- SQLINES LICENSE FOR EVALUATION USE ONLY
insert
	into
	usuario (nombres,
	apellidos,
	email,
	tipoUsuario,
	contrasenia,
	sexo,
	fechaNacimiento)
values ('Visor',
'01',
'visor_01@gmail.com',
2,
'Password01',
'M',
'2005-03-15');

-- SQLINES LICENSE FOR EVALUATION USE ONLY
insert
	into
	usuario (nombres,
	apellidos,
	email,
	tipoUsuario,
	contrasenia,
	sexo,
	fechaNacimiento)
values ('Guest',
'01',
'guest_01@gmail.com',
3,
'Password01',
'M',
'2003-02-17');
