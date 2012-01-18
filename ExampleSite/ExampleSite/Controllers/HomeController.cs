using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using ExampleSite.Data;
using ExampleSite.Infrastructure;

namespace ExampleSite.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            UserService service = new UserService();
            if (service.IsConnected) {
                List<User> users = service.GetData<User>();
                User user = null;
                if (users.Count > 0)
                    user = service.Single(users.FirstOrDefault().UserID);
            }

            return View();
        }

    }
}
