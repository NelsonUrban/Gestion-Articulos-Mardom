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
    
    public partial class Tipo_Almacen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_Almacen()
        {
            this.Almacen = new HashSet<Almacen>();
        }
    
        public int Id { get; set; }
        public string descripcion { get; set; }
        public bool Activo { get; set; }
        public System.DateTime Fecha_creacion { get; set; }
        public Nullable<System.DateTime> Fecha_Modificacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almacen> Almacen { get; set; }
    }
}
