﻿using System.Web.Mvc;

namespace JohnWeb.WebUI.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}