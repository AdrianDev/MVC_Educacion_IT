using System.Web;
using System.Web.Mvc;

namespace com.educacionit.ms.mvc.pet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
