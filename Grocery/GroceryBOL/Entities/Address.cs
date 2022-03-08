using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryBOL.Entities
{
    public  class Address
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string Address1 { get; set; }
        public string Landmark { get; set; }
        public int? Pincodeid { get; set; }

        public  Customer Customer { get; set; }
        public  Pincode Pincode { get; set; }
    }
}
