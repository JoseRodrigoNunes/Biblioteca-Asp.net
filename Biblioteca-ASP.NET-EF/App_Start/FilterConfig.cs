using System.Web;
using System.Web.Mvc;

namespace Biblioteca_ASP.NET_EF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
