using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Member
    {
        public Member()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string CustomerLocationAddress { get; set; }
        public string CustomerLocationCity { get; set; }
        public string CustomerLocationState { get; set; }
        public string CustomerLocationCountry { get; set; }
        public string CustomerLocationZip { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
