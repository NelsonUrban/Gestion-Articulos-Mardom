using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel
{
    public class VmArticulos
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Referencia { get; set; }
        public string Codigo_Barra { get; set; }
        public bool Expira { get; set; }
        public double Precio_1 { get; set; }
        public double? Precio_2 { get; set; }
        public double? Precio_3 { get; set; }
        public int Tipo_Articulo_id { get; set; }
        public int Selected { get; set; }
         public IEnumerable<Tipo_Articulo> TipoArticulo { get; set; }
        public bool Activo { get; set; }
        public DateTime Fecha_creacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
        
    }
}