# Smart-Cart-Application

The Smart Cart Application is a versatile shopping cart system designed to simulate an online shopping experience. It supports multiple product categories, including groceries and clothing, with the capability to generate random products for a dynamic shopping experience.

## Features

- **Dynamic Product Generation:** Utilizes a random generator to create a variety of products in different categories, making each shopping experience unique.
- **Support for Multiple Categories:** Currently supports two main product categories:
  - **Food (Groceries)**
  - **Clothing**
- **Random Product Selection:** Offers a feature to generate a random product, enhancing the unpredictability and fun of the shopping experience.

## Getting Started

To get started with the Smart Cart Application, clone this repository to your local machine. Ensure you have a suitable .NET development environment set up, such as Visual Studio or Visual Studio Code.

### Prerequisites

- .NET SDK (compatible with .NET Core 3.1 or later)
- An IDE like Visual Studio, Visual Studio Code, or Rider

### Running the Application

1. Open the solution file (`ShoppingCartApplication.sln`) in your IDE.
2. Build the solution to restore any NuGet packages and compile the application.
3. Run the application. This can typically be done by pressing `F5` or selecting "Run" from your IDE.

## How It Works

The application generates products dynamically through the `ProductGenerator` class, which creates products with random names and prices within predefined categories. These products are then added to specific stores:

- `GroceryStore` for food-related items.
- `ClothingStore` for clothing items.

Users can interact with the application to add products to their cart, view cart contents, and simulate the checkout process.

## Contributing

Contributions to the Smart Cart Application are welcome. Please feel free to fork the repository, make your changes, and submit a pull request.

## License

This project is licensed under the MIT License - see the LICENSE file for details.
