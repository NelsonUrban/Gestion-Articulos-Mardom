using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel
{
    public class VmEntradasAlmacen
    {
        public Sp_Report_EntradaAlmacen_Result Entrada { get; set; }
        public IList<Sp_Report_DetEntradaAlmacen_Result> ListEntradaDetalle { get; set; }
    }
}