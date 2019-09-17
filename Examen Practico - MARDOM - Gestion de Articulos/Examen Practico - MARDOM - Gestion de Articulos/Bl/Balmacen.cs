using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Repository;
using Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Bl
{
    public class Balmacen
    {
        private Ralmacen _almacen;
        public Balmacen()
        {
            this._almacen = new Ralmacen(new Gestion_Articulos_MardomEntities1());
        }
        public IEnumerable<Tipo_Almacen> GetTipoAlmacen()
        {
            return _almacen.GetTipoAlmacen().ToList();
        }
        public IEnumerable<Valmacen> GetAlmacen()
        {
            return _almacen.GetAlmacen().ToList();
        }
        public Almacen DetailsAlmacen(int id)
        {
            return _almacen.GetAlmacenForID(id);
        }
        public void InsertAlmacen(VmAlmacen almacen)
        {
            var Almacen = new Almacen()
            {
                Id = almacen.id,
                Descripcion = almacen.Descripcion,
                Activo = almacen.Activo,
                Fecha_creacion = DateTime.Today,
                Fecha_Modificacion = null,
                Minima = almacen.Minimo,
                Maximo = almacen.Maximo,
                Tipo_Almacen_Id = almacen.Tipo_almacen_id

            };
            this._almacen.InsertAlmacen(Almacen);
            this._almacen.Save();
            this._almacen.Dispose();
        }
        public VmAlmacen UpdateAlmacenForID( int id)
        {
            VmAlmacen vm = new VmAlmacen();
            var edit_almacen = _almacen.GetAlmacenForID(id);
            vm.Descripcion = edit_almacen.Descripcion;
            vm.id = edit_almacen.Id;
            vm.Activo = edit_almacen.Activo;
            vm.Selected = edit_almacen.Tipo_Almacen_Id;
            vm.Tipo_almacen_id = edit_almacen.Tipo_Almacen_Id;
            vm.fecha_creacion = edit_almacen.Fecha_creacion;
            vm.Maximo = edit_almacen.Maximo;
            vm.Minimo = edit_almacen.Minima;
            vm.TipoAlmacen = _almacen.GetTipoAlmacen();
            return vm;
        }
        public void UpdateAlmacen(VmAlmacen almacen)
        {
            var Almacen = new Almacen()
            {
                Id = almacen.id,
                Descripcion = almacen.Descripcion,
                Tipo_Almacen_Id = almacen.Selected,
                Activo = almacen.Activo,
                Fecha_creacion= almacen.fecha_creacion,
                Fecha_Modificacion = Convert.ToDateTime(DateTime.Now)
            };
            this._almacen.UpdateAlmacen(Almacen);
            this._almacen.Save();
            this._almacen.Dispose();
        }
        public void DeleteAlmacen(int id)
        {
            this._almacen.DeleteAlmacen(id);
            this._almacen.Save();
            this._almacen.Dispose();
        }


    }
}