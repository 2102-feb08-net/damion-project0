using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime DatePlaced { get; set; }
        public int? StoreId { get; set; }

        public virtual Member Customer { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
