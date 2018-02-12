using System.Web;
using System.Web.Mvc;

namespace ItUniver.Calc.WebCalc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
