using RestroMonk.Data;
using RestroMonk.Domain.Interfaces.Repository;
using RestroMonk.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestroMonk.Repository
{
    public class UserRepository:IUserRepository
    {
        public bool AddUser(User user)
        {
            using (var context = new BaseContext())
            {
                context.User.Add(user);
                context.SaveChanges();
            }
            return true;
        }

        public IEnumerable<User> GetUsers()
        {
            using(var context = new BaseContext())
            {
                var users = context.User.AsEnumerable();
                if (users.Any() == false)
                {
                    return null;
                }
                return users.ToList();
            }
        }
    }
}
