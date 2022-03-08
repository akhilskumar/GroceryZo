using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryBOL.Entities
{
    public  class Order
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string OrderNo { get; set; }
        public decimal? Total { get; set; }
        public DateTime? OrderDate { get; set; }
        public byte? Status { get; set; }

        public  Customer Customer { get; set; }
        public  List<OrderItem> OrderItems { get; set; }
    }
}
