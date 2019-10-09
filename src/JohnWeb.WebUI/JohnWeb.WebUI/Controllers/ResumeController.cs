using System.Web.Mvc;

namespace JohnWeb.WebUI.Controllers
{
    public class ResumeController : Controller
    {
        // GET: Resume
        public ActionResult MyResume()
        {
            return View("MyResume");
        }
    }
}