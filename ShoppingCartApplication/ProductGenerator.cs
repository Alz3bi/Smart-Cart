using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShoppingCartApplication
{
    
    public class ProductGenerator
    {
        private static Random _random = new Random();
        public static Product GenerateRandomProduct()
        {
            ProductCategory[] categories = (ProductCategory[])Enum.GetValues(typeof(ProductCategory));
            Product product = new Product
            {
                Category = categories[_random.Next(categories.Length)],
                Name = "Product " + _random.Next(1, 101),
                Price = _random.Next(1, 101)
            };
            return product;
        }
        public static Product GenerateClothingProduct()
        {

           return new Product
            {
                Category = ProductCategory.Clothing,
                Name = "ClothingProduct " + _random.Next(1, 101),
                Price = _random.Next(1, 101)
            };
        }
        public static Product GenerateGroceryProduct()
        {
            return new Product
            {
                Category = ProductCategory.Food,
                Name = "GroceryProduct " + _random.Next(1, 101),
                Price = _random.Next(1, 101)
            };
        }
    }
}
