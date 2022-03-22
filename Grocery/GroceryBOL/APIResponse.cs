using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryBOL
{
    public class APIResponce
    {

        public string ResetToken { get; set; }
        public string Status { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
     
        public dynamic data { get; set; }
    }
    }
