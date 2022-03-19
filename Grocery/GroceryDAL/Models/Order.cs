using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryDAL
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string OrderNo { get; set; }
        public decimal? Total { get; set; }
        public DateTime? OrderDate { get; set; }
        public byte? Status { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
