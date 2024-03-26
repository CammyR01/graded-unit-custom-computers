using System.Web;
using System.Web.Mvc;

namespace CReid_Graded_Unit_2_Custom_Computers
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
