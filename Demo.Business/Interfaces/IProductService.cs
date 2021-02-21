using Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Business.Interfaces
{
    public interface IProductService : IGenericService<Product>
    {
        Task<List<Product>> GetWithCategoryAsync();
    }
}
