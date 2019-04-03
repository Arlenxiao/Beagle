using System.Web;
using System.Web.Mvc;

namespace NewLife.Cube.Beagle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
