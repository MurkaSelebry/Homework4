using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2410
{
    public class Product
    {
        public Product(string name, string country, decimal price)
        {
            Name = name;
            Country = country;
            Price = price;
        }

        public string Name { get; set; }
        public string Country { get; set; }
        public decimal Price { get; set; }
        
    }
}
