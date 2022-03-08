using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryDAL.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public bool? Flag { get; set; }
        public string ProductDesc { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitId { get; set; }
        public string Image { get; set; }
        public int? UnitIncrement { get; set; }

        public virtual ProductCategory IdNavigation { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
