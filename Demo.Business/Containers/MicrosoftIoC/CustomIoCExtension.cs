using Demo.Business.Concrete;
using Demo.Business.Interfaces;
using Demo.DataAccess.Concrete.EntityFramework.Context;
using Demo.DataAccess.Concrete.EntityFramework.Repositories;
using Demo.DataAccess.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension 
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<DemoContext>();

            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped<ICategoryDal, EfCategoryRepository>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IProductDal, EfProductRepository>();
            services.AddScoped<IProductService, ProductManager>();
        }
    }
}
