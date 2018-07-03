using RestroMonk.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace RestroMonk.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new List<User>
            {
                new User{ FirstName="Neha", LastName="Ambasta", Address= new Address
                {
                     Address1="Kanan Vihar", Address2="Patia", Country="India", PostalCode="751024", State="Odisha", City="Bhubaneswar"
                }, Id=1
                }
            };
        }
    }
}
