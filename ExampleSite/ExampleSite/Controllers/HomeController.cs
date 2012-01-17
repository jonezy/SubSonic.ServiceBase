using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExampleSite.Infrastructure;

namespace ExampleSite.Controllers {
    public class HomeController : Controller {
        //
        // GET: /Home/

        public ActionResult Index() {
            UserService service = new UserService();

            return View();
        }

    }
}
