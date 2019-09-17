using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Bl;
using Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Controllers
{
    public class TipoArticuloController : Controller
    {
        // GET: TipoArticulo
        private BTipoArticulo _TipoArticulo = new BTipoArticulo();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetTipoArticulo()
        {
            var result = from s in _TipoArticulo.GetTipoArticulo()
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
        public ActionResult Create(VmTipoArticulo almacen)
        {
            if (almacen != null)
            {
                this._TipoArticulo.InsertTipoArticulo(almacen);
                return RedirectToAction("Index");
            }
            return ViewBag.Mensaje = "El Formulario no puede ser Enviado En Blanco!!";
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_TipoArticulo.DetailsTipoArticulo(id));
        }
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirmed(VmTipoArticulo almacen)
        {
            if (almacen != null)
            {
                this._TipoArticulo.updateTipoArticulo(almacen);
                return RedirectToAction("Index");
            }
            return ViewBag.Mensaje = "El Formulario no puede ser Enviado En Blanco!!";
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(_TipoArticulo.DetailsTipoArticulo(id));
        }
        [HttpPost, ActionName("Details")]
        [ValidateAntiForgeryToken]
        public ActionResult DetailsConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                _TipoArticulo.DetailsTipoArticulo(id);
            }
            return View(_TipoArticulo);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_TipoArticulo.DetailsTipoArticulo(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                _TipoArticulo.DeleteTipoArticulo(id);
                return RedirectToAction("Index");
            }
            return View(_TipoArticulo);

        }
    }
}
