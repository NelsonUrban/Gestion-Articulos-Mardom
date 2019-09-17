using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Repository
{
    public class RtipoArticulos
    {
        private Gestion_Articulos_MardomEntities1 Context;

        public RtipoArticulos(Gestion_Articulos_MardomEntities1 Context)
        {
            this.Context = Context;
        }
        public IEnumerable<Tipo_Articulo> GetTipoArticulo()
        {
            return Context.Tipo_Articulo.ToList();
        }      
        public Tipo_Articulo GetTipoarticuloForID(int id)
        {
            return Context.Tipo_Articulo.Find(id);
        }
        public void InsertTipoArticulo(Tipo_Articulo TipoArticulos)
        {
            this.Context.Tipo_Articulo.Add(TipoArticulos);
        }
        public void DeleteTipoArticulo(int id)
        {
            Tipo_Articulo Articulo_Tipos = Context.Tipo_Articulo.Find(id);
            Context.Tipo_Articulo.Remove(Articulo_Tipos);
        }

        public void UpdateTipoArticulo(Tipo_Articulo TipoArticulo)
        {
            Context.Entry(TipoArticulo).State = EntityState.Modified;
        }
        public void Save()
        {
            Context.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposed)
        {
            if (!this.disposed)
            {
                if (disposed)
                {
                    Context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}