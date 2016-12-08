using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerExtensibility.Infrastructure
{
    public class CustomActionInvoker : IActionInvoker
    {
        public bool InvokeAction(ControllerContext controllerContext, string actionName)
        {
            if (actionName != "Index") return false;
            controllerContext.HttpContext.Response.Write("This is the output from the index action");
            return true;
        }
    }
}