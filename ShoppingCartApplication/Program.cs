namespace ShoppingCartApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the shopping cart application");
            ShoppingCart cart = new ShoppingCart();
            GroceryStore groceryStore = new GroceryStore();
            ClothingStore clothingStore = new ClothingStore();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. View products in the grocery store");
                Console.WriteLine("2. View products in the clothing store");
                Console.WriteLine("3. View cart");
                Console.WriteLine("4. Calculate total");
                Console.WriteLine("5. Exit");
                string? input = Console.ReadLine();
                if (input == null) continue;
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Grocery Store Products:");
                        groceryStore.GetProducts(cart);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Clothing Store Products:");
                        clothingStore.GetProducts(cart);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case "3":
                        while (true)
                        {
                            Console.Clear();
                            cart.ViewCart();
                            if (cart.Cart.Count == 0)
                            {
                                break;
                            }
                            Console.WriteLine("Do you want to remove a product from your cart?(yes/no)");
                            string stringInput = Console.ReadLine()?.Trim().ToLower() ?? "";
                            if (stringInput == "yes")
                            {
                                Console.WriteLine("Enter the number of the product you want to remove from the cart: ");
                                if (int.TryParse(Console.ReadLine(), out int productNumber) && productNumber >= 1 && productNumber <= cart.Cart.Count)
                                {
                                    var selectedProduct = cart.Cart[productNumber - 1];
                                    cart.RemoveProduct(selectedProduct);
                                    Console.WriteLine($"{selectedProduct.Name} has been removed from the cart.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid selection.");
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        double total = cart.CalculateTotal();
                        Console.WriteLine($"Total: ${total}");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case "5":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid option");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
