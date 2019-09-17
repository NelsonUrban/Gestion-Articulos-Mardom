using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Bl;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Controllers
{
    public class EntradaAlmacenController : Controller
    {
        // GET: EntradaAlmacen
        private BEntradaAlmacen _entrada = new BEntradaAlmacen();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetEntrada()
        {
            var result = from s in _entrada.GetEntrada()
                         select new
                         {
                             s.Id,
                             s.Almacen,
                             s.Monto_Entrada

                         };
            var model = result.ToList();
            return Json(new { data = model }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public ActionResult NewEntrada()
        {
            VmEntradaAlmacen entrada = new VmEntradaAlmacen();
            entrada.Almacen = _entrada.GetAlmacenes();
            return View(entrada);
        }
        [HttpPost]
        public ActionResult NewEntrada(VmEntradaAlmacen Ventrada, string detalle)
        {
            _entrada.InsertEntrada(Ventrada, detalle);
            return Redirect("index");
        }

        [HttpPost]
        public JsonResult GetArticulo(string id)
        {
            var result = from s in _entrada.GetArticulos()
                         where s.Codigo_Barra == id
                         select new
                         {
                             s.Nombre,
                             s.Precio_1
                         };
            var model = result.ToList();
            return Json(model, JsonRequestBehavior.AllowGet);

        }
     
        public ActionResult Delete( int id )
        {
            _entrada.DeleteEntrada(id);
             return Redirect("Index");
        }
    }
}
