using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Repository;
using Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Bl
{
    public class BTipoArticulo
    {
        private RtipoArticulos _TipoArticulo;

        public BTipoArticulo()
        {
            this._TipoArticulo = new RtipoArticulos(new Gestion_Articulos_MardomEntities1());
        }
        public IEnumerable<Tipo_Articulo> GetTipoArticulo()
        {
            return _TipoArticulo.GetTipoArticulo().ToList();
        }
        public Tipo_Articulo DetailsTipoArticulo(int id)
        {
            return _TipoArticulo.GetTipoarticuloForID(id);
        }
        public void InsertTipoArticulo(VmTipoArticulo almacen)
        {
            var Almacen = new Tipo_Articulo()
            {
                Id = almacen.id,
                descripcion = almacen.Descripcion,
                Activo = almacen.Activo,
                Fecha_creacion = DateTime.Today,
                Fecha_Modificacion = null

            };
            this._TipoArticulo.InsertTipoArticulo(Almacen);
            this._TipoArticulo.Save();
            this._TipoArticulo.Dispose();
        }
        public VmTipoArticulo UpdateTipoArticuloForID(int id)
        {
            VmTipoArticulo vm = new VmTipoArticulo();
            var editAlmacen = _TipoArticulo.GetTipoarticuloForID(id);
            vm.Descripcion = editAlmacen.descripcion;
            vm.id = editAlmacen.Id;
            vm.Activo = editAlmacen.Activo;
            return (vm);
        }
        public void updateTipoArticulo(VmTipoArticulo almacen)
        {
            var Almacen = new Tipo_Articulo()
            {
                Id = almacen.id,
                descripcion = almacen.Descripcion,
                Activo = almacen.Activo,
                Fecha_creacion = almacen.fecha_creacion,
                Fecha_Modificacion = Convert.ToDateTime(DateTime.Today)
            };
            this._TipoArticulo.UpdateTipoArticulo(Almacen);
            this._TipoArticulo.Save();
            this._TipoArticulo.Dispose();
        }
        public void DeleteTipoArticulo(int id)
        {
            this._TipoArticulo.DeleteTipoArticulo(id);
            this._TipoArticulo.Save();
            this._TipoArticulo.Dispose();
        }


    }


}

