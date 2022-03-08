using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryDAL.Models
{
    public partial class ProductCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool? Flag { get; set; }
        public string Image { get; set; }

        public virtual Product Product { get; set; }
    }
}
