using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Bl;
using Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Controllers
{
    public class AlmacenController : Controller 
    {
        private Balmacen _almacen = new Balmacen();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAlmacen()
        {
            var result = from s in _almacen.GetAlmacen()
                         select new
                         {
                             s.Id,
                             s.Descripcion,
                             s.Tipo_Almacen,
                             s.Activo
                         };
            var model = result.ToList();
            return Json(new { data = model }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Create()
        {
            VmAlmacen VmAlmacen = new VmAlmacen();
            VmAlmacen.TipoAlmacen = _almacen.GetTipoAlmacen();
            return View(VmAlmacen);
        }
        [HttpPost]
        public ActionResult Create(VmAlmacen almacen)
        {
            if (almacen != null)
            {
                this._almacen.InsertAlmacen(almacen);
                return RedirectToAction("Index");
            }
            return ViewBag.Mensaje = "El Formulario no puede ser Enviado En Blanco!!";
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_almacen.UpdateAlmacenForID(id));
        }
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirmed(VmAlmacen almacen)
        {
            if (almacen != null)
            {
                this._almacen.UpdateAlmacen(almacen);
                return RedirectToAction("Index");
            }
            return ViewBag.Mensaje = "El Formulario no puede ser Enviado En Blanco!!";
        }


        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(_almacen.DetailsAlmacen(id));
        }
        [HttpPost, ActionName("Details")]
        [ValidateAntiForgeryToken]
        public ActionResult DetailsConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                _almacen.DetailsAlmacen(id);
            }
            return View(_almacen);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_almacen.DetailsAlmacen(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                _almacen.DeleteAlmacen(id);
                return RedirectToAction("Index");
            }
            return View(_almacen);

        }
    }


}