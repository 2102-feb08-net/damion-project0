using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class StoreInventory
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? StoreId { get; set; }
        public int ProductQuantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
    }
}
