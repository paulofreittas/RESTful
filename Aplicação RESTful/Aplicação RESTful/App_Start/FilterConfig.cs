using System.Web;
using System.Web.Mvc;

namespace Aplicação_RESTful
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
