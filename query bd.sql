use master 
go
if exists(select * from sysdatabases where name = 'Disermo') 
DROP DATABASE Disermo
go
create database Disermo
go
use Disermo
go

create table bajacliente(
Id_Motivo int primary key,
motivo varchar(50)
);
insert into bajacliente values('1','por meco')
insert into bajacliente values('0','no esta bloqueado')

go
--SELECT * FROM USUARIOS WHERE NombreUsuario='ADMINISTRADOR'
create table perfil(
Id_Perfil int primary key not null,
perfil varchar(20) not null
);
insert into perfil values('1','Administrador')
insert into perfil values('2','Vendedor')
insert into perfil values('3','Invitado')
go
create table fotos(
NombreUsuario varchar(50) primary key,
foto image
);
go


create table usuarios(
Id_Usuario int primary key not null,
NombreUsuario varchar(20) not null,
contraseña varchar(15) not null,
correo varchar(50),
telefono varchar(8),
Id_Perfil int not null,
ingresar tinyint not null,
modificar tinyint not null,
eliminar tinyint not null,
imprimir tinyint not null,
foto image,
foreign key(Id_Perfil) references perfil(Id_Perfil),
);
INSERT INTO usuarios values('1','Administrador','uwu','admin@admin.com','24456002','1','1','1','1','1','NULL')
INSERT INTO usuarios values('2','Invitado','uwu','admin@admin.com','24456002','2','1','1','1','1','NULL')
go
create table detperfil(
Id_Perfil int,
menu varchar(40),
activo int,
item varchar(40),
itemactivo int
);
go
-- administrador

insert into detperfil values('1','CuentaxCobrar','1','CXC1','1')
insert into detperfil values('1','CuentaxCobrar','1','CXC2','1')
insert into detperfil values('1','CuentaxCobrar','1','CXC3','1')
insert into detperfil values('1','CuentaxCobrar','1','CXC4','1')
insert into detperfil values('1','CuentaxCobrar','1','CXC5','1')

insert into detperfil values('1','CuentaxPagar','1','CXP1','1')
insert into detperfil values('1','CuentaxPagar','1','CXP2','1')
insert into detperfil values('1','CuentaxPagar','1','CXP3','1')
insert into detperfil values('1','CuentaxPagar','1','CXP4','1')
insert into detperfil values('1','CuentaxPagar','1','CXP5','1')

insert into detperfil values('1','Mantenimientos','1','Mant1','1')
insert into detperfil values('1','Mantenimientos','1','Mant2','1')
insert into detperfil values('1','Mantenimientos','1','Mant3','1')
insert into detperfil values('1','Mantenimientos','1','Mant4','1')
insert into detperfil values('1','Mantenimientos','1','Mant5','1')
insert into detperfil values('1','Mantenimientos','1','Mant6','1')
insert into detperfil values('1','Mantenimientos','1','Mant7','1')
insert into detperfil values('1','Mantenimientos','1','Mant8','1')
insert into detperfil values('1','Mantenimientos','1','Mant9','1')
insert into detperfil values('1','Mantenimientos','1','Mant10','1')
insert into detperfil values('1','Mantenimientos','1','Mant11','1')

insert into detperfil values('1','Movimientos','1','Mov1','1')
insert into detperfil values('1','Movimientos','1','Mov2','1')
insert into detperfil values('1','Movimientos','1','Mov3','1')
insert into detperfil values('1','Movimientos','1','Mov4','1')
insert into detperfil values('1','Movimientos','1','Mov5','1')
insert into detperfil values('1','Movimientos','1','Mov6','1')
insert into detperfil values('1','Movimientos','1','Mov7','1')
insert into detperfil values('1','Movimientos','1','Mov8','1')
insert into detperfil values('1','Movimientos','1','Mov9','1')
insert into detperfil values('1','Movimientos','1','Mov10','1')

insert into detperfil values('1','Utilitarios','1','Uti1','1')
insert into detperfil values('1','Utilitarios','1','Uti2','1')
insert into detperfil values('1','Utilitarios','1','Uti3','1')
insert into detperfil values('1','Utilitarios','1','Uti4','1')
insert into detperfil values('1','Utilitarios','1','Uti5','1')
insert into detperfil values('1','Utilitarios','1','Uti6','1')

-- Vendedor

