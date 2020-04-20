using System.Web;
using System.Web.Mvc;

namespace _3_ways_to_use_multiple_submit_buttons
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
