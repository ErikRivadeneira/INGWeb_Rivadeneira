using System.Web;
using System.Web.Mvc;

namespace INGWeb_Rivadeneira
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
