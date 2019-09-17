using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Repository;
using Examen_Practico___MARDOM___Gestion_de_Articulos.ViewModel;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Bl
{
    public class BEntradaAlmacen
    {
        private RentradaAlmacen _Entrada;
        public BEntradaAlmacen()
        {
            this._Entrada = new RentradaAlmacen(new Gestion_Articulos_MardomEntities1());
        }
        int _IdEntrada = 0;
        public IEnumerable<Almacen> GetAlmacenes()
        {
            return this._Entrada.getAlmacenes().ToList();
        }
        public void ValidarStock(int AlmacenID, int ArticuloID)
        {
            this._Entrada.ValidarStock(AlmacenID, ArticuloID);
        }
        public IEnumerable<VEntrada_Almacen> GetEntrada()
        {
            return _Entrada.GetEntrada().ToList();
        }
        public void DeleteEntrada(int id)
        {
            _Entrada.DeleteEntrada(id);
            _Entrada.Save();
        }
        public void InsertEntrada(VmEntradaAlmacen entrada, string detalle)
        {

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            List<VmDetalleEntradaAlmacen> ListSalidaDetalle = (List<VmDetalleEntradaAlmacen>)javaScriptSerializer.Deserialize(detalle, typeof(List<VmDetalleEntradaAlmacen>));

            if (entrada != null)
            {
                var SAlmaen = new Entrada_Almacen()
                {
                    Almacen_Id = entrada.Almacen_Id,
                    Comentarios = entrada.Comentarios,
                    Fecha_crea = Convert.ToDateTime(DateTime.Now),
                    Fecha_modifica = null ,
                    Total = entrada.Total_Apagar


                };
                _Entrada.InsertEntrada(SAlmaen);               
                _Entrada.Save();
               _IdEntrada = _Entrada.GetIdEntrada();  // Retorna el Ultimo Id

            }
            foreach (VmDetalleEntradaAlmacen DetalleEntrada in ListSalidaDetalle)
            {
                var ArticuloId = _Entrada.SearchArticulos(DetalleEntrada.Producto);
                var NewDetalle = new Detalle_Entrada_Almacen
                {
                    entrada_id = _IdEntrada,
                    Articulo_id = ArticuloId,
                    Precio = DetalleEntrada.Precio,
                    Cantidad = DetalleEntrada.Cantidad,
                    fecha = Convert.ToDateTime(DateTime.Now)

                };

                _Entrada.InsertDetailsEntrada(NewDetalle);
                _Entrada.ValidarStock(entrada.Almacen_Id, ArticuloId);
                _Entrada.UpdateStock(ArticuloId, DetalleEntrada.Cantidad, 0, 0, entrada.Almacen_Id);
                _Entrada.Save();
              
            }

        }
        public IEnumerable<Articulos> GetArticulos()
        {
            return _Entrada.getArticulo().ToList();
        }

    }
}