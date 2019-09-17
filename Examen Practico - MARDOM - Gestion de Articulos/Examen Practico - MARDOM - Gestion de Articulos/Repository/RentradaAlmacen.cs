using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;
namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Repository
{
    public class RentradaAlmacen
    {
        private Gestion_Articulos_MardomEntities1 Context;

        public RentradaAlmacen(Gestion_Articulos_MardomEntities1 Context)
        {
            this.Context = Context;
        }

        public Models.Entrada_Almacen InsertEntrada(Models.Entrada_Almacen Entrada) // cabecera 
        {

            return Context.Entrada_Almacen.Add(Entrada);

        }
        public void ValidarStock(int AlmacenID, int ArticuloID)
        {
            Context.Sp_VerificarProductoEnStock(AlmacenID,ArticuloID);
        }
        public int SearchArticulos(string codigoB) // Busca el Id del Producto para insertar el detalle por el codigo de referencia del producto
        {
            var ArticuloID = Context.Articulos.ToList().Where(m => m.Codigo_Barra == codigoB).Select(m => m.Id).FirstOrDefault();

            return ArticuloID;
        }
        public int GetIdEntrada()
        {

            int lastentradaId = Context.Entrada_Almacen.ToList().Select(o => o.Id).Max();

            return lastentradaId;
        }
        public void InsertDetailsEntrada(Models.Detalle_Entrada_Almacen detentrada) // Detalle
        {
            Context.Detalle_Entrada_Almacen.Add(detentrada);
        }
        public IEnumerable<Articulos> getArticulo()
        {
            return Context.Articulos.ToList();
        }
        public IEnumerable<VEntrada_Almacen> GetEntrada()
        {
            return Context.VEntrada_Almacen.ToList();
        }
        public IEnumerable<Almacen> getAlmacenes()
        {
            return Context.Almacen.ToList();
        }
        public void DeleteEntrada(int id)
        {
            Entrada_Almacen Entrada = Context.Entrada_Almacen.Find(id);
            Context.Entrada_Almacen.Remove(Entrada);
            Detalle_Entrada_Almacen DetEntrada = Context.Detalle_Entrada_Almacen.Find(id);
            Context.Detalle_Entrada_Almacen.Remove(DetEntrada);
        }       
        public void UpdateStock(int articuloid, int cantidad, int existencia, int existenciaactu, int almacenid)
        {
            Context.Sp_Entrada_Almacen(articuloid, cantidad, existencia, existenciaactu, almacenid);
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
