using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryBOL.Entities
{
    public class APIResponce
    {

        public string ResetToken { get; set; }
        public string Status { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public int UserRole { get; set; }
        public decimal GrandTotal { get; set; }

        public Guid? vreceipt { get; set; }
        public List<PincodeDTO> Pincodes { get; set; }
        public bool IsSuccess { get; set; }

        public PincodeDTO pincodeDTO;
    }
    }
