using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Repository
{
    public class RreportSalidaAlmacen
    {
        private Gestion_Articulos_MardomEntities1 Context;

        public RreportSalidaAlmacen(Gestion_Articulos_MardomEntities1 Context)
        {
            this.Context = Context;
        }

        public IList<Sp_Report_DetSalidaAlmacen_Result> DetailsSalida(int id)
        {
            return Context.Sp_Report_DetSalidaAlmacen(id).ToList();

        }
        public Sp_Report_SalidaAlmacen_Result SalidaAlmacen(int id )
        {
            return Context.Sp_Report_SalidaAlmacen(id).FirstOrDefault();
        }


    }
}