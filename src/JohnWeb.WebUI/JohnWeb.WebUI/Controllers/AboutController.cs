using System.Web.Mvc;

namespace JohnWeb.WebUI.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult AboutMe()
        {
            return View();
        }
    }
}