using System.Web;
using System.Web.Mvc;

namespace CricInfo_Web_using_Partial_View
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
