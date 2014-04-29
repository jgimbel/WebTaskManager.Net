using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Proccess_Application
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"Process",
				"Process/{process}",
				new {
					controller = "Process",
					action = "Index",
					process = UrlParameter.Optional
				},
				new {
					process = @"\d+"
				}
			);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


			ValueProviderFactories.Factories.Add(new JsonValueProviderFactory());
        }
    }
}
