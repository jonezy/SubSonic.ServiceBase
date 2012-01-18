using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using ExampleSite.Data;
using ExampleSite.Infrastructure;

namespace ExampleSite.Controllers {
    public class HomeController : Controller {
        UserService service;

        public HomeController() {
            if (service == null) service = new UserService();
            
            if (!service.IsConnected)
                throw new Exception("Could not connect to the database, or the database has no tables in it");
        }

        public ActionResult Index() {
            List<User> users = service.GetData<User>();
            User user = null;
            if (users.Count > 0)
                user = service.Single(users.FirstOrDefault().UserID);
            
            return View();
        }

    }
}
