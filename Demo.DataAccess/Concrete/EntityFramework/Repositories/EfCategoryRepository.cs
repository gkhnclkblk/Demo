using Demo.DataAccess.Concrete.EntityFramework.Context;
using Demo.DataAccess.Interfaces;
using Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCategoryRepository : EfGenericRepository<Category>,ICategoryDal
    {
        private readonly DemoContext _context;

        public EfCategoryRepository(DemoContext context) : base(context)
        {
            _context = context;
        }
    }
}