insert into detperfil values('2','CuentaxCobrar','0','CXC1','0')
insert into detperfil values('2','CuentaxCobrar','0','CXC2','0')
insert into detperfil values('2','CuentaxCobrar','0','CXC3','0')
insert into detperfil values('2','CuentaxCobrar','0','CXC4','0')
insert into detperfil values('2','CuentaxCobrar','0','CXC5','0')

insert into detperfil values('2','CuentaxPagar','0','CXP1','0')
insert into detperfil values('2','CuentaxPagar','0','CXP2','0')
insert into detperfil values('2','CuentaxPagar','0','CXP3','0')
insert into detperfil values('2','CuentaxPagar','0','CXP4','0')
insert into detperfil values('2','CuentaxPagar','0','CXP5','0')

insert into detperfil values('2','Mantenimientos','0','Mant1','0')
insert into detperfil values('2','Mantenimientos','0','Mant2','0')
insert into detperfil values('2','Mantenimientos','0','Mant3','0')
insert into detperfil values('2','Mantenimientos','0','Mant4','0')
insert into detperfil values('2','Mantenimientos','0','Mant5','0')
insert into detperfil values('2','Mantenimientos','0','Mant6','0')
insert into detperfil values('2','Mantenimientos','0','Mant7','0')
insert into detperfil values('2','Mantenimientos','0','Mant8','0')
insert into detperfil values('2','Mantenimientos','0','Mant9','0')
insert into detperfil values('2','Mantenimientos','0','Mant10','0')
insert into detperfil values('2','Mantenimientos','0','Mant11','0')

insert into detperfil values('2','Movimientos','1','Mov1','1')
insert into detperfil values('2','Movimientos','1','Mov2','1')
insert into detperfil values('2','Movimientos','1','Mov3','1')
insert into detperfil values('2','Movimientos','1','Mov4','1')
insert into detperfil values('2','Movimientos','1','Mov5','1')
insert into detperfil values('2','Movimientos','1','Mov6','1')
insert into detperfil values('2','Movimientos','1','Mov7','1')
insert into detperfil values('2','Movimientos','1','Mov8','1')
insert into detperfil values('2','Movimientos','1','Mov9','1')
insert into detperfil values('2','Movimientos','1','Mov10','1')

insert into detperfil values('2','Utilitarios','1','Uti1','1')
insert into detperfil values('2','Utilitarios','1','Uti2','1')
insert into detperfil values('2','Utilitarios','1','Uti3','1')
insert into detperfil values('2','Utilitarios','1','Uti4','1')
insert into detperfil values('2','Utilitarios','1','Uti5','1')
insert into detperfil values('2','Utilitarios','1','Uti6','1')

--invitado

insert into detperfil values('3','CuentaxCobrar','0','CXC1','0')
insert into detperfil values('3','CuentaxCobrar','0','CXC2','0')
insert into detperfil values('3','CuentaxCobrar','0','CXC3','0')
insert into detperfil values('3','CuentaxCobrar','0','CXC4','0')
insert into detperfil values('3','CuentaxCobrar','0','CXC5','0')

insert into detperfil values('3','CuentaxPagar','0','CXP1','0')
insert into detperfil values('3','CuentaxPagar','0','CXP2','0')
insert into detperfil values('3','CuentaxPagar','0','CXP3','0')
insert into detperfil values('3','CuentaxPagar','0','CXP4','0')
insert into detperfil values('3','CuentaxPagar','0','CXP5','0')

insert into detperfil values('3','Mantenimientos','0','Mant1','0')
insert into detperfil values('3','Mantenimientos','0','Mant2','0')
insert into detperfil values('3','Mantenimientos','0','Mant3','0')
insert into detperfil values('3','Mantenimientos','0','Mant4','0')
insert into detperfil values('3','Mantenimientos','0','Mant5','0')
insert into detperfil values('3','Mantenimientos','0','Mant6','0')
insert into detperfil values('3','Mantenimientos','0','Mant7','0')
insert into detperfil values('3','Mantenimientos','0','Mant8','0')
insert into detperfil values('3','Mantenimientos','0','Mant9','0')
insert into detperfil values('3','Mantenimientos','0','Mant10','0')
insert into detperfil values('3','Mantenimientos','0','Mant11','0')

insert into detperfil values('3','Movimientos','1','Mov1','1')
insert into detperfil values('3','Movimientos','1','Mov2','1')
insert into detperfil values('3','Movimientos','1','Mov3','1')
insert into detperfil values('3','Movimientos','1','Mov4','1')
insert into detperfil values('3','Movimientos','1','Mov5','1')
insert into detperfil values('3','Movimientos','1','Mov6','1')
insert into detperfil values('3','Movimientos','1','Mov7','1')
insert into detperfil values('3','Movimientos','1','Mov8','1')
insert into detperfil values('3','Movimientos','1','Mov9','1')
insert into detperfil values('3','Movimientos','1','Mov10','1')

