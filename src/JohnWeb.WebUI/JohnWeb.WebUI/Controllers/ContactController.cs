using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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