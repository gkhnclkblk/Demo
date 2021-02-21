using Demo.DataAccess.Concrete.EntityFramework.Context;
using Demo.DataAccess.Interfaces;
using Demo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfProductRepository : EfGenericRepository<Product>,IProductDal
    {
        private readonly DemoContext _context;

        public EfProductRepository(DemoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetWithCategoryAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
