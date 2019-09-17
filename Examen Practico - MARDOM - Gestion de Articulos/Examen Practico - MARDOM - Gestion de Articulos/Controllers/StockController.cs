using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Bl;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        private BStockArticulo _Stock = new BStockArticulo();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetStock()
        {
            var result = from s in _Stock.GetStock()
                         select new
                         {
                             s.Articulos.Id,
                             s.Almacen.Descripcion,
                             s.Articulos.Nombre,
                             s.Existencia
                         };
            var model = result.ToList();
            return Json(new { data = model }, JsonRequestBehavior.AllowGet);
        }
    }
}