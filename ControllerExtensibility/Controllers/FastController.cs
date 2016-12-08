using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using ControllerExtensibility.Models;

namespace ControllerExtensibility.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    // If you want to pass data from controller to the view - consider using VIEWBAG -> this is not affected by the SessionState attribute
    public class FastController : Controller
    {
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "Fast",
                ActionName = "Index"
            });
        }
    }
}