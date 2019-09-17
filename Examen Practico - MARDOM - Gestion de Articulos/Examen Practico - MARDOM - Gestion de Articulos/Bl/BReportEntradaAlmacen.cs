using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Bl
{
    public class BReportEntradaAlmacen
    {
        private RreportEntradaAlmacen _ReportEntrada;
        public BReportEntradaAlmacen()
        {
            this._ReportEntrada = new RreportEntradaAlmacen(new Gestion_Articulos_MardomEntities1());
        }
        public IList<Sp_Report_DetEntradaAlmacen_Result> DetailsEntrada(int id)
        {
            return _ReportEntrada.DetailsEntrada(id);
        }
        public Sp_Report_EntradaAlmacen_Result EntradaAlmacen(int id)
        {
            return _ReportEntrada.EntradaAlmacen(id);
        }
    }
}