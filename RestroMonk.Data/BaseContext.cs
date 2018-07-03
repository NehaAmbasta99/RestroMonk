using RestroMonk.Domain.Models;
using System.Data.Entity;

namespace RestroMonk.Data
{
    public class BaseContext:  DbContext
    {
        public BaseContext(): base("name=DbConnection")
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}
