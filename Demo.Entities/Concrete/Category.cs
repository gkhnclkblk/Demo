using Demo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Entities.Concrete
{
    public class Category : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
