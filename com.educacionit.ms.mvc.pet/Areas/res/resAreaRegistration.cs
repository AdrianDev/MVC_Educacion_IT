using System.Web.Mvc;

namespace com.educacionit.ms.mvc.pet.Areas.res
{
    public class resAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "res";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "res_default",
                "res/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}