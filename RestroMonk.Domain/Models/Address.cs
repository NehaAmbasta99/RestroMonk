using System.ComponentModel.DataAnnotations.Schema;

namespace RestroMonk.Domain.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("Id")]
        public virtual Account Account { get; set; }
    }
}
