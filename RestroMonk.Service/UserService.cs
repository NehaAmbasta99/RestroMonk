using RestroMonk.Domain.Interfaces.Services;
using RestroMonk.Domain.Models;
using RestroMonk.Repository;
using System.Collections.Generic;
using System.Linq;

namespace RestroMonk.Service
{
    public class UserService: IUserService
    {
        public bool AddUser(User user)
        {
            return new UserRepository().AddUser(user);
        }

        public IEnumerable<User> GetUsers()
        {
            return new UserRepository().GetUsers().ToList();
        }
    }
}
