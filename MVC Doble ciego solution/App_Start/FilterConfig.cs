using System.Web;
using System.Web.Mvc;

namespace MVC_Doble_ciego_solution
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
