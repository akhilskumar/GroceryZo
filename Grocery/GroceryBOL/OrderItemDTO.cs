using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryBOL
{
    public  class OrderItemDTO
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Total { get; set; }

        public  OrderDTO Order { get; set; }
        public  ProductDTO Product { get; set; }
    }
}
