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
    
    public partial class Almacen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Almacen()
        {
            this.Articulo_stock = new HashSet<Articulo_stock>();
            this.Entrada_Almacen = new HashSet<Entrada_Almacen>();
            this.Salida_Almacen = new HashSet<Salida_Almacen>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Tipo_Almacen_Id { get; set; }
        public bool Activo { get; set; }
        public System.DateTime Fecha_creacion { get; set; }
        public Nullable<System.DateTime> Fecha_Modificacion { get; set; }
        public Nullable<int> Maximo { get; set; }
        public Nullable<int> Minima { get; set; }
    
        public virtual Tipo_Almacen Tipo_Almacen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo_stock> Articulo_stock { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrada_Almacen> Entrada_Almacen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida_Almacen> Salida_Almacen { get; set; }
    }
}
