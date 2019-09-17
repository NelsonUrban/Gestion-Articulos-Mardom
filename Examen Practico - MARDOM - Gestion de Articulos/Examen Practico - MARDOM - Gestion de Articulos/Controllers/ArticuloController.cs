using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Bl;
using Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Controllers
{
    public class ArticuloController : Controller
    {
        // GET: Articulo
        private BArticulo _Articulo = new BArticulo();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetArticulo()
        {
            var result = from s in _Articulo.GetArticulo()
                         select new
                         {
                             s.Id,
                             s.Nombre,
                             s.Precio_1,
                             s.Referencia,
                             s.Activo
                         };
            var model = result.ToList();
            return Json(new { data = model }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Create()
        {
            VmArticulos vmArticulos = new VmArticulos();
            vmArticulos.TipoArticulo = _Articulo.GetTipoArticulo();
            return View(vmArticulos);
        }
        [HttpPost]
        public ActionResult Create(VmArticulos articulo)
        {
            if (articulo != null)
            {
                this._Articulo.InsertArticulo(articulo);
                return RedirectToAction("Index");
            }
            return ViewBag.Mensaje = "El Formulario no puede ser Enviado En Blanco!!";
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_Articulo.UpdateArticuloForID(id));
        }
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirmed(VmArticulos articulo)
        {
            if (articulo != null)
            {
                this._Articulo.updateArticulo(articulo);
                return RedirectToAction("Index");
            }
            return ViewBag.Mensaje = "El Formulario no puede ser Enviado En Blanco!!";
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(_Articulo.DetailsArticulo(id));
        }
        [HttpPost, ActionName("Details")]
        [ValidateAntiForgeryToken]
        public ActionResult DetailsConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                _Articulo.DetailsArticulo(id);
            }
            return View(_Articulo);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_Articulo.DetailsArticulo(id));
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                _Articulo.DeletArticulo(id);
                return RedirectToAction("Index");
            }
            return View(_Articulo);

        }
    }

}
