using GroceryBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryDAL
{
    public interface IProductCategoryDAL
    {
        ProductCategoryDTO GetById(int Id);
    }
}
