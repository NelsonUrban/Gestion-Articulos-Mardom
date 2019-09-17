Create Database  Gestion_Articulos_Mardom;
go
use Gestion_Articulos_Mardom;

go 

Create Table Almacen
(
   Id Int Primary Key Identity(1,1) not null,
   Descripcion Varchar(50) Not null,
   Tipo_Almacen_Id int not null,
   Activo bit not null,
   Maximo int  ,
   Minima int  ,
   Fecha_creacion datetime not null,
   Fecha_Modificacion datetime null
);
go

create Table Tipo_Almacen
( 
   Id Int Primary Key identity(1,1) not null,
   descripcion varchar(50) not null,
   Activo bit not null,
   Fecha_creacion datetime not null,
   Fecha_Modificacion datetime null  
);

go

Create table Articulos
( 
 Id Int Primary Key identity(1,1) not null,
 Nombre Varchar(50) not null,
 Referencia varchar(20) null,
 Codigo_Barra varchar(20) null,
 Expira bit not null,
 Precio_1 float not null,
 Precio_2 float default (0.00),
 Precio_3 float default (0.00),
 Tipo_Articulo_Id int not null,
 Activo bit not null,
 Fecha_creacion datetime not null,
 Fecha_Modificacion datetime null 
);
go
create table Tipo_Articulo
(
   Id Int Primary Key identity(1,1) not null,
   descripcion varchar(50) not null,
   Activo bit not null,
   Fecha_creacion datetime not null,
   Fecha_Modificacion datetime null
);
go
create table Articulo_stock
(
  Id int Primary Key identity (1,1) not null,
  Articulo_id int not null,
  Almacen_Id int not null,
  Existencia int  not null default(0),
  fecha_creacion datetime null
);
go
create table Entrada_Almacen(
	 Id int Primary Key identity (1,1) not null,
	Almacen_Id int NOT NULL,
	Fecha_crea datetime NOT NULL,
    Fecha_modifica datetime NULL,
    Total Float default 0.00,
	Comentarios varchar(250) NULL
);
go
 Create Table Detalle_Entrada_Almacen
 (
	 Id int Primary Key identity (1,1) not null,
    Articulo_id int NOT NULL,
	Cantidad int NOT NULL,
	Precio float NOT NULL,
	fecha datetime NOT NULL,
	entrada_id int NOT NULL
);
go
Create table Salida_Almacen(
 Id int Primary Key identity (1,1) not null,
	Almacen_Id int NOT NULL,
	Fecha_crea datetime NOT NULL,	
    Fecha_modifica datetime NULL,
    Total Float default 0.00,
	Comentarios varchar(250) NULL
);
go
 Create Table Detalle_Salida_Almacen
 (
	 Id int Primary Key identity (1,1) not null,
    Articulo_id int NOT NULL,
	Cantidad int NOT NULL,
	Precio float NOT NULL,
	fecha datetime NOT NULL,
	Salida_id int NOT NULL
);

