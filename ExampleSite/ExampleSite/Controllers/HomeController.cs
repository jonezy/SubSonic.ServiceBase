using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using ExampleSite.Data;
using ExampleSite.Infrastructure;

namespace ExampleSite.Controllers {
    public class HomeController : Controller {
        //
        // GET: /Home/

        public ActionResult Index() {
            UserService service = new UserService();
            List<User> users = service.GetData<User>();
            User user = service.Single(users.FirstOrDefault().UserID);
            return View();
        }

    }
}
