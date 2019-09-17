using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel
{
    public class VmSalidasDeAlmacen
    {
        public Sp_Report_SalidaAlmacen_Result Salida { get; set; }
        public IList<Sp_Report_DetSalidaAlmacen_Result> ListSalidaDetalle { get; set; }

    }
}