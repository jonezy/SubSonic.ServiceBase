using System.Web.Mvc;
using System.Web.Routing;

using ExampleSite.Infrastructure.Data;

namespace ExampleSite {
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        public static void RegisterEndPoints(DatabaseEndPointCollection endPoints) {
            endPoints.MapStorageEndPoint(typeof(ExampleSiteDB), typeof(ExampleSiteDB));
        }

        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            // you can do this if you have multiple endpoints to make things cleaner.
            //RegisterEndPoints(DatabaseTable.Databases);

            // if you just have one end point, you can do this.
            DatabaseEndPointTable.Databases.MapStorageEndPoint(typeof(ExampleSiteDB), typeof(ExampleSiteDB));
        }
    }
}