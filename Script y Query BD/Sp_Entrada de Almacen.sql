use Gestion_Articulos_Mardom;

go

create proc [dbo].[Sp_Report_DetEntradaAlmacen]
(
   @idEntrada int 
)
as
select 
 de.Id,
 a.Codigo_Barra,
 a.Nombre as Producto,
 de.Precio,
 de.Cantidad,
 sum(de.Precio * de.Cantidad) as Total
 from  Entrada_Almacen EA
 inner join Detalle_Entrada_Almacen de
 on de.entrada_id=ea.Id
  inner join Articulos a
  on de.Articulo_id = a.Id
  where ea.Id=@idEntrada
 group by 

 de.Id,
 a.Codigo_Barra,
 a.Nombre,
 de.Precio,
 de.Cantidad

 go

 
create proc [dbo].[Sp_Report_EntradaAlmacen]
(
   @idEntrada int 
)
as
select  
EA.Id,
a.descripcion as Almacen,
ea.Fecha_crea,
SUM(de.Precio * de.Cantidad) as Monto_Entrada
 from  Entrada_Almacen EA
 inner join Almacen a
 on ea.Almacen_Id = a.Id
 inner join Detalle_Entrada_Almacen de
 on ea.Id=de.entrada_id
 where ea.id = @idEntrada
 group by EA.Id,
a.Descripcion ,
ea.Fecha_crea



