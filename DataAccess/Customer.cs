using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }

        public virtual Member User { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
