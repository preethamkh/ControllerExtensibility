using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerExtensibility.Models;

namespace ControllerExtensibility.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "Customer",
                ActionName = "Index"
            });
        }

        [ActionName("Enumerate")] // New action name, overrides the action name "List" below
        public ViewResult List()
        {
            return View("Result", new Result
            {
                ControllerName = "Customer",
                ActionName = "List"
            });
        }

        [NonAction]
        public ActionResult MyAction()
        {
            return View();
        }
    }
}