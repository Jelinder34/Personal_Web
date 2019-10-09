using System.Web.Mvc;

namespace JohnWeb.WebUI.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult ContactMe()
        {
            return View("ContactMe");
        }
    }
}