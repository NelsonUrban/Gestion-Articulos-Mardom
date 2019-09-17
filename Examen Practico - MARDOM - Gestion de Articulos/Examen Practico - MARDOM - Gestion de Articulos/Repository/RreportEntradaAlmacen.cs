using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Repository
{
    public class RreportEntradaAlmacen
    {

        private Gestion_Articulos_MardomEntities1 Context;

        public RreportEntradaAlmacen(Gestion_Articulos_MardomEntities1 Context)
        {
            this.Context = Context;
        }

        public IList<Sp_Report_DetEntradaAlmacen_Result> DetailsEntrada(int id)
        {
            return Context.Sp_Report_DetEntradaAlmacen(id).ToList();

        }
        public Sp_Report_EntradaAlmacen_Result EntradaAlmacen(int id)
        {
            return Context.Sp_Report_EntradaAlmacen(id).FirstOrDefault();
        }

    }
}