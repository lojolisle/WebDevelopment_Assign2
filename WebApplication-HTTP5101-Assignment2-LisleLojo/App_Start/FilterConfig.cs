using System.Web;
using System.Web.Mvc;

namespace WebApplication_HTTP5101_Assignment2_LisleLojo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
