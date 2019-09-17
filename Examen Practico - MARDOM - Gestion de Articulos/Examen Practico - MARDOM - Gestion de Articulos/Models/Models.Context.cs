﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Gestion_Articulos_MardomEntities1 : DbContext
    {
        public Gestion_Articulos_MardomEntities1()
            : base("name=Gestion_Articulos_MardomEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<Articulo_stock> Articulo_stock { get; set; }
        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<Detalle_Entrada_Almacen> Detalle_Entrada_Almacen { get; set; }
        public virtual DbSet<Detalle_Salida_Almacen> Detalle_Salida_Almacen { get; set; }
        public virtual DbSet<Entrada_Almacen> Entrada_Almacen { get; set; }
        public virtual DbSet<Salida_Almacen> Salida_Almacen { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tipo_Almacen> Tipo_Almacen { get; set; }
        public virtual DbSet<Tipo_Articulo> Tipo_Articulo { get; set; }
        public virtual DbSet<Valmacen> Valmacen { get; set; }
        public virtual DbSet<VSalida_Almacen> VSalida_Almacen { get; set; }
        public virtual DbSet<VEntrada_Almacen> VEntrada_Almacen { get; set; }
    
        public virtual int Sp_Entrada_Almacen(Nullable<int> articuloid, Nullable<int> cantidad, Nullable<int> existencia, Nullable<int> existenciaActual, Nullable<int> almacen_id)
        {
            var articuloidParameter = articuloid.HasValue ?
                new ObjectParameter("Articuloid", articuloid) :
                new ObjectParameter("Articuloid", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var existenciaParameter = existencia.HasValue ?
                new ObjectParameter("Existencia", existencia) :
                new ObjectParameter("Existencia", typeof(int));
    
            var existenciaActualParameter = existenciaActual.HasValue ?
                new ObjectParameter("ExistenciaActual", existenciaActual) :
                new ObjectParameter("ExistenciaActual", typeof(int));
    
            var almacen_idParameter = almacen_id.HasValue ?
                new ObjectParameter("almacen_id", almacen_id) :
                new ObjectParameter("almacen_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Entrada_Almacen", articuloidParameter, cantidadParameter, existenciaParameter, existenciaActualParameter, almacen_idParameter);
        }
    
        public virtual int Sp_Salida_Almacen(Nullable<int> articuloid, Nullable<int> cantidad, Nullable<int> existencia, Nullable<int> existenciaActual, Nullable<int> almacen_id)
        {
            var articuloidParameter = articuloid.HasValue ?
                new ObjectParameter("Articuloid", articuloid) :
                new ObjectParameter("Articuloid", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var existenciaParameter = existencia.HasValue ?
                new ObjectParameter("Existencia", existencia) :
                new ObjectParameter("Existencia", typeof(int));
    
            var existenciaActualParameter = existenciaActual.HasValue ?
                new ObjectParameter("ExistenciaActual", existenciaActual) :
                new ObjectParameter("ExistenciaActual", typeof(int));
    
            var almacen_idParameter = almacen_id.HasValue ?
                new ObjectParameter("almacen_id", almacen_id) :
                new ObjectParameter("almacen_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Salida_Almacen", articuloidParameter, cantidadParameter, existenciaParameter, existenciaActualParameter, almacen_idParameter);
        }
    
        public virtual int Sp_VerificarProductoEnStock(Nullable<int> almacen_ID, Nullable<int> articulo_id)
        {
            var almacen_IDParameter = almacen_ID.HasValue ?
                new ObjectParameter("Almacen_ID", almacen_ID) :
                new ObjectParameter("Almacen_ID", typeof(int));
    
            var articulo_idParameter = articulo_id.HasValue ?
                new ObjectParameter("Articulo_id", articulo_id) :
                new ObjectParameter("Articulo_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_VerificarProductoEnStock", almacen_IDParameter, articulo_idParameter);
        }
    
        public virtual ObjectResult<Sp_Report_List_Articulos_Result> Sp_Report_List_Articulos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Report_List_Articulos_Result>("Sp_Report_List_Articulos");
        }
    
        public virtual ObjectResult<Sp_Report_DetSalidaAlmacen_Result> Sp_Report_DetSalidaAlmacen(Nullable<int> idSalida)
        {
            var idSalidaParameter = idSalida.HasValue ?
                new ObjectParameter("idSalida", idSalida) :
                new ObjectParameter("idSalida", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Report_DetSalidaAlmacen_Result>("Sp_Report_DetSalidaAlmacen", idSalidaParameter);
        }
    
        public virtual ObjectResult<Sp_Report_SalidaAlmacen_Result> Sp_Report_SalidaAlmacen(Nullable<int> idSalida)
        {
            var idSalidaParameter = idSalida.HasValue ?
                new ObjectParameter("idSalida", idSalida) :
                new ObjectParameter("idSalida", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Report_SalidaAlmacen_Result>("Sp_Report_SalidaAlmacen", idSalidaParameter);
        }
    
        public virtual ObjectResult<Sp_Report_DetEntradaAlmacen_Result> Sp_Report_DetEntradaAlmacen(Nullable<int> idEntrada)
        {
            var idEntradaParameter = idEntrada.HasValue ?
                new ObjectParameter("idEntrada", idEntrada) :
                new ObjectParameter("idEntrada", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Report_DetEntradaAlmacen_Result>("Sp_Report_DetEntradaAlmacen", idEntradaParameter);
        }
    
        public virtual ObjectResult<Sp_Report_EntradaAlmacen_Result> Sp_Report_EntradaAlmacen(Nullable<int> idEntrada)
        {
            var idEntradaParameter = idEntrada.HasValue ?
                new ObjectParameter("idEntrada", idEntrada) :
                new ObjectParameter("idEntrada", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Report_EntradaAlmacen_Result>("Sp_Report_EntradaAlmacen", idEntradaParameter);
        }
    }
}
