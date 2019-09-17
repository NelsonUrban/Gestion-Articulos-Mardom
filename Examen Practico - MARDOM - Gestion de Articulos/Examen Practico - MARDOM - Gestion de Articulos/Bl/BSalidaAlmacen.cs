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
    public class BSalidaAlmacen : Balmacen
    {
        private RsalidaAlmacen _Salida;
        public BSalidaAlmacen()
        {
            this._Salida = new RsalidaAlmacen(new Gestion_Articulos_MardomEntities1());
        }
        int _IdSalida = 0;
        public IEnumerable<Almacen> GetAlmacenes()
        {
            return this._Salida.GetAlmacenes().ToList();
        }      
        public  void InsertSalida( VmSalidaAlmacen salida , string detalle )
        {

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            List<VmDetalleSalidaAlmacen> ListSalidaDetalle = (List<VmDetalleSalidaAlmacen>)javaScriptSerializer.Deserialize(detalle, typeof(List<VmDetalleSalidaAlmacen>));

            if (_Salida != null)
            {
                var SAlmaen = new Salida_Almacen()
                {
                    Almacen_Id = salida.Almacen_Id,
                    Comentarios = salida.Comentarios,
                    Fecha_crea = Convert.ToDateTime(DateTime.Now),
                    Fecha_modifica = null,
                    Total = salida.Total_Apagar
              
                };
                _Salida.InsertSalida(SAlmaen);
                _Salida.Save();
                _IdSalida = _Salida.GetIdSalida();  // Retorna el Ultimo Id

            }
            foreach (VmDetalleSalidaAlmacen DetalleSali in ListSalidaDetalle)
            {
                var ArticuloId = _Salida.SearchIdArtculos(DetalleSali.Producto);
                var NewDetalle = new Detalle_Salida_Almacen
                {
                    Salida_id = _IdSalida,
                    Articulo_id = ArticuloId,
                    Precio = DetalleSali.Precio,
                    Cantidad = DetalleSali.Cantidad,
                    fecha = Convert.ToDateTime(DateTime.Now)
                };

                _Salida.InsertDetailsSalida(NewDetalle);
                _Salida.RestarInventario(ArticuloId, DetalleSali.Cantidad, 0, 0, salida.Almacen_Id);
                _Salida.Save();
                _Salida.Dispose();
            }         

        }
        public IEnumerable<Articulos> GetArticulos()
        {
            return _Salida.GetArticulos().ToList();
        }
        public IEnumerable<VSalida_Almacen> GetSalida()
        {
            return _Salida.GetSalida().ToList();
        }
        public void DeleteSalida(int id)
        {
            _Salida.DeleteSalida(id);
            _Salida.Save();
        }
    }
}