insert into detperfil values('3','Utilitarios','1','Uti1','1')
insert into detperfil values('3','Utilitarios','1','Uti2','1')
insert into detperfil values('3','Utilitarios','1','Uti3','0')
insert into detperfil values('3','Utilitarios','1','Uti4','1')
insert into detperfil values('3','Utilitarios','1','Uti5','1')
insert into detperfil values('3','Utilitarios','1','Uti6','1')
go
--select itemactivo from detperfil where Id_Perfil='1' and menu='utilitarios'
create table proveedor(
id_proveedor int primary key,
proveedor varchar(100) not null,
direccion varchar(100) not null,
telefonos varchar(80) not null,
nit varchar(15) not null,
dias_credito int not null,
email varchar(50) not null,
contacto varchar(50) not null,
celular varchar(20) not null,
importada tinyint not null,
dias_tramite int not null
);
insert into proveedor values('1','alder','14 calle b','5989898','26626565','12','swordslol323@gmail.com','23266656','16111113','1','23')
go
create table combinaciones(
id_combinacion int primary key, 
combinacion varchar(50) not null,
cantidad int not null,
estado int not null,
);
insert into combinaciones values('1','1','1','1')
go
select * from combinaciones
create table grupo(
id_grupo int identity(1,1) primary key,
grupo varchar(50) not null
);
insert into grupo values('griferia')
go
create table productos(
id_producto int primary key,
producto varchar(200) not null,
descripcion varchar(150) not null,
id_proveedor int not null,
volumen decimal(18,0) not null,
promedio_ventaxmes decimal(18,0) not null,
peso decimal(18,0) not null,
id_combinacion int not null,
grupo varchar(40) not null,
alta_rotacion tinyint not null,--modificar tipo
bloqueo_temporal tinyint not null,
ganLiquidacion decimal(18,2) not null, 
ganfardo decimal(18,2) not null,
ganunmediofardo decimal(18,2) not null,
ganDocena decimal(18,2) not null,
prec_liquidacion decimal(18,2) not null,
pre_fardo decimal(18,2) not null,
prec_unmedio_fardo decimal(18,2) not null,
prec_Docena_Fardo decimal(18,2) not null,
min_inv  int not null,
min_venta int not null,
existencias int not null,
fardos int not null,
min_multiplos int not null

 foreign key(id_proveedor) references proveedor(id_proveedor),
 foreign key(id_combinacion) references combinaciones(id_combinacion),
);
--select * from productos where descripcion like '%una espadita%'
insert into productos values('1','swords','una espadita, osi','1','15.2','25','66.33','1','griferia','1','1','15.2','155.3','70.6','25','125.3','89.3','78.2','12.2','200','200','12','2','12')
insert into productos values('2','swords2','una xd wapa osi, osi','1','15.2','25','66.33','1','griferia','1','1','15.2','155.3','70.6','25','125.3','89.3','78.2','12.2','200','200','12','2','12')
go
create table ultimasesion
(
idsesion int identity,
nombreusuario varchar(50)  
);
go
create table departamento(
id_departamento int primary key,
departamento varchar(20) not null
);
insert into departamento values('1','Guatemala')
go
select * from usuarios
create table tipo_cliente(
id_tipo int primary key,
tipo varchar(50) not null,
);
insert into tipo_cliente values('1','malapaga')
go
create table notas(
NombreUsuario varchar(50) primary key,
nota varchar(8000),
);
go
create table transporte(
id_transporte int primary key,
transpor varchar(50) not null
);
insert into transporte values('1','Cargo Expreso')
go
create table bancos(
Id_Banco int primary key not null,
banco varchar(60) not null,
);
insert into bancos values('1','banrural')
go
select * from usuarios

create table estado(
id_estado int primary key,
estado varchar(50) not null
);
insert into estado values('1','1')
go

create table subruta(
id_subruta int primary key,
subruta varchar(50) not null,
activa char not null
);
insert into subruta values('1','1','1')
go

create table region(
id_region int primary key, 
region varchar(50) not null
);
insert into region values('1','1')
go


create table supervisor(
id_supervisor int primary key,
supervisor varchar(50) not null,
meta int not null,
super_activo int not null
);
insert into supervisor values('1','Luis Moran','1','1')
go


