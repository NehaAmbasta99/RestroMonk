using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestroMonk.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}