using System;
using System.Collections.Generic;
using System.Web.Mvc;

using ExampleSite.Infrastructure.Data;
using ExampleSite.Infrastructure.Services;
using ExampleSite.Models;

namespace ExampleSite.Controllers {
    public class HomeController : Controller {
        UserService service;

        public HomeController() {
            if (service == null) service = new UserService();
            
            if (!service.IsConnected<ExampleSiteDB>())
                throw new Exception("Could not connect to the database, or the database has no tables in it");
        }

        public HomeController(UserService _service) {
            service = _service;
        }
        
        public ActionResult Index() {
            List<User> users = service.GetData<User, ExampleSiteDB>(u => u.IsActive == true);
            
            IndexViewModel model = new IndexViewModel();
            model.Users = new List<UserViewModel>();
            foreach (var item in users) {
                model.Users.Add(new UserViewModel {
                    EmailAddress = item.EmailAddress,
                    IsActive = item.IsActive
                });
            }

            return View("Index", model);
        }

    }
}
