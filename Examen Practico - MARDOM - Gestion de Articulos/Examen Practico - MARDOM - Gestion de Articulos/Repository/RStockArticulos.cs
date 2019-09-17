using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Repository
{
    public class RStockArticulos
    {
        private Gestion_Articulos_MardomEntities1 Context;
        public RStockArticulos(Gestion_Articulos_MardomEntities1 Context)
        {
            this.Context = Context;
        }
        public IEnumerable<Articulo_stock> GetStock()
        {
            return Context.Articulo_stock.ToList();
        }
    }
}
