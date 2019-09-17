using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel
{
    public class VmEntradaAlmacen
    {

        public int Id { get; set; }
        public int Almacen_Id { get; set; }
        public DateTime Fecha_crea { get; set; }

        public DateTime Fecha_modifica { get; set; }
        public string Comentarios { get; set; }

        [Required]
        [Display(Name = "Codigo Articulo")]
        public int Articulo_id { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public int cantidad { get; set; }

        public decimal precio { get; set; }
        [Required]
        public int descuento { get; set; }

        public IEnumerable<Almacen> Almacen { get; set; }


        #region Totales

        public double? Total_Apagar { get; set; }        
        public float Sub_Total { get; set; }
        #endregion
    }
}