create table subgerente(
id_subgerente int primary key,
subgerente varchar(50) not null

);
insert into subgerente values('1','hugo')
go

create table ruta(
id_ruta int primary key,
ruta varchar(50) not null,
ruta_activa int not null

);
insert into ruta values('1','12','1')
go

create table municipio(
id_municipio int primary key,
municipio varchar(25) not null,
id_departamento int not null,
id_ruta int not null,
id_subruta int not null,
estado_activo int not null,
foreign key(id_departamento) references departamento(id_departamento),
foreign key(id_ruta) references ruta(id_ruta),
foreign key(id_subruta) references subruta(id_subruta)
);
insert into municipio values('1','san juan','1','1','1','1')
go


create table vendedor(
id_vendedor int primary key,
vendedor varchar(50) not null,
vendedor_activo char not null,
id_supervisor int not null,
id_subgerente int not null,
id_region int not null,
id_ruta int not null,
foreign key(id_ruta) references ruta(id_ruta),
foreign key(id_subgerente) references subgerente(id_subgerente),
foreign key(id_supervisor) references supervisor(id_supervisor),
foreign key(id_region) references region(id_region),
foreign key(id_vendedor) references vendedor(id_vendedor),

);
insert into vendedor values('1','Manfredo lopez','1','1','1','1','1')
go

create table tabla_clientes(
id_cliente int primary key,
Cliente varchar(50) not null,
Direccion varchar(50) not null,
No_Casa varchar(30) not null,
calleAvenia varchar(50) not null,
No_Local varchar(20) not null,
Zona varchar(20) not null,
ColoniaoLugar varchar(30) not null,
id_municipio int not null,
id_departamento int not null,
telefono int not null,
nit varchar(13) not null,
vip int not null,
dia_credito int not null,
limite_credito int not null,
email varchar(50) not null,
Obser varchar(50) not null,
id_vendedor int not null,
id_tipo int not null,
id_subruta int not null,
id_ruta int not null,
id_transporte int not null,
bloqueo_temporal varchar(200),
motivo_bloqueo varchar(200),
id_estado int not null,
Id_Motivo int


foreign key(id_municipio) references municipio(id_municipio),
foreign key(id_vendedor) references vendedor(id_vendedor),
foreign key(id_estado) references estado(id_estado),
foreign key(id_subruta) references subruta(id_subruta),
foreign key(id_transporte) references transporte(id_transporte),
foreign key(id_departamento) references departamento(id_departamento),
foreign key(id_tipo) references tipo_cliente(id_tipo),
foreign key(id_ruta) references ruta(id_ruta),
foreign key(Id_Motivo) references bajacliente(Id_Motivo)

);
--select * from detfacturaCompra
--select * from productos
insert into tabla_clientes values('1','alder isaac solis de leon','14 calle b 18-28 colonia san carlos 1','18-28','calle B','no','1','san carlos 1','1','1','24456002','1111111111111','1','1','1','swordslol323@gmail.com','ninguna','1','1','1','1','1','no',' ','1','0')
go
create table facturascanceladasclientes(
id_cliente int not null,
fech_ini datetime not null,
fech_final datetime not null,
foreign key(id_cliente) references tabla_clientes(id_cliente),
);

create table facturasmorosasvendedor(
id_vendedor int not null,
id_ruta int not null,
alcance varchar(200) not null,
foreign key(id_vendedor) references vendedor(id_vendedor),
foreign key(id_ruta) references ruta(id_ruta)
);
--drop table cotizaciones
create table cotizaciones(
id_documento int primary key,
id_cliente int not null,
Nit varchar(13) not null,
direccion varchar(100) not null,
telfono int not null,
id_vendedor int not null,
fecha varchar(15),
obser varchar(200) not null,
total_general decimal(18,2) not null,
foreign key(id_cliente) references tabla_clientes(id_cliente),
foreign key(id_vendedor) references vendedor(id_vendedor)
);
create table detallecotizaciones(
id_documento  int not null,
id_cliente int not null,
id_producto int not null,
cantidad int not null,
precio decimal(18,2) not null,
totaldetalle decimal(18,2) not null,
foreign key(id_producto) references productos(id_producto),
foreign key(id_cliente) references tabla_clientes(id_cliente)

);
insert into detallecotizaciones values('1','1','1','2','12.2','24.4')

