using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Repository;
using Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Bl
{
    public class BTipoAlmacen
    {
        private RtipoAlmacen _TipoAlmacen;
        public BTipoAlmacen()
        {
            this._TipoAlmacen = new RtipoAlmacen(new Gestion_Articulos_MardomEntities1());
        }
        public IEnumerable<Tipo_Almacen> GetTipoAlmacen()
        {
            return _TipoAlmacen.GetTipoAlmacen ().ToList();
        }       
        public Tipo_Almacen DetailsTipoAlmacen(int id)
        {
            return _TipoAlmacen.GetTipoAlmacenForID(id);
        }
        public void InsertTipoAlmacen(VmTipoAlmacen almacen)
        {
            var Almacen = new Tipo_Almacen()
            {
                Id = almacen.id,
                descripcion = almacen.Descripcion,
                Activo = almacen.Activo,
                Fecha_creacion = DateTime.Today,
                Fecha_Modificacion = null          

            };
            this._TipoAlmacen.InsertTipoAlmacen(Almacen);
            this._TipoAlmacen.Save();
            this._TipoAlmacen.Dispose();
        }
        public VmTipoAlmacen UpdateTipoAlmacenForID(int id)
        {
            VmTipoAlmacen vm = new VmTipoAlmacen();
            var editAlmacen = _TipoAlmacen.GetTipoAlmacenForID(id);
            vm.Descripcion = editAlmacen.descripcion;
            vm.fecha_creacion = editAlmacen.Fecha_creacion;
            vm.id = editAlmacen.Id;
            vm.Activo = editAlmacen.Activo;                
            return (vm);
        }
        public void updateTipoAlmacen(VmTipoAlmacen almacen)
        {
            var Almacen = new Tipo_Almacen()
            {
                Id = almacen.id,
                descripcion = almacen.Descripcion,            
                Activo = almacen.Activo,
                Fecha_creacion = almacen.fecha_creacion,
                Fecha_Modificacion = Convert.ToDateTime(DateTime.Today)
            };
            this._TipoAlmacen.UpdateTipoAlmacen(Almacen);
            this._TipoAlmacen.Save();
            this._TipoAlmacen.Dispose();
        }
        public void DeleteAlmacen(int id)
        {
            this._TipoAlmacen.DeleteTipoAlmacen(id);
            this._TipoAlmacen.Save();
            this._TipoAlmacen.Dispose();
        }


    }

}
