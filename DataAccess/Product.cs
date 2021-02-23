using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Product
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
            StoreInventories = new HashSet<StoreInventory>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<StoreInventory> StoreInventories { get; set; }
    }
}
