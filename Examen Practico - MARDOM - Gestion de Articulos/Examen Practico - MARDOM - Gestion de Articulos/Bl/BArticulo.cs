using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Repository;
using Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Bl
{
    public class BArticulo
    {
        private Rarticulos _articulos;
        public BArticulo()
        {
            this._articulos = new Rarticulos(new Gestion_Articulos_MardomEntities1());
        }
        public IEnumerable<Tipo_Articulo> GetTipoArticulo()
        {
            return _articulos.GetTipoArticulo().ToList();
        }
        public IEnumerable<Articulos> GetArticulo()
        {
            return _articulos.GetArticulo().ToList();
        }
        public Articulos DetailsArticulo (int id)
        {
            return _articulos.GetaticuloForID(id);
        }
        public void InsertArticulo(VmArticulos articulo)
        {
            var articulos = new Articulos()
            {
                Id = articulo.id,
                Nombre = articulo.Nombre,
                Referencia = articulo.Referencia,
                Precio_1 = articulo.Precio_1,
                Precio_2 =articulo.Precio_2,
                Precio_3 =articulo.Precio_3,
                Expira =articulo.Expira,
                Tipo_Articulo_Id = articulo.Tipo_Articulo_id,
                Codigo_Barra = articulo.Codigo_Barra,
                Activo = articulo.Activo,
                Fecha_creacion = DateTime.Today,
                Fecha_Modificacion = null

            };
            this._articulos.InsertArticulos(articulos);
            this._articulos.Save();
            this._articulos.Dispose();
        }
        public VmArticulos UpdateArticuloForID(int id)
        {
            VmArticulos vm = new VmArticulos();
            var editArticulo = _articulos.GetaticuloForID(id);
            vm.id = editArticulo.Id;
            vm.Nombre = editArticulo.Nombre;
            vm.Expira = editArticulo.Expira;
            vm.Precio_1 = editArticulo.Precio_1;
            vm.Precio_2 = editArticulo.Precio_2;
            vm.Precio_3 = editArticulo.Precio_3;
            vm.Referencia = editArticulo.Referencia;
            vm.Codigo_Barra = editArticulo.Codigo_Barra;
            vm.Activo = editArticulo.Activo;
            vm.Tipo_Articulo_id = editArticulo.Tipo_Articulo_Id;
            return (vm);
        }
        public void updateArticulo(VmArticulos articulo)
        {
            var articulos = new Articulos()
            {
                Id = articulo.id,
                Nombre = articulo.Nombre,
                Activo = articulo.Activo,
                Precio_1 =articulo.Precio_1,
                Precio_2 = articulo.Precio_2,
                Precio_3 =articulo.Precio_3,
                Referencia =articulo.Referencia,
                Expira =articulo.Expira,
                Codigo_Barra = articulo.Codigo_Barra,
                Tipo_Articulo_Id =articulo.Selected,
                Fecha_creacion = articulo.Fecha_creacion,
                Fecha_Modificacion = Convert.ToDateTime(DateTime.Today)
            };
            this._articulos.UpdateArticulo(articulos);
            this._articulos.Save();
            this._articulos.Dispose();
        }
        public void DeletArticulo(int id)
        {
            this._articulos.DeleteArticulo(id);
            this._articulos.Save();
            this._articulos.Dispose();
        }

    }
}