using Demo.Business.Interfaces;
using Demo.DataAccess.Interfaces;
using Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Business.Concrete
{
    public class ProductManager : GenericManager<Product>,IProductService
    {
        private readonly IGenericDal<Product> _genericDal;
        private readonly IProductDal _productDal;

        public ProductManager(IGenericDal<Product> genericDal,IProductDal productDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _productDal = productDal;
        }

        public async Task<List<Product>> GetWithCategoryAsync()
        {
            return await _productDal.GetWithCategoryAsync();
        }
    }
}
