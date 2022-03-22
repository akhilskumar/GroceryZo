using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryBOL
{
    public  class OrderDTO
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string OrderNo { get; set; }
        public decimal? Total { get; set; }
        public DateTime? OrderDate { get; set; }
        public byte? Status { get; set; }

        public  CustomerDTO Customer { get; set; }
        public  List<OrderItemDTO> OrderItems { get; set; }
    }
}
