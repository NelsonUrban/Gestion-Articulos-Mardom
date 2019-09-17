using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Repository
{
    public class Rarticulos
    {
        private Gestion_Articulos_MardomEntities1 Context;

        public Rarticulos(Gestion_Articulos_MardomEntities1 Context)
        {
            this.Context = Context;
        }
        public IEnumerable<Articulos> GetArticulo()
        {
            return Context.Articulos.ToList();
        }   
        public IEnumerable<Tipo_Articulo> GetTipoArticulo()
        {
            return Context.Tipo_Articulo.ToList();
        }  
        public Articulos GetaticuloForID(int id)
        {
            return Context.Articulos.Find(id);
        }
        public void InsertArticulos(Articulos Articulos)
        {
            this.Context.Articulos.Add(Articulos);
        }
        public void DeleteArticulo(int id)
        {
            Articulos Articulos = Context.Articulos.Find(id);
            Context.Articulos.Remove(Articulos);
        }

        public void UpdateArticulo(Articulos Articulos)
        {
            Context.Entry(Articulos).State = EntityState.Modified;
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