create table IDENTIFICADOR(
	nombre varchar(100) not null primary key,
	tipo int
)

create table vendedor(
	ci varchar(10) not null primary key,
	nombre varchar(100) not null,
	apellido varchar(100) not null
)

create table ventas(
	id int primary key not null,
	descrpcion varchar(100),
	precio money
)




insert into IDENTIFICADOR values
('EMPLEADO FLORES 2',1),
('EMPLEADO FLORES 3',1)

create procedure consulta_empleado(@nombre varchar(100))
as
begin
	if exists (select tipo from IDENTIFICADOR where nombre=@nombre and tipo=0)
	begin
		print('ADMINISTRADOR')
	end
	else
	begin 
		print('EMPLEADO')
	end
end

exec consulta_empleado'EMPLEADO FLORES 3'

create trigger borra
on ventas
after delete
as
begin
    insert into BORRADO
		select * from deleted
end


select * from ventas
insert into vendedor values
('12312','PEPITO','BRILLO')
insert into ventas values
(1,'PAPAYA',2.3,'12312'),
(2,'MANDARINA',2.3,'12312')


select * from BORRADO

delete from ventas where id=1