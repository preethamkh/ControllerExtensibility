using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerExtensibility.Infrastructure;
using ControllerExtensibility.Models;

namespace ControllerExtensibility.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "Product",
                ActionName = "Index"
            });
        }

        [Local]
        [ActionName("Index")]
        public ActionResult LocalIndex()
        {
            return View("Result", new Result
            {
                ControllerName = "Product",
                ActionName = "LocalIndex"
            });
        }

        protected override void HandleUnknownAction(string actionName)
        {
            Response.Write(string.Format("You requested the {0} action", actionName));
        }
    }
}