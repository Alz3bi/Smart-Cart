using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class GroceryStore
    {
        public List<Product> GroceryStoreProducts { get; set; }
        public GroceryStore()
        {
            GroceryStoreProducts = new List<Product>
            {
                ProductGenerator.GenerateGroceryProduct(),
                ProductGenerator.GenerateGroceryProduct(),
                ProductGenerator.GenerateGroceryProduct()
            };
        }
        public void GetProducts(ShoppingCart cart)
        {
            if (GroceryStoreProducts.Count == 0)
            {
                Console.WriteLine("No products available in the store");
            }
            int index = 1;
            foreach (Product product in GroceryStoreProducts)
            {
                Console.WriteLine($"{index}. {product.Name} - ${product.Price}");
                index++;
            }
            Console.WriteLine("Enter the number of the product you want to add to the cart:");
            if (int.TryParse(Console.ReadLine(), out int productNumber) && productNumber >= 1 && productNumber <= GroceryStoreProducts.Count)
            {
                var selectedProduct = GroceryStoreProducts[productNumber - 1];
                cart.AddProduct(selectedProduct);
                Console.WriteLine($"{selectedProduct.Name} has been added to the cart.");
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
    }
}
