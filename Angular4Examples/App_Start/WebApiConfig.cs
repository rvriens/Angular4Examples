using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Angular4Examples
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
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Single Page Application - Controller
            config.Routes.MapHttpRoute(
                name: "Default",
                routeTemplate: "{*catchall}",
                defaults: new { controller = "Spa" }
            );

        }
    }
}
