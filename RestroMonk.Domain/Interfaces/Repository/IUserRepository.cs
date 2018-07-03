using RestroMonk.Domain.Models;

namespace RestroMonk.Domain.Interfaces.Repository
{
    public interface IUserRepository
    {
        bool AddUser(User user);
    }
}
