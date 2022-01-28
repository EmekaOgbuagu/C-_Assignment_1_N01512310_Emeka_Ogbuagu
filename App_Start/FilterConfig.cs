using System.Web;
using System.Web.Mvc;

namespace My_First_Project_N01512310_Emeka
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
