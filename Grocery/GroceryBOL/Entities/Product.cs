using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryBOL.Entities
{
    public  class Product
    {

        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public bool? Flag { get; set; }
        public string ProductDesc { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitId { get; set; }
        public string Image { get; set; }
        public int? UnitIncrement { get; set; }

        public  ProductCategory IdNavigation { get; set; }
        public  Unit Unit { get; set; }
        public  List<OrderItem> OrderItems { get; set; }
    }
}
