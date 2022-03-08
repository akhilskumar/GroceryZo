using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utilities.CommonEnums;

namespace Utilities
{
    public class GroceryException : Exception
    {
        public ExceptionCategory ExceptionCategoryObj { get; set; }
        public ExceptionResponceStatus ResponceStatusObj { get; set; }
        public Exception ExceptionObj { get; set; }
        public GroceryException(ExceptionCategory exceptionCategory, ExceptionResponceStatus responceStatus, Exception exception)
        {
            ExceptionCategoryObj = exceptionCategory;
            ResponceStatusObj = responceStatus;
            ExceptionObj = exception;
        }
    }
}
