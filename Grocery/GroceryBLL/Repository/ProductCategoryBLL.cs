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

        public ProductCategoryDTO Add(ProductCategoryDTO ModelDTO)
        {
            try
            {
                return _productCategoryDAL.Add(ModelDTO);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                return (_productCategoryDAL.Delete(Id));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<ProductCategoryDTO> GetAll()
        {

            try
            {
                return _productCategoryDAL.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public ProductCategoryDTO Update(ProductCategoryDTO pincodeDTO)
        {

            try
            {
                return _productCategoryDAL.Update(pincodeDTO);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
