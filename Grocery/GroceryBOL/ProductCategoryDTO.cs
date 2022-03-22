using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryBOL
{
    public  class ProductCategoryDTO
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool? Flag { get; set; }
        public string Image { get; set; }

        public  ProductDTO Product { get; set; }
    }
}
