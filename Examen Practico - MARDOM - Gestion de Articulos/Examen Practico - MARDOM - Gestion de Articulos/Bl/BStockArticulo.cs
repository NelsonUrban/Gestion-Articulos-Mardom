using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Repository;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Bl
{
    public class BStockArticulo
    {
        private RStockArticulos _stock;
        public BStockArticulo()
        {
            this._stock = new RStockArticulos(new Gestion_Articulos_MardomEntities1());
        }
        public IEnumerable<Articulo_stock> GetStock()
        {
            return _stock.GetStock().ToList();
        }

    }
}