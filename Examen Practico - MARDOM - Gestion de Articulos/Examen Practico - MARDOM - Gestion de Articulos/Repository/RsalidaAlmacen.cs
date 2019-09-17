using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Repository
{
    public class RsalidaAlmacen
    {

        private Gestion_Articulos_MardomEntities1 Context;

        public RsalidaAlmacen(Gestion_Articulos_MardomEntities1 Context)
        {
            this.Context = Context;
        }

        public Models.Salida_Almacen InsertSalida(Models.Salida_Almacen Salida) // cabecera y detalle
        {

            return Context.Salida_Almacen.Add(Salida);

        }
        public void RestarInventario(int Articuloid, int cantidad, int existencia, int existenciaActual, int AlmacenId)
        {
            Context.Sp_Salida_Almacen(Articuloid, cantidad, existencia, existenciaActual, AlmacenId);
        }
        public int GetIdSalida()
        {

            int lasOrderId = Context.Salida_Almacen.ToList().Select(o => o.Id).Max();

            return lasOrderId;
        }
        public int SearchIdArtculos(string codigoB) // Busca el Id del Producto para insertar el detalle
        {
            var ArticuloID = Context.Articulos.ToList().Where(m => m.Codigo_Barra == codigoB).Select(m => m.Id).FirstOrDefault();

            return ArticuloID;
        }
        public IEnumerable<VSalida_Almacen> GetSalida()
        {
            return Context.VSalida_Almacen.ToList();
        }

        public void InsertDetailsSalida(Detalle_Salida_Almacen detSalida)
        {
            Context.Detalle_Salida_Almacen.Add(detSalida);
        }
        public void DeleteSalida(int id)
        {
            Salida_Almacen salida = Context.Salida_Almacen.Find(id);
            Context.Salida_Almacen.Remove(salida);
            Detalle_Salida_Almacen DetSalida = Context.Detalle_Salida_Almacen.Find(id);
            Context.Detalle_Salida_Almacen.Remove(DetSalida);
        }
        public IEnumerable<Articulos> GetArticulos()
        {
            return Context.Articulos.ToList();
        }
        public IEnumerable<Almacen> GetAlmacenes()
        {
            return Context.Almacen.ToList();
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