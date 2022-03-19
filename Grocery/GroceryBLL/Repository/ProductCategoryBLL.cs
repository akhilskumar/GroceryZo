using GroceryBLL;
using GroceryBOL;
using GroceryDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryBLL
{
    public class ProductCategoryBLL : IProductCategoryBLL
    {
        private IProductCategoryDAL _productCategoryDAL;    

        public ProductCategoryBLL(IProductCategoryDAL productCategoryDAL)
        {
            _productCategoryDAL = productCategoryDAL;
        }

        public ProductCategoryDTO GetById(int Id)
        {
            try
            {
                return _productCategoryDAL.GetById(Id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
