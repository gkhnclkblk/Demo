using Demo.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DTO.DTOs.CategoryDtos
{
    public class CategoryUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
