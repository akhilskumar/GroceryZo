using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryBOL.Entities
{
    public  class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsBase { get; set; }
        public bool? Flag { get; set; }
        public int? UnitId { get; set; }
        public  List<Product> Products { get; set; }
    }
}
