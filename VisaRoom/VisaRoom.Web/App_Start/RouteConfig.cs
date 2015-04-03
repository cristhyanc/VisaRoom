using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VisaRoom.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "RegisterApplicant", id = UrlParameter.Optional }
            );

            routes.MapRoute("GetStatesByCountryId",
                           "Services/GetStatesByCountryId/",
                           new { controller = "Services", action = "GetStatesByCountryId" },
                           new[] { "VisaRoom.Web.Controllers" });

            routes.MapRoute("GetCityByState",
                           "Services/GetCityByState/",
                           new { controller = "Services", action = "GetCityByState" },
                           new[] { "VisaRoom.Web.Controllers" });
        }
    }
}