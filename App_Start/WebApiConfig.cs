﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace isMART.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { controller = "Product", action = "GetAllProducts", id = RouteParameter.Optional }
            );
        }
    }
}
