using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryBOL
{
    public  class AddressDTO
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string Address1 { get; set; }
        public string Landmark { get; set; }
        public int? Pincodeid { get; set; }

        public  CustomerDTO Customer { get; set; }
        public  PincodeDTO Pincode { get; set; }
    }
}
