using System;
using System.Web.Mvc;

namespace JohnWeb.WebUI.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult NotFound(int id)
        {
            Response.StatusCode = id;
            return View();
        }

        public ActionResult Force()
        {
            throw new Exception("Error not working");
        }
    }
}