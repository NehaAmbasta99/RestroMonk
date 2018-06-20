using RestroMonk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestroMonk.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return new List<Account>
            {
                new Account{ AccountNumber="0001", BankName="Dummy Bank", Address= new Address
                {
                     Address1="Kanan Vihar", Address2="Patia", Country="India", PostalCode="751024", State="Odisha", City="Bhubaneswar"
                }, Id="Cust001", Name="Nea Ambasta"
                }
            };
        }
    }
}
