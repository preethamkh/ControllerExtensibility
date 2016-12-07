using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ControllerExtensibility.Controllers;

namespace ControllerExtensibility.Infrastructure
{
    public class CustomControllerActivator : IControllerActivator // demonstrates how you can use the IControllerActivator interface to intercept requests between the controller factory and dependency resolver
    {
        public IController Create(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == typeof(ProductController))
            {
                controllerType = typeof(CustomerController);
            }

            return (IController) DependencyResolver.Current.GetService(controllerType);
        }
    }
}