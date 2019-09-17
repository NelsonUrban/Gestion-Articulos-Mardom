using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;
namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Repository
{
    public class RtipoAlmacen
    {
        private Gestion_Articulos_MardomEntities1 Context;

        public RtipoAlmacen(Gestion_Articulos_MardomEntities1 Context)
        {
            this.Context = Context;
        }
        public IEnumerable<Tipo_Almacen> GetTipoAlmacen()
        {
            return Context.Tipo_Almacen.ToList();
        }
        public Tipo_Almacen GetTipoAlmacenForID(int id)
        {
            return Context.Tipo_Almacen.Find(id);
        }
        public void InsertTipoAlmacen(Tipo_Almacen TipoAlmacen)
        {
            this.Context.Tipo_Almacen.Add(TipoAlmacen);
        }
        public void DeleteTipoAlmacen(int id)
        {
            Tipo_Almacen Tipo_Almacen = Context.Tipo_Almacen.Find(id);
            Context.Tipo_Almacen.Remove(Tipo_Almacen);
        }
        public void UpdateTipoAlmacen(Tipo_Almacen TipoAlmacen)
        {
            Context.Entry(TipoAlmacen).State = EntityState.Modified;
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