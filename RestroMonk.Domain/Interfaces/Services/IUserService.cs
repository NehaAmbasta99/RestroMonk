using RestroMonk.Domain.Models;
using System.Collections.Generic;

namespace RestroMonk.Domain.Interfaces.Services
{
   public interface IUserService
    {
        bool AddUser(User user);
        IEnumerable<User> GetUsers();
    }
}
