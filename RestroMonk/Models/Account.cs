namespace RestroMonk.Models
{
    public class Account
    {
            public string AccountNumber { get; set; }
            public string Id { get; set; }
            public string BankName { get; set; }
            public string Name { get; set; }
            public Address Address
            {
                get; set;
            }
    }
}