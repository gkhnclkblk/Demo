using Demo.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DTO.DTOs.CategoryDtos
{
    public class CategoryAddDto : IDto
    {
        public string Name { get; set; }
    }
}
