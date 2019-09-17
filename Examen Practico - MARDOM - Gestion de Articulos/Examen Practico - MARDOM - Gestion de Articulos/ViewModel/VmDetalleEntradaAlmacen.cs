using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel
{
    public class VmDetalleEntradaAlmacen
    {
        public int Id { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public int entrada_id { get; set; }
        public float Precio { get; set; }
        public DateTime fecha { get; set; }
    }
}