using GroceryBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryBLL
{
    public interface IProductCategoryBLL
    {
        ProductCategoryDTO GetById(int Id);
    }
}
