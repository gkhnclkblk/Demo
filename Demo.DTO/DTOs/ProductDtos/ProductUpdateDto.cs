using Demo.DTO.DTOs.CategoryDtos;
using Demo.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DTO.DTOs.ProductDtos
{
    public class ProductUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public List<CategoryListDto> Categories { get; set; }
    }
}