create table reciboscliente (
id_documento int primary key not null,
serie int not null,
Id_Cliente int not null,
observaciones varchar(200),
fecha varchar(15) not null,
anulado int,
totalgeneral decimal(18,2) not null,
foreign key(Id_cliente) references tabla_clientes(Id_cliente)
);
create table detreciboscliente(
Id_Documento int not null,
Id_Cliente int not null,
serie int not null,
id_producto int,
cantidad int not null,	
precio decimal(18,2) not null,
totaldet decimal(18,2) not null,
foreign key(Id_Cliente) references tabla_clientes(Id_Cliente),
);
select * from detreciboscliente where Id_Documento='1' and serie='1' and id_cliente='1'

go
create table factuasventa(
Id_Documento int primary key not null,
Serie int  not null,
Id_Cliente int not null,
Direccion varchar(50) not null,
NoNit varchar(13) not null,
Id_Municipio int not null,
NoPedido int not null,
IdRuta int not null,
Observaciones varchar(150) not null,
DiasCredito int not null,
limiteCredito int not null,
fechaVenci varchar(15) not null,
cobroxenvio decimal(18,2) not null,
Id_Departamento int not null,
Id_SubRuta int not null,
Telefonos varchar(17) not null,
anulado tinyint not null,
credito int not null,
Id_Vendedor int not null,
fecha varchar(15),
total decimal(18,2)
 foreign key(id_cliente) references tabla_Clientes(id_cliente),
 foreign key(Id_Municipio) references municipio(Id_Municipio),
  foreign key(IdRuta) references Ruta(Id_Ruta),
 foreign key(Id_Vendedor) references vendedor(Id_Vendedor),
  foreign key(Id_Departamento) references Departamento(Id_Departamento),
  foreign key(Id_SubRuta) references Subruta(Id_SubRuta),
);
--drop table defacturasventa
create table defacturasventa(
Id_Documento int not null,
serie Varchar(6) not null,
credito int not null,
direccion varchar(50),
nit varchar(13),
fecha varchar(20) not null,
total decimal(18,2) not null,
);
ALTER TABLE defacturasventa ADD PRIMARY KEY ( serie , Id_Documento);
--drop table detfacturaCompra
go
create table facturaCompra(
Id_Documento int primary key not null,
Serie int  not null,
Id_proveedor int not null,
Direccion varchar(50) not null,
NoNit varchar(13) not null,
Observaciones varchar(150) not null,
DiasCredito int not null,
fechaVenci varchar(15) not null,
Telefonos varchar(17) not null,
anulado tinyint not null,
credito int not null,
Id_Vendedor int not null,
fecha varchar(15),
total decimal(18,2)
 foreign key(Id_Vendedor) references vendedor(Id_Vendedor),
  foreign key(Id_proveedor) references proveedor(Id_proveedor),
);
--select * from proveedor
create table detfacturaCompra(
Id_Documento int not null,
serie Varchar(6) not null,
Id_Producto int not null,
cantidad int not null,
precio decimal(18,2) not null,
totaldet decimal(18,2) not null,
);
--drop table envioentrada
create table envioentrada(
Id_Proveedor int not null,
Id_envio Int not null,
fecha varchar(15) not null,
observaciones varchar(120),
No_nit varchar(13) not null,
DoctoReclamo int not null,
valor decimal(18,2) not null,
direccion varchar(200) not null,
totalenvio decimal(18,2) not null
foreign key(Id_Proveedor) references proveedor(Id_Proveedor),
);
ALTER TABLE envioentrada ADD PRIMARY KEY (Id_envio,Id_Proveedor) ;
--drop table detenvioentrada
create table detenvioentrada(
Id_Proveedor int not null,
Id_envio Int not null,
id_producto Int not null,
cantidad int not null,
precio decimal(18,2) not null,
totaldetalle decimal(18,2) not null
foreign key(Id_Proveedor) references proveedor(Id_Proveedor),
);
--drop table enviosdesalida
create table enviosdesalida(
No_Envio int primary key not null,
No_Nit varchar(13) not null,
Id_Cliente int null,
Id_vendedor int not null,
fecha varchar(15),
Id_Municipio int not null,
Id_Ruta int not null,
Id_Subruta int not null,
Id_Departamento int not null,
direccion varchar(100),
Observaciones varchar(120) not null,
total decimal(18,2) not null
foreign key(Id_Cliente) references tabla_clientes(Id_Cliente),
foreign key(Id_vendedor) references vendedor(Id_vendedor),
foreign key(Id_Municipio) references municipio(Id_Municipio),
foreign key(Id_Ruta) references Ruta(Id_Ruta),
foreign key(Id_Subruta) references Subruta(Id_Subruta),
foreign key(Id_Departamento) references Departamento(Id_Departamento),
);
--drop table Detenviosdesalida
create table Detenviosdesalida(
No_Envio int not null,
Id_Cliente int not null,
Id_vendedor int not null,
Id_Producto int not null,
cantidad int not null,
precio decimal(18,2) not null,
totaldet decimal(18,2) not null
foreign key(Id_Cliente) references tabla_clientes(Id_Cliente),
foreign key(Id_vendedor) references vendedor(Id_vendedor),
);

