using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public enum ProductCategory
    {
        Food,
        Clothing,
        Electronics,
        Furniture
    }
    public class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public ProductCategory Category { get; set; }

    }
}
