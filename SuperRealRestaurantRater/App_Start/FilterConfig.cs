using System.Web;
using System.Web.Mvc;

namespace SuperRealRestaurantRater
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
