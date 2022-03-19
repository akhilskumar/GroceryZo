using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryDAL
{
    public partial class Pincode
    {
        public Pincode()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Pincode1 { get; set; }
        public decimal? DeliveryCharge { get; set; }
        public string Location { get; set; }
        public bool? Flag { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
