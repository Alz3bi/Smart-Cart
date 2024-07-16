using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ShoppingCart
    {
        public List<Product> Cart { get; set; } = new List<Product>();
        public void AddProduct(Product product)
        {
            Cart.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            Cart.Remove(product);
        }
        public void ViewCart()
        {
            if (Cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            int index = 0;
            foreach (Product product in Cart) {
                Console.WriteLine($"{index + 1}. {product.Name} - ${product.Price}");
                index++;
            }
            Console.WriteLine("Total: $" + CalculateTotal());
        }
        public double CalculateTotal()
        {
            double total = 0;
            foreach (Product product in Cart)
            {
                total += product.Price;
            }
            return total;
        }
    }
}
