using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class Store
    {
        public Store()
        {
            Orders = new HashSet<Order>();
            StoreInventories = new HashSet<StoreInventory>();
        }

        public int Id { get; set; }
        public string StoreName { get; set; }
        public string StoreLocationAddress { get; set; }
        public string StoreLocationCity { get; set; }
        public string StoreLocationState { get; set; }
        public string StoreLocationCountry { get; set; }
        public string StoreLocationZip { get; set; }
        public string StorePhoneNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<StoreInventory> StoreInventories { get; set; }
    }
}
