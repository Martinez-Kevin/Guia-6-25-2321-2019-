using System.Web;
using System.Web.Mvc;

namespace Guia_6__25_2321_2019_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
