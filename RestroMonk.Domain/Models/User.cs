﻿namespace RestroMonk.Domain.Models
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
        public Role Role
        {
            get; set;
        }
    }
}