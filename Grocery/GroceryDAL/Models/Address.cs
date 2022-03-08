using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryDAL.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string Address1 { get; set; }
        public string Landmark { get; set; }
        public int? Pincodeid { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Pincode Pincode { get; set; }
    }
}
