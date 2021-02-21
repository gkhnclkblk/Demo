using Demo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Entities.Concrete
{
    public class Product : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
