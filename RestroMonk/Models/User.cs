using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestroMonk.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address
        {
            get; set;
        }
        public int RoleId { get; set; }

        public virtual ICollection<Address> Addressess { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}