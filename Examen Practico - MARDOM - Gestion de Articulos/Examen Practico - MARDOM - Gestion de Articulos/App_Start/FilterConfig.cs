using System.Web;
using System.Web.Mvc;

namespace Examen_Practico___MARDOM___Gestion_de_Articulos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
