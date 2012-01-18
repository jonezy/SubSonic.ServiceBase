using System;
using System.Linq;
using System.Linq.Expressions;

using ExampleSite.Data;

namespace ExampleSite.Infrastructure {
    public class UserService : ServiceBase {
        public User Single(int userId) {
            Expression<Func<User,bool>> expression = u => u.UserID == userId;
            return base.GetData<User>(expression).FirstOrDefault();
        }
    }
}