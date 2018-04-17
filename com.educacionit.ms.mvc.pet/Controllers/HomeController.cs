using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using com.educacionit.ms.mvc.pet.Helpers;
using com.educacionit.ms.mvc.pet.Models;



namespace com.educacionit.ms.mvc.pet.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult GiveInAdoption ()
        {
            return View ();
        }

        [HttpPost]
        public ActionResult GiveInAdoption (Pet pet)
        {
            ViewBag.Message = String.Concat ("Thank you very much for register to ", pet.Contact.Name);

            return View ();
        }

        [HttpGet]
        public ActionResult Adopt()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adopt (Person per)
        {
            ViewBag.Message = String.Concat("Thank you very much for the adoption request ", per.Name);

            return View();
        }

        public ActionResult SetCulture(string culture)
        {
            // Validate input
            culture = CultureHelper.GetImplementedCulture(culture);

            // Save culture in a cookie
            HttpCookie cookie = Request.Cookies["_culture"];
            if (cookie != null)
                cookie.Value = culture;   // update cookie value
            else
            {

                cookie = new HttpCookie("_culture");
                cookie.Value = culture;
                cookie.Expires = DateTime.Now.AddYears(1);
            }
            Response.Cookies.Add(cookie);

            return RedirectToAction("Adopt");
        }
    }
}