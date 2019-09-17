use Gestion_Articulos_Mardom;

go

create Procedure Sp_Entrada_Almacen
(
  @Articuloid int , @Cantidad int , @Existencia int , @ExistenciaActual int , @almacen_id int 

)
 
as
Begin 
  set  @Existencia = (Select Existencia
                     From Articulo_Stock A
                      where a.Articulo_Id =@Articuloid and Almacen_Id=@almacen_id);
End 
Begin 

  set @ExistenciaActual  = @Existencia + @Cantidad;
 
 update Articulo_Stock set Existencia = @ExistenciaActual
 Where Articulo_Id = @Articuloid and Almacen_Id = @almacen_id ;

End 


go

Create Procedure Sp_Salida_Almacen
(
  @Articuloid int , @Cantidad int , @Existencia int , @ExistenciaActual int , @almacen_id int 

)
 
as
Begin 
  set  @Existencia = (Select Existencia
                     From Articulo_Stock A
                      where a.Articulo_Id =@Articuloid and Almacen_Id=@almacen_id );
End 
Begin 

  set @ExistenciaActual  = @Existencia - @Cantidad;
 
 update Articulo_Stock set Existencia = @ExistenciaActual
 Where Articulo_Id = @Articuloid and Almacen_Id =@almacen_id;

End 
