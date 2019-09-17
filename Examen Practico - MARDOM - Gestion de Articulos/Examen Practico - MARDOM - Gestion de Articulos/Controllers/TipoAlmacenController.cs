using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Bl;
using Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Controllers
{
    public class TipoAlmacenController : Controller
    {      
        private BTipoAlmacen _TipoAlmacen = new BTipoAlmacen();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetTipoAlmacen()
        {
            var result = from s in _TipoAlmacen.GetTipoAlmacen()
                         select new
                         {
                             s.Id,
                             s.descripcion,                         
                             s.Activo
                         };
            var model = result.ToList();
            return Json(new { data = model }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(VmTipoAlmacen almacen)
        {
            if (almacen != null)
            {
                this._TipoAlmacen.InsertTipoAlmacen(almacen);
                return RedirectToAction("Index");
            }
            return ViewBag.Mensaje = "El Formulario no puede ser Enviado En Blanco!!";
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_TipoAlmacen.UpdateTipoAlmacenForID(id));
        }
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirmed(VmTipoAlmacen almacen)
        {
            if (almacen != null)
            {
                this._TipoAlmacen.updateTipoAlmacen(almacen);
                return RedirectToAction("Index");
            }
            return ViewBag.Mensaje = "El Formulario no puede ser Enviado En Blanco!!";
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(_TipoAlmacen.DetailsTipoAlmacen(id));
        }
        [HttpPost, ActionName("Details")]
        [ValidateAntiForgeryToken]
        public ActionResult DetailsConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                _TipoAlmacen.DetailsTipoAlmacen(id);
            }
            return View(_TipoAlmacen);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_TipoAlmacen.DetailsTipoAlmacen(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                _TipoAlmacen.DeleteAlmacen(id);
                return RedirectToAction("Index");
            }
            return View(_TipoAlmacen);

        }
    }
}
