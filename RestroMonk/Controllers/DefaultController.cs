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
                new Account{ AccountNumber="0001", BankName="Dummy Bank", CustomerAddress= new Address
                {
                     Address1="address1", Address2="address2", Country="US", PostalCode="20877", State="MD"
                }, CustomerId="Customer001", CustomerName="John Sherman"
                },  new Account{ AccountNumber="0002", BankName="Dummy Bank", CustomerAddress= new Address
                {
                     Address1="address3", Address2="address4", Country="US", PostalCode="20877", State="MD"
                }, CustomerId="Customer002", CustomerName="Marie Curie"
                }
            };
        }
    }
}
