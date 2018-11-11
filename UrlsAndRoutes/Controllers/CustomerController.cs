using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    [RoutePrefix("Users")]
    public class CustomerController : Controller
    {
        [Route("~/Test")]
        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            return View("ActionName");
        }
        [Route("User/Add/{user}/{id:int}")]
        public string Create(string user, int id)
        {
            return string.Format("Create Method - User: {0}, Id: {1}", user, id);
        }
        [Route("User/Add/{user}/{password:alpha:length(6)}")]
        public string ChangePass(string user, string password)
        {
            return string.Format("ChangePass Method - User: {0}, Password: {1}", 
                user, password);
        }
        public ActionResult List()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "List";
            return View("ActionName");
        }
    }
}