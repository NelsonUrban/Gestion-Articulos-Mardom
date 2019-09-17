using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Repository
{
    public class Ralmacen
    {
        private Gestion_Articulos_MardomEntities1 Context;

        public Ralmacen(Gestion_Articulos_MardomEntities1 Context)
        {
            this.Context = Context;
        }
        public IEnumerable<Valmacen> GetAlmacen()
        {
            return Context.Valmacen.ToList();
        }
        public IEnumerable<Tipo_Almacen> GetTipoAlmacen()
        {
            return Context.Tipo_Almacen.ToList();
        }
        public Almacen GetAlmacenForID(int id)
        {
            return Context.Almacen.Find(id);
        }
        public void InsertAlmacen(Almacen Almacen)
        {
            this.Context.Almacen.Add(Almacen);
        }
        public void DeleteAlmacen(int id)
        {
            Almacen Almacen = Context.Almacen.Find(id);
            Context.Almacen.Remove(Almacen);
        }

        public void UpdateAlmacen(Almacen Almacen)
        {

            Context.Entry(Almacen).State = EntityState.Modified;
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