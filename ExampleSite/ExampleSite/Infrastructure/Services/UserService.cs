using System;
using System.Linq;
using System.Linq.Expressions;

using ExampleSite.Infrastructure.Data;

namespace ExampleSite.Infrastructure.Services {
    public class UserService : ServiceBase {
        protected override string CacheKey {
            get { return "UserService.Users"; }
        }   

        public User Single(int userId) {
            return base.GetData<User, ExampleSiteDB>(u => u.UserID == userId).FirstOrDefault();
        }
    }
}