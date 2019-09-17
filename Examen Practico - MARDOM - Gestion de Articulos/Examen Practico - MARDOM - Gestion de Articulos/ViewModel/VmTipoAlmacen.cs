using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel
{
    public class VmTipoAlmacen
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime fecha_modificacion { get; set; }


    }
}