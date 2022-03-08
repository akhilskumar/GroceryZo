using System;
using System.Collections.Generic;

#nullable disable

namespace GroceryBOL.Entities
{
    public  class CustomerDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }

        public  List<AddressDTO> Addresses { get; set; }
        public  List<OrderDTO> Orders { get; set; }
    }
}
