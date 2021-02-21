using AutoMapper;
using Demo.DTO.DTOs.CategoryDtos;
using Demo.DTO.DTOs.ProductDtos;
using Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.UI.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CategoryListDto, Category>();
            CreateMap<Category, CategoryListDto>();
            CreateMap<CategoryAddDto, Category>();
            CreateMap<Category, CategoryAddDto>();
            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();
            CreateMap<ProductListDto, Product>();
            CreateMap<Product, ProductListDto>();
            CreateMap<ProductAddDto, Product>();
            CreateMap<Product, ProductAddDto>();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductUpdateDto>();
        }
    }
}
