create database db_PuntoDeVenta

use db_PuntoDeVenta

create table Persona
(
ID int identity primary key not null,
Nombre varchar (50),
Apellidos varchar (50),
DNI varchar (50),
Telefono varchar (50),
Usuario varchar (50),
Clave varchar (50)
)

insert into Persona(Nombre, Apellidos, DNI, Telefono, Usuario, Clave) values('Jaret', 'Gonzalez', '123456', '1234567891', 'Jaret', '123')
select * from Persona
SELECT COUNT(*) FROM Persona WHERE Usuario = @Usuario AND Clave = @Clave