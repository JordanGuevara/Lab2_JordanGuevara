using System.Web;
using System.Web.Mvc;

namespace Lab2_JordanGuevara
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
