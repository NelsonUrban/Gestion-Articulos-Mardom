using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Bl;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Controllers
{
    public class SalidaAlmacenController : Controller
    {
        // GET: SalidaAlmacen
        private BSalidaAlmacen _salida = new BSalidaAlmacen();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetSalida()
        {
            var result = from s in _salida.GetSalida()
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
        public ActionResult NewSalida()
        {
            VmSalidaAlmacen vmSalida = new VmSalidaAlmacen();
            vmSalida.Almacen = _salida.GetAlmacenes();
            return View(vmSalida);
        }
         [HttpPost]
        public ActionResult NewSalida(VmSalidaAlmacen vsalida, string detalle)
        {
            _salida.InsertSalida(vsalida,detalle);
            return Redirect("Index");
        }

        [HttpPost]
        public JsonResult getArticulos(string id)
        {
            var result = from s in _salida.GetArticulos() 
                         where s.Codigo_Barra == id
                         select new
                         {
                             s.Nombre,
                             s.Precio_1
                         };
            var model = result.ToList();
            return Json(model, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Delete(int id)
        {
            _salida.DeleteSalida(id);
            return Redirect("Index");
        }
    }
}