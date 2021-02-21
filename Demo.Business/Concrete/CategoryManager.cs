using Demo.Business.Interfaces;
using Demo.DataAccess.Interfaces;
using Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Business.Concrete
{
    public class CategoryManager : GenericManager<Category>,ICategoryService
    {
        private readonly IGenericDal<Category> _genericDal;

        public CategoryManager(IGenericDal<Category> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}
