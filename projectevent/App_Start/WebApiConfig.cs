using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace projectevent
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
            config.Routes.MapHttpRoute(
               name: "DefaultApi1",
               routeTemplate: "api/{controller}/{date1}/{vid}",
               defaults: new { date1 = RouteParameter.Optional, vid = RouteParameter.Optional }
           );
            config.Routes.MapHttpRoute(
              name: "DefaultApi3",
              routeTemplate: "api/{controller}/{search}",
              defaults: new { search = RouteParameter.Optional }
          );
           
        }
    }
}
