//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Articulo_stock
    {
        public int Id { get; set; }
        public int Articulo_id { get; set; }
        public int Almacen_Id { get; set; }
        public int Existencia { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
    
        public virtual Almacen Almacen { get; set; }
        public virtual Articulos Articulos { get; set; }
    }
}