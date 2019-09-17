using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Repository;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Bl
{
    public class BReportSalidaAlmacen
    {
        private  RreportSalidaAlmacen _ReportSalida;
       
        public BReportSalidaAlmacen()
        {
            this._ReportSalida = new RreportSalidaAlmacen(new Gestion_Articulos_MardomEntities1());
        }
        public IList<Sp_Report_DetSalidaAlmacen_Result> DetailsSalida( int id )
        {
            return _ReportSalida.DetailsSalida(id);
        }
        public Sp_Report_SalidaAlmacen_Result SalidaAlmacen(int id)
        {
            return _ReportSalida.SalidaAlmacen(id);
        }


    }
}