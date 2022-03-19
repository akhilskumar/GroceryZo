using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryDAL
{
    public partial class Unit
    {
        public Unit()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsBase { get; set; }
        public bool? Flag { get; set; }
        public int? UnitId { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
