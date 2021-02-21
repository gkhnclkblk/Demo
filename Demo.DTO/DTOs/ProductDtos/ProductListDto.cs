using Demo.DTO.DTOs.CategoryDtos;
using Demo.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DTO.DTOs.ProductDtos
{
    public class ProductListDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryListDto Category { get; set; }
    }
}
