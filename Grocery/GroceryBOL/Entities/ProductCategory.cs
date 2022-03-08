using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryBOL.Entities
{
    public  class ProductCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool? Flag { get; set; }
        public string Image { get; set; }

        public  Product Product { get; set; }
    }
}
