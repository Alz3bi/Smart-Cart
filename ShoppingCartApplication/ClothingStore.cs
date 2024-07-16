using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ClothingStore
    {
        public List<Product> ClothStoreProducts { get; set; }
        public ClothingStore()
        {
            ClothStoreProducts = new List<Product>
            {
                ProductGenerator.GenerateClothingProduct(),
                ProductGenerator.GenerateClothingProduct(),
                ProductGenerator.GenerateClothingProduct()
            };
        }
        public void GetProducts(ShoppingCart cart)
        {
            if (ClothStoreProducts.Count == 0)
            {
                Console.WriteLine("No products available in the store");
            }
            int index = 1;
            foreach (Product product in ClothStoreProducts)
            {
                Console.WriteLine($"{index}. {product.Name} - ${product.Price}");
                index++;
            }
            Console.WriteLine("Enter the number of the product you want to add to the cart:");
            if (int.TryParse(Console.ReadLine(), out int productNumber) && productNumber >= 1 && productNumber <= ClothStoreProducts.Count)
            {
                var selectedProduct = ClothStoreProducts[productNumber - 1];
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
