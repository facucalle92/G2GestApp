create database gest

use gest

drop table Servicio

create table Servicio(
id int identity(1,1) primary key not null,
nombreServicio varchar(50),
tipoServicio varchar(30),
precio int
)

insert into Servicio values ('Fibertel', 'Internet', 2500);
insert into Servicio values ('EPEC', 'Electrecidad', 1500);
insert into Servicio values ('Aguas Cordobesas', 'Agua', 700);

drop table Contrato

create table Contrato(
 id int identity(1,1) primary key not null,
 nroContrato int,
 monto int,
 metodoDePago varchar(30),
 condicionDePago varchar(30),
 tipoDeTrabajo varchar(30),
 fechaDeRealizacion dateTime,
 plazoDePago int,
 idServicio int foreign key references Servicio(id)
)