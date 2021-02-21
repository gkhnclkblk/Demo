using Demo.DTO.DTOs.CategoryDtos;
using Demo.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DTO.DTOs.ProductDtos
{
    public class ProductAddDto : IDto
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}
