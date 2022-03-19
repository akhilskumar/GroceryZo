using System;
using GroceryBOL;
using System.Linq;

namespace GroceryDAL
{
    public class ProductCategoryDAL:IProductCategoryDAL
    {
        private readonly GroceryZoContext _context;

        public ProductCategoryDAL(GroceryZoContext context)
        {
            _context = context;
        }
        public ProductCategoryDTO GetById(int Id)
        {
            try
            {
                ProductCategory productCategory = _context.ProductCategories.Where(x => x.Id == Id && x.Flag == true).FirstOrDefault();
                if (productCategory == null) return new ProductCategoryDTO();
                ProductCategoryDTO productCategoryDTO = new ProductCategoryDTO();
                CopyTo(productCategoryDTO, productCategory);
                return productCategoryDTO;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        ProductCategoryDTO CopyTo(ProductCategoryDTO destination, ProductCategory source)
        {
            if (source != null)
            {
                destination.Id = source.Id;
                destination.Flag = source.Flag;
            }
            return destination;

        }
        ProductCategory CopyFrom(ProductCategoryDTO source, ProductCategory destination)
        {
            destination.Id = source.Id;
            destination.Flag = source.Flag;
            return destination;
        }
    }
}
