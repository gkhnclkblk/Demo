using Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Interfaces
{
    public interface IProductDal : IGenericDal<Product>
    {
        Task<List<Product>> GetWithCategoryAsync();
    }
}
