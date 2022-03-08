using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryBOL.Entities
{
    public  class Pincode
    {

        public int Id { get; set; }
        public string Pincode1 { get; set; }
        public decimal? DeliveryCharge { get; set; }
        public string Location { get; set; }
        public bool? Flag { get; set; }

        public  List<Address> Addresses { get; set; }
    }
}
