using RestroMonk.Models;
using System.Collections.Generic;
using System.Web.Http;
using RestroMonk.Service;
using AutoMapper;
using RestroMonk.Domain.Interfaces.Services;

namespace RestroMonk.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            var users = new UserService().GetUsers();
            return Ok(users);
        }

        [HttpPost]
        public IHttpActionResult Add()
        {
            var user = new User
            {
                FirstName = "Neha",
                LastName = "Ambasta",
                Address = new Address
                {
                    Address1 = "Kanan Vihar",
                    Address2 = "Patia",
                    Country = "India",
                    PostalCode = "751024",
                    State = "Odisha",
                    City = "Bhubaneswar"
                },
                Id = 1,
                RoleId = 1
            };
            var mappedUser = Mapper.Map<User, Domain.Models.User>(user);
            new UserService().AddUser(mappedUser);
            return Ok(mappedUser);
        }
    }
}
