using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;

namespace Cormant.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("GetEmployees", "api/employee",
                new {controller = "Employee", action = "GetEmployees"},
                new {httpMethod = new HttpMethodConstraint(HttpMethod.Get)}
                );

            config.Routes.MapHttpRoute("Login", "api/employee/email={email},password={password}/",
                new {controller = "Employee,", action = "Login"}, 
                new {httpMethod = new HttpMethodConstraint(HttpMethod.Get)}
                );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