create table credito_proveedores(
Id_documento int identity(1,1)primary key not null ,
Id_DocumentoNota int not null,
Serie int not null, 
serienota int not null,
Id_Proveedor int not null,
Fecha date not null,
Notadecredito int not null,
documentocompra int not null,
No_Nit int not null
foreign key(Id_Proveedor) references proveedor(Id_Proveedor),

);
create table Detcredito_proveedores(
Id_documento int not null ,
Serie int not null,
Id_Proveedor int not null,
cantidad int not null,
precio money not null,
totaldetalle money not null,
foreign key(Id_Proveedor) references proveedor(Id_Proveedor),
);


Create table NotascreditoProveedores(
Id_Proveedor int not null,
IdDocumento int not null,
serie varchar(13),
Id_Cliente int not null,
Fecha varchar(15) not null,
año varchar(15) not null,
saldo decimal(18,2),
No_Nit varchar(13) not null,
notadecredito int primary key not null,
direccion varchar(200) not null,
total decimal(18,2),
foreign key(Id_Proveedor) references proveedor(Id_Proveedor),
foreign key(Id_Cliente) references tabla_clientes(Id_Cliente),
);

Create table DetNotascreditoProveedores(
notadecredito int not null,
serie varchar(13),
Id_Proveedor int not null,
IdDocumento int not null,
Id_Cliente int not null,
id_producto int not null,
Cantidad int not null,
precio decimal(18,2) not null,
Totaldet decimal(18,2) not null
foreign key(Id_Proveedor) references proveedor(Id_Proveedor),
foreign key(Id_Cliente) references tabla_clientes(Id_Cliente),
foreign key(id_producto) references productos(id_producto),


);
create table recibosproveedores(
Id_Proveedor int,
serie int,
no_documento int primary key,
Anulado int,
fecha varchar(15),
valorrecibido decimal(18,2),
formadepago varchar(30),
efectivo decimal(18,2),
Id_Banco int,
chequeNo int,
valor decimal(18,2),
totalgeneral decimal(18,2),
foreign key(Id_Proveedor) references proveedor(Id_Proveedor),
foreign key(Id_Banco) references bancos(Id_Banco),
);

create table detrecibosproveedores(
serie int not null,
no_documento int not null,
Id_Proveedor int not null,
Id_Producto int not null,
cantidad int not null,
precio decimal(18,2) not null,
totaledet decimal(18,2) not null
foreign key(Id_Proveedor) references proveedor(Id_Proveedor),
foreign key(Id_Producto) references productos(Id_Producto),


);

Create table NotascreditoClientes(
notadecredito int primary key not null,
Serie int not null,
IdDocumento int not null,
Id_Cliente int not null,
Fecha varchar(15) not null,
Id_Vendedor int not null,
Id_Municipio int not null,
Id_Ruta int not null,
Id_Departamento int not null,
Id_SubRuta int not null,
TotalGeneral decimal(18,2) not null,
direccion varchar(200) not null,
No_Nit varchar(13) not null,
foreign key(Id_Cliente) references tabla_clientes(Id_Cliente),
foreign key(Id_Vendedor) references vendedor(Id_Vendedor),
foreign key(Id_Municipio) references municipio(Id_Municipio),
foreign key(Id_Ruta) references ruta(Id_Ruta),
foreign key(Id_Departamento) references departamento(Id_Departamento),
foreign key(Id_SubRuta) references subruta(Id_SubRuta),
);

Create table DetNotascreditoCliente(
notadecredito int not null,
Serie int not null,
IdDocumento int not null,
IdCliente int not null,
Id_Producto int not null,
Cantidad int not null,
precio decimal(18,2) not null,
Totaldet decimal(18,2) not null
foreign key(IdCliente) references tabla_clientes(Id_Cliente),
foreign key(Id_Producto) references productos(Id_Producto),

);
