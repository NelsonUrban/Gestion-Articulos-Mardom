use Gestion_Articulos_Mardom;

go


Create proc [dbo].[Sp_Report_DetSalidaAlmacen]
(
   @idSalida int 
)
as
select 
 de.Id,
 a.Codigo_Barra,
 a.Nombre as Producto,
 de.Precio,
 de.Cantidad,
  sum(de.Precio * de.Cantidad) as Total
 from  Salida_Almacen EA
 inner join Detalle_Salida_Almacen de
 on de.salida_id=ea.Id
  inner join Articulos a
  on de.Articulo_id = a.Id
  where ea.Id=@idSalida
   group by 

 de.Id,
 a.Codigo_Barra,
 a.Nombre,
 de.Precio,
 de.Cantidad


 go 


 
Create proc [dbo].[Sp_Report_SalidaAlmacen]
(
   @idSalida int 
)
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

 Where ea.Id=@idSalida

 group by 
 EA.Id,
a.Descripcion ,
ea.Fecha_crea

