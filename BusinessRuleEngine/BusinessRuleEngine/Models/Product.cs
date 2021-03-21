using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
