using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examen_Practico___MARDOM___Gestion_de_Articulos.Models;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos.Repository
{
    public class Rreports
    {
        private Gestion_Articulos_MardomEntities1 Context;

        public Rreports(Gestion_Articulos_MardomEntities1 Context)
        {
            this.Context = Context;
        }
        public IEnumerable<Sp_Report_List_Articulos_Result> getListArticulos()
        {

            return Context.Sp_Report_List_Articulos().ToList();
        }

    }
}