﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlsAndRoutes.AddtionControllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Addition Controllers - Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }
    }
}