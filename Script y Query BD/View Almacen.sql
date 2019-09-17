use Gestion_Articulos_Mardom;
go


Create View Valmacen
AS
(
Select A.Id,
     A.Descripcion,
	 TA.descripcion as Tipo_Almacen,
	 A.Activo 
From  Almacen A 
inner Join Tipo_Almacen TA
on a.Tipo_Almacen_Id = TA.Id
)

go
 create View [VEntradas_Almacen]
 as
select  
EA.Id,
a.descripcion as Almacen,
 cast(ea.Fecha_crea as date) Fecha_Entrada,
SUM(de.Precio * de.Cantidad) as Monto_Entrada
from  Entrada_Almacen EA
 inner join Almacen a
 on ea.Almacen_Id = a.Id 
 inner join Detalle_Entrada_Almacen de
 on ea.Id=de.entrada_id
 group by EA.Id,
a.Descripcion ,
ea.Fecha_crea

go

 Create View VSalida_Almacen
 as
select  
EA.Id,
a.Descripcion as Almacen,
ea.Fecha_crea,
SUM(de.Precio * de.Cantidad) as Monto_Entrada
 from  Salida_Almacen EA
 inner join Almacen a
 on ea.Almacen_Id = a.Id
 inner join Detalle_Salida_Almacen de
 on ea.Id=de.salida_id

 group by 
 EA.Id,
a.Descripcion ,
ea.Fecha_crea
