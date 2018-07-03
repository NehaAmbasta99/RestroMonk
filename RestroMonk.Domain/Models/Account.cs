using System.Collections.Generic;

namespace RestroMonk.Domain.Models
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string Id { get; set; }
        public string BankName { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}
