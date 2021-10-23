using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApplication_HTTP5101_Assignment2_LisleLojo
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
               // routeTemplate: "api/{controller}/{action}/{burger}/{drink}/{side}/{dessert}",
               //    routeTemplate: "api/{controller}/{action}/{r1}/{r2}/{r3}/{r4}",
                   routeTemplate: "api/{controller}/{action}/{c1}/{c2}/{c3}/{c4}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
