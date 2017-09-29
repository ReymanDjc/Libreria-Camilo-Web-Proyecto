create table Usuarios(
UsuarioId int identity(1,1) primary key, 
Nombres varchar(80), 
Clave varchar(20),
ConfirmarClave varchar(50),
Fecha date);


create table Clientes(
ClienteId int identity(1,1) primary key, 
Nombres varchar(80), 
Direccion varchar(100),
Email varchar(50),
Telefono varchar(15));

create table Productos(
ProductoId int identity(1,1) primary key, 
Descripcion varchar(100), 
Costo decimal,
Precio decimal,
Cantidad decimal);

create table Facturas(
FacturaId int identity(1,1) primary key, 
Fecha datetime,
SubTotal decimal,
Itbis decimal,
Total decimal,
NombreCliente varchar(80),
ClienteId int);

create table FacturasProductos(
FacturaId int, 
ProductoId int,
Cantidad int,
Precio int);