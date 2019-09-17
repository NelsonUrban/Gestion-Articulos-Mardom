using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel
{
    public class VmAlmacen
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public int Tipo_almacen_id { get; set; }
        public int Selected { get; set; }
        public bool Activo { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime fecha_modificacion { get; set; }
        public int? Minimo { get; set; }
        public int? Maximo { get; set; }


        public IEnumerable<Tipo_Almacen> TipoAlmacen { get; set; }


    }
}