using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Bl;
using Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        private BReports _BReports = new BReports();
        private VmSalidasDeAlmacen _VmSalidas = new VmSalidasDeAlmacen();
        private VmEntradasAlmacen _vmEntradas = new VmEntradasAlmacen();
        private BReportSalidaAlmacen _reportSalida = new BReportSalidaAlmacen();
        private BReportEntradaAlmacen _reportEntrada = new BReportEntradaAlmacen();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetReportArticulos()
        {
            var ruta = Request.MapPath(Request.ApplicationPath) + @"Report\ReportListadoArticulos.rdl";
            ViewBag.ReportViewer = _BReports.GetReport(ruta);
            return View();

        }
        public ActionResult ReportSalida( int id )
        {
            _VmSalidas.Salida = _reportSalida.SalidaAlmacen(id);
            _VmSalidas.ListSalidaDetalle = _reportSalida.DetailsSalida(id);

            return View(_VmSalidas);
        }
        public ActionResult ReportEntrada( int id )
        {
            _vmEntradas.Entrada = _reportEntrada.EntradaAlmacen(id);
            _vmEntradas.ListEntradaDetalle = _reportEntrada.DetailsEntrada(id);

            return View(_vmEntradas);
        }
    }
}