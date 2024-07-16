using ShoppingCartApplication;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddProductToCart()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product
            {
                Name = "TestProduct",
                Price = 10,
                Category = ProductCategory.Clothing
            };
            // Act
            cart.AddProduct(product);
            // Assert
            Assert.Contains(product, cart.Cart);
        }
        [Fact]
        public void RemoveProductFromCart()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product
            {
                Name = "TestProduct",
                Price = 10,
                Category = ProductCategory.Clothing
            };
            // Act
            cart.AddProduct(product);
            cart.RemoveProduct(product);
            // Assert
            Assert.DoesNotContain(product, cart.Cart);
        }
        [Fact]
        public void TotalCostTest()
        {
            ShoppingCart cart = new ShoppingCart();
            Product product1 = new Product
            {
                Name = "TestProduct1",
                Price = 10,
                Category = ProductCategory.Clothing
            };
            cart.AddProduct(product1);
            Product product2 = new Product
            {
                Name = "TestProduct2",
                Price = 20,
                Category = ProductCategory.Clothing
            };
            cart.AddProduct(product2);
            Assert.Equal(30, cart.CalculateTotal());
        }
    }